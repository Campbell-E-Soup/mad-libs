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
			comboBox1 = new ComboBox();
			btnLoad = new Button();
			lblTitle = new Label();
			SuspendLayout();
			// 
			// btnPlay
			// 
			btnPlay.Location = new Point(275, 167);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(94, 29);
			btnPlay.TabIndex = 0;
			btnPlay.Text = "Play!";
			btnPlay.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(28, 167);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(94, 29);
			btnCreate.TabIndex = 1;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			// 
			// lblSort
			// 
			lblSort.AutoSize = true;
			lblSort.Location = new Point(28, 61);
			lblSort.Name = "lblSort";
			lblSort.Size = new Size(86, 20);
			lblSort.TabIndex = 2;
			lblSort.Text = "Sort By Tag:";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(28, 84);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 28);
			comboBox1.TabIndex = 3;
			// 
			// btnLoad
			// 
			btnLoad.Location = new Point(334, 83);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(35, 29);
			btnLoad.TabIndex = 4;
			btnLoad.Text = ". . .";
			btnLoad.UseVisualStyleBackColor = true;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.Location = new Point(121, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(143, 28);
			lblTitle.TabIndex = 5;
			lblTitle.Text = "Mad-Libs App";
			// 
			// StartUp
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(394, 220);
			Controls.Add(lblTitle);
			Controls.Add(btnLoad);
			Controls.Add(comboBox1);
			Controls.Add(lblSort);
			Controls.Add(btnCreate);
			Controls.Add(btnPlay);
			Name = "StartUp";
			Text = "StartUp";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnPlay;
		private Button btnCreate;
		private Label lblSort;
		private ComboBox comboBox1;
		private Button btnLoad;
		private Label lblTitle;
	}
}