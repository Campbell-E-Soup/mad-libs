using Mad_Libs_App.Classes;
using Mad_Libs_App.Classes.Stories;
using System.Text.RegularExpressions;

namespace Mad_Libs_App
{
    public partial class Prompts : Form
    {
        MadLib? madlib;
        Word? Replacer;
        public Prompts()
        {
            InitializeComponent();
        }

        private void Prompts_Load(object sender, EventArgs e)
        {
            string str = "One [adj] day, I was walking my [color] pet [noun] when [pnoun] started flying from the sky! I called my friend [name] and she said one just landed right on her [place]! [adv], it was raining [pnoun] as well and they were just going everywhere! My [noun] started [ving] and catching [pnoun] with his mouth to eat!";
            //str = "this story has nothing to replace";
            //str = "Noun: [noun], Adjective: [adj], Verb: [verb], Ving: [ving], Adverb: [adv], Place: [place], Person: [person], Plural Noun: [pnoun], Name: [pname], Color: [color], Body Part: [body], Plural Body Part: [pbody], Food: [food], Exclamation: [exc]";
            //StoryList stories = new StoryList();
            //str = stories.Stories[0].Str;
            if (Tag !=  null)
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
            if (!Regex.IsMatch(s, @"^[a-zA-Z\s]+$")) { return false; }
            if (s.Count(char.IsLetter) < 3) { return false; }

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
