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
			btnCopy = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// btnExit
			// 
			btnExit.Location = new Point(481, 316);
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
			lblStory.Margin = new Padding(59, 29, 59, 29);
			lblStory.Name = "lblStory";
			lblStory.Padding = new Padding(30, 29, 30, 29);
			lblStory.Size = new Size(539, 269);
			lblStory.TabIndex = 1;
			lblStory.Text = "Story";
			lblStory.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnCopy
			// 
			btnCopy.Location = new Point(389, 316);
			btnCopy.Margin = new Padding(3, 4, 3, 4);
			btnCopy.Name = "btnCopy";
			btnCopy.Size = new Size(86, 31);
			btnCopy.TabIndex = 2;
			btnCopy.Text = "Copy";
			btnCopy.UseVisualStyleBackColor = true;
			btnCopy.Click += btnCopy_Click;
			// 
			// button1
			// 
			button1.Location = new Point(291, 316);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(90, 31);
			button1.TabIndex = 3;
			button1.Text = "Download";
			button1.UseVisualStyleBackColor = true;
			button1.Click += DownloadButton_Click;
			// 
			// StoryForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(610, 357);
			Controls.Add(button1);
			Controls.Add(btnCopy);
			Controls.Add(lblStory);
			Controls.Add(btnExit);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "StoryForm";
			Text = "Story";
			Load += Story_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button btnExit;
        private Label lblStory;
        private Button btnCopy;
        private Button button1;
    }
}