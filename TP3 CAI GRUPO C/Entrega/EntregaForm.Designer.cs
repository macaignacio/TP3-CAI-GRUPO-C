namespace TP3_CAI_GRUPO_C.Entrega
{
    partial class EntregaForm
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
            VerififcacionDestinatarioGroupBox = new GroupBox();
            BuscarButton = new Button();
            DniTextBox = new TextBox();
            DNILabel = new Label();
            DatosEncomiendasGroupBox = new GroupBox();
            NombreApellidoTextBox = new TextBox();
            ConfirmarButton = new Button();
            DatosEncomiendaListView = new ListView();
            NumeroGuia = new ColumnHeader();
            Estado = new ColumnHeader();
            NombreApellidoLabel = new Label();
            VerififcacionDestinatarioGroupBox.SuspendLayout();
            DatosEncomiendasGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaTituloLabel
            // 
            TutasaTituloLabel.AutoSize = true;
            TutasaTituloLabel.Location = new Point(295, 24);
            TutasaTituloLabel.Margin = new Padding(4, 0, 4, 0);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(75, 25);
            TutasaTituloLabel.TabIndex = 0;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // VerififcacionDestinatarioGroupBox
            // 
            VerififcacionDestinatarioGroupBox.Controls.Add(BuscarButton);
            VerififcacionDestinatarioGroupBox.Controls.Add(DniTextBox);
            VerififcacionDestinatarioGroupBox.Controls.Add(DNILabel);
            VerififcacionDestinatarioGroupBox.Location = new Point(49, 93);
            VerififcacionDestinatarioGroupBox.Margin = new Padding(4, 5, 4, 5);
            VerififcacionDestinatarioGroupBox.Name = "VerififcacionDestinatarioGroupBox";
            VerififcacionDestinatarioGroupBox.Padding = new Padding(4, 5, 4, 5);
            VerififcacionDestinatarioGroupBox.Size = new Size(557, 131);
            VerififcacionDestinatarioGroupBox.TabIndex = 1;
            VerififcacionDestinatarioGroupBox.TabStop = false;
            VerififcacionDestinatarioGroupBox.Text = "Verificación de Destinatario";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(334, 51);
            BuscarButton.Margin = new Padding(4, 5, 4, 5);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(107, 38);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(84, 55);
            DniTextBox.Margin = new Padding(4, 5, 4, 5);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(237, 31);
            DniTextBox.TabIndex = 1;
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Location = new Point(21, 60);
            DNILabel.Margin = new Padding(4, 0, 4, 0);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(43, 25);
            DNILabel.TabIndex = 0;
            DNILabel.Text = "DNI";
            // 
            // DatosEncomiendasGroupBox
            // 
            DatosEncomiendasGroupBox.Controls.Add(NombreApellidoTextBox);
            DatosEncomiendasGroupBox.Controls.Add(ConfirmarButton);
            DatosEncomiendasGroupBox.Controls.Add(DatosEncomiendaListView);
            DatosEncomiendasGroupBox.Controls.Add(NombreApellidoLabel);
            DatosEncomiendasGroupBox.Location = new Point(49, 278);
            DatosEncomiendasGroupBox.Margin = new Padding(4, 5, 4, 5);
            DatosEncomiendasGroupBox.Name = "DatosEncomiendasGroupBox";
            DatosEncomiendasGroupBox.Padding = new Padding(4, 5, 4, 5);
            DatosEncomiendasGroupBox.Size = new Size(561, 338);
            DatosEncomiendasGroupBox.TabIndex = 2;
            DatosEncomiendasGroupBox.TabStop = false;
            DatosEncomiendasGroupBox.Text = "Datos de Encomiendas";
            // 
            // NombreApellidoTextBox
            // 
            NombreApellidoTextBox.Location = new Point(184, 42);
            NombreApellidoTextBox.Margin = new Padding(4, 5, 4, 5);
            NombreApellidoTextBox.Name = "NombreApellidoTextBox";
            NombreApellidoTextBox.ReadOnly = true;
            NombreApellidoTextBox.Size = new Size(257, 31);
            NombreApellidoTextBox.TabIndex = 3;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(360, 290);
            ConfirmarButton.Margin = new Padding(4, 5, 4, 5);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(179, 38);
            ConfirmarButton.TabIndex = 2;
            ConfirmarButton.Text = "Confirmar entrega";
            ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // DatosEncomiendaListView
            // 
            DatosEncomiendaListView.Columns.AddRange(new ColumnHeader[] { NumeroGuia, Estado });
            DatosEncomiendaListView.Location = new Point(16, 90);
            DatosEncomiendaListView.Margin = new Padding(4, 5, 4, 5);
            DatosEncomiendaListView.Name = "DatosEncomiendaListView";
            DatosEncomiendaListView.Size = new Size(523, 159);
            DatosEncomiendaListView.TabIndex = 1;
            DatosEncomiendaListView.UseCompatibleStateImageBehavior = false;
            DatosEncomiendaListView.View = View.Details;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Numero de Guía";
            NumeroGuia.Width = 100;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // NombreApellidoLabel
            // 
            NombreApellidoLabel.AutoSize = true;
            NombreApellidoLabel.Location = new Point(16, 45);
            NombreApellidoLabel.Margin = new Padding(4, 0, 4, 0);
            NombreApellidoLabel.Name = "NombreApellidoLabel";
            NombreApellidoLabel.Size = new Size(164, 25);
            NombreApellidoLabel.TabIndex = 0;
            NombreApellidoLabel.Text = "Nombre y apellido:";
            // 
            // EntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 657);
            Controls.Add(DatosEncomiendasGroupBox);
            Controls.Add(VerififcacionDestinatarioGroupBox);
            Controls.Add(TutasaTituloLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EntregaForm";
            Text = "EntregaForm";
            VerififcacionDestinatarioGroupBox.ResumeLayout(false);
            VerififcacionDestinatarioGroupBox.PerformLayout();
            DatosEncomiendasGroupBox.ResumeLayout(false);
            DatosEncomiendasGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TutasaTituloLabel;
        private GroupBox VerififcacionDestinatarioGroupBox;
        private Button BuscarButton;
        private TextBox DniTextBox;
        private Label DNILabel;
        private GroupBox DatosEncomiendasGroupBox;
        private Button ConfirmarButton;
        private ListView DatosEncomiendaListView;
        private ColumnHeader NumeroGuia;
        private ColumnHeader Estado;
        private Label NombreApellidoLabel;
        private TextBox NombreApellidoTextBox;
    }
}