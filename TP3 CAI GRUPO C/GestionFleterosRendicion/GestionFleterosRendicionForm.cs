namespace TP3_CAI_GRUPO_C.GestionFleterosRendicion
{
    public partial class GestionFleterosRendicionForm : Form
    {
        private GestionFleterosRendicionModelo modelo = new GestionFleterosRendicionModelo();

        public GestionFleterosRendicionForm()
        {
            InitializeComponent();
        }

        private void GestionFleterosRendicionForm_Load(object sender, EventArgs e)
        {
            traerNombreFleteroLabel.Text = "";
            HdrAsignadasGroupBox.Enabled = false;
            ConfirmarButton.Enabled = false;
            //CumplidoCheckBox.Visible = false;

            HdrAsignadasListView.CheckBoxes = true;
            HdrAsignadasListView.FullRowSelect = true;
            HdrAsignadasListView.MultiSelect = false;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuitTextBox.Text, out var cuitCuil))
            {
                MessageBox.Show("El CUIT/CUIL debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = modelo.BuscarFletero(cuitCuil);

            if (resultado.fletero == null)
            {
                traerNombreFleteroLabel.Text = "";
                HdrAsignadasListView.Items.Clear();
                HdrAsignadasGroupBox.Enabled = false;
                ConfirmarButton.Enabled = false;
                MessageBox.Show(resultado.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            traerNombreFleteroLabel.Text = resultado.fletero.NombreCompleto;
            HdrAsignadasGroupBox.Enabled = true;
            CargarHojasDeRuta(resultado.fletero.HojasDeRuta);
            ConfirmarButton.Enabled = false;
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            if (HdrAsignadasListView.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe marcar al menos una hoja de ruta cumplida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(CuitTextBox.Text, out var cuitCuil))
            {
                MessageBox.Show("El CUIT/CUIL debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var codigosCumplidos = ObtenerCodigosCumplidos();
            var resultado = modelo.ConfirmarRendicion(cuitCuil, codigosCumplidos);

            if (!resultado.Valido)
            {
                MessageBox.Show(resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Se actualizó el estado de las encomiendas correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private List<string> ObtenerCodigosCumplidos()
        {
            var codigosCumplidos = new List<string>();

            foreach (ListViewItem item in HdrAsignadasListView.CheckedItems)
            {
                codigosCumplidos.Add(item.Text);
            }

            return codigosCumplidos;
        }

        private void HdrAsignadasListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ConfirmarButton.Enabled = HdrAsignadasListView.CheckedItems.Count > 0;
        }

        private void CargarHojasDeRuta(List<HojaDeRuta> hojasDeRuta)
        {
            HdrAsignadasListView.Items.Clear();

            foreach (var hojaDeRuta in hojasDeRuta)
            {
                var item = new ListViewItem(hojaDeRuta.Codigo);
                item.SubItems.Add(hojaDeRuta.NumeroGuia.ToString());
                item.SubItems.Add(hojaDeRuta.EstadoEncomienda);

                HdrAsignadasListView.Items.Add(item);
            }
        }

        private void LimpiarFormulario()
        {
            CuitTextBox.Text = "";
            traerNombreFleteroLabel.Text = "";
            HdrAsignadasListView.Items.Clear();
            HdrAsignadasGroupBox.Enabled = false;
            ConfirmarButton.Enabled = false;
        }
    }
}
