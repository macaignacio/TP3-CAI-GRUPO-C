namespace TP3_CAI_GRUPO_C
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
            DatosBusquedaGroupBox.SuspendLayout();
            ResultadoBusquedaGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(223, 30);
            TutasaTituloLabel.Margin = new Padding(4, 0, 4, 0);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(75, 25);
            TutasaTituloLabel.TabIndex = 0;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // DatosBusquedaGroupBox
            // 
            DatosBusquedaGroupBox.Controls.Add(BuscarButton);
            DatosBusquedaGroupBox.Controls.Add(NumeroGuiaTextBox);
            DatosBusquedaGroupBox.Controls.Add(NumeroGuiaLabel);
            DatosBusquedaGroupBox.Location = new Point(31, 110);
            DatosBusquedaGroupBox.Margin = new Padding(4, 5, 4, 5);
            DatosBusquedaGroupBox.Name = "DatosBusquedaGroupBox";
            DatosBusquedaGroupBox.Padding = new Padding(4, 5, 4, 5);
            DatosBusquedaGroupBox.Size = new Size(450, 167);
            DatosBusquedaGroupBox.TabIndex = 1;
            DatosBusquedaGroupBox.TabStop = false;
            DatosBusquedaGroupBox.Text = "Datos de Búsqueda";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(334, 118);
            BuscarButton.Margin = new Padding(4, 5, 4, 5);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(107, 38);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // NumeroGuiaTextBox
            // 
            NumeroGuiaTextBox.Location = new Point(161, 45);
            NumeroGuiaTextBox.Margin = new Padding(4, 5, 4, 5);
            NumeroGuiaTextBox.Name = "NumeroGuiaTextBox";
            NumeroGuiaTextBox.Size = new Size(258, 31);
            NumeroGuiaTextBox.TabIndex = 1;
            // 
            // NumeroGuiaLabel
            // 
            NumeroGuiaLabel.AutoSize = true;
            NumeroGuiaLabel.Location = new Point(14, 50);
            NumeroGuiaLabel.Margin = new Padding(4, 0, 4, 0);
            NumeroGuiaLabel.Name = "NumeroGuiaLabel";
            NumeroGuiaLabel.Size = new Size(146, 25);
            NumeroGuiaLabel.TabIndex = 0;
            NumeroGuiaLabel.Text = "Número de Guía:";
            // 
            // ResultadoBusquedaGroupBox
            // 
            ResultadoBusquedaGroupBox.Controls.Add(ResultadoBusquedaListView);
            ResultadoBusquedaGroupBox.Location = new Point(31, 327);
            ResultadoBusquedaGroupBox.Margin = new Padding(4, 5, 4, 5);
            ResultadoBusquedaGroupBox.Name = "ResultadoBusquedaGroupBox";
            ResultadoBusquedaGroupBox.Padding = new Padding(4, 5, 4, 5);
            ResultadoBusquedaGroupBox.Size = new Size(450, 243);
            ResultadoBusquedaGroupBox.TabIndex = 2;
            ResultadoBusquedaGroupBox.TabStop = false;
            ResultadoBusquedaGroupBox.Text = "Resultado de Búsqueda";
            // 
            // ResultadoBusquedaListView
            // 
            ResultadoBusquedaListView.Columns.AddRange(new ColumnHeader[] { EstadoEncomienda, Actualizacion });
            ResultadoBusquedaListView.Location = new Point(14, 55);
            ResultadoBusquedaListView.Margin = new Padding(4, 5, 4, 5);
            ResultadoBusquedaListView.Name = "ResultadoBusquedaListView";
            ResultadoBusquedaListView.Size = new Size(405, 159);
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
            AceptarButton.Location = new Point(374, 587);
            AceptarButton.Margin = new Padding(4, 5, 4, 5);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(107, 38);
            AceptarButton.TabIndex = 3;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            // 
            // EstadoEncomiendaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 645);
            Controls.Add(AceptarButton);
            Controls.Add(ResultadoBusquedaGroupBox);
            Controls.Add(DatosBusquedaGroupBox);
            Controls.Add(TutasaTituloLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EstadoEncomiendaForm";
            Text = "EstadoEncomiendaForm";
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
    }
}