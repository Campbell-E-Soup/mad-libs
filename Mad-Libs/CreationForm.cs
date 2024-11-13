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
            String s = txtStory.Text.Trim() + " " + cboAdd.Text + " ";
            txtStory.Text = s;
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
    }
}
