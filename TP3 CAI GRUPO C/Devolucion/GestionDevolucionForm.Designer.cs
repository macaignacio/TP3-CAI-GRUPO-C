namespace TP3_CAI_GRUPO_C.Devolucion
{
    partial class GestionDevolucionForm
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
            seleccionarLabel = new Label();
            OperacionGroupBox = new GroupBox();
            ContinuarButton = new Button();
            IniciarDevRadioButton = new RadioButton();
            ConfirmarDevRadioButton = new RadioButton();
            ConfirmarDevGroupBox = new GroupBox();
            ConfirmarDevolucionButton = new Button();
            DatosEncomiendaListView = new ListView();
            NumeroGuia = new ColumnHeader();
            Estado = new ColumnHeader();
            LugarDev = new ColumnHeader();
            FechaLlegada = new ColumnHeader();
            RazonSocialClienteLabel = new Label();
            BuscarButton = new Button();
            CuitTextBox = new TextBox();
            CuitLabel = new Label();
            IniciarDevGroupBox = new GroupBox();
            IniciarDevButton = new Button();
            DatosEncomiendaParaDevListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            InstruccionDevLabel = new Label();
            OperacionGroupBox.SuspendLayout();
            ConfirmarDevGroupBox.SuspendLayout();
            IniciarDevGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // seleccionarLabel
            // 
            seleccionarLabel.AutoSize = true;
            seleccionarLabel.Location = new Point(18, 29);
            seleccionarLabel.Name = "seleccionarLabel";
            seleccionarLabel.Size = new Size(116, 15);
            seleccionarLabel.TabIndex = 0;
            seleccionarLabel.Text = "Seleccione la acción:";
            // 
            // OperacionGroupBox
            // 
            OperacionGroupBox.Controls.Add(ContinuarButton);
            OperacionGroupBox.Controls.Add(IniciarDevRadioButton);
            OperacionGroupBox.Controls.Add(ConfirmarDevRadioButton);
            OperacionGroupBox.Controls.Add(seleccionarLabel);
            OperacionGroupBox.Location = new Point(20, 20);
            OperacionGroupBox.Name = "OperacionGroupBox";
            OperacionGroupBox.Size = new Size(597, 88);
            OperacionGroupBox.TabIndex = 1;
            OperacionGroupBox.TabStop = false;
            OperacionGroupBox.Text = "Operación a realizar";
            // 
            // ContinuarButton
            // 
            ContinuarButton.Location = new Point(494, 49);
            ContinuarButton.Name = "ContinuarButton";
            ContinuarButton.Size = new Size(84, 25);
            ContinuarButton.TabIndex = 3;
            ContinuarButton.Text = "Continuar";
            ContinuarButton.UseVisualStyleBackColor = true;
            ContinuarButton.Click += ContinuarButton_Click;
            // 
            // IniciarDevRadioButton
            // 
            IniciarDevRadioButton.AutoSize = true;
            IniciarDevRadioButton.Location = new Point(400, 28);
            IniciarDevRadioButton.Name = "IniciarDevRadioButton";
            IniciarDevRadioButton.Size = new Size(180, 19);
            IniciarDevRadioButton.TabIndex = 2;
            IniciarDevRadioButton.TabStop = true;
            IniciarDevRadioButton.Text = "Iniciar proceso de devolución";
            IniciarDevRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarDevRadioButton
            // 
            ConfirmarDevRadioButton.AutoSize = true;
            ConfirmarDevRadioButton.Location = new Point(160, 28);
            ConfirmarDevRadioButton.Name = "ConfirmarDevRadioButton";
            ConfirmarDevRadioButton.Size = new Size(207, 19);
            ConfirmarDevRadioButton.TabIndex = 1;
            ConfirmarDevRadioButton.TabStop = true;
            ConfirmarDevRadioButton.Text = "Confirmar devolución al remitente";
            ConfirmarDevRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarDevGroupBox
            // 
            ConfirmarDevGroupBox.Controls.Add(ConfirmarDevolucionButton);
            ConfirmarDevGroupBox.Controls.Add(DatosEncomiendaListView);
            ConfirmarDevGroupBox.Controls.Add(RazonSocialClienteLabel);
            ConfirmarDevGroupBox.Controls.Add(BuscarButton);
            ConfirmarDevGroupBox.Controls.Add(CuitTextBox);
            ConfirmarDevGroupBox.Controls.Add(CuitLabel);
            ConfirmarDevGroupBox.Location = new Point(20, 124);
            ConfirmarDevGroupBox.Name = "ConfirmarDevGroupBox";
            ConfirmarDevGroupBox.Size = new Size(1140, 238);
            ConfirmarDevGroupBox.TabIndex = 2;
            ConfirmarDevGroupBox.TabStop = false;
            ConfirmarDevGroupBox.Text = "Confirmar devolución al remitente";
            // 
            // ConfirmarDevolucionButton
            // 
            ConfirmarDevolucionButton.Location = new Point(990, 198);
            ConfirmarDevolucionButton.Name = "ConfirmarDevolucionButton";
            ConfirmarDevolucionButton.Size = new Size(132, 25);
            ConfirmarDevolucionButton.TabIndex = 4;
            ConfirmarDevolucionButton.Text = "Confirmar devolución";
            ConfirmarDevolucionButton.UseVisualStyleBackColor = true;
            ConfirmarDevolucionButton.Click += ConfirmarDevolucionButton_Click;
            // 
            // DatosEncomiendaListView
            // 
            DatosEncomiendaListView.Columns.AddRange(new ColumnHeader[] { NumeroGuia, Estado, LugarDev, FechaLlegada });
            DatosEncomiendaListView.Location = new Point(18, 64);
            DatosEncomiendaListView.Name = "DatosEncomiendaListView";
            DatosEncomiendaListView.Size = new Size(1104, 126);
            DatosEncomiendaListView.TabIndex = 7;
            DatosEncomiendaListView.UseCompatibleStateImageBehavior = false;
            DatosEncomiendaListView.View = View.Details;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Numero de Guía";
            NumeroGuia.Width = 160;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 250;
            // 
            // LugarDev
            // 
            LugarDev.Text = "Lugar de devolución";
            LugarDev.Width = 160;
            // 
            // FechaLlegada
            // 
            FechaLlegada.Text = "Fecha llegada a origen";
            FechaLlegada.Width = 160;
            // 
            // RazonSocialClienteLabel
            // 
            RazonSocialClienteLabel.AutoSize = true;
            RazonSocialClienteLabel.Location = new Point(350, 29);
            RazonSocialClienteLabel.Name = "RazonSocialClienteLabel";
            RazonSocialClienteLabel.Size = new Size(77, 15);
            RazonSocialClienteLabel.TabIndex = 9;
            RazonSocialClienteLabel.Text = "[razón social]";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(250, 24);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(84, 25);
            BuscarButton.TabIndex = 8;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(64, 25);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(167, 23);
            CuitTextBox.TabIndex = 6;
            // 
            // CuitLabel
            // 
            CuitLabel.AutoSize = true;
            CuitLabel.Location = new Point(18, 29);
            CuitLabel.Name = "CuitLabel";
            CuitLabel.Size = new Size(36, 15);
            CuitLabel.TabIndex = 4;
            CuitLabel.Text = "CUIT:";
            // 
            // IniciarDevGroupBox
            // 
            IniciarDevGroupBox.Controls.Add(IniciarDevButton);
            IniciarDevGroupBox.Controls.Add(DatosEncomiendaParaDevListView);
            IniciarDevGroupBox.Controls.Add(InstruccionDevLabel);
            IniciarDevGroupBox.Location = new Point(20, 378);
            IniciarDevGroupBox.Name = "IniciarDevGroupBox";
            IniciarDevGroupBox.Size = new Size(1140, 238);
            IniciarDevGroupBox.TabIndex = 3;
            IniciarDevGroupBox.TabStop = false;
            IniciarDevGroupBox.Text = "Iniciar devolución";
            // 
            // IniciarDevButton
            // 
            IniciarDevButton.Location = new Point(990, 198);
            IniciarDevButton.Name = "IniciarDevButton";
            IniciarDevButton.Size = new Size(132, 25);
            IniciarDevButton.TabIndex = 10;
            IniciarDevButton.Text = "Iniciar devolución";
            IniciarDevButton.UseVisualStyleBackColor = true;
            IniciarDevButton.Click += IniciarDevButton_Click;
            // 
            // DatosEncomiendaParaDevListView
            // 
            DatosEncomiendaParaDevListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader2, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            DatosEncomiendaParaDevListView.Location = new Point(18, 64);
            DatosEncomiendaParaDevListView.Name = "DatosEncomiendaParaDevListView";
            DatosEncomiendaParaDevListView.Size = new Size(1104, 126);
            DatosEncomiendaParaDevListView.TabIndex = 10;
            DatosEncomiendaParaDevListView.UseCompatibleStateImageBehavior = false;
            DatosEncomiendaParaDevListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Numero de Guía";
            columnHeader1.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 2;
            columnHeader3.Text = "Cliente";
            columnHeader3.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "Estado";
            columnHeader2.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ubicación actual";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha arribo";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Días en espera";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Destino de devolución";
            columnHeader7.Width = 150;
            // 
            // InstruccionDevLabel
            // 
            InstruccionDevLabel.AutoSize = true;
            InstruccionDevLabel.Location = new Point(18, 29);
            InstruccionDevLabel.Name = "InstruccionDevLabel";
            InstruccionDevLabel.Size = new Size(439, 15);
            InstruccionDevLabel.TabIndex = 0;
            InstruccionDevLabel.Text = "Guías disponibles para devolución por superar 15 días en CD o agencia de destino:";
            // 
            // GestionDevolucionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 636);
            Controls.Add(IniciarDevGroupBox);
            Controls.Add(ConfirmarDevGroupBox);
            Controls.Add(OperacionGroupBox);
            Name = "GestionDevolucionForm";
            Text = "Gestión de devoluciones";
            Load += GestionDevolucionForm_Load;
            OperacionGroupBox.ResumeLayout(false);
            OperacionGroupBox.PerformLayout();
            ConfirmarDevGroupBox.ResumeLayout(false);
            ConfirmarDevGroupBox.PerformLayout();
            IniciarDevGroupBox.ResumeLayout(false);
            IniciarDevGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label seleccionarLabel;
        private GroupBox OperacionGroupBox;
        private Button ContinuarButton;
        private RadioButton IniciarDevRadioButton;
        private RadioButton ConfirmarDevRadioButton;
        private GroupBox ConfirmarDevGroupBox;
        private Button ConfirmarDevolucionButton;
        private ListView DatosEncomiendaListView;
        private ColumnHeader NumeroGuia;
        private ColumnHeader Estado;
        private Label RazonSocialClienteLabel;
        private Button BuscarButton;
        private TextBox CuitTextBox;
        private Label CuitLabel;
        private GroupBox IniciarDevGroupBox;
        private Button IniciarDevButton;
        private ListView DatosEncomiendaParaDevListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label InstruccionDevLabel;
        private ColumnHeader LugarDev;
        private ColumnHeader FechaLlegada;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
