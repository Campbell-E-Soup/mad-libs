using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mad_Libs_App
{
    public partial class StoryForm : Form
    {
        public StoryForm()
        {
            InitializeComponent();
        }

        private void Story_Load(object sender, EventArgs e)
        {
            if (Tag != null) { lblStory.Text = Tag.ToString(); }
            lblMessage.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblStory.Text);
            lblMessage.ForeColor = SystemColors.ControlDark;
            lblMessage.Text = "Story copied to clipboard!";
        }

        //button for downloading finished madlib to desktop 
        private void DownloadButton_Click(object sender, EventArgs e)
        {   //dialog showing location where user can save .txt file 
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            //determine directory to save file 
            string filePath;
            filePath = Path.Combine(AppContext.BaseDirectory, "Text Files");
            if (!Directory.Exists(filePath))
            {
                filePath = Path.Combine(AppContext.BaseDirectory, "..", "..","..", "Text Files");
                if (!Directory.Exists(filePath))
                {
                    filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }
            }
            saveFileDialog.InitialDirectory = filePath;
            saveFileDialog.FileName = "saved_madlib.txt";
            //Lets user know save was successful 
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {   //saving to a .txt file 
                    File.WriteAllText(saveFileDialog.FileName, lblStory.Text);
                    lblMessage.ForeColor = SystemColors.ControlDark;
                    lblMessage.Text = "Story saved successfully!";
                }
                //Lets user know if save had issues 
                catch (Exception ex)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Error saving the story: " + ex.Message;
                }
            }
        }

    }
}
