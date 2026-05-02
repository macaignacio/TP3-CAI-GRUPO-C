namespace TP3_CAI_GRUPO_C
{
    partial class GestionCDFormOriginal
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            listView1 = new ListView();
            HojaDeRuta = new ColumnHeader();
            NumeroGuia = new ColumnHeader();
            Estado = new ColumnHeader();
            PatenteOmnibus = new ColumnHeader();
            groupBox3 = new GroupBox();
            button3 = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button4 = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Location = new Point(259, 22);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(27, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar órden";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(261, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 0;
            label2.Text = "Código de órden";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(27, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(524, 171);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Confirmar HDR despachadas";
            // 
            // button2
            // 
            button2.Location = new Point(380, 139);
            button2.Name = "button2";
            button2.Size = new Size(138, 23);
            button2.TabIndex = 1;
            button2.Text = "Confirmar despacho";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HojaDeRuta, NumeroGuia, Estado, PatenteOmnibus });
            listView1.Location = new Point(12, 36);
            listView1.Name = "listView1";
            listView1.Size = new Size(506, 97);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // HojaDeRuta
            // 
            HojaDeRuta.Text = "Hoja de Ruta";
            HojaDeRuta.Width = 100;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Número de Guía";
            NumeroGuia.Width = 120;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 120;
            // 
            // PatenteOmnibus
            // 
            PatenteOmnibus.Text = "Patente de Ómnibus";
            PatenteOmnibus.Width = 120;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(listView2);
            groupBox3.Location = new Point(27, 370);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(524, 171);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Confirmar HDR recibidas";
            // 
            // button3
            // 
            button3.Location = new Point(380, 139);
            button3.Name = "button3";
            button3.Size = new Size(138, 23);
            button3.TabIndex = 1;
            button3.Text = "Confirmar recepción";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView2.Location = new Point(12, 36);
            listView2.Name = "listView2";
            listView2.Size = new Size(506, 97);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hoja de Ruta";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Número de Guía";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estado";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Patente de Ómnibus";
            columnHeader4.Width = 120;
            // 
            // button4
            // 
            button4.Location = new Point(476, 547);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuHighlight;
            label3.Location = new Point(35, 13);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 5;
            label3.Text = "PANTALLA NO VALIDADA.";
            // 
            // GestionCDFormOriginal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 577);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "GestionCDFormOriginal";
            Text = "Gestión de encomiendas en CD";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private ListView listView1;
        private Button button2;
        private ColumnHeader HojaDeRuta;
        private ColumnHeader NumeroGuia;
        private ColumnHeader Estado;
        private ColumnHeader PatenteOmnibus;
        private GroupBox groupBox3;
        private Button button3;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button4;
        private Label label3;
    }
}