using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3_CAI_GRUPO_C.Devolucion
{
    public partial class GestionDevolucionForm : Form
    {
        private GestionDevolucionModelo modelo = new GestionDevolucionModelo();

        public GestionDevolucionForm()
        {
            InitializeComponent();
        }

        private void GestionDevolucionForm_Load(object sender, EventArgs e)
        {
            ConfirmarDevGroupBox.Enabled = false;
            IniciarDevGroupBox.Enabled = false;
            RazonSocialClienteLabel.Text = "";

            DatosEncomiendaListView.FullRowSelect = true;
            DatosEncomiendaListView.MultiSelect = false;
            DatosEncomiendaParaDevListView.FullRowSelect = true;
            DatosEncomiendaParaDevListView.MultiSelect = false;
        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {
            if (!ConfirmarDevRadioButton.Checked && !IniciarDevRadioButton.Checked)
            {
                MessageBox.Show("Debe seleccionar una operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ConfirmarDevRadioButton.Checked)
            {
                ConfirmarDevGroupBox.Enabled = true;
                IniciarDevGroupBox.Enabled = false;
                LimpiarConfirmarDev();
                DatosEncomiendaParaDevListView.Items.Clear();
            }
            else
            {
                IniciarDevGroupBox.Enabled = true;
                ConfirmarDevGroupBox.Enabled = false;
                LimpiarConfirmarDev();
                CargarGuiasParaIniciar();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CuitTextBox.Text))
            {
                MessageBox.Show("Debe ingresar un CUIT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(CuitTextBox.Text, out var cuit))
            {
                MessageBox.Show("CUIT inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = modelo.BuscarParaConfirmar(cuit);

            if (!resultado.Valido)
            {
                MessageBox.Show(resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RazonSocialClienteLabel.Text = "";
                DatosEncomiendaListView.Items.Clear();
                return;
            }

            RazonSocialClienteLabel.Text = resultado.Cliente!.RazonSocial;
            CargarGuiasConfirmar(resultado.Guias);
        }

        private void ConfirmarDevolucionButton_Click(object sender, EventArgs e)
        {
            if (DatosEncomiendaListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una guía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var numeroGuia = DatosEncomiendaListView.SelectedItems[0].Text;
            var resultado = modelo.ConfirmarDevolucion(numeroGuia);

            if (!resultado.valido)
            {
                MessageBox.Show(resultado.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("La devolución se confirmó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (long.TryParse(CuitTextBox.Text, out var cuit))
            {
                var nuevaBusqueda = modelo.BuscarParaConfirmar(cuit);
                if (nuevaBusqueda.Valido)
                    CargarGuiasConfirmar(nuevaBusqueda.Guias);
            }
        }

        private void IniciarDevButton_Click(object sender, EventArgs e)
        {
            if (DatosEncomiendaParaDevListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una guía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var numeroGuia = DatosEncomiendaParaDevListView.SelectedItems[0].Text;
            var resultado = modelo.IniciarDevolucion(numeroGuia);

            if (!resultado.valido)
            {
                MessageBox.Show(resultado.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("La devolución se inició correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarGuiasParaIniciar();
        }

        private void CargarGuiasConfirmar(List<GuiaDevolucionConfirmar> guias)
        {
            DatosEncomiendaListView.Items.Clear();
            foreach (var guia in guias)
            {
                var item = new ListViewItem(guia.NumeroGuia);
                item.SubItems.Add(guia.Estado);
                item.SubItems.Add(guia.LugarDevolucion);
                item.SubItems.Add(guia.FechaLlegada.ToString("dd/MM/yyyy HH:mm"));
                DatosEncomiendaListView.Items.Add(item);
            }
        }

        private void CargarGuiasParaIniciar()
        {
            DatosEncomiendaParaDevListView.Items.Clear();
            var guias = modelo.ObtenerGuiasParaIniciar();
            foreach (var guia in guias)
            {
                var item = new ListViewItem(guia.NumeroGuia);
                item.SubItems.Add(guia.RazonSocialCliente);
                item.SubItems.Add(guia.Estado);
                item.SubItems.Add(guia.UbicacionActual);
                item.SubItems.Add(guia.FechaArribo.ToString("dd/MM/yyyy"));
                item.SubItems.Add(guia.DiasEnEspera.ToString());
                item.SubItems.Add(guia.DestinoDevolucion);
                DatosEncomiendaParaDevListView.Items.Add(item);
            }
        }

        private void LimpiarConfirmarDev()
        {
            CuitTextBox.Text = "";
            RazonSocialClienteLabel.Text = "";
            DatosEncomiendaListView.Items.Clear();
        }
    }
}
