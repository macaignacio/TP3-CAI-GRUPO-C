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
            DetalleHdrGroupBox = new GroupBox();
            DetalleHdrListView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            ConfirmarRecepcionButton = new Button();
            NroCDLabel = new Label();
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
            TutasaLabel.Location = new Point(213, 9);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(50, 15);
            TutasaLabel.TabIndex = 11;
            TutasaLabel.Text = "TUTASA";
            // 
            // CodigoCDLabel
            // 
            CodigoCDLabel.AutoSize = true;
            CodigoCDLabel.Location = new Point(12, 24);
            CodigoCDLabel.Name = "CodigoCDLabel";
            CodigoCDLabel.Size = new Size(68, 15);
            CodigoCDLabel.TabIndex = 10;
            CodigoCDLabel.Text = "Código CD:";
            // 
            // DetalleHdrGroupBox
            // 
            DetalleHdrGroupBox.Controls.Add(DetalleHdrListView);
            DetalleHdrGroupBox.Controls.Add(ConfirmarRecepcionButton);
            DetalleHdrGroupBox.Location = new Point(12, 180);
            DetalleHdrGroupBox.Name = "DetalleHdrGroupBox";
            DetalleHdrGroupBox.Size = new Size(567, 226);
            DetalleHdrGroupBox.TabIndex = 14;
            DetalleHdrGroupBox.TabStop = false;
            DetalleHdrGroupBox.Text = "Detalle de Hojas de Ruta de transporte recibidas";
            // 
            // DetalleHdrListView
            // 
            DetalleHdrListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader3, columnHeader5 });
            DetalleHdrListView.Location = new Point(16, 22);
            DetalleHdrListView.Name = "DetalleHdrListView";
            DetalleHdrListView.Size = new Size(545, 170);
            DetalleHdrListView.TabIndex = 2;
            DetalleHdrListView.UseCompatibleStateImageBehavior = false;
            DetalleHdrListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nro de Órden";
            columnHeader4.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Empresa de ómnibus";
            columnHeader5.Width = 150;
            // 
            // ConfirmarRecepcionButton
            // 
            ConfirmarRecepcionButton.Location = new Point(422, 197);
            ConfirmarRecepcionButton.Name = "ConfirmarRecepcionButton";
            ConfirmarRecepcionButton.Size = new Size(135, 23);
            ConfirmarRecepcionButton.TabIndex = 1;
            ConfirmarRecepcionButton.Text = "Confirmar recepción";
            ConfirmarRecepcionButton.UseVisualStyleBackColor = true;
            // 
            // NroCDLabel
            // 
            NroCDLabel.AutoSize = true;
            NroCDLabel.Location = new Point(92, 24);
            NroCDLabel.Name = "NroCDLabel";
            NroCDLabel.Size = new Size(52, 15);
            NroCDLabel.TabIndex = 18;
            NroCDLabel.Text = "[código]";
            // 
            // SeleccionarOmnibusGroupBox
            // 
            SeleccionarOmnibusGroupBox.Controls.Add(EmpresaComboBox);
            SeleccionarOmnibusGroupBox.Controls.Add(HorarioSalidaDateTimePicker);
            SeleccionarOmnibusGroupBox.Controls.Add(FechaHoraLabel);
            SeleccionarOmnibusGroupBox.Controls.Add(BuscarButton);
            SeleccionarOmnibusGroupBox.Controls.Add(EmpresaTextoLabel);
            SeleccionarOmnibusGroupBox.Location = new Point(12, 54);
            SeleccionarOmnibusGroupBox.Name = "SeleccionarOmnibusGroupBox";
            SeleccionarOmnibusGroupBox.Size = new Size(567, 113);
            SeleccionarOmnibusGroupBox.TabIndex = 19;
            SeleccionarOmnibusGroupBox.TabStop = false;
            SeleccionarOmnibusGroupBox.Text = "Seleccionar Ómnibus";
            // 
            // EmpresaComboBox
            // 
            EmpresaComboBox.FormattingEnabled = true;
            EmpresaComboBox.Location = new Point(90, 33);
            EmpresaComboBox.Margin = new Padding(2);
            EmpresaComboBox.Name = "EmpresaComboBox";
            EmpresaComboBox.Size = new Size(180, 23);
            EmpresaComboBox.TabIndex = 6;
            // 
            // HorarioSalidaDateTimePicker
            // 
            HorarioSalidaDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            HorarioSalidaDateTimePicker.Format = DateTimePickerFormat.Custom;
            HorarioSalidaDateTimePicker.Location = new Point(422, 33);
            HorarioSalidaDateTimePicker.Name = "HorarioSalidaDateTimePicker";
            HorarioSalidaDateTimePicker.Size = new Size(139, 23);
            HorarioSalidaDateTimePicker.TabIndex = 5;
            HorarioSalidaDateTimePicker.Value = new DateTime(2026, 4, 30, 0, 0, 0, 0);
            // 
            // FechaHoraLabel
            // 
            FechaHoraLabel.AutoSize = true;
            FechaHoraLabel.Location = new Point(285, 36);
            FechaHoraLabel.Name = "FechaHoraLabel";
            FechaHoraLabel.Size = new Size(122, 15);
            FechaHoraLabel.TabIndex = 4;
            FechaHoraLabel.Text = "Fecha/Hora de Salida:";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(486, 78);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // EmpresaTextoLabel
            // 
            EmpresaTextoLabel.AutoSize = true;
            EmpresaTextoLabel.Location = new Point(11, 36);
            EmpresaTextoLabel.Name = "EmpresaTextoLabel";
            EmpresaTextoLabel.Size = new Size(55, 15);
            EmpresaTextoLabel.TabIndex = 0;
            EmpresaTextoLabel.Text = "Empresa:";
            // 
            // RecepcionEncomiendasCDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 438);
            Controls.Add(SeleccionarOmnibusGroupBox);
            Controls.Add(NroCDLabel);
            Controls.Add(DetalleHdrGroupBox);
            Controls.Add(TutasaLabel);
            Controls.Add(CodigoCDLabel);
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

        private TextBox textBox1;
        private Label TutasaLabel;
        private Label CodigoCDLabel;
        private GroupBox DetalleHdrGroupBox;
        private ListView DetalleHdrListView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private Button ConfirmarRecepcionButton;
        private Label NroCDLabel;
        private GroupBox SeleccionarOmnibusGroupBox;
        private ComboBox EmpresaComboBox;
        private DateTimePicker HorarioSalidaDateTimePicker;
        private Label FechaHoraLabel;
        private Button BuscarButton;
        private Label EmpresaTextoLabel;
    }
}