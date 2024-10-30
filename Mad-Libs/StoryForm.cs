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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblStory.Text);
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            //saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Text Files");
            if (!Directory.Exists(filePath))
            {
                filePath = Path.Combine(AppContext.BaseDirectory, "Text Files");
            }
            saveFileDialog.InitialDirectory = filePath;
            saveFileDialog.FileName = "finished_story.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, lblStory.Text);
                    MessageBox.Show("Story saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the story: " + ex.Message);
                }
            }
        }

    }
}
