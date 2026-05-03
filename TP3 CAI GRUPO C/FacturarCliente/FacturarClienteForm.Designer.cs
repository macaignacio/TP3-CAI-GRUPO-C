namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    partial class FacturarClienteForm
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
            SeleccionarClienteTextGroup = new GroupBox();
            RSLabel = new Label();
            CuitTextBox = new TextBox();
            BuscarButton = new Button();
            RSTextLabel = new Label();
            CuilLabel = new Label();
            FacturarServiciosGroupBox = new GroupBox();
            TotalCalculadoLabel = new Label();
            CancelarButton = new Button();
            EmitirFacturaButton = new Button();
            TotalTextLabel = new Label();
            ServiciosListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            NumeroGuia = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Subtotal = new ColumnHeader();
            SeleccionarClienteTextGroup.SuspendLayout();
            FacturarServiciosGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(260, 19);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(50, 15);
            TutasaTituloLabel.TabIndex = 0;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // SeleccionarClienteTextGroup
            // 
            SeleccionarClienteTextGroup.Controls.Add(RSLabel);
            SeleccionarClienteTextGroup.Controls.Add(CuitTextBox);
            SeleccionarClienteTextGroup.Controls.Add(BuscarButton);
            SeleccionarClienteTextGroup.Controls.Add(RSTextLabel);
            SeleccionarClienteTextGroup.Controls.Add(CuilLabel);
            SeleccionarClienteTextGroup.Location = new Point(28, 62);
            SeleccionarClienteTextGroup.Name = "SeleccionarClienteTextGroup";
            SeleccionarClienteTextGroup.Size = new Size(520, 100);
            SeleccionarClienteTextGroup.TabIndex = 1;
            SeleccionarClienteTextGroup.TabStop = false;
            SeleccionarClienteTextGroup.Text = "Seleccionar Cliente";
            // 
            // RSLabel
            // 
            RSLabel.AutoSize = true;
            RSLabel.Location = new Point(332, 36);
            RSLabel.Name = "RSLabel";
            RSLabel.Size = new Size(39, 15);
            RSLabel.TabIndex = 14;
            RSLabel.Text = "[dato]";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(83, 33);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(151, 23);
            CuitTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(439, 71);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // RSTextLabel
            // 
            RSTextLabel.AutoSize = true;
            RSTextLabel.Location = new Point(251, 36);
            RSTextLabel.Name = "RSTextLabel";
            RSTextLabel.Size = new Size(76, 15);
            RSTextLabel.TabIndex = 1;
            RSTextLabel.Text = "Razón Social:";
            // 
            // CuilLabel
            // 
            CuilLabel.AutoSize = true;
            CuilLabel.Location = new Point(11, 36);
            CuilLabel.Name = "CuilLabel";
            CuilLabel.Size = new Size(66, 15);
            CuilLabel.TabIndex = 0;
            CuilLabel.Text = "CUIT/CUIL:";
            // 
            // FacturarServiciosGroupBox
            // 
            FacturarServiciosGroupBox.Controls.Add(TotalCalculadoLabel);
            FacturarServiciosGroupBox.Controls.Add(CancelarButton);
            FacturarServiciosGroupBox.Controls.Add(EmitirFacturaButton);
            FacturarServiciosGroupBox.Controls.Add(TotalTextLabel);
            FacturarServiciosGroupBox.Controls.Add(ServiciosListView);
            FacturarServiciosGroupBox.Location = new Point(30, 186);
            FacturarServiciosGroupBox.Name = "FacturarServiciosGroupBox";
            FacturarServiciosGroupBox.Size = new Size(518, 240);
            FacturarServiciosGroupBox.TabIndex = 2;
            FacturarServiciosGroupBox.TabStop = false;
            FacturarServiciosGroupBox.Text = "Facturar Servicios";
            // 
            // TotalCalculadoLabel
            // 
            TotalCalculadoLabel.AutoSize = true;
            TotalCalculadoLabel.Location = new Point(108, 175);
            TotalCalculadoLabel.Name = "TotalCalculadoLabel";
            TotalCalculadoLabel.Size = new Size(95, 15);
            TotalCalculadoLabel.TabIndex = 14;
            TotalCalculadoLabel.Text = "[Total calculado]";
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(437, 208);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(75, 23);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EmitirFacturaButton
            // 
            EmitirFacturaButton.Location = new Point(330, 208);
            EmitirFacturaButton.Name = "EmitirFacturaButton";
            EmitirFacturaButton.Size = new Size(99, 23);
            EmitirFacturaButton.TabIndex = 2;
            EmitirFacturaButton.Text = "Emitir Factura";
            EmitirFacturaButton.UseVisualStyleBackColor = true;
            // 
            // TotalTextLabel
            // 
            TotalTextLabel.AutoSize = true;
            TotalTextLabel.Location = new Point(17, 175);
            TotalTextLabel.Name = "TotalTextLabel";
            TotalTextLabel.Size = new Size(89, 15);
            TotalTextLabel.TabIndex = 1;
            TotalTextLabel.Text = "Total a facturar:";
            // 
            // ServiciosListView
            // 
            ServiciosListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, NumeroGuia, columnHeader3, Subtotal });
            ServiciosListView.Location = new Point(15, 33);
            ServiciosListView.Name = "ServiciosListView";
            ServiciosListView.Size = new Size(497, 126);
            ServiciosListView.TabIndex = 0;
            ServiciosListView.UseCompatibleStateImageBehavior = false;
            ServiciosListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descripción";
            columnHeader2.Width = 120;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Número de Guía";
            NumeroGuia.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Monto";
            columnHeader3.Width = 80;
            // 
            // Subtotal
            // 
            Subtotal.Text = "Subtotal";
            Subtotal.Width = 80;
            // 
            // FacturarClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 449);
            Controls.Add(FacturarServiciosGroupBox);
            Controls.Add(SeleccionarClienteTextGroup);
            Controls.Add(TutasaTituloLabel);
            Name = "FacturarClienteForm";
            Text = "Facturación a Clientes";
            Load += FacturarClienteForm_Load;
            SeleccionarClienteTextGroup.ResumeLayout(false);
            SeleccionarClienteTextGroup.PerformLayout();
            FacturarServiciosGroupBox.ResumeLayout(false);
            FacturarServiciosGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TutasaTituloLabel;
        private GroupBox SeleccionarClienteTextGroup;
        private TextBox CuitTextBox;
        private Button BuscarButton;
        private Label RSTextLabel;
        private Label CuilLabel;
        private GroupBox FacturarServiciosGroupBox;
        private ListView ServiciosListView;
        private ColumnHeader NumeroGuia;
        private ColumnHeader Subtotal;
        private Button EmitirFacturaButton;
        private Label TotalTextLabel;
        private Button CancelarButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label RSLabel;
        private Label TotalCalculadoLabel;
    }
}