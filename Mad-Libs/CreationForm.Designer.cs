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
            lblTag = new Label();
            txtTag = new TextBox();
            SuspendLayout();
            // 
            // txtStory
            // 
            txtStory.Location = new Point(10, 9);
            txtStory.Margin = new Padding(3, 2, 3, 2);
            txtStory.Multiline = true;
            txtStory.Name = "txtStory";
            txtStory.Size = new Size(412, 196);
            txtStory.TabIndex = 0;
            // 
            // cboAdd
            // 
            cboAdd.FormattingEnabled = true;
            cboAdd.Items.AddRange(new object[] { "[adj]", "[noun]", "[verb]", "[ving]", "[adv]", "[place]", "[person]", "[pnoun]", "[pname]", "[color]", "[body]", "[pbody]", "[food]", "[exc]" });
            cboAdd.Location = new Point(10, 224);
            cboAdd.Margin = new Padding(3, 2, 3, 2);
            cboAdd.Name = "cboAdd";
            cboAdd.Size = new Size(133, 23);
            cboAdd.TabIndex = 1;
            cboAdd.SelectedIndexChanged += cboAdd_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(340, 223);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 2;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblObject
            // 
            lblObject.AutoSize = true;
            lblObject.Location = new Point(52, 206);
            lblObject.Name = "lblObject";
            lblObject.Size = new Size(40, 15);
            lblObject.TabIndex = 3;
            lblObject.Text = "object";
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Location = new Point(225, 206);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(24, 15);
            lblTag.TabIndex = 4;
            lblTag.Text = "tag";
            // 
            // txtTag
            // 
            txtTag.Location = new Point(149, 224);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(185, 23);
            txtTag.TabIndex = 5;
            // 
            // CreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 257);
            Controls.Add(txtTag);
            Controls.Add(lblTag);
            Controls.Add(lblObject);
            Controls.Add(btnSave);
            Controls.Add(cboAdd);
            Controls.Add(txtStory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreationForm";
            Text = "Create a MadLib!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStory;
        private ComboBox cboAdd;
        private Button btnSave;
        private Label lblObject;
        private Label lblTag;
        private TextBox txtTag;
    }
}