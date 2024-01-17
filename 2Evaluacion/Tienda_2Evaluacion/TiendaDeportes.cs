using MySql.Data.MySqlClient;
using Tienda_2Evaluacion.Model;

namespace Tienda_2Evaluacion
{
    public partial class TiendaDeportes : Form
    {
        public List<Articulo> ListaArticulos { get; set; }
        public TiendaDeportes()
        {
            ListaArticulos = new List<Articulo>();
            InitializeComponent();
        }

        private void TiendaDeportes_Load(object sender, EventArgs e)
        {
            RecogerYMostrarArticulos();
        }

        private MySqlConnection Connect()
        {
            string connectionString = "Server=localhost;Port=1818;Database=tienda_deportes;User Id=root;Password=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        public List<Articulo> RecogerYMostrarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            using (MySqlConnection connection = Connect())
            {
                connection.Open();

                string consulta = "SELECT * FROM articulos";
                using (MySqlCommand command = new MySqlCommand(consulta, connection))
                {
                    try
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Articulo articulo = new Articulo
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Deporte = (Articulo.SportType)Enum.Parse(typeof(Articulo.SportType), reader["deporte"].ToString(), true),
                                    TipoArticulo = (Articulo.ArticleType)Enum.Parse(typeof(Articulo.ArticleType), reader["tipo_articulo"].ToString(), true),
                                    Nombre = reader["nombre"].ToString(),
                                    Precio = (double)Convert.ToDecimal(reader["precio"])
                                };

                                listaArticulos.Add(articulo);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading data from database: " + ex.Message);
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ListaArticulos;
                }
            }

            return listaArticulos;
        }
    }
}
