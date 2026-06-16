namespace TP3_CAI_GRUPO_C.GestionFleterosRendicion
{
    partial class GestionFleterosRendicionForm
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
            HdrAsignadasGroupBox = new GroupBox();
            InstruccionesLabel = new Label();
            HdrAsignadasListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ConfirmarCumplidaButton = new Button();
            ConfirmarNoCumplidaButton = new Button();
            SelecFleteroGroupBox = new GroupBox();
            traerNombreFleteroLabel = new Label();
            NombreFleteroLabel = new Label();
            CuitTextBox = new TextBox();
            BuscarButton = new Button();
            CuitLabel = new Label();
            HdrAsignadasGroupBox.SuspendLayout();
            SelecFleteroGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TutasaLabel
            // 
            TutasaLabel.AutoSize = true;
            TutasaLabel.Location = new Point(318, 19);
            TutasaLabel.Margin = new Padding(6, 0, 6, 0);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(97, 32);
            TutasaLabel.TabIndex = 0;
            TutasaLabel.Text = "TUTASA";
            // 
            // HdrAsignadasGroupBox
            // 
            HdrAsignadasGroupBox.Controls.Add(InstruccionesLabel);
            HdrAsignadasGroupBox.Controls.Add(HdrAsignadasListView);
            HdrAsignadasGroupBox.Location = new Point(24, 348);
            HdrAsignadasGroupBox.Margin = new Padding(6, 6, 6, 6);
            HdrAsignadasGroupBox.Name = "HdrAsignadasGroupBox";
            HdrAsignadasGroupBox.Padding = new Padding(6, 6, 6, 6);
            HdrAsignadasGroupBox.Size = new Size(910, 529);
            HdrAsignadasGroupBox.TabIndex = 2;
            HdrAsignadasGroupBox.TabStop = false;
            HdrAsignadasGroupBox.Text = "Hojas de Ruta Asignadas";
            // 
            // InstruccionesLabel
            // 
            InstruccionesLabel.AutoSize = true;
            InstruccionesLabel.Location = new Point(30, 60);
            InstruccionesLabel.Margin = new Padding(6, 0, 6, 0);
            InstruccionesLabel.Name = "InstruccionesLabel";
            InstruccionesLabel.Size = new Size(574, 32);
            InstruccionesLabel.TabIndex = 2;
            InstruccionesLabel.Text = "Marcar las HDR a procesar y seleccionar el resultado:";
            // 
            // HdrAsignadasListView
            // 
            HdrAsignadasListView.CheckBoxes = true;
            HdrAsignadasListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            HdrAsignadasListView.Location = new Point(30, 115);
            HdrAsignadasListView.Margin = new Padding(6, 6, 6, 6);
            HdrAsignadasListView.Name = "HdrAsignadasListView";
            HdrAsignadasListView.Size = new Size(866, 399);
            HdrAsignadasListView.TabIndex = 0;
            HdrAsignadasListView.UseCompatibleStateImageBehavior = false;
            HdrAsignadasListView.View = View.Details;
            HdrAsignadasListView.ItemChecked += HdrAsignadasListView_ItemChecked;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Número de Guía";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 180;
            // 
            // ConfirmarCumplidaButton
            // 
            ConfirmarCumplidaButton.Location = new Point(390, 887);
            ConfirmarCumplidaButton.Margin = new Padding(6, 6, 6, 6);
            ConfirmarCumplidaButton.Name = "ConfirmarCumplidaButton";
            ConfirmarCumplidaButton.Size = new Size(260, 49);
            ConfirmarCumplidaButton.TabIndex = 4;
            ConfirmarCumplidaButton.Text = "Confirmar cumplidas";
            ConfirmarCumplidaButton.UseVisualStyleBackColor = true;
            ConfirmarCumplidaButton.Click += ConfirmarCumplidaButton_Click;
            // 
            // ConfirmarNoCumplidaButton
            // 
            ConfirmarNoCumplidaButton.Location = new Point(669, 887);
            ConfirmarNoCumplidaButton.Margin = new Padding(6, 6, 6, 6);
            ConfirmarNoCumplidaButton.Name = "ConfirmarNoCumplidaButton";
            ConfirmarNoCumplidaButton.Size = new Size(288, 49);
            ConfirmarNoCumplidaButton.TabIndex = 5;
            ConfirmarNoCumplidaButton.Text = "Confirmar no cumplidas";
            ConfirmarNoCumplidaButton.UseVisualStyleBackColor = true;
            ConfirmarNoCumplidaButton.Click += ConfirmarNoCumplidaButton_Click;
            // 
            // SelecFleteroGroupBox
            // 
            SelecFleteroGroupBox.Controls.Add(traerNombreFleteroLabel);
            SelecFleteroGroupBox.Controls.Add(NombreFleteroLabel);
            SelecFleteroGroupBox.Controls.Add(CuitTextBox);
            SelecFleteroGroupBox.Controls.Add(BuscarButton);
            SelecFleteroGroupBox.Controls.Add(CuitLabel);
            SelecFleteroGroupBox.Location = new Point(24, 98);
            SelecFleteroGroupBox.Margin = new Padding(6, 6, 6, 6);
            SelecFleteroGroupBox.Name = "SelecFleteroGroupBox";
            SelecFleteroGroupBox.Padding = new Padding(6, 6, 6, 6);
            SelecFleteroGroupBox.Size = new Size(910, 190);
            SelecFleteroGroupBox.TabIndex = 7;
            SelecFleteroGroupBox.TabStop = false;
            SelecFleteroGroupBox.Text = "Seleccionar Fletero";
            // 
            // traerNombreFleteroLabel
            // 
            traerNombreFleteroLabel.AutoSize = true;
            traerNombreFleteroLabel.Location = new Point(550, 66);
            traerNombreFleteroLabel.Margin = new Padding(6, 0, 6, 0);
            traerNombreFleteroLabel.Name = "traerNombreFleteroLabel";
            traerNombreFleteroLabel.Size = new Size(193, 32);
            traerNombreFleteroLabel.TabIndex = 5;
            traerNombreFleteroLabel.Text = "[nombre Fletero]";
            // 
            // NombreFleteroLabel
            // 
            NombreFleteroLabel.AutoSize = true;
            NombreFleteroLabel.Location = new Point(446, 66);
            NombreFleteroLabel.Margin = new Padding(6, 0, 6, 0);
            NombreFleteroLabel.Name = "NombreFleteroLabel";
            NombreFleteroLabel.Size = new Size(107, 32);
            NombreFleteroLabel.TabIndex = 4;
            NombreFleteroLabel.Text = "Nombre:";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(178, 60);
            CuitTextBox.Margin = new Padding(6, 6, 6, 6);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(245, 39);
            CuitTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(760, 128);
            BuscarButton.Margin = new Padding(6, 6, 6, 6);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(139, 49);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // CuitLabel
            // 
            CuitLabel.AutoSize = true;
            CuitLabel.BackColor = SystemColors.Control;
            CuitLabel.Location = new Point(30, 66);
            CuitLabel.Margin = new Padding(6, 0, 6, 0);
            CuitLabel.Name = "CuitLabel";
            CuitLabel.Size = new Size(126, 32);
            CuitLabel.TabIndex = 0;
            CuitLabel.Text = "CUIT/CUIL:";
            // 
            // GestionFleterosRendicionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 958);
            Controls.Add(SelecFleteroGroupBox);
            Controls.Add(ConfirmarCumplidaButton);
            Controls.Add(ConfirmarNoCumplidaButton);
            Controls.Add(HdrAsignadasGroupBox);
            Controls.Add(TutasaLabel);
            Margin = new Padding(6, 6, 6, 6);
            Name = "GestionFleterosRendicionForm";
            Text = "Gestión HDR Asignadas a Fleteros";
            Load += GestionFleterosRendicionForm_Load;
            HdrAsignadasGroupBox.ResumeLayout(false);
            HdrAsignadasGroupBox.PerformLayout();
            SelecFleteroGroupBox.ResumeLayout(false);
            SelecFleteroGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TutasaLabel;
        private GroupBox HdrAsignadasGroupBox;
        private ListView HdrAsignadasListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button ConfirmarCumplidaButton;
        private Button ConfirmarNoCumplidaButton;
        private GroupBox SelecFleteroGroupBox;
        private Label NombreFleteroLabel;
        private TextBox CuitTextBox;
        private Button BuscarButton;
        private Label CuitLabel;
        private Label traerNombreFleteroLabel;
        private Label InstruccionesLabel;
    }
}
