using TP3_CAI_GRUPO_C.Admision;
using TP3_CAI_GRUPO_C.Almacenes;
using TP3_CAI_GRUPO_C.ConsultaCtaCteCliente;
using TP3_CAI_GRUPO_C.Devolucion;
using TP3_CAI_GRUPO_C.DespachoEncomiendasCD;
using TP3_CAI_GRUPO_C.Entrega;
using TP3_CAI_GRUPO_C.EstadoEncomienda;
using TP3_CAI_GRUPO_C.FacturarCliente;
using TP3_CAI_GRUPO_C.GestionFleterosAsignacion;
using TP3_CAI_GRUPO_C.GestionFleterosRendicion;
using TP3_CAI_GRUPO_C.ImposicionXAgencia;
using TP3_CAI_GRUPO_C.ImposicionXTel;
using TP3_CAI_GRUPO_C.ImposiciónXCD;
using TP3_CAI_GRUPO_C.RecepcionEncomiendasCD;
using TP3_CAI_GRUPO_C.ResultadosCostoVenta;

namespace TP3_CAI_GRUPO_C
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            CargarCombos();
            ConfigurarCombos();
            ConfigurarBotones();
        }

        private void CargarCombos()
        {
            comboBox1.Items.AddRange(CentroDistribucionAlmacen.cd
                .Select(cd => cd.Codigo)
                .OrderBy(codigo => codigo)
                .ToArray());

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox2.Enabled = false;
        }

        private void ConfigurarCombos()
        {
            comboBox1.SelectedIndexChanged += (_, _) =>
            {
                Program.CDActual = comboBox1.SelectedItem?.ToString() ?? "";
                CargarAgenciasPorCD(Program.CDActual);
            };

            comboBox2.SelectedIndexChanged += (_, _) =>
                Program.AgenciaActual = comboBox2.SelectedItem?.ToString() ?? "";
        }

        private void CargarAgenciasPorCD(string codigoCD)
        {
            comboBox2.Items.Clear();
            comboBox2.SelectedIndex = -1;
            Program.AgenciaActual = "";

            if (string.IsNullOrWhiteSpace(codigoCD))
            {
                comboBox2.Enabled = false;
                return;
            }

            comboBox2.Items.AddRange(AgenciaAlmacen.agencia
                .Where(agencia => agencia.CentroDistribucion == codigoCD)
                .Select(agencia => agencia.Codigo)
                .OrderBy(codigo => codigo)
                .ToArray());

            comboBox2.Enabled = comboBox2.Items.Count > 0;
        }

        private void ConfigurarBotones()
        {
            ImpoXTelButton.Click += (_, _) => AbrirFormulario(new ImposicionXTelForm());
            ImpoXAgenciaButton.Click += (_, _) => AbrirFormulario(new ImposicionXAgenciaForm());
            ImpoXCDButton.Click += (_, _) => AbrirFormulario(new ImposiciónXCDForm());
            GestionAsigFleterosButton.Click += (_, _) => AbrirFormulario(new GestionFleterosAsignacionForm());
            GestionRendFleterosButton.Click += (_, _) => AbrirFormulario(new GestionFleterosRendicionForm());
            AdmisionButton.Click += (_, _) => AbrirFormulario(new AdmisionForm());
            DespachoEncomiendasButton.Click += (_, _) => AbrirFormulario(new DespachoEncomiendasCDForm());
            RecepEncomiendasButton.Click += (_, _) => AbrirFormulario(new RecepcionEncomiendasCDForm());
            EntregaButton.Click += (_, _) => AbrirFormulario(new EntregaForm());
            ConsultaEncomiendaButton.Click += (_, _) => AbrirFormulario(new EstadoEncomiendaForm());
            FacturarButton.Click += (_, _) => AbrirFormulario(new FacturarClienteForm());
            CtaCteClienteButton.Click += (_, _) => AbrirFormulario(new ConsultaCtaCteClienteForm());
            ResultadosButton.Click += (_, _) => AbrirFormulario(new ResultadosCostoVentaForm());
            GestionDevolucionesButton.Click += (_, _) => AbrirFormulario(new GestionDevolucionForm());
        }

        private void AbrirFormulario(Form formulario)
        {
            using (formulario)
            {
                formulario.ShowDialog(this);
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
