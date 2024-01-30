using MySql.Data.MySqlClient;
using Tienda_2Evaluacion.Model;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System.Diagnostics;

namespace Tienda_2Evaluacion
{
    public partial class TiendaDeportes : Form
    {

        private decimal? PrecioTotal { get; set; } = decimal.Zero;

        ConnectionBD connection;

        public List<Articulo> ListaArticulosBD { get; set; }

        public List<Articulo> ListaArticulosCarrito = new List<Articulo>();

        Articulo articuloSeleccionado;


        public TiendaDeportes()
        {
            InitializeComponent();
            CargarDatos();
            ConfigurarGrafico();
        }

        /**
         * Método para recoger los datos de la BD y generar el gráfico de tipo circular de cuantos artículos por deporte hay.
         */
        private void ConfigurarGrafico()
        {
            PlotModel model = new PlotModel();
            model.Title = "Artículos por Deporte";
            model.DefaultFontSize = 10;

            // Obtener la cantidad de artículos por deporte
            var cantidadPorDeporte = ListaArticulosBD
                .GroupBy(articulo => articulo.Deporte)
                .Select(group => new { Deporte = group.Key, Cantidad = group.Count() });

            PieSeries pieSeries = new PieSeries();

            // Agregar los datos
            foreach (var item in cantidadPorDeporte)
            {
                pieSeries.Slices.Add(new PieSlice(item.Deporte.ToString(), item.Cantidad) { IsExploded = false });
                
            }

            // Agregar la serie al modelo
            model.Series.Add(pieSeries);


            // Asignar el modelo al PlotView
            plotView.Model = model;
        }


        /*
         * Recoge los datos de la base de datos y actualiza la lista de articulos del DataGridView.
         */
        private void CargarDatos()
        {

            connection = new ConnectionBD();
            this.ListaArticulosBD = connection.GetArticulos();

            if (ListaArticulosBD.Count > 0)
            {
                dataGridViewBD.DataSource = ListaArticulosBD;

                dataGridViewBD.Columns["Id"].Visible = false;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar datos desde la base de datos.");
            }
            connection.CloseCon();
        }

        /**
         * Método para BUSCAR un artículo según los valores introducidos en el formulario.
         */
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string deporte = comboBoxDeporte.SelectedItem?.ToString() ?? string.Empty;

            string tipoArticulo = comboBoxTipo.SelectedItem?.ToString() ?? string.Empty;

            string nombre = textBoxNombre.Text.Trim();

            // Busca y compara los artículos en la lista de objetos recogidos
            List<Articulo> resultados = ListaArticulosBD.Where(articulo =>
                (string.IsNullOrEmpty(nombre) || articulo.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(deporte) || deporte == articulo.Deporte.ToString()) &&
                (string.IsNullOrEmpty(tipoArticulo) || tipoArticulo == articulo.TipoArticulo.ToString())
            ).ToList();

            if (resultados.Count > 0) // Comprobamos que haya reusltados válidos para la búsqueda
            {
                dataGridViewBD.DataSource = resultados;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para la búsqueda.");
            }
        }


        /**
         * Método para ELIMINAR un artículo seleccionado previamente de la lista de artículos del DataGridView.
         */
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Preguntar al usuario si realmente desea eliminar el artículo
            DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar el artículo '{articuloSeleccionado.Nombre}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                connection.GetCon();
                int id = articuloSeleccionado.Id;
                string consulta = $"DELETE FROM articulos WHERE id = {id}";

                using (MySqlCommand command = new MySqlCommand(consulta, connection.GetCon()))
                {
                    try
                    {
                        // Ejecutar la consulta para eliminar el artículo de la base de datos
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el artículo: " + ex.Message);
                    }
                }

                // Actualizar el DataGridView después de la eliminación
                CargarDatos();

