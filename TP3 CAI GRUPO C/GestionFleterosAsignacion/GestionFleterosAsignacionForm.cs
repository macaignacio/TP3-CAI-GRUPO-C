namespace TP3_CAI_GRUPO_C.GestionFleterosAsignacion
{
    public partial class GestionFleterosAsignacionForm : Form
    {
        private GestionFleterosAsignacionModelo modelo = new GestionFleterosAsignacionModelo();

        public GestionFleterosAsignacionForm()
        {
            InitializeComponent();
        }

        private void GestionFleterosAsignacionForm_Load(object sender, EventArgs e)
        {
            NombreLabel.Text = "";
            DetalleHDRPendientesGroupBox.Enabled = false;
            ConfirmarAsignacionButton.Enabled = false;

            DetalleHDRPendientesListView.FullRowSelect = false;
            DetalleHDRPendientesListView.MultiSelect = false;
            DetalleHDRPendientesListView.HideSelection = true;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuilTextBox.Text, out var cuitCuil))
            {
                MessageBox.Show("El CUIT/CUIL debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = modelo.BuscarFletero(cuitCuil);

            if (resultado.fletero == null)
            {
                NombreLabel.Text = "";
                DetalleHDRPendientesListView.Items.Clear();
                DetalleHDRPendientesGroupBox.Enabled = false;
                ConfirmarAsignacionButton.Enabled = false;
                MessageBox.Show(resultado.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NombreLabel.Text = resultado.fletero.NombreCompleto;
            DetalleHDRPendientesGroupBox.Enabled = true;
            ConfirmarAsignacionButton.Enabled = true;
            CargarHojasDeRuta(resultado.fletero.HojasDeRuta);
        }

        private void ConfirmarAsignacionButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuilTextBox.Text, out var cuitCuil))
            {
                MessageBox.Show("El CUIT/CUIL debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = modelo.ConfirmarAsignacion(cuitCuil);

            if (!resultado.Valido)
            {
                MessageBox.Show(resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarHojasDeRuta(resultado.HojasActualizadas);
            MessageBox.Show("Se actualizó el estado de las encomiendas correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarHojasDeRuta(List<HojaDeRuta> hojasDeRuta)
        {
            DetalleHDRPendientesListView.Items.Clear();

            foreach (var hojaDeRuta in hojasDeRuta)
            {
                var item = new ListViewItem(hojaDeRuta.Codigo);
                item.SubItems.Add(hojaDeRuta.NumeroGuia.ToString());
                item.SubItems.Add(hojaDeRuta.EstadoEncomienda);

                DetalleHDRPendientesListView.Items.Add(item);
            }
        }
    }
}
