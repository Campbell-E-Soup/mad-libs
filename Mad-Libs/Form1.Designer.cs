namespace Mad_Libs_App
{
    partial class make_text
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
            Object = new ComboBox();
            button1 = new Button();
            users_story = new TextBox();
            file = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Object
            // 
            Object.FormattingEnabled = true;
            Object.Items.AddRange(new object[] { "[adj]", "[noun]", "[verb]", "[ving]", "[adv]", "[place]", "[person]", "[pnoun]", "[pname]", "[color]", "[body]", "[pbody]", "[food]", "[exc]" });
            Object.Location = new Point(151, 338);
            Object.Name = "Object";
            Object.Size = new Size(151, 28);
            Object.TabIndex = 0;
            Object.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(329, 337);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // users_story
            // 
            users_story.Location = new Point(151, 57);
            users_story.Multiline = true;
            users_story.Name = "users_story";
            users_story.Size = new Size(455, 251);
            users_story.TabIndex = 2;
            users_story.TextChanged += textBox1_TextChanged;
            // 
            // file
            // 
            file.FormattingEnabled = true;
            file.Items.AddRange(new object[] { "save_slot_1", "save_slot_2", "save_slot_3" });
            file.Location = new Point(455, 338);
            file.Name = "file";
            file.Size = new Size(151, 28);
            file.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 311);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "object";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 315);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "save files";
            // 
            // make_text
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(file);
            Controls.Add(users_story);
            Controls.Add(button1);
            Controls.Add(Object);
            Name = "make_text";
            Text = "new_story";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Object;
        private Button button1;
        private Label newtext;
        private TextBox users_story;
        private ComboBox file;
        private Label label1;
        private Label label2;
    }
}