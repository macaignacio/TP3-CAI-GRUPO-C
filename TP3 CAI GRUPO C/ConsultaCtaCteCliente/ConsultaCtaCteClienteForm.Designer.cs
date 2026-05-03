namespace TP3_CAI_GRUPO_C
{
    partial class ConsultaCtaCteClienteForm
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
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            Fecha = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            Monto = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 21);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "TUTASA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 127);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Búsqueda de Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(514, 98);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMMyyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(100, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2026, 4, 30, 0, 0, 0, 0);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(380, 27);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(175, 23);
            textBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 30);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 0;
            label5.Text = "Razón Social:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 68);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Período:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 30);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "CUIT/CUIL:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(23, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(595, 165);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen de Cuenta Corriente";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader5, Fecha, columnHeader6, columnHeader2, Monto, columnHeader3, columnHeader4 });
            listView1.GridLines = true;
            listView1.Location = new Point(9, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(573, 103);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Comprobante";
            columnHeader2.Width = 90;
            // 
            // Monto
            // 
            Monto.Text = "Debe";
            Monto.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Haber";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Saldo";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tipo";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Vencimiento";
            columnHeader6.Width = 80;
            // 
            // ConsultaCtaCteClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 408);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ConsultaCtaCteClienteForm";
            Text = "Estado de Cuenta Corriente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader Fecha;
        private ColumnHeader Monto;
        private TextBox textBox2;
        private Label label5;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}