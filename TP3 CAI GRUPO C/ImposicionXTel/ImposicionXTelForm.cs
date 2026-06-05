namespace TP3_CAI_GRUPO_C.ImposicionXTel
{
    public partial class ImposicionXTelForm : Form
    {
        private ImposicionXTelModelo modelo = new ImposicionXTelModelo();

        public ImposicionXTelForm()
        {
            InitializeComponent();
        }

        private void ImposicionXTelForm_Load(object sender, EventArgs e)
        {
            var provincias = modelo.Provincias;
            var metodosEntrega = modelo.MetodosEntrega;

            var comboBoxesProvincias = new[]
            {
                  ProvinciaRetiroComboBox,
                  ProvinciaEnvioComboBox,
                  ProvinciaSucurComboBox
            };

            foreach (var combo in comboBoxesProvincias)
            {
                combo.Items.AddRange(provincias);
                combo.SelectedIndex = -1;
            }

            foreach (var tipoEntrega in metodosEntrega)
            {
                MetodoEntregaComboBox.Items.Add(tipoEntrega);
            }

            DatosEntregaGroupBox.Enabled = false;
            DatosSucurGroupBox.Enabled = false;

            LocalidadRetiroComboBox.Enabled = false;
            CPRetiroTextBox.Enabled = false;
            DirecRetiroTextBox.Enabled = false;

            LocalidadEnvioComboBox.Enabled = false;
            CPEnvioTextBox.Enabled = false;
            DirecEnvioTextBox.Enabled = false;

            LocalidadSucurComboBox.Enabled = false;
            RetiroSucurListView.Enabled = false;

            ProvinciaRetiroComboBox.Enabled = false;
            ProvinciaEnvioComboBox.Enabled = false;
            ProvinciaSucurComboBox.Enabled = false;
            MetodoEntregaComboBox.Enabled = false;
            DatosDestinatarioGroupBox.Enabled = false;
            DatosEncomiendaGroupBox.Enabled = false;
        }

        private void ValidarButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuitTextBox.Text, out var cuit))
            {
                MessageBox.Show("CUIT inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");
                return;
            }

            var resultado = modelo.ValidarCliente(cuit);

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
                Close();
            }
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuitTextBox.Text, out var cuit))
            {
                MessageBox.Show("El CUIT debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(DNIDestinatarioTextBox.Text, out var dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(CPRetiroTextBox.Text, out var codigoPostalRetiro))
            {
                MessageBox.Show("El código postal de retiro debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var codigoPostalEnvio = 0;
            if (MetodoEntregaComboBox.SelectedItem?.ToString() == "A Domicilio" &&
                !int.TryParse(CPEnvioTextBox.Text, out codigoPostalEnvio))
            {
                MessageBox.Show("El código postal de entrega debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TryParseCantidadCaja(CajaSTextBox.Text, out var cantidadCajaS) ||
                !TryParseCantidadCaja(CajaMTextBox.Text, out var cantidadCajaM) ||
                !TryParseCantidadCaja(CajaLTextBox.Text, out var cantidadCajaL) ||
                !TryParseCantidadCaja(CajaXLTextBox.Text, out var cantidadCajaXL))
            {
                MessageBox.Show("Las cantidades de cajas deben ser números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var imposicion = new Imposicion
            {
                CuitCliente = cuit,
                NombreDestinatario = NombreDestinatarioTextBox.Text,
                DniDestinatario = dni,
                ProvinciaRetiro = ProvinciaRetiroComboBox.SelectedItem?.ToString() ?? "",
                LocalidadRetiro = LocalidadRetiroComboBox.SelectedItem?.ToString() ?? "",
                CodigoPostalRetiro = codigoPostalRetiro,
                DireccionRetiro = DirecRetiroTextBox.Text,
                MetodoEntrega = MetodoEntregaComboBox.SelectedItem?.ToString() ?? "",
                ProvinciaEnvio = ProvinciaEnvioComboBox.SelectedItem?.ToString() ?? "",
                LocalidadEnvio = LocalidadEnvioComboBox.SelectedItem?.ToString() ?? "",
                CodigoPostalEnvio = codigoPostalEnvio,
                DireccionEnvio = DirecEnvioTextBox.Text,
                ProvinciaSucursal = ProvinciaSucurComboBox.SelectedItem?.ToString() ?? "",
                LocalidadSucursal = LocalidadSucurComboBox.SelectedItem?.ToString() ?? "",
                SucursalSeleccionada = ObtenerSucursalSeleccionada(),
                CantidadCajaS = cantidadCajaS,
                CantidadCajaM = cantidadCajaM,
                CantidadCajaL = cantidadCajaL,
                CantidadCajaXL = cantidadCajaXL
            };

            var resultado = modelo.GenerarImposicion(imposicion);

            if (!resultado.Valido)
            {
                MessageBox.Show(resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Imposición generada con éxito. Número de guía: {resultado.Guía!.NumeroGuia}",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private bool TryParseCantidadCaja(string texto, out int cantidad)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                cantidad = 0;
                return true;
            }

            return int.TryParse(texto, out cantidad);
        }

        private Sucursal? ObtenerSucursalSeleccionada()
        {
            if (RetiroSucurListView.SelectedItems.Count == 0)
                return null;

            var item = RetiroSucurListView.SelectedItems[0];

            return new Sucursal
            {
                Codigo = item.Text,
                Direccion = item.SubItems[1].Text,
                Horarios = item.SubItems[2].Text,
                Tipo = item.SubItems[3].Text
            };
        }

        private void LimpiarFormulario()
        {
            CuitTextBox.Text = "";
            RazonSocialLabel.Text = "";
            NombreDestinatarioTextBox.Text = "";
            DNIDestinatarioTextBox.Text = "";
            CPRetiroTextBox.Text = "";
            DirecRetiroTextBox.Text = "";
            CPEnvioTextBox.Text = "";
            DirecEnvioTextBox.Text = "";
            CajaSTextBox.Text = "";
            CajaMTextBox.Text = "";
            CajaLTextBox.Text = "";
            CajaXLTextBox.Text = "";

            ProvinciaRetiroComboBox.SelectedIndex = -1;
            ProvinciaEnvioComboBox.SelectedIndex = -1;
            ProvinciaSucurComboBox.SelectedIndex = -1;
            MetodoEntregaComboBox.SelectedIndex = -1;

            LocalidadRetiroComboBox.Items.Clear();
            LocalidadRetiroComboBox.Text = "";
            LocalidadEnvioComboBox.Items.Clear();
            LocalidadEnvioComboBox.Text = "";
            LocalidadSucurComboBox.Items.Clear();
            LocalidadSucurComboBox.Text = "";
            RetiroSucurListView.Items.Clear();

            DatosEntregaGroupBox.Enabled = false;
            DatosSucurGroupBox.Enabled = false;
            LocalidadRetiroComboBox.Enabled = false;
            CPRetiroTextBox.Enabled = false;
            DirecRetiroTextBox.Enabled = false;
            LocalidadEnvioComboBox.Enabled = false;
            CPEnvioTextBox.Enabled = false;
            DirecEnvioTextBox.Enabled = false;
            LocalidadSucurComboBox.Enabled = false;
            RetiroSucurListView.Enabled = false;

            ProvinciaRetiroComboBox.Enabled = false;
            ProvinciaEnvioComboBox.Enabled = false;
            ProvinciaSucurComboBox.Enabled = false;
            MetodoEntregaComboBox.Enabled = false;
            DatosDestinatarioGroupBox.Enabled = false;
            DatosEncomiendaGroupBox.Enabled = false;
        }

        private void ProvinciaRetiroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadRetiroComboBox.Items.Clear();

            if (ProvinciaRetiroComboBox.SelectedIndex == -1)
            {
                LocalidadRetiroComboBox.Enabled = false;
                CPRetiroTextBox.Enabled = false;
                DirecRetiroTextBox.Enabled = false;

                LocalidadRetiroComboBox.Text = "";
                CPRetiroTextBox.Text = "";
                DirecRetiroTextBox.Text = "";
                return;
            }

            LocalidadRetiroComboBox.Enabled = true;
            CPRetiroTextBox.Enabled = true;
            DirecRetiroTextBox.Enabled = true;
            LocalidadRetiroComboBox.SelectedIndex = -1;

            string provincia = (string)ProvinciaRetiroComboBox.SelectedItem!;
            LocalidadRetiroComboBox.Items.AddRange(modelo.ObtenerLocalidadesPorProvincia(provincia));
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
            LocalidadEnvioComboBox.Items.Clear();

            if (ProvinciaEnvioComboBox.SelectedIndex == -1)
            {
                LocalidadEnvioComboBox.Enabled = false;
                CPEnvioTextBox.Enabled = false;
                DirecEnvioTextBox.Enabled = false;

                LocalidadEnvioComboBox.Text = "";
                CPEnvioTextBox.Text = "";
                DirecEnvioTextBox.Text = "";
                return;
            }

            LocalidadEnvioComboBox.Enabled = true;
            CPEnvioTextBox.Enabled = true;
            DirecEnvioTextBox.Enabled = true;
            LocalidadEnvioComboBox.SelectedIndex = -1;

            string provincia = (string)ProvinciaEnvioComboBox.SelectedItem!;
            LocalidadEnvioComboBox.Items.AddRange(modelo.ObtenerLocalidadesPorProvincia(provincia));
        }

        private void ProvinciaSucurComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadSucurComboBox.Items.Clear();
            RetiroSucurListView.Items.Clear();

            if (ProvinciaSucurComboBox.SelectedIndex == -1)
            {
                LocalidadSucurComboBox.Enabled = false;
                RetiroSucurListView.Enabled = false;
                return;
            }

            LocalidadSucurComboBox.Enabled = true;
            RetiroSucurListView.Enabled = false;
            LocalidadSucurComboBox.SelectedIndex = -1;

            string provincia = (string)ProvinciaSucurComboBox.SelectedItem!;
            LocalidadSucurComboBox.Items.AddRange(modelo.ObtenerLocalidadesPorProvincia(provincia));
        }

        private void LocalidadSucurComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetiroSucurListView.Items.Clear();

            if (LocalidadSucurComboBox.SelectedIndex == -1)
            {
                RetiroSucurListView.Enabled = false;
                return;
            }

            RetiroSucurListView.Enabled = true;
            CargarSucursales(LocalidadSucurComboBox.SelectedItem!.ToString()!);
        }

        private void CargarSucursales(string localidad)
        {
            var sucursales = modelo.ObtenerSucursalesPorLocalidad(localidad);

            foreach (var s in sucursales)
            {
                var item = new ListViewItem(s.Codigo);
                item.SubItems.Add(s.Direccion);
                item.SubItems.Add(s.Horarios);
                item.SubItems.Add(s.Tipo);

                RetiroSucurListView.Items.Add(item);
            }
        }

        private void DatosSucurGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
