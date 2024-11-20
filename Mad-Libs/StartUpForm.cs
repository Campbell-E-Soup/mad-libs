using Mad_Libs_App.Classes.Stories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Mad_Libs_App
{
    public partial class StartUpForm : Form
    {
        //colors for easy use.
        readonly Color BGColor = ColorTranslator.FromHtml("#3e3546");
        readonly Color FormColor = ColorTranslator.FromHtml("#9babb2");
        readonly Color TabColor = ColorTranslator.FromHtml("#625565");
        readonly Color ShadowColor = ColorTranslator.FromHtml("#2e222f");
        readonly Color ElementColor = ColorTranslator.FromHtml("#91db69");
        readonly Color ElementShadowColor = ColorTranslator.FromHtml("#7f708a");
        readonly Color ExitColor = ColorTranslator.FromHtml("#e83b3b");

        //ui vars
        int shadowOffset = 8;
        int deselectedOffset = 2;
        int tabSpacing = 4;

        string notSorted = "";
        StoryList Stories;
        public StartUpForm()
        {
            InitializeComponent();
        }

        //TODO: ADD LINQ
        private List<Story> SortStoriesByTag()
        {

            //sort by this
            int index = cboSortBy.SelectedIndex;
            if (index <= -1 || index >= cboSortBy.Items.Count) { index = 0; }
            string tag = cboSortBy.Items[index].ToString();
            if (tag == notSorted)
            {
                return Stories.Stories;
            }
            else
            {
                List<Story> stories = Stories.Stories;
                var filteredStories = Stories.Stories.Where(s => s.Tags.Contains(tag)).ToList();
                return filteredStories;
            }
        }

        private void CreateElementShadow(System.Windows.Forms.Control element)
        {
            PictureBox picShadow = new PictureBox();
            picShadow.BackColor = ElementShadowColor;
            picShadow.Parent = element.Parent;
            picShadow.Location = new Point(element.Location.X - (shadowOffset / 2), element.Location.Y + (shadowOffset / 2));
            picShadow.Size = element.Size;
        }
        private void CreateTabShadow(System.Windows.Forms.Control element)
        {
            PictureBox picShadow = new PictureBox();
            picShadow.BackColor = ShadowColor;
            picShadow.Parent = element.Parent;
            picShadow.Location = new Point(element.Location.X - (shadowOffset), element.Location.Y + (shadowOffset));
            picShadow.Size = element.Size;
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            //set colors
            this.BackColor = BGColor;
            picShadow.BackColor = ShadowColor;
            picForm.BackColor = FormColor;

            //buttons
            btnCreate.BackColor = ElementColor;
            btnLoad.BackColor = ElementColor;
            btnPlay.BackColor = ElementColor;
            btnExit.BackColor = ExitColor;
            btnExit.ForeColor = Color.White;
            //tabs
            tabMain.BackColor = FormColor;
            tabCreate.BackColor = TabColor;
            tabPlay.BackColor = TabColor;
            tabCredits.BackColor = TabColor;

            //resize form to fullscreen
            FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            //set parents
            lblSort.Parent = picForm;
            lblTitle.Parent = picForm;
            lblTooltip.Parent = picForm;
            btnCreate.Parent = picForm;
            btnLoad.Parent = picForm;
            btnPlay.Parent = picForm;
            cboSortBy.Parent = picForm;
            btnExit.Parent = picForm;

            //cboSortBy.Items.Clear();
            cboSortBy.Items.Add(notSorted);
            cboSortBy.SelectedIndex = 0;
            //StoryList constructed with no variables just gets default.txt
            Stories = new StoryList();
            //load in all the tags from the stories to dropbox
            UpdateDropBox(Stories);
            lblTooltip.Text = string.Empty;

            //add shadows to element (buttons, etc.)
            CreateElementShadow(btnPlay);
            CreateElementShadow(btnCreate);
            CreateElementShadow(btnLoad);
            CreateElementShadow(cboSortBy);
            CreateElementShadow(btnExit);

            //set position of tabs
            int x = picForm.Location.X;
            int y = picForm.Location.Y;
            int currentTab = 0;
            Control[] tabs = { tabMain, tabPlay, tabCreate, tabCredits };
            for (int i = 0; i < tabs.Length; i++)
            {
                Control tab = tabs[i];
                tab.SendToBack();
                int xOffset = (tab.Width + tabSpacing) * i;
                int yOffset = 0;
                if (i != currentTab) { yOffset = deselectedOffset; }
                tab.Location = new Point(x + xOffset, y - tabMain.Height + yOffset);
                CreateTabShadow(tab);
            }

        }

        private void UpdateDropBox(StoryList stories)
        {
            List<string> allTags = new List<string>();
            //updates the drop box to have each different tags from story list.
            for (int i = 0; i < stories.Stories.Count; i++)
            {
                List<string> tags = stories.Stories[i].Tags;
                allTags.AddRange(tags.Except(allTags));
            }
            cboSortBy.Items.Clear();
            cboSortBy.Items.Add(notSorted);
            foreach (string tag in allTags)
            {
                if (!cboSortBy.Items.Contains(tag))
                {
                    cboSortBy.Items.Add(tag);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            List<Story> stories = SortStoriesByTag();
            //check if their are any stories to play
            if (stories.Count > 0 && stories != null)
            {
                //get a random story from the list.
                Random rand = new Random();
                string str = stories[rand.Next(stories.Count)].Str;
                PromptsForm prmpt = new PromptsForm();
                prmpt.Tag = str;
                this.Hide();
                prmpt.Closed += (s, args) => this.Show();
                prmpt.Show();
            }
            else
            {
                MessageBox.Show("There are no stories");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //assure no errors when new tags are loaded
            cboSortBy.SelectedIndex = 0;
            //load in a file stored on device
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

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
            openFileDialog.InitialDirectory = filePath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != null)
                {
                    Stories = new StoryList(openFileDialog.FileName);
                    UpdateDropBox(Stories);
                }
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreationForm creationForm = new CreationForm();
            this.Hide();
            creationForm.Closed += (s, args) => this.Show();
            creationForm.ShowDialog();
        }

        /* | tooltips |
		   V          V */
        private void cboSortBy_MouseEnter(object sender, EventArgs e)
        {
            lblTooltip.Text = "Sort the stories by their tags.\nWill select a random story with the matching tag";
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            lblTooltip.Text = "Will load a random story from the selected text file with the matching tag.";
        }

        private void btnCreate_MouseEnter(object sender, EventArgs e)
        {
            lblTooltip.Text = "Easily create your own Mad Libs.";
        }

        private void btnLoad_MouseEnter(object sender, EventArgs e)
        {
            lblTooltip.Text = "Load any Mad Lib from a text file.";
        }

        private void StartUpForm_Resize(object sender, EventArgs e)
        {
            //center pic form to center
            int x = (this.ClientSize.Width / 2) - (picForm.Width / 2);
            int y = (this.ClientSize.Height / 2) - (picForm.Height / 2);

            picForm.Location = new Point(x, y);
            picShadow.Size = picForm.Size;
            picShadow.Location = new Point(x - shadowOffset, y + shadowOffset);


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
