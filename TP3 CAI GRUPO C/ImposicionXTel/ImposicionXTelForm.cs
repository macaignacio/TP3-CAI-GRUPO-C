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

            // Lista de ComboBox de provincias
            var comboBoxesProvincias = new[]
            {
                  ProvinciaRetiroComboBox,
                  ProvinciaEnvioComboBox,
                  ProvinciaSucurComboBox
            };

            // Cargar provincias en todos los ComboBox & sin seleccionar nada
            foreach (var combo in comboBoxesProvincias)
            {
                combo.Items.AddRange(provincias);
                combo.SelectedIndex = -1;
            }

            //Agregar las opciones tipos de entrega a Combobox Metodos de Entrega

            foreach (var tipoEntrega in metodosEntrega)

            {
                MetodoEntregaComboBox.Items.Add(tipoEntrega);
            }

            // Estado inicial de los groupbox
            DatosEntregaGroupBox.Enabled = false;
            DatosSucurGroupBox.Enabled = false;

            // Retiro
            LocalidadRetiroComboBox.Enabled = false;
            CPRetiroTextBox.Enabled = false;
            DirecRetiroTextBox.Enabled = false;

            // Entrega
            LocalidadEnvioComboBox.Enabled = false;
            CPEnvioTextBox.Enabled = false;
            DirecEnvioTextBox.Enabled = false;

            // Sucursal
            RetiroSucurListView.Enabled = false;

            // Bloquear selección hasta validar CUIT
            ProvinciaRetiroComboBox.Enabled = false;
            ProvinciaEnvioComboBox.Enabled = false;
            ProvinciaSucurComboBox.Enabled = false;
            MetodoEntregaComboBox.Enabled = false;
            DatosDestinatarioGroupBox.Enabled = false;
            DatosEncomiendaGroupBox.Enabled = false;

        }

        private void ValidarButton_Click(object sender, EventArgs e)
        {
            //Realizar las distintas validaciones asociadas al CUIT
            var resultado = modelo.ValidarCliente(CuitTextBox.Text);

            if (resultado.cliente != null)
            {
                RazonSocialLabel.Text = resultado.cliente.RazonSocial;
                ProvinciaRetiroComboBox.Enabled = true;
                MetodoEntregaComboBox.Enabled = true;
            }
            else
            {
                MessageBox.Show(resultado.error);
            }
                   

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

            // RETIRO
          

            if (!modelo.ValidarCodigoPostal(CPRetiroTextBox.Text))
            {
                MessageBox.Show("El código postal de retiro debe ser un número de 4 dígitos.");
                return;
            }

            if (!modelo.ValidarDireccion(DirecRetiroTextBox.Text))
            {
                MessageBox.Show("La dirección de retiro no puede estar vacía.");
                return;
            }

            
            // ENTREGA (depende del método)
            

            if (MetodoEntregaComboBox.SelectedIndex == 0) // A domicilio
            {
                if (!modelo.ValidarCodigoPostal(CPEnvioTextBox.Text))
                {
                    MessageBox.Show("El código postal de entrega debe ser un número de 4 dígitos.");
                    return;
                }

                if (!modelo.ValidarDireccion(DirecEnvioTextBox.Text))
                {
                    MessageBox.Show("La dirección de entrega no puede estar vacía.");
                    return;
                }
            }
            else // Sucursal
            {
                if (RetiroSucurListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una sucursal.");
                    return;
                }
            }

        }


           

      private void ProvinciaRetiroComboBox_SelectedIndexChanged(object sender, EventArgs e)
          {
            if (ProvinciaRetiroComboBox.SelectedIndex == -1)
            {
                // Deshabilitar todo
                LocalidadRetiroComboBox.Enabled = false;
                CPRetiroTextBox.Enabled = false;
                DirecRetiroTextBox.Enabled = false;

                // Limpiar
                LocalidadRetiroComboBox.Items.Clear();
                LocalidadRetiroComboBox.Text = "";
                CPRetiroTextBox.Text = "";
                DirecRetiroTextBox.Text = "";
            }
            else
            {
                // SIEMPRE habilitar cuando hay provincia
                LocalidadRetiroComboBox.Enabled = true;
                CPRetiroTextBox.Enabled = true;
                DirecRetiroTextBox.Enabled = true;

                // Limpiar antes de cargar
                LocalidadRetiroComboBox.Items.Clear();
                LocalidadRetiroComboBox.SelectedIndex = -1;

                string provincia = (string)ProvinciaRetiroComboBox.SelectedItem!;

                var localidades = modelo.ObtenerLocalidadesPorProvincia(provincia);

                // SOLO carga si hay datos (CABA)
                if (localidades.Length > 0)
                {
                    LocalidadRetiroComboBox.Items.AddRange(localidades);
                }
                
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
                ProvinciaEnvioComboBox.Enabled = true;
            }
            else
            {
                DatosEntregaGroupBox.Enabled = false;
                DatosSucurGroupBox.Enabled = true;
                ProvinciaSucurComboBox.Enabled = true;
            }
           
            DatosDestinatarioGroupBox.Enabled = true;
            DatosEncomiendaGroupBox.Enabled = true;

        }

        private void ProvinciaEnvioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProvinciaEnvioComboBox.SelectedIndex == -1)
            {
                LocalidadEnvioComboBox.Enabled = false;
                CPEnvioTextBox.Enabled = false;
                DirecEnvioTextBox.Enabled = false;

                LocalidadEnvioComboBox.Text = "";
                CPEnvioTextBox.Text = "";
                DirecEnvioTextBox.Text = "";
            }
            else
            {
                LocalidadEnvioComboBox.Enabled = true;
                CPEnvioTextBox.Enabled = true;
                DirecEnvioTextBox.Enabled = true;
            }
        }

        private void ProvinciaSucurComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProvinciaSucurComboBox.SelectedIndex == -1)
            {
                RetiroSucurListView.Enabled = false;
                RetiroSucurListView.Items.Clear();
                return;
            }

            RetiroSucurListView.Enabled = true;
            RetiroSucurListView.Items.Clear();

            string provincia = (string)ProvinciaSucurComboBox.SelectedItem!;

            var sucursales = modelo.ObtenerSucursalesPorProvincia(provincia);

            foreach (var s in sucursales)
            {
                var item = new ListViewItem(s.Codigo);
                item.SubItems.Add(s.Direccion);
                item.SubItems.Add(s.Horarios);
                item.SubItems.Add(s.Tipo);

                RetiroSucurListView.Items.Add(item);
            }
        }

        


    }

}
