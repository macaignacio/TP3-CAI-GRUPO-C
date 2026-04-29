namespace TP3_CAI_GRUPO_C
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            listView1 = new ListView();
            NumeroGuia = new ColumnHeader();
            Estado = new ColumnHeader();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(18, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Verificación de Destinatario";
            // 
            // button1
            // 
            button1.Location = new Point(157, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 36);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 0;
            label2.Text = "DNI";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(21, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 203);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de Encomiendas";
            // 
            // button2
            // 
            button2.Location = new Point(262, 174);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 2;
            button2.Text = "Confirmar entrega";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { NumeroGuia, Estado });
            listView1.Location = new Point(11, 54);
            listView1.Name = "listView1";
            listView1.Size = new Size(299, 97);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // NumeroGuia
            // 
            NumeroGuia.Text = "Numero de Guía";
            NumeroGuia.Width = 100;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 27);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 0;
            label3.Text = "Nombre y apellido:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 25);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 3;
            // 
            // EntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 410);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "EntregaForm";
            Text = "EntregaForm";
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
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Button button2;
        private ListView listView1;
        private ColumnHeader NumeroGuia;
        private ColumnHeader Estado;
        private Label label3;
        private TextBox textBox2;
    }
}