using Tienda_2Evaluacion.Model;

namespace Tienda_2Evaluacion
{
    partial class TiendaDeportes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonBuscar = new Button();
            comboBoxTipo = new ComboBox();
            comboBoxDeporte = new ComboBox();
            textBoxPrecio = new TextBox();
            textBoxNombre = new TextBox();
            dataGridView1 = new DataGridView();
            labelPrecio = new Label();
            labelNombre = new Label();
            labelTipo = new Label();
            labelDeporte = new Label();
            articuloBindingSource1 = new BindingSource(components);
            articuloBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 48);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonBuscar);
            panel2.Controls.Add(comboBoxTipo);
            panel2.Controls.Add(comboBoxDeporte);
            panel2.Controls.Add(textBoxPrecio);
            panel2.Controls.Add(textBoxNombre);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(labelPrecio);
            panel2.Controls.Add(labelNombre);
            panel2.Controls.Add(labelTipo);
            panel2.Controls.Add(labelDeporte);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 402);
            panel2.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(287, 9);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 9;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += button1_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { Articulo.ArticleType.accesorio, Articulo.ArticleType.ropa, Articulo.ArticleType.zapatillas, Articulo.ArticleType.articulo });
            comboBoxTipo.Location = new Point(89, 45);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 8;
            // 
            // comboBoxDeporte
            // 
            comboBoxDeporte.FormattingEnabled = true;
            comboBoxDeporte.Items.AddRange(new object[] { Articulo.SportType.futbol, Articulo.SportType.baloncesto, Articulo.SportType.tenis, Articulo.SportType.esqui, Articulo.SportType.boxeo, Articulo.SportType.otro });
            comboBoxDeporte.Location = new Point(89, 9);
            comboBoxDeporte.Name = "comboBoxDeporte";
            comboBoxDeporte.Size = new Size(121, 23);
            comboBoxDeporte.TabIndex = 7;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(89, 119);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(121, 23);
            textBoxPrecio.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(89, 81);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(121, 23);
            textBoxNombre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 235);
            dataGridView1.TabIndex = 4;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(32, 122);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(40, 15);
            labelPrecio.TabIndex = 3;
            labelPrecio.Text = "Precio";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(34, 84);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(12, 48);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(77, 15);
            labelTipo.TabIndex = 1;
            labelTipo.Text = "Tipo_Articulo";
            // 
            // labelDeporte
            // 
            labelDeporte.AutoSize = true;
            labelDeporte.Location = new Point(34, 12);
            labelDeporte.Name = "labelDeporte";
            labelDeporte.Size = new Size(49, 15);
            labelDeporte.TabIndex = 0;
            labelDeporte.Text = "Deporte";
            // 
            // articuloBindingSource1
            // 
            articuloBindingSource1.DataSource = typeof(Articulo);
            // 
            // articuloBindingSource
            // 
            articuloBindingSource.DataSource = typeof(Articulo);
            // 
            // TiendaDeportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TiendaDeportes";
            Text = "Sportanus";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)articuloBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label labelPrecio;
        private Label labelNombre;
        private Label labelTipo;
        private Label labelDeporte;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxDeporte;
        private TextBox textBoxPrecio;
        private TextBox textBoxNombre;
        private BindingSource articuloBindingSource;
        private BindingSource articuloBindingSource1;
        private Button buttonBuscar;
    }
}
