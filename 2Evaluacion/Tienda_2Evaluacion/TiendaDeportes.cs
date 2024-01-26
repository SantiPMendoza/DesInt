using MySql.Data.MySqlClient;
using Tienda_2Evaluacion.Model;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tienda_2Evaluacion
{
    public partial class TiendaDeportes : Form
    {
        public List<Articulo> ListaArticulos { get; set; }
        public TiendaDeportes()
        {
            //this.ListaArticulos = new List<Articulo>();
            InitializeComponent();
            CargarDatos();
            buttonBuscar.Click += button1_Click;
        }

        private void CargarDatos()
        {

            ConexionBD conexionBD = new ConexionBD();
            this.ListaArticulos = conexionBD.GetArticulos();

            if (ListaArticulos.Count > 0)
            {
                dataGridView1.DataSource = ListaArticulos;

                dataGridView1.Columns["Id"].Visible = false;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar datos desde la base de datos.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string deporte = comboBoxDeporte.SelectedItem?.ToString() ?? string.Empty;

            string tipoArticulo = comboBoxTipo.SelectedItem?.ToString() ?? string.Empty;

            string nombre = textBoxNombre.Text.Trim();

            List<Articulo> resultados = ListaArticulos.Where(articulo =>
                (string.IsNullOrEmpty(nombre) || articulo.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(deporte) || deporte == articulo.Deporte.ToString()) &&
                (string.IsNullOrEmpty(tipoArticulo) || tipoArticulo == articulo.TipoArticulo.ToString())
            ).ToList();

            if (resultados.Count > 0)
            {
                dataGridView1.DataSource = resultados;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para la búsqueda.");
            }
        }


    }


}
