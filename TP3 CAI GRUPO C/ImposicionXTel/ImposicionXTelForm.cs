using System.Reflection;

namespace TP3_CAI_GRUPO_C.ImposicionXTel
{
    public partial class ImposicionXTelForm : Form
    {
        public ImposicionXTelForm()
        {
            InitializeComponent();
        }

        private ImposicionXTelModelo modelo = new ImposicionXTelModelo();
        private void ImposicionXTelForm_Load(object sender, EventArgs e)
        {
            var provincias = modelo.Provincias;
            var metodosEntrega = modelo.MetodosEntrega;

            //Agregar las opciones provincias a Combobox

            foreach (var provincia in provincias)

            {
                ProvinciaRetiroComboBox.Items.Add(provincia);

            }

            foreach (var provincia in provincias)

            {
                ProvinciaEnvioComboBox.Items.Add(provincia);

            }

            foreach (var provincia in provincias)

            {
                ProvinciaSucurComboBox.Items.Add(provincia);

            }

            //Agregar las opciones tipos de entrega a Combobox Metodos de Entrega

            foreach (var tipoEntrega in metodosEntrega)

            {
                MetodoEntregaComboBox.Items.Add(tipoEntrega);
            }
        }

        private void ValidarButton_Click(object sender, EventArgs e)
        {
            //Validar que no esté vacío el campo CUIT 
            if (string.IsNullOrWhiteSpace(CuitTextBox.Text))
            {
                MessageBox.Show("El campo CUIT no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar que se ingresó un numero en CUIT y que no es decimal 
            //(long.TryParse() solo acepta números enteros.

            if (!long.TryParse(CuitTextBox.Text, out long cuit))
            {
                MessageBox.Show("El CUIT debe ser un número válido sin puntos, guiones ni comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  var Cliente = ValidarCliente(cuit);

            //  if (Cliente == null)

            //{
            //  return;
            // }
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea cancelar y cerrar la ventana?",
                "Confirmar Cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            //Validar que no esté vacío el campo Nombre y Apellido de Destinatario 
            if (string.IsNullOrWhiteSpace(NombreDestinatarioTextBox.Text))
            {
                MessageBox.Show("El Nombre y Apellido de Destinatario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Validar que no esté vacío el campo DNI de Destinatario 
            if (string.IsNullOrWhiteSpace(DNIDestinatarioTextBox.Text))
            {
                MessageBox.Show("El DNI de Destinatario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void MetodoEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MetodoEntregaComboBox.SelectedIndex == -1)
                return;

            if (MetodoEntregaComboBox.SelectedIndex == 0)
            {
                DatosEntregaGroupBox.Enabled = true;
                DatosSucurGroupBox.Enabled = false;
            }
            else
            {
                DatosEntregaGroupBox.Enabled = false;
                DatosSucurGroupBox.Enabled = true;
            }
        }
    }

}
