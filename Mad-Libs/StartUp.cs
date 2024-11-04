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

namespace Mad_Libs_App
{
	public partial class StartUp : Form
	{
		string notSorted = "";
		StoryList Stories;
		public StartUp()
		{
			InitializeComponent();
		}

		//TODO: ADD LINQ
		private List<Story> SortStoriesByTag()
		{

			//sort by this
			string tag = cboSortBy.Items[cboSortBy.SelectedIndex].ToString();

			int index = cboSortBy.SelectedIndex;
			if (index <= -1 || index >= cboSortBy.Items.Count) { index = 0; }

            //string tag = cboSortBy.Items[index].ToString();
			//this returns a list of Stories as to not overwrite the loaded stories, we just want to 
			//sort not replace.

			//if not filtering by tag, return the default storylist
			if (tag == notSorted)
			{
				return Stories.Stories;
			}
			else
			{
				List<Story> stories = Stories.Stories;
				var filteredStories = Stories.Stories.Where(s => s.Tags.Contains(tag)).ToList();
				///THIS IS WHERE LINQ SHOULD GO.
				//This return should return the sorted list stored in a new variable
				//other than stories.
				return filteredStories;
			}
		}

		private void StartUp_Load(object sender, EventArgs e)
		{
			//cboSortBy.Items.Clear();
			cboSortBy.Items.Add(notSorted);
			cboSortBy.SelectedIndex = 0;
			//StoryList constructed with no variables just gets default.txt
			Stories = new StoryList();
			//load in all the tags from the stories to dropbox
			UpdateDropBox(Stories);
			lblTooltip.Text = string.Empty;
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
				Prompts prmpt = new Prompts();
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
	}
}
