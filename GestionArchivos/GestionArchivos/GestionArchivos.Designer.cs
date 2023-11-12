namespace GestionArchivos
{
    partial class GestionArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionArchivos));
            menu = new ToolStrip();
            infoButton = new ToolStripButton();
            fileButton = new ToolStripDropDownButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
            panel1 = new Panel();
            menu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = SystemColors.ControlLight;
            menu.CanOverflow = false;
            menu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menu.Items.AddRange(new ToolStripItem[] { infoButton, fileButton });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(854, 25);
            menu.Stretch = true;
            menu.TabIndex = 1;
            menu.Text = "toolStrip1";
            // 
            // infoButton
            // 
            infoButton.AutoSize = false;
            infoButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            infoButton.Image = (Image)resources.GetObject("infoButton.Image");
            infoButton.ImageTransparentColor = Color.Magenta;
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(64, 22);
            infoButton.Text = "Info";
            infoButton.Click += toolStripButton1_Click_1;
            // 
            // fileButton
            // 
            fileButton.AutoSize = false;
            fileButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileButton.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2, toolStripTextBox3 });
            fileButton.Image = (Image)resources.GetObject("fileButton.Image");
            fileButton.ImageTransparentColor = Color.Magenta;
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(76, 22);
            fileButton.Text = "File";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "Guardar";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            toolStripTextBox2.Text = "Borrar";
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(100, 23);
            toolStripTextBox3.Text = "Abrir";
            toolStripTextBox3.Click += toolStripTextBox3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(menu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 474);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(854, 474);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolStrip menu;
        private ToolStripButton infoButton;
        private ToolStripDropDownButton fileButton;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox toolStripTextBox3;
        private Panel panel1;
    }
}