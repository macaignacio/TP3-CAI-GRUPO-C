namespace TP3_CAI_GRUPO_C
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
            CuitTextBox = new TextBox();
            BuscarButton = new Button();
            RSTextLabel = new Label();
            CuilLabel = new Label();
            FacturarServiciosGroupBox = new GroupBox();
            CancelarButton = new Button();
            EmitirFacturaButton = new Button();
            TotalTextLabel = new Label();
            ServiciosListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            NumeroGuia = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Subtotal = new ColumnHeader();
            RSLabel = new Label();
            TotalCalculadoLabel = new Label();
            SeleccionarClienteTextGroup.SuspendLayout();
            FacturarServiciosGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(371, 32);
            TutasaTituloLabel.Margin = new Padding(4, 0, 4, 0);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(75, 25);
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
            SeleccionarClienteTextGroup.Location = new Point(40, 103);
            SeleccionarClienteTextGroup.Margin = new Padding(4, 5, 4, 5);
            SeleccionarClienteTextGroup.Name = "SeleccionarClienteTextGroup";
            SeleccionarClienteTextGroup.Padding = new Padding(4, 5, 4, 5);
            SeleccionarClienteTextGroup.Size = new Size(743, 167);
            SeleccionarClienteTextGroup.TabIndex = 1;
            SeleccionarClienteTextGroup.TabStop = false;
            SeleccionarClienteTextGroup.Text = "Seleccionar Cliente";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(119, 55);
            CuitTextBox.Margin = new Padding(4, 5, 4, 5);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(214, 31);
            CuitTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(627, 118);
            BuscarButton.Margin = new Padding(4, 5, 4, 5);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(107, 38);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // RSTextLabel
            // 
            RSTextLabel.AutoSize = true;
            RSTextLabel.Location = new Point(359, 60);
            RSTextLabel.Margin = new Padding(4, 0, 4, 0);
            RSTextLabel.Name = "RSTextLabel";
            RSTextLabel.Size = new Size(116, 25);
            RSTextLabel.TabIndex = 1;
            RSTextLabel.Text = "Razón Social:";
            // 
            // CuilLabel
            // 
            CuilLabel.AutoSize = true;
            CuilLabel.Location = new Point(16, 60);
            CuilLabel.Margin = new Padding(4, 0, 4, 0);
            CuilLabel.Name = "CuilLabel";
            CuilLabel.Size = new Size(96, 25);
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
            FacturarServiciosGroupBox.Location = new Point(43, 310);
            FacturarServiciosGroupBox.Margin = new Padding(4, 5, 4, 5);
            FacturarServiciosGroupBox.Name = "FacturarServiciosGroupBox";
            FacturarServiciosGroupBox.Padding = new Padding(4, 5, 4, 5);
            FacturarServiciosGroupBox.Size = new Size(740, 400);
            FacturarServiciosGroupBox.TabIndex = 2;
            FacturarServiciosGroupBox.TabStop = false;
            FacturarServiciosGroupBox.Text = "Facturar Servicios";
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(624, 346);
            CancelarButton.Margin = new Padding(4, 5, 4, 5);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(107, 38);
            CancelarButton.TabIndex = 3;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // EmitirFacturaButton
            // 
            EmitirFacturaButton.Location = new Point(471, 346);
            EmitirFacturaButton.Margin = new Padding(4, 5, 4, 5);
            EmitirFacturaButton.Name = "EmitirFacturaButton";
            EmitirFacturaButton.Size = new Size(141, 38);
            EmitirFacturaButton.TabIndex = 2;
            EmitirFacturaButton.Text = "Emitir Factura";
            EmitirFacturaButton.UseVisualStyleBackColor = true;
            // 
            // TotalTextLabel
            // 
            TotalTextLabel.AutoSize = true;
            TotalTextLabel.Location = new Point(24, 291);
            TotalTextLabel.Margin = new Padding(4, 0, 4, 0);
            TotalTextLabel.Name = "TotalTextLabel";
            TotalTextLabel.Size = new Size(132, 25);
            TotalTextLabel.TabIndex = 1;
            TotalTextLabel.Text = "Total a facturar:";
            // 
            // ServiciosListView
            // 
            ServiciosListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, NumeroGuia, columnHeader3, Subtotal });
            ServiciosListView.Location = new Point(21, 55);
            ServiciosListView.Margin = new Padding(4, 5, 4, 5);
            ServiciosListView.Name = "ServiciosListView";
            ServiciosListView.Size = new Size(708, 208);
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
            // RSLabel
            // 
            RSLabel.AutoSize = true;
            RSLabel.Location = new Point(474, 60);
            RSLabel.Margin = new Padding(4, 0, 4, 0);
            RSLabel.Name = "RSLabel";
            RSLabel.Size = new Size(59, 25);
            RSLabel.TabIndex = 14;
            RSLabel.Text = "[dato]";
            // 
            // TotalCalculadoLabel
            // 
            TotalCalculadoLabel.AutoSize = true;
            TotalCalculadoLabel.Location = new Point(155, 291);
            TotalCalculadoLabel.Margin = new Padding(4, 0, 4, 0);
            TotalCalculadoLabel.Name = "TotalCalculadoLabel";
            TotalCalculadoLabel.Size = new Size(138, 25);
            TotalCalculadoLabel.TabIndex = 14;
            TotalCalculadoLabel.Text = "[Total calculado]";
            // 
            // FacturarClienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 750);
            Controls.Add(FacturarServiciosGroupBox);
            Controls.Add(SeleccionarClienteTextGroup);
            Controls.Add(TutasaTituloLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FacturarClienteForm";
            Text = "Facturación a Clientes";
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