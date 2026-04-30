namespace TP3_CAI_GRUPO_C
{
    partial class FacturarClienteForm
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            NumeroGuia = new ColumnHeader();
            Subtotal = new ColumnHeader();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 21);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(28, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccionar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 36);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "CUIT/CUIL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 36);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 1;
            label3.Text = "Razón Social:";
            // 
            // button1
            // 
            button1.Location = new Point(439, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(332, 33);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(30, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 207);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Facturar Servicios";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroGuia, Subtotal });
            listView1.Location = new Point(15, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(497, 97);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Número de Guía";
            NumeroGuia.Width = 120;
            // 
            // Subtotal
            // 
            Subtotal.Text = "Subtotal";
            Subtotal.Width = 80;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 145);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 1;
            label4.Text = "Total a facturar:";
            // 
            // button2
            // 
            button2.Location = new Point(413, 178);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 2;
            button2.Text = "Emitir Factura";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(473, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Aceptar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 142);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // FacturarClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FacturarClienteForm";
            Text = "Facturación a Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader NumeroGuia;
        private ColumnHeader Subtotal;
        private Button button2;
        private Label label4;
        private Button button3;
        private TextBox textBox3;
    }
}