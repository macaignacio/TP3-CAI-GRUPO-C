namespace TP3_CAI_GRUPO_C
{
    partial class ResultadosCostoVentaFOrm
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
            label3 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            listView1 = new ListView();
            EmpresaOmnibus = new ColumnHeader();
            Ventas = new ColumnHeader();
            Costos = new ColumnHeader();
            Utilidad = new ColumnHeader();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 20);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Período de Consulta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(13, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 144);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado Operativo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 32);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 33);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 1;
            label3.Text = "Hasta:";
            // 
            // button1
            // 
            button1.Location = new Point(274, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(61, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(102, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(247, 27);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(102, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { EmpresaOmnibus, Ventas, Costos, Utilidad });
            listView1.Location = new Point(11, 25);
            listView1.Name = "listView1";
            listView1.Size = new Size(357, 97);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // EmpresaOmnibus
            // 
            EmpresaOmnibus.Text = "Empresa de Ómnibus";
            EmpresaOmnibus.Width = 140;
            // 
            // Ventas
            // 
            Ventas.Text = "Ventas";
            // 
            // Costos
            // 
            Costos.Text = "Costos";
            // 
            // Utilidad
            // 
            Utilidad.Text = "Utilidad";
            Utilidad.Width = 80;
            // 
            // button2
            // 
            button2.Location = new Point(330, 345);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ResultadosCostoVentaFOrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 380);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ResultadosCostoVentaFOrm";
            Text = "Resultados Ingresos y Egresos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label3;
        private Label label2;
        private ListView listView1;
        private ColumnHeader EmpresaOmnibus;
        private ColumnHeader Ventas;
        private ColumnHeader Costos;
        private ColumnHeader Utilidad;
        private Button button2;
    }
}