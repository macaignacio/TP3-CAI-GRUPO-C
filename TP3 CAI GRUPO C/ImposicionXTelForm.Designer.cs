namespace TP3_CAI_GRUPO_C
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBox5 = new ComboBox();
            listView1 = new ListView();
            Codigo = new ColumnHeader();
            Dirección = new ColumnHeader();
            Horarios = new ColumnHeader();
            groupBox4 = new GroupBox();
            textBox7 = new TextBox();
            label13 = new Label();
            textBox8 = new TextBox();
            label14 = new Label();
            textBox9 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            groupBox5 = new GroupBox();
            comboBox6 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            Seleccionar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            // SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 81);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Solicitante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "CUIT/CUIL:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(173, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 103);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de retiro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "Provincia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 65);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 1;
            label4.Text = "Localidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 28);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 2;
            label5.Text = "Código Postal";
            // label5.Click += this.label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 65);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 3;
            label6.Text = "Dirección";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(80, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(80, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(174, 23);
            comboBox2.TabIndex = 5;
            comboBox2.Text = "*bloquear*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(373, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Seleccionar);
            groupBox3.Controls.Add(listView1);
            groupBox3.Controls.Add(comboBox5);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(15, 287);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(587, 253);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información de envío";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(283, 26);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 5;
            label7.Text = "Razón Social";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(373, 22);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(211, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(370, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(93, 102);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(175, 23);
            textBox6.TabIndex = 14;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(77, 61);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(174, 23);
            comboBox3.TabIndex = 13;
            comboBox3.Text = "*bloquear*";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(77, 24);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(174, 23);
            comboBox4.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 105);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 11;
            label8.Text = "Dirección";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 102);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 10;
            label9.Text = "Código Postal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 64);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 9;
            label10.Text = "Localidad";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 27);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 8;
            label11.Text = "Provincia";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(280, 30);
            label12.Name = "label12";
            label12.Size = new Size(108, 15);
            label12.TabIndex = 16;
            label12.Text = "Método de Entrega";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(402, 27);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(179, 23);
            comboBox5.TabIndex = 17;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Codigo, Dirección, Horarios });
            listView1.Location = new Point(6, 148);
            listView1.Name = "listView1";
            listView1.Size = new Size(575, 65);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo";
            // 
            // Dirección
            // 
            Dirección.Text = "Dirección";
            Dirección.Width = 180;
            // 
            // Horarios
            // 
            Horarios.Text = "Horarios";
            Horarios.Width = 150;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox7);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(16, 559);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(590, 60);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Destinatario";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(373, 22);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(211, 23);
            textBox7.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(340, 26);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 5;
            label13.Text = "DNI";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(117, 22);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(166, 23);
            textBox8.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 26);
            label14.Name = "label14";
            label14.Size = new Size(105, 15);
            label14.TabIndex = 2;
            label14.Text = "Nombre y apellido";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(446, 22);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(138, 23);
            textBox9.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(340, 26);
            label15.Name = "label15";
            label15.Size = new Size(100, 15);
            label15.TabIndex = 5;
            label15.Text = "Cantidad de cajas";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 26);
            label16.Name = "label16";
            label16.Size = new Size(119, 15);
            label16.TabIndex = 2;
            label16.Text = "Tamaño Encomienda";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox6);
            groupBox5.Controls.Add(textBox9);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label16);
            groupBox5.Location = new Point(16, 636);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(590, 54);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Datos Encomienda";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(126, 22);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(175, 23);
            comboBox6.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(446, 714);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Generar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(527, 714);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Seleccionar
            // 
            Seleccionar.Location = new Point(506, 219);
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Size = new Size(75, 23);
            Seleccionar.TabIndex = 19;
            Seleccionar.Text = "Seleccionar";
            Seleccionar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 749);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Imposición telefónica";
           // Load += this.Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private Label label7;
        private ComboBox comboBox5;
        private Label label12;
        private TextBox textBox5;
        private ComboBox comboBox3;
        private TextBox textBox6;
        private Label label11;
        private Label label10;
        private ComboBox comboBox4;
        private Label label9;
        private Label label8;
        private ListView listView1;
        private ColumnHeader Codigo;
        private ColumnHeader Dirección;
        private ColumnHeader Horarios;
        private GroupBox groupBox4;
        private TextBox textBox7;
        private Label label13;
        private TextBox textBox8;
        private Label label14;
        private TextBox textBox9;
        private Label label15;
        private Label label16;
        private GroupBox groupBox5;
        private ComboBox comboBox6;
        private Button button2;
        private Button button3;
        private Button Seleccionar;
    }
}
