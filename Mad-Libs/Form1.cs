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
    public partial class make_text : Form
    {
        public make_text()
        {
            InitializeComponent();
        }

        private void newtext_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // this block of code let the user add an object just by selecting an item form the combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = users_story.Text + " " + Object.Text + " ";
            users_story.Text = s;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //this writer over a text file that has the same name as the file combobox
        private void button1_Click(object sender, EventArgs e)
        {
            String s = users_story.Text;
            if (file.Text == "save_slot_1")
            {
                StreamWriter slot1 = new StreamWriter("C:\\Users\\alexa\\source\\repos\\Mad-Libs\\Mad-Libs\\save_slot_1.txt");
                slot1.WriteLine(s);
                slot1.Close();
            }
            else if (file.Text == "save_slot_2")
            {
                StreamWriter slot2 = new StreamWriter("C:\\Users\\alexa\\source\\repos\\Mad-Libs\\Mad-Libs\\save_slot_2.txt");
                slot2.WriteLine(s);
                slot2.Close();
            }
            else if (file.Text == "save_slot_3") {
                StreamWriter slot3 = new StreamWriter("C:\\Users\\alexa\\source\\repos\\Mad-Libs\\Mad-Libs\\save_slot_3.txt");
                slot3.WriteLine(s);
                slot3.Close();
            }
           
        }
    }
}
