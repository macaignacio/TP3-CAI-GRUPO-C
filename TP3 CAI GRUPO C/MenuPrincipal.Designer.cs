namespace TP3_CAI_GRUPO_C
{
    partial class MenuPrincipal
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
            ContextoGroupBox = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            AgenciaActualLabel = new Label();
            CDActualLabel = new Label();
            FechaSistemaGroupBox = new GroupBox();
            FechaSistemaOverrideCheckBox = new CheckBox();
            FechaSistemaDateTimePicker = new DateTimePicker();
            FechaSistemaActualLabel = new Label();
            FechaSistemaResetButton = new Button();
            MenuGroupBox = new GroupBox();
            GestionDevolucionesButton = new Button();
            ResultadosButton = new Button();
            CtaCteClienteButton = new Button();
            FacturarButton = new Button();
            ConsultaEncomiendaButton = new Button();
            EntregaButton = new Button();
            RecepEncomiendasButton = new Button();
            DespachoEncomiendasButton = new Button();
            AdmisionButton = new Button();
            GestionRendFleterosButton = new Button();
            GestionAsigFleterosButton = new Button();
            ImpoXCDButton = new Button();
            ImpoXAgenciaButton = new Button();
            ImpoXTelButton = new Button();
            MenuPpalLabel = new Label();
            ContextoGroupBox.SuspendLayout();
            FechaSistemaGroupBox.SuspendLayout();
            MenuGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ContextoGroupBox
            // 
            ContextoGroupBox.Controls.Add(comboBox2);
            ContextoGroupBox.Controls.Add(comboBox1);
            ContextoGroupBox.Controls.Add(AgenciaActualLabel);
            ContextoGroupBox.Controls.Add(CDActualLabel);
            ContextoGroupBox.Location = new Point(20, 20);
            ContextoGroupBox.Name = "ContextoGroupBox";
            ContextoGroupBox.Size = new Size(441, 95);
            ContextoGroupBox.TabIndex = 0;
            ContextoGroupBox.TabStop = false;
            ContextoGroupBox.Text = "Contexto actual";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(198, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(208, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(198, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 23);
            comboBox1.TabIndex = 1;
            // 
            // AgenciaActualLabel
            // 
            AgenciaActualLabel.AutoSize = true;
            AgenciaActualLabel.Location = new Point(20, 54);
            AgenciaActualLabel.Name = "AgenciaActualLabel";
            AgenciaActualLabel.Size = new Size(157, 15);
            AgenciaActualLabel.TabIndex = 2;
            AgenciaActualLabel.Text = "Seleccione la agencia actual:";
            // 
            // CDActualLabel
            // 
            CDActualLabel.AutoSize = true;
            CDActualLabel.Location = new Point(20, 25);
            CDActualLabel.Name = "CDActualLabel";
            CDActualLabel.Size = new Size(132, 15);
            CDActualLabel.TabIndex = 0;
            CDActualLabel.Text = "Seleccione el CD actual:";
            //
            // FechaSistemaGroupBox
            //
            FechaSistemaGroupBox.Controls.Add(FechaSistemaOverrideCheckBox);
            FechaSistemaGroupBox.Controls.Add(FechaSistemaDateTimePicker);
            FechaSistemaGroupBox.Controls.Add(FechaSistemaActualLabel);
            FechaSistemaGroupBox.Controls.Add(FechaSistemaResetButton);
            FechaSistemaGroupBox.Location = new Point(475, 20);
            FechaSistemaGroupBox.Name = "FechaSistemaGroupBox";
            FechaSistemaGroupBox.Size = new Size(205, 95);
            FechaSistemaGroupBox.TabIndex = 2;
            FechaSistemaGroupBox.TabStop = false;
            FechaSistemaGroupBox.Text = "Fecha Sistema (override)";
            //
            // FechaSistemaOverrideCheckBox
            //
            FechaSistemaOverrideCheckBox.AutoSize = true;
            FechaSistemaOverrideCheckBox.Location = new Point(10, 22);
            FechaSistemaOverrideCheckBox.Name = "FechaSistemaOverrideCheckBox";
            FechaSistemaOverrideCheckBox.Size = new Size(120, 19);
            FechaSistemaOverrideCheckBox.TabIndex = 0;
            FechaSistemaOverrideCheckBox.Text = "Usar fecha custom";
            FechaSistemaOverrideCheckBox.UseVisualStyleBackColor = true;
            //
            // FechaSistemaDateTimePicker
            //
            FechaSistemaDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            FechaSistemaDateTimePicker.Format = DateTimePickerFormat.Custom;
            FechaSistemaDateTimePicker.Location = new Point(10, 45);
            FechaSistemaDateTimePicker.Name = "FechaSistemaDateTimePicker";
            FechaSistemaDateTimePicker.Size = new Size(135, 23);
            FechaSistemaDateTimePicker.TabIndex = 1;
            //
            // FechaSistemaResetButton
            //
            FechaSistemaResetButton.Location = new Point(150, 44);
            FechaSistemaResetButton.Name = "FechaSistemaResetButton";
            FechaSistemaResetButton.Size = new Size(45, 25);
            FechaSistemaResetButton.TabIndex = 2;
            FechaSistemaResetButton.Text = "Hoy";
            FechaSistemaResetButton.UseVisualStyleBackColor = true;
            //
            // FechaSistemaActualLabel
            //
            FechaSistemaActualLabel.AutoSize = true;
            FechaSistemaActualLabel.Location = new Point(10, 73);
            FechaSistemaActualLabel.Name = "FechaSistemaActualLabel";
            FechaSistemaActualLabel.Size = new Size(140, 15);
            FechaSistemaActualLabel.TabIndex = 3;
            FechaSistemaActualLabel.Text = "Hoy: --";
            //
            // MenuGroupBox
            // 
            MenuGroupBox.Controls.Add(GestionDevolucionesButton);
            MenuGroupBox.Controls.Add(ResultadosButton);
            MenuGroupBox.Controls.Add(CtaCteClienteButton);
            MenuGroupBox.Controls.Add(FacturarButton);
            MenuGroupBox.Controls.Add(ConsultaEncomiendaButton);
            MenuGroupBox.Controls.Add(EntregaButton);
            MenuGroupBox.Controls.Add(RecepEncomiendasButton);
            MenuGroupBox.Controls.Add(DespachoEncomiendasButton);
            MenuGroupBox.Controls.Add(AdmisionButton);
            MenuGroupBox.Controls.Add(GestionRendFleterosButton);
            MenuGroupBox.Controls.Add(GestionAsigFleterosButton);
            MenuGroupBox.Controls.Add(ImpoXCDButton);
            MenuGroupBox.Controls.Add(ImpoXAgenciaButton);
            MenuGroupBox.Controls.Add(ImpoXTelButton);
            MenuGroupBox.Controls.Add(MenuPpalLabel);
            MenuGroupBox.Location = new Point(20, 130);
            MenuGroupBox.Name = "MenuGroupBox";
            MenuGroupBox.Size = new Size(660, 310);
            MenuGroupBox.TabIndex = 1;
            MenuGroupBox.TabStop = false;
            MenuGroupBox.Text = "Menú principal";
            // 
            // GestionDevolucionesButton
            // 
            GestionDevolucionesButton.Location = new Point(440, 250);
            GestionDevolucionesButton.Name = "GestionDevolucionesButton";
            GestionDevolucionesButton.Size = new Size(180, 35);
            GestionDevolucionesButton.TabIndex = 14;
            GestionDevolucionesButton.Text = "Gestión Devoluciones";
            GestionDevolucionesButton.UseVisualStyleBackColor = true;
            // 
            // ResultadosButton
            // 
            ResultadosButton.Location = new Point(240, 250);
            ResultadosButton.Name = "ResultadosButton";
            ResultadosButton.Size = new Size(180, 35);
            ResultadosButton.TabIndex = 13;
            ResultadosButton.Text = "Resultados Costos Ventas";
            ResultadosButton.UseVisualStyleBackColor = true;
            // 
            // CtaCteClienteButton
            // 
            CtaCteClienteButton.Location = new Point(440, 200);
            CtaCteClienteButton.Name = "CtaCteClienteButton";
            CtaCteClienteButton.Size = new Size(180, 35);
            CtaCteClienteButton.TabIndex = 12;
            CtaCteClienteButton.Text = "Consulta Cta Cte";
            CtaCteClienteButton.UseVisualStyleBackColor = true;
            // 
            // FacturarButton
            // 
            FacturarButton.Location = new Point(240, 200);
            FacturarButton.Name = "FacturarButton";
            FacturarButton.Size = new Size(180, 35);
            FacturarButton.TabIndex = 11;
            FacturarButton.Text = "Facturar";
            FacturarButton.UseVisualStyleBackColor = true;
            // 
            // ConsultaEncomiendaButton
            // 
            ConsultaEncomiendaButton.Location = new Point(40, 200);
            ConsultaEncomiendaButton.Name = "ConsultaEncomiendaButton";
            ConsultaEncomiendaButton.Size = new Size(180, 35);
            ConsultaEncomiendaButton.TabIndex = 10;
            ConsultaEncomiendaButton.Text = "Consulta estado encomienda";
            ConsultaEncomiendaButton.UseVisualStyleBackColor = true;
            // 
            // EntregaButton
            // 
            EntregaButton.Location = new Point(440, 150);
            EntregaButton.Name = "EntregaButton";
            EntregaButton.Size = new Size(180, 35);
            EntregaButton.TabIndex = 9;
            EntregaButton.Text = "Entrega";
            EntregaButton.UseVisualStyleBackColor = true;
            // 
            // RecepEncomiendasButton
            // 
            RecepEncomiendasButton.Location = new Point(240, 150);
            RecepEncomiendasButton.Name = "RecepEncomiendasButton";
            RecepEncomiendasButton.Size = new Size(180, 35);
            RecepEncomiendasButton.TabIndex = 8;
            RecepEncomiendasButton.Text = "Recepción Encomiendas";
            RecepEncomiendasButton.UseVisualStyleBackColor = true;
            // 
            // DespachoEncomiendasButton
            // 
            DespachoEncomiendasButton.Location = new Point(40, 150);
            DespachoEncomiendasButton.Name = "DespachoEncomiendasButton";
            DespachoEncomiendasButton.Size = new Size(180, 35);
            DespachoEncomiendasButton.TabIndex = 7;
            DespachoEncomiendasButton.Text = "Despacho Encomiendas";
            DespachoEncomiendasButton.UseVisualStyleBackColor = true;
            // 
            // AdmisionButton
            // 
            AdmisionButton.Location = new Point(440, 100);
            AdmisionButton.Name = "AdmisionButton";
            AdmisionButton.Size = new Size(180, 35);
            AdmisionButton.TabIndex = 6;
            AdmisionButton.Text = "Admisión";
            AdmisionButton.UseVisualStyleBackColor = true;
            // 
            // GestionRendFleterosButton
            // 
            GestionRendFleterosButton.Location = new Point(240, 100);
            GestionRendFleterosButton.Name = "GestionRendFleterosButton";
            GestionRendFleterosButton.Size = new Size(180, 35);
            GestionRendFleterosButton.TabIndex = 5;
            GestionRendFleterosButton.Text = "Gestión Rendición Fleteros";
            GestionRendFleterosButton.UseVisualStyleBackColor = true;
            // 
            // GestionAsigFleterosButton
            // 
            GestionAsigFleterosButton.Location = new Point(40, 100);
            GestionAsigFleterosButton.Name = "GestionAsigFleterosButton";
            GestionAsigFleterosButton.Size = new Size(180, 35);
            GestionAsigFleterosButton.TabIndex = 4;
            GestionAsigFleterosButton.Text = "Gestión Asignación Fleteros";
            GestionAsigFleterosButton.UseVisualStyleBackColor = true;
            // 
            // ImpoXCDButton
            // 
            ImpoXCDButton.Location = new Point(440, 50);
            ImpoXCDButton.Name = "ImpoXCDButton";
            ImpoXCDButton.Size = new Size(180, 35);
            ImpoXCDButton.TabIndex = 3;
            ImpoXCDButton.Text = "Imposición por CD";
            ImpoXCDButton.UseVisualStyleBackColor = true;
            // 
            // ImpoXAgenciaButton
            // 
            ImpoXAgenciaButton.Location = new Point(240, 50);
            ImpoXAgenciaButton.Name = "ImpoXAgenciaButton";
            ImpoXAgenciaButton.Size = new Size(180, 35);
            ImpoXAgenciaButton.TabIndex = 2;
            ImpoXAgenciaButton.Text = "Imposición por agencia";
            ImpoXAgenciaButton.UseVisualStyleBackColor = true;
            // 
            // ImpoXTelButton
            // 
            ImpoXTelButton.Location = new Point(40, 50);
            ImpoXTelButton.Name = "ImpoXTelButton";
            ImpoXTelButton.Size = new Size(180, 35);
            ImpoXTelButton.TabIndex = 1;
            ImpoXTelButton.Text = "Imposición telefónica";
            ImpoXTelButton.UseVisualStyleBackColor = true;
            // 
            // MenuPpalLabel
            // 
            MenuPpalLabel.AutoSize = true;
            MenuPpalLabel.Location = new Point(20, 25);
            MenuPpalLabel.Name = "MenuPpalLabel";
            MenuPpalLabel.Size = new Size(214, 15);
            MenuPpalLabel.TabIndex = 0;
            MenuPpalLabel.Text = "Seleccione la pantalla a la cual dirigirse:";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 460);
            Controls.Add(MenuGroupBox);
            Controls.Add(FechaSistemaGroupBox);
            Controls.Add(ContextoGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            Load += MenuPrincipal_Load;
            ContextoGroupBox.ResumeLayout(false);
            ContextoGroupBox.PerformLayout();
            FechaSistemaGroupBox.ResumeLayout(false);
            FechaSistemaGroupBox.PerformLayout();
            MenuGroupBox.ResumeLayout(false);
            MenuGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ContextoGroupBox;
        private Label CDActualLabel;
        private Label AgenciaActualLabel;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox MenuGroupBox;
        private Label MenuPpalLabel;
        private Button ImpoXTelButton;
        private Button ImpoXAgenciaButton;
        private Button ImpoXCDButton;
        private Button GestionAsigFleterosButton;
        private Button GestionRendFleterosButton;
        private Button AdmisionButton;
        private Button DespachoEncomiendasButton;
        private Button RecepEncomiendasButton;
        private Button EntregaButton;
        private Button ConsultaEncomiendaButton;
        private Button FacturarButton;
        private Button CtaCteClienteButton;
        private Button ResultadosButton;
        private Button GestionDevolucionesButton;
        private GroupBox FechaSistemaGroupBox;
        private CheckBox FechaSistemaOverrideCheckBox;
        private DateTimePicker FechaSistemaDateTimePicker;
        private Button FechaSistemaResetButton;
        private Label FechaSistemaActualLabel;
    }
}
