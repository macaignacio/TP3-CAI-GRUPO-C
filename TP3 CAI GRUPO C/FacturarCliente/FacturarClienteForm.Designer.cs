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
            TutasaTituloLabel.Location = new Point(297, 25);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(62, 20);
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
            SeleccionarClienteTextGroup.Location = new Point(32, 83);
            SeleccionarClienteTextGroup.Margin = new Padding(3, 4, 3, 4);
            SeleccionarClienteTextGroup.Name = "SeleccionarClienteTextGroup";
            SeleccionarClienteTextGroup.Padding = new Padding(3, 4, 3, 4);
            SeleccionarClienteTextGroup.Size = new Size(594, 133);
            SeleccionarClienteTextGroup.TabIndex = 1;
            SeleccionarClienteTextGroup.TabStop = false;
            SeleccionarClienteTextGroup.Text = "Seleccionar Cliente";
            // 
            // RSLabel
            // 
            RSLabel.AutoSize = true;
            RSLabel.Location = new Point(379, 48);
            RSLabel.Name = "RSLabel";
            RSLabel.Size = new Size(50, 20);
            RSLabel.TabIndex = 14;
            RSLabel.Text = "[dato]";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(95, 44);
            CuitTextBox.Margin = new Padding(3, 4, 3, 4);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(172, 27);
            CuitTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(502, 95);
            BuscarButton.Margin = new Padding(3, 4, 3, 4);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(86, 31);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // RSTextLabel
            // 
            RSTextLabel.AutoSize = true;
            RSTextLabel.Location = new Point(287, 48);
            RSTextLabel.Name = "RSTextLabel";
            RSTextLabel.Size = new Size(97, 20);
            RSTextLabel.TabIndex = 1;
            RSTextLabel.Text = "Razón Social:";
            // 
            // CuilLabel
            // 
            CuilLabel.AutoSize = true;
            CuilLabel.Location = new Point(13, 48);
            CuilLabel.Name = "CuilLabel";
            CuilLabel.Size = new Size(79, 20);
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
            FacturarServiciosGroupBox.Location = new Point(34, 248);
            FacturarServiciosGroupBox.Margin = new Padding(3, 4, 3, 4);
            FacturarServiciosGroupBox.Name = "FacturarServiciosGroupBox";
            FacturarServiciosGroupBox.Padding = new Padding(3, 4, 3, 4);
            FacturarServiciosGroupBox.Size = new Size(592, 320);
            FacturarServiciosGroupBox.TabIndex = 2;
            FacturarServiciosGroupBox.TabStop = false;
            FacturarServiciosGroupBox.Text = "Facturar Servicios";
            // 
            // TotalCalculadoLabel
            // 
            TotalCalculadoLabel.AutoSize = true;
            TotalCalculadoLabel.Location = new Point(123, 233);
            TotalCalculadoLabel.Name = "TotalCalculadoLabel";
            TotalCalculadoLabel.Size = new Size(120, 20);
            TotalCalculadoLabel.TabIndex = 14;
            TotalCalculadoLabel.Text = "[Total calculado]";
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(499, 277);
            CancelarButton.Margin = new Padding(3, 4, 3, 4);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(86, 31);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EmitirFacturaButton
            // 
            EmitirFacturaButton.Location = new Point(377, 277);
            EmitirFacturaButton.Margin = new Padding(3, 4, 3, 4);
            EmitirFacturaButton.Name = "EmitirFacturaButton";
            EmitirFacturaButton.Size = new Size(113, 31);
            EmitirFacturaButton.TabIndex = 2;
            EmitirFacturaButton.Text = "Emitir Factura";
            EmitirFacturaButton.UseVisualStyleBackColor = true;
            // 
            // TotalTextLabel
            // 
            TotalTextLabel.AutoSize = true;
            TotalTextLabel.Location = new Point(19, 233);
            TotalTextLabel.Name = "TotalTextLabel";
            TotalTextLabel.Size = new Size(112, 20);
            TotalTextLabel.TabIndex = 1;
            TotalTextLabel.Text = "Total a facturar:";
            // 
            // ServiciosListView
            // 
            ServiciosListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, NumeroGuia, columnHeader3, Subtotal });
            ServiciosListView.Location = new Point(17, 44);
            ServiciosListView.Margin = new Padding(3, 4, 3, 4);
            ServiciosListView.Name = "ServiciosListView";
            ServiciosListView.Size = new Size(567, 167);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 599);
            Controls.Add(FacturarServiciosGroupBox);
            Controls.Add(SeleccionarClienteTextGroup);
            Controls.Add(TutasaTituloLabel);
            Margin = new Padding(3, 4, 3, 4);
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