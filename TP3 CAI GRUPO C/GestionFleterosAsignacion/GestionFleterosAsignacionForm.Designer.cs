namespace TP3_CAI_GRUPO_C.GestionFleterosAsignacion
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
            NombreLabel = new Label();
            NombreTextoLabel = new Label();
            CuilTextBox = new TextBox();
            BuscarButton = new Button();
            CuilTextLabel = new Label();
            DetalleHDRPendientesGroupBox = new GroupBox();
            DetalleHDRPendientesListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ConfirmarAsignacionButton = new Button();
            button4 = new Button();
            TutasaTituloLabel = new Label();
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
            SeleccionarFleteroGroupBox.Location = new Point(31, 41);
            SeleccionarFleteroGroupBox.Name = "SeleccionarFleteroGroupBox";
            SeleccionarFleteroGroupBox.Size = new Size(490, 157);
            SeleccionarFleteroGroupBox.TabIndex = 0;
            SeleccionarFleteroGroupBox.TabStop = false;
            SeleccionarFleteroGroupBox.Text = "Seleccionar Fletero";
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(314, 31);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(39, 15);
            NombreLabel.TabIndex = 15;
            NombreLabel.Text = "[dato]";
            // 
            // NombreTextoLabel
            // 
            NombreTextoLabel.AutoSize = true;
            NombreTextoLabel.Location = new Point(258, 32);
            NombreTextoLabel.Name = "NombreTextoLabel";
            NombreTextoLabel.Size = new Size(54, 15);
            NombreTextoLabel.TabIndex = 4;
            NombreTextoLabel.Text = "Nombre:";
            // 
            // CuilTextBox
            // 
            CuilTextBox.Location = new Point(96, 28);
            CuilTextBox.Name = "CuilTextBox";
            CuilTextBox.Size = new Size(134, 23);
            CuilTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(409, 60);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // CuilTextLabel
            // 
            CuilTextLabel.AutoSize = true;
            CuilTextLabel.BackColor = SystemColors.Control;
            CuilTextLabel.Location = new Point(16, 31);
            CuilTextLabel.Name = "CuilTextLabel";
            CuilTextLabel.Size = new Size(66, 15);
            CuilTextLabel.TabIndex = 0;
            CuilTextLabel.Text = "CUIT/CUIL:";
            // 
            // DetalleHDRPendientesGroupBox
            // 
            DetalleHDRPendientesGroupBox.Controls.Add(DetalleHDRPendientesListView);
            DetalleHDRPendientesGroupBox.Controls.Add(ConfirmarAsignacionButton);
            DetalleHDRPendientesGroupBox.Location = new Point(31, 156);
            DetalleHDRPendientesGroupBox.Name = "DetalleHDRPendientesGroupBox";
            DetalleHDRPendientesGroupBox.Size = new Size(490, 232);
            DetalleHDRPendientesGroupBox.TabIndex = 2;
            DetalleHDRPendientesGroupBox.TabStop = false;
            DetalleHDRPendientesGroupBox.Text = "Detalle de Hojas de Ruta pendientes";
            // 
            // DetalleHDRPendientesListView
            // 
            DetalleHDRPendientesListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            DetalleHDRPendientesListView.Location = new Point(16, 22);
            DetalleHDRPendientesListView.Name = "DetalleHDRPendientesListView";
            DetalleHDRPendientesListView.Size = new Size(468, 159);
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
            // ConfirmarAsignacionButton
            // 
            ConfirmarAsignacionButton.Location = new Point(343, 193);
            ConfirmarAsignacionButton.Name = "ConfirmarAsignacionButton";
            ConfirmarAsignacionButton.Size = new Size(141, 23);
            ConfirmarAsignacionButton.TabIndex = 1;
            ConfirmarAsignacionButton.Text = "Confirmar asignación";
            ConfirmarAsignacionButton.UseVisualStyleBackColor = true;
            ConfirmarAsignacionButton.Click += ConfirmarAsignacionButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(443, 508);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AceptarButton_Click;
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(243, 11);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(50, 15);
            TutasaTituloLabel.TabIndex = 4;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // GestionFleterosAsignacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 404);
            Controls.Add(TutasaTituloLabel);
            Controls.Add(button4);
            Controls.Add(DetalleHDRPendientesGroupBox);
            Controls.Add(SeleccionarFleteroGroupBox);
            Name = "GestionFleterosAsignacionForm";
            Text = "Gestión de HDR Pendientes a Fleteros";
            Load += GestionFleterosAsignacionForm_Load;
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
        private Button ConfirmarAsignacionButton;
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
