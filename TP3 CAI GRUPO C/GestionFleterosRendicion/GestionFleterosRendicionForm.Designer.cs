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
            CumplidoCheckBox = new CheckBox();
            HdrAsignadasListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ConfirmarButton = new Button();
            SelecFleteroGroupBox = new GroupBox();
            NombreFleteroTextBox = new TextBox();
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
            TutasaLabel.Location = new Point(171, 9);
            TutasaLabel.Name = "TutasaLabel";
            TutasaLabel.Size = new Size(50, 15);
            TutasaLabel.TabIndex = 0;
            TutasaLabel.Text = "TUTASA";
            // 
            // HdrAsignadasGroupBox
            // 
            HdrAsignadasGroupBox.Controls.Add(CumplidoCheckBox);
            HdrAsignadasGroupBox.Controls.Add(HdrAsignadasListView);
            HdrAsignadasGroupBox.Location = new Point(13, 163);
            HdrAsignadasGroupBox.Name = "HdrAsignadasGroupBox";
            HdrAsignadasGroupBox.Size = new Size(490, 248);
            HdrAsignadasGroupBox.TabIndex = 2;
            HdrAsignadasGroupBox.TabStop = false;
            HdrAsignadasGroupBox.Text = "Hojas de Ruta Asignadas";
            // 
            // CumplidoCheckBox
            // 
            CumplidoCheckBox.AutoSize = true;
            CumplidoCheckBox.Location = new Point(174, 53);
            CumplidoCheckBox.Margin = new Padding(3, 2, 3, 2);
            CumplidoCheckBox.Name = "CumplidoCheckBox";
            CumplidoCheckBox.Size = new Size(79, 19);
            CumplidoCheckBox.TabIndex = 1;
            CumplidoCheckBox.Text = "Cumplido";
            CumplidoCheckBox.UseVisualStyleBackColor = true;
            // 
            // HdrAsignadasListView
            // 
            HdrAsignadasListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            HdrAsignadasListView.Location = new Point(16, 21);
            HdrAsignadasListView.Name = "HdrAsignadasListView";
            HdrAsignadasListView.Size = new Size(468, 222);
            HdrAsignadasListView.TabIndex = 0;
            HdrAsignadasListView.UseCompatibleStateImageBehavior = false;
            HdrAsignadasListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Número de Guía";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 100;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(396, 416);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(107, 23);
            ConfirmarButton.TabIndex = 4;
            ConfirmarButton.Text = "Confirmar";
            ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // SelecFleteroGroupBox
            // 
            SelecFleteroGroupBox.Controls.Add(NombreFleteroTextBox);
            SelecFleteroGroupBox.Controls.Add(NombreFleteroLabel);
            SelecFleteroGroupBox.Controls.Add(CuitTextBox);
            SelecFleteroGroupBox.Controls.Add(BuscarButton);
            SelecFleteroGroupBox.Controls.Add(CuitLabel);
            SelecFleteroGroupBox.Location = new Point(13, 46);
            SelecFleteroGroupBox.Name = "SelecFleteroGroupBox";
            SelecFleteroGroupBox.Size = new Size(490, 89);
            SelecFleteroGroupBox.TabIndex = 7;
            SelecFleteroGroupBox.TabStop = false;
            SelecFleteroGroupBox.Text = "Seleccionar Fletero";
            // 
            // NombreFleteroTextBox
            // 
            NombreFleteroTextBox.Location = new Point(300, 28);
            NombreFleteroTextBox.Name = "NombreFleteroTextBox";
            NombreFleteroTextBox.ReadOnly = true;
            NombreFleteroTextBox.Size = new Size(184, 23);
            NombreFleteroTextBox.TabIndex = 5;
            // 
            // NombreFleteroLabel
            // 
            NombreFleteroLabel.AutoSize = true;
            NombreFleteroLabel.Location = new Point(240, 31);
            NombreFleteroLabel.Name = "NombreFleteroLabel";
            NombreFleteroLabel.Size = new Size(54, 15);
            NombreFleteroLabel.TabIndex = 4;
            NombreFleteroLabel.Text = "Nombre:";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(96, 28);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(134, 23);
            CuitTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(409, 60);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(75, 23);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // CuitLabel
            // 
            CuitLabel.AutoSize = true;
            CuitLabel.BackColor = SystemColors.Control;
            CuitLabel.Location = new Point(16, 31);
            CuitLabel.Name = "CuitLabel";
            CuitLabel.Size = new Size(66, 15);
            CuitLabel.TabIndex = 0;
            CuitLabel.Text = "CUIT/CUIL:";
            // 
            // GestionFleterosRendicionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 449);
            Controls.Add(SelecFleteroGroupBox);
            Controls.Add(ConfirmarButton);
            Controls.Add(HdrAsignadasGroupBox);
            Controls.Add(TutasaLabel);
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
        private Button ConfirmarButton;
        private GroupBox SelecFleteroGroupBox;
        private TextBox NombreFleteroTextBox;
        private Label NombreFleteroLabel;
        private TextBox CuitTextBox;
        private Button BuscarButton;
        private Label CuitLabel;
        private CheckBox CumplidoCheckBox;
    }
}