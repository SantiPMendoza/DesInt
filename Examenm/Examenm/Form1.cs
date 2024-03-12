using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Examenm
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Port=6942;Database=turnitin;Uid=root;Pwd=root;";
        private Button[] fileButtons;

        public Form1()
        {
            
            InitializeComponent();
            tabPage3.Visible = false;

            string rutaDirectorioArchivos = Path.Combine(Application.StartupPath, "FILES");
            if (Directory.Exists(rutaDirectorioArchivos))
            {
                string[] archivos = Directory.GetFiles(rutaDirectorioArchivos);
                fileButtons = new Button[archivos.Length];

                foreach (string archivo in archivos)
                {
                    comboBox1.Items.Add(Path.GetFileName(archivo));
                    comboBox2.Items.Add(Path.GetFileName(archivo));
                }

            }
            else
            {
                MessageBox.Show("La carpeta 'Files' no existe en la ubicación del proyecto.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string nombreArchivoSeleccionado = comboBox1.SelectedItem.ToString();
                string rutaCompleta = Path.Combine(Application.StartupPath, "FILES", nombreArchivoSeleccionado);

                try
                {
                    // Leer el contenido del archivo y cargarlo en el TextBox
                    string contenidoArchivo = File.ReadAllText(rutaCompleta);
                    richTextBox1.Text = contenidoArchivo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}");
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string nombreArchivoSeleccionado = comboBox1.SelectedItem.ToString();
                string rutaCompleta = Path.Combine(Application.StartupPath, "FILES", nombreArchivoSeleccionado);

                try
                {
                    // Leer el contenido del archivo y cargarlo en el TextBox
                    string contenidoArchivo = File.ReadAllText(rutaCompleta);
                    richTextBox2.Text = contenidoArchivo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingresa un nombre de usuario y una contraseña.");
                return;
            }

            if (Login(username, password))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                // Cambiar al tabPage con los botones de archivos
                tabPage3.Visible = true;
                tabControl1.TabPages.Remove(tabPage2);
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private bool Login(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Usuario WHERE username = @username AND password = @password;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    MostrarBotonesArchivos();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error de inicio de sesión: {ex.Message}");
                    return false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar TextBox
            richTextBox1.Clear();
            richTextBox2.Clear();

            // Limpiar ComboBox
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string archivo1 = comboBox1.SelectedItem?.ToString();
            string archivo2 = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(archivo1) || string.IsNullOrEmpty(archivo2))
            {
                MessageBox.Show("Por favor, seleccione un archivo en ambos ComboBox.");
                return;
            }

            try
            {
                ApiClient apiClient = new ApiClient();
                int resultado = await apiClient.CompararArchivos(archivo1, archivo2);

                // Mostrar el resultado en el Label con el símbolo de porcentaje
                label1.Text = $"El resultado de la comparación es: {resultado}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al comparar archivos: {ex.Message}");
            }
        }

        private void MostrarBotonesArchivos()
        {
            // Obtener la lista de archivos
            string rutaDirectorioArchivos = Path.Combine(Application.StartupPath, "FILES");
            string[] archivos = Directory.GetFiles(rutaDirectorioArchivos);

            // Crear un botón para cada archivo y mostrar su nombre en el botón
            foreach (string archivo in archivos)
            {
                string nombreArchivo = Path.GetFileName(archivo);

                // Crear y configurar el botón
                Button button = new Button();
                button.Text = nombreArchivo;
                button.AutoSize = true; // Permitir que el botón ajuste automáticamente su tamaño según el texto
                button.Click += (sender, e) =>
                {
                    // Manejar el evento Click del botón
                    // Por ejemplo, abrir el archivo, mostrar detalles, etc.
                };

                // Agregar el botón al tabPage3
                tabPage3.Controls.Add(button);
            }
        }

        private async Task<int> ObtenerPorcentajeDeComparacion(string archivo1, string archivo2)
        {
            // Llamar a la API para obtener el porcentaje de comparación entre archivo1 y archivo2
            ApiClient apiClient = new ApiClient();
            int porcentaje = await apiClient.CompararArchivos(archivo1, archivo2);
            return porcentaje;
        }

    }
}