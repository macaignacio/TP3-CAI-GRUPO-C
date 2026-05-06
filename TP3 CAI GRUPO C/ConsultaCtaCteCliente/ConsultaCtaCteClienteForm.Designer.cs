namespace TP3_CAI_GRUPO_C.ConsultaCtaCteCliente

{
    partial class ConsultaCtaCteClienteForm
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
            TutasaTituloLabel = new Label();
            BusquedaClienteGroupBox = new GroupBox();
            RazonSocialLabel = new Label();
            BuscarButton = new Button();
            PeriodoDateTimePicker = new DateTimePicker();
            RZTextoLabel = new Label();
            CuitTextBox = new TextBox();
            periodoTextoLabel = new Label();
            CuitTextoLabel = new Label();
            ResumenCuentaGroupBox = new GroupBox();
            CuentaCorrienteListView = new ListView();
            columnHeader5 = new ColumnHeader();
            Fecha = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            Monto = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            Limpiar = new Button();
            BusquedaClienteGroupBox.SuspendLayout();
            ResumenCuentaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(459, 30);
            TutasaTituloLabel.Margin = new Padding(4, 0, 4, 0);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(75, 25);
            TutasaTituloLabel.TabIndex = 0;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // BusquedaClienteGroupBox
            // 
            BusquedaClienteGroupBox.Controls.Add(RazonSocialLabel);
            BusquedaClienteGroupBox.Controls.Add(BuscarButton);
            BusquedaClienteGroupBox.Controls.Add(PeriodoDateTimePicker);
            BusquedaClienteGroupBox.Controls.Add(RZTextoLabel);
            BusquedaClienteGroupBox.Controls.Add(CuitTextBox);
            BusquedaClienteGroupBox.Controls.Add(periodoTextoLabel);
            BusquedaClienteGroupBox.Controls.Add(CuitTextoLabel);
            BusquedaClienteGroupBox.Location = new Point(64, 100);
            BusquedaClienteGroupBox.Margin = new Padding(4, 5, 4, 5);
            BusquedaClienteGroupBox.Name = "BusquedaClienteGroupBox";
            BusquedaClienteGroupBox.Padding = new Padding(4, 5, 4, 5);
            BusquedaClienteGroupBox.Size = new Size(850, 212);
            BusquedaClienteGroupBox.TabIndex = 1;
            BusquedaClienteGroupBox.TabStop = false;
            BusquedaClienteGroupBox.Text = "Búsqueda de Cliente";
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new Point(587, 48);
            RazonSocialLabel.Margin = new Padding(4, 0, 4, 0);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new Size(59, 25);
            RazonSocialLabel.TabIndex = 7;
            RazonSocialLabel.Text = "[dato]";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(734, 163);
            BuscarButton.Margin = new Padding(4, 5, 4, 5);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(107, 38);
            BuscarButton.TabIndex = 6;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // PeriodoDateTimePicker
            // 
            PeriodoDateTimePicker.CustomFormat = "MMMMyyyy";
            PeriodoDateTimePicker.Format = DateTimePickerFormat.Custom;
            PeriodoDateTimePicker.Location = new Point(143, 108);
            PeriodoDateTimePicker.Margin = new Padding(4, 5, 4, 5);
            PeriodoDateTimePicker.Name = "PeriodoDateTimePicker";
            PeriodoDateTimePicker.ShowUpDown = true;
            PeriodoDateTimePicker.Size = new Size(255, 31);
            PeriodoDateTimePicker.TabIndex = 4;
            PeriodoDateTimePicker.Value = new DateTime(2026, 4, 30, 0, 0, 0, 0);
            PeriodoDateTimePicker.ValueChanged += PeriodoDateTimePicker_ValueChanged;
            // 
            // RZTextoLabel
            // 
            RZTextoLabel.AutoSize = true;
            RZTextoLabel.Location = new Point(463, 48);
            RZTextoLabel.Margin = new Padding(4, 0, 4, 0);
            RZTextoLabel.Name = "RZTextoLabel";
            RZTextoLabel.Size = new Size(116, 25);
            RZTextoLabel.TabIndex = 0;
            RZTextoLabel.Text = "Razón Social:";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(143, 45);
            CuitTextBox.Margin = new Padding(4, 5, 4, 5);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(255, 31);
            CuitTextBox.TabIndex = 3;
            // 
            // periodoTextoLabel
            // 
            periodoTextoLabel.AutoSize = true;
            periodoTextoLabel.Location = new Point(26, 113);
            periodoTextoLabel.Margin = new Padding(4, 0, 4, 0);
            periodoTextoLabel.Name = "periodoTextoLabel";
            periodoTextoLabel.Size = new Size(77, 25);
            periodoTextoLabel.TabIndex = 1;
            periodoTextoLabel.Text = "Período:";
            // 
            // CuitTextoLabel
            // 
            CuitTextoLabel.AutoSize = true;
            CuitTextoLabel.Location = new Point(26, 50);
            CuitTextoLabel.Margin = new Padding(4, 0, 4, 0);
            CuitTextoLabel.Name = "CuitTextoLabel";
            CuitTextoLabel.Size = new Size(96, 25);
            CuitTextoLabel.TabIndex = 0;
            CuitTextoLabel.Text = "CUIT/CUIL:";
            // 
            // ResumenCuentaGroupBox
            // 
            ResumenCuentaGroupBox.Controls.Add(CuentaCorrienteListView);
            ResumenCuentaGroupBox.Location = new Point(64, 348);
            ResumenCuentaGroupBox.Margin = new Padding(4, 5, 4, 5);
            ResumenCuentaGroupBox.Name = "ResumenCuentaGroupBox";
            ResumenCuentaGroupBox.Padding = new Padding(4, 5, 4, 5);
            ResumenCuentaGroupBox.Size = new Size(850, 432);
            ResumenCuentaGroupBox.TabIndex = 2;
            ResumenCuentaGroupBox.TabStop = false;
            ResumenCuentaGroupBox.Text = "Resumen de Cuenta Corriente";
            // 
            // CuentaCorrienteListView
            // 
            CuentaCorrienteListView.Columns.AddRange(new ColumnHeader[] { columnHeader5, Fecha, columnHeader6, columnHeader2, Monto, columnHeader3, columnHeader4 });
            CuentaCorrienteListView.GridLines = true;
            CuentaCorrienteListView.Location = new Point(13, 67);
            CuentaCorrienteListView.Margin = new Padding(4, 5, 4, 5);
            CuentaCorrienteListView.Name = "CuentaCorrienteListView";
            CuentaCorrienteListView.Size = new Size(806, 327);
            CuentaCorrienteListView.TabIndex = 2;
            CuentaCorrienteListView.UseCompatibleStateImageBehavior = false;
            CuentaCorrienteListView.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tipo";
            columnHeader5.Width = 100;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Vencimiento";
            columnHeader6.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Comprobante";
            columnHeader2.Width = 150;
            // 
            // Monto
            // 
            Monto.Text = "Debe";
            Monto.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Haber";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Saldo";
            columnHeader4.Width = 110;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(832, 813);
            Limpiar.Margin = new Padding(4, 5, 4, 5);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(107, 38);
            Limpiar.TabIndex = 7;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            // 
            // ConsultaCtaCteClienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 871);
            Controls.Add(Limpiar);
            Controls.Add(ResumenCuentaGroupBox);
            Controls.Add(BusquedaClienteGroupBox);
            Controls.Add(TutasaTituloLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ConsultaCtaCteClienteForm";
            Text = "Estado de Cuenta Corriente";
            Load += ConsultaCtaCteClienteForm_Load;
            BusquedaClienteGroupBox.ResumeLayout(false);
            BusquedaClienteGroupBox.PerformLayout();
            ResumenCuentaGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TutasaTituloLabel;
        private GroupBox BusquedaClienteGroupBox;
        private DateTimePicker PeriodoDateTimePicker;
        private TextBox CuitTextBox;
        private Label periodoTextoLabel;
        private Label CuitTextoLabel;
        private Button BuscarButton;
        private GroupBox ResumenCuentaGroupBox;
        private ListView CuentaCorrienteListView;
        private ColumnHeader Fecha;
        private ColumnHeader Monto;
        private Label RZTextoLabel;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label RazonSocialLabel;
        private Button Limpiar;
    }
}