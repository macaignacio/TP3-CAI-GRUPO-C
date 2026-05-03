namespace TP3_CAI_GRUPO_C.ImposicionXTel
{
    partial class ImposicionXTelForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            DatosSolicitanteGroupBox = new GroupBox();
            RazonSocialLabel = new Label();
            label7 = new Label();
            ValidarButton = new Button();
            CuitTextBox = new TextBox();
            label2 = new Label();
            DatosRetiroGroupBox = new GroupBox();
            DirecRetiroTextBox = new TextBox();
            CPRetiroTextBox = new TextBox();
            LocalidadRetiroComboBox = new ComboBox();
            ProvinciaRetiroComboBox = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            DatosEntregaGroupBox = new GroupBox();
            DirecEnvioTextBox = new TextBox();
            LocalidadEnvioComboBox = new ComboBox();
            CPEnvioTextBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            ProvinciaEnvioComboBox = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            MetodoEntregaComboBox = new ComboBox();
            label12 = new Label();
            DatosDestinatarioGroupBox = new GroupBox();
            DNIDestinatarioTextBox = new TextBox();
            label13 = new Label();
            NombreDestinatarioTextBox = new TextBox();
            label14 = new Label();
            CajaSTextBox = new TextBox();
            label15 = new Label();
            DatosEncomiendaGroupBox = new GroupBox();
            CajaXLTextBox = new TextBox();
            label16 = new Label();
            CajaLTextBox = new TextBox();
            label21 = new Label();
            CajaMTextBox = new TextBox();
            label19 = new Label();
            GenerarButton = new Button();
            CancelarButton = new Button();
            DatosSucurGroupBox = new GroupBox();
            SeleccionarSucurButton = new Button();
            RetiroSucurListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            TipoEstablecimiento = new ColumnHeader();
            LocalidadSucurComboBox = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            ProvinciaSucurComboBox = new ComboBox();
            DatosSolicitanteGroupBox.SuspendLayout();
            DatosRetiroGroupBox.SuspendLayout();
            DatosEntregaGroupBox.SuspendLayout();
            DatosDestinatarioGroupBox.SuspendLayout();
            DatosEncomiendaGroupBox.SuspendLayout();
            DatosSucurGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
            // 
            // DatosSolicitanteGroupBox
            // 
            DatosSolicitanteGroupBox.Controls.Add(RazonSocialLabel);
            DatosSolicitanteGroupBox.Controls.Add(label7);
            DatosSolicitanteGroupBox.Controls.Add(ValidarButton);
            DatosSolicitanteGroupBox.Controls.Add(CuitTextBox);
            DatosSolicitanteGroupBox.Controls.Add(label2);
            DatosSolicitanteGroupBox.Location = new Point(17, 95);
            DatosSolicitanteGroupBox.Margin = new Padding(4, 5, 4, 5);
            DatosSolicitanteGroupBox.Name = "DatosSolicitanteGroupBox";
            DatosSolicitanteGroupBox.Padding = new Padding(4, 5, 4, 5);
            DatosSolicitanteGroupBox.Size = new Size(843, 172);
            DatosSolicitanteGroupBox.TabIndex = 1;
            DatosSolicitanteGroupBox.TabStop = false;
            DatosSolicitanteGroupBox.Text = "Datos Solicitante";
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new Point(517, 43);
            RazonSocialLabel.Margin = new Padding(4, 0, 4, 0);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new Size(112, 25);
            RazonSocialLabel.TabIndex = 7;
            RazonSocialLabel.Text = "[razonSocial]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(404, 43);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 5;
            label7.Text = "Razón Social:";
            // 
            // ValidarButton
            // 
            ValidarButton.Location = new Point(241, 102);
            ValidarButton.Margin = new Padding(4, 5, 4, 5);
            ValidarButton.Name = "ValidarButton";
            ValidarButton.Size = new Size(107, 38);
            ValidarButton.TabIndex = 4;
            ValidarButton.Text = "Validar";
            ValidarButton.UseVisualStyleBackColor = true;
            ValidarButton.Click += ValidarButton_Click;
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(111, 38);
            CuitTextBox.Margin = new Padding(4, 5, 4, 5);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(235, 31);
            CuitTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "CUIT/CUIL:";
            // 
            // DatosRetiroGroupBox
            // 
            DatosRetiroGroupBox.Controls.Add(DirecRetiroTextBox);
            DatosRetiroGroupBox.Controls.Add(CPRetiroTextBox);
            DatosRetiroGroupBox.Controls.Add(LocalidadRetiroComboBox);
            DatosRetiroGroupBox.Controls.Add(ProvinciaRetiroComboBox);
            DatosRetiroGroupBox.Controls.Add(label6);
            DatosRetiroGroupBox.Controls.Add(label5);
            DatosRetiroGroupBox.Controls.Add(label4);
            DatosRetiroGroupBox.Controls.Add(label3);
            DatosRetiroGroupBox.Location = new Point(880, 95);
            DatosRetiroGroupBox.Margin = new Padding(4, 5, 4, 5);
            DatosRetiroGroupBox.Name = "DatosRetiroGroupBox";
            DatosRetiroGroupBox.Padding = new Padding(4, 5, 4, 5);
            DatosRetiroGroupBox.Size = new Size(843, 172);
            DatosRetiroGroupBox.TabIndex = 2;
            DatosRetiroGroupBox.TabStop = false;
            DatosRetiroGroupBox.Text = "Datos de retiro";
            // 
            // DirecRetiroTextBox
            // 
            DirecRetiroTextBox.Location = new Point(533, 103);
            DirecRetiroTextBox.Margin = new Padding(4, 5, 4, 5);
            DirecRetiroTextBox.Name = "DirecRetiroTextBox";
            DirecRetiroTextBox.Size = new Size(300, 31);
            DirecRetiroTextBox.TabIndex = 7;
            // 
            // CPRetiroTextBox
            // 
            CPRetiroTextBox.Location = new Point(137, 103);
            CPRetiroTextBox.Margin = new Padding(4, 5, 4, 5);
            CPRetiroTextBox.Name = "CPRetiroTextBox";
            CPRetiroTextBox.Size = new Size(224, 31);
            CPRetiroTextBox.TabIndex = 6;
            // 
            // LocalidadRetiroComboBox
            // 
            LocalidadRetiroComboBox.FormattingEnabled = true;
            LocalidadRetiroComboBox.Location = new Point(533, 42);
            LocalidadRetiroComboBox.Margin = new Padding(4, 5, 4, 5);
            LocalidadRetiroComboBox.Name = "LocalidadRetiroComboBox";
            LocalidadRetiroComboBox.Size = new Size(300, 33);
            LocalidadRetiroComboBox.TabIndex = 5;
            LocalidadRetiroComboBox.Text = "*bloquear*";
            // 
            // ProvinciaRetiroComboBox
            // 
            ProvinciaRetiroComboBox.FormattingEnabled = true;
            ProvinciaRetiroComboBox.Location = new Point(137, 42);
            ProvinciaRetiroComboBox.Margin = new Padding(4, 5, 4, 5);
            ProvinciaRetiroComboBox.Name = "ProvinciaRetiroComboBox";
            ProvinciaRetiroComboBox.Size = new Size(224, 33);
            ProvinciaRetiroComboBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(403, 108);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 3;
            label6.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 103);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 2;
            label5.Text = "Código Postal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 47);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 1;
            label4.Text = "Localidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 47);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 0;
            label3.Text = "Provincia";
            // 
            // DatosEntregaGroupBox
            // 
            DatosEntregaGroupBox.Controls.Add(DirecEnvioTextBox);
            DatosEntregaGroupBox.Controls.Add(LocalidadEnvioComboBox);
            DatosEntregaGroupBox.Controls.Add(CPEnvioTextBox);
            DatosEntregaGroupBox.Controls.Add(label11);
            DatosEntregaGroupBox.Controls.Add(label10);
            DatosEntregaGroupBox.Controls.Add(ProvinciaEnvioComboBox);
            DatosEntregaGroupBox.Controls.Add(label9);
            DatosEntregaGroupBox.Controls.Add(label8);
            DatosEntregaGroupBox.Location = new Point(17, 408);
            DatosEntregaGroupBox.Margin = new Padding(4, 5, 4, 5);
            DatosEntregaGroupBox.Name = "DatosEntregaGroupBox";
            DatosEntregaGroupBox.Padding = new Padding(4, 5, 4, 5);
            DatosEntregaGroupBox.Size = new Size(851, 263);
            DatosEntregaGroupBox.TabIndex = 3;
            DatosEntregaGroupBox.TabStop = false;
            DatosEntregaGroupBox.Text = "Entrega a domicilio";
            // 
            // DirecEnvioTextBox
            // 
            DirecEnvioTextBox.Location = new Point(533, 110);
            DirecEnvioTextBox.Margin = new Padding(4, 5, 4, 5);
            DirecEnvioTextBox.Name = "DirecEnvioTextBox";
            DirecEnvioTextBox.Size = new Size(281, 31);
            DirecEnvioTextBox.TabIndex = 15;
            // 
            // LocalidadEnvioComboBox
            // 
            LocalidadEnvioComboBox.FormattingEnabled = true;
            LocalidadEnvioComboBox.Location = new Point(533, 42);
            LocalidadEnvioComboBox.Margin = new Padding(4, 5, 4, 5);
            LocalidadEnvioComboBox.Name = "LocalidadEnvioComboBox";
            LocalidadEnvioComboBox.Size = new Size(281, 33);
            LocalidadEnvioComboBox.TabIndex = 13;
            LocalidadEnvioComboBox.Text = "*bloquear*";
            // 
            // CPEnvioTextBox
            // 
            CPEnvioTextBox.Location = new Point(137, 110);
            CPEnvioTextBox.Margin = new Padding(4, 5, 4, 5);
            CPEnvioTextBox.Name = "CPEnvioTextBox";
            CPEnvioTextBox.Size = new Size(224, 31);
            CPEnvioTextBox.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 42);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(83, 25);
            label11.TabIndex = 8;
            label11.Text = "Provincia";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(404, 47);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(87, 25);
            label10.TabIndex = 9;
            label10.Text = "Localidad";
            // 
            // ProvinciaEnvioComboBox
            // 
            ProvinciaEnvioComboBox.FormattingEnabled = true;
            ProvinciaEnvioComboBox.Location = new Point(137, 37);
            ProvinciaEnvioComboBox.Margin = new Padding(4, 5, 4, 5);
            ProvinciaEnvioComboBox.Name = "ProvinciaEnvioComboBox";
            ProvinciaEnvioComboBox.Size = new Size(224, 33);
            ProvinciaEnvioComboBox.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 110);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 25);
            label9.TabIndex = 10;
            label9.Text = "Código Postal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 115);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 11;
            label8.Text = "Dirección";
            // 
            // MetodoEntregaComboBox
            // 
            MetodoEntregaComboBox.FormattingEnabled = true;
            MetodoEntregaComboBox.Location = new Point(204, 320);
            MetodoEntregaComboBox.Margin = new Padding(4, 5, 4, 5);
            MetodoEntregaComboBox.Name = "MetodoEntregaComboBox";
            MetodoEntregaComboBox.Size = new Size(254, 33);
            MetodoEntregaComboBox.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 325);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(166, 25);
            label12.TabIndex = 16;
            label12.Text = "Método de Entrega";
            // 
            // DatosDestinatarioGroupBox
            // 
            DatosDestinatarioGroupBox.Controls.Add(DNIDestinatarioTextBox);
            DatosDestinatarioGroupBox.Controls.Add(label13);
            DatosDestinatarioGroupBox.Controls.Add(NombreDestinatarioTextBox);
            DatosDestinatarioGroupBox.Controls.Add(label14);
            DatosDestinatarioGroupBox.Location = new Point(17, 705);
            DatosDestinatarioGroupBox.Margin = new Padding(4, 5, 4, 5);
            DatosDestinatarioGroupBox.Name = "DatosDestinatarioGroupBox";
            DatosDestinatarioGroupBox.Padding = new Padding(4, 5, 4, 5);
            DatosDestinatarioGroupBox.Size = new Size(849, 143);
            DatosDestinatarioGroupBox.TabIndex = 4;
            DatosDestinatarioGroupBox.TabStop = false;
            DatosDestinatarioGroupBox.Text = "Datos Destinatario";
            // 
            // DNIDestinatarioTextBox
            // 
            DNIDestinatarioTextBox.Location = new Point(533, 37);
            DNIDestinatarioTextBox.Margin = new Padding(4, 5, 4, 5);
            DNIDestinatarioTextBox.Name = "DNIDestinatarioTextBox";
            DNIDestinatarioTextBox.Size = new Size(261, 31);
            DNIDestinatarioTextBox.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(486, 43);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(43, 25);
            label13.TabIndex = 5;
            label13.Text = "DNI";
            // 
            // NombreDestinatarioTextBox
            // 
            NombreDestinatarioTextBox.Location = new Point(167, 37);
            NombreDestinatarioTextBox.Margin = new Padding(4, 5, 4, 5);
            NombreDestinatarioTextBox.Name = "NombreDestinatarioTextBox";
            NombreDestinatarioTextBox.Size = new Size(235, 31);
            NombreDestinatarioTextBox.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 43);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(160, 25);
            label14.TabIndex = 2;
            label14.Text = "Nombre y apellido";
            // 
            // CajaSTextBox
            // 
            CajaSTextBox.Location = new Point(210, 25);
            CajaSTextBox.Margin = new Padding(4, 5, 4, 5);
            CajaSTextBox.Name = "CajaSTextBox";
            CajaSTextBox.Size = new Size(151, 31);
            CajaSTextBox.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 38);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(166, 25);
            label15.TabIndex = 5;
            label15.Text = "Cantidad de cajas S";
            // 
            // DatosEncomiendaGroupBox
            // 
            DatosEncomiendaGroupBox.Controls.Add(CajaXLTextBox);
            DatosEncomiendaGroupBox.Controls.Add(label16);
            DatosEncomiendaGroupBox.Controls.Add(CajaLTextBox);
            DatosEncomiendaGroupBox.Controls.Add(label21);
            DatosEncomiendaGroupBox.Controls.Add(CajaMTextBox);
            DatosEncomiendaGroupBox.Controls.Add(label19);
            DatosEncomiendaGroupBox.Controls.Add(CajaSTextBox);
            DatosEncomiendaGroupBox.Controls.Add(label15);
            DatosEncomiendaGroupBox.Location = new Point(880, 705);
            DatosEncomiendaGroupBox.Margin = new Padding(4, 5, 4, 5);
            DatosEncomiendaGroupBox.Name = "DatosEncomiendaGroupBox";
            DatosEncomiendaGroupBox.Padding = new Padding(4, 5, 4, 5);
            DatosEncomiendaGroupBox.Size = new Size(843, 143);
            DatosEncomiendaGroupBox.TabIndex = 7;
            DatosEncomiendaGroupBox.TabStop = false;
            DatosEncomiendaGroupBox.Text = "Datos Encomienda";
            // 
            // CajaXLTextBox
            // 
            CajaXLTextBox.Location = new Point(670, 73);
            CajaXLTextBox.Margin = new Padding(4, 5, 4, 5);
            CajaXLTextBox.Name = "CajaXLTextBox";
            CajaXLTextBox.Size = new Size(151, 31);
            CajaXLTextBox.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(471, 82);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(175, 25);
            label16.TabIndex = 16;
            label16.Text = "Cantidad de cajas XL";
            // 
            // CajaLTextBox
            // 
            CajaLTextBox.Location = new Point(670, 25);
            CajaLTextBox.Margin = new Padding(4, 5, 4, 5);
            CajaLTextBox.Name = "CajaLTextBox";
            CajaLTextBox.Size = new Size(151, 31);
            CajaLTextBox.TabIndex = 15;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(471, 38);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(164, 25);
            label21.TabIndex = 14;
            label21.Text = "Cantidad de cajas L";
            // 
            // CajaMTextBox
            // 
            CajaMTextBox.Location = new Point(210, 73);
            CajaMTextBox.Margin = new Padding(4, 5, 4, 5);
            CajaMTextBox.Name = "CajaMTextBox";
            CajaMTextBox.Size = new Size(151, 31);
            CajaMTextBox.TabIndex = 11;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 87);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(172, 25);
            label19.TabIndex = 10;
            label19.Text = "Cantidad de cajas M";
            // 
            // GenerarButton
            // 
            GenerarButton.Location = new Point(1500, 883);
            GenerarButton.Margin = new Padding(4, 5, 4, 5);
            GenerarButton.Name = "GenerarButton";
            GenerarButton.Size = new Size(107, 38);
            GenerarButton.TabIndex = 8;
            GenerarButton.Text = "Generar";
            GenerarButton.UseVisualStyleBackColor = true;
            GenerarButton.Click += GenerarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(1616, 883);
            CancelarButton.Margin = new Padding(4, 5, 4, 5);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(107, 38);
            CancelarButton.TabIndex = 9;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // DatosSucurGroupBox
            // 
            DatosSucurGroupBox.Controls.Add(SeleccionarSucurButton);
            DatosSucurGroupBox.Controls.Add(RetiroSucurListView);
            DatosSucurGroupBox.Controls.Add(LocalidadSucurComboBox);
            DatosSucurGroupBox.Controls.Add(label17);
            DatosSucurGroupBox.Controls.Add(label18);
            DatosSucurGroupBox.Controls.Add(ProvinciaSucurComboBox);
            DatosSucurGroupBox.Location = new Point(880, 408);
            DatosSucurGroupBox.Margin = new Padding(4, 5, 4, 5);
            DatosSucurGroupBox.Name = "DatosSucurGroupBox";
            DatosSucurGroupBox.Padding = new Padding(4, 5, 4, 5);
            DatosSucurGroupBox.Size = new Size(843, 263);
            DatosSucurGroupBox.TabIndex = 20;
            DatosSucurGroupBox.TabStop = false;
            DatosSucurGroupBox.Text = "Retiro en sucursal (Agencia o CD)";
            // 
            // SeleccionarSucurButton
            // 
            SeleccionarSucurButton.Location = new Point(723, 213);
            SeleccionarSucurButton.Margin = new Padding(4, 5, 4, 5);
            SeleccionarSucurButton.Name = "SeleccionarSucurButton";
            SeleccionarSucurButton.Size = new Size(107, 38);
            SeleccionarSucurButton.TabIndex = 19;
            SeleccionarSucurButton.Text = "Seleccionar";
            SeleccionarSucurButton.UseVisualStyleBackColor = true;
            // 
            // RetiroSucurListView
            // 
            RetiroSucurListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, TipoEstablecimiento });
            RetiroSucurListView.Location = new Point(9, 95);
            RetiroSucurListView.Margin = new Padding(4, 5, 4, 5);
            RetiroSucurListView.Name = "RetiroSucurListView";
            RetiroSucurListView.Size = new Size(820, 106);
            RetiroSucurListView.TabIndex = 18;
            RetiroSucurListView.UseCompatibleStateImageBehavior = false;
            RetiroSucurListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dirección";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Horarios";
            columnHeader3.Width = 120;
            // 
            // TipoEstablecimiento
            // 
            TipoEstablecimiento.Text = "Tipo de Establecimiento";
            TipoEstablecimiento.Width = 220;
            // 
            // LocalidadSucurComboBox
            // 
            LocalidadSucurComboBox.FormattingEnabled = true;
            LocalidadSucurComboBox.Location = new Point(533, 42);
            LocalidadSucurComboBox.Margin = new Padding(4, 5, 4, 5);
            LocalidadSucurComboBox.Name = "LocalidadSucurComboBox";
            LocalidadSucurComboBox.Size = new Size(281, 33);
            LocalidadSucurComboBox.TabIndex = 13;
            LocalidadSucurComboBox.Text = "*bloquear*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(9, 42);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(83, 25);
            label17.TabIndex = 8;
            label17.Text = "Provincia";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(404, 47);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(87, 25);
            label18.TabIndex = 9;
            label18.Text = "Localidad";
            // 
            // ProvinciaSucurComboBox
            // 
            ProvinciaSucurComboBox.FormattingEnabled = true;
            ProvinciaSucurComboBox.Location = new Point(137, 37);
            ProvinciaSucurComboBox.Margin = new Padding(4, 5, 4, 5);
            ProvinciaSucurComboBox.Name = "ProvinciaSucurComboBox";
            ProvinciaSucurComboBox.Size = new Size(224, 33);
            ProvinciaSucurComboBox.TabIndex = 12;
            // 
            // ImposicionXTelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 953);
            Controls.Add(DatosSucurGroupBox);
            Controls.Add(CancelarButton);
            Controls.Add(GenerarButton);
            Controls.Add(MetodoEntregaComboBox);
            Controls.Add(label12);
            Controls.Add(DatosEncomiendaGroupBox);
            Controls.Add(DatosDestinatarioGroupBox);
            Controls.Add(DatosEntregaGroupBox);
            Controls.Add(DatosRetiroGroupBox);
            Controls.Add(DatosSolicitanteGroupBox);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ImposicionXTelForm";
            Text = "Imposición telefónica";
            Load += ImposicionXTelForm_Load;
            DatosSolicitanteGroupBox.ResumeLayout(false);
            DatosSolicitanteGroupBox.PerformLayout();
            DatosRetiroGroupBox.ResumeLayout(false);
            DatosRetiroGroupBox.PerformLayout();
            DatosEntregaGroupBox.ResumeLayout(false);
            DatosEntregaGroupBox.PerformLayout();
            DatosDestinatarioGroupBox.ResumeLayout(false);
            DatosDestinatarioGroupBox.PerformLayout();
            DatosEncomiendaGroupBox.ResumeLayout(false);
            DatosEncomiendaGroupBox.PerformLayout();
            DatosSucurGroupBox.ResumeLayout(false);
            DatosSucurGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox DatosSolicitanteGroupBox;
        private Button ValidarButton;
        private TextBox CuitTextBox;
        private Label label2;
        private GroupBox DatosRetiroGroupBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox ProvinciaRetiroComboBox;
        private TextBox DirecRetiroTextBox;
        private TextBox CPRetiroTextBox;
        private ComboBox LocalidadRetiroComboBox;
        private GroupBox DatosEntregaGroupBox;
        private TextBox RSTextBox;
        private Label label7;
        private ComboBox MetodoEntregaComboBox;
        private Label label12;
        private TextBox DirecEnvioTextBox;
        private ComboBox LocalidadEnvioComboBox;
        private TextBox CPEnvioTextBox;
        private Label label11;
        private Label label10;
        private ComboBox ProvinciaEnvioComboBox;
        private Label label9;
        private Label label8;
        private GroupBox DatosDestinatarioGroupBox;
        private TextBox DNIDestinatarioTextBox;
        private Label label13;
        private TextBox NombreDestinatarioTextBox;
        private Label label14;
        private TextBox CajaSTextBox;
        private Label label15;
        private GroupBox DatosEncomiendaGroupBox;
        private Button GenerarButton;
        private Button CancelarButton;
        private GroupBox DatosSucurGroupBox;
        private Button SeleccionarSucurButton;
        private ListView RetiroSucurListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader TipoEstablecimiento;
        private ComboBox LocalidadSucurComboBox;
        private Label label17;
        private Label label18;
        private ComboBox ProvinciaSucurComboBox;
        private TextBox CajaLTextBox;
        private Label label21;
        private TextBox CajaMTextBox;
        private Label label19;
        private Label label16;
        private TextBox CajaXLTextBox;
        private Label RazonSocialLabel;
    }
}
