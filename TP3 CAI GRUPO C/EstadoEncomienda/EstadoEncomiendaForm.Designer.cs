namespace TP3_CAI_GRUPO_C.EstadoEncomienda
{
    partial class EstadoEncomiendaForm
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
            DatosBusquedaGroupBox = new GroupBox();
            BuscarButton = new Button();
            NumeroGuiaTextBox = new TextBox();
            NumeroGuiaLabel = new Label();
            ResultadoBusquedaGroupBox = new GroupBox();
            ResultadoBusquedaListView = new ListView();
            EstadoEncomienda = new ColumnHeader();
            Actualizacion = new ColumnHeader();
            AceptarButton = new Button();
            Ubicacion = new ColumnHeader();
            DatosBusquedaGroupBox.SuspendLayout();
            ResultadoBusquedaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(156, 18);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(50, 15);
            TutasaTituloLabel.TabIndex = 0;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // DatosBusquedaGroupBox
            // 
            DatosBusquedaGroupBox.Controls.Add(BuscarButton);
            DatosBusquedaGroupBox.Controls.Add(NumeroGuiaTextBox);
            DatosBusquedaGroupBox.Controls.Add(NumeroGuiaLabel);
            DatosBusquedaGroupBox.Location = new Point(22, 66);
            DatosBusquedaGroupBox.Name = "DatosBusquedaGroupBox";
            DatosBusquedaGroupBox.Size = new Size(315, 100);
            DatosBusquedaGroupBox.TabIndex = 1;
            DatosBusquedaGroupBox.TabStop = false;
            DatosBusquedaGroupBox.Text = "Datos de Búsqueda";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(234, 71);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
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
            // ResultadoBusquedaGroupBox
            // 
            ResultadoBusquedaGroupBox.Controls.Add(ResultadoBusquedaListView);
            ResultadoBusquedaGroupBox.Location = new Point(22, 196);
            ResultadoBusquedaGroupBox.Name = "ResultadoBusquedaGroupBox";
            ResultadoBusquedaGroupBox.Size = new Size(545, 146);
            ResultadoBusquedaGroupBox.TabIndex = 2;
            ResultadoBusquedaGroupBox.TabStop = false;
            ResultadoBusquedaGroupBox.Text = "Resultado de Búsqueda";
            // 
            // ResultadoBusquedaListView
            // 
            ResultadoBusquedaListView.Columns.AddRange(new ColumnHeader[] { EstadoEncomienda, Actualizacion, Ubicacion });
            ResultadoBusquedaListView.Location = new Point(10, 33);
            ResultadoBusquedaListView.Name = "ResultadoBusquedaListView";
            ResultadoBusquedaListView.Size = new Size(510, 97);
            ResultadoBusquedaListView.TabIndex = 0;
            ResultadoBusquedaListView.UseCompatibleStateImageBehavior = false;
            ResultadoBusquedaListView.View = View.Details;
            // 
            // EstadoEncomienda
            // 
            EstadoEncomienda.Text = "Estado de Encomienda";
            EstadoEncomienda.Width = 200;
            // 
            // Actualizacion
            // 
            Actualizacion.Text = "Última Actualización";
            Actualizacion.Width = 180;
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(492, 352);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(75, 23);
            AceptarButton.TabIndex = 3;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            // 
            // Ubicacion
            // 
            Ubicacion.Text = "Ubicación";
            Ubicacion.Width = 100;
            // 
            // EstadoEncomiendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 387);
            Controls.Add(AceptarButton);
            Controls.Add(ResultadoBusquedaGroupBox);
            Controls.Add(DatosBusquedaGroupBox);
            Controls.Add(TutasaTituloLabel);
            Name = "EstadoEncomiendaForm";
            Text = "EstadoEncomiendaForm";
            Load += EstadoEncomiendaForm_Load;
            DatosBusquedaGroupBox.ResumeLayout(false);
            DatosBusquedaGroupBox.PerformLayout();
            ResultadoBusquedaGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TutasaTituloLabel;
        private GroupBox DatosBusquedaGroupBox;
        private Button BuscarButton;
        private TextBox NumeroGuiaTextBox;
        private Label NumeroGuiaLabel;
        private GroupBox ResultadoBusquedaGroupBox;
        private ListView ResultadoBusquedaListView;
        private ColumnHeader EstadoEncomienda;
        private ColumnHeader Actualizacion;
        private Button AceptarButton;
        private ColumnHeader Ubicacion;
    }
}