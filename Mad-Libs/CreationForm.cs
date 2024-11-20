using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mad_Libs_App.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mad_Libs_App
{
    public partial class CreationForm : Form
    {
        public CreationForm()
        {
            InitializeComponent();
        }

        private void cboAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            insertText(cboAdd.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog getFile = new OpenFileDialog();
            getFile.Title = "Open or Create a File";
            getFile.Filter = "Text Files (*.txt)|*.txt";
            getFile.CheckFileExists = false;//IOSystem.AppendToFile() will create if file does not exist
            string filePath;
            filePath = Path.Combine(AppContext.BaseDirectory, "Text Files");
            if (!Directory.Exists(filePath))
            {
                filePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Text Files");
                if (!Directory.Exists(filePath))
                {
                    filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
            }
            //saving custom madlib into folder w/ story and tags
            getFile.InitialDirectory = filePath;
            if (getFile.ShowDialog() == DialogResult.OK)
            {
                String customStory = "{Custom, " + txtTag.Text + "} " + txtStory.Text;
                IOSystem.AppendToFile(getFile.FileName, customStory);
            }
        }

        private void txtStory_Enter(object sender, EventArgs e)
        {
            if (txtStory.ForeColor == SystemColors.GrayText)
            {
                txtStory.Text = String.Empty;
                txtStory.ForeColor = SystemColors.WindowText;
            }
        }

        private void insertText(string text)
        {
            String s = txtStory.Text + " " + text + " ";
            txtStory.Text = s.Trim();
        }

        private void btnNoun_Click(object sender, EventArgs e)
        {
            insertText("[noun]");
        }

        private void btnVerb_Click(object sender, EventArgs e)
        {
            insertText("[verb]");
        }

        private void btnAdj_Click(object sender, EventArgs e)
        {
            insertText("[adj]");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertText("[adv]");
        }

        private void CreationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
