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
            ConfirmarCumplidaButton.Enabled = false;
            ConfirmarNoCumplidaButton.Enabled = false;

            HdrAsignadasListView.CheckBoxes = true;
            HdrAsignadasListView.FullRowSelect = true;
            HdrAsignadasListView.MultiSelect = false;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuitTextBox.Text, out var cuitCuil))
            {
                MessageBox.Show("CUIT/CUIL invalido. Se debe ingresar un numero de 11 digitos sin guiones ni comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = modelo.BuscarFletero(cuitCuil);

            if (resultado.fletero == null)
            {
                traerNombreFleteroLabel.Text = "";
                HdrAsignadasListView.Items.Clear();
                HdrAsignadasGroupBox.Enabled = false;
                ConfirmarCumplidaButton.Enabled = false;
                ConfirmarNoCumplidaButton.Enabled = false;
                MessageBox.Show(resultado.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            traerNombreFleteroLabel.Text = resultado.fletero.NombreCompleto;
            HdrAsignadasGroupBox.Enabled = true;
            CargarHojasDeRuta(resultado.fletero.HojasDeRuta);
            ConfirmarCumplidaButton.Enabled = false;
            ConfirmarNoCumplidaButton.Enabled = false;
        }

        private void ConfirmarCumplidaButton_Click(object sender, EventArgs e)
        {
            ConfirmarRendicion(cumplida: true);
        }

        private void ConfirmarNoCumplidaButton_Click(object sender, EventArgs e)
        {
            ConfirmarRendicion(cumplida: false);
        }

        private void ConfirmarRendicion(bool cumplida)
        {
            if (HdrAsignadasListView.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe marcar al menos una hoja de ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(CuitTextBox.Text, out var cuitCuil))
            {
                MessageBox.Show("CUIT/CUIL invalido. Se debe ingresar un numero de 11 digitos sin guiones ni comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var codigosSeleccionados = ObtenerCodigosSeleccionados();
            var resultado = cumplida
                ? modelo.ConfirmarRendicionCumplida(cuitCuil, codigosSeleccionados)
                : modelo.ConfirmarRendicionNoCumplida(cuitCuil, codigosSeleccionados);

            if (!resultado.Valido)
            {
                MessageBox.Show(resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Se actualizo el estado de las encomiendas correctamente.",
                "Exito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private List<string> ObtenerCodigosSeleccionados()
        {
            var codigos = new List<string>();

            foreach (ListViewItem item in HdrAsignadasListView.CheckedItems)
            {
                codigos.Add(item.Text);
            }

            return codigos;
        }

        private void HdrAsignadasListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var hayChequeados = HdrAsignadasListView.CheckedItems.Count > 0;
            ConfirmarCumplidaButton.Enabled = hayChequeados;
            ConfirmarNoCumplidaButton.Enabled = hayChequeados;
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
            ConfirmarCumplidaButton.Enabled = false;
            ConfirmarNoCumplidaButton.Enabled = false;
        }
    }
}
