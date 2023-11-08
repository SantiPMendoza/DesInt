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
        string files = "FILES";
        private PictureBox pictureBoxFile;
        private PictureBox pictureBoxDir;
        public MenuAbrir()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Controls.Clear();

            if (!Directory.Exists(files))
            {
                Directory.CreateDirectory(files);

            }
            string[] archivos = Directory.GetFiles(files);
            string[] directorios = Directory.GetDirectories(files);

            for (int i = 0; i < archivos.Length; i++)
            {
                for(int j = 0; j < directorios.Length; j++)
                {
                    pictureBoxFile = new PictureBox();
                    pictureBoxFile.Image = Properties.Resources.archivo;
                    pictureBoxFile.Location = new Point(i * 100, 0);
                    pictureBoxFile.Name = "pictureBoxFile" + i;
                    pictureBoxFile.Size = new Size(100, 100);
                    Controls.Add(pictureBoxFile);

                }
            }
        }
    }
}
