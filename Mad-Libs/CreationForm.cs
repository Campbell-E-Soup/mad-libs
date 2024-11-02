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
    public partial class CreationForm : Form
    {
        public CreationForm()
        {
            InitializeComponent();
        }

        private void cboAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = txtStory.Text.Trim() + " " + cboAdd.Text + " ";
            txtStory.Text = s;
        }
    }
}
