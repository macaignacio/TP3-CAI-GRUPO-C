namespace TP3_CAI_GRUPO_C
{
    partial class DespachoEncomiendasCDForm
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
            SeleccionarOmnibusGroupBox = new GroupBox();
            BuscarButton = new Button();
            EmpresaTextoLabel = new Label();
            TutasaTituloLabel = new Label();
            CodCdTextoLabel = new Label();
            DetalleHDRAsignadasGroupBox = new GroupBox();
            HDRAsignadasListView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            ImprimirButton = new Button();
            CodCDLabel = new Label();
            FechaHoraLabel = new Label();
            HorarioSalidaDateTimePicker = new DateTimePicker();
            EmpresaComboBox = new ComboBox();
            SeleccionarOmnibusGroupBox.SuspendLayout();
            DetalleHDRAsignadasGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeleccionarOmnibusGroupBox
            // 
            SeleccionarOmnibusGroupBox.Controls.Add(EmpresaComboBox);
            SeleccionarOmnibusGroupBox.Controls.Add(HorarioSalidaDateTimePicker);
            SeleccionarOmnibusGroupBox.Controls.Add(FechaHoraLabel);
            SeleccionarOmnibusGroupBox.Controls.Add(BuscarButton);
            SeleccionarOmnibusGroupBox.Controls.Add(EmpresaTextoLabel);
            SeleccionarOmnibusGroupBox.Location = new Point(56, 134);
            SeleccionarOmnibusGroupBox.Margin = new Padding(4, 5, 4, 5);
            SeleccionarOmnibusGroupBox.Name = "SeleccionarOmnibusGroupBox";
            SeleccionarOmnibusGroupBox.Padding = new Padding(4, 5, 4, 5);
            SeleccionarOmnibusGroupBox.Size = new Size(632, 237);
            SeleccionarOmnibusGroupBox.TabIndex = 10;
            SeleccionarOmnibusGroupBox.TabStop = false;
            SeleccionarOmnibusGroupBox.Text = "Seleccionar Ómnibus";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(500, 173);
            BuscarButton.Margin = new Padding(4, 5, 4, 5);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(107, 38);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // EmpresaTextoLabel
            // 
            EmpresaTextoLabel.AutoSize = true;
            EmpresaTextoLabel.Location = new Point(16, 60);
            EmpresaTextoLabel.Margin = new Padding(4, 0, 4, 0);
            EmpresaTextoLabel.Name = "EmpresaTextoLabel";
            EmpresaTextoLabel.Size = new Size(84, 25);
            EmpresaTextoLabel.TabIndex = 0;
            EmpresaTextoLabel.Text = "Empresa:";
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(328, 20);
            TutasaTituloLabel.Margin = new Padding(4, 0, 4, 0);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(75, 25);
            TutasaTituloLabel.TabIndex = 8;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // CodCdTextoLabel
            // 
            CodCdTextoLabel.AutoSize = true;
            CodCdTextoLabel.Location = new Point(56, 57);
            CodCdTextoLabel.Margin = new Padding(4, 0, 4, 0);
            CodCdTextoLabel.Name = "CodCdTextoLabel";
            CodCdTextoLabel.Size = new Size(104, 25);
            CodCdTextoLabel.TabIndex = 7;
            CodCdTextoLabel.Text = "Código CD:";
            // 
            // DetalleHDRAsignadasGroupBox
            // 
            DetalleHDRAsignadasGroupBox.Controls.Add(HDRAsignadasListView);
            DetalleHDRAsignadasGroupBox.Controls.Add(ImprimirButton);
            DetalleHDRAsignadasGroupBox.Location = new Point(56, 409);
            DetalleHDRAsignadasGroupBox.Margin = new Padding(4, 5, 4, 5);
            DetalleHDRAsignadasGroupBox.Name = "DetalleHDRAsignadasGroupBox";
            DetalleHDRAsignadasGroupBox.Padding = new Padding(4, 5, 4, 5);
            DetalleHDRAsignadasGroupBox.Size = new Size(632, 365);
            DetalleHDRAsignadasGroupBox.TabIndex = 11;
            DetalleHDRAsignadasGroupBox.TabStop = false;
            DetalleHDRAsignadasGroupBox.Text = "Detalle de Hojas de Ruta de transporte asignadas";
            // 
            // HDRAsignadasListView
            // 
            HDRAsignadasListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader3, columnHeader5 });
            HDRAsignadasListView.Location = new Point(23, 37);
            HDRAsignadasListView.Margin = new Padding(4, 5, 4, 5);
            HDRAsignadasListView.Name = "HDRAsignadasListView";
            HDRAsignadasListView.Size = new Size(584, 260);
            HDRAsignadasListView.TabIndex = 2;
            HDRAsignadasListView.UseCompatibleStateImageBehavior = false;
            HDRAsignadasListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nro de Órden";
            columnHeader4.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Patente";
            columnHeader5.Width = 80;
            // 
            // ImprimirButton
            // 
            ImprimirButton.Location = new Point(448, 317);
            ImprimirButton.Margin = new Padding(4, 5, 4, 5);
            ImprimirButton.Name = "ImprimirButton";
            ImprimirButton.Size = new Size(159, 38);
            ImprimirButton.TabIndex = 1;
            ImprimirButton.Text = "Imprimir detalle";
            ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // CodCDLabel
            // 
            CodCDLabel.AutoSize = true;
            CodCDLabel.Location = new Point(159, 57);
            CodCDLabel.Margin = new Padding(4, 0, 4, 0);
            CodCDLabel.Name = "CodCDLabel";
            CodCDLabel.Size = new Size(84, 25);
            CodCDLabel.TabIndex = 12;
            CodCDLabel.Text = "[número]";
            // 
            // FechaHoraLabel
            // 
            FechaHoraLabel.AutoSize = true;
            FechaHoraLabel.Location = new Point(16, 111);
            FechaHoraLabel.Margin = new Padding(4, 0, 4, 0);
            FechaHoraLabel.Name = "FechaHoraLabel";
            FechaHoraLabel.Size = new Size(184, 25);
            FechaHoraLabel.TabIndex = 4;
            FechaHoraLabel.Text = "Fecha/Hora de Salida:";
            // 
            // HorarioSalidaDateTimePicker
            // 
            HorarioSalidaDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            HorarioSalidaDateTimePicker.Format = DateTimePickerFormat.Custom;
            HorarioSalidaDateTimePicker.Location = new Point(217, 105);
            HorarioSalidaDateTimePicker.Margin = new Padding(4, 5, 4, 5);
            HorarioSalidaDateTimePicker.Name = "HorarioSalidaDateTimePicker";
            HorarioSalidaDateTimePicker.Size = new Size(255, 31);
            HorarioSalidaDateTimePicker.TabIndex = 5;
            HorarioSalidaDateTimePicker.Value = new DateTime(2026, 4, 30, 0, 0, 0, 0);
            // 
            // EmpresaComboBox
            // 
            EmpresaComboBox.FormattingEnabled = true;
            EmpresaComboBox.Location = new Point(217, 52);
            EmpresaComboBox.Name = "EmpresaComboBox";
            EmpresaComboBox.Size = new Size(255, 33);
            EmpresaComboBox.TabIndex = 6;
            // 
            // DespachoEncomiendasCDForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 808);
            Controls.Add(CodCDLabel);
            Controls.Add(DetalleHDRAsignadasGroupBox);
            Controls.Add(SeleccionarOmnibusGroupBox);
            Controls.Add(TutasaTituloLabel);
            Controls.Add(CodCdTextoLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DespachoEncomiendasCDForm";
            Text = "Gestión de Despacho de Encomiendas de media/larga distancia";
            SeleccionarOmnibusGroupBox.ResumeLayout(false);
            SeleccionarOmnibusGroupBox.PerformLayout();
            DetalleHDRAsignadasGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox SeleccionarOmnibusGroupBox;
        private Button BuscarButton;
        private Label EmpresaTextoLabel;
        private Label TutasaTituloLabel;
        private Label CodCdTextoLabel;
        private GroupBox DetalleHDRAsignadasGroupBox;
        private ListView HDRAsignadasListView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private Button ImprimirButton;
        private Label CodCDLabel;
        private Label FechaHoraLabel;
        private DateTimePicker HorarioSalidaDateTimePicker;
        private ComboBox EmpresaComboBox;
    }
}