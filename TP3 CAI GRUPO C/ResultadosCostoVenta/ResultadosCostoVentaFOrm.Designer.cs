namespace TP3_CAI_GRUPO_C.ResultadosCostoVenta
{
    partial class ResultadosCostoVentaFOrm
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
            AceptarButton = new Button();
            PeriodoConsultaGroupBox.SuspendLayout();
            ResultadoOperativoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaLabel
            // 
            TutasaLabel.AutoSize = true;
            TutasaLabel.Location = new Point(186, 27);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(62, 20);
            TutasaLabel.TabIndex = 0;
            TutasaLabel.Text = "TUTASA";
            // 
            // PeriodoConsultaGroupBox
            // 
            PeriodoConsultaGroupBox.Controls.Add(PeriodoDateTimePicker);
            PeriodoConsultaGroupBox.Controls.Add(PeriodoLabel);
            PeriodoConsultaGroupBox.Controls.Add(ConsultarButton);
            PeriodoConsultaGroupBox.Location = new Point(15, 64);
            PeriodoConsultaGroupBox.Margin = new Padding(3, 4, 3, 4);
            PeriodoConsultaGroupBox.Name = "PeriodoConsultaGroupBox";
            PeriodoConsultaGroupBox.Padding = new Padding(3, 4, 3, 4);
            PeriodoConsultaGroupBox.Size = new Size(445, 133);
            PeriodoConsultaGroupBox.TabIndex = 1;
            PeriodoConsultaGroupBox.TabStop = false;
            PeriodoConsultaGroupBox.Text = "Período de Consulta";
            // 
            // PeriodoDateTimePicker
            // 
            PeriodoDateTimePicker.CustomFormat = "MMMMyyyy";
            PeriodoDateTimePicker.Format = DateTimePickerFormat.Custom;
            PeriodoDateTimePicker.Location = new Point(109, 41);
            PeriodoDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            PeriodoDateTimePicker.Name = "PeriodoDateTimePicker";
            PeriodoDateTimePicker.Size = new Size(205, 27);
            PeriodoDateTimePicker.TabIndex = 6;
            PeriodoDateTimePicker.Value = new DateTime(2026, 4, 30, 0, 0, 0, 0);
            // 
            // PeriodoLabel
            // 
            PeriodoLabel.AutoSize = true;
            PeriodoLabel.Location = new Point(15, 49);
            PeriodoLabel.Name = "PeriodoLabel";
            PeriodoLabel.Size = new Size(63, 20);
            PeriodoLabel.TabIndex = 5;
            PeriodoLabel.Text = "Período:";
            // 
            // ConsultarButton
            // 
            ConsultarButton.Location = new Point(313, 95);
            ConsultarButton.Margin = new Padding(3, 4, 3, 4);
            ConsultarButton.Name = "ConsultarButton";
            ConsultarButton.Size = new Size(86, 31);
            ConsultarButton.TabIndex = 2;
            ConsultarButton.Text = "Consultar";
            ConsultarButton.UseVisualStyleBackColor = true;
            // 
            // ResultadoOperativoGroupBox
            // 
            ResultadoOperativoGroupBox.Controls.Add(ResultadoOperativoListView);
            ResultadoOperativoGroupBox.Location = new Point(15, 241);
            ResultadoOperativoGroupBox.Margin = new Padding(3, 4, 3, 4);
            ResultadoOperativoGroupBox.Name = "ResultadoOperativoGroupBox";
            ResultadoOperativoGroupBox.Padding = new Padding(3, 4, 3, 4);
            ResultadoOperativoGroupBox.Size = new Size(445, 192);
            ResultadoOperativoGroupBox.TabIndex = 2;
            ResultadoOperativoGroupBox.TabStop = false;
            ResultadoOperativoGroupBox.Text = "Resultado Operativo";
            // 
            // ResultadoOperativoListView
            // 
            ResultadoOperativoListView.Columns.AddRange(new ColumnHeader[] { EmpresaOmnibus, Ventas, Costos, Utilidad });
            ResultadoOperativoListView.Location = new Point(13, 33);
            ResultadoOperativoListView.Margin = new Padding(3, 4, 3, 4);
            ResultadoOperativoListView.Name = "ResultadoOperativoListView";
            ResultadoOperativoListView.Size = new Size(407, 128);
            ResultadoOperativoListView.TabIndex = 0;
            ResultadoOperativoListView.UseCompatibleStateImageBehavior = false;
            ResultadoOperativoListView.View = View.Details;
            // 
            // EmpresaOmnibus
            // 
            EmpresaOmnibus.Text = "Empresa de Ómnibus";
            EmpresaOmnibus.Width = 140;
            // 
            // Ventas
            // 
            Ventas.Text = "Ventas";
            // 
            // Costos
            // 
            Costos.Text = "Costos";
            // 
            // Utilidad
            // 
            Utilidad.Text = "Utilidad";
            Utilidad.Width = 80;
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(377, 460);
            AceptarButton.Margin = new Padding(3, 4, 3, 4);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(86, 31);
            AceptarButton.TabIndex = 3;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            // 
            // ResultadosCostoVentaFOrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 507);
            Controls.Add(AceptarButton);
            Controls.Add(ResultadoOperativoGroupBox);
            Controls.Add(PeriodoConsultaGroupBox);
            Controls.Add(TutasaLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ResultadosCostoVentaFOrm";
            Text = "Resultados Ingresos y Egresos";
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
        private Button AceptarButton;
        private DateTimePicker PeriodoDateTimePicker;
        private Label PeriodoLabel;
    }
}