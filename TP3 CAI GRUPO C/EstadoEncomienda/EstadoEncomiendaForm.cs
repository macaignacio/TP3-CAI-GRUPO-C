using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3_CAI_GRUPO_C.EstadoEncomienda
{
    public partial class EstadoEncomiendaForm : Form
    {
        private EstadoEncomiendaModelo modelo = new EstadoEncomiendaModelo();

        public EstadoEncomiendaForm()
        {
            InitializeComponent();
            BuscarButton.Click += BuscarButton_Click;
        }

        private void EstadoEncomiendaForm_Load(object sender, EventArgs e)
        {
            ResultadoBusquedaListView.FullRowSelect = true;
        }

        private void BuscarButton_Click(object? sender, EventArgs e)
        {
            string textoGuia = NumeroGuiaTextBox.Text.Trim();

            // Validación de vacío
            if (string.IsNullOrWhiteSpace(textoGuia))
            {
                MessageBox.Show("Debe ingresar una guia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de 17 dígitos
            if (!long.TryParse(textoGuia, out var numeroGuia) || textoGuia.Length != 17)
            {
                MessageBox.Show("Guia invalida. Debe ingresar un numero de 17 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = modelo.ValidarYBuscarGuia(numeroGuia);

            if (resultado.guia == null)
            {
                ResultadoBusquedaListView.Items.Clear();
                MessageBox.Show("Guia no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarMovimientos(resultado.guia.Historial);
        }

        private void CargarMovimientos(List<Movimiento> historial)
        {
            ResultadoBusquedaListView.Items.Clear();

            foreach (var mov in historial)
            {
                ListViewItem fila = new ListViewItem(mov.Estado);
                fila.SubItems.Add(mov.UltimaActualizacion);
                fila.SubItems.Add(mov.Ubicacion);

                ResultadoBusquedaListView.Items.Add(fila);
            }
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            NumeroGuiaTextBox.Clear();
            ResultadoBusquedaListView.Items.Clear();
            NumeroGuiaTextBox.Focus();
        }
    }
}

