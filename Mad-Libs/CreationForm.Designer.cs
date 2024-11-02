namespace Mad_Libs_App
{
    partial class CreationForm
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
            txtStory = new TextBox();
            cboAdd = new ComboBox();
            btnSave = new Button();
            lblObject = new Label();
            SuspendLayout();
            // 
            // txtStory
            // 
            txtStory.Location = new Point(12, 12);
            txtStory.Multiline = true;
            txtStory.Name = "txtStory";
            txtStory.Size = new Size(470, 260);
            txtStory.TabIndex = 0;
            // 
            // cboAdd
            // 
            cboAdd.FormattingEnabled = true;
            cboAdd.Location = new Point(12, 298);
            cboAdd.Name = "cboAdd";
            cboAdd.Size = new Size(151, 28);
            cboAdd.TabIndex = 1;
            cboAdd.SelectedIndexChanged += cboAdd_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(388, 297);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblObject
            // 
            lblObject.AutoSize = true;
            lblObject.Location = new Point(59, 275);
            lblObject.Name = "lblObject";
            lblObject.Size = new Size(51, 20);
            lblObject.TabIndex = 3;
            lblObject.Text = "object";
            // 
            // CreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 343);
            Controls.Add(lblObject);
            Controls.Add(btnSave);
            Controls.Add(cboAdd);
            Controls.Add(txtStory);
            Name = "CreationForm";
            Text = "CreationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStory;
        private ComboBox cboAdd;
        private Button btnSave;
        private Label lblObject;
    }
}