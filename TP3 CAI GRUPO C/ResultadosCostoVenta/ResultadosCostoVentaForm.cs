using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP3_CAI_GRUPO_C.ResultadosCostoVenta
{
    public partial class ResultadosCostoVentaForm : Form
    {
        private ResultadosCostoVentaModelo modelo = new ResultadosCostoVentaModelo();

        public ResultadosCostoVentaForm()
        {
            InitializeComponent();
            ConsultarButton.Click += ConsultarButton_Click;
        }

        private void ResultadosCostoVentaFOrm_Load(object sender, EventArgs e)
        {
            var hoy = DateTime.Today;
            var ultimoDiaMesActual = DateTime.DaysInMonth(hoy.Year, hoy.Month);
            PeriodoDateTimePicker.MaxDate = new DateTime(hoy.Year, hoy.Month, ultimoDiaMesActual);

            PeriodoDateTimePicker.Checked = false;
        }

        private void ConsultarButton_Click(object? sender, EventArgs e)
        {
            if (!PeriodoDateTimePicker.Checked)
            {
                MessageBox.Show("Debe seleccionar un período.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultados = modelo.ObtenerResultadosPorPeriodo(PeriodoDateTimePicker.Value);
            CargarResultados(resultados);

            if (resultados.Count == 0)
            {
                MessageBox.Show("No hay resultados para el período seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void CargarResultados(List<Resultado> resultados)
        {
            ResultadoOperativoListView.Items.Clear();

            foreach (var resultado in resultados)
            {
                var item = new ListViewItem(resultado.EmpresaOmnibus);
                item.SubItems.Add($"${resultado.Ventas:N2}");
                item.SubItems.Add($"${resultado.Costos:N2}");
                item.SubItems.Add($"${resultado.Utilidad:N2}");

                ResultadoOperativoListView.Items.Add(item);
            }
        }

        private void LimpiarFormulario()
        {
            ResultadoOperativoListView.Items.Clear();
            PeriodoDateTimePicker.Value = DateTime.Today;
            PeriodoDateTimePicker.Checked = false;
            PeriodoDateTimePicker.Focus();
        }
    }
}
