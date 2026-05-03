namespace TP3_CAI_GRUPO_C.DespachoEncomiendasCD
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
            EmpresaComboBox = new ComboBox();
            HorarioSalidaDateTimePicker = new DateTimePicker();
            FechaHoraLabel = new Label();
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
            SeleccionarOmnibusGroupBox.Location = new Point(39, 80);
            SeleccionarOmnibusGroupBox.Name = "SeleccionarOmnibusGroupBox";
            SeleccionarOmnibusGroupBox.Size = new Size(442, 142);
            SeleccionarOmnibusGroupBox.TabIndex = 10;
            SeleccionarOmnibusGroupBox.TabStop = false;
            SeleccionarOmnibusGroupBox.Text = "Seleccionar Ómnibus";
            // 
            // EmpresaComboBox
            // 
            EmpresaComboBox.FormattingEnabled = true;
            EmpresaComboBox.Location = new Point(152, 31);
            EmpresaComboBox.Margin = new Padding(2, 2, 2, 2);
            EmpresaComboBox.Name = "EmpresaComboBox";
            EmpresaComboBox.Size = new Size(180, 23);
            EmpresaComboBox.TabIndex = 6;
            // 
            // HorarioSalidaDateTimePicker
            // 
            HorarioSalidaDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            HorarioSalidaDateTimePicker.Format = DateTimePickerFormat.Custom;
            HorarioSalidaDateTimePicker.Location = new Point(152, 63);
            HorarioSalidaDateTimePicker.Name = "HorarioSalidaDateTimePicker";
            HorarioSalidaDateTimePicker.Size = new Size(180, 23);
            HorarioSalidaDateTimePicker.TabIndex = 5;
            HorarioSalidaDateTimePicker.Value = new DateTime(2026, 4, 30, 0, 0, 0, 0);
            // 
            // FechaHoraLabel
            // 
            FechaHoraLabel.AutoSize = true;
            FechaHoraLabel.Location = new Point(11, 67);
            FechaHoraLabel.Name = "FechaHoraLabel";
            FechaHoraLabel.Size = new Size(122, 15);
            FechaHoraLabel.TabIndex = 4;
            FechaHoraLabel.Text = "Fecha/Hora de Salida:";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(350, 104);
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
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(230, 12);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(50, 15);
            TutasaTituloLabel.TabIndex = 8;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // CodCdTextoLabel
            // 
            CodCdTextoLabel.AutoSize = true;
            CodCdTextoLabel.Location = new Point(39, 34);
            CodCdTextoLabel.Name = "CodCdTextoLabel";
            CodCdTextoLabel.Size = new Size(68, 15);
            CodCdTextoLabel.TabIndex = 7;
            CodCdTextoLabel.Text = "Código CD:";
            // 
            // DetalleHDRAsignadasGroupBox
            // 
            DetalleHDRAsignadasGroupBox.Controls.Add(HDRAsignadasListView);
            DetalleHDRAsignadasGroupBox.Controls.Add(ImprimirButton);
            DetalleHDRAsignadasGroupBox.Location = new Point(39, 245);
            DetalleHDRAsignadasGroupBox.Name = "DetalleHDRAsignadasGroupBox";
            DetalleHDRAsignadasGroupBox.Size = new Size(442, 219);
            DetalleHDRAsignadasGroupBox.TabIndex = 11;
            DetalleHDRAsignadasGroupBox.TabStop = false;
            DetalleHDRAsignadasGroupBox.Text = "Detalle de Hojas de Ruta de transporte asignadas";
            // 
            // HDRAsignadasListView
            // 
            HDRAsignadasListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader3, columnHeader5 });
            HDRAsignadasListView.Location = new Point(16, 22);
            HDRAsignadasListView.Name = "HDRAsignadasListView";
            HDRAsignadasListView.Size = new Size(410, 158);
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
            ImprimirButton.Location = new Point(314, 190);
            ImprimirButton.Name = "ImprimirButton";
            ImprimirButton.Size = new Size(111, 23);
            ImprimirButton.TabIndex = 1;
            ImprimirButton.Text = "Imprimir detalle";
            ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // CodCDLabel
            // 
            CodCDLabel.AutoSize = true;
            CodCDLabel.Location = new Point(111, 34);
            CodCDLabel.Name = "CodCDLabel";
            CodCDLabel.Size = new Size(57, 15);
            CodCDLabel.TabIndex = 12;
            CodCDLabel.Text = "[número]";
            // 
            // DespachoEncomiendasCDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 449);
            Controls.Add(CodCDLabel);
            Controls.Add(DetalleHDRAsignadasGroupBox);
            Controls.Add(SeleccionarOmnibusGroupBox);
            Controls.Add(TutasaTituloLabel);
            Controls.Add(CodCdTextoLabel);
            Name = "DespachoEncomiendasCDForm";
            Text = "Gestión de Despacho de Encomiendas de media/larga distancia";
            Load += DespachoEncomiendasCDForm_Load;
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