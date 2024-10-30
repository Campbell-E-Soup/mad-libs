using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Libs_App.Classes.Stories
{
	internal class StoryList
	{
		public List<Story> Stories {  get; set; }
		public StoryList() 
		{
			Stories = new List<Story>();
			List<string> stringList = IOSystem.GetAllStrings();

			foreach (string str in stringList)
			{
				Stories.Add(new Story(str));
			}
			//MessageBox.Show(this.ToString());
		}

		public StoryList(string path)
		{
			Stories = new List<Story>();
			List<string> stringList = IOSystem.GetAllStrings(path);

			foreach (string str in stringList)
			{
				Stories.Add(new Story(str));
			}
			//MessageBox.Show(this.ToString());
		}

		public override string ToString()
		{
			string stories = string.Empty;
			foreach (Story story in Stories)
			{
				stories += story.ToString() + "\n";
			}

			return stories;
		}
	}
}