                connection.CloseCon();

            }
        }

        /**
         * Método por el cual se selecciona y recoge un elemento del DataGridView.
         */
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en cualquier celda y no en los encabezados
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el objeto Articulo asociado a la fila seleccionada
                this.articuloSeleccionado = (Articulo)dataGridViewBD.Rows[e.RowIndex].DataBoundItem;
            }
        }


        /**
        * Método para MODIFICAR un artículo seleccionado previamente de la lista de artículos del DataGridView.
        */
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un artículo seleccionado
            if (articuloSeleccionado == null)
            {
                MessageBox.Show("Selecciona un artículo para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los nuevos valores de los componentes del formulario (si no se introducen nuevos valores, se mantienen los antiguos)
            string deporte = comboBoxDeporte.SelectedItem?.ToString() ?? string.Empty;
            string tipoArticulo = comboBoxTipo.SelectedItem?.ToString() ?? string.Empty;
            string nombre = string.IsNullOrEmpty(textBoxNombre.Text) ? articuloSeleccionado.Nombre : textBoxNombre.Text.Trim();
            decimal? precio = string.IsNullOrEmpty(textBoxPrecio.Text) ? articuloSeleccionado.Precio : Convert.ToDecimal(textBoxPrecio.Text);

            // Crear un nuevo objeto Articulo con los valores actualizados
            Articulo articuloActualizado = new Articulo
            {
                Id = articuloSeleccionado.Id,
                Deporte = Enum.TryParse(deporte, out Articulo.SportType deporteEnum) ? deporteEnum : articuloSeleccionado.Deporte,
                TipoArticulo = Enum.TryParse(tipoArticulo, out Articulo.ArticleType tipoArticuloEnum) ? tipoArticuloEnum : articuloSeleccionado.TipoArticulo,
                Nombre = nombre,
                Precio = precio
            };

            // Llamar al método para actualizar en la base de datos
            connection.ActualizarArticuloEnBD(articuloActualizado);

            // Actualizar la lista de artículos
            CargarDatos();
        }
        /**
         * Método para INSERTAR un artículo 
         */
        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            // Recoger los valores del formulario en variables para el nuevo Articulo
            string deporte = comboBoxDeporte.SelectedItem?.ToString() ?? string.Empty;

            string tipoArticulo = comboBoxTipo.SelectedItem?.ToString() ?? string.Empty;

            string nombre = textBoxNombre.Text.Trim();

            decimal precio = Convert.ToDecimal(textBoxPrecio.Text);

            Articulo articuloInsertado = new Articulo
            {

                Deporte = Enum.TryParse(deporte, out Articulo.SportType deporteEnum) ? deporteEnum : Articulo.SportType.otro,
                TipoArticulo = Enum.TryParse(tipoArticulo, out Articulo.ArticleType tipoArticuloEnum) ? tipoArticuloEnum : Articulo.ArticleType.articulo,
                Nombre = nombre,
                Precio = precio
            };

            // Llamar al método para actualizar en la base de datos
            connection.InsertarArticuloEnBD(articuloInsertado);

            // Actualizar la lista de artículos
            CargarDatos();

        }

        /**
         * Método para AGREGAR y SUMAR el valor total de los artículos en el carrito de la compra
         */
        private void buttonCompra_Click(object sender, EventArgs e)
        {
            // Verificar si hay un artículo seleccionado
            if (articuloSeleccionado == null)
            {
                MessageBox.Show("Selecciona un artículo para comprar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Incrementar el total de precios
            PrecioTotal += articuloSeleccionado.Precio ?? 0;

            // Mostrar el nombre del artículo seleccionado
            textBoxNombre.Text = articuloSeleccionado.Nombre;

            ListaArticulosCarrito.Add(articuloSeleccionado);

            // Actualizar el DataGridView con los artículos del carrito
            dataGridViewCarrito.DataSource = null;                   // Limpiar la fuente de datos
            dataGridViewCarrito.DataSource = ListaArticulosCarrito; // Añadimos el artículo seleccionado al carrito de compra

            dataGridViewCarrito.Columns["Id"].Visible = false;
            /**
            dataGridViewCarrito.Columns["Deporte"].Visible = false;
            dataGridViewCarrito.Columns["TipoArticulo"].Visible = false;*/


            // Mostrar el precio total en el TextBox
            textBoxTotal.Text = PrecioTotal?.ToString("C"); // Muestra el valor como moneda

        }
    }


}
