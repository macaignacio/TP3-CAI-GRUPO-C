namespace TP3_CAI_GRUPO_C
{
    partial class GestionFleterosForm
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            HojadeRuta = new ColumnHeader();
            NumeroGuia = new ColumnHeader();
            Estado = new ColumnHeader();
            groupBox3 = new GroupBox();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 89);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccionar Fletero";
            // 
            // button1
            // 
            button1.Location = new Point(246, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Fletero";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(12, 332);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(484, 170);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hojas de Ruta Asignadas";
            // 
            // button5
            // 
            button5.Location = new Point(222, 141);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 2;
            button5.Text = "Marcar Cumplida";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(353, 141);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 1;
            button2.Text = "Imprimir Detalle";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HojadeRuta, NumeroGuia, Estado });
            listView1.Location = new Point(14, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(345, 104);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // HojadeRuta
            // 
            HojadeRuta.Text = "Hoja de Ruta";
            HojadeRuta.Width = 80;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Número de Guía";
            NumeroGuia.Width = 100;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView2);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(12, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(486, 164);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Asignar Hoja de Ruta";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView2.Location = new Point(16, 22);
            listView2.Name = "listView2";
            listView2.Size = new Size(345, 104);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
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
            // button3
            // 
            button3.Location = new Point(387, 135);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Asignar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(443, 508);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "TUTASA";
            // 
            // GestionFleterosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 537);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "GestionFleterosForm";
            Text = "Gestión de HDR Fleteros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader HojadeRuta;
        private ColumnHeader NumeroGuia;
        private ColumnHeader Estado;
        private GroupBox groupBox3;
        private Button button2;
        private Button button3;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button4;
        private Button button5;
        private Label label2;
    }
}