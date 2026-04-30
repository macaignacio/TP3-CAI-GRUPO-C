namespace TP3_CAI_GRUPO_C
{
    partial class ImposiciónXCDForm
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
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            listView1 = new ListView();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            Codigo = new ColumnHeader();
            Direccion = new ColumnHeader();
            Horarios = new ColumnHeader();
            label10 = new Label();
            label11 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            comboBox4 = new ComboBox();
            textBox8 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Código CD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 31);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "TUTASA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 28);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(20, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Solicitante";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(367, 31);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(207, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 34);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 1;
            label4.Text = "Razón Social:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 34);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "CUIT/CUIL:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(20, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(529, 269);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de envío";
            // 
            // button2
            // 
            button2.Location = new Point(448, 240);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Seleccionar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Codigo, Direccion, Horarios });
            listView1.Location = new Point(18, 150);
            listView1.Name = "listView1";
            listView1.Size = new Size(498, 71);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(344, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(105, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(281, 101);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 7;
            label9.Text = "Dirección";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 101);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 6;
            label8.Text = "Código Postal";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(395, 28);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(79, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 23);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 23);
            comboBox1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(281, 31);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 2;
            label7.Text = "Método de Entrega";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 62);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 1;
            label6.Text = "Localidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 31);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 0;
            label5.Text = "Provincia";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(20, 473);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(529, 70);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Destinatario";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(comboBox4);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(20, 563);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(529, 72);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Encomienda";
            // 
            // Codigo
            // 
            Codigo.Text = "Código";
            // 
            // Direccion
            // 
            Direccion.Text = "Dirección";
            Direccion.Width = 180;
            // 
            // Horarios
            // 
            Horarios.Text = "Horarios";
            Horarios.Width = 180;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 32);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 0;
            label10.Text = "Nombre y apellido";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(337, 32);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 1;
            label11.Text = "DNI";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(123, 29);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(203, 23);
            textBox6.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(370, 29);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(153, 23);
            textBox7.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 37);
            label12.Name = "label12";
            label12.Size = new Size(119, 15);
            label12.TabIndex = 0;
            label12.Text = "Tamaño Encomienda";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(289, 37);
            label13.Name = "label13";
            label13.Size = new Size(100, 15);
            label13.TabIndex = 1;
            label13.Text = "Cantidad de cajas";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(131, 34);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(135, 23);
            comboBox4.TabIndex = 2;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(416, 34);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(387, 652);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Generar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(474, 652);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // ImposiciónXCDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 682);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ImposiciónXCDForm";
            Text = "ImposiciónXCDForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private ListView listView1;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label9;
        private Label label8;
        private Button button2;
        private ColumnHeader Codigo;
        private ColumnHeader Direccion;
        private ColumnHeader Horarios;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label11;
        private Label label10;
        private TextBox textBox8;
        private ComboBox comboBox4;
        private Label label13;
        private Label label12;
        private Button button3;
        private Button button4;
    }
}