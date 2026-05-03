namespace TP3_CAI_GRUPO_C
{
    partial class EstadoEncomiendaForm
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
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listView1 = new ListView();
            EstadoEncomienda = new ColumnHeader();
            Actualizacion = new ColumnHeader();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 18);
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
            groupBox1.Location = new Point(22, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Búsqueda";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(22, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 146);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado de Búsqueda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 30);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 0;
            label2.Text = "Número de Guía:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(234, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { EstadoEncomienda, Actualizacion });
            listView1.Location = new Point(10, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(285, 97);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // EstadoEncomienda
            // 
            EstadoEncomienda.Text = "Estado de Encomienda";
            EstadoEncomienda.Width = 140;
            // 
            // Actualizacion
            // 
            Actualizacion.Text = "Última Actualización";
            Actualizacion.Width = 140;
            // 
            // button2
            // 
            button2.Location = new Point(262, 352);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            // 
            // EstadoEncomiendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 387);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "EstadoEncomiendaForm";
            Text = "EstadoEncomiendaForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
        private ListView listView1;
        private ColumnHeader EstadoEncomienda;
        private ColumnHeader Actualizacion;
        private Button button2;
    }
}