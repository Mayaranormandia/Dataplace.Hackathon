namespace Dataplace.Imersao.Presentation.Views.Orcamentos.Tools
{
    partial class CancelarFehacrOrcamentosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarFehacrOrcamentosView));
            this.gridOrcamento = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiMarcar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDesmarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAberto = new System.Windows.Forms.CheckBox();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.chkFechado = new System.Windows.Forms.CheckBox();
            this.rangeDate = new dpLibrary05.ucSymGen_ReferenceDtp();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.opreabrir = new System.Windows.Forms.RadioButton();
            this.optFechar = new System.Windows.Forms.RadioButton();
            this.optCancelar = new System.Windows.Forms.RadioButton();
            this.dpCliente = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpiNumOrcamento = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.dpVendedor = new dpLibrary05.Infrastructure.Controls.DPInput();
            this.chkSelCliente = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOrcamento
            // 
            this.gridOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOrcamento.GroupByCaption = "Drag a column header here to group by that column";
            this.gridOrcamento.Images.Add(((System.Drawing.Image)(resources.GetObject("gridOrcamento.Images"))));
            this.gridOrcamento.Location = new System.Drawing.Point(2, 133);
            this.gridOrcamento.Margin = new System.Windows.Forms.Padding(2);
            this.gridOrcamento.Name = "gridOrcamento";
            this.gridOrcamento.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.gridOrcamento.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.gridOrcamento.PreviewInfo.ZoomFactor = 75D;
            this.gridOrcamento.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
            this.gridOrcamento.PrintInfo.MeasurementPrinterName = null;
            this.gridOrcamento.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("gridOrcamento.PrintInfo.PageSettings")));
            this.gridOrcamento.Size = new System.Drawing.Size(1006, 198);
            this.gridOrcamento.TabIndex = 3;
            this.gridOrcamento.UseCompatibleTextRendering = false;
            this.gridOrcamento.PropBag = resources.GetString("gridOrcamento.PropBag");
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.Location = new System.Drawing.Point(905, 96);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(82, 24);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 393);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiMarcar,
            this.tsiDesmarca,
            this.tsiExcel});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripSplitButton1.Text = "Ferramentas";
            // 
            // tsiMarcar
            // 
            this.tsiMarcar.Name = "tsiMarcar";
            this.tsiMarcar.Size = new System.Drawing.Size(174, 22);
            this.tsiMarcar.Text = "Marcar Todos";
            // 
            // tsiDesmarca
            // 
            this.tsiDesmarca.Name = "tsiDesmarca";
            this.tsiDesmarca.Size = new System.Drawing.Size(174, 22);
            this.tsiDesmarca.Text = "Desmarcar Todos";
            // 
            // tsiExcel
            // 
            this.tsiExcel.Name = "tsiExcel";
            this.tsiExcel.Size = new System.Drawing.Size(174, 22);
            this.tsiExcel.Text = "Exportar para excel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAberto);
            this.groupBox1.Controls.Add(this.chkCancelado);
            this.groupBox1.Controls.Add(this.chkFechado);
            this.groupBox1.Location = new System.Drawing.Point(547, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(254, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação do orçamento";
            // 
            // chkAberto
            // 
            this.chkAberto.AutoSize = true;
            this.chkAberto.Checked = true;
            this.chkAberto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAberto.Location = new System.Drawing.Point(11, 25);
            this.chkAberto.Margin = new System.Windows.Forms.Padding(2);
            this.chkAberto.Name = "chkAberto";
            this.chkAberto.Size = new System.Drawing.Size(57, 17);
            this.chkAberto.TabIndex = 0;
            this.chkAberto.Text = "Aberto";
            this.chkAberto.UseVisualStyleBackColor = true;
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Location = new System.Drawing.Point(173, 25);
            this.chkCancelado.Margin = new System.Windows.Forms.Padding(2);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(77, 17);
            this.chkCancelado.TabIndex = 2;
            this.chkCancelado.Text = "Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // chkFechado
            // 
            this.chkFechado.AutoSize = true;
            this.chkFechado.Location = new System.Drawing.Point(86, 25);
            this.chkFechado.Margin = new System.Windows.Forms.Padding(2);
            this.chkFechado.Name = "chkFechado";
            this.chkFechado.Size = new System.Drawing.Size(68, 17);
            this.chkFechado.TabIndex = 1;
            this.chkFechado.Text = "Fechado";
            this.chkFechado.UseVisualStyleBackColor = true;
            // 
            // rangeDate
            // 
            this.rangeDate.Date1CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.Date2CustomFormat = dpLibrary05.ucSymGen_ReferenceDtp.CustomFormatEnum.FShort;
            this.rangeDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rangeDate.DotNetContainer = false;
            this.rangeDate.KeyPreview = false;
            this.rangeDate.Label1Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TFrom;
            this.rangeDate.Label2Text = dpLibrary05.ucSymGen_ReferenceDtp.LabelTextEnum.TTo;
            this.rangeDate.Location = new System.Drawing.Point(7, 20);
            this.rangeDate.Margin = new System.Windows.Forms.Padding(4);
            this.rangeDate.Name = "rangeDate";
            this.rangeDate.OpenModal = false;
            this.rangeDate.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("rangeDate.Parameters")));
            this.rangeDate.Size = new System.Drawing.Size(372, 22);
            this.rangeDate.TabIndex = 0;
            this.rangeDate.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.rangeDate);
            this.gbData.Location = new System.Drawing.Point(133, 11);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(396, 58);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data do orçamento";
            // 
            // gbAcoes
            // 
            this.gbAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAcoes.Controls.Add(this.opreabrir);
            this.gbAcoes.Controls.Add(this.optFechar);
            this.gbAcoes.Controls.Add(this.optCancelar);
            this.gbAcoes.Location = new System.Drawing.Point(3, 336);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Size = new System.Drawing.Size(390, 47);
            this.gbAcoes.TabIndex = 4;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "O que deseja fazer?";
            // 
            // opreabrir
            // 
            this.opreabrir.AutoSize = true;
            this.opreabrir.Location = new System.Drawing.Point(267, 19);
            this.opreabrir.Name = "opreabrir";
            this.opreabrir.Size = new System.Drawing.Size(114, 17);
            this.opreabrir.TabIndex = 7;
            this.opreabrir.Text = "Reabrir Orcamento";
            this.opreabrir.UseVisualStyleBackColor = true;
            // 
            // optFechar
            // 
            this.optFechar.AutoSize = true;
            this.optFechar.Checked = true;
            this.optFechar.Location = new System.Drawing.Point(150, 19);
            this.optFechar.Name = "optFechar";
            this.optFechar.Size = new System.Drawing.Size(111, 17);
            this.optFechar.TabIndex = 0;
            this.optFechar.Text = "Fechar orçamento";
            this.optFechar.UseVisualStyleBackColor = true;
            // 
            // optCancelar
            // 
            this.optCancelar.AutoSize = true;
            this.optCancelar.Location = new System.Drawing.Point(24, 19);
            this.optCancelar.Name = "optCancelar";
            this.optCancelar.Size = new System.Drawing.Size(120, 17);
            this.optCancelar.TabIndex = 6;
            this.optCancelar.Text = "Cancelar orçamento";
            this.optCancelar.UseVisualStyleBackColor = true;
            // 
            // dpCliente
            // 
            this.dpCliente.Active = false;
            this.dpCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpCliente.DataSource = null;
            this.dpCliente.DP_Caption = "Cliente";
            this.dpCliente.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpCliente.DP_DataField = null;
            this.dpCliente.DP_FilterMemo = false;
            this.dpCliente.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.SearchValueInput;
            this.dpCliente.DP_Length = 0;
            this.dpCliente.DP_Maximum = null;
            this.dpCliente.DP_Minimum = null;
            this.dpCliente.DP_NumericPrecision = 0;
            this.dpCliente.EditMask = null;
            this.dpCliente.EditMaskUpdate = false;
            this.dpCliente.FindMode = false;
            this.dpCliente.InterfaceField = null;
            this.dpCliente.IsReadonly = false;
            this.dpCliente.Location = new System.Drawing.Point(16, 72);
            this.dpCliente.Multiline = false;
            this.dpCliente.Name = "dpCliente";
            this.dpCliente.SearchObject = null;
            this.dpCliente.SettingValue = false;
            this.dpCliente.Size = new System.Drawing.Size(367, 35);
            this.dpCliente.TabIndex = 503;
            // 
            // dpiNumOrcamento
            // 
            this.dpiNumOrcamento.Active = false;
            this.dpiNumOrcamento.DataSource = null;
            this.dpiNumOrcamento.DP_Caption = "Nº Orcamento";
            this.dpiNumOrcamento.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpiNumOrcamento.DP_DataField = null;
            this.dpiNumOrcamento.DP_FilterMemo = false;
            this.dpiNumOrcamento.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.NumericInput;
            this.dpiNumOrcamento.DP_Length = 0;
            this.dpiNumOrcamento.DP_Maximum = null;
            this.dpiNumOrcamento.DP_Minimum = null;
            this.dpiNumOrcamento.DP_NumericPrecision = 0;
            this.dpiNumOrcamento.EditMask = null;
            this.dpiNumOrcamento.EditMaskUpdate = false;
            this.dpiNumOrcamento.FindMode = false;
            this.dpiNumOrcamento.InterfaceField = null;
            this.dpiNumOrcamento.IsReadonly = false;
            this.dpiNumOrcamento.Location = new System.Drawing.Point(16, 11);
            this.dpiNumOrcamento.Multiline = false;
            this.dpiNumOrcamento.Name = "dpiNumOrcamento";
            this.dpiNumOrcamento.SearchObject = null;
            this.dpiNumOrcamento.SettingValue = false;
            this.dpiNumOrcamento.Size = new System.Drawing.Size(100, 36);
            this.dpiNumOrcamento.TabIndex = 504;
            // 
            // dpVendedor
            // 
            this.dpVendedor.Active = false;
            this.dpVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpVendedor.DataSource = null;
            this.dpVendedor.DP_Caption = "Vendedor";
            this.dpVendedor.DP_CaptionVisibleType = dpLibrary05.Infrastructure.Controls.DPInput.CaptionVisibleTypeEnum.Top;
            this.dpVendedor.DP_DataField = null;
            this.dpVendedor.DP_FilterMemo = false;
            this.dpVendedor.DP_InputType = dpLibrary05.Infrastructure.Controls.DPInput.InputTypeEnum.SearchValueInput;
            this.dpVendedor.DP_Length = 0;
            this.dpVendedor.DP_Maximum = null;
            this.dpVendedor.DP_Minimum = null;
            this.dpVendedor.DP_NumericPrecision = 0;
            this.dpVendedor.EditMask = null;
            this.dpVendedor.EditMaskUpdate = false;
            this.dpVendedor.FindMode = false;
            this.dpVendedor.InterfaceField = null;
            this.dpVendedor.IsReadonly = false;
            this.dpVendedor.Location = new System.Drawing.Point(389, 74);
            this.dpVendedor.Multiline = false;
            this.dpVendedor.Name = "dpVendedor";
            this.dpVendedor.SearchObject = null;
            this.dpVendedor.SettingValue = false;
            this.dpVendedor.Size = new System.Drawing.Size(249, 35);
            this.dpVendedor.TabIndex = 506;
            // 
            // chkSelCliente
            // 
            this.chkSelCliente.AutoSize = true;
            this.chkSelCliente.Location = new System.Drawing.Point(16, 112);
            this.chkSelCliente.Margin = new System.Windows.Forms.Padding(2);
            this.chkSelCliente.Name = "chkSelCliente";
            this.chkSelCliente.Size = new System.Drawing.Size(158, 17);
            this.chkSelCliente.TabIndex = 507;
            this.chkSelCliente.Text = "Selecionar multiplos clientes";
            this.chkSelCliente.UseVisualStyleBackColor = true;
            // 
            // CancelarFehacrOrcamentosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkSelCliente);
            this.Controls.Add(this.dpVendedor);
            this.Controls.Add(this.dpiNumOrcamento);
            this.Controls.Add(this.dpCliente);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.gridOrcamento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CancelarFehacrOrcamentosView";
            this.Size = new System.Drawing.Size(1010, 450);
            this.Load += new System.EventHandler(this.CancelarFehacrOrcamentosView_Load);
            this.Controls.SetChildIndex(this.gridOrcamento, 0);
            this.Controls.SetChildIndex(this.btnCarregar, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.gbAcoes, 0);
            this.Controls.SetChildIndex(this.dpCliente, 0);
            this.Controls.SetChildIndex(this.dpiNumOrcamento, 0);
            this.Controls.SetChildIndex(this.dpVendedor, 0);
            this.Controls.SetChildIndex(this.chkSelCliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrcamento)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbAcoes.ResumeLayout(false);
            this.gbAcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid gridOrcamento;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsiMarcar;
        private System.Windows.Forms.ToolStripMenuItem tsiDesmarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAberto;
        private System.Windows.Forms.CheckBox chkCancelado;
        private System.Windows.Forms.CheckBox chkFechado;
        private System.Windows.Forms.ToolStripMenuItem tsiExcel;
        internal dpLibrary05.ucSymGen_ReferenceDtp rangeDate;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.RadioButton optFechar;
        private System.Windows.Forms.RadioButton optCancelar;
        private dpLibrary05.Infrastructure.Controls.DPInput dpCliente;
        private dpLibrary05.Infrastructure.Controls.DPInput dpiNumOrcamento;
        private System.Windows.Forms.RadioButton opreabrir;
        private dpLibrary05.Infrastructure.Controls.DPInput dpVendedor;
        private System.Windows.Forms.CheckBox chkSelCliente;
    }
}
