namespace TP3_CAI_GRUPO_C.ImposiciónXCD
{
    public partial class ImposiciónXCDForm : Form
    {
        private ImposicionXCDModelo modelo = new ImposicionXCDModelo();

        public ImposiciónXCDForm()
        {
            InitializeComponent();
        }

        private void ImposiciónXCDForm_Load(object sender, EventArgs e)
        {
            NroCDLabel.Text = modelo.CodigoCDActual.ToString();
            label1.Text = "";

            ProvinciaDomicilioComboBox.Items.AddRange(modelo.Provincias);
            ProvinciaSucursalComboBox.Items.AddRange(modelo.Provincias);

            foreach (var metodoEntrega in modelo.MetodosEntrega)
            {
                MetodoEntregaComboBox.Items.Add(metodoEntrega);
            }

            ProvinciaDomicilioComboBox.SelectedIndex = -1;
            ProvinciaSucursalComboBox.SelectedIndex = -1;
            MetodoEntregaComboBox.SelectedIndex = -1;
            LocalidadDomicilioComboBox.Text = "";
            LocalidadSucursalComboBox.Text = "";

            SucursalListView.FullRowSelect = true;
            SucursalListView.MultiSelect = false;

            BloquearFormularioParaNuevoCliente();
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
                label1.Text = resultado.cliente.RazonSocial;
                MetodoEntregaComboBox.Enabled = true;
            }
            else
            {
                MessageBox.Show(resultado.error);
            }
        }

