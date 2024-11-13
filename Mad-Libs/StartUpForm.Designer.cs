namespace Mad_Libs_App
{
	partial class StartUpForm
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
            btnPlay = new Button();
            btnCreate = new Button();
            lblSort = new Label();
            cboSortBy = new ComboBox();
            btnLoad = new Button();
            lblTitle = new Label();
            lblTooltip = new Label();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(275, 195);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(94, 29);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play!";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            btnPlay.MouseEnter += btnPlay_MouseEnter;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(27, 195);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            btnCreate.MouseEnter += btnCreate_MouseEnter;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Location = new Point(27, 61);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(86, 20);
            lblSort.TabIndex = 2;
            lblSort.Text = "Sort By Tag:";
            // 
            // cboSortBy
            // 
            cboSortBy.FormattingEnabled = true;
            cboSortBy.Location = new Point(27, 84);
            cboSortBy.Name = "cboSortBy";
            cboSortBy.Size = new Size(249, 28);
            cboSortBy.TabIndex = 3;
            cboSortBy.MouseEnter += cboSortBy_MouseEnter;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(334, 83);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(35, 29);
            btnLoad.TabIndex = 4;
            btnLoad.Text = ". . .";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            btnLoad.MouseEnter += btnLoad_MouseEnter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(130, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(141, 28);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Mad Libs App";
            // 
            // lblTooltip
            // 
            lblTooltip.Location = new Point(27, 128);
            lblTooltip.Name = "lblTooltip";
            lblTooltip.Size = new Size(341, 51);
            lblTooltip.TabIndex = 6;
            lblTooltip.Text = "Tooltip";
            lblTooltip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 239);
            Controls.Add(lblTooltip);
            Controls.Add(lblTitle);
            Controls.Add(btnLoad);
            Controls.Add(cboSortBy);
            Controls.Add(lblSort);
            Controls.Add(btnCreate);
            Controls.Add(btnPlay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StartUp";
            Text = "Mad Libs";
            Load += StartUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
		private Button btnCreate;
		private Label lblSort;
		private ComboBox cboSortBy;
		private Button btnLoad;
		private Label lblTitle;
		private Label lblTooltip;
	}
}