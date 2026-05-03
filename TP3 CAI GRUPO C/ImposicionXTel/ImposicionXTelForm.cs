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

    }
}
