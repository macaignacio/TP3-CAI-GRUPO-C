namespace TP3_CAI_GRUPO_C.RecepcionEncomiendasCD
{
    partial class RecepcionEncomiendasCDForm
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
            TutasaLabel = new Label();
            CodigoCDLabel = new Label();
            DetalleHdrGroupBox = new GroupBox();
            DetalleHdrListView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            ConfirmarRecepcionButton = new Button();
            SeleccionarOmnibusGroupBox1 = new GroupBox();
            PatenteTextBox = new TextBox();
            BuscarButton = new Button();
            PatenteLabel = new Label();
            NroCDLabel = new Label();
            AceptarButton = new Button();
            DetalleHdrGroupBox.SuspendLayout();
            SeleccionarOmnibusGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaLabel
            // 
            TutasaLabel.AutoSize = true;
            TutasaLabel.Location = new Point(213, 9);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(50, 15);
            TutasaLabel.TabIndex = 11;
            TutasaLabel.Text = "TUTASA";
            // 
            // CodigoCDLabel
            // 
            CodigoCDLabel.AutoSize = true;
            CodigoCDLabel.Location = new Point(12, 24);
            CodigoCDLabel.Name = "CodigoCDLabel";
            CodigoCDLabel.Size = new Size(68, 15);
            CodigoCDLabel.TabIndex = 10;
            CodigoCDLabel.Text = "Código CD:";
            // 
            // DetalleHdrGroupBox
            // 
            DetalleHdrGroupBox.Controls.Add(DetalleHdrListView);
            DetalleHdrGroupBox.Controls.Add(ConfirmarRecepcionButton);
            DetalleHdrGroupBox.Location = new Point(12, 180);
            DetalleHdrGroupBox.Name = "DetalleHdrGroupBox";
            DetalleHdrGroupBox.Size = new Size(410, 226);
            DetalleHdrGroupBox.TabIndex = 14;
            DetalleHdrGroupBox.TabStop = false;
            DetalleHdrGroupBox.Text = "Detalle de Hojas de Ruta de transporte recibidas";
            // 
            // DetalleHdrListView
            // 
            DetalleHdrListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader3, columnHeader5 });
            DetalleHdrListView.Location = new Point(16, 22);
            DetalleHdrListView.Name = "DetalleHdrListView";
            DetalleHdrListView.Size = new Size(381, 170);
            DetalleHdrListView.TabIndex = 2;
            DetalleHdrListView.UseCompatibleStateImageBehavior = false;
            DetalleHdrListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nro de Órden";
            columnHeader4.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Patente";
            columnHeader5.Width = 80;
            // 
            // ConfirmarRecepcionButton
            // 
            ConfirmarRecepcionButton.Location = new Point(262, 196);
            ConfirmarRecepcionButton.Name = "ConfirmarRecepcionButton";
            ConfirmarRecepcionButton.Size = new Size(135, 23);
            ConfirmarRecepcionButton.TabIndex = 1;
            ConfirmarRecepcionButton.Text = "Confirmar recepción";
            ConfirmarRecepcionButton.UseVisualStyleBackColor = true;
            // 
            // SeleccionarOmnibusGroupBox1
            // 
            SeleccionarOmnibusGroupBox1.Controls.Add(PatenteTextBox);
            SeleccionarOmnibusGroupBox1.Controls.Add(BuscarButton);
            SeleccionarOmnibusGroupBox1.Controls.Add(PatenteLabel);
            SeleccionarOmnibusGroupBox1.Location = new Point(12, 61);
            SeleccionarOmnibusGroupBox1.Name = "SeleccionarOmnibusGroupBox1";
            SeleccionarOmnibusGroupBox1.Size = new Size(251, 100);
            SeleccionarOmnibusGroupBox1.TabIndex = 13;
            SeleccionarOmnibusGroupBox1.TabStop = false;
            SeleccionarOmnibusGroupBox1.Text = "Seleccionar Ómnibus";
            // 
            // PatenteTextBox
            // 
            PatenteTextBox.Location = new Point(83, 33);
            PatenteTextBox.Name = "PatenteTextBox";
            PatenteTextBox.Size = new Size(151, 23);
            PatenteTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(159, 71);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // PatenteLabel
            // 
            PatenteLabel.AutoSize = true;
            PatenteLabel.Location = new Point(11, 36);
            PatenteLabel.Name = "PatenteLabel";
            PatenteLabel.Size = new Size(50, 15);
            PatenteLabel.TabIndex = 0;
            PatenteLabel.Text = "Patente:";
            // 
            // NroCDLabel
            // 
            NroCDLabel.AutoSize = true;
            NroCDLabel.Location = new Point(92, 24);
            NroCDLabel.Name = "NroCDLabel";
            NroCDLabel.Size = new Size(52, 15);
            NroCDLabel.TabIndex = 18;
            NroCDLabel.Text = "[código]";
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(344, 412);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(75, 23);
            AceptarButton.TabIndex = 4;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            // 
            // RecepcionEncomiendasCDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 438);
            Controls.Add(AceptarButton);
            Controls.Add(NroCDLabel);
            Controls.Add(DetalleHdrGroupBox);
            Controls.Add(SeleccionarOmnibusGroupBox1);
            Controls.Add(TutasaLabel);
            Controls.Add(CodigoCDLabel);
            Name = "RecepcionEncomiendasCDForm";
            Text = "Gestión de Recepción de Encomiendas de media/larga distancia";
            Load += RecepcionEncomiendasCDForm_Load;
            DetalleHdrGroupBox.ResumeLayout(false);
            SeleccionarOmnibusGroupBox1.ResumeLayout(false);
            SeleccionarOmnibusGroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label TutasaLabel;
        private Label CodigoCDLabel;
        private GroupBox DetalleHdrGroupBox;
        private ListView DetalleHdrListView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private Button ConfirmarRecepcionButton;
        private GroupBox SeleccionarOmnibusGroupBox1;
        private TextBox PatenteTextBox;
        private Button BuscarButton;
        private Label PatenteLabel;
        private Label NroCDLabel;
        private Button AceptarButton;
    }
}