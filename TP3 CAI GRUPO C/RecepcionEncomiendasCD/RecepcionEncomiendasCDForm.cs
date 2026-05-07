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
                EmpresaComboBox.Items.Add(empresa.Nombre);
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
            var hojaSeleccionada = ObtenerHojaDeRutaSeleccionada();

            var resultadoValidacion = modelo.ValidarConfirmacion(hojaSeleccionada);

            if (!resultadoValidacion.valido)
            {
                MessageBox.Show(resultadoValidacion.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultadoActualizacion = modelo.ActualizarEstadoHojaDeRuta(hojaSeleccionada!);

            if (!resultadoActualizacion.valido)
            {
                MessageBox.Show(resultadoActualizacion.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Reflejar el cambio de estado en el ListView
            var itemSeleccionado = DetalleHdrListView.SelectedItems[0];
            itemSeleccionado.SubItems[2].Text = hojaSeleccionada!.Estado;

            MessageBox.Show(
                "Recepción confirmada con éxito.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private HojaDeRuta? ObtenerHojaDeRutaSeleccionada()
        {
            if (DetalleHdrListView.SelectedItems.Count == 0)
                return null;

            return DetalleHdrListView.SelectedItems[0].Tag as HojaDeRuta;
        }
    }
}