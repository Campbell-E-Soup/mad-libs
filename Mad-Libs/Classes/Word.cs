using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Libs_App.Classes
{
    internal class Word
    {
        public string Replace {  get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        public static Dictionary<string, string> Examples { get; set; }
        private static Dictionary<string,string> ExtendType { get; set; }
        public Word(string replace, string type)
        {
            this.Replace = replace;
            this.Type = type;
        }

        static Word()
        {
            Examples = new Dictionary<string, string>
            {
                { "noun", "e.g., dog, flower or javelin" },
                { "verb", "e.g., run, jump or defenestrate" },
                { "adj", "e.g., wicked, lazy or irradiated"},
                { "ving", "e.g, jumping, throwing or flailing"},
                { "name", "e.g, your name, a friends name, or anyones name" },
                { "pnoun", "e.g., cats, biscuits or tons of gold"},
                { "color", "e.g., red, blueish or smoky topaz"},
                { "place",  "e.g., house, street or bottomless pit"},
                { "adv", "e.g., rabidly, suddenly or absurdly"},
                { "prsn", "e.g., Elvis, George Washington or Dolly Parton"},
                { "body", "e.g., nose, arm or weenis" },
                { "pbody", "e.g., legs, eyes or toe nails"},
                { "food", "e.g., pizza, salsa or chicken sandwich" },
                { "exc", "e.g., ouch, geewhiz or golly" }
                //add others as you need
            };

            ExtendType = new Dictionary<string, string>
            {
                {"adj", "adjective"},
                {"ving", "verb ending in ing" },
                {"pnoun", "plural noun" },
                {"adv", "adverb" },
                {"prsn", "person" },
                {"body", "body part" },
                {"pbody", "plural body part" },
                {"exc", "exclamation" }
            };
        }

        public string TypeExtend()
        {
            string str = Type;
            if (ExtendType.ContainsKey(Type)) { str = ExtendType[Type]; }
            string article = isVowel(str[0]) ? "an" : "a";
            return $"Enter {article} {str}.";
        }

        private bool isVowel(char c)
        {
            c = char.ToLower(c);
            switch (c)
            {
                case 'a': return true;
                case 'e': return true;
                case 'i': return true;
                case 'o': return true;
                case 'u': return true;
                default: return false;
            }
        }
    }
}
