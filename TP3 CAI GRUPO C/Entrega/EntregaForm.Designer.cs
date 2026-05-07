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
            NuevaConsultabtn = new Button();
            traerNombreDestinatarioLabel = new Label();
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
            TutasaTituloLabel.Location = new Point(383, 30);
            TutasaTituloLabel.Margin = new Padding(6, 0, 6, 0);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(97, 32);
            TutasaTituloLabel.TabIndex = 0;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // VerififcacionDestinatarioGroupBox
            // 
            VerififcacionDestinatarioGroupBox.Controls.Add(BuscarButton);
            VerififcacionDestinatarioGroupBox.Controls.Add(DniTextBox);
            VerififcacionDestinatarioGroupBox.Controls.Add(DNILabel);
            VerififcacionDestinatarioGroupBox.Location = new Point(63, 119);
            VerififcacionDestinatarioGroupBox.Margin = new Padding(6);
            VerififcacionDestinatarioGroupBox.Name = "VerififcacionDestinatarioGroupBox";
            VerififcacionDestinatarioGroupBox.Padding = new Padding(6);
            VerififcacionDestinatarioGroupBox.Size = new Size(724, 169);
            VerififcacionDestinatarioGroupBox.TabIndex = 1;
            VerififcacionDestinatarioGroupBox.TabStop = false;
            VerififcacionDestinatarioGroupBox.Text = "Verificación de Destinatario";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(435, 66);
            BuscarButton.Margin = new Padding(6);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(139, 49);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(110, 70);
            DniTextBox.Margin = new Padding(6);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(307, 39);
            DniTextBox.TabIndex = 1;
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Location = new Point(28, 77);
            DNILabel.Margin = new Padding(6, 0, 6, 0);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(55, 32);
            DNILabel.TabIndex = 0;
            DNILabel.Text = "DNI";
            // 
            // DatosEncomiendasGroupBox
            // 
            DatosEncomiendasGroupBox.Controls.Add(NuevaConsultabtn);
            DatosEncomiendasGroupBox.Controls.Add(traerNombreDestinatarioLabel);
            DatosEncomiendasGroupBox.Controls.Add(ConfirmarButton);
            DatosEncomiendasGroupBox.Controls.Add(DatosEncomiendaListView);
            DatosEncomiendasGroupBox.Controls.Add(NombreApellidoLabel);
            DatosEncomiendasGroupBox.Location = new Point(63, 356);
            DatosEncomiendasGroupBox.Margin = new Padding(6);
            DatosEncomiendasGroupBox.Name = "DatosEncomiendasGroupBox";
            DatosEncomiendasGroupBox.Padding = new Padding(6);
            DatosEncomiendasGroupBox.Size = new Size(730, 433);
            DatosEncomiendasGroupBox.TabIndex = 2;
            DatosEncomiendasGroupBox.TabStop = false;
            DatosEncomiendasGroupBox.Text = "Datos de Encomiendas";
            // 
            // NuevaConsultabtn
            // 
            NuevaConsultabtn.Location = new Point(478, 372);
            NuevaConsultabtn.Margin = new Padding(6);
            NuevaConsultabtn.Name = "NuevaConsultabtn";
            NuevaConsultabtn.Size = new Size(232, 49);
            NuevaConsultabtn.TabIndex = 4;
            NuevaConsultabtn.Text = "Nueva Consulta";
            NuevaConsultabtn.UseVisualStyleBackColor = true;
            // 
            // traerNombreDestinatarioLabel
            // 
            traerNombreDestinatarioLabel.AutoSize = true;
            traerNombreDestinatarioLabel.Location = new Point(234, 60);
            traerNombreDestinatarioLabel.Margin = new Padding(6, 0, 6, 0);
            traerNombreDestinatarioLabel.Name = "traerNombreDestinatarioLabel";
            traerNombreDestinatarioLabel.Size = new Size(244, 32);
            traerNombreDestinatarioLabel.TabIndex = 3;
            traerNombreDestinatarioLabel.Text = "[nombre destinatario]";
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(234, 372);
            ConfirmarButton.Margin = new Padding(6);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(232, 49);
            ConfirmarButton.TabIndex = 2;
            ConfirmarButton.Text = "Confirmar entrega";
            ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // DatosEncomiendaListView
            // 
            DatosEncomiendaListView.Columns.AddRange(new ColumnHeader[] { NumeroGuia, Estado });
            DatosEncomiendaListView.Location = new Point(20, 115);
            DatosEncomiendaListView.Margin = new Padding(6);
            DatosEncomiendaListView.Name = "DatosEncomiendaListView";
            DatosEncomiendaListView.Size = new Size(678, 202);
            DatosEncomiendaListView.TabIndex = 1;
            DatosEncomiendaListView.UseCompatibleStateImageBehavior = false;
            DatosEncomiendaListView.View = View.Details;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Numero de Guía";
            NumeroGuia.Width = 230;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 300;
            // 
            // NombreApellidoLabel
            // 
            NombreApellidoLabel.AutoSize = true;
            NombreApellidoLabel.Location = new Point(20, 58);
            NombreApellidoLabel.Margin = new Padding(6, 0, 6, 0);
            NombreApellidoLabel.Name = "NombreApellidoLabel";
            NombreApellidoLabel.Size = new Size(218, 32);
            NombreApellidoLabel.TabIndex = 0;
            NombreApellidoLabel.Text = "Nombre y apellido:";
            // 
            // EntregaForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 841);
            Controls.Add(DatosEncomiendasGroupBox);
            Controls.Add(VerififcacionDestinatarioGroupBox);
            Controls.Add(TutasaTituloLabel);
            Margin = new Padding(6);
            Name = "EntregaForm";
            Text = "EntregaForm";
            Load += EntregaForm_Load;
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
        private Label traerNombreDestinatarioLabel;
        private Button NuevaConsultabtn;
    }
}