using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace TP3_CAI_GRUPO_C.RecepcionEncomiendasCD
{
    public partial class RecepcionEncomiendasCDForm : Form
    {
        private RecepcionEncomiendasCDModelo modelo = new RecepcionEncomiendasCDModelo();

        public RecepcionEncomiendasCDForm()
        {
            InitializeComponent();
        }

        private void RecepcionEncomiendasCDForm_Load(object sender, EventArgs e)
        {
            NroCDLabel.Text = modelo.CodigoCDActual.ToString();

            foreach (var empresa in modelo.Empresas)
            {
                EmpresaComboBox.Items.Add(empresa.nombre);
            }

            EmpresaComboBox.SelectedIndex = -1;
            HorarioSalidaDateTimePicker.Value = DateTime.Now;

            DetalleHdrGroupBox.Enabled = false;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var empresa = EmpresaComboBox.SelectedItem?.ToString() ?? "";
            var fechaSalida = HorarioSalidaDateTimePicker.Value;

            var resultado = modelo.ValidarBusqueda(empresa, fechaSalida);

            if (!resultado.valido)
            {
                MessageBox.Show(resultado.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetalleHdrListView.Items.Clear();

            var hojas = modelo.BuscarHojasDeRuta(empresa, fechaSalida);

            if (hojas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron Hojas de Ruta para la empresa y fecha/hora seleccionadas.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DetalleHdrGroupBox.Enabled = false;
                return;
            }

            foreach (var h in hojas)
            {
                var item = new ListViewItem(h.NroOrden);
                item.SubItems.Add(h.Codigo);
                item.SubItems.Add(h.Estado);
                item.SubItems.Add(h.EmpresaOmnibus);
                item.Tag = h;
                DetalleHdrListView.Items.Add(item);
            }

            DetalleHdrGroupBox.Enabled = true;
        }

        private void ConfirmarRecepcionButton_Click(object sender, EventArgs e)
        {
            var hojas = ObtenerTodasLasHojas();

            var resultadoValidacion = modelo.ValidarConfirmacion(hojas);

            if (!resultadoValidacion.valido)
            {
                MessageBox.Show(resultadoValidacion.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultadoActualizacion = modelo.ActualizarEstadoHojasDeRuta(hojas);

            if (!resultadoActualizacion.valido)
            {
                MessageBox.Show(resultadoActualizacion.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ListViewItem item in DetalleHdrListView.Items)
            {
                item.SubItems[2].Text = (item.Tag as HojaDeRuta)!.Estado;
            }

            MessageBox.Show(
                "Recepción confirmada con éxito.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private List<HojaDeRuta> ObtenerTodasLasHojas()
        {
            var hojas = new List<HojaDeRuta>();

            foreach (ListViewItem item in DetalleHdrListView.Items)
            {
                if (item.Tag is HojaDeRuta hoja)
                    hojas.Add(hoja);
            }

            return hojas;
        }

        private void LimpiarFormulario()
        {
            EmpresaComboBox.SelectedIndex = -1;
            HorarioSalidaDateTimePicker.Value = DateTime.Now;
            DetalleHdrListView.Items.Clear();
            DetalleHdrGroupBox.Enabled = false;
        }
    }
}
