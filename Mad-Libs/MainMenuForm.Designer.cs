namespace Mad_Libs_App
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            pictureBox1 = new PictureBox();
            labelTableContents = new Label();
            labelTitle3 = new Label();
            labelTitle1 = new Label();
            labelTitle2 = new Label();
            labelCredits = new Label();
            labelCC = new Label();
            labelKC = new Label();
            labelML = new Label();
            labelJC = new Label();
            labelAE = new Label();
            labelAuthors = new Label();
            labelCP = new Label();
            labelThemeStories = new Label();
            labelOgStories = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panelTitleMenu = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTitleMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(732, 563);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelTableContents
            // 
            labelTableContents.AutoSize = true;
            labelTableContents.BackColor = Color.FromArgb(238, 189, 138);
            labelTableContents.Font = new Font("KimsBitHand", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTableContents.Location = new Point(41, 120);
            labelTableContents.Name = "labelTableContents";
            labelTableContents.Size = new Size(185, 19);
            labelTableContents.TabIndex = 2;
            labelTableContents.Text = "Table of Contents";
            // 
            // labelTitle3
            // 
            labelTitle3.AutoSize = true;
            labelTitle3.BackColor = Color.FromArgb(238, 189, 138);
            labelTitle3.Font = new Font("KimsBitHand", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle3.Location = new Point(86, 67);
            labelTitle3.Name = "labelTitle3";
            labelTitle3.Size = new Size(104, 24);
            labelTitle3.TabIndex = 3;
            labelTitle3.Text = "MadLibs";
            // 
            // labelTitle1
            // 
            labelTitle1.AutoSize = true;
            labelTitle1.BackColor = Color.FromArgb(238, 189, 138);
            labelTitle1.Font = new Font("KimsBitHand", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle1.Location = new Point(86, 21);
            labelTitle1.Name = "labelTitle1";
            labelTitle1.Size = new Size(107, 24);
            labelTitle1.TabIndex = 4;
            labelTitle1.Text = "Big Book";
            // 
            // labelTitle2
            // 
            labelTitle2.AutoSize = true;
            labelTitle2.BackColor = Color.FromArgb(238, 189, 138);
            labelTitle2.Font = new Font("KimsBitHand", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle2.Location = new Point(117, 43);
            labelTitle2.Name = "labelTitle2";
            labelTitle2.Size = new Size(35, 24);
            labelTitle2.TabIndex = 5;
            labelTitle2.Text = "of";
            // 
            // labelCredits
            // 
            labelCredits.AutoSize = true;
            labelCredits.BackColor = Color.FromArgb(238, 189, 138);
            labelCredits.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCredits.Location = new Point(28, 199);
            labelCredits.Name = "labelCredits";
            labelCredits.Size = new Size(229, 16);
            labelCredits.TabIndex = 6;
            labelCredits.Text = "Credits.................................###";
            labelCredits.Click += labelCredits_Click;
            // 
            // labelCC
            // 
            labelCC.AutoSize = true;
            labelCC.BackColor = Color.FromArgb(238, 189, 138);
            labelCC.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCC.Location = new Point(49, 120);
            labelCC.Name = "labelCC";
            labelCC.Size = new Size(147, 16);
            labelCC.TabIndex = 7;
            labelCC.Text = "Campbell Chudley";
            // 
            // labelKC
            // 
            labelKC.AutoSize = true;
            labelKC.BackColor = Color.FromArgb(238, 189, 138);
            labelKC.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKC.Location = new Point(49, 143);
            labelKC.Name = "labelKC";
            labelKC.Size = new Size(145, 16);
            labelKC.TabIndex = 8;
            labelKC.Text = "Keyla Christopher";
            // 
            // labelML
            // 
            labelML.AutoSize = true;
            labelML.BackColor = Color.FromArgb(238, 189, 138);
            labelML.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelML.Location = new Point(73, 199);
            labelML.Name = "labelML";
            labelML.Size = new Size(110, 16);
            labelML.TabIndex = 9;
            labelML.Text = "Morgan Lowe";
            // 
            // labelJC
            // 
            labelJC.AutoSize = true;
            labelJC.BackColor = Color.FromArgb(238, 189, 138);
            labelJC.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJC.Location = new Point(55, 94);
            labelJC.Name = "labelJC";
            labelJC.Size = new Size(111, 16);
            labelJC.TabIndex = 10;
            labelJC.Text = "Judy Chavez";
            // 
            // labelAE
            // 
            labelAE.AutoSize = true;
            labelAE.BackColor = Color.FromArgb(238, 189, 138);
            labelAE.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAE.Location = new Point(40, 167);
            labelAE.Name = "labelAE";
            labelAE.Size = new Size(156, 16);
            labelAE.TabIndex = 11;
            labelAE.Text = "Alexander Escobar";
            // 
            // labelAuthors
            // 
            labelAuthors.AutoSize = true;
            labelAuthors.BackColor = Color.FromArgb(238, 189, 138);
            labelAuthors.Font = new Font("KimsBitHand", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAuthors.Location = new Point(78, 21);
            labelAuthors.Name = "labelAuthors";
            labelAuthors.Size = new Size(88, 21);
            labelAuthors.TabIndex = 12;
            labelAuthors.Text = "Authors";
            // 
            // labelCP
            // 
            labelCP.AutoSize = true;
            labelCP.BackColor = Color.FromArgb(238, 189, 138);
            labelCP.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCP.Location = new Point(78, 226);
            labelCP.Name = "labelCP";
            labelCP.Size = new Size(88, 16);
            labelCP.TabIndex = 13;
            labelCP.Text = "Cole Prine";
            // 
            // labelThemeStories
            // 
            labelThemeStories.AutoSize = true;
            labelThemeStories.BackColor = Color.FromArgb(238, 189, 138);
            labelThemeStories.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelThemeStories.Location = new Point(29, 183);
            labelThemeStories.Name = "labelThemeStories";
            labelThemeStories.Size = new Size(228, 16);
            labelThemeStories.TabIndex = 14;
            labelThemeStories.Text = "Themed Stories...................##";
            labelThemeStories.Click += labelThemeStories_Click;
            // 
            // labelOgStories
            // 
            labelOgStories.AutoSize = true;
            labelOgStories.BackColor = Color.FromArgb(238, 189, 138);
            labelOgStories.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOgStories.Location = new Point(29, 167);
            labelOgStories.Name = "labelOgStories";
            labelOgStories.Size = new Size(214, 16);
            labelOgStories.TabIndex = 15;
            labelOgStories.Text = "Original Stories...................#";
            labelOgStories.Click += labelOgStories_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(238, 189, 138);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(78, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 24);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(238, 189, 138);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(64, 135);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 24);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // panelTitleMenu
            // 
            panelTitleMenu.BackColor = Color.FromArgb(238, 189, 138);
            panelTitleMenu.Controls.Add(labelTitle1);
            panelTitleMenu.Controls.Add(pictureBox3);
            panelTitleMenu.Controls.Add(labelCredits);
            panelTitleMenu.Controls.Add(labelTitle2);
            panelTitleMenu.Controls.Add(labelThemeStories);
            panelTitleMenu.Controls.Add(labelOgStories);
            panelTitleMenu.Controls.Add(labelTitle3);
            panelTitleMenu.Controls.Add(labelTableContents);
            panelTitleMenu.Location = new Point(409, 111);
            panelTitleMenu.Name = "panelTitleMenu";
            panelTitleMenu.Size = new Size(267, 309);
            panelTitleMenu.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 189, 138);
            panel1.Controls.Add(labelAuthors);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(labelCP);
            panel1.Controls.Add(labelJC);
            panel1.Controls.Add(labelML);
            panel1.Controls.Add(labelAE);
            panel1.Controls.Add(labelCC);
            panel1.Controls.Add(labelKC);
            panel1.Location = new Point(90, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 277);
            panel1.TabIndex = 19;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(768, 560);
            Controls.Add(panel1);
            Controls.Add(panelTitleMenu);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTitleMenu.ResumeLayout(false);
            panelTitleMenu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTableContents;
        private Label labelTitle3;
        private Label labelTitle1;
        private Label labelTitle2;
        private Label labelCredits;
        private Label labelCC;
        private Label labelKC;
        private Label labelML;
        private Label labelJC;
        private Label labelAE;
        private Label labelAuthors;
        private Label labelCP;
        private Label labelThemeStories;
        private Label labelOgStories;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panelTitleMenu;
        private Panel panel1;
    }
}