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
            CodCDLabel = new Label();
            DetalleHDRAsignadasGroupBox = new GroupBox();
            HDRAsignadasListView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            ConfirmarAsignacionButton = new Button();
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
            SeleccionarOmnibusGroupBox.Location = new Point(45, 171);
            SeleccionarOmnibusGroupBox.Margin = new Padding(6);
            SeleccionarOmnibusGroupBox.Name = "SeleccionarOmnibusGroupBox";
            SeleccionarOmnibusGroupBox.Padding = new Padding(6);
            SeleccionarOmnibusGroupBox.Size = new Size(1179, 241);
            SeleccionarOmnibusGroupBox.TabIndex = 10;
            SeleccionarOmnibusGroupBox.TabStop = false;
            SeleccionarOmnibusGroupBox.Text = "Seleccionar Ómnibus";
            // 
            // EmpresaComboBox
            // 
            EmpresaComboBox.FormattingEnabled = true;
            EmpresaComboBox.Location = new Point(167, 70);
            EmpresaComboBox.Margin = new Padding(4);
            EmpresaComboBox.Name = "EmpresaComboBox";
            EmpresaComboBox.Size = new Size(331, 40);
            EmpresaComboBox.TabIndex = 6;
            // 
            // HorarioSalidaDateTimePicker
            // 
            HorarioSalidaDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            HorarioSalidaDateTimePicker.Format = DateTimePickerFormat.Custom;
            HorarioSalidaDateTimePicker.Location = new Point(802, 70);
            HorarioSalidaDateTimePicker.Margin = new Padding(6);
            HorarioSalidaDateTimePicker.Name = "HorarioSalidaDateTimePicker";
            HorarioSalidaDateTimePicker.Size = new Size(288, 39);
            HorarioSalidaDateTimePicker.TabIndex = 5;
            HorarioSalidaDateTimePicker.Value = new DateTime(2026, 5, 7, 19, 0, 15, 92);
            // 
            // FechaHoraLabel
            // 
            FechaHoraLabel.AutoSize = true;
            FechaHoraLabel.Location = new Point(548, 77);
            FechaHoraLabel.Margin = new Padding(6, 0, 6, 0);
            FechaHoraLabel.Name = "FechaHoraLabel";
            FechaHoraLabel.Size = new Size(245, 32);
            FechaHoraLabel.TabIndex = 4;
            FechaHoraLabel.Text = "Fecha/Hora de Salida:";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(1012, 179);
            BuscarButton.Margin = new Padding(6);
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
            EmpresaTextoLabel.Location = new Point(20, 77);
            EmpresaTextoLabel.Margin = new Padding(6, 0, 6, 0);
            EmpresaTextoLabel.Name = "EmpresaTextoLabel";
            EmpresaTextoLabel.Size = new Size(109, 32);
            EmpresaTextoLabel.TabIndex = 0;
            EmpresaTextoLabel.Text = "Empresa:";
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(427, 26);
            TutasaTituloLabel.Margin = new Padding(6, 0, 6, 0);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(97, 32);
            TutasaTituloLabel.TabIndex = 8;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // CodCdTextoLabel
            // 
            CodCdTextoLabel.AutoSize = true;
            CodCdTextoLabel.Location = new Point(72, 73);
            CodCdTextoLabel.Margin = new Padding(6, 0, 6, 0);
            CodCdTextoLabel.Name = "CodCdTextoLabel";
            CodCdTextoLabel.Size = new Size(135, 32);
            CodCdTextoLabel.TabIndex = 7;
            CodCdTextoLabel.Text = "Código CD:";
            // 
            // CodCDLabel
            // 
            CodCDLabel.AutoSize = true;
            CodCDLabel.Location = new Point(206, 73);
            CodCDLabel.Margin = new Padding(6, 0, 6, 0);
            CodCDLabel.Name = "CodCDLabel";
            CodCDLabel.Size = new Size(112, 32);
            CodCDLabel.TabIndex = 12;
            CodCDLabel.Text = "[número]";
            // 
            // DetalleHDRAsignadasGroupBox
            // 
            DetalleHDRAsignadasGroupBox.Controls.Add(HDRAsignadasListView);
            DetalleHDRAsignadasGroupBox.Controls.Add(ConfirmarAsignacionButton);
            DetalleHDRAsignadasGroupBox.Location = new Point(45, 461);
            DetalleHDRAsignadasGroupBox.Margin = new Padding(6);
            DetalleHDRAsignadasGroupBox.Name = "DetalleHDRAsignadasGroupBox";
            DetalleHDRAsignadasGroupBox.Padding = new Padding(6);
            DetalleHDRAsignadasGroupBox.Size = new Size(1179, 467);
            DetalleHDRAsignadasGroupBox.TabIndex = 11;
            DetalleHDRAsignadasGroupBox.TabStop = false;
            DetalleHDRAsignadasGroupBox.Text = "Detalle de Hojas de Ruta de transporte asignadas";
            // 
            // HDRAsignadasListView
            // 
            HDRAsignadasListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader3, columnHeader5 });
            HDRAsignadasListView.FullRowSelect = true;
            HDRAsignadasListView.Location = new Point(30, 47);
            HDRAsignadasListView.Margin = new Padding(6);
            HDRAsignadasListView.MultiSelect = false;
            HDRAsignadasListView.Name = "HDRAsignadasListView";
            HDRAsignadasListView.Size = new Size(1118, 333);
            HDRAsignadasListView.TabIndex = 2;
            HDRAsignadasListView.UseCompatibleStateImageBehavior = false;
            HDRAsignadasListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nro de Orden";
            columnHeader4.Width = 160;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 260;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 440;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Empresa de ómnibus";
            columnHeader5.Width = 250;
            // 
            // ConfirmarAsignacionButton
            // 
            ConfirmarAsignacionButton.Location = new Point(893, 397);
            ConfirmarAsignacionButton.Margin = new Padding(6);
            ConfirmarAsignacionButton.Name = "ConfirmarAsignacionButton";
            ConfirmarAsignacionButton.Size = new Size(258, 49);
            ConfirmarAsignacionButton.TabIndex = 1;
            ConfirmarAsignacionButton.Text = "Confirmar asignación";
            ConfirmarAsignacionButton.UseVisualStyleBackColor = true;
            ConfirmarAsignacionButton.Click += ConfirmarAsignacionButton_Click;
            // 
            // DespachoEncomiendasCDForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 949);
            Controls.Add(CodCDLabel);
            Controls.Add(DetalleHDRAsignadasGroupBox);
            Controls.Add(SeleccionarOmnibusGroupBox);
            Controls.Add(TutasaTituloLabel);
            Controls.Add(CodCdTextoLabel);
            Margin = new Padding(6);
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
        private Label CodCDLabel;
        private GroupBox DetalleHDRAsignadasGroupBox;
        private ListView HDRAsignadasListView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private Button ConfirmarAsignacionButton;
        private Label FechaHoraLabel;
        private DateTimePicker HorarioSalidaDateTimePicker;
        private ComboBox EmpresaComboBox;
    }
}