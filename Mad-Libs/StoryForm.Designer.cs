﻿namespace Mad_Libs_App
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
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(421, 237);
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
            lblStory.BackColor = SystemColors.GradientInactiveCaption;
            lblStory.BorderStyle = BorderStyle.Fixed3D;
            lblStory.FlatStyle = FlatStyle.Flat;
            lblStory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStory.Location = new Point(31, 26);
            lblStory.Margin = new Padding(52, 22, 52, 22);
            lblStory.Name = "lblStory";
            lblStory.Padding = new Padding(26, 22, 26, 22);
            lblStory.Size = new Size(472, 202);
            lblStory.TabIndex = 1;
            lblStory.Text = "Story";
            lblStory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(340, 237);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // button1
            // 
            button1.Location = new Point(255, 237);
            button1.Name = "button1";
            button1.Size = new Size(79, 23);
            button1.TabIndex = 3;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DownloadButton_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(27, 238);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(53, 15);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Message";
            // 
            // StoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 268);
            Controls.Add(lblMessage);
            Controls.Add(button1);
            Controls.Add(btnCopy);
            Controls.Add(lblStory);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "StoryForm";
            Text = "Story";
            Load += Story_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label lblStory;
        private Button btnCopy;
        private Button button1;
        private Label lblMessage;
    }
}