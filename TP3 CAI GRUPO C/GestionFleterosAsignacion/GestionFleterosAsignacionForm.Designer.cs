namespace TP3_CAI_GRUPO_C
{
    partial class GestionFleterosAsignacionForm
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
            SeleccionarFleteroGroupBox = new GroupBox();
            NombreTextoLabel = new Label();
            CuilTextBox = new TextBox();
            BuscarButton = new Button();
            CuilTextLabel = new Label();
            DetalleHDRPendientesGroupBox = new GroupBox();
            DetalleHDRPendientesListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ImprimirDetalleButton = new Button();
            button4 = new Button();
            TutasaTituloLabel = new Label();
            NombreLabel = new Label();
            SeleccionarFleteroGroupBox.SuspendLayout();
            DetalleHDRPendientesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SeleccionarFleteroGroupBox
            // 
            SeleccionarFleteroGroupBox.Controls.Add(NombreLabel);
            SeleccionarFleteroGroupBox.Controls.Add(NombreTextoLabel);
            SeleccionarFleteroGroupBox.Controls.Add(CuilTextBox);
            SeleccionarFleteroGroupBox.Controls.Add(BuscarButton);
            SeleccionarFleteroGroupBox.Controls.Add(CuilTextLabel);
            SeleccionarFleteroGroupBox.Location = new Point(44, 69);
            SeleccionarFleteroGroupBox.Margin = new Padding(4, 5, 4, 5);
            SeleccionarFleteroGroupBox.Name = "SeleccionarFleteroGroupBox";
            SeleccionarFleteroGroupBox.Padding = new Padding(4, 5, 4, 5);
            SeleccionarFleteroGroupBox.Size = new Size(700, 261);
            SeleccionarFleteroGroupBox.TabIndex = 0;
            SeleccionarFleteroGroupBox.TabStop = false;
            SeleccionarFleteroGroupBox.Text = "Seleccionar Fletero";
            // 
            // NombreTextoLabel
            // 
            NombreTextoLabel.AutoSize = true;
            NombreTextoLabel.Location = new Point(368, 53);
            NombreTextoLabel.Margin = new Padding(4, 0, 4, 0);
            NombreTextoLabel.Name = "NombreTextoLabel";
            NombreTextoLabel.Size = new Size(82, 25);
            NombreTextoLabel.TabIndex = 4;
            NombreTextoLabel.Text = "Nombre:";
            // 
            // CuilTextBox
            // 
            CuilTextBox.Location = new Point(137, 47);
            CuilTextBox.Margin = new Padding(4, 5, 4, 5);
            CuilTextBox.Name = "CuilTextBox";
            CuilTextBox.Size = new Size(190, 31);
            CuilTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(584, 100);
            BuscarButton.Margin = new Padding(4, 5, 4, 5);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(107, 38);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // CuilTextLabel
            // 
            CuilTextLabel.AutoSize = true;
            CuilTextLabel.BackColor = SystemColors.Control;
            CuilTextLabel.Location = new Point(23, 52);
            CuilTextLabel.Margin = new Padding(4, 0, 4, 0);
            CuilTextLabel.Name = "CuilTextLabel";
            CuilTextLabel.Size = new Size(96, 25);
            CuilTextLabel.TabIndex = 0;
            CuilTextLabel.Text = "CUIT/CUIL:";
            // 
            // DetalleHDRPendientesGroupBox
            // 
            DetalleHDRPendientesGroupBox.Controls.Add(DetalleHDRPendientesListView);
            DetalleHDRPendientesGroupBox.Controls.Add(ImprimirDetalleButton);
            DetalleHDRPendientesGroupBox.Location = new Point(44, 260);
            DetalleHDRPendientesGroupBox.Margin = new Padding(4, 5, 4, 5);
            DetalleHDRPendientesGroupBox.Name = "DetalleHDRPendientesGroupBox";
            DetalleHDRPendientesGroupBox.Padding = new Padding(4, 5, 4, 5);
            DetalleHDRPendientesGroupBox.Size = new Size(700, 386);
            DetalleHDRPendientesGroupBox.TabIndex = 2;
            DetalleHDRPendientesGroupBox.TabStop = false;
            DetalleHDRPendientesGroupBox.Text = "Detalle de Hojas de Ruta pendientes";
            // 
            // DetalleHDRPendientesListView
            // 
            DetalleHDRPendientesListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            DetalleHDRPendientesListView.Location = new Point(23, 37);
            DetalleHDRPendientesListView.Margin = new Padding(4, 5, 4, 5);
            DetalleHDRPendientesListView.Name = "DetalleHDRPendientesListView";
            DetalleHDRPendientesListView.Size = new Size(667, 262);
            DetalleHDRPendientesListView.TabIndex = 2;
            DetalleHDRPendientesListView.UseCompatibleStateImageBehavior = false;
            DetalleHDRPendientesListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Número de Guía";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 100;
            // 
            // ImprimirDetalleButton
            // 
            ImprimirDetalleButton.Location = new Point(527, 322);
            ImprimirDetalleButton.Margin = new Padding(4, 5, 4, 5);
            ImprimirDetalleButton.Name = "ImprimirDetalleButton";
            ImprimirDetalleButton.Size = new Size(164, 38);
            ImprimirDetalleButton.TabIndex = 1;
            ImprimirDetalleButton.Text = "Imprimir detalle";
            ImprimirDetalleButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(633, 847);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 3;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = true;
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(347, 19);
            TutasaTituloLabel.Margin = new Padding(4, 0, 4, 0);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(75, 25);
            TutasaTituloLabel.TabIndex = 4;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(448, 52);
            NombreLabel.Margin = new Padding(4, 0, 4, 0);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(59, 25);
            NombreLabel.TabIndex = 15;
            NombreLabel.Text = "[dato]";
            // 
            // GestionFleterosAsignacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 674);
            Controls.Add(TutasaTituloLabel);
            Controls.Add(button4);
            Controls.Add(DetalleHDRPendientesGroupBox);
            Controls.Add(SeleccionarFleteroGroupBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionFleterosAsignacionForm";
            Text = "Gestión de HDR Pendientes a Fleteros";
            SeleccionarFleteroGroupBox.ResumeLayout(false);
            SeleccionarFleteroGroupBox.PerformLayout();
            DetalleHDRPendientesGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox SeleccionarFleteroGroupBox;
        private Button BuscarButton;
        private Label CuilTextLabel;
        private GroupBox DetalleHDRPendientesGroupBox;
        private Button ImprimirDetalleButton;
        private ListView DetalleHDRPendientesListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button4;
        private Label TutasaTituloLabel;
        private Label NombreTextoLabel;
        private TextBox CuilTextBox;
        private Label NombreLabel;
    }
}