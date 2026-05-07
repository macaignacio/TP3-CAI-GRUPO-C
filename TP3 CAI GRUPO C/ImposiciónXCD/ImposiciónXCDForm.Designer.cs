namespace TP3_CAI_GRUPO_C.ImposiciónXCD
{
    partial class ImposiciónXCDForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CodigoCDLabel = new Label();
            TutasaLabel = new Label();
            DatosSolicitanteGroupBox = new GroupBox();
            label1 = new Label();
            CuitTextBox = new TextBox();
            ValidarButton = new Button();
            RazonSocialLabel = new Label();
            CuitLabel = new Label();
            DatosDestinatarioGroupBox = new GroupBox();
            DniTextBox = new TextBox();
            NombreApellidoTextBox = new TextBox();
            DniLabel = new Label();
            NombreApellidoLabel = new Label();
            GenerarButton = new Button();
            CancelarButton = new Button();
            RetiroSucursalGroupBox = new GroupBox();
            SucursalListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            LocalidadSucursalComboBox = new ComboBox();
            ProvinciaSucursalComboBox = new ComboBox();
            LocalidadSucursalLabel = new Label();
            ProvinciaSucursalLabel = new Label();
            EntregaDomicilioGroupBox = new GroupBox();
            DireccionTextBox = new TextBox();
            CodigoPostalTextBox = new TextBox();
            DireccionLabel = new Label();
            CodigoPostalLabel = new Label();
            LocalidadDomicilioComboBox = new ComboBox();
            ProvinciaDomicilioComboBox = new ComboBox();
            LocalidadDomicilioLabel = new Label();
            ProvinciaDomicilioLabel = new Label();
            MetodoEntregaComboBox = new ComboBox();
            MetodoEntregaLabel = new Label();
            DatosEncomiendaGroupBox = new GroupBox();
            CantidadCajasXLLabel = new Label();
            CantidadCajasLLabel = new Label();
            CantidadCajasMLabel = new Label();
            CantidadCajasXLTextBox = new TextBox();
            CantidadCajasSTextBox = new TextBox();
            CantidadCajasMTextBox = new TextBox();
            CantidadCajasLTextBox = new TextBox();
            CantidadCajasSLabel = new Label();
            NroCDLabel = new Label();
            DatosSolicitanteGroupBox.SuspendLayout();
            DatosDestinatarioGroupBox.SuspendLayout();
            RetiroSucursalGroupBox.SuspendLayout();
            EntregaDomicilioGroupBox.SuspendLayout();
            DatosEncomiendaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CodigoCDLabel
            // 
            CodigoCDLabel.AutoSize = true;
            CodigoCDLabel.Location = new Point(20, 31);
            CodigoCDLabel.Name = "CodigoCDLabel";
            CodigoCDLabel.Size = new Size(68, 15);
            CodigoCDLabel.TabIndex = 0;
            CodigoCDLabel.Text = "Código CD:";
            // 
            // TutasaLabel
            // 
            TutasaLabel.AutoSize = true;
            TutasaLabel.Location = new Point(252, 31);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(50, 15);
            TutasaLabel.TabIndex = 1;
            TutasaLabel.Text = "TUTASA";
            // 
            // DatosSolicitanteGroupBox
            // 
            DatosSolicitanteGroupBox.Controls.Add(label1);
            DatosSolicitanteGroupBox.Controls.Add(CuitTextBox);
            DatosSolicitanteGroupBox.Controls.Add(ValidarButton);
            DatosSolicitanteGroupBox.Controls.Add(RazonSocialLabel);
            DatosSolicitanteGroupBox.Controls.Add(CuitLabel);
            DatosSolicitanteGroupBox.Location = new Point(20, 57);
            DatosSolicitanteGroupBox.Name = "DatosSolicitanteGroupBox";
            DatosSolicitanteGroupBox.Size = new Size(529, 100);
            DatosSolicitanteGroupBox.TabIndex = 3;
            DatosSolicitanteGroupBox.TabStop = false;
            DatosSolicitanteGroupBox.Text = "Datos Solicitante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 34);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 8;
            label1.Text = "[razonSocial]";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(89, 31);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(193, 23);
            CuitTextBox.TabIndex = 3;
            // 
            // ValidarButton
            // 
            ValidarButton.Location = new Point(207, 71);
            ValidarButton.Name = "ValidarButton";
            ValidarButton.Size = new Size(75, 23);
            ValidarButton.TabIndex = 2;
            ValidarButton.Text = "Validar";
            ValidarButton.UseVisualStyleBackColor = true;
            ValidarButton.Click += ValidarButton_Click;
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new Point(288, 34);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new Size(76, 15);
            RazonSocialLabel.TabIndex = 1;
            RazonSocialLabel.Text = "Razón Social:";
            // 
            // CuitLabel
            // 
            CuitLabel.AutoSize = true;
            CuitLabel.Location = new Point(17, 34);
            CuitLabel.Name = "CuitLabel";
            CuitLabel.Size = new Size(66, 15);
            CuitLabel.TabIndex = 0;
            CuitLabel.Text = "CUIT/CUIL:";
            // 
            // DatosDestinatarioGroupBox
            // 
            DatosDestinatarioGroupBox.Controls.Add(DniTextBox);
            DatosDestinatarioGroupBox.Controls.Add(NombreApellidoTextBox);
            DatosDestinatarioGroupBox.Controls.Add(DniLabel);
            DatosDestinatarioGroupBox.Controls.Add(NombreApellidoLabel);
            DatosDestinatarioGroupBox.Location = new Point(17, 522);
            DatosDestinatarioGroupBox.Name = "DatosDestinatarioGroupBox";
            DatosDestinatarioGroupBox.Size = new Size(526, 70);
            DatosDestinatarioGroupBox.TabIndex = 5;
            DatosDestinatarioGroupBox.TabStop = false;
            DatosDestinatarioGroupBox.Text = "Datos Destinatario";
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(370, 29);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(153, 23);
            DniTextBox.TabIndex = 3;
            // 
            // NombreApellidoTextBox
            // 
            NombreApellidoTextBox.Location = new Point(123, 29);
            NombreApellidoTextBox.Name = "NombreApellidoTextBox";
            NombreApellidoTextBox.Size = new Size(203, 23);
            NombreApellidoTextBox.TabIndex = 2;
            // 
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Location = new Point(337, 32);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(27, 15);
            DniLabel.TabIndex = 1;
            DniLabel.Text = "DNI";
            // 
            // NombreApellidoLabel
            // 
            NombreApellidoLabel.AutoSize = true;
            NombreApellidoLabel.Location = new Point(6, 32);
            NombreApellidoLabel.Name = "NombreApellidoLabel";
            NombreApellidoLabel.Size = new Size(105, 15);
            NombreApellidoLabel.TabIndex = 0;
            NombreApellidoLabel.Text = "Nombre y apellido";
            // 
            // GenerarButton
            // 
            GenerarButton.Location = new Point(387, 716);
            GenerarButton.Name = "GenerarButton";
            GenerarButton.Size = new Size(75, 23);
            GenerarButton.TabIndex = 7;
            GenerarButton.Text = "Generar";
            GenerarButton.UseVisualStyleBackColor = true;
            GenerarButton.Click += GenerarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(474, 716);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(75, 23);
            CancelarButton.TabIndex = 8;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // RetiroSucursalGroupBox
            // 
            RetiroSucursalGroupBox.Controls.Add(SucursalListView);
            RetiroSucursalGroupBox.Controls.Add(LocalidadSucursalComboBox);
            RetiroSucursalGroupBox.Controls.Add(ProvinciaSucursalComboBox);
            RetiroSucursalGroupBox.Controls.Add(LocalidadSucursalLabel);
            RetiroSucursalGroupBox.Controls.Add(ProvinciaSucursalLabel);
            RetiroSucursalGroupBox.Location = new Point(17, 327);
            RetiroSucursalGroupBox.Name = "RetiroSucursalGroupBox";
            RetiroSucursalGroupBox.Size = new Size(527, 189);
            RetiroSucursalGroupBox.TabIndex = 16;
            RetiroSucursalGroupBox.TabStop = false;
            RetiroSucursalGroupBox.Text = "Retiro en Sucursal (Agencia o CD)";
            // 
            // SucursalListView
            // 
            SucursalListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            SucursalListView.Location = new Point(14, 69);
            SucursalListView.Name = "SucursalListView";
            SucursalListView.Size = new Size(505, 114);
            SucursalListView.TabIndex = 10;
            SucursalListView.UseCompatibleStateImageBehavior = false;
            SucursalListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dirección";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Horarios";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tipo de Establecimiento";
            columnHeader4.Width = 150;
            // 
            // LocalidadSucursalComboBox
            // 
            LocalidadSucursalComboBox.FormattingEnabled = true;
            LocalidadSucursalComboBox.Location = new Point(336, 32);
            LocalidadSucursalComboBox.Name = "LocalidadSucursalComboBox";
            LocalidadSucursalComboBox.Size = new Size(178, 23);
            LocalidadSucursalComboBox.TabIndex = 4;
            LocalidadSucursalComboBox.Text = "*bloquear*";
            LocalidadSucursalComboBox.SelectedIndexChanged += LocalidadSucursalComboBox_SelectedIndexChanged;
            // 
            // ProvinciaSucursalComboBox
            // 
            ProvinciaSucursalComboBox.FormattingEnabled = true;
            ProvinciaSucursalComboBox.Location = new Point(101, 30);
            ProvinciaSucursalComboBox.Name = "ProvinciaSucursalComboBox";
            ProvinciaSucursalComboBox.Size = new Size(154, 23);
            ProvinciaSucursalComboBox.TabIndex = 3;
            ProvinciaSucursalComboBox.SelectedIndexChanged += ProvinciaSucursalComboBox_SelectedIndexChanged;
            // 
            // LocalidadSucursalLabel
            // 
            LocalidadSucursalLabel.AutoSize = true;
            LocalidadSucursalLabel.Location = new Point(261, 35);
            LocalidadSucursalLabel.Name = "LocalidadSucursalLabel";
            LocalidadSucursalLabel.Size = new Size(58, 15);
            LocalidadSucursalLabel.TabIndex = 1;
            LocalidadSucursalLabel.Text = "Localidad";
            // 
            // ProvinciaSucursalLabel
            // 
            ProvinciaSucursalLabel.AutoSize = true;
            ProvinciaSucursalLabel.Location = new Point(15, 32);
            ProvinciaSucursalLabel.Name = "ProvinciaSucursalLabel";
            ProvinciaSucursalLabel.Size = new Size(56, 15);
            ProvinciaSucursalLabel.TabIndex = 0;
            ProvinciaSucursalLabel.Text = "Provincia";
            // 
            // EntregaDomicilioGroupBox
            // 
            EntregaDomicilioGroupBox.Controls.Add(DireccionTextBox);
            EntregaDomicilioGroupBox.Controls.Add(CodigoPostalTextBox);
            EntregaDomicilioGroupBox.Controls.Add(DireccionLabel);
            EntregaDomicilioGroupBox.Controls.Add(CodigoPostalLabel);
            EntregaDomicilioGroupBox.Controls.Add(LocalidadDomicilioComboBox);
            EntregaDomicilioGroupBox.Controls.Add(ProvinciaDomicilioComboBox);
            EntregaDomicilioGroupBox.Controls.Add(LocalidadDomicilioLabel);
            EntregaDomicilioGroupBox.Controls.Add(ProvinciaDomicilioLabel);
            EntregaDomicilioGroupBox.Location = new Point(17, 205);
            EntregaDomicilioGroupBox.Name = "EntregaDomicilioGroupBox";
            EntregaDomicilioGroupBox.Size = new Size(527, 106);
            EntregaDomicilioGroupBox.TabIndex = 14;
            EntregaDomicilioGroupBox.TabStop = false;
            EntregaDomicilioGroupBox.Text = "Entrega a Domicilio";
            // 
            // DireccionTextBox
            // 
            DireccionTextBox.Location = new Point(336, 61);
            DireccionTextBox.Name = "DireccionTextBox";
            DireccionTextBox.Size = new Size(177, 23);
            DireccionTextBox.TabIndex = 9;
            // 
            // CodigoPostalTextBox
            // 
            CodigoPostalTextBox.Location = new Point(101, 61);
            CodigoPostalTextBox.Name = "CodigoPostalTextBox";
            CodigoPostalTextBox.Size = new Size(154, 23);
            CodigoPostalTextBox.TabIndex = 8;
            // 
            // DireccionLabel
            // 
            DireccionLabel.AutoSize = true;
            DireccionLabel.Location = new Point(261, 64);
            DireccionLabel.Name = "DireccionLabel";
            DireccionLabel.Size = new Size(57, 15);
            DireccionLabel.TabIndex = 7;
            DireccionLabel.Text = "Dirección";
            // 
            // CodigoPostalLabel
            // 
            CodigoPostalLabel.AutoSize = true;
            CodigoPostalLabel.Location = new Point(14, 64);
            CodigoPostalLabel.Name = "CodigoPostalLabel";
            CodigoPostalLabel.Size = new Size(81, 15);
            CodigoPostalLabel.TabIndex = 6;
            CodigoPostalLabel.Text = "Código Postal";
            // 
            // LocalidadDomicilioComboBox
            // 
            LocalidadDomicilioComboBox.FormattingEnabled = true;
            LocalidadDomicilioComboBox.Location = new Point(335, 32);
            LocalidadDomicilioComboBox.Name = "LocalidadDomicilioComboBox";
            LocalidadDomicilioComboBox.Size = new Size(178, 23);
            LocalidadDomicilioComboBox.TabIndex = 4;
            LocalidadDomicilioComboBox.Text = "*bloquear*";
            // 
            // ProvinciaDomicilioComboBox
            // 
            ProvinciaDomicilioComboBox.FormattingEnabled = true;
            ProvinciaDomicilioComboBox.Location = new Point(101, 30);
            ProvinciaDomicilioComboBox.Name = "ProvinciaDomicilioComboBox";
            ProvinciaDomicilioComboBox.Size = new Size(154, 23);
            ProvinciaDomicilioComboBox.TabIndex = 3;
            ProvinciaDomicilioComboBox.SelectedIndexChanged += ProvinciaDomicilioComboBox_SelectedIndexChanged;
            // 
            // LocalidadDomicilioLabel
            // 
            LocalidadDomicilioLabel.AutoSize = true;
            LocalidadDomicilioLabel.Location = new Point(261, 32);
            LocalidadDomicilioLabel.Name = "LocalidadDomicilioLabel";
            LocalidadDomicilioLabel.Size = new Size(58, 15);
            LocalidadDomicilioLabel.TabIndex = 1;
            LocalidadDomicilioLabel.Text = "Localidad";
            // 
            // ProvinciaDomicilioLabel
            // 
            ProvinciaDomicilioLabel.AutoSize = true;
            ProvinciaDomicilioLabel.Location = new Point(15, 32);
            ProvinciaDomicilioLabel.Name = "ProvinciaDomicilioLabel";
            ProvinciaDomicilioLabel.Size = new Size(56, 15);
            ProvinciaDomicilioLabel.TabIndex = 0;
            ProvinciaDomicilioLabel.Text = "Provincia";
            // 
            // MetodoEntregaComboBox
            // 
            MetodoEntregaComboBox.FormattingEnabled = true;
            MetodoEntregaComboBox.Location = new Point(141, 167);
            MetodoEntregaComboBox.Name = "MetodoEntregaComboBox";
            MetodoEntregaComboBox.Size = new Size(143, 23);
            MetodoEntregaComboBox.TabIndex = 15;
            MetodoEntregaComboBox.SelectedIndexChanged += MetodoEntregaComboBox_SelectedIndexChanged;
            // 
            // MetodoEntregaLabel
            // 
            MetodoEntregaLabel.AutoSize = true;
            MetodoEntregaLabel.Location = new Point(27, 171);
            MetodoEntregaLabel.Name = "MetodoEntregaLabel";
            MetodoEntregaLabel.Size = new Size(108, 15);
            MetodoEntregaLabel.TabIndex = 13;
            MetodoEntregaLabel.Text = "Método de Entrega";
            // 
            // DatosEncomiendaGroupBox
            // 
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasXLLabel);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasLLabel);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasMLabel);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasXLTextBox);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasSTextBox);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasMTextBox);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasLTextBox);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasSLabel);
            DatosEncomiendaGroupBox.Location = new Point(17, 598);
            DatosEncomiendaGroupBox.Name = "DatosEncomiendaGroupBox";
            DatosEncomiendaGroupBox.Size = new Size(527, 101);
            DatosEncomiendaGroupBox.TabIndex = 12;
            DatosEncomiendaGroupBox.TabStop = false;
            DatosEncomiendaGroupBox.Text = "Datos Encomienda";
            // 
            // CantidadCajasXLLabel
            // 
            CantidadCajasXLLabel.AutoSize = true;
            CantidadCajasXLLabel.Location = new Point(261, 60);
            CantidadCajasXLLabel.Name = "CantidadCajasXLLabel";
            CantidadCajasXLLabel.Size = new Size(116, 15);
            CantidadCajasXLLabel.TabIndex = 19;
            CantidadCajasXLLabel.Text = "Cantidad de cajas XL";
            // 
            // CantidadCajasLLabel
            // 
            CantidadCajasLLabel.AutoSize = true;
            CantidadCajasLLabel.Location = new Point(261, 34);
            CantidadCajasLLabel.Name = "CantidadCajasLLabel";
            CantidadCajasLLabel.Size = new Size(109, 15);
            CantidadCajasLLabel.TabIndex = 18;
            CantidadCajasLLabel.Text = "Cantidad de cajas L";
            // 
            // CantidadCajasMLabel
            // 
            CantidadCajasMLabel.AutoSize = true;
            CantidadCajasMLabel.Location = new Point(12, 58);
            CantidadCajasMLabel.Name = "CantidadCajasMLabel";
            CantidadCajasMLabel.Size = new Size(114, 15);
            CantidadCajasMLabel.TabIndex = 17;
            CantidadCajasMLabel.Text = "Cantidad de cajas M";
            // 
            // CantidadCajasXLTextBox
            // 
            CantidadCajasXLTextBox.Location = new Point(393, 55);
            CantidadCajasXLTextBox.Name = "CantidadCajasXLTextBox";
            CantidadCajasXLTextBox.Size = new Size(100, 23);
            CantidadCajasXLTextBox.TabIndex = 6;
            // 
            // CantidadCajasSTextBox
            // 
            CantidadCajasSTextBox.Location = new Point(139, 26);
            CantidadCajasSTextBox.Name = "CantidadCajasSTextBox";
            CantidadCajasSTextBox.Size = new Size(100, 23);
            CantidadCajasSTextBox.TabIndex = 5;
            // 
            // CantidadCajasMTextBox
            // 
            CantidadCajasMTextBox.Location = new Point(139, 55);
            CantidadCajasMTextBox.Name = "CantidadCajasMTextBox";
            CantidadCajasMTextBox.Size = new Size(100, 23);
            CantidadCajasMTextBox.TabIndex = 4;
            // 
            // CantidadCajasLTextBox
            // 
            CantidadCajasLTextBox.Location = new Point(393, 26);
            CantidadCajasLTextBox.Name = "CantidadCajasLTextBox";
            CantidadCajasLTextBox.Size = new Size(100, 23);
            CantidadCajasLTextBox.TabIndex = 3;
            // 
            // CantidadCajasSLabel
            // 
            CantidadCajasSLabel.AutoSize = true;
            CantidadCajasSLabel.Location = new Point(12, 34);
            CantidadCajasSLabel.Name = "CantidadCajasSLabel";
            CantidadCajasSLabel.Size = new Size(109, 15);
            CantidadCajasSLabel.TabIndex = 1;
            CantidadCajasSLabel.Text = "Cantidad de cajas S";
            // 
            // NroCDLabel
            // 
            NroCDLabel.AutoSize = true;
            NroCDLabel.Location = new Point(97, 31);
            NroCDLabel.Name = "NroCDLabel";
            NroCDLabel.Size = new Size(52, 15);
            NroCDLabel.TabIndex = 17;
            NroCDLabel.Text = "[código]";
            // 
            // ImposiciónXCDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(561, 749);
            Controls.Add(NroCDLabel);
            Controls.Add(DatosEncomiendaGroupBox);
            Controls.Add(RetiroSucursalGroupBox);
            Controls.Add(EntregaDomicilioGroupBox);
            Controls.Add(MetodoEntregaComboBox);
            Controls.Add(MetodoEntregaLabel);
            Controls.Add(CancelarButton);
            Controls.Add(GenerarButton);
            Controls.Add(DatosDestinatarioGroupBox);
            Controls.Add(DatosSolicitanteGroupBox);
            Controls.Add(TutasaLabel);
            Controls.Add(CodigoCDLabel);
            Name = "ImposiciónXCDForm";
            Text = "Imposición por Centro de Distribución";
            Load += ImposiciónXCDForm_Load;
            DatosSolicitanteGroupBox.ResumeLayout(false);
            DatosSolicitanteGroupBox.PerformLayout();
            DatosDestinatarioGroupBox.ResumeLayout(false);
            DatosDestinatarioGroupBox.PerformLayout();
            RetiroSucursalGroupBox.ResumeLayout(false);
            RetiroSucursalGroupBox.PerformLayout();
            EntregaDomicilioGroupBox.ResumeLayout(false);
            EntregaDomicilioGroupBox.PerformLayout();
            DatosEncomiendaGroupBox.ResumeLayout(false);
            DatosEncomiendaGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CodigoCDLabel;
        private Label TutasaLabel;
        private GroupBox DatosSolicitanteGroupBox;
        private GroupBox DatosDestinatarioGroupBox;
        private TextBox CuitTextBox;
        private Button ValidarButton;
        private Label RazonSocialLabel;
        private Label CuitLabel;
        private TextBox DniTextBox;
        private TextBox NombreApellidoTextBox;
        private Label DniLabel;
        private Label NombreApellidoLabel;
        private Button GenerarButton;
        private Button CancelarButton;
        private GroupBox RetiroSucursalGroupBox;
        private ListView SucursalListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox LocalidadSucursalComboBox;
        private ComboBox ProvinciaSucursalComboBox;
        private Label LocalidadSucursalLabel;
        private Label ProvinciaSucursalLabel;
        private GroupBox EntregaDomicilioGroupBox;
        private TextBox DireccionTextBox;
        private TextBox CodigoPostalTextBox;
        private Label DireccionLabel;
        private Label CodigoPostalLabel;
        private ComboBox LocalidadDomicilioComboBox;
        private ComboBox ProvinciaDomicilioComboBox;
        private Label LocalidadDomicilioLabel;
        private Label ProvinciaDomicilioLabel;
        private ComboBox MetodoEntregaComboBox;
        private Label MetodoEntregaLabel;
        private GroupBox DatosEncomiendaGroupBox;
        private Label CantidadCajasXLLabel;
        private Label CantidadCajasLLabel;
        private Label CantidadCajasMLabel;
        private TextBox CantidadCajasXLTextBox;
        private TextBox CantidadCajasSTextBox;
        private TextBox CantidadCajasMTextBox;
        private TextBox CantidadCajasLTextBox;
        private Label CantidadCajasSLabel;
        private Label NroCDLabel;
        private Label label1;
    }
}