        private void MetodoEntregaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MetodoEntregaComboBox.SelectedIndex == -1)
                return;

            if (MetodoEntregaComboBox.SelectedItem?.ToString() == "A Domicilio")
            {
                EntregaDomicilioGroupBox.Enabled = true;
                RetiroSucursalGroupBox.Enabled = false;
                ProvinciaDomicilioComboBox.Enabled = true;
            }
            else
            {
                EntregaDomicilioGroupBox.Enabled = false;
                RetiroSucursalGroupBox.Enabled = true;
                ProvinciaSucursalComboBox.Enabled = true;
            }

            DatosDestinatarioGroupBox.Enabled = true;
            DatosEncomiendaGroupBox.Enabled = true;
        }

        private void ProvinciaDomicilioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadDomicilioComboBox.Items.Clear();

            if (ProvinciaDomicilioComboBox.SelectedIndex == -1)
            {
                LocalidadDomicilioComboBox.Enabled = false;
                CodigoPostalTextBox.Enabled = false;
                DireccionTextBox.Enabled = false;

                LocalidadDomicilioComboBox.Text = "";
                CodigoPostalTextBox.Text = "";
                DireccionTextBox.Text = "";
                return;
            }

            LocalidadDomicilioComboBox.Enabled = true;
            CodigoPostalTextBox.Enabled = true;
            DireccionTextBox.Enabled = true;
            LocalidadDomicilioComboBox.SelectedIndex = -1;

            string provincia = (string)ProvinciaDomicilioComboBox.SelectedItem!;
            LocalidadDomicilioComboBox.Items.AddRange(modelo.ObtenerLocalidadesPorProvincia(provincia));
        }

        private void ProvinciaSucursalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadSucursalComboBox.Items.Clear();
            SucursalListView.Items.Clear();

            if (ProvinciaSucursalComboBox.SelectedIndex == -1)
            {
                LocalidadSucursalComboBox.Enabled = false;
                SucursalListView.Enabled = false;
                return;
            }

            LocalidadSucursalComboBox.Enabled = true;
            SucursalListView.Enabled = false;
            LocalidadSucursalComboBox.SelectedIndex = -1;

            string provincia = (string)ProvinciaSucursalComboBox.SelectedItem!;
            LocalidadSucursalComboBox.Items.AddRange(modelo.ObtenerLocalidadesPorProvincia(provincia));
        }

        private void LocalidadSucursalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SucursalListView.Items.Clear();

            if (LocalidadSucursalComboBox.SelectedIndex == -1)
            {
                SucursalListView.Enabled = false;
                return;
            }

            SucursalListView.Enabled = true;
            CargarSucursales(LocalidadSucursalComboBox.SelectedItem!.ToString()!);
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuitTextBox.Text, out var cuit))
            {
                MessageBox.Show("El CUIT debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(DniTextBox.Text, out var dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var codigoPostal = 0;
            if (MetodoEntregaComboBox.SelectedItem?.ToString() == "A Domicilio" &&
                !int.TryParse(CodigoPostalTextBox.Text, out codigoPostal))
            {
                MessageBox.Show("El código postal de entrega debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TryParseCantidadCaja(CantidadCajasSTextBox.Text, out var cantidadCajaS) ||
                !TryParseCantidadCaja(CantidadCajasMTextBox.Text, out var cantidadCajaM) ||
                !TryParseCantidadCaja(CantidadCajasLTextBox.Text, out var cantidadCajaL) ||
                !TryParseCantidadCaja(CantidadCajasXLTextBox.Text, out var cantidadCajaXL))
            {
                MessageBox.Show("Las cantidades de cajas deben ser números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var imposicion = new Imposicion
            {
                CuitCliente = cuit,
                NombreDestinatario = NombreApellidoTextBox.Text,
                DniDestinatario = dni,
                MetodoEntrega = MetodoEntregaComboBox.SelectedItem?.ToString() ?? "",
                ProvinciaDomicilio = ProvinciaDomicilioComboBox.SelectedItem?.ToString() ?? "",
                LocalidadDomicilio = LocalidadDomicilioComboBox.SelectedItem?.ToString() ?? "",
                CodigoPostalDomicilio = codigoPostal,
                DireccionDomicilio = DireccionTextBox.Text,
                ProvinciaSucursal = ProvinciaSucursalComboBox.SelectedItem?.ToString() ?? "",
                LocalidadSucursal = LocalidadSucursalComboBox.SelectedItem?.ToString() ?? "",
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
            if (SucursalListView.SelectedItems.Count == 0)
                return null;

            var item = SucursalListView.SelectedItems[0];

            return new Sucursal
            {
                Codigo = int.Parse(item.Text),
                Direccion = item.SubItems[1].Text,
                Horarios = item.SubItems[2].Text,
                Tipo = item.SubItems[3].Text
            };
        }

        private void CargarSucursales(string localidad)
        {
            var sucursales = modelo.ObtenerSucursalesPorLocalidad(localidad);

            foreach (var s in sucursales)
            {
                var item = new ListViewItem(s.Codigo.ToString());
                item.SubItems.Add(s.Direccion);
                item.SubItems.Add(s.Horarios);
                item.SubItems.Add(s.Tipo);

                SucursalListView.Items.Add(item);
            }
        }

        private void LimpiarFormulario()
        {
            CuitTextBox.Text = "";
            label1.Text = "";
            NombreApellidoTextBox.Text = "";
            DniTextBox.Text = "";
            CodigoPostalTextBox.Text = "";
            DireccionTextBox.Text = "";
            CantidadCajasSTextBox.Text = "";
            CantidadCajasMTextBox.Text = "";
            CantidadCajasLTextBox.Text = "";
            CantidadCajasXLTextBox.Text = "";

            MetodoEntregaComboBox.SelectedIndex = -1;
            ProvinciaDomicilioComboBox.SelectedIndex = -1;
            ProvinciaSucursalComboBox.SelectedIndex = -1;

            LocalidadDomicilioComboBox.Items.Clear();
            LocalidadDomicilioComboBox.Text = "";
            LocalidadSucursalComboBox.Items.Clear();
            LocalidadSucursalComboBox.Text = "";
            SucursalListView.Items.Clear();

            BloquearFormularioParaNuevoCliente();
        }

        private void BloquearFormularioParaNuevoCliente()
        {
            EntregaDomicilioGroupBox.Enabled = false;
            RetiroSucursalGroupBox.Enabled = false;
            DatosDestinatarioGroupBox.Enabled = false;
            DatosEncomiendaGroupBox.Enabled = false;

            MetodoEntregaComboBox.Enabled = false;
            ProvinciaDomicilioComboBox.Enabled = false;
            LocalidadDomicilioComboBox.Enabled = false;
            CodigoPostalTextBox.Enabled = false;
            DireccionTextBox.Enabled = false;

            ProvinciaSucursalComboBox.Enabled = false;
            LocalidadSucursalComboBox.Enabled = false;
            SucursalListView.Enabled = false;
        }
    }
}
