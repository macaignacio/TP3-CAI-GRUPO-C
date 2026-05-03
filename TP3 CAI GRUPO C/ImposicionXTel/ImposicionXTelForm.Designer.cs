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
            RazonSocialLabel = new Label();
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
            label1.Location = new Point(269, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
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
            DatosSolicitanteGroupBox.Location = new Point(12, 57);
            DatosSolicitanteGroupBox.Name = "DatosSolicitanteGroupBox";
            DatosSolicitanteGroupBox.Size = new Size(590, 103);
            DatosSolicitanteGroupBox.TabIndex = 1;
            DatosSolicitanteGroupBox.TabStop = false;
            DatosSolicitanteGroupBox.Text = "Datos Solicitante";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(283, 26);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 5;
            label7.Text = "Razón Social:";
            // 
            // ValidarButton
            // 
            ValidarButton.Location = new Point(169, 61);
            ValidarButton.Name = "ValidarButton";
            ValidarButton.Size = new Size(75, 23);
            ValidarButton.TabIndex = 4;
            ValidarButton.Text = "Validar";
            ValidarButton.UseVisualStyleBackColor = true;
            ValidarButton.Click += ValidarButton_Click;
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(78, 23);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(166, 23);
            CuitTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
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
            DatosRetiroGroupBox.Location = new Point(616, 57);
            DatosRetiroGroupBox.Name = "DatosRetiroGroupBox";
            DatosRetiroGroupBox.Size = new Size(590, 103);
            DatosRetiroGroupBox.TabIndex = 2;
            DatosRetiroGroupBox.TabStop = false;
            DatosRetiroGroupBox.Text = "Datos de retiro";
            // 
            // DirecRetiroTextBox
            // 
            DirecRetiroTextBox.Location = new Point(373, 62);
            DirecRetiroTextBox.Name = "DirecRetiroTextBox";
            DirecRetiroTextBox.Size = new Size(211, 23);
            DirecRetiroTextBox.TabIndex = 7;
            // 
            // CPRetiroTextBox
            // 
            CPRetiroTextBox.Location = new Point(96, 62);
            CPRetiroTextBox.Name = "CPRetiroTextBox";
            CPRetiroTextBox.Size = new Size(158, 23);
            CPRetiroTextBox.TabIndex = 6;
            // 
            // LocalidadRetiroComboBox
            // 
            LocalidadRetiroComboBox.FormattingEnabled = true;
            LocalidadRetiroComboBox.Location = new Point(373, 25);
            LocalidadRetiroComboBox.Name = "LocalidadRetiroComboBox";
            LocalidadRetiroComboBox.Size = new Size(211, 23);
            LocalidadRetiroComboBox.TabIndex = 5;
            LocalidadRetiroComboBox.Text = "*bloquear*";
            // 
            // ProvinciaRetiroComboBox
            // 
            ProvinciaRetiroComboBox.FormattingEnabled = true;
            ProvinciaRetiroComboBox.Location = new Point(96, 25);
            ProvinciaRetiroComboBox.Name = "ProvinciaRetiroComboBox";
            ProvinciaRetiroComboBox.Size = new Size(158, 23);
            ProvinciaRetiroComboBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 65);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 3;
            label6.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 62);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 2;
            label5.Text = "Código Postal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 28);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 1;
            label4.Text = "Localidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
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
            DatosEntregaGroupBox.Location = new Point(12, 245);
            DatosEntregaGroupBox.Name = "DatosEntregaGroupBox";
            DatosEntregaGroupBox.Size = new Size(596, 158);
            DatosEntregaGroupBox.TabIndex = 3;
            DatosEntregaGroupBox.TabStop = false;
            DatosEntregaGroupBox.Text = "Entrega a domicilio";
            // 
            // DirecEnvioTextBox
            // 
            DirecEnvioTextBox.Location = new Point(373, 66);
            DirecEnvioTextBox.Name = "DirecEnvioTextBox";
            DirecEnvioTextBox.Size = new Size(198, 23);
            DirecEnvioTextBox.TabIndex = 15;
            // 
            // LocalidadEnvioComboBox
            // 
            LocalidadEnvioComboBox.FormattingEnabled = true;
            LocalidadEnvioComboBox.Location = new Point(373, 25);
            LocalidadEnvioComboBox.Name = "LocalidadEnvioComboBox";
            LocalidadEnvioComboBox.Size = new Size(198, 23);
            LocalidadEnvioComboBox.TabIndex = 13;
            LocalidadEnvioComboBox.Text = "*bloquear*";
            // 
            // CPEnvioTextBox
            // 
            CPEnvioTextBox.Location = new Point(96, 66);
            CPEnvioTextBox.Name = "CPEnvioTextBox";
            CPEnvioTextBox.Size = new Size(158, 23);
            CPEnvioTextBox.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 25);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 8;
            label11.Text = "Provincia";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(283, 28);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 9;
            label10.Text = "Localidad";
            // 
            // ProvinciaEnvioComboBox
            // 
            ProvinciaEnvioComboBox.FormattingEnabled = true;
            ProvinciaEnvioComboBox.Location = new Point(96, 22);
            ProvinciaEnvioComboBox.Name = "ProvinciaEnvioComboBox";
            ProvinciaEnvioComboBox.Size = new Size(158, 23);
            ProvinciaEnvioComboBox.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 66);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 10;
            label9.Text = "Código Postal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(282, 69);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 11;
            label8.Text = "Dirección";
            // 
            // MetodoEntregaComboBox
            // 
            MetodoEntregaComboBox.FormattingEnabled = true;
            MetodoEntregaComboBox.Location = new Point(143, 192);
            MetodoEntregaComboBox.Name = "MetodoEntregaComboBox";
            MetodoEntregaComboBox.Size = new Size(179, 23);
            MetodoEntregaComboBox.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 195);
            label12.Name = "label12";
            label12.Size = new Size(108, 15);
            label12.TabIndex = 16;
            label12.Text = "Método de Entrega";
            // 
            // DatosDestinatarioGroupBox
            // 
            DatosDestinatarioGroupBox.Controls.Add(DNIDestinatarioTextBox);
            DatosDestinatarioGroupBox.Controls.Add(label13);
            DatosDestinatarioGroupBox.Controls.Add(NombreDestinatarioTextBox);
            DatosDestinatarioGroupBox.Controls.Add(label14);
            DatosDestinatarioGroupBox.Location = new Point(12, 423);
            DatosDestinatarioGroupBox.Name = "DatosDestinatarioGroupBox";
            DatosDestinatarioGroupBox.Size = new Size(594, 86);
            DatosDestinatarioGroupBox.TabIndex = 4;
            DatosDestinatarioGroupBox.TabStop = false;
            DatosDestinatarioGroupBox.Text = "Datos Destinatario";
            // 
            // DNIDestinatarioTextBox
            // 
            DNIDestinatarioTextBox.Location = new Point(373, 22);
            DNIDestinatarioTextBox.Name = "DNIDestinatarioTextBox";
            DNIDestinatarioTextBox.Size = new Size(184, 23);
            DNIDestinatarioTextBox.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(340, 26);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 5;
            label13.Text = "DNI";
            // 
            // NombreDestinatarioTextBox
            // 
            NombreDestinatarioTextBox.Location = new Point(117, 22);
            NombreDestinatarioTextBox.Name = "NombreDestinatarioTextBox";
            NombreDestinatarioTextBox.Size = new Size(166, 23);
            NombreDestinatarioTextBox.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 26);
            label14.Name = "label14";
            label14.Size = new Size(105, 15);
            label14.TabIndex = 2;
            label14.Text = "Nombre y apellido";
            // 
            // CajaSTextBox
            // 
            CajaSTextBox.Location = new Point(147, 15);
            CajaSTextBox.Name = "CajaSTextBox";
            CajaSTextBox.Size = new Size(107, 23);
            CajaSTextBox.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 23);
            label15.Name = "label15";
            label15.Size = new Size(109, 15);
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
            DatosEncomiendaGroupBox.Location = new Point(616, 423);
            DatosEncomiendaGroupBox.Name = "DatosEncomiendaGroupBox";
            DatosEncomiendaGroupBox.Size = new Size(590, 86);
            DatosEncomiendaGroupBox.TabIndex = 7;
            DatosEncomiendaGroupBox.TabStop = false;
            DatosEncomiendaGroupBox.Text = "Datos Encomienda";
            // 
            // CajaXLTextBox
            // 
            CajaXLTextBox.Location = new Point(469, 44);
            CajaXLTextBox.Name = "CajaXLTextBox";
            CajaXLTextBox.Size = new Size(107, 23);
            CajaXLTextBox.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(330, 49);
            label16.Name = "label16";
            label16.Size = new Size(116, 15);
            label16.TabIndex = 16;
            label16.Text = "Cantidad de cajas XL";
            // 
            // CajaLTextBox
            // 
            CajaLTextBox.Location = new Point(469, 15);
            CajaLTextBox.Name = "CajaLTextBox";
            CajaLTextBox.Size = new Size(107, 23);
            CajaLTextBox.TabIndex = 15;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(330, 23);
            label21.Name = "label21";
            label21.Size = new Size(109, 15);
            label21.TabIndex = 14;
            label21.Text = "Cantidad de cajas L";
            // 
            // CajaMTextBox
            // 
            CajaMTextBox.Location = new Point(147, 44);
            CajaMTextBox.Name = "CajaMTextBox";
            CajaMTextBox.Size = new Size(107, 23);
            CajaMTextBox.TabIndex = 11;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 52);
            label19.Name = "label19";
            label19.Size = new Size(114, 15);
            label19.TabIndex = 10;
            label19.Text = "Cantidad de cajas M";
            // 
            // GenerarButton
            // 
            GenerarButton.Location = new Point(1050, 530);
            GenerarButton.Name = "GenerarButton";
            GenerarButton.Size = new Size(75, 23);
            GenerarButton.TabIndex = 8;
            GenerarButton.Text = "Generar";
            GenerarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(1131, 530);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(75, 23);
            CancelarButton.TabIndex = 9;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // DatosSucurGroupBox
            // 
            DatosSucurGroupBox.Controls.Add(SeleccionarSucurButton);
            DatosSucurGroupBox.Controls.Add(RetiroSucurListView);
            DatosSucurGroupBox.Controls.Add(LocalidadSucurComboBox);
            DatosSucurGroupBox.Controls.Add(label17);
            DatosSucurGroupBox.Controls.Add(label18);
            DatosSucurGroupBox.Controls.Add(ProvinciaSucurComboBox);
            DatosSucurGroupBox.Location = new Point(616, 245);
            DatosSucurGroupBox.Name = "DatosSucurGroupBox";
            DatosSucurGroupBox.Size = new Size(590, 158);
            DatosSucurGroupBox.TabIndex = 20;
            DatosSucurGroupBox.TabStop = false;
            DatosSucurGroupBox.Text = "Retiro en sucursal (Agencia o CD)";
            // 
            // SeleccionarSucurButton
            // 
            SeleccionarSucurButton.Location = new Point(506, 128);
            SeleccionarSucurButton.Name = "SeleccionarSucurButton";
            SeleccionarSucurButton.Size = new Size(75, 23);
            SeleccionarSucurButton.TabIndex = 19;
            SeleccionarSucurButton.Text = "Seleccionar";
            SeleccionarSucurButton.UseVisualStyleBackColor = true;
            // 
            // RetiroSucurListView
            // 
            RetiroSucurListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, TipoEstablecimiento });
            RetiroSucurListView.Location = new Point(6, 57);
            RetiroSucurListView.Name = "RetiroSucurListView";
            RetiroSucurListView.Size = new Size(575, 65);
            RetiroSucurListView.TabIndex = 18;
            RetiroSucurListView.UseCompatibleStateImageBehavior = false;
            RetiroSucurListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
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
            TipoEstablecimiento.Width = 150;
            // 
            // LocalidadSucurComboBox
            // 
            LocalidadSucurComboBox.FormattingEnabled = true;
            LocalidadSucurComboBox.Location = new Point(373, 25);
            LocalidadSucurComboBox.Name = "LocalidadSucurComboBox";
            LocalidadSucurComboBox.Size = new Size(198, 23);
            LocalidadSucurComboBox.TabIndex = 13;
            LocalidadSucurComboBox.Text = "*bloquear*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 25);
            label17.Name = "label17";
            label17.Size = new Size(56, 15);
            label17.TabIndex = 8;
            label17.Text = "Provincia";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(283, 28);
            label18.Name = "label18";
            label18.Size = new Size(58, 15);
            label18.TabIndex = 9;
            label18.Text = "Localidad";
            // 
            // ProvinciaSucurComboBox
            // 
            ProvinciaSucurComboBox.FormattingEnabled = true;
            ProvinciaSucurComboBox.Location = new Point(96, 22);
            ProvinciaSucurComboBox.Name = "ProvinciaSucurComboBox";
            ProvinciaSucurComboBox.Size = new Size(158, 23);
            ProvinciaSucurComboBox.TabIndex = 12;
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new Point(362, 26);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new Size(75, 15);
            RazonSocialLabel.TabIndex = 7;
            RazonSocialLabel.Text = "[razonSocial]";
            // 
            // ImposicionXTelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 572);
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
