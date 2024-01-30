using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms; // Make sure to include this for MessageBox
using MySql.Data.MySqlClient;
using Tienda_2Evaluacion.Model;

namespace Tienda_2Evaluacion
{
    internal class ConnectionBD
    {
        MySqlConnection connection;



        /**
         * Método para CONECTAR con la Base de Datos, RECUPERAR los artículos de la misma y MOSTRARLOS en un tabla del tipo DataGridView
         */
        public List<Articulo> GetArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            try
            {

                GetCon(); // Abrimos conexion


                    string consulta = "SELECT * FROM articulos";
                    using (MySqlCommand command = new MySqlCommand(consulta, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) // Recogemos cada 'artículo' en un objeto del tipo Artículo mientras haya líneas que leer
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

                                listaArticulos.Add(articulo); // Añadimos el nuevo Artículo a una lista de Artículos
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



        public MySqlConnection GetCon() // Método para abrir y recuperar la conexión
        {
            connection = new MySqlConnection(Utils.Constants.CONNECTION_STRING);
            connection.Open();
            return connection;
        }

        public void CloseCon() // Método para cerrar la conexión
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


        /**
        * Método para ACTUALIZAR un articulo en la BD una vez hayamos recogido los nuevos atributos desde el formulario
        */
        public void ActualizarArticuloEnBD(Articulo articulo)
        {
            try
            {
                // Abrir la conexión
                GetCon();

                // Consulta SQL para actualizar el artículo
                string consulta = "UPDATE articulos SET deporte = @deporte, tipo_articulo = @tipo_articulo, nombre = @nombre, precio = @precio WHERE id = @id";

                using (MySqlCommand command = new MySqlCommand(consulta, GetCon()))
                {
                    // Asignar valores a los parámetros
                    command.Parameters.AddWithValue("@deporte", articulo.Deporte.ToString());
                    command.Parameters.AddWithValue("@tipo_articulo", articulo.TipoArticulo.ToString());
                    command.Parameters.AddWithValue("@nombre", articulo.Nombre);
                    command.Parameters.AddWithValue("@precio", articulo.Precio ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@id", articulo.Id);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el artículo: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                CloseCon();
            }
        }



        /**
         * Método para INSERTAR un articulo en la BD una vez lo hayamos recogido desde el formulario
         */
        public void InsertarArticuloEnBD(Articulo articulo)
        {
            try
            {
                // Abrir la conexión
                GetCon();

                // Consulta SQL para actualizar el artículo
                string consulta = "INSERT articulos SET deporte = @deporte, tipo_articulo = @tipo_articulo, nombre = @nombre, precio = @precio";

                using (MySqlCommand command = new MySqlCommand(consulta, GetCon()))
                {
                    // Asignar valores a los parámetros
                    command.Parameters.AddWithValue("@deporte", articulo.Deporte.ToString());
                    command.Parameters.AddWithValue("@tipo_articulo", articulo.TipoArticulo.ToString());
                    command.Parameters.AddWithValue("@nombre", articulo.Nombre);
                    command.Parameters.AddWithValue("@precio", articulo.Precio ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@id", articulo.Id);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el artículo: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                CloseCon();
            }
        }

    }
}

