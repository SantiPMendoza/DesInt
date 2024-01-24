using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms; // Make sure to include this for MessageBox
using MySql.Data.MySqlClient;
using Tienda_2Evaluacion.Model;

namespace Tienda_2Evaluacion
{
    internal class ConexionBD
    {
        public List<Articulo> GetArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            try
            {
                string stringConexion = "server=localhost;database=tienda_deportes;uid=root;password=root";
                using (MySqlConnection conexion = new MySqlConnection(stringConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM articulos";
                    using (MySqlCommand command = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Articulo articulo = new Articulo();

                                articulo.Id = reader.GetInt32("id");
                                articulo.Deporte = Enum.TryParse(reader.GetString("deporte"), out Articulo.SportType deporteEnum)
                                    ? deporteEnum
                                    : Articulo.SportType.otro;
                                articulo.TipoArticulo = Enum.TryParse(reader.GetString("tipo_articulo"), out Articulo.ArticleType tipoArticuloEnum)
                                    ? tipoArticuloEnum
                                    : Articulo.ArticleType.articulo; 
                                articulo.Nombre = reader.IsDBNull(reader.GetOrdinal("nombre")) ? null : reader.GetString(reader.GetOrdinal("nombre"));
                                articulo.Precio = reader.IsDBNull(reader.GetOrdinal("precio")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("precio"));

                                listaArticulos.Add(articulo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return listaArticulos;
        }
    }
}
