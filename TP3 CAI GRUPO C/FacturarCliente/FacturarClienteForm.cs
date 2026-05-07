using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    public partial class FacturarClienteForm : Form
    {
        private FacturarClienteModelo modelo = new FacturarClienteModelo();
        private List<Servicio> serviciosCargados = new List<Servicio>();

        public FacturarClienteForm()
        {
            InitializeComponent();
        }

        private void FacturarClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuitTextBox.Text, out var cuit))
            {
                MessageBox.Show("El CUIT debe ser un número");
                return;
            }

            var resultado = modelo.ValidarCliente(cuit);

            if (resultado.cliente != null)
            {
                RSLabel.Text = resultado.cliente.RazonSocial;
                CargarFacturas(resultado.cliente.RazonSocial);
            }
            else
            {
                LimpiarDatosFacturacion();
                MessageBox.Show(resultado.error);
            }

        }
          
        private void CargarFacturas(string cliente)
        {
            ServiciosListView.Items.Clear();

            var facturas = modelo.ObtenerFacturasPorCliente(cliente);

            var resultado = modelo.CalcularFacturacion(new FacturacionCliente
            {
                Servicios = facturas
            });

            serviciosCargados = resultado.facturas;

            foreach (var f in resultado.facturas)
            {
                var item = new ListViewItem(f.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(f.Descripcion);
                item.SubItems.Add(f.NumeroGuia.ToString());
                item.SubItems.Add(f.Monto.ToString("N2"));
                item.SubItems.Add(f.Subtotal.ToString("N2"));

                ServiciosListView.Items.Add(item);
            }

            TotalCalculadoLabel.Text = resultado.total.ToString("N2");
        }

        private void EmitirFacturaButton_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(CuitTextBox.Text, out var cuit))
            {
                MessageBox.Show("El CUIT debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var facturacion = new FacturacionCliente
            {
                CuitCliente = cuit,
                RazonSocial = RSLabel.Text,
                Servicios = serviciosCargados
            };

            var resultado = modelo.EmitirFactura(facturacion);

            if (!resultado.Valido)
            {
                MessageBox.Show(resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Factura emitida con éxito. Número de factura: {resultado.Factura!.NumeroFactura}",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            CuitTextBox.Text = "";
            LimpiarDatosFacturacion();
        }

        private void LimpiarDatosFacturacion()
        {
            RSLabel.Text = "[dato]";
            ServiciosListView.Items.Clear();
            TotalCalculadoLabel.Text = "[Total calculado]";
            serviciosCargados.Clear();
        }
            
    }
}
