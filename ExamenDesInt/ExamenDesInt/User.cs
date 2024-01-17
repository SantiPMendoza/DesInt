using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDesInt
{
    public partial class User : Form
    {
        private string path = "FILES";
        static List<Archivo> archivos;
        private string[] names;
        private string content;
        public User()
        {

            InitializeComponent();
            Generar();
        }
        private void Generar()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            names = Directory.GetFileSystemEntries(path);
            
            archivos = new List<Archivo>();
            for (int i = 0; i < names.Length; i++)
            {
                
                    content = ""+File.ReadAllText(path);
                //content=archivito.Content;

                new Archivo={ Name = names[i],Content = File.ReadAllText(path)};
                
            }
            comboBox1.Items.AddRange(names);
            comboBox2.Items.AddRange(names);

            // Set default selection
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update labels based on the selected country
            int selectedIndex1 = comboBox1.SelectedIndex;
            int selectedIndex2 = comboBox2.SelectedIndex;

            label1.Text = $"{archivos[selectedIndex1].Content}";
            label2.Text = $"{archivos[selectedIndex2].Content}";

        }

    }
    public class Archivo
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
