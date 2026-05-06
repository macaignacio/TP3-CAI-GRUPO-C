namespace TP3_CAI_GRUPO_C.ConsultaCtaCteCliente

{
    public partial class ConsultaCtaCteClienteForm : Form
    {
        public ConsultaCtaCteClienteForm()
        {
            InitializeComponent();
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

            }
            else
            {
                MessageBox.Show(resultado.error);
            }

        }

        private void PeriodoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            periodoSeleccionado = true;
        }
    }
}
