namespace TP3_CAI_GRUPO_C.ImposicionXAgencia
{
    partial class ImposicionXAgenciaForm
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
            TutasaLabel = new Label();
            CodigoAgenciaLabel = new Label();
            DatosSolicitanteGroupBox = new GroupBox();
            CuitTextBox = new TextBox();
            ValidarButton = new Button();
            RazonSocialLabel = new Label();
            CuitLabel = new Label();
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
            DatosDestinatarioGroupBox = new GroupBox();
            DniTextBox = new TextBox();
            NombreApellidoTextBox = new TextBox();
            DniLabel = new Label();
            NombreApellidoLabel = new Label();
            DatosEncomiendaGroupBox = new GroupBox();
            CantidadCajasXLLabel = new Label();
            CantidadCajasLLabel = new Label();
            CantidadCajasMLabel = new Label();
            CantidadCajasXLTextBox = new TextBox();
            CantidadCajasSTextBox = new TextBox();
            CantidadCajasMTextBox = new TextBox();
            CantidadCajasLTextBox = new TextBox();
            CantidadCajasSLabel = new Label();
            GenerarButton = new Button();
            CancelarButton = new Button();
            RetiroSucursalGroupBox = new GroupBox();
            SeleccionarButton = new Button();
            SucursalListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            LocalidadSucursalComboBox = new ComboBox();
            ProvinciaSucursalComboBox = new ComboBox();
            LocalidadSucursalLabel = new Label();
            ProvinciaSucursalLabel = new Label();
            NroAgenciaLabel = new Label();
            label1 = new Label();
            DatosSolicitanteGroupBox.SuspendLayout();
            EntregaDomicilioGroupBox.SuspendLayout();
            DatosDestinatarioGroupBox.SuspendLayout();
            DatosEncomiendaGroupBox.SuspendLayout();
            RetiroSucursalGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaLabel
            // 
            TutasaLabel.AutoSize = true;
            TutasaLabel.Location = new Point(248, 25);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(50, 15);
            TutasaLabel.TabIndex = 0;
            TutasaLabel.Text = "TUTASA";
            // 
            // CodigoAgenciaLabel
            // 
            CodigoAgenciaLabel.AutoSize = true;
            CodigoAgenciaLabel.Location = new Point(17, 24);
            CodigoAgenciaLabel.Name = "CodigoAgenciaLabel";
            CodigoAgenciaLabel.Size = new Size(95, 15);
            CodigoAgenciaLabel.TabIndex = 1;
            CodigoAgenciaLabel.Text = "Código Agencia:";
            // 
            // DatosSolicitanteGroupBox
            // 
            DatosSolicitanteGroupBox.Controls.Add(label1);
            DatosSolicitanteGroupBox.Controls.Add(CuitTextBox);
            DatosSolicitanteGroupBox.Controls.Add(ValidarButton);
            DatosSolicitanteGroupBox.Controls.Add(RazonSocialLabel);
            DatosSolicitanteGroupBox.Controls.Add(CuitLabel);
            DatosSolicitanteGroupBox.Location = new Point(23, 57);
            DatosSolicitanteGroupBox.Name = "DatosSolicitanteGroupBox";
            DatosSolicitanteGroupBox.Size = new Size(527, 100);
            DatosSolicitanteGroupBox.TabIndex = 3;
            DatosSolicitanteGroupBox.TabStop = false;
            DatosSolicitanteGroupBox.Text = "Datos Solicitante";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(85, 30);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(189, 23);
            CuitTextBox.TabIndex = 3;
            // 
            // ValidarButton
            // 
            ValidarButton.Location = new Point(199, 71);
            ValidarButton.Name = "ValidarButton";
            ValidarButton.Size = new Size(75, 23);
            ValidarButton.TabIndex = 2;
            ValidarButton.Text = "Validar";
            ValidarButton.UseVisualStyleBackColor = true;
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new Point(286, 33);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new Size(76, 15);
            RazonSocialLabel.TabIndex = 1;
            RazonSocialLabel.Text = "Razón Social:";
            // 
            // CuitLabel
            // 
            CuitLabel.AutoSize = true;
            CuitLabel.Location = new Point(13, 33);
            CuitLabel.Name = "CuitLabel";
            CuitLabel.Size = new Size(66, 15);
            CuitLabel.TabIndex = 0;
            CuitLabel.Text = "CUIT/CUIL:";
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
            EntregaDomicilioGroupBox.Location = new Point(24, 206);
            EntregaDomicilioGroupBox.Name = "EntregaDomicilioGroupBox";
            EntregaDomicilioGroupBox.Size = new Size(527, 106);
            EntregaDomicilioGroupBox.TabIndex = 4;
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
            MetodoEntregaComboBox.Location = new Point(148, 168);
            MetodoEntregaComboBox.Name = "MetodoEntregaComboBox";
            MetodoEntregaComboBox.Size = new Size(143, 23);
            MetodoEntregaComboBox.TabIndex = 5;
            // 
            // MetodoEntregaLabel
            // 
            MetodoEntregaLabel.AutoSize = true;
            MetodoEntregaLabel.Location = new Point(34, 172);
            MetodoEntregaLabel.Name = "MetodoEntregaLabel";
            MetodoEntregaLabel.Size = new Size(108, 15);
            MetodoEntregaLabel.TabIndex = 2;
            MetodoEntregaLabel.Text = "Método de Entrega";
            // 
            // DatosDestinatarioGroupBox
            // 
            DatosDestinatarioGroupBox.Controls.Add(DniTextBox);
            DatosDestinatarioGroupBox.Controls.Add(NombreApellidoTextBox);
            DatosDestinatarioGroupBox.Controls.Add(DniLabel);
            DatosDestinatarioGroupBox.Controls.Add(NombreApellidoLabel);
            DatosDestinatarioGroupBox.Location = new Point(24, 523);
            DatosDestinatarioGroupBox.Name = "DatosDestinatarioGroupBox";
            DatosDestinatarioGroupBox.Size = new Size(528, 78);
            DatosDestinatarioGroupBox.TabIndex = 5;
            DatosDestinatarioGroupBox.TabStop = false;
            DatosDestinatarioGroupBox.Text = "Datos Destinatario";
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(355, 32);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(160, 23);
            DniTextBox.TabIndex = 3;
            // 
            // NombreApellidoTextBox
            // 
            NombreApellidoTextBox.Location = new Point(121, 32);
            NombreApellidoTextBox.Name = "NombreApellidoTextBox";
            NombreApellidoTextBox.Size = new Size(174, 23);
            NombreApellidoTextBox.TabIndex = 2;
            // 
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Location = new Point(311, 35);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(27, 15);
            DniLabel.TabIndex = 1;
            DniLabel.Text = "DNI";
            // 
            // NombreApellidoLabel
            // 
            NombreApellidoLabel.AutoSize = true;
            NombreApellidoLabel.Location = new Point(10, 35);
            NombreApellidoLabel.Name = "NombreApellidoLabel";
            NombreApellidoLabel.Size = new Size(105, 15);
            NombreApellidoLabel.TabIndex = 0;
            NombreApellidoLabel.Text = "Nombre y apellido";
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
            DatosEncomiendaGroupBox.Location = new Point(24, 607);
            DatosEncomiendaGroupBox.Name = "DatosEncomiendaGroupBox";
            DatosEncomiendaGroupBox.Size = new Size(528, 101);
            DatosEncomiendaGroupBox.TabIndex = 6;
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
            // GenerarButton
            // 
            GenerarButton.Location = new Point(392, 714);
            GenerarButton.Name = "GenerarButton";
            GenerarButton.Size = new Size(75, 23);
            GenerarButton.TabIndex = 7;
            GenerarButton.Text = "Generar";
            GenerarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(477, 714);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(75, 23);
            CancelarButton.TabIndex = 8;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // RetiroSucursalGroupBox
            // 
            RetiroSucursalGroupBox.Controls.Add(SeleccionarButton);
            RetiroSucursalGroupBox.Controls.Add(SucursalListView);
            RetiroSucursalGroupBox.Controls.Add(LocalidadSucursalComboBox);
            RetiroSucursalGroupBox.Controls.Add(ProvinciaSucursalComboBox);
            RetiroSucursalGroupBox.Controls.Add(LocalidadSucursalLabel);
            RetiroSucursalGroupBox.Controls.Add(ProvinciaSucursalLabel);
            RetiroSucursalGroupBox.Location = new Point(24, 328);
            RetiroSucursalGroupBox.Name = "RetiroSucursalGroupBox";
            RetiroSucursalGroupBox.Size = new Size(527, 189);
            RetiroSucursalGroupBox.TabIndex = 12;
            RetiroSucursalGroupBox.TabStop = false;
            RetiroSucursalGroupBox.Text = "Retiro en Sucursal (Agencia o CD)";
            // 
            // SeleccionarButton
            // 
            SeleccionarButton.Location = new Point(436, 155);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(83, 23);
            SeleccionarButton.TabIndex = 11;
            SeleccionarButton.Text = "Seleccionar";
            SeleccionarButton.UseVisualStyleBackColor = true;
            // 
            // SucursalListView
            // 
            SucursalListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            SucursalListView.Location = new Point(14, 78);
            SucursalListView.Name = "SucursalListView";
            SucursalListView.Size = new Size(505, 69);
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
            // 
            // ProvinciaSucursalComboBox
            // 
            ProvinciaSucursalComboBox.FormattingEnabled = true;
            ProvinciaSucursalComboBox.Location = new Point(101, 30);
            ProvinciaSucursalComboBox.Name = "ProvinciaSucursalComboBox";
            ProvinciaSucursalComboBox.Size = new Size(154, 23);
            ProvinciaSucursalComboBox.TabIndex = 3;
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
            // NroAgenciaLabel
            // 
            NroAgenciaLabel.AutoSize = true;
            NroAgenciaLabel.Location = new Point(124, 24);
            NroAgenciaLabel.Name = "NroAgenciaLabel";
            NroAgenciaLabel.Size = new Size(52, 15);
            NroAgenciaLabel.TabIndex = 13;
            NroAgenciaLabel.Text = "[código]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 8;
            label1.Text = "[razonSocial]";
            // 
            // ImposicionXAgenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 746);
            Controls.Add(NroAgenciaLabel);
            Controls.Add(RetiroSucursalGroupBox);
            Controls.Add(CancelarButton);
            Controls.Add(GenerarButton);
            Controls.Add(DatosEncomiendaGroupBox);
            Controls.Add(DatosDestinatarioGroupBox);
            Controls.Add(EntregaDomicilioGroupBox);
            Controls.Add(DatosSolicitanteGroupBox);
            Controls.Add(MetodoEntregaComboBox);
            Controls.Add(CodigoAgenciaLabel);
            Controls.Add(MetodoEntregaLabel);
            Controls.Add(TutasaLabel);
            Name = "ImposicionXAgenciaForm";
            Text = "Imposición en Agencia";
            Load += ImposicionXAgenciaForm_Load;
            DatosSolicitanteGroupBox.ResumeLayout(false);
            DatosSolicitanteGroupBox.PerformLayout();
            EntregaDomicilioGroupBox.ResumeLayout(false);
            EntregaDomicilioGroupBox.PerformLayout();
            DatosDestinatarioGroupBox.ResumeLayout(false);
            DatosDestinatarioGroupBox.PerformLayout();
            DatosEncomiendaGroupBox.ResumeLayout(false);
            DatosEncomiendaGroupBox.PerformLayout();
            RetiroSucursalGroupBox.ResumeLayout(false);
            RetiroSucursalGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TutasaLabel;
        private Label CodigoAgenciaLabel;
        private GroupBox DatosSolicitanteGroupBox;
        private Label CuitLabel;
        private TextBox CuitTextBox;
        private Button ValidarButton;
        private Label RazonSocialLabel;
        private GroupBox EntregaDomicilioGroupBox;
        private ComboBox MetodoEntregaComboBox;
        private ComboBox LocalidadDomicilioComboBox;
        private ComboBox ProvinciaDomicilioComboBox;
        private Label MetodoEntregaLabel;
        private Label LocalidadDomicilioLabel;
        private Label ProvinciaDomicilioLabel;
        private TextBox DireccionTextBox;
        private TextBox CodigoPostalTextBox;
        private Label DireccionLabel;
        private Label CodigoPostalLabel;
        private GroupBox DatosDestinatarioGroupBox;
        private GroupBox DatosEncomiendaGroupBox;
        private TextBox DniTextBox;
        private TextBox NombreApellidoTextBox;
        private Label DniLabel;
        private Label NombreApellidoLabel;
        private TextBox CantidadCajasLTextBox;
        private Label CantidadCajasSLabel;
        private Button GenerarButton;
        private Button CancelarButton;
        private GroupBox RetiroSucursalGroupBox;
        private Button SeleccionarButton;
        private ListView SucursalListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ComboBox LocalidadSucursalComboBox;
        private ComboBox ProvinciaSucursalComboBox;
        private Label LocalidadSucursalLabel;
        private Label ProvinciaSucursalLabel;
        private ColumnHeader columnHeader4;
        private TextBox CantidadCajasXLTextBox;
        private TextBox CantidadCajasSTextBox;
        private TextBox CantidadCajasMTextBox;
        private Label CantidadCajasXLLabel;
        private Label CantidadCajasLLabel;
        private Label CantidadCajasMLabel;
        private Label NroAgenciaLabel;
        private Label label1;
    }
}