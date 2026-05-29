namespace TP3_CAI_GRUPO_C.ResultadosCostoVenta
{
    partial class ResultadosCostoVentaForm
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
            PeriodoConsultaGroupBox = new GroupBox();
            PeriodoDateTimePicker = new DateTimePicker();
            PeriodoLabel = new Label();
            ConsultarButton = new Button();
            ResultadoOperativoGroupBox = new GroupBox();
            ResultadoOperativoListView = new ListView();
            EmpresaOmnibus = new ColumnHeader();
            Ventas = new ColumnHeader();
            Costos = new ColumnHeader();
            Utilidad = new ColumnHeader();
            LimpiarButton = new Button();
            PeriodoConsultaGroupBox.SuspendLayout();
            ResultadoOperativoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaLabel
            // 
            TutasaLabel.AutoSize = true;
            TutasaLabel.Location = new Point(200, 23);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(50, 15);
            TutasaLabel.TabIndex = 0;
            TutasaLabel.Text = "TUTASA";
            // 
            // PeriodoConsultaGroupBox
            // 
            PeriodoConsultaGroupBox.Controls.Add(PeriodoDateTimePicker);
            PeriodoConsultaGroupBox.Controls.Add(PeriodoLabel);
            PeriodoConsultaGroupBox.Controls.Add(ConsultarButton);
            PeriodoConsultaGroupBox.Location = new Point(40, 52);
            PeriodoConsultaGroupBox.Name = "PeriodoConsultaGroupBox";
            PeriodoConsultaGroupBox.Size = new Size(467, 89);
            PeriodoConsultaGroupBox.TabIndex = 1;
            PeriodoConsultaGroupBox.TabStop = false;
            PeriodoConsultaGroupBox.Text = "Período de Consulta";
            // 
            // PeriodoDateTimePicker
            // 
            PeriodoDateTimePicker.CustomFormat = "MMMMyyyy";
            PeriodoDateTimePicker.Format = DateTimePickerFormat.Custom;
            PeriodoDateTimePicker.Location = new Point(91, 40);
            PeriodoDateTimePicker.Name = "PeriodoDateTimePicker";
            PeriodoDateTimePicker.ShowCheckBox = true;
            PeriodoDateTimePicker.ShowUpDown = true;
            PeriodoDateTimePicker.Size = new Size(180, 23);
            PeriodoDateTimePicker.TabIndex = 6;
            PeriodoDateTimePicker.Value = new DateTime(2026, 4, 30, 0, 0, 0, 0);
            // 
            // PeriodoLabel
            // 
            PeriodoLabel.AutoSize = true;
            PeriodoLabel.Location = new Point(15, 43);
            PeriodoLabel.Name = "PeriodoLabel";
            PeriodoLabel.Size = new Size(51, 15);
            PeriodoLabel.TabIndex = 5;
            PeriodoLabel.Text = "Período:";
            // 
            // ConsultarButton
            // 
            ConsultarButton.Location = new Point(311, 39);
            ConsultarButton.Name = "ConsultarButton";
            ConsultarButton.Size = new Size(75, 23);
            ConsultarButton.TabIndex = 2;
            ConsultarButton.Text = "Consultar";
            ConsultarButton.UseVisualStyleBackColor = true;
            // 
            // ResultadoOperativoGroupBox
            // 
            ResultadoOperativoGroupBox.Controls.Add(ResultadoOperativoListView);
            ResultadoOperativoGroupBox.Location = new Point(40, 175);
            ResultadoOperativoGroupBox.Name = "ResultadoOperativoGroupBox";
            ResultadoOperativoGroupBox.Size = new Size(467, 175);
            ResultadoOperativoGroupBox.TabIndex = 2;
            ResultadoOperativoGroupBox.TabStop = false;
            ResultadoOperativoGroupBox.Text = "Resultado Operativo";
            // 
            // ResultadoOperativoListView
            // 
            ResultadoOperativoListView.Columns.AddRange(new ColumnHeader[] { EmpresaOmnibus, Ventas, Costos, Utilidad });
            ResultadoOperativoListView.Location = new Point(11, 25);
            ResultadoOperativoListView.Name = "ResultadoOperativoListView";
            ResultadoOperativoListView.Size = new Size(441, 134);
            ResultadoOperativoListView.TabIndex = 0;
            ResultadoOperativoListView.UseCompatibleStateImageBehavior = false;
            ResultadoOperativoListView.View = View.Details;
            // 
            // EmpresaOmnibus
            // 
            EmpresaOmnibus.Text = "Empresa de Ómnibus";
            EmpresaOmnibus.Width = 210;
            // 
            // Ventas
            // 
            Ventas.Text = "Ventas";
            Ventas.Width = 135;
            // 
            // Costos
            // 
            Costos.Text = "Costos";
            Costos.Width = 135;
            // 
            // Utilidad
            // 
            Utilidad.Text = "Utilidad";
            Utilidad.Width = 140;
            // 
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(391, 368);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(75, 23);
            LimpiarButton.TabIndex = 3;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            LimpiarButton.Click += LimpiarButton_Click;
            // 
            // ResultadosCostoVentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 404);
            Controls.Add(LimpiarButton);
            Controls.Add(ResultadoOperativoGroupBox);
            Controls.Add(PeriodoConsultaGroupBox);
            Controls.Add(TutasaLabel);
            Name = "ResultadosCostoVentaForm";
            Text = "Resultados Ingresos y Egresos";
            Load += ResultadosCostoVentaFOrm_Load;
            PeriodoConsultaGroupBox.ResumeLayout(false);
            PeriodoConsultaGroupBox.PerformLayout();
            ResultadoOperativoGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TutasaLabel;
        private GroupBox PeriodoConsultaGroupBox;
        private GroupBox ResultadoOperativoGroupBox;
        private Button ConsultarButton;
        private ListView ResultadoOperativoListView;
        private ColumnHeader EmpresaOmnibus;
        private ColumnHeader Ventas;
        private ColumnHeader Costos;
        private ColumnHeader Utilidad;
        private Button LimpiarButton;
        private DateTimePicker PeriodoDateTimePicker;
        private Label PeriodoLabel;
    }
}
