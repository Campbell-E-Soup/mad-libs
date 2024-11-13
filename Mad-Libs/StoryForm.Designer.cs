namespace Mad_Libs_App
{
    partial class StoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoryForm));
            btnExit = new Button();
            lblStory = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(478, 426);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblStory
            // 
            lblStory.BackColor = Color.FromArgb(238, 189, 138);
            lblStory.FlatStyle = FlatStyle.Flat;
            lblStory.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStory.Location = new Point(419, 127);
            lblStory.Margin = new Padding(52, 22, 52, 22);
            lblStory.Name = "lblStory";
            lblStory.Padding = new Padding(26, 22, 26, 22);
            lblStory.Size = new Size(250, 293);
            lblStory.TabIndex = 1;
            lblStory.Text = "Story";
            lblStory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-68, -105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(791, 653);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // StoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(768, 560);
            Controls.Add(lblStory);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "StoryForm";
            Text = "Story";
            Load += Story_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Label lblStory;
        private PictureBox pictureBox1;
    }
}