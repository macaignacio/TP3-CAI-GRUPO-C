namespace TP3_CAI_GRUPO_C.RecepcionEncomiendasCD
{
    partial class RecepcionEncomiendasCDForm
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
            CodigoCDLabel = new Label();
            NroCDLabel = new Label();
            DetalleHdrGroupBox = new GroupBox();
            DetalleHdrListView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            ConfirmarRecepcionButton = new Button();
            SeleccionarOmnibusGroupBox = new GroupBox();
            EmpresaComboBox = new ComboBox();
            HorarioSalidaDateTimePicker = new DateTimePicker();
            FechaHoraLabel = new Label();
            BuscarButton = new Button();
            EmpresaTextoLabel = new Label();
            DetalleHdrGroupBox.SuspendLayout();
            SeleccionarOmnibusGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaLabel
            // 
            TutasaLabel.AutoSize = true;
            TutasaLabel.Location = new Point(588, 20);
            TutasaLabel.Margin = new Padding(6, 0, 6, 0);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(97, 32);
            TutasaLabel.TabIndex = 11;
            TutasaLabel.Text = "TUTASA";
            // 
            // CodigoCDLabel
            // 
            CodigoCDLabel.AutoSize = true;
            CodigoCDLabel.Location = new Point(53, 47);
            CodigoCDLabel.Margin = new Padding(6, 0, 6, 0);
            CodigoCDLabel.Name = "CodigoCDLabel";
            CodigoCDLabel.Size = new Size(135, 32);
            CodigoCDLabel.TabIndex = 10;
            CodigoCDLabel.Text = "Código CD:";
            // 
            // NroCDLabel
            // 
            NroCDLabel.AutoSize = true;
            NroCDLabel.Location = new Point(202, 47);
            NroCDLabel.Margin = new Padding(6, 0, 6, 0);
            NroCDLabel.Name = "NroCDLabel";
            NroCDLabel.Size = new Size(101, 32);
            NroCDLabel.TabIndex = 18;
            NroCDLabel.Text = "[código]";
            // 
            // DetalleHdrGroupBox
            // 
            DetalleHdrGroupBox.Controls.Add(DetalleHdrListView);
            DetalleHdrGroupBox.Controls.Add(ConfirmarRecepcionButton);
            DetalleHdrGroupBox.Location = new Point(35, 384);
            DetalleHdrGroupBox.Margin = new Padding(6, 6, 6, 6);
            DetalleHdrGroupBox.Name = "DetalleHdrGroupBox";
            DetalleHdrGroupBox.Padding = new Padding(6, 6, 6, 6);
            DetalleHdrGroupBox.Size = new Size(1287, 487);
            DetalleHdrGroupBox.TabIndex = 14;
            DetalleHdrGroupBox.TabStop = false;
            DetalleHdrGroupBox.Text = "Detalle de Hojas de Ruta de transporte recibidas";
            // 
            // DetalleHdrListView
            // 
            DetalleHdrListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader3, columnHeader5 });
            DetalleHdrListView.FullRowSelect = true;
            DetalleHdrListView.Location = new Point(30, 47);
            DetalleHdrListView.Margin = new Padding(6, 6, 6, 6);
            DetalleHdrListView.MultiSelect = false;
            DetalleHdrListView.Name = "DetalleHdrListView";
            DetalleHdrListView.Size = new Size(1227, 358);
            DetalleHdrListView.TabIndex = 2;
            DetalleHdrListView.UseCompatibleStateImageBehavior = false;
            DetalleHdrListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nro de Orden";
            columnHeader4.Width = 180;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 170;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Empresa de ómnibus";
            columnHeader5.Width = 300;
            // 
            // ConfirmarRecepcionButton
            // 
            ConfirmarRecepcionButton.Location = new Point(1006, 417);
            ConfirmarRecepcionButton.Margin = new Padding(6, 6, 6, 6);
            ConfirmarRecepcionButton.Name = "ConfirmarRecepcionButton";
            ConfirmarRecepcionButton.Size = new Size(251, 49);
            ConfirmarRecepcionButton.TabIndex = 1;
            ConfirmarRecepcionButton.Text = "Confirmar recepción";
            ConfirmarRecepcionButton.UseVisualStyleBackColor = true;
            ConfirmarRecepcionButton.Click += ConfirmarRecepcionButton_Click;
            // 
            // SeleccionarOmnibusGroupBox
            // 
            SeleccionarOmnibusGroupBox.Controls.Add(EmpresaComboBox);
            SeleccionarOmnibusGroupBox.Controls.Add(HorarioSalidaDateTimePicker);
            SeleccionarOmnibusGroupBox.Controls.Add(FechaHoraLabel);
            SeleccionarOmnibusGroupBox.Controls.Add(BuscarButton);
            SeleccionarOmnibusGroupBox.Controls.Add(EmpresaTextoLabel);
            SeleccionarOmnibusGroupBox.Location = new Point(35, 115);
            SeleccionarOmnibusGroupBox.Margin = new Padding(6, 6, 6, 6);
            SeleccionarOmnibusGroupBox.Name = "SeleccionarOmnibusGroupBox";
            SeleccionarOmnibusGroupBox.Padding = new Padding(6, 6, 6, 6);
            SeleccionarOmnibusGroupBox.Size = new Size(1287, 246);
            SeleccionarOmnibusGroupBox.TabIndex = 19;
            SeleccionarOmnibusGroupBox.TabStop = false;
            SeleccionarOmnibusGroupBox.Text = "Seleccionar Ómnibus";
            // 
            // EmpresaComboBox
            // 
            EmpresaComboBox.FormattingEnabled = true;
            EmpresaComboBox.Location = new Point(167, 70);
            EmpresaComboBox.Margin = new Padding(4, 4, 4, 4);
            EmpresaComboBox.Name = "EmpresaComboBox";
            EmpresaComboBox.Size = new Size(331, 40);
            EmpresaComboBox.TabIndex = 6;
            // 
            // HorarioSalidaDateTimePicker
            // 
            HorarioSalidaDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            HorarioSalidaDateTimePicker.Format = DateTimePickerFormat.Custom;
            HorarioSalidaDateTimePicker.Location = new Point(937, 68);
            HorarioSalidaDateTimePicker.Margin = new Padding(6, 6, 6, 6);
            HorarioSalidaDateTimePicker.Name = "HorarioSalidaDateTimePicker";
            HorarioSalidaDateTimePicker.Size = new Size(317, 39);
            HorarioSalidaDateTimePicker.TabIndex = 5;
            HorarioSalidaDateTimePicker.Value = new DateTime(2026, 5, 7, 1, 55, 16, 563);
            // 
            // FechaHoraLabel
            // 
            FechaHoraLabel.AutoSize = true;
            FechaHoraLabel.Location = new Point(636, 71);
            FechaHoraLabel.Margin = new Padding(6, 0, 6, 0);
            FechaHoraLabel.Name = "FechaHoraLabel";
            FechaHoraLabel.Size = new Size(264, 32);
            FechaHoraLabel.TabIndex = 4;
            FechaHoraLabel.Text = "Fecha/Hora de Llegada:";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(1118, 164);
            BuscarButton.Margin = new Padding(6, 6, 6, 6);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(139, 49);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // EmpresaTextoLabel
            // 
            EmpresaTextoLabel.AutoSize = true;
            EmpresaTextoLabel.Location = new Point(20, 72);
            EmpresaTextoLabel.Margin = new Padding(6, 0, 6, 0);
            EmpresaTextoLabel.Name = "EmpresaTextoLabel";
            EmpresaTextoLabel.Size = new Size(109, 32);
            EmpresaTextoLabel.TabIndex = 0;
            EmpresaTextoLabel.Text = "Empresa:";
            // 
            // RecepcionEncomiendasCDForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 888);
            Controls.Add(SeleccionarOmnibusGroupBox);
            Controls.Add(NroCDLabel);
            Controls.Add(DetalleHdrGroupBox);
            Controls.Add(TutasaLabel);
            Controls.Add(CodigoCDLabel);
            Margin = new Padding(6, 6, 6, 6);
            Name = "RecepcionEncomiendasCDForm";
            Text = "Gestión de Recepción de Encomiendas de media/larga distancia";
            Load += RecepcionEncomiendasCDForm_Load;
            DetalleHdrGroupBox.ResumeLayout(false);
            SeleccionarOmnibusGroupBox.ResumeLayout(false);
            SeleccionarOmnibusGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TutasaLabel;
        private Label CodigoCDLabel;
        private Label NroCDLabel;
        private GroupBox DetalleHdrGroupBox;
        private ListView DetalleHdrListView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private Button ConfirmarRecepcionButton;
        private GroupBox SeleccionarOmnibusGroupBox;
        private ComboBox EmpresaComboBox;
        private DateTimePicker HorarioSalidaDateTimePicker;
        private Label FechaHoraLabel;
        private Button BuscarButton;
        private Label EmpresaTextoLabel;
    }
}