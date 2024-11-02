namespace Mad_Libs_App
{
	partial class StartUp
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
            btnPlay.Location = new Point(241, 146);
            btnPlay.Margin = new Padding(3, 2, 3, 2);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(82, 22);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play!";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            btnPlay.MouseEnter += btnPlay_MouseEnter;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(24, 146);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            btnCreate.MouseEnter += btnCreate_MouseEnter;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Location = new Point(24, 46);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(68, 15);
            lblSort.TabIndex = 2;
            lblSort.Text = "Sort By Tag:";
            // 
            // cboSortBy
            // 
            cboSortBy.FormattingEnabled = true;
            cboSortBy.Location = new Point(24, 63);
            cboSortBy.Margin = new Padding(3, 2, 3, 2);
            cboSortBy.Name = "cboSortBy";
            cboSortBy.Size = new Size(218, 23);
            cboSortBy.TabIndex = 3;
            cboSortBy.MouseEnter += cboSortBy_MouseEnter;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(292, 62);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(31, 22);
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
            lblTitle.Location = new Point(114, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(113, 21);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Mad Libs App";
            // 
            // lblTooltip
            // 
            lblTooltip.Location = new Point(24, 96);
            lblTooltip.Name = "lblTooltip";
            lblTooltip.Size = new Size(298, 38);
            lblTooltip.TabIndex = 6;
            lblTooltip.Text = "Tooltip";
            lblTooltip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 179);
            Controls.Add(lblTooltip);
            Controls.Add(lblTitle);
            Controls.Add(btnLoad);
            Controls.Add(cboSortBy);
            Controls.Add(lblSort);
            Controls.Add(btnCreate);
            Controls.Add(btnPlay);
            Margin = new Padding(3, 2, 3, 2);
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