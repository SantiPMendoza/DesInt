using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionArchivos
{
    public partial class MenuAbrir : Form
    {

        private PictureBox pictureBox;
 
            
        private string files = "FILES";

        public MenuAbrir()
        {
            InitializeComponent();
            this.Load += MenuAbrir_Load;
        }

        private void MenuAbrir_Load(object sender, EventArgs e)
        {
            Generar();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Generar()
        {
            if (!Directory.Exists(files))
            {
                Directory.CreateDirectory(files);
            }

            string[] archivos = Directory.GetFileSystemEntries(files);

            for (int i = 0; i < archivos.Length; i++)
            {
                bool esDir = Directory.Exists(archivos[i]);

                Panel filePanel = new Panel();
                filePanel.Size = new Size(100, 150);
                filePanel.AutoSize = false;

                PictureBox pictureBox = new PictureBox();
                try
                {
                    if (esDir)
                    {
                        pictureBox.Image = global::GestionArchivos.Properties.Resources.directorio;
                        Console.WriteLine("Directorio");
                    }
                    else
                    {
                        pictureBox.Image = global::GestionArchivos.Properties.Resources.archivo;
                        Console.WriteLine("Archivo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                }

                //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(100, 100);
                pictureBox.Dock = DockStyle.Top;

                Label nameLabel = new Label();
                nameLabel.Text = Path.GetFileName(archivos[i]);
                nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                nameLabel.Dock = DockStyle.Bottom;
                nameLabel.Size = new Size(100, 50);

                filePanel.Controls.Add(pictureBox);
                filePanel.Controls.Add(nameLabel);

                flowLayoutPanel1.Controls.Add(filePanel);
            }
        }

        private void crearArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFile createFile=new CreateFile();
            createFile.Show();
        }

        private void crearDirectorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDirectory createDirectory = new CreateDirectory();
            createDirectory.Show();
        }
    }
}
