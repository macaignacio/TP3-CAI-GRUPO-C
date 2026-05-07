namespace TP3_CAI_GRUPO_C.Admision
{
    partial class AdmisionForm
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
            DatosBusquedaGroupBox = new GroupBox();
            BuscarButton = new Button();
            NumeroGuiaTextBox = new TextBox();
            NumeroGuiaLabel = new Label();
            TutasaTituloLabel = new Label();
            DatosEncomiendaGroupBox = new GroupBox();
            CantidadCajasXLLabel = new Label();
            CantidadCajasLLabel = new Label();
            CantidadCajasMLabel = new Label();
            CantidadCajasXLTextBox = new TextBox();
            CantidadCajasSTextBox = new TextBox();
            CantidadCajasMTextBox = new TextBox();
            CantidadCajasLTextBox = new TextBox();
            CantidadCajasSLabel = new Label();
            instruccion = new Label();
            confirmarAdmisionButton = new Button();
            mostrarCuitLabel = new Label();
            CuitLabel = new Label();
            DatosBusquedaGroupBox.SuspendLayout();
            DatosEncomiendaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DatosBusquedaGroupBox
            // 
            DatosBusquedaGroupBox.Controls.Add(mostrarCuitLabel);
            DatosBusquedaGroupBox.Controls.Add(CuitLabel);
            DatosBusquedaGroupBox.Controls.Add(BuscarButton);
            DatosBusquedaGroupBox.Controls.Add(NumeroGuiaTextBox);
            DatosBusquedaGroupBox.Controls.Add(NumeroGuiaLabel);
            DatosBusquedaGroupBox.Location = new Point(12, 36);
            DatosBusquedaGroupBox.Name = "DatosBusquedaGroupBox";
            DatosBusquedaGroupBox.Size = new Size(527, 100);
            DatosBusquedaGroupBox.TabIndex = 2;
            DatosBusquedaGroupBox.TabStop = false;
            DatosBusquedaGroupBox.Text = "Datos de Búsqueda";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(220, 71);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // NumeroGuiaTextBox
            // 
            NumeroGuiaTextBox.Location = new Point(113, 27);
            NumeroGuiaTextBox.Name = "NumeroGuiaTextBox";
            NumeroGuiaTextBox.Size = new Size(182, 23);
            NumeroGuiaTextBox.TabIndex = 1;
            // 
            // NumeroGuiaLabel
            // 
            NumeroGuiaLabel.AutoSize = true;
            NumeroGuiaLabel.Location = new Point(10, 30);
            NumeroGuiaLabel.Name = "NumeroGuiaLabel";
            NumeroGuiaLabel.Size = new Size(97, 15);
            NumeroGuiaLabel.TabIndex = 0;
            NumeroGuiaLabel.Text = "Número de Guía:";
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(165, 9);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(50, 15);
            TutasaTituloLabel.TabIndex = 3;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // DatosEncomiendaGroupBox
            // 
            DatosEncomiendaGroupBox.Controls.Add(instruccion);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasXLLabel);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasLLabel);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasMLabel);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasXLTextBox);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasSTextBox);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasMTextBox);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasLTextBox);
            DatosEncomiendaGroupBox.Controls.Add(CantidadCajasSLabel);
            DatosEncomiendaGroupBox.Location = new Point(12, 156);
            DatosEncomiendaGroupBox.Name = "DatosEncomiendaGroupBox";
            DatosEncomiendaGroupBox.Size = new Size(527, 121);
            DatosEncomiendaGroupBox.TabIndex = 13;
            DatosEncomiendaGroupBox.TabStop = false;
            DatosEncomiendaGroupBox.Text = "Confirmación de datos";
            // 
            // CantidadCajasXLLabel
            // 
            CantidadCajasXLLabel.AutoSize = true;
            CantidadCajasXLLabel.Location = new Point(261, 83);
            CantidadCajasXLLabel.Name = "CantidadCajasXLLabel";
            CantidadCajasXLLabel.Size = new Size(116, 15);
            CantidadCajasXLLabel.TabIndex = 19;
            CantidadCajasXLLabel.Text = "Cantidad de cajas XL";
            // 
            // CantidadCajasLLabel
            // 
            CantidadCajasLLabel.AutoSize = true;
            CantidadCajasLLabel.Location = new Point(261, 57);
            CantidadCajasLLabel.Name = "CantidadCajasLLabel";
            CantidadCajasLLabel.Size = new Size(109, 15);
            CantidadCajasLLabel.TabIndex = 18;
            CantidadCajasLLabel.Text = "Cantidad de cajas L";
            // 
            // CantidadCajasMLabel
            // 
            CantidadCajasMLabel.AutoSize = true;
            CantidadCajasMLabel.Location = new Point(12, 81);
            CantidadCajasMLabel.Name = "CantidadCajasMLabel";
            CantidadCajasMLabel.Size = new Size(114, 15);
            CantidadCajasMLabel.TabIndex = 17;
            CantidadCajasMLabel.Text = "Cantidad de cajas M";
            // 
            // CantidadCajasXLTextBox
            // 
            CantidadCajasXLTextBox.Location = new Point(393, 78);
            CantidadCajasXLTextBox.Name = "CantidadCajasXLTextBox";
            CantidadCajasXLTextBox.Size = new Size(100, 23);
            CantidadCajasXLTextBox.TabIndex = 6;
            // 
            // CantidadCajasSTextBox
            // 
            CantidadCajasSTextBox.Location = new Point(139, 49);
            CantidadCajasSTextBox.Name = "CantidadCajasSTextBox";
            CantidadCajasSTextBox.Size = new Size(100, 23);
            CantidadCajasSTextBox.TabIndex = 5;
            // 
            // CantidadCajasMTextBox
            // 
            CantidadCajasMTextBox.Location = new Point(139, 78);
            CantidadCajasMTextBox.Name = "CantidadCajasMTextBox";
            CantidadCajasMTextBox.Size = new Size(100, 23);
            CantidadCajasMTextBox.TabIndex = 4;
            // 
            // CantidadCajasLTextBox
            // 
            CantidadCajasLTextBox.Location = new Point(393, 49);
            CantidadCajasLTextBox.Name = "CantidadCajasLTextBox";
            CantidadCajasLTextBox.Size = new Size(100, 23);
            CantidadCajasLTextBox.TabIndex = 3;
            // 
            // CantidadCajasSLabel
            // 
            CantidadCajasSLabel.AutoSize = true;
            CantidadCajasSLabel.Location = new Point(12, 57);
            CantidadCajasSLabel.Name = "CantidadCajasSLabel";
            CantidadCajasSLabel.Size = new Size(109, 15);
            CantidadCajasSLabel.TabIndex = 1;
            CantidadCajasSLabel.Text = "Cantidad de cajas S";
            // 
            // instruccion
            // 
            instruccion.AutoSize = true;
            instruccion.Location = new Point(12, 22);
            instruccion.Name = "instruccion";
            instruccion.Size = new Size(433, 15);
            instruccion.TabIndex = 20;
            instruccion.Text = "Verifique que la información ingresada sea correcta antes de generar la admisión:";
            // 
            // confirmarAdmisionButton
            // 
            confirmarAdmisionButton.Location = new Point(404, 283);
            confirmarAdmisionButton.Name = "confirmarAdmisionButton";
            confirmarAdmisionButton.Size = new Size(135, 23);
            confirmarAdmisionButton.TabIndex = 14;
            confirmarAdmisionButton.Text = "Confirmar admisión";
            confirmarAdmisionButton.UseVisualStyleBackColor = true;
            confirmarAdmisionButton.Click += confirmarAdmisionButton_Click;
            // 
            // mostrarCuitLabel
            // 
            mostrarCuitLabel.AutoSize = true;
            mostrarCuitLabel.Location = new Point(392, 30);
            mostrarCuitLabel.Name = "mostrarCuitLabel";
            mostrarCuitLabel.Size = new Size(35, 15);
            mostrarCuitLabel.TabIndex = 10;
            mostrarCuitLabel.Text = "[cuit]";
            // 
            // CuitLabel
            // 
            CuitLabel.AutoSize = true;
            CuitLabel.Location = new Point(310, 30);
            CuitLabel.Name = "CuitLabel";
            CuitLabel.Size = new Size(74, 15);
            CuitLabel.TabIndex = 9;
            CuitLabel.Text = "CUIT cliente:";
            // 
            // AdmisionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 339);
            Controls.Add(confirmarAdmisionButton);
            Controls.Add(DatosEncomiendaGroupBox);
            Controls.Add(TutasaTituloLabel);
            Controls.Add(DatosBusquedaGroupBox);
            Name = "AdmisionForm";
            Text = "Admisión";
            Load += AdmisionForm_Load;
            DatosBusquedaGroupBox.ResumeLayout(false);
            DatosBusquedaGroupBox.PerformLayout();
            DatosEncomiendaGroupBox.ResumeLayout(false);
            DatosEncomiendaGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox DatosBusquedaGroupBox;
        private Button BuscarButton;
        private TextBox NumeroGuiaTextBox;
        private Label NumeroGuiaLabel;
        private Label TutasaTituloLabel;
        private GroupBox DatosEncomiendaGroupBox;
        private Label CantidadCajasXLLabel;
        private Label CantidadCajasLLabel;
        private Label CantidadCajasMLabel;
        private TextBox CantidadCajasXLTextBox;
        private TextBox CantidadCajasSTextBox;
        private TextBox CantidadCajasMTextBox;
        private TextBox CantidadCajasLTextBox;
        private Label CantidadCajasSLabel;
        private Label instruccion;
        private Button confirmarAdmisionButton;
        private Label mostrarCuitLabel;
        private Label CuitLabel;
    }
}
