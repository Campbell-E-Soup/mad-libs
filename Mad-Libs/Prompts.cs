using Mad_Libs_App.Classes;
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
            //str = "Noun: [noun], Adjective: [adj], Verb: [verb], Ving: [ving], Adverb: [adv], Place: [place], Person: [person], Plural Noun: [pnoun], Name: [pname], Color: [color], Body Part: [body], Plural Body Part: [pbody], Food: [food], Exclamation: [exc]";
            madlib = new MadLib(str);
            Replacer = madlib.Next();
            if (Replacer != null)
            {
                lblPrompt.Text = Replacer.GetPrompt();
                lblReminder.Text = Word.Examples[Replacer.Type];
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

        // this is just to open the new_story (form1) window
        private void new_story_Click(object sender, EventArgs e)
        { 
            
            make_text Q = new make_text();
           Q.Show();
           
        }
    }
}
