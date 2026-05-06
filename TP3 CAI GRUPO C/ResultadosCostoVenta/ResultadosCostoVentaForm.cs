using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3_CAI_GRUPO_C.ResultadosCostoVenta
{
    public partial class ResultadosCostoVentaFOrm : Form
    {
        public ResultadosCostoVentaFOrm()
        {
            InitializeComponent();
            PeriodoDateTimePicker.ValueChanged += PeriodoDateTimePicker_ValueChanged;
            ConsultarButton.Click += ConsultarButton_Click;
        }

        private void ResultadosCostoVentaFOrm_Load(object sender, EventArgs e)
        {
            var hoy = DateTime.Today;
            var ultimoDiaMesActual = DateTime.DaysInMonth(hoy.Year, hoy.Month);
            PeriodoDateTimePicker.MaxDate = new DateTime(hoy.Year, hoy.Month, ultimoDiaMesActual);

            periodoSeleccionado = false;
        }

        private bool periodoSeleccionado = false;

        private void ConsultarButton_Click(object? sender, EventArgs e)
        {
            if (!periodoSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un período.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PeriodoDateTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            periodoSeleccionado = true;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
