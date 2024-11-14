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
            btnNoun = new Button();
            btnAdv = new Button();
            btnVerb = new Button();
            btnAdj = new Button();
            SuspendLayout();
            // 
            // txtStory
            // 
            txtStory.ForeColor = SystemColors.GrayText;
            txtStory.Location = new Point(11, 12);
            txtStory.Multiline = true;
            txtStory.Name = "txtStory";
            txtStory.Size = new Size(470, 260);
            txtStory.TabIndex = 2;
            txtStory.Text = "This is a really [adj] example MadLib!\r\nWe even support linebreaks!\r\nTry it out!";
            txtStory.Enter += txtStory_Enter;
            // 
            // cboAdd
            // 
            cboAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAdd.FormattingEnabled = true;
            cboAdd.Items.AddRange(new object[] { "[adj]", "[noun]", "[verb]", "[ving]", "[adv]", "[place]", "[person]", "[pnoun]", "[pname]", "[color]", "[body]", "[pbody]", "[food]", "[exc]" });
            cboAdd.Location = new Point(496, 108);
            cboAdd.Name = "cboAdd";
            cboAdd.Size = new Size(162, 28);
            cboAdd.TabIndex = 1;
            cboAdd.SelectedIndexChanged += cboAdd_SelectedIndexChanged;
            cboAdd.Enter += txtStory_Enter;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(580, 297);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblObject
            // 
            lblObject.AutoSize = true;
            lblObject.Location = new Point(534, 15);
            lblObject.Name = "lblObject";
            lblObject.Size = new Size(83, 20);
            lblObject.TabIndex = 3;
            lblObject.Text = "Add Blanks";
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Location = new Point(12, 275);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(107, 20);
            lblTag.TabIndex = 0;
            lblTag.Text = "Save with tags:";
            // 
            // txtTag
            // 
            txtTag.Location = new Point(12, 299);
            txtTag.Margin = new Padding(3, 4, 3, 4);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(562, 27);
            txtTag.TabIndex = 0;
            // 
            // btnNoun
            // 
            btnNoun.Location = new Point(496, 38);
            btnNoun.Name = "btnNoun";
            btnNoun.Size = new Size(78, 29);
            btnNoun.TabIndex = 1;
            btnNoun.Text = "Noun";
            btnNoun.UseVisualStyleBackColor = true;
            btnNoun.Click += btnNoun_Click;
            btnNoun.Enter += txtStory_Enter;
            // 
            // btnAdv
            // 
            btnAdv.Location = new Point(591, 73);
            btnAdv.Name = "btnAdv";
            btnAdv.Size = new Size(67, 29);
            btnAdv.TabIndex = 7;
            btnAdv.Text = "Adverb";
            btnAdv.UseVisualStyleBackColor = true;
            btnAdv.Click += button2_Click;
            btnAdv.Enter += txtStory_Enter;
            // 
            // btnVerb
            // 
            btnVerb.Location = new Point(580, 38);
            btnVerb.Name = "btnVerb";
            btnVerb.Size = new Size(78, 29);
            btnVerb.TabIndex = 8;
            btnVerb.Text = "Verb";
            btnVerb.UseVisualStyleBackColor = true;
            btnVerb.Click += btnVerb_Click;
            btnVerb.Enter += txtStory_Enter;
            // 
            // btnAdj
            // 
            btnAdj.Location = new Point(496, 73);
            btnAdj.Name = "btnAdj";
            btnAdj.Size = new Size(89, 29);
            btnAdj.TabIndex = 9;
            btnAdj.Text = "Adjective";
            btnAdj.UseVisualStyleBackColor = true;
            btnAdj.Click += btnAdj_Click;
            btnAdj.Enter += txtStory_Enter;
            // 
            // CreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 343);
            Controls.Add(btnAdj);
            Controls.Add(btnVerb);
            Controls.Add(btnAdv);
            Controls.Add(btnNoun);
            Controls.Add(txtTag);
            Controls.Add(lblTag);
            Controls.Add(lblObject);
            Controls.Add(btnSave);
            Controls.Add(cboAdd);
            Controls.Add(txtStory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button btnNoun;
        private Button btnAdv;
        private Button btnVerb;
        private Button btnAdj;
    }
}