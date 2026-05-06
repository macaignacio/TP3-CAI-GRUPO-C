using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using TP3_CAI_GRUPO_C.ImposiciónXCD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    public partial class FacturarClienteForm : Form
    {
        private FacturarClienteModelo modelo = new FacturarClienteModelo();
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
                MessageBox.Show("CUIT inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");
                return;
            }

            var resultado = modelo.ValidarCliente(cuit);

            if (resultado.cliente != null)
            {
                RSLabel.Text = resultado.cliente.RazonSocial;
                
            }
            else
            {
                MessageBox.Show(resultado.error);
            }

        }
        private Factura? ObtenerFacturaSeleccionada()
        {
            if (ServiciosListView.SelectedItems.Count == 0)
                return null;

            var item = ServiciosListView.SelectedItems[0];

            return new Factura 
            {
                Fecha = DateTime.Parse(item.SubItems[0].Text),
                Descripcion = item.SubItems[1].Text,
                NumeroGuia = int.Parse(item.SubItems[2].Text),
                Monto = int.Parse(item.SubItems[3].Text),
                Subtotal = int.Parse(item.SubItems[4].Text)
            };
        }
          
        private void CargarFacturas(string cliente)
        {
            var facturas = modelo.ObtenerFacturasPorCliente(cliente);

            foreach (var f in facturas)
            {
                var item = new ListViewItem(f.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(f.Descripcion);
                item.SubItems.Add(f.NumeroGuia.ToString());
                item.SubItems.Add(f.Monto.ToString());
                item.SubItems.Add(f.Subtotal.ToString());

                ServiciosListView.Items.Add(item);
            }
        }
            
    }
}
