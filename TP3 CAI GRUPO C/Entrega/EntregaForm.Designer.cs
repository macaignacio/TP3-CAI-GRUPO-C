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
            TutasaTituloLabel.Location = new Point(206, 14);
            TutasaTituloLabel.Name = "TutasaTituloLabel";
            TutasaTituloLabel.Size = new Size(50, 15);
            TutasaTituloLabel.TabIndex = 0;
            TutasaTituloLabel.Text = "TUTASA";
            // 
            // VerififcacionDestinatarioGroupBox
            // 
            VerififcacionDestinatarioGroupBox.Controls.Add(BuscarButton);
            VerififcacionDestinatarioGroupBox.Controls.Add(DniTextBox);
            VerififcacionDestinatarioGroupBox.Controls.Add(DNILabel);
            VerififcacionDestinatarioGroupBox.Location = new Point(34, 56);
            VerififcacionDestinatarioGroupBox.Name = "VerififcacionDestinatarioGroupBox";
            VerififcacionDestinatarioGroupBox.Size = new Size(390, 79);
            VerififcacionDestinatarioGroupBox.TabIndex = 1;
            VerififcacionDestinatarioGroupBox.TabStop = false;
            VerififcacionDestinatarioGroupBox.Text = "Verificación de Destinatario";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(234, 31);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(59, 33);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(167, 23);
            DniTextBox.TabIndex = 1;
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Location = new Point(15, 36);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(27, 15);
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
            DatosEncomiendasGroupBox.Location = new Point(34, 167);
            DatosEncomiendasGroupBox.Name = "DatosEncomiendasGroupBox";
            DatosEncomiendasGroupBox.Size = new Size(393, 222);
            DatosEncomiendasGroupBox.TabIndex = 2;
            DatosEncomiendasGroupBox.TabStop = false;
            DatosEncomiendasGroupBox.Text = "Datos de Encomiendas";
            // 
            // NuevaConsultabtn
            // 
            NuevaConsultabtn.Location = new Point(253, 193);
            NuevaConsultabtn.Name = "NuevaConsultabtn";
            NuevaConsultabtn.Size = new Size(125, 23);
            NuevaConsultabtn.TabIndex = 4;
            NuevaConsultabtn.Text = "Nueva Consulta";
            NuevaConsultabtn.UseVisualStyleBackColor = true;
            // 
            // traerNombreDestinatarioLabel
            // 
            traerNombreDestinatarioLabel.AutoSize = true;
            traerNombreDestinatarioLabel.Location = new Point(126, 28);
            traerNombreDestinatarioLabel.Name = "traerNombreDestinatarioLabel";
            traerNombreDestinatarioLabel.Size = new Size(122, 15);
            traerNombreDestinatarioLabel.TabIndex = 3;
            traerNombreDestinatarioLabel.Text = "[nombre destinatario]";
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(122, 193);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(125, 23);
            ConfirmarButton.TabIndex = 2;
            ConfirmarButton.Text = "Confirmar entrega";
            ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // DatosEncomiendaListView
            // 
            DatosEncomiendaListView.Columns.AddRange(new ColumnHeader[] { NumeroGuia, Estado });
            DatosEncomiendaListView.Location = new Point(11, 54);
            DatosEncomiendaListView.Name = "DatosEncomiendaListView";
            DatosEncomiendaListView.Size = new Size(367, 116);
            DatosEncomiendaListView.TabIndex = 1;
            DatosEncomiendaListView.UseCompatibleStateImageBehavior = false;
            DatosEncomiendaListView.View = View.Details;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Numero de Guía";
            NumeroGuia.Width = 200;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 300;
            // 
            // NombreApellidoLabel
            // 
            NombreApellidoLabel.AutoSize = true;
            NombreApellidoLabel.Location = new Point(11, 27);
            NombreApellidoLabel.Name = "NombreApellidoLabel";
            NombreApellidoLabel.Size = new Size(108, 15);
            NombreApellidoLabel.TabIndex = 0;
            NombreApellidoLabel.Text = "Nombre y apellido:";
            // 
            // EntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 401);
            Controls.Add(DatosEncomiendasGroupBox);
            Controls.Add(VerififcacionDestinatarioGroupBox);
            Controls.Add(TutasaTituloLabel);
            Name = "EntregaForm";
            Text = "Confirmación de entrega";
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