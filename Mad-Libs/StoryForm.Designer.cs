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
            btnExit = new Button();
            lblStory = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(485, 316);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblStory
            // 
            lblStory.BackColor = SystemColors.GradientInactiveCaption;
            lblStory.BorderStyle = BorderStyle.Fixed3D;
            lblStory.FlatStyle = FlatStyle.Flat;
            lblStory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStory.Location = new Point(35, 35);
            lblStory.Margin = new Padding(60, 30, 60, 30);
            lblStory.Name = "lblStory";
            lblStory.Padding = new Padding(30);
            lblStory.Size = new Size(540, 270);
            lblStory.TabIndex = 1;
            lblStory.Text = "Story";
            lblStory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 357);
            Controls.Add(lblStory);
            Controls.Add(btnExit);
            Name = "StoryForm";
            Text = "Story";
            Load += Story_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Label lblStory;
    }
}