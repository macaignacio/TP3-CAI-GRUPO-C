namespace TP3_CAI_GRUPO_C.Admision
{
    public partial class AdmisionForm : Form
    {
        private AdmisionModelo modelo = new AdmisionModelo();

        public AdmisionForm()
        {
            InitializeComponent();
        }

        private void AdmisionForm_Load(object sender, EventArgs e)
        {
            BloquearFormulario();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(NumeroGuiaTextBox.Text, out var numeroGuia))
            {
                MessageBox.Show("El número de guía debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = modelo.BuscarGuia(numeroGuia);

            if (!resultado.Valido || resultado.Guia == null)
            {
                LimpiarDatosGuia();
                MessageBox.Show(resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mostrarCuitLabel.Text = resultado.Guia.CuitCliente.ToString();
            CantidadCajasSTextBox.Text = resultado.Guia.CantidadCajaS.ToString();
            CantidadCajasMTextBox.Text = resultado.Guia.CantidadCajaM.ToString();
            CantidadCajasLTextBox.Text = resultado.Guia.CantidadCajaL.ToString();
            CantidadCajasXLTextBox.Text = resultado.Guia.CantidadCajaXL.ToString();

            DatosEncomiendaGroupBox.Enabled = true;
            confirmarAdmisionButton.Enabled = true;
        }

        private void confirmarAdmisionButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(NumeroGuiaTextBox.Text, out var numeroGuia))
            {
                MessageBox.Show("El número de guía debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(CantidadCajasSTextBox.Text, out var cantidadCajaS) ||
                !int.TryParse(CantidadCajasMTextBox.Text, out var cantidadCajaM) ||
                !int.TryParse(CantidadCajasLTextBox.Text, out var cantidadCajaL) ||
                !int.TryParse(CantidadCajasXLTextBox.Text, out var cantidadCajaXL))
            {
                MessageBox.Show("Las cantidades de cajas deben ser números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = modelo.ConfirmarAdmision(
                numeroGuia,
                cantidadCajaS,
                cantidadCajaM,
                cantidadCajaL,
                cantidadCajaXL);

            if (!resultado.Valido)
            {
                MessageBox.Show(resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Admisión realizada exitosamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private void BloquearFormulario()
        {
            mostrarCuitLabel.Text = "";
            DatosEncomiendaGroupBox.Enabled = false;
            confirmarAdmisionButton.Enabled = false;
        }

        private void LimpiarDatosGuia()
        {
            mostrarCuitLabel.Text = "";
            CantidadCajasSTextBox.Text = "";
            CantidadCajasMTextBox.Text = "";
            CantidadCajasLTextBox.Text = "";
            CantidadCajasXLTextBox.Text = "";
            DatosEncomiendaGroupBox.Enabled = false;
            confirmarAdmisionButton.Enabled = false;
        }

        private void LimpiarFormulario()
        {
            NumeroGuiaTextBox.Text = "";
            LimpiarDatosGuia();
        }
    }
}
