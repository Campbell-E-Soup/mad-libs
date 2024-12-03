using Mad_Libs_App.Classes;
using Mad_Libs_App.Classes.Stories;
using System.Text.RegularExpressions;

namespace Mad_Libs_App
{
	public partial class PromptsForm : Form
	{
		MadLib? madlib;
		Word? Replacer;
		public PromptsForm()
		{
			InitializeComponent();
		}

		private void Prompts_Load(object sender, EventArgs e)
		{
			string str = "One [adj] day, I was walking my [color] pet [noun] when [pnoun] started flying from the sky! I called my friend [name] and she said one just landed right on her [place]! [adv], it was raining [pnoun] as well and they were just going everywhere! My [noun] started [ving] and catching [pnoun] with his mouth to eat!";
			if (Tag != null)
			{
				str = Tag.ToString();
			}
			madlib = new MadLib(str);
			Replacer = madlib.Next();
			if (Replacer != null)
			{
				lblPrompt.Text = Replacer.GetPrompt();
				lblReminder.Text = Word.Examples[Replacer.Type];
			}
			else
			{
				StoryForm storyForm = new StoryForm();
				storyForm.Tag = str;
				//cannot hide form in load event.
				hideTimer.Enabled = true;
				storyForm.Closed += (s, args) => this.Close();
				storyForm.Show();
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (answerValidation(txtWord.Text) && Replacer != null)
			{
				Replacer.Replace = txtWord.Text.Trim();
				Replacer = madlib.Next();
				//if list is NOT empty
				if (Replacer != null)
				{
					lblPrompt.Text = Replacer.GetPrompt();
					lblReminder.Text = Word.Examples[Replacer.Type];
					btnNext.Enabled = false;
					txtWord.Text = string.Empty;
				}
				else
				{
					//list is empty, story is complete
					this.Hide();
					madlib.Finish();
					StoryForm storyForm = new StoryForm();
					storyForm.Tag = madlib.FinishedStory;
					storyForm.Closed += (s, args) => this.Close();
					storyForm.Show();
				}
			}
		}

		private bool answerValidation(string s)
		{
			if (Replacer.Type != "num")
			{
				if (!Regex.IsMatch(s, @"^[a-zA-Z\s]+$")) { return false; }
				if (s.Count(char.IsLetter) < 3) { return false; }
			}
			else
			{
				if (!Regex.IsMatch(s, @"^[a-zA-Z0-9\s]+$")) { return false; }
			}
			return true;
		}

		private void txtWord_TextChanged(object sender, EventArgs e)
		{
			if (answerValidation(txtWord.Text))
			{
				btnNext.Enabled = true;
			}
			else
			{
				btnNext.Enabled = false;
			}
		}

		private void hideTimer_Tick(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
