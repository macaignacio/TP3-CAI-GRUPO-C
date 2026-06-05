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
            CodigoCDLabel.Location = new Point(37, 66);
            CodigoCDLabel.Margin = new Padding(6, 0, 6, 0);
            CodigoCDLabel.Name = "CodigoCDLabel";
            CodigoCDLabel.Size = new Size(135, 32);
            CodigoCDLabel.TabIndex = 0;
            CodigoCDLabel.Text = "Código CD:";
            // 
            // TutasaLabel
            // 
            TutasaLabel.AutoSize = true;
            TutasaLabel.Location = new Point(468, 66);
            TutasaLabel.Margin = new Padding(6, 0, 6, 0);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(97, 32);
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
            DatosSolicitanteGroupBox.Location = new Point(37, 122);
            DatosSolicitanteGroupBox.Margin = new Padding(6, 6, 6, 6);
            DatosSolicitanteGroupBox.Name = "DatosSolicitanteGroupBox";
            DatosSolicitanteGroupBox.Padding = new Padding(6, 6, 6, 6);
            DatosSolicitanteGroupBox.Size = new Size(982, 213);
            DatosSolicitanteGroupBox.TabIndex = 3;
            DatosSolicitanteGroupBox.TabStop = false;
            DatosSolicitanteGroupBox.Text = "Datos Solicitante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(687, 73);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 8;
            label1.Text = "[razonSocial]";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(165, 66);
            CuitTextBox.Margin = new Padding(6, 6, 6, 6);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(355, 39);
            CuitTextBox.TabIndex = 3;
            // 
            // ValidarButton
            // 
            ValidarButton.Location = new Point(384, 151);
            ValidarButton.Margin = new Padding(6, 6, 6, 6);
            ValidarButton.Name = "ValidarButton";
            ValidarButton.Size = new Size(139, 49);
            ValidarButton.TabIndex = 2;
            ValidarButton.Text = "Validar";
            ValidarButton.UseVisualStyleBackColor = true;
            ValidarButton.Click += ValidarButton_Click;
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new Point(535, 73);
            RazonSocialLabel.Margin = new Padding(6, 0, 6, 0);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new Size(153, 32);
            RazonSocialLabel.TabIndex = 1;
            RazonSocialLabel.Text = "Razón Social:";
            // 
            // CuitLabel
            // 
            CuitLabel.AutoSize = true;
            CuitLabel.Location = new Point(32, 73);
            CuitLabel.Margin = new Padding(6, 0, 6, 0);
            CuitLabel.Name = "CuitLabel";
            CuitLabel.Size = new Size(126, 32);
            CuitLabel.TabIndex = 0;
            CuitLabel.Text = "CUIT/CUIL:";
            // 
            // DatosDestinatarioGroupBox
            // 
            DatosDestinatarioGroupBox.Controls.Add(DniTextBox);
            DatosDestinatarioGroupBox.Controls.Add(NombreApellidoTextBox);
            DatosDestinatarioGroupBox.Controls.Add(DniLabel);
            DatosDestinatarioGroupBox.Controls.Add(NombreApellidoLabel);
            DatosDestinatarioGroupBox.Location = new Point(32, 1114);
            DatosDestinatarioGroupBox.Margin = new Padding(6, 6, 6, 6);
            DatosDestinatarioGroupBox.Name = "DatosDestinatarioGroupBox";
            DatosDestinatarioGroupBox.Padding = new Padding(6, 6, 6, 6);
            DatosDestinatarioGroupBox.Size = new Size(977, 149);
            DatosDestinatarioGroupBox.TabIndex = 5;
            DatosDestinatarioGroupBox.TabStop = false;
            DatosDestinatarioGroupBox.Text = "Datos Destinatario";
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(687, 62);
            DniTextBox.Margin = new Padding(6, 6, 6, 6);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(281, 39);
            DniTextBox.TabIndex = 3;
            // 
            // NombreApellidoTextBox
            // 
            NombreApellidoTextBox.Location = new Point(228, 62);
            NombreApellidoTextBox.Margin = new Padding(6, 6, 6, 6);
            NombreApellidoTextBox.Name = "NombreApellidoTextBox";
            NombreApellidoTextBox.Size = new Size(374, 39);
            NombreApellidoTextBox.TabIndex = 2;
            // 
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Location = new Point(626, 68);
            DniLabel.Margin = new Padding(6, 0, 6, 0);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(55, 32);
            DniLabel.TabIndex = 1;
            DniLabel.Text = "DNI";
            // 
            // NombreApellidoLabel
            // 
            NombreApellidoLabel.AutoSize = true;
            NombreApellidoLabel.Location = new Point(11, 68);
            NombreApellidoLabel.Margin = new Padding(6, 0, 6, 0);
            NombreApellidoLabel.Name = "NombreApellidoLabel";
            NombreApellidoLabel.Size = new Size(213, 32);
            NombreApellidoLabel.TabIndex = 0;
            NombreApellidoLabel.Text = "Nombre y apellido";
            // 
            // GenerarButton
            // 
            GenerarButton.Location = new Point(719, 1527);
            GenerarButton.Margin = new Padding(6, 6, 6, 6);
            GenerarButton.Name = "GenerarButton";
            GenerarButton.Size = new Size(139, 49);
            GenerarButton.TabIndex = 7;
            GenerarButton.Text = "Generar";
            GenerarButton.UseVisualStyleBackColor = true;
            GenerarButton.Click += GenerarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(880, 1527);
            CancelarButton.Margin = new Padding(6, 6, 6, 6);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(139, 49);
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
            RetiroSucursalGroupBox.Location = new Point(32, 698);
            RetiroSucursalGroupBox.Margin = new Padding(6, 6, 6, 6);
            RetiroSucursalGroupBox.Name = "RetiroSucursalGroupBox";
            RetiroSucursalGroupBox.Padding = new Padding(6, 6, 6, 6);
            RetiroSucursalGroupBox.Size = new Size(979, 403);
            RetiroSucursalGroupBox.TabIndex = 16;
            RetiroSucursalGroupBox.TabStop = false;
            RetiroSucursalGroupBox.Text = "Entrega en Sucursal (Agencia o CD)";
            // 
            // SucursalListView
            // 
            SucursalListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            SucursalListView.Location = new Point(26, 147);
            SucursalListView.Margin = new Padding(6, 6, 6, 6);
            SucursalListView.Name = "SucursalListView";
            SucursalListView.Size = new Size(934, 239);
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
            LocalidadSucursalComboBox.Location = new Point(624, 68);
            LocalidadSucursalComboBox.Margin = new Padding(6, 6, 6, 6);
            LocalidadSucursalComboBox.Name = "LocalidadSucursalComboBox";
            LocalidadSucursalComboBox.Size = new Size(327, 40);
            LocalidadSucursalComboBox.TabIndex = 4;
            LocalidadSucursalComboBox.Text = "*bloquear*";
            LocalidadSucursalComboBox.SelectedIndexChanged += LocalidadSucursalComboBox_SelectedIndexChanged;
            // 
            // ProvinciaSucursalComboBox
            // 
            ProvinciaSucursalComboBox.FormattingEnabled = true;
            ProvinciaSucursalComboBox.Location = new Point(188, 64);
            ProvinciaSucursalComboBox.Margin = new Padding(6, 6, 6, 6);
            ProvinciaSucursalComboBox.Name = "ProvinciaSucursalComboBox";
            ProvinciaSucursalComboBox.Size = new Size(283, 40);
            ProvinciaSucursalComboBox.TabIndex = 3;
            ProvinciaSucursalComboBox.SelectedIndexChanged += ProvinciaSucursalComboBox_SelectedIndexChanged;
            // 
            // LocalidadSucursalLabel
            // 
            LocalidadSucursalLabel.AutoSize = true;
            LocalidadSucursalLabel.Location = new Point(485, 75);
            LocalidadSucursalLabel.Margin = new Padding(6, 0, 6, 0);
            LocalidadSucursalLabel.Name = "LocalidadSucursalLabel";
            LocalidadSucursalLabel.Size = new Size(114, 32);
            LocalidadSucursalLabel.TabIndex = 1;
            LocalidadSucursalLabel.Text = "Localidad";
            // 
            // ProvinciaSucursalLabel
            // 
            ProvinciaSucursalLabel.AutoSize = true;
            ProvinciaSucursalLabel.Location = new Point(28, 68);
            ProvinciaSucursalLabel.Margin = new Padding(6, 0, 6, 0);
            ProvinciaSucursalLabel.Name = "ProvinciaSucursalLabel";
            ProvinciaSucursalLabel.Size = new Size(110, 32);
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
            EntregaDomicilioGroupBox.Location = new Point(32, 437);
            EntregaDomicilioGroupBox.Margin = new Padding(6, 6, 6, 6);
            EntregaDomicilioGroupBox.Name = "EntregaDomicilioGroupBox";
            EntregaDomicilioGroupBox.Padding = new Padding(6, 6, 6, 6);
            EntregaDomicilioGroupBox.Size = new Size(979, 226);
            EntregaDomicilioGroupBox.TabIndex = 14;
            EntregaDomicilioGroupBox.TabStop = false;
            EntregaDomicilioGroupBox.Text = "Entrega a Domicilio";
            // 
            // DireccionTextBox
            // 
            DireccionTextBox.Location = new Point(624, 130);
            DireccionTextBox.Margin = new Padding(6, 6, 6, 6);
            DireccionTextBox.Name = "DireccionTextBox";
            DireccionTextBox.Size = new Size(325, 39);
            DireccionTextBox.TabIndex = 9;
            // 
            // CodigoPostalTextBox
            // 
            CodigoPostalTextBox.Location = new Point(188, 130);
            CodigoPostalTextBox.Margin = new Padding(6, 6, 6, 6);
            CodigoPostalTextBox.Name = "CodigoPostalTextBox";
            CodigoPostalTextBox.Size = new Size(283, 39);
            CodigoPostalTextBox.TabIndex = 8;
            // 
            // DireccionLabel
            // 
            DireccionLabel.AutoSize = true;
            DireccionLabel.Location = new Point(485, 137);
            DireccionLabel.Margin = new Padding(6, 0, 6, 0);
            DireccionLabel.Name = "DireccionLabel";
            DireccionLabel.Size = new Size(114, 32);
            DireccionLabel.TabIndex = 7;
            DireccionLabel.Text = "Dirección";
            // 
            // CodigoPostalLabel
            // 
            CodigoPostalLabel.AutoSize = true;
            CodigoPostalLabel.Location = new Point(26, 137);
            CodigoPostalLabel.Margin = new Padding(6, 0, 6, 0);
            CodigoPostalLabel.Name = "CodigoPostalLabel";
            CodigoPostalLabel.Size = new Size(160, 32);
            CodigoPostalLabel.TabIndex = 6;
            CodigoPostalLabel.Text = "Código Postal";
            // 
            // LocalidadDomicilioComboBox
            // 
            LocalidadDomicilioComboBox.FormattingEnabled = true;
            LocalidadDomicilioComboBox.Location = new Point(622, 68);
            LocalidadDomicilioComboBox.Margin = new Padding(6, 6, 6, 6);
            LocalidadDomicilioComboBox.Name = "LocalidadDomicilioComboBox";
            LocalidadDomicilioComboBox.Size = new Size(327, 40);
            LocalidadDomicilioComboBox.TabIndex = 4;
            LocalidadDomicilioComboBox.Text = "*bloquear*";
            // 
            // ProvinciaDomicilioComboBox
            // 
            ProvinciaDomicilioComboBox.FormattingEnabled = true;
            ProvinciaDomicilioComboBox.Location = new Point(188, 64);
            ProvinciaDomicilioComboBox.Margin = new Padding(6, 6, 6, 6);
            ProvinciaDomicilioComboBox.Name = "ProvinciaDomicilioComboBox";
            ProvinciaDomicilioComboBox.Size = new Size(283, 40);
            ProvinciaDomicilioComboBox.TabIndex = 3;
            ProvinciaDomicilioComboBox.SelectedIndexChanged += ProvinciaDomicilioComboBox_SelectedIndexChanged;
            // 
            // LocalidadDomicilioLabel
            // 
            LocalidadDomicilioLabel.AutoSize = true;
            LocalidadDomicilioLabel.Location = new Point(485, 68);
            LocalidadDomicilioLabel.Margin = new Padding(6, 0, 6, 0);
            LocalidadDomicilioLabel.Name = "LocalidadDomicilioLabel";
            LocalidadDomicilioLabel.Size = new Size(114, 32);
            LocalidadDomicilioLabel.TabIndex = 1;
            LocalidadDomicilioLabel.Text = "Localidad";
            // 
            // ProvinciaDomicilioLabel
            // 
            ProvinciaDomicilioLabel.AutoSize = true;
            ProvinciaDomicilioLabel.Location = new Point(28, 68);
            ProvinciaDomicilioLabel.Margin = new Padding(6, 0, 6, 0);
            ProvinciaDomicilioLabel.Name = "ProvinciaDomicilioLabel";
            ProvinciaDomicilioLabel.Size = new Size(110, 32);
            ProvinciaDomicilioLabel.TabIndex = 0;
            ProvinciaDomicilioLabel.Text = "Provincia";
            // 
            // MetodoEntregaComboBox
            // 
            MetodoEntregaComboBox.FormattingEnabled = true;
            MetodoEntregaComboBox.Location = new Point(262, 356);
            MetodoEntregaComboBox.Margin = new Padding(6, 6, 6, 6);
            MetodoEntregaComboBox.Name = "MetodoEntregaComboBox";
            MetodoEntregaComboBox.Size = new Size(262, 40);
            MetodoEntregaComboBox.TabIndex = 15;
            MetodoEntregaComboBox.SelectedIndexChanged += MetodoEntregaComboBox_SelectedIndexChanged;
            // 
            // MetodoEntregaLabel
            // 
            MetodoEntregaLabel.AutoSize = true;
            MetodoEntregaLabel.Location = new Point(50, 365);
            MetodoEntregaLabel.Margin = new Padding(6, 0, 6, 0);
            MetodoEntregaLabel.Name = "MetodoEntregaLabel";
            MetodoEntregaLabel.Size = new Size(221, 32);
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
            DatosEncomiendaGroupBox.Location = new Point(32, 1276);
            DatosEncomiendaGroupBox.Margin = new Padding(6, 6, 6, 6);
            DatosEncomiendaGroupBox.Name = "DatosEncomiendaGroupBox";
            DatosEncomiendaGroupBox.Padding = new Padding(6, 6, 6, 6);
            DatosEncomiendaGroupBox.Size = new Size(979, 215);
            DatosEncomiendaGroupBox.TabIndex = 12;
            DatosEncomiendaGroupBox.TabStop = false;
            DatosEncomiendaGroupBox.Text = "Datos Encomienda";
            // 
            // CantidadCajasXLLabel
            // 
            CantidadCajasXLLabel.AutoSize = true;
            CantidadCajasXLLabel.Location = new Point(485, 128);
            CantidadCajasXLLabel.Margin = new Padding(6, 0, 6, 0);
            CantidadCajasXLLabel.Name = "CantidadCajasXLLabel";
            CantidadCajasXLLabel.Size = new Size(233, 32);
            CantidadCajasXLLabel.TabIndex = 19;
            CantidadCajasXLLabel.Text = "Cantidad de cajas XL";
            // 
            // CantidadCajasLLabel
            // 
            CantidadCajasLLabel.AutoSize = true;
            CantidadCajasLLabel.Location = new Point(485, 73);
            CantidadCajasLLabel.Margin = new Padding(6, 0, 6, 0);
            CantidadCajasLLabel.Name = "CantidadCajasLLabel";
            CantidadCajasLLabel.Size = new Size(219, 32);
            CantidadCajasLLabel.TabIndex = 18;
            CantidadCajasLLabel.Text = "Cantidad de cajas L";
            // 
            // CantidadCajasMLabel
            // 
            CantidadCajasMLabel.AutoSize = true;
            CantidadCajasMLabel.Location = new Point(22, 124);
            CantidadCajasMLabel.Margin = new Padding(6, 0, 6, 0);
            CantidadCajasMLabel.Name = "CantidadCajasMLabel";
            CantidadCajasMLabel.Size = new Size(230, 32);
            CantidadCajasMLabel.TabIndex = 17;
            CantidadCajasMLabel.Text = "Cantidad de cajas M";
            // 
            // CantidadCajasXLTextBox
            // 
            CantidadCajasXLTextBox.Location = new Point(730, 117);
            CantidadCajasXLTextBox.Margin = new Padding(6, 6, 6, 6);
            CantidadCajasXLTextBox.Name = "CantidadCajasXLTextBox";
            CantidadCajasXLTextBox.Size = new Size(182, 39);
            CantidadCajasXLTextBox.TabIndex = 6;
            // 
            // CantidadCajasSTextBox
            // 
            CantidadCajasSTextBox.Location = new Point(258, 55);
            CantidadCajasSTextBox.Margin = new Padding(6, 6, 6, 6);
            CantidadCajasSTextBox.Name = "CantidadCajasSTextBox";
            CantidadCajasSTextBox.Size = new Size(182, 39);
            CantidadCajasSTextBox.TabIndex = 5;
            // 
            // CantidadCajasMTextBox
            // 
            CantidadCajasMTextBox.Location = new Point(258, 117);
            CantidadCajasMTextBox.Margin = new Padding(6, 6, 6, 6);
            CantidadCajasMTextBox.Name = "CantidadCajasMTextBox";
            CantidadCajasMTextBox.Size = new Size(182, 39);
            CantidadCajasMTextBox.TabIndex = 4;
            // 
            // CantidadCajasLTextBox
            // 
            CantidadCajasLTextBox.Location = new Point(730, 55);
            CantidadCajasLTextBox.Margin = new Padding(6, 6, 6, 6);
            CantidadCajasLTextBox.Name = "CantidadCajasLTextBox";
            CantidadCajasLTextBox.Size = new Size(182, 39);
            CantidadCajasLTextBox.TabIndex = 3;
            // 
            // CantidadCajasSLabel
            // 
            CantidadCajasSLabel.AutoSize = true;
            CantidadCajasSLabel.Location = new Point(22, 73);
            CantidadCajasSLabel.Margin = new Padding(6, 0, 6, 0);
            CantidadCajasSLabel.Name = "CantidadCajasSLabel";
            CantidadCajasSLabel.Size = new Size(221, 32);
            CantidadCajasSLabel.TabIndex = 1;
            CantidadCajasSLabel.Text = "Cantidad de cajas S";
            // 
            // NroCDLabel
            // 
            NroCDLabel.AutoSize = true;
            NroCDLabel.Location = new Point(180, 66);
            NroCDLabel.Margin = new Padding(6, 0, 6, 0);
            NroCDLabel.Name = "NroCDLabel";
            NroCDLabel.Size = new Size(101, 32);
            NroCDLabel.TabIndex = 17;
            NroCDLabel.Text = "[código]";
            // 
            // ImposiciónXCDForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1042, 1598);
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
            Margin = new Padding(6, 6, 6, 6);
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
