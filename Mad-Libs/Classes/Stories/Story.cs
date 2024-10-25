using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Libs_App.Classes.Stories
{
	internal class Story
	{
		public List<string> Tags { get; set; }
		public string Str { get; set; } = string.Empty;

		public Story(string line) {
			//create list of tags
			Tags = new List<string>();
			if (line.Contains('{') && line.Contains('}'))
			{
				int start = line.IndexOf('{');
				int length = Math.Abs(line.IndexOf('{') - line.LastIndexOf('}')-1);
				string allTags = line.Substring(start+1,length-2).Trim();
				line = line.Remove(start, length);
				
				foreach (string t in allTags.Split(','))
				{
					string tag = t.Trim();
					Tags.Add(tag);
				}
			}
			Str = line.Trim();
		}

		
		public override string ToString()
		{
			string tags = string.Empty;
			foreach (string tag in Tags) 
			{
				tags += tag + "\n"; 
			}
			return "Tags:\n" + tags + "Story: " + Str;
		}
	}
}
