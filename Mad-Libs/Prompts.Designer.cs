namespace Mad_Libs_App
{
    partial class Prompts
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
            lblPrompt = new Label();
            btnNext = new Button();
            txtWord = new TextBox();
            lblReminder = new Label();
            new_story = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrompt.Location = new Point(12, 9);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(351, 64);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "MadLib";
            lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Enabled = false;
            btnNext.Location = new Point(137, 173);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 1;
            btnNext.Text = "Submit";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtWord
            // 
            txtWord.Location = new Point(82, 126);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(208, 27);
            txtWord.TabIndex = 2;
            txtWord.TextChanged += txtWord_TextChanged;
            // 
            // lblReminder
            // 
            lblReminder.ForeColor = SystemColors.GrayText;
            lblReminder.Location = new Point(12, 73);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(351, 46);
            lblReminder.TabIndex = 3;
            lblReminder.Text = "Reminder";
            lblReminder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // new_story
            // 
            new_story.Location = new Point(102, 208);
            new_story.Name = "new_story";
            new_story.Size = new Size(175, 29);
            new_story.TabIndex = 4;
            new_story.Text = "make a new story";
            new_story.UseVisualStyleBackColor = true;
            new_story.Click += new_story_Click;
            // 
            // Prompts
            // 
            AcceptButton = btnNext;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 283);
            Controls.Add(new_story);
            Controls.Add(lblReminder);
            Controls.Add(txtWord);
            Controls.Add(btnNext);
            Controls.Add(lblPrompt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Prompts";
            Text = "Mad Libs";
            Load += Prompts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private Button btnNext;
        private TextBox txtWord;
        private Label lblReminder;
        private Button new_story;
    }
}
