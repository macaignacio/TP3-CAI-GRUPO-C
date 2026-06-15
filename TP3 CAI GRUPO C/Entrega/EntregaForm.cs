using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP3_CAI_GRUPO_C.Entrega
{
    public partial class EntregaForm : Form
    {
        private EntregaModelo modelo = new EntregaModelo();

        public EntregaForm()
        {
            InitializeComponent();
            BuscarButton.Click += BuscarButton_Click;
            ConfirmarButton.Click += ConfirmarButton_Click;
            NuevaConsultabtn.Click += NuevaConsultabtn_Click;
            DatosEncomiendaListView.SelectedIndexChanged += DatosEncomiendaListView_SelectedIndexChanged;
        }

        private void EntregaForm_Load(object? sender, EventArgs e)
        {
            traerNombreDestinatarioLabel.Text = "";
            DatosEncomiendaListView.FullRowSelect = true;
            DatosEncomiendaListView.MultiSelect = false;
            Estado.Width = 240;
            ConfirmarButton.Enabled = false;
            NuevaConsultabtn.Enabled = false;
        }

        private void BuscarButton_Click(object? sender, EventArgs e)
        {
            var resultadoIngresoDni = modelo.ValidarIngresoDNI(DniTextBox.Text);
            if (!resultadoIngresoDni.valido)
            {
                MessageBox.Show(resultadoIngresoDni.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(DniTextBox.Text, out var dni))
            {
                MessageBox.Show("El DNI debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = modelo.BuscarDestinatario(dni);

            if (resultado.destinatario == null)
            {
                traerNombreDestinatarioLabel.Text = "";
                DatosEncomiendaListView.Items.Clear();
                ConfirmarButton.Enabled = false;
                NuevaConsultabtn.Enabled = false;
                MessageBox.Show(resultado.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            traerNombreDestinatarioLabel.Text = resultado.destinatario.NombreApellido;
            CargarEncomiendas(modelo.ObtenerEncomiendasPorDni(dni));
            ConfirmarButton.Enabled = false;
            NuevaConsultabtn.Enabled = true;
        }

        private void DatosEncomiendaListView_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ConfirmarButton.Enabled = DatosEncomiendaListView.SelectedItems.Count > 0;
        }

        private void ConfirmarButton_Click(object? sender, EventArgs e)
        {
            if (DatosEncomiendaListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe indicar una encomienda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(DniTextBox.Text, out var dni))
            {
                MessageBox.Show("El DNI debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var numeroGuia = DatosEncomiendaListView.SelectedItems[0].Text;

            var confirmacion = MessageBox.Show(
                $"Confirma la entrega de la guia {numeroGuia}?",
                "Confirmar entrega",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes)
                return;

            var resultado = modelo.ConfirmarEntrega(dni, numeroGuia);

            if (!resultado.valido)
            {
                MessageBox.Show(resultado.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarEncomiendas(modelo.ObtenerEncomiendasPorDni(dni));
            ConfirmarButton.Enabled = false;
            MessageBox.Show("Entrega confirmada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NuevaConsultabtn_Click(object? sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void CargarEncomiendas(List<Encomienda> encomiendas)
        {
            DatosEncomiendaListView.Items.Clear();

            foreach (var encomienda in encomiendas)
            {
                var item = new ListViewItem(encomienda.NumeroGuia.ToString());
                item.SubItems.Add(modelo.ObtenerNombreEstado(encomienda.Estado));
                DatosEncomiendaListView.Items.Add(item);
            }
        }

        private void LimpiarControles()
        {
            DniTextBox.Text = "";
            traerNombreDestinatarioLabel.Text = "";
            DatosEncomiendaListView.Items.Clear();
            ConfirmarButton.Enabled = false;
            NuevaConsultabtn.Enabled = false;
        }
    }
}
