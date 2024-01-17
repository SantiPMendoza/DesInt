namespace OnlyZoo
{
    partial class CatalogoMascotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 33);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(lblLogo);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(764, 46);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(467, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(430, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 23);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoEllipsis = true;
            lblLogo.AutoSize = true;
            lblLogo.Dock = DockStyle.Left;
            lblLogo.Font = new Font("Stencil", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(165, 42);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "OnlyZoo";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            lblLogo.Click += label1_Click_1;
            // 
            // CatalogoMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 548);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "CatalogoMascotas";
            Text = "CatalogoMascotas";
            Load += CatalogoMascotas_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label lblLogo;
    }
}