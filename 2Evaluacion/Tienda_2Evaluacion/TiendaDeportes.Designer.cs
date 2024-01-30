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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiendaDeportes));
            panelEncabezado = new Panel();
            panelContent = new Panel();
            panelBottom = new Panel();
            plotView = new OxyPlot.WindowsForms.PlotView();
            dataGridViewBD = new DataGridView();
            panelBotones = new Panel();
            dataGridViewCarrito = new DataGridView();
            labelTotal = new Label();
            textBoxTotal = new TextBox();
            buttonCompra = new Button();
            comboBoxTipo = new ComboBox();
            buttonInsertar = new Button();
            labelDeporte = new Label();
            buttonEliminar = new Button();
            labelTipo = new Label();
            buttonModificar = new Button();
            labelNombre = new Label();
            buttonBuscar = new Button();
            labelPrecio = new Label();
            textBoxNombre = new TextBox();
            comboBoxDeporte = new ComboBox();
            textBoxPrecio = new TextBox();
            panelContent.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBD).BeginInit();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).BeginInit();
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.BackgroundImage = (Image)resources.GetObject("panelEncabezado.BackgroundImage");
            panelEncabezado.BackgroundImageLayout = ImageLayout.Stretch;
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(934, 75);
            panelEncabezado.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.DarkSlateBlue;
            panelContent.Controls.Add(panelBottom);
            panelContent.Controls.Add(panelBotones);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 75);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(934, 586);
            panelContent.TabIndex = 1;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(plotView);
            panelBottom.Controls.Add(dataGridViewBD);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 231);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(934, 355);
            panelBottom.TabIndex = 13;
            // 
            // plotView
            // 
            plotView.BackColor = Color.LightSteelBlue;
            plotView.Dock = DockStyle.Fill;
            plotView.ForeColor = Color.Transparent;
            plotView.Location = new Point(525, 0);
            plotView.Name = "plotView";
            plotView.PanCursor = Cursors.Hand;
            plotView.Size = new Size(409, 355);
            plotView.TabIndex = 5;
            plotView.Text = "plotView";
            plotView.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // dataGridViewBD
            // 
            dataGridViewBD.BackgroundColor = Color.White;
            dataGridViewBD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBD.Dock = DockStyle.Left;
            dataGridViewBD.Location = new Point(0, 0);
            dataGridViewBD.Name = "dataGridViewBD";
            dataGridViewBD.Size = new Size(525, 355);
            dataGridViewBD.TabIndex = 4;
            dataGridViewBD.CellClick += dataGridView1_CellClick;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(dataGridViewCarrito);
            panelBotones.Controls.Add(labelTotal);
            panelBotones.Controls.Add(textBoxTotal);
            panelBotones.Controls.Add(buttonCompra);
            panelBotones.Controls.Add(comboBoxTipo);
            panelBotones.Controls.Add(buttonInsertar);
            panelBotones.Controls.Add(labelDeporte);
            panelBotones.Controls.Add(buttonEliminar);
            panelBotones.Controls.Add(labelTipo);
            panelBotones.Controls.Add(buttonModificar);
            panelBotones.Controls.Add(labelNombre);
            panelBotones.Controls.Add(buttonBuscar);
            panelBotones.Controls.Add(labelPrecio);
            panelBotones.Controls.Add(textBoxNombre);
            panelBotones.Controls.Add(comboBoxDeporte);
            panelBotones.Controls.Add(textBoxPrecio);
            panelBotones.Dock = DockStyle.Top;
            panelBotones.Location = new Point(0, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(934, 231);
            panelBotones.TabIndex = 13;
            // 
            // dataGridViewCarrito
            // 
            dataGridViewCarrito.BackgroundColor = Color.White;
            dataGridViewCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrito.Dock = DockStyle.Right;
            dataGridViewCarrito.Location = new Point(525, 0);
            dataGridViewCarrito.Name = "dataGridViewCarrito";
            dataGridViewCarrito.Size = new Size(409, 231);
            dataGridViewCarrito.TabIndex = 17;
            // 
            // labelTotal
            // 
            labelTotal.BorderStyle = BorderStyle.Fixed3D;
            labelTotal.ForeColor = Color.Transparent;
            labelTotal.Location = new Point(410, 74);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(80, 20);
            labelTotal.TabIndex = 16;
            labelTotal.Text = "Precio Total";
            labelTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(410, 106);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(80, 23);
            textBoxTotal.TabIndex = 15;
            textBoxTotal.Text = "0";
            // 
            // buttonCompra
            // 
            buttonCompra.BackColor = Color.MidnightBlue;
            buttonCompra.ForeColor = Color.Transparent;
            buttonCompra.Location = new Point(410, 142);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(80, 61);
            buttonCompra.TabIndex = 13;
            buttonCompra.Text = "Comprar";
            buttonCompra.UseVisualStyleBackColor = false;
            buttonCompra.Click += buttonCompra_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { Articulo.ArticleType.accesorio, Articulo.ArticleType.ropa, Articulo.ArticleType.zapatillas, Articulo.ArticleType.articulo });
            comboBoxTipo.Location = new Point(105, 68);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 8;
            // 
            // buttonInsertar
            // 
            buttonInsertar.BackColor = Color.MidnightBlue;
            buttonInsertar.ForeColor = Color.Transparent;
            buttonInsertar.Location = new Point(294, 174);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(75, 23);
            buttonInsertar.TabIndex = 12;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = false;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // labelDeporte
            // 
            labelDeporte.BorderStyle = BorderStyle.Fixed3D;
            labelDeporte.ForeColor = Color.Transparent;
            labelDeporte.Location = new Point(19, 29);
            labelDeporte.Name = "labelDeporte";
            labelDeporte.Size = new Size(80, 20);
            labelDeporte.TabIndex = 0;
            labelDeporte.Text = "Deporte";
            labelDeporte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.MidnightBlue;
            buttonEliminar.ForeColor = Color.Transparent;
            buttonEliminar.Location = new Point(294, 122);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 11;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelTipo
            // 
            labelTipo.BorderStyle = BorderStyle.Fixed3D;
            labelTipo.ForeColor = Color.Transparent;
            labelTipo.Location = new Point(19, 69);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(80, 20);
            labelTipo.TabIndex = 1;
            labelTipo.Text = "Tipo_Articulo";
            labelTipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.MidnightBlue;
            buttonModificar.ForeColor = Color.Transparent;
            buttonModificar.Location = new Point(294, 71);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 10;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // labelNombre
            // 
            labelNombre.BorderStyle = BorderStyle.Fixed3D;
            labelNombre.ForeColor = Color.Transparent;
            labelNombre.Location = new Point(19, 121);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(80, 20);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            labelNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.MidnightBlue;
            buttonBuscar.ForeColor = Color.Transparent;
            buttonBuscar.Location = new Point(294, 27);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 9;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // labelPrecio
            // 
            labelPrecio.BorderStyle = BorderStyle.Fixed3D;
            labelPrecio.ForeColor = Color.Transparent;
            labelPrecio.Location = new Point(19, 172);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(80, 20);
            labelPrecio.TabIndex = 3;
            labelPrecio.Text = "Precio";
            labelPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(105, 119);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(121, 23);
            textBoxNombre.TabIndex = 5;
            // 
            // comboBoxDeporte
            // 
            comboBoxDeporte.FormattingEnabled = true;
            comboBoxDeporte.Items.AddRange(new object[] { Articulo.SportType.futbol, Articulo.SportType.baloncesto, Articulo.SportType.tenis, Articulo.SportType.esqui, Articulo.SportType.boxeo, Articulo.SportType.otro });
            comboBoxDeporte.Location = new Point(105, 27);
            comboBoxDeporte.Name = "comboBoxDeporte";
            comboBoxDeporte.Size = new Size(121, 23);
            comboBoxDeporte.TabIndex = 7;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(105, 171);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(121, 23);
            textBoxPrecio.TabIndex = 6;
            // 
            // TiendaDeportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(934, 661);
            Controls.Add(panelContent);
            Controls.Add(panelEncabezado);
            ForeColor = SystemColors.ControlText;
            Name = "TiendaDeportes";
            Text = "Sportanus";
            panelContent.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBD).EndInit();
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEncabezado;
        private Panel panelContent;
        private DataGridView dataGridViewBD;
        private Label labelPrecio;
        private Label labelNombre;
        private Label labelTipo;
        private Label labelDeporte;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxDeporte;
        private TextBox textBoxPrecio;
        private TextBox textBoxNombre;
        private Button buttonBuscar;
        private Button buttonEliminar;
        private Button buttonModificar;
        private Button buttonInsertar;
        private Panel panelBotones;
        private Panel panelBottom;
        private OxyPlot.WindowsForms.PlotView plotView;
        private Label labelTotal;
        private TextBox textBoxTotal;
        private Button buttonCompra;
        private DataGridView dataGridViewCarrito;
    }
}
