namespace TP3_CAI_GRUPO_C.ConsultaCtaCteCliente

{
    public partial class ConsultaCtaCteClienteForm : Form
    {
        public ConsultaCtaCteClienteForm()
        {
            InitializeComponent();
            LimpiarButton.Click += LimpiarButton_Click;
        }

        private void ConsultaCtaCteClienteForm_Load(object sender, EventArgs e)
        {
            var hoy = DateTime.Today;
            var ultimoDiaMesActual = DateTime.DaysInMonth(hoy.Year, hoy.Month);
            PeriodoDateTimePicker.MaxDate = new DateTime(hoy.Year, hoy.Month, ultimoDiaMesActual);

            periodoSeleccionado = false;
        }

        private bool periodoSeleccionado = false;

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuitTextBox.Text, out var cuit))
            {
                MessageBox.Show("CUIT inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");
                return;

            }

            if (!periodoSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un período.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime periodo = PeriodoDateTimePicker.Value;


            ConsultaCtaCteClienteModelo modelo = new ConsultaCtaCteClienteModelo();
            var resultado = modelo.ValidarCliente(cuit);

            if (resultado.cliente != null)
            {
                RazonSocialLabel.Text = resultado.cliente.RazonSocial;

                var movimientos = modelo.ObtenerCuentaCorrientePorCliente(
                    resultado.cliente.RazonSocial,
                    periodo);

                CargarCuentaCorriente(movimientos);

                if (movimientos.Count == 0)
                {
                    MessageBox.Show("No hay movimientos para el período seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                CuentaCorrienteListView.Items.Clear();
                MessageBox.Show(resultado.error);
            }

        }

        private void PeriodoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            periodoSeleccionado = true;
        }

        private void LimpiarButton_Click(object? sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            CuitTextBox.Text = "";
            RazonSocialLabel.Text = "[dato]";
            CuentaCorrienteListView.Items.Clear();
            PeriodoDateTimePicker.Value = DateTime.Today;
            periodoSeleccionado = false;
            CuitTextBox.Focus();
        }

        private void CargarCuentaCorriente(List<CtaCorriente> movimientos)
        {
            CuentaCorrienteListView.Items.Clear();

            foreach (var movimiento in movimientos)
            {
                var item = new ListViewItem(movimiento.Tipo);
                item.SubItems.Add(movimiento.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(movimiento.Vencimiento.ToString("dd/MM/yyyy"));
                item.SubItems.Add(movimiento.Comprobante);
                item.SubItems.Add(movimiento.Debe.ToString("N2"));
                item.SubItems.Add(movimiento.Haber.ToString("N2"));
                item.SubItems.Add(movimiento.Saldo.ToString("N2"));

                CuentaCorrienteListView.Items.Add(item);
            }
        }
    }
}
