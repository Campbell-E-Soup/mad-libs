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
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.BackColor = Color.FromArgb(238, 189, 138);
            lblPrompt.Font = new Font("KimsBitHand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrompt.Location = new Point(10, 9);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(307, 48);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "MadLib";
            lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Enabled = false;
            btnNext.Location = new Point(133, 145);
            btnNext.Margin = new Padding(3, 2, 3, 2);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(82, 22);
            btnNext.TabIndex = 1;
            btnNext.Text = "Submit";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtWord
            // 
            txtWord.BackColor = Color.FromArgb(238, 189, 138);
            txtWord.BorderStyle = BorderStyle.FixedSingle;
            txtWord.Font = new Font("KimsBitHand", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtWord.Location = new Point(72, 93);
            txtWord.Margin = new Padding(3, 2, 3, 2);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(182, 21);
            txtWord.TabIndex = 2;
            txtWord.TextChanged += txtWord_TextChanged;
            // 
            // lblReminder
            // 
            lblReminder.BackColor = Color.FromArgb(238, 189, 138);
            lblReminder.Font = new Font("KimsBitHand", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReminder.ForeColor = SystemColors.GrayText;
            lblReminder.Location = new Point(12, 57);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(307, 34);
            lblReminder.TabIndex = 3;
            lblReminder.Text = "Reminder";
            lblReminder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Prompts
            // 
            AcceptButton = btnNext;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 189, 138);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(329, 178);
            Controls.Add(lblReminder);
            Controls.Add(txtWord);
            Controls.Add(btnNext);
            Controls.Add(lblPrompt);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
