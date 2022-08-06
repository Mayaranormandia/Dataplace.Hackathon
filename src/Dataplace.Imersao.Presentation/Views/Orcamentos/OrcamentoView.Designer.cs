namespace Dataplace.Imersao.Presentation.Views.Orcamentos
{
    partial class OrcamentoView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabMain = new C1.Win.C1Command.C1DockingTab();
            this.tpItens = new C1.Win.C1Command.C1DockingTabPage();
            this.picObservacoes = new System.Windows.Forms.PictureBox();
            this.dpiData = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiFechamento = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiSituacao = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiVendedor = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiCliente = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiNumOrcamento = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiValidadeData = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiValidadeDias = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiTotal = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.tpfinaceiro = new C1.Win.C1Command.C1DockingTabPage();
            this.txtuser = new dpLibrary05.Infrastructure.Controls.DPInput();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picObservacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tpItens);
            this.tabMain.Controls.Add(this.tpfinaceiro);
            this.tabMain.Location = new System.Drawing.Point(0, 88);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 1;
            this.tabMain.Size = new System.Drawing.Size(1003, 411);
            this.tabMain.TabIndex = 8;
            this.tabMain.TabsSpacing = 5;
            // 
            // tpItens
            // 
            this.tpItens.Location = new System.Drawing.Point(1, 24);
            this.tpItens.Name = "tpItens";
            this.tpItens.Size = new System.Drawing.Size(1001, 386);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens";
            // 
            // picObservacoes
            // 
            this.picObservacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picObservacoes.Location = new System.Drawing.Point(435, 19);
            this.picObservacoes.Name = "picObservacoes";
            this.picObservacoes.Size = new System.Drawing.Size(20, 20);
            this.picObservacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObservacoes.TabIndex = 112;
            this.picObservacoes.TabStop = false;
            // 
            // dpiData
            // 
            this.dpiData.Active = false;
            this.dpiData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpiData.DataSource = null;
            this.dpiData.DP_Caption = "3845";
            this.dpiData.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiData.DP_DataField = null;
            this.dpiData.DP_FilterMemo = false;
            this.dpiData.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.DateInput;
            this.dpiData.DP_Length = 0;
            this.dpiData.DP_Maximum = null;
            this.dpiData.DP_Minimum = null;
            this.dpiData.DP_NumericPrecision = 0;
            this.dpiData.EditMask = "00/00/0000";
            this.dpiData.EditMaskUpdate = true;
            this.dpiData.FindMode = false;
            this.dpiData.InterfaceField = null;
            this.dpiData.IsReadonly = true;
            this.dpiData.Location = new System.Drawing.Point(461, 4);
            this.dpiData.Multiline = false;
            this.dpiData.Name = "dpiData";
            this.dpiData.SearchObject = null;
            this.dpiData.SettingValue = false;
            this.dpiData.Size = new System.Drawing.Size(96, 35);
            this.dpiData.TabIndex = 2;
            // 
            // dpiFechamento
            // 
            this.dpiFechamento.Active = false;
            this.dpiFechamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpiFechamento.DataSource = null;
            this.dpiFechamento.DP_Caption = "3136";
            this.dpiFechamento.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiFechamento.DP_DataField = null;
            this.dpiFechamento.DP_FilterMemo = false;
            this.dpiFechamento.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.DateInput;
            this.dpiFechamento.DP_Length = 0;
            this.dpiFechamento.DP_Maximum = null;
            this.dpiFechamento.DP_Minimum = null;
            this.dpiFechamento.DP_NumericPrecision = 0;
            this.dpiFechamento.EditMask = "00/00/0000";
            this.dpiFechamento.EditMaskUpdate = true;
            this.dpiFechamento.FindMode = false;
            this.dpiFechamento.InterfaceField = null;
            this.dpiFechamento.IsReadonly = true;
            this.dpiFechamento.Location = new System.Drawing.Point(563, 4);
            this.dpiFechamento.Multiline = false;
            this.dpiFechamento.Name = "dpiFechamento";
            this.dpiFechamento.SearchObject = null;
            this.dpiFechamento.SettingValue = false;
            this.dpiFechamento.Size = new System.Drawing.Size(96, 35);
            this.dpiFechamento.TabIndex = 3;
            // 
            // dpiSituacao
            // 
            this.dpiSituacao.Active = false;
            this.dpiSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpiSituacao.DataSource = null;
            this.dpiSituacao.DP_Caption = "2805";
            this.dpiSituacao.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiSituacao.DP_DataField = null;
            this.dpiSituacao.DP_FilterMemo = false;
            this.dpiSituacao.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.SelectedValueInput;
            this.dpiSituacao.DP_Length = 0;
            this.dpiSituacao.DP_Maximum = null;
            this.dpiSituacao.DP_Minimum = null;
            this.dpiSituacao.DP_NumericPrecision = 0;
            this.dpiSituacao.EditMask = null;
            this.dpiSituacao.EditMaskUpdate = false;
            this.dpiSituacao.FindMode = false;
            this.dpiSituacao.InterfaceField = null;
            this.dpiSituacao.IsReadonly = false;
            this.dpiSituacao.Location = new System.Drawing.Point(665, 3);
            this.dpiSituacao.Multiline = false;
            this.dpiSituacao.Name = "dpiSituacao";
            this.dpiSituacao.SearchObject = null;
            this.dpiSituacao.SettingValue = false;
            this.dpiSituacao.Size = new System.Drawing.Size(337, 37);
            this.dpiSituacao.TabIndex = 4;
            // 
            // dpiVendedor
            // 
            this.dpiVendedor.Active = false;
            this.dpiVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpiVendedor.DataSource = null;
            this.dpiVendedor.DP_Caption = "2799";
            this.dpiVendedor.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiVendedor.DP_DataField = null;
            this.dpiVendedor.DP_FilterMemo = false;
            this.dpiVendedor.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.SearchValueInput;
            this.dpiVendedor.DP_Length = 0;
            this.dpiVendedor.DP_Maximum = null;
            this.dpiVendedor.DP_Minimum = null;
            this.dpiVendedor.DP_NumericPrecision = 0;
            this.dpiVendedor.EditMask = null;
            this.dpiVendedor.EditMaskUpdate = false;
            this.dpiVendedor.FindMode = false;
            this.dpiVendedor.InterfaceField = null;
            this.dpiVendedor.IsReadonly = false;
            this.dpiVendedor.Location = new System.Drawing.Point(665, 45);
            this.dpiVendedor.Multiline = false;
            this.dpiVendedor.Name = "dpiVendedor";
            this.dpiVendedor.SearchObject = null;
            this.dpiVendedor.SettingValue = false;
            this.dpiVendedor.Size = new System.Drawing.Size(337, 35);
            this.dpiVendedor.TabIndex = 7;
            // 
            // dpiCliente
            // 
            this.dpiCliente.Active = false;
            this.dpiCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpiCliente.DataSource = null;
            this.dpiCliente.DP_Caption = null;
            this.dpiCliente.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Hide;
            this.dpiCliente.DP_DataField = null;
            this.dpiCliente.DP_FilterMemo = false;
            this.dpiCliente.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.SearchValueInput;
            this.dpiCliente.DP_Length = 0;
            this.dpiCliente.DP_Maximum = null;
            this.dpiCliente.DP_Minimum = null;
            this.dpiCliente.DP_NumericPrecision = 0;
            this.dpiCliente.EditMask = null;
            this.dpiCliente.EditMaskUpdate = false;
            this.dpiCliente.FindMode = false;
            this.dpiCliente.InterfaceField = null;
            this.dpiCliente.IsReadonly = false;
            this.dpiCliente.Location = new System.Drawing.Point(79, 3);
            this.dpiCliente.Multiline = false;
            this.dpiCliente.Name = "dpiCliente";
            this.dpiCliente.SearchObject = null;
            this.dpiCliente.SettingValue = false;
            this.dpiCliente.Size = new System.Drawing.Size(350, 36);
            this.dpiCliente.TabIndex = 1;
            // 
            // dpiNumOrcamento
            // 
            this.dpiNumOrcamento.Active = false;
            this.dpiNumOrcamento.DataSource = null;
            this.dpiNumOrcamento.DP_Caption = "3182";
            this.dpiNumOrcamento.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiNumOrcamento.DP_DataField = null;
            this.dpiNumOrcamento.DP_FilterMemo = false;
            this.dpiNumOrcamento.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.StringInput;
            this.dpiNumOrcamento.DP_Length = 0;
            this.dpiNumOrcamento.DP_Maximum = null;
            this.dpiNumOrcamento.DP_Minimum = null;
            this.dpiNumOrcamento.DP_NumericPrecision = 0;
            this.dpiNumOrcamento.EditMask = null;
            this.dpiNumOrcamento.EditMaskUpdate = false;
            this.dpiNumOrcamento.FindMode = false;
            this.dpiNumOrcamento.InterfaceField = null;
            this.dpiNumOrcamento.IsReadonly = false;
            this.dpiNumOrcamento.Location = new System.Drawing.Point(4, 3);
            this.dpiNumOrcamento.Multiline = false;
            this.dpiNumOrcamento.Name = "dpiNumOrcamento";
            this.dpiNumOrcamento.SearchObject = null;
            this.dpiNumOrcamento.SettingValue = false;
            this.dpiNumOrcamento.Size = new System.Drawing.Size(69, 36);
            this.dpiNumOrcamento.TabIndex = 0;
            // 
            // dpiValidadeData
            // 
            this.dpiValidadeData.Active = false;
            this.dpiValidadeData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpiValidadeData.DataSource = null;
            this.dpiValidadeData.DP_Caption = "40973";
            this.dpiValidadeData.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiValidadeData.DP_DataField = null;
            this.dpiValidadeData.DP_FilterMemo = false;
            this.dpiValidadeData.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.DateInput;
            this.dpiValidadeData.DP_Length = 0;
            this.dpiValidadeData.DP_Maximum = null;
            this.dpiValidadeData.DP_Minimum = null;
            this.dpiValidadeData.DP_NumericPrecision = 0;
            this.dpiValidadeData.EditMask = "00/00/0000";
            this.dpiValidadeData.EditMaskUpdate = true;
            this.dpiValidadeData.FindMode = false;
            this.dpiValidadeData.InterfaceField = null;
            this.dpiValidadeData.IsReadonly = true;
            this.dpiValidadeData.Location = new System.Drawing.Point(563, 45);
            this.dpiValidadeData.Multiline = false;
            this.dpiValidadeData.Name = "dpiValidadeData";
            this.dpiValidadeData.SearchObject = null;
            this.dpiValidadeData.SettingValue = false;
            this.dpiValidadeData.Size = new System.Drawing.Size(96, 35);
            this.dpiValidadeData.TabIndex = 6;
            // 
            // dpiValidadeDias
            // 
            this.dpiValidadeDias.Active = false;
            this.dpiValidadeDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpiValidadeDias.DataSource = null;
            this.dpiValidadeDias.DP_Caption = "29971";
            this.dpiValidadeDias.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiValidadeDias.DP_DataField = null;
            this.dpiValidadeDias.DP_FilterMemo = false;
            this.dpiValidadeDias.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.NumericInput;
            this.dpiValidadeDias.DP_Length = 0;
            this.dpiValidadeDias.DP_Maximum = null;
            this.dpiValidadeDias.DP_Minimum = null;
            this.dpiValidadeDias.DP_NumericPrecision = 0;
            this.dpiValidadeDias.EditMask = null;
            this.dpiValidadeDias.EditMaskUpdate = false;
            this.dpiValidadeDias.FindMode = false;
            this.dpiValidadeDias.InterfaceField = null;
            this.dpiValidadeDias.IsReadonly = false;
            this.dpiValidadeDias.Location = new System.Drawing.Point(461, 45);
            this.dpiValidadeDias.Multiline = false;
            this.dpiValidadeDias.Name = "dpiValidadeDias";
            this.dpiValidadeDias.SearchObject = null;
            this.dpiValidadeDias.SettingValue = false;
            this.dpiValidadeDias.Size = new System.Drawing.Size(96, 35);
            this.dpiValidadeDias.TabIndex = 5;
            // 
            // dpiTotal
            // 
            this.dpiTotal.Active = false;
            this.dpiTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dpiTotal.DataSource = null;
            this.dpiTotal.DP_Caption = "Total";
            this.dpiTotal.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiTotal.DP_DataField = null;
            this.dpiTotal.DP_FilterMemo = false;
            this.dpiTotal.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.DecimalInput;
            this.dpiTotal.DP_Length = 0;
            this.dpiTotal.DP_Maximum = null;
            this.dpiTotal.DP_Minimum = null;
            this.dpiTotal.DP_NumericPrecision = 2;
            this.dpiTotal.EditMask = null;
            this.dpiTotal.EditMaskUpdate = false;
            this.dpiTotal.FindMode = false;
            this.dpiTotal.InterfaceField = null;
            this.dpiTotal.IsReadonly = false;
            this.dpiTotal.Location = new System.Drawing.Point(665, 505);
            this.dpiTotal.Multiline = false;
            this.dpiTotal.Name = "dpiTotal";
            this.dpiTotal.SearchObject = null;
            this.dpiTotal.SettingValue = false;
            this.dpiTotal.Size = new System.Drawing.Size(337, 35);
            this.dpiTotal.TabIndex = 6;
            // 
            // tpfinaceiro
            // 
            this.tpfinaceiro.Location = new System.Drawing.Point(1, 24);
            this.tpfinaceiro.Name = "tpfinaceiro";
            this.tpfinaceiro.Size = new System.Drawing.Size(1001, 386);
            this.tpfinaceiro.TabIndex = 0;
            this.tpfinaceiro.Text = "Dados Financeiros";
            // 
            // txtuser
            // 
            this.txtuser.Active = false;
            this.txtuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtuser.DataSource = null;
            this.txtuser.DP_Caption = "Usuário";
            this.txtuser.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.txtuser.DP_DataField = null;
            this.txtuser.DP_FilterMemo = false;
            this.txtuser.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.StringInput;
            this.txtuser.DP_Length = 0;
            this.txtuser.DP_Maximum = null;
            this.txtuser.DP_Minimum = null;
            this.txtuser.DP_NumericPrecision = 0;
            this.txtuser.EditMask = null;
            this.txtuser.EditMaskUpdate = false;
            this.txtuser.FindMode = false;
            this.txtuser.InterfaceField = null;
            this.txtuser.IsReadonly = true;
            this.txtuser.Location = new System.Drawing.Point(281, 45);
            this.txtuser.Multiline = false;
            this.txtuser.Name = "txtuser";
            this.txtuser.SearchObject = null;
            this.txtuser.SettingValue = false;
            this.txtuser.Size = new System.Drawing.Size(174, 35);
            this.txtuser.TabIndex = 7;
            this.txtuser.Paint += new System.Windows.Forms.PaintEventHandler(this.dpInput1_Paint);
            // 
            // OrcamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.dpiTotal);
            this.Controls.Add(this.picObservacoes);
            this.Controls.Add(this.dpiValidadeDias);
            this.Controls.Add(this.dpiData);
            this.Controls.Add(this.dpiValidadeData);
            this.Controls.Add(this.dpiFechamento);
            this.Controls.Add(this.dpiSituacao);
            this.Controls.Add(this.dpiVendedor);
            this.Controls.Add(this.dpiCliente);
            this.Controls.Add(this.dpiNumOrcamento);
            this.Controls.Add(this.tabMain);
            this.Name = "OrcamentoView";
            this.Size = new System.Drawing.Size(1006, 543);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picObservacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private C1.Win.C1Command.C1DockingTab tabMain;
        private C1.Win.C1Command.C1DockingTabPage tpItens;
        private System.Windows.Forms.PictureBox picObservacoes;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiData;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiFechamento;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiSituacao;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiVendedor;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiCliente;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiNumOrcamento;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiValidadeData;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiValidadeDias;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiTotal;
        private C1.Win.C1Command.C1DockingTabPage tpfinaceiro;
        private dpLibrary05.Infrastructure.Controls.DPInput txtuser;
    }
}
