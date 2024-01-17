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
            panelSearch = new Panel();
            labelFilterBy = new Label();
            pictureBoxSearch = new PictureBox();
            textBoxSearch = new TextBox();
            menuStripFilterBy = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            breedToolStripMenuItem = new ToolStripMenuItem();
            speciesToolStripMenuItem = new ToolStripMenuItem();
            dogsToolStripMenuItem = new ToolStripMenuItem();
            labradorToolStripMenuItem = new ToolStripMenuItem();
            germanShepperdToolStripMenuItem = new ToolStripMenuItem();
            rotweillerToolStripMenuItem = new ToolStripMenuItem();
            chihuahuaToolStripMenuItem = new ToolStripMenuItem();
            pomeranianToolStripMenuItem = new ToolStripMenuItem();
            catsToolStripMenuItem = new ToolStripMenuItem();
            egyptianToolStripMenuItem = new ToolStripMenuItem();
            brownToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            blondeToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            rodentsToolStripMenuItem = new ToolStripMenuItem();
            hamsterToolStripMenuItem = new ToolStripMenuItem();
            guineanPigToolStripMenuItem = new ToolStripMenuItem();
            chinchillaToolStripMenuItem = new ToolStripMenuItem();
            gerbilsToolStripMenuItem = new ToolStripMenuItem();
            horsesToolStripMenuItem = new ToolStripMenuItem();
            turtlesToolStripMenuItem = new ToolStripMenuItem();
            fishesToolStripMenuItem = new ToolStripMenuItem();
            goldfishToolStripMenuItem = new ToolStripMenuItem();
            bettaToolStripMenuItem = new ToolStripMenuItem();
            swordtailToolStripMenuItem = new ToolStripMenuItem();
            tagToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            menuStripFilterBy.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 48);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(labelFilterBy);
            panelSearch.Controls.Add(pictureBoxSearch);
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Controls.Add(menuStripFilterBy);
            panelSearch.Location = new Point(0, 48);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(800, 26);
            panelSearch.TabIndex = 1;
            panelSearch.Paint += panelSearch_Paint;
            // 
            // labelFilterBy
            // 
            labelFilterBy.BackColor = Color.LightSalmon;
            labelFilterBy.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelFilterBy.Location = new Point(0, 0);
            labelFilterBy.Name = "labelFilterBy";
            labelFilterBy.Size = new Size(72, 26);
            labelFilterBy.TabIndex = 2;
            labelFilterBy.Text = "Filter by:";
            labelFilterBy.TextAlign = ContentAlignment.MiddleCenter;
            labelFilterBy.Click += label1_Click;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Dock = DockStyle.Right;
            pictureBoxSearch.Location = new Point(535, 0);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(34, 26);
            pictureBoxSearch.TabIndex = 1;
            pictureBoxSearch.TabStop = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Right;
            textBoxSearch.Location = new Point(569, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(231, 23);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.Text = "Search...";
            // 
            // menuStripFilterBy
            // 
            menuStripFilterBy.Dock = DockStyle.None;
            menuStripFilterBy.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, breedToolStripMenuItem, speciesToolStripMenuItem, tagToolStripMenuItem });
            menuStripFilterBy.Location = new Point(0, 0);
            menuStripFilterBy.Name = "menuStripFilterBy";
            menuStripFilterBy.Size = new Size(164, 30);
            menuStripFilterBy.TabIndex = 3;
            menuStripFilterBy.Text = "Breed";
            menuStripFilterBy.ItemClicked += menuStripFilterBy_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 26);
            // 
            // breedToolStripMenuItem
            // 
            breedToolStripMenuItem.Name = "breedToolStripMenuItem";
            breedToolStripMenuItem.Size = new Size(49, 26);
            breedToolStripMenuItem.Text = "Breed";
            // 
            // speciesToolStripMenuItem
            // 
            speciesToolStripMenuItem.AutoSize = false;
            speciesToolStripMenuItem.BackColor = Color.Coral;
            speciesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dogsToolStripMenuItem, catsToolStripMenuItem, rodentsToolStripMenuItem, horsesToolStripMenuItem, turtlesToolStripMenuItem, fishesToolStripMenuItem });
            speciesToolStripMenuItem.Name = "speciesToolStripMenuItem";
            speciesToolStripMenuItem.Size = new Size(58, 26);
            speciesToolStripMenuItem.Text = "Species";
            // 
            // dogsToolStripMenuItem
            // 
            dogsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { labradorToolStripMenuItem, germanShepperdToolStripMenuItem, rotweillerToolStripMenuItem, chihuahuaToolStripMenuItem, pomeranianToolStripMenuItem });
            dogsToolStripMenuItem.Name = "dogsToolStripMenuItem";
            dogsToolStripMenuItem.Size = new Size(117, 22);
            dogsToolStripMenuItem.Text = "Dogs";
            // 
            // labradorToolStripMenuItem
            // 
            labradorToolStripMenuItem.Name = "labradorToolStripMenuItem";
            labradorToolStripMenuItem.Size = new Size(169, 22);
            labradorToolStripMenuItem.Text = "Labrador";
            // 
            // germanShepperdToolStripMenuItem
            // 
            germanShepperdToolStripMenuItem.Name = "germanShepperdToolStripMenuItem";
            germanShepperdToolStripMenuItem.Size = new Size(169, 22);
            germanShepperdToolStripMenuItem.Text = "German Shepperd";
            // 
            // rotweillerToolStripMenuItem
            // 
            rotweillerToolStripMenuItem.Name = "rotweillerToolStripMenuItem";
            rotweillerToolStripMenuItem.Size = new Size(169, 22);
            rotweillerToolStripMenuItem.Text = "Rotweiller";
            // 
            // chihuahuaToolStripMenuItem
            // 
            chihuahuaToolStripMenuItem.Name = "chihuahuaToolStripMenuItem";
            chihuahuaToolStripMenuItem.Size = new Size(169, 22);
            chihuahuaToolStripMenuItem.Text = "Chihuahua";
            // 
            // pomeranianToolStripMenuItem
            // 
            pomeranianToolStripMenuItem.Name = "pomeranianToolStripMenuItem";
            pomeranianToolStripMenuItem.Size = new Size(169, 22);
            pomeranianToolStripMenuItem.Text = "Pomeranian";
            // 
            // catsToolStripMenuItem
            // 
            catsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { egyptianToolStripMenuItem, brownToolStripMenuItem, blackToolStripMenuItem, blondeToolStripMenuItem, whiteToolStripMenuItem });
            catsToolStripMenuItem.Name = "catsToolStripMenuItem";
            catsToolStripMenuItem.Size = new Size(117, 22);
            catsToolStripMenuItem.Text = "Cats";
            // 
            // egyptianToolStripMenuItem
            // 
            egyptianToolStripMenuItem.Name = "egyptianToolStripMenuItem";
            egyptianToolStripMenuItem.Size = new Size(120, 22);
            egyptianToolStripMenuItem.Text = "Egyptian";
            // 
            // brownToolStripMenuItem
            // 
            brownToolStripMenuItem.Name = "brownToolStripMenuItem";
            brownToolStripMenuItem.Size = new Size(120, 22);
            brownToolStripMenuItem.Text = "Brown";
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(120, 22);
            blackToolStripMenuItem.Text = "Black";
            // 
            // blondeToolStripMenuItem
            // 
            blondeToolStripMenuItem.Name = "blondeToolStripMenuItem";
            blondeToolStripMenuItem.Size = new Size(120, 22);
            blondeToolStripMenuItem.Text = "Blonde";
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(120, 22);
            whiteToolStripMenuItem.Text = "White";
            // 
            // rodentsToolStripMenuItem
            // 
            rodentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hamsterToolStripMenuItem, guineanPigToolStripMenuItem, chinchillaToolStripMenuItem, gerbilsToolStripMenuItem });
            rodentsToolStripMenuItem.Name = "rodentsToolStripMenuItem";
            rodentsToolStripMenuItem.Size = new Size(117, 22);
            rodentsToolStripMenuItem.Text = "Rodents";
            // 
            // hamsterToolStripMenuItem
            // 
            hamsterToolStripMenuItem.Name = "hamsterToolStripMenuItem";
            hamsterToolStripMenuItem.Size = new Size(143, 22);
            hamsterToolStripMenuItem.Text = "Hamsters";
            // 
            // guineanPigToolStripMenuItem
            // 
            guineanPigToolStripMenuItem.Name = "guineanPigToolStripMenuItem";
            guineanPigToolStripMenuItem.Size = new Size(143, 22);
            guineanPigToolStripMenuItem.Text = "Guinean Pigs";
            // 
            // chinchillaToolStripMenuItem
            // 
            chinchillaToolStripMenuItem.Name = "chinchillaToolStripMenuItem";
            chinchillaToolStripMenuItem.Size = new Size(143, 22);
            chinchillaToolStripMenuItem.Text = "Chinchillas";
            // 
            // gerbilsToolStripMenuItem
            // 
            gerbilsToolStripMenuItem.Name = "gerbilsToolStripMenuItem";
            gerbilsToolStripMenuItem.Size = new Size(143, 22);
            gerbilsToolStripMenuItem.Text = "Gerbils";
            // 
            // horsesToolStripMenuItem
            // 
            horsesToolStripMenuItem.Name = "horsesToolStripMenuItem";
            horsesToolStripMenuItem.Size = new Size(117, 22);
            horsesToolStripMenuItem.Text = "Horses";
            // 
            // turtlesToolStripMenuItem
            // 
            turtlesToolStripMenuItem.Name = "turtlesToolStripMenuItem";
            turtlesToolStripMenuItem.Size = new Size(117, 22);
            turtlesToolStripMenuItem.Text = "Turtles";
            // 
            // fishesToolStripMenuItem
            // 
            fishesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { goldfishToolStripMenuItem, bettaToolStripMenuItem, swordtailToolStripMenuItem });
            fishesToolStripMenuItem.Name = "fishesToolStripMenuItem";
            fishesToolStripMenuItem.Size = new Size(117, 22);
            fishesToolStripMenuItem.Text = "Fishes";
            // 
            // goldfishToolStripMenuItem
            // 
            goldfishToolStripMenuItem.Name = "goldfishToolStripMenuItem";
            goldfishToolStripMenuItem.Size = new Size(123, 22);
            goldfishToolStripMenuItem.Text = "Goldfish";
            goldfishToolStripMenuItem.Click += goldfishToolStripMenuItem_Click;
            // 
            // bettaToolStripMenuItem
            // 
            bettaToolStripMenuItem.Name = "bettaToolStripMenuItem";
            bettaToolStripMenuItem.Size = new Size(123, 22);
            bettaToolStripMenuItem.Text = "Betta";
            bettaToolStripMenuItem.Click += bettaToolStripMenuItem_Click;
            // 
            // swordtailToolStripMenuItem
            // 
            swordtailToolStripMenuItem.Name = "swordtailToolStripMenuItem";
            swordtailToolStripMenuItem.Size = new Size(123, 22);
            swordtailToolStripMenuItem.Text = "Swordtail";
            // 
            // tagToolStripMenuItem
            // 
            tagToolStripMenuItem.AutoSize = false;
            tagToolStripMenuItem.BackColor = Color.Salmon;
            tagToolStripMenuItem.Name = "tagToolStripMenuItem";
            tagToolStripMenuItem.Size = new Size(37, 26);
            tagToolStripMenuItem.Text = "Tag";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.PeachPuff;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 77);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 373);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // CatalogoMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelSearch);
            Controls.Add(panel1);
            Name = "CatalogoMascotas";
            Text = "CatalogoMascotas";
            Load += CatalogoMascotas_Load;
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            menuStripFilterBy.ResumeLayout(false);
            menuStripFilterBy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelSearch;
        private PictureBox pictureBoxSearch;
        private TextBox textBoxSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelFilterBy;
        private MenuStrip menuStripFilterBy;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem breedToolStripMenuItem;
        private ToolStripMenuItem speciesToolStripMenuItem;
        private ToolStripMenuItem dogsToolStripMenuItem;
        private ToolStripMenuItem labradorToolStripMenuItem;
        private ToolStripMenuItem germanShepperdToolStripMenuItem;
        private ToolStripMenuItem rotweillerToolStripMenuItem;
        private ToolStripMenuItem chihuahuaToolStripMenuItem;
        private ToolStripMenuItem pomeranianToolStripMenuItem;
        private ToolStripMenuItem catsToolStripMenuItem;
        private ToolStripMenuItem egyptianToolStripMenuItem;
        private ToolStripMenuItem brownToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem blondeToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem rodentsToolStripMenuItem;
        private ToolStripMenuItem hamsterToolStripMenuItem;
        private ToolStripMenuItem guineanPigToolStripMenuItem;
        private ToolStripMenuItem chinchillaToolStripMenuItem;
        private ToolStripMenuItem gerbilsToolStripMenuItem;
        private ToolStripMenuItem horsesToolStripMenuItem;
        private ToolStripMenuItem turtlesToolStripMenuItem;
        private ToolStripMenuItem fishesToolStripMenuItem;
        private ToolStripMenuItem goldfishToolStripMenuItem;
        private ToolStripMenuItem bettaToolStripMenuItem;
        private ToolStripMenuItem swordtailToolStripMenuItem;
        private ToolStripMenuItem tagToolStripMenuItem;
    }
}