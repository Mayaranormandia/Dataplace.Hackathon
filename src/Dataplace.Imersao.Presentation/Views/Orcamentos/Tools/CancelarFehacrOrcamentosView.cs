﻿using Dataplace.Core.Application.Services.Results;
using Dataplace.Core.Comunications;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Core.Domain.Notifications;
using Dataplace.Core.Infra.CrossCutting.EventAggregator.Contracts;
using Dataplace.Core.win.Controls.Extensions;
using Dataplace.Core.win.Controls.List.Behaviors;
using Dataplace.Core.win.Controls.List.Behaviors.Contracts;
using Dataplace.Core.win.Controls.List.Configurations;
using Dataplace.Core.win.Views;
using Dataplace.Core.win.Views.Extensions;
using Dataplace.Imersao.Core.Application.Clientes.ViewModels;
using Dataplace.Imersao.Core.Application.Orcamentos.Commands;
using Dataplace.Imersao.Core.Application.Orcamentos.Queries;
using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;
using Dataplace.Imersao.Core.Domain.Orcamentos.Enums;
using Dataplace.Imersao.Presentation.Views.Orcamentos.Messages;
using Dataplace.Imersao.Presentation.Views.Providers;
using dpLibrary05;
using dpLibrary05.Infrastructure.Helpers;
using dpLibrary05.Infrastructure.Helpers.Permission;
using dpLibrary05.Infrastructure.Helpers.SimpleSqlBulk;
using dpLibrary05.SymphonyInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataplace.Imersao.Presentation.Views.Orcamentos.Tools
{
    public partial class CancelarFehacrOrcamentosView : dpLibrary05.Infrastructure.UserControls.ucSymGen_ToolDialog
    {
        #region fields
        private DateTime _startDate;
        private DateTime _endDate;
        private const int _itemSeg = 467;
        private IListBehavior<OrcamentoViewModel, OrcamentoQuery> _orcamentoList;
        private readonly IServiceProvider _serviceProvider;
        private readonly IEventAggregator _eventAggregator;
        private IList<ClienteViewModel> _clientesSelecionados;
        #endregion

        #region constructors
        public CancelarFehacrOrcamentosView(
            IServiceProvider serviceProvider,
            IEventAggregator eventAggregator)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _eventAggregator = eventAggregator;

            _orcamentoList = new C1TrueDBGridListBehavior<OrcamentoViewModel, OrcamentoQuery>(gridOrcamento)
                .WithConfiguration(GetConfiguration());

            this.ToolConfiguration += CancelamentoOrcamentoView_ToolConfiguration;
            this.BeforeProcess += CancelamentoOrcamentoView_BeforeProcess;
            this.Process += CancelamentoOrcamentoView_Process;
            this.AfterProcess += CancelamentoOrcamentoView_AfterProcess;


            this.tsiMarcar.Click += TsiMarcarTodos_Click;
            this.tsiDesmarca.Click += TsiDesmarcarTodos_Click;
            this.tsiExcel.Click += TsiExportarGridParaExcel_Click;

            this.KeyDown += CancelamentoOrcamentoView_KeyDown;


            this.chkAberto.Click += chk_Click;
            this.chkFechado.Click += chk_Click;
            this.chkCancelado.Click += chk_Click;


            // pegar evento clique das opçoes
            this.optCancelar.Click += opt_Click;
            this.optFechar.Click += opt_Click;


            _startDate = DateTime.Today.AddMonths(-1);
            _endDate = DateTime.Today;
            rangeDate.Date1.Value = _startDate;
            rangeDate.Date2.Value = _endDate;


            // pegar key down de um controle
            // dtpPrevisaoEntrega.KeyDown += Dtp_KeyDown;


            dpVendedor.SearchObject = GetSearchVendedor();
            //dpUsuario.SearchObject = Common.PedidoSearch.find_usuario();
            dpCliente.SearchObject = Common.PedidoSearch.find_cliente(new clsSymSearch.SearchArgs()
            {
                Fields = new List<clsSymInterfaceSearchField>() {
                    new clsSymInterfaceSearchField() { SearchIndex=2, VisibleEdit =false },
                    new clsSymInterfaceSearchField() { SearchIndex=4, VisibleEdit =false }
                }
            });




            var clienteViewProvicer = dpLibrary05.BootStrapper.Container.GetViewProvider<SelectableListView, ClienteListViewProvider>();
            chkSelCliente.ConfigureSelector(clienteViewProvicer, itens => {
                _clientesSelecionados = itens.ToList();
            });

            // rotina para validar status do controle
            //  desabilitar ou habilitar algun componente em tela
            //  deixar invisível ou algo assim
            VerificarStatusControles();

        }
        

        #endregion

        #region tool events

        private TipoAcaoEnum _tipoAcao;
        private enum TipoAcaoEnum
        {
            CancelarOrcamento,
            FecharOrcamento,
            ReabrirOrcamento
        }
        private void CancelamentoOrcamentoView_ToolConfiguration(object sender, ToolConfigurationEventArgs e)
        {
            // definições iniciais do projeto
            // item seguraça
            // engine code
            this.Text = "Cancelar/Fechar orçamentos em aberto";
            e.SecurityIdList.Add(_itemSeg);
            e.CancelButtonVisisble = true;
        }
        private void CancelamentoOrcamentoView_BeforeProcess(object sender, BeforeProcessEventArgs e)
        {
            // defaul 
            _tipoAcao = TipoAcaoEnum.CancelarOrcamento;

            if (optCancelar.Checked)
                _tipoAcao = TipoAcaoEnum.CancelarOrcamento;

            if (optFechar.Checked)
                _tipoAcao = TipoAcaoEnum.FecharOrcamento;

            if (opreabrir.Checked)
                _tipoAcao = TipoAcaoEnum.ReabrirOrcamento;



            var permission = PermissionControl.Factory().ValidatePermission(_itemSeg, dpLibrary05.mGenerico.PermissionEnum.Execute);
            if (!permission.IsAuthorized())
            {
                e.Cancel = true;
                this.Message.Info(permission.BuildMessage());
                return;
            }

            var itensSelecionados = _orcamentoList.GetCheckedItems();
            if (itensSelecionados.Count() == 0)
            {
                e.Cancel = true;
                this.Message.Info(53727.ToMessage());
                return;
            }


            e.Parameter.Items.Add("acao", _tipoAcao);
            e.Parameter.Items.Add("itensSelecionados", itensSelecionados);
        }
        private async void CancelamentoOrcamentoView_Process(object sender, ProcessEventArgs e)
        {

            var acao = (TipoAcaoEnum)e.Parameter.Items.get_Item("acao").Value;
            var itensSelecionados = (IEnumerable<OrcamentoViewModel>)e.Parameter.Items.get_Item("itensSelecionados").Value;

            e.ProgressMinimum = 0;
            e.ProgressMaximum = itensSelecionados.Count();
            e.BeginProcess();

            // um a um
            foreach (var item in itensSelecionados)
            {

                switch (acao)
                {
                    case TipoAcaoEnum.CancelarOrcamento:
                        await CancelarOrcamento(item);
                        // registrar log na parte de detalhes
                        e.LogBuilder.Items.Add($"Orçamento {item.NumOrcamento} cancelado", dpLibrary05.Infrastructure.Helpers.LogBuilder.LogTypeEnum.Information);
                        break;
                    case TipoAcaoEnum.FecharOrcamento:
                        await FecharOrcamento(item);
                        // registrar log na parte de detalhes
                        e.LogBuilder.Items.Add($"Orçamento {item.NumOrcamento} fechado", dpLibrary05.Infrastructure.Helpers.LogBuilder.LogTypeEnum.Information);
                        break;
                    case TipoAcaoEnum.ReabrirOrcamento:
                        await ReabrirOrcamento(item);
                        // registrar log na parte de detalhes
                        e.LogBuilder.Items.Add($"Orçamento {item.NumOrcamento} reaberto", dpLibrary05.Infrastructure.Helpers.LogBuilder.LogTypeEnum.Information);
                        break;
                    default:
                        break;
                }



                // permitir cancelamento 
                if (e.CancellationRequested)
                    break;

                e.ProgressValue += 1;
            }

            e.EndProcess();
        }
        private void CancelamentoOrcamentoView_AfterProcess(object sender, AfterProcessEventArgs e)
        {
            // exemplo de message box no final do processo
            // this.Message.Info("MENSAGEM FINAL");


            //  desmarcar todos itens no final do processo
            // _orcamentoList.ChangeCheckState(false);
        }

        // teclas de atalho
        private  void CancelamentoOrcamentoView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadList();
            }

            if (e.Control && e.Shift && e.KeyCode == Keys.M)
            {
                _orcamentoList.ChangeCheckState(true);
            }

            if (e.Control && e.Shift && e.KeyCode == Keys.D)
            {
                _orcamentoList.ChangeCheckState(false);
            }

        }

        #endregion

        #region list events

        // exemplos conf list
        //  configuration.AllowFilter();  >> permite filtro
        //  configuration.AllowSort(); >> habilita ordenação
        //  configuration.Ignore(x => x.CdVendedor); >> ignora 
        // 


        // adicionar botão (nesse caso seta azul)
        // configuration.Property(x => x.NumOrcamento)
        //    .HasButton(dpLibrary05.mGenerico.oImageList.imgList16.Images[dpLibrary05.mGenerico.oImageList.SETA_AZUL_PEQ], (sender, e) => {
        //        var item = (OrcamentoViewModel)sender;
        //        _eventAggregator.PublishEvent(new OrcamentoSetaAzulClick(item.NumOrcamento));
        //    });



        // exemplode de destaque das linhas
        //configuration.HasHighlight(x => {
        //    // destacando somente cor da fonte
        //    x.Add(orcamento => orcamento.StEntrega == "2", System.Drawing.Color.DarkOrange);

        //    // exemplo para destacar a cor da fonte e cor de fundo da linha
        //    x.Add(orcamento => orcamento.StEntrega == "2", new ViewModePropertyHighlightStyle()
        //        .WithBackColor(System.Drawing.Color.DarkOrange)
        //        .WithForeColor(System.Drawing.Color.White));
        //});


        // exemplo de tradução para valores na coluna
        //configuration.Property(x => x.StAlgumaCoisa)
        //   .HasCaption("St. validade")
        //   .HasValueItems(x =>
        //   {
        //       x.Add("0", "texto para equivalente ao valor 0");
        //       x.Add("1", "texto para equivalente ao valor 1");
        //       x.Add("2", "texto para equivalente ao valor 2");
        //   });

        private ViewModelListBuilder<OrcamentoViewModel> GetConfiguration()
        {
            var configuration = new ViewModelListBuilder<OrcamentoViewModel>();
            configuration.AllowSort();


            configuration.HasHighlight(x => {
                x.Add(orcamento => orcamento.Situacao == Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Cancelado.ToDataValue(), System.Drawing.Color.Red);
            });

            // define rotina para obter os filtros que vão ser aplicados na query
            configuration.WithQuery<OrcamentoQuery>(() => GetQuery());

            configuration.Ignore(x => x.CdEmpresa);
            configuration.Ignore(x => x.CdFilial);
            configuration.Ignore(x => x.SqTabela);
            configuration.Ignore(x => x.CdTabela);
            //configuration.Ignore(x => x.CdVendedor);
            //configuration.Ignore(x => x.DiasValidade);
            configuration.Ignore(x => x.DataValidade);
            configuration.Ignore(x => x.TotalItens);

            configuration.Property(x => x.Situacao)
                  .HasMinWidth(100)
                  .HasCaption("Situação")
                  .HasValueItems(x =>
                  {
                      x.Add(OrcamentoStatusEnum.Aberto.ToDataValue(), 3469.ToMessage());
                      x.Add(OrcamentoStatusEnum.Fechado.ToDataValue(), 3846.ToMessage());
                      x.Add(OrcamentoStatusEnum.Cancelado.ToDataValue(), 3485.ToMessage());
                  });

            configuration.Property(x => x.CdCliente)
               .HasMinWidth(50)
               .HasCaption("Cliente");

            configuration.Property(x => x.DsCliente)
                .HasMinWidth(200)
                .HasCaption("Razão");

            configuration.Property(x => x.DtOrcamento)
                .HasMinWidth(80)
                .HasCaption("Data")
                .HasFormat("d");

            configuration.Property(x => x.VlTotal)
                .HasMinWidth(80)
                .HasCaption("Total")
                .HasFormat("n");


            configuration.Property(x => x.DtFechamento)
                .HasMinWidth(80)
                .HasCaption("Fechamento")
                .HasFormat("d");

            return configuration;
        }

        private OrcamentoQuery GetQuery()
        {
            var situacaoList = new List<Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum>();
            if (chkAberto.Checked)
                situacaoList.Add(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Aberto);
            if (chkFechado.Checked)
                situacaoList.Add(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Fechado);
            if (chkCancelado.Checked)
                situacaoList.Add(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Cancelado);


            string cdCliente = dpCliente.GetValue()?.ToString();
            string Vendedor = dpVendedor.GetValue()?.ToString();
            int numOrcamento = (int)Convert.ToInt64(dpiNumOrcamento.GetValue()?.ToString().Length == 0 ? 0 : dpiNumOrcamento.GetValue());



            DateTime? dtInicio = null;
            DateTime? dtFim = null;
            if (rangeDate.Date1.Value is DateTime d)
                dtInicio = d;

            if (rangeDate.Date2.Value is DateTime d2)
                dtFim = d2;


            var cdClienteList = _clientesSelecionados?.Select(x => x.CdCliente).ToList();
            var vendedor = dpVendedor.GetValue().ToString();   


            var query = new OrcamentoQuery() { SituacaoList = situacaoList, 
                DtInicio = dtInicio, 
                DtFim = dtFim, 
                CdCliente = cdCliente, 
                NumOrcamento = numOrcamento ,
                Vendedor = vendedor
            };
            return query;
        }

        private async void LoadList()
        {
            await _orcamentoList.LoadAsync();
            if (!_orcamentoList.GetAllItems().Any())
            {
                MessageForm.Info("Nenhum registro encontrado!");
            }

        }

        #endregion

        #region contol events

        private void TsiExportarGridParaExcel_Click(object sender, EventArgs e)
        {
            clsOffice.ExportTrueDbGridToExcel(gridOrcamento, xlsOption.xlsSaveAndOpen);
        }
        private void TsiDesmarcarTodos_Click(object sender, EventArgs e)
        {
            _orcamentoList.ChangeCheckState(false);
        }
        private void TsiMarcarTodos_Click(object sender, EventArgs e)
        {
            _orcamentoList.ChangeCheckState(true);
        }

        private  void BtnCarregar_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private  void chk_Click(object sender, EventArgs e)
        {
            LoadList();
        }
        private void opt_Click(object sender, EventArgs e)
        {
            VerificarStatusControles();
        }


        private void VerificarStatusControles() {

            // exemplo pra deixar componente intaivo dependendo de uma opão
            // dtpPrevisaoEntrega.Enabled = optAtribuirPevisaoEntrega.Checked;

        }
        #endregion

        #region processamentos
        private async Task CancelarOrcamento(OrcamentoViewModel item)
        {

            using (var scope = dpLibrary05.Infrastructure.ServiceLocator.ServiceLocatorScoped.Factory())
            {

                var command = new CancelarOrcamentoCommand(item);
                var mediator = scope.Container.GetInstance<IMediatorHandler>();

                var notifications = scope.Container.GetInstance<INotificationHandler<DomainNotification>>();
                await mediator.SendCommand(command);

                item.Result = Result.ResultFactory.New(notifications.GetNotifications());
                if (item.Result.Success)
                {
                    item.Situacao = Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Cancelado.ToDataValue();
                }

            }

        }

        private async Task FecharOrcamento(OrcamentoViewModel item)
        {

            using (var scope = dpLibrary05.Infrastructure.ServiceLocator.ServiceLocatorScoped.Factory())
            {

                var command = new FecharOrcamentoCommand(item);
                var mediator = scope.Container.GetInstance<IMediatorHandler>();

                var notifications = scope.Container.GetInstance<INotificationHandler<DomainNotification>>();
                await mediator.SendCommand(command);

                item.Result = Result.ResultFactory.New(notifications.GetNotifications());
                if (item.Result.Success)
                {
                    item.Situacao = Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Fechado.ToDataValue();
                    item.DtFechamento = DateTime.Now.Date;
                }

            }

        }

        #endregion

        private async Task ReabrirOrcamento(OrcamentoViewModel item)
        {

            using (var scope = dpLibrary05.Infrastructure.ServiceLocator.ServiceLocatorScoped.Factory())
            {

                var command = new ReabrirOrcamentoCommand(item);
                var mediator = scope.Container.GetInstance<IMediatorHandler>();

                var notifications = scope.Container.GetInstance<INotificationHandler<DomainNotification>>();
                await mediator.SendCommand(command);

                item.Result = Result.ResultFactory.New(notifications.GetNotifications());
                if (item.Result.Success)
                {
                    item.Situacao = Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Aberto.ToDataValue();
                    item.DtFechamento = null;
                }

            }

        }
        private void CancelarFehacrOrcamentosView_Load(object sender, EventArgs e)
        {

        }
        private void txtNumOrcamento_Paint(object sender, PaintEventArgs e)
        {

        }
        #region 
        private ISymInterfaceSearch _searchVendedor;

        private ISymInterfaceSearch GetSearchVendedor()
        {
            if (_searchVendedor != null)
                return _searchVendedor;

            var prmVendendor = new dpLibrary05.Infrastructure.Helpers.clsSymSearch.SearchArgs()
            {
                Fields = new List<dpLibrary05.SymphonyInterface.clsSymInterfaceSearchField>()
                {
                    new dpLibrary05.SymphonyInterface.clsSymInterfaceSearchField(){
                        SearchIndex = 2,
                        VisibleEdit = false
                    },
                    new dpLibrary05.SymphonyInterface.clsSymInterfaceSearchField(){
                        SearchIndex = 3,
                        VisibleEdit = false
                    },
                    new dpLibrary05.SymphonyInterface.clsSymInterfaceSearchField(){
                        SearchIndex = 4,
                        VisibleEdit = false
                    }
                }
            };
            _searchVendedor = dpLibrary05.Infrastructure.Helpers.clsSymSearch.find_vendedor(prmVendendor);

            return _searchVendedor;



        }
        #endregion
    }
}

