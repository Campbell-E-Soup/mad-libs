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
            picShadow = new PictureBox();
            picForm = new PictureBox();
            tabMain = new Button();
            tabPlay = new Button();
            tabCreate = new Button();
            tabCredits = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picShadow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picForm).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(432, 283);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(133, 29);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play!";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            btnPlay.MouseEnter += btnPlay_MouseEnter;
            // 
            // btnCreate
            // 
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(117, 283);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(133, 29);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            btnCreate.MouseEnter += btnCreate_MouseEnter;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSort.Location = new Point(117, 73);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(110, 25);
            lblSort.TabIndex = 2;
            lblSort.Text = "Sort By Tag:";
            // 
            // cboSortBy
            // 
            cboSortBy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            cboSortBy.FormattingEnabled = true;
            cboSortBy.Location = new Point(117, 101);
            cboSortBy.Name = "cboSortBy";
            cboSortBy.Size = new Size(288, 31);
            cboSortBy.TabIndex = 3;
            cboSortBy.MouseEnter += cboSortBy_MouseEnter;
            // 
            // btnLoad
            // 
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(491, 101);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(74, 31);
            btnLoad.TabIndex = 4;
            btnLoad.Text = ". . .";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            btnLoad.MouseEnter += btnLoad_MouseEnter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(268, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 31);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Madlibs App";
            // 
            // lblTooltip
            // 
            lblTooltip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTooltip.Location = new Point(117, 148);
            lblTooltip.Name = "lblTooltip";
            lblTooltip.Size = new Size(448, 120);
            lblTooltip.TabIndex = 6;
            lblTooltip.Text = "Tooltip";
            lblTooltip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picShadow
            // 
            picShadow.BackColor = SystemColors.ActiveCaptionText;
            picShadow.Location = new Point(872, -2);
            picShadow.Name = "picShadow";
            picShadow.Size = new Size(125, 62);
            picShadow.TabIndex = 7;
            picShadow.TabStop = false;
            // 
            // picForm
            // 
            picForm.BackColor = Color.RosyBrown;
            picForm.Location = new Point(0, 0);
            picForm.Name = "picForm";
            picForm.Size = new Size(682, 343);
            picForm.TabIndex = 8;
            picForm.TabStop = false;
            // 
            // tabMain
            // 
            tabMain.FlatAppearance.BorderSize = 0;
            tabMain.FlatStyle = FlatStyle.Flat;
            tabMain.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.Size = new Size(101, 31);
            tabMain.TabIndex = 9;
            tabMain.Text = "Home";
            tabMain.UseVisualStyleBackColor = true;
            // 
            // tabPlay
            // 
            tabPlay.FlatAppearance.BorderSize = 0;
            tabPlay.FlatStyle = FlatStyle.Flat;
            tabPlay.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPlay.Location = new Point(102, 0);
            tabPlay.Name = "tabPlay";
            tabPlay.Size = new Size(101, 31);
            tabPlay.TabIndex = 10;
            tabPlay.Text = "Play";
            tabPlay.UseVisualStyleBackColor = true;
            tabPlay.Click += btnPlay_Click;
            // 
            // tabCreate
            // 
            tabCreate.FlatAppearance.BorderSize = 0;
            tabCreate.FlatStyle = FlatStyle.Flat;
            tabCreate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabCreate.Location = new Point(204, 0);
            tabCreate.Name = "tabCreate";
            tabCreate.Size = new Size(101, 31);
            tabCreate.TabIndex = 11;
            tabCreate.Text = "Create";
            tabCreate.UseVisualStyleBackColor = true;
            tabCreate.Click += btnCreate_Click;
            // 
            // tabCredits
            // 
            tabCredits.FlatAppearance.BorderSize = 0;
            tabCredits.FlatStyle = FlatStyle.Flat;
            tabCredits.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabCredits.Location = new Point(306, 0);
            tabCredits.Name = "tabCredits";
            tabCredits.Size = new Size(101, 31);
            tabCredits.TabIndex = 12;
            tabCredits.Text = "Credits";
            tabCredits.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(639, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(38, 38);
            btnExit.TabIndex = 13;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // StartUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 537);
            Controls.Add(btnExit);
            Controls.Add(tabCredits);
            Controls.Add(tabCreate);
            Controls.Add(tabPlay);
            Controls.Add(tabMain);
            Controls.Add(lblTooltip);
            Controls.Add(lblTitle);
            Controls.Add(btnLoad);
            Controls.Add(cboSortBy);
            Controls.Add(lblSort);
            Controls.Add(btnCreate);
            Controls.Add(btnPlay);
            Controls.Add(picForm);
            Controls.Add(picShadow);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StartUpForm";
            Text = "Mad Libs";
            Load += StartUp_Load;
            Resize += StartUpForm_Resize;
            ((System.ComponentModel.ISupportInitialize)picShadow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picForm).EndInit();
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
        private PictureBox picShadow;
        private PictureBox picForm;
        private Button tabMain;
        private Button tabPlay;
        private Button tabCreate;
        private Button tabCredits;
        private Button btnExit;
    }
}