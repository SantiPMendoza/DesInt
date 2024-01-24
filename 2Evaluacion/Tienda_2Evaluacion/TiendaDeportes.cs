using MySql.Data.MySqlClient;
using Tienda_2Evaluacion.Model;
using System.Data;
using System.Text;
using System.Windows.Forms;

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
        }

        private void CargarDatos()
        {
            ConexionBD conexionBD = new ConexionBD();
            List<Articulo> listaArticulos = conexionBD.GetArticulos();

            if (listaArticulos.Count > 0)
            {
                dataGridView1.DataSource = listaArticulos;

                dataGridView1.Columns["Id"].Visible = false; 
            }
            else
            {
                MessageBox.Show("No se pudieron cargar datos desde la base de datos.");
            }
        }

    }
}