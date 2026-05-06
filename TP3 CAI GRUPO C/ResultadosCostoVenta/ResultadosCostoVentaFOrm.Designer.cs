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
            TutasaLabel.Location = new Point(286, 39);
            TutasaLabel.Margin = new Padding(4, 0, 4, 0);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(75, 25);
            TutasaLabel.TabIndex = 0;
            TutasaLabel.Text = "TUTASA";
            // 
            // PeriodoConsultaGroupBox
            // 
            PeriodoConsultaGroupBox.Controls.Add(PeriodoDateTimePicker);
            PeriodoConsultaGroupBox.Controls.Add(PeriodoLabel);
            PeriodoConsultaGroupBox.Controls.Add(ConsultarButton);
            PeriodoConsultaGroupBox.Location = new Point(57, 86);
            PeriodoConsultaGroupBox.Margin = new Padding(4, 5, 4, 5);
            PeriodoConsultaGroupBox.Name = "PeriodoConsultaGroupBox";
            PeriodoConsultaGroupBox.Padding = new Padding(4, 5, 4, 5);
            PeriodoConsultaGroupBox.Size = new Size(609, 149);
            PeriodoConsultaGroupBox.TabIndex = 1;
            PeriodoConsultaGroupBox.TabStop = false;
            PeriodoConsultaGroupBox.Text = "Período de Consulta";
            // 
            // PeriodoDateTimePicker
            // 
            PeriodoDateTimePicker.CustomFormat = "MMMMyyyy";
            PeriodoDateTimePicker.Format = DateTimePickerFormat.Custom;
            PeriodoDateTimePicker.Location = new Point(130, 67);
            PeriodoDateTimePicker.Margin = new Padding(4, 5, 4, 5);
            PeriodoDateTimePicker.Name = "PeriodoDateTimePicker";
            PeriodoDateTimePicker.ShowUpDown = true;
            PeriodoDateTimePicker.Size = new Size(255, 31);
            PeriodoDateTimePicker.TabIndex = 6;
            PeriodoDateTimePicker.Value = new DateTime(2026, 4, 30, 0, 0, 0, 0);
            // 
            // PeriodoLabel
            // 
            PeriodoLabel.AutoSize = true;
            PeriodoLabel.Location = new Point(21, 72);
            PeriodoLabel.Margin = new Padding(4, 0, 4, 0);
            PeriodoLabel.Name = "PeriodoLabel";
            PeriodoLabel.Size = new Size(77, 25);
            PeriodoLabel.TabIndex = 5;
            PeriodoLabel.Text = "Período:";
            // 
            // ConsultarButton
            // 
            ConsultarButton.Location = new Point(444, 65);
            ConsultarButton.Margin = new Padding(4, 5, 4, 5);
            ConsultarButton.Name = "ConsultarButton";
            ConsultarButton.Size = new Size(107, 38);
            ConsultarButton.TabIndex = 2;
            ConsultarButton.Text = "Consultar";
            ConsultarButton.UseVisualStyleBackColor = true;
            // 
            // ResultadoOperativoGroupBox
            // 
            ResultadoOperativoGroupBox.Controls.Add(ResultadoOperativoListView);
            ResultadoOperativoGroupBox.Location = new Point(57, 291);
            ResultadoOperativoGroupBox.Margin = new Padding(4, 5, 4, 5);
            ResultadoOperativoGroupBox.Name = "ResultadoOperativoGroupBox";
            ResultadoOperativoGroupBox.Padding = new Padding(4, 5, 4, 5);
            ResultadoOperativoGroupBox.Size = new Size(609, 291);
            ResultadoOperativoGroupBox.TabIndex = 2;
            ResultadoOperativoGroupBox.TabStop = false;
            ResultadoOperativoGroupBox.Text = "Resultado Operativo";
            // 
            // ResultadoOperativoListView
            // 
            ResultadoOperativoListView.Columns.AddRange(new ColumnHeader[] { EmpresaOmnibus, Ventas, Costos, Utilidad });
            ResultadoOperativoListView.Location = new Point(16, 42);
            ResultadoOperativoListView.Margin = new Padding(4, 5, 4, 5);
            ResultadoOperativoListView.Name = "ResultadoOperativoListView";
            ResultadoOperativoListView.Size = new Size(558, 221);
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
            Ventas.Width = 110;
            // 
            // Costos
            // 
            Costos.Text = "Costos";
            Costos.Width = 110;
            // 
            // Utilidad
            // 
            Utilidad.Text = "Utilidad";
            Utilidad.Width = 110;
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(559, 614);
            AceptarButton.Margin = new Padding(4, 5, 4, 5);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(107, 38);
            AceptarButton.TabIndex = 3;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            AceptarButton.Click += AceptarButton_Click;
            // 
            // ResultadosCostoVentaFOrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 673);
            Controls.Add(AceptarButton);
            Controls.Add(ResultadoOperativoGroupBox);
            Controls.Add(PeriodoConsultaGroupBox);
            Controls.Add(TutasaLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ResultadosCostoVentaFOrm";
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
        private Button AceptarButton;
        private DateTimePicker PeriodoDateTimePicker;
        private Label PeriodoLabel;
    }
}