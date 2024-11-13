using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace Mad_Libs_App
{
    public partial class MainMenuForm : Form
    {
        private Image gifOpen, gifClose, pngOpen, pngClose, gifTurnLeft, gifTurnRight, gifContentAppear;
        public MainMenuForm()
        {
            InitializeComponent();

            gifOpen = Image.FromFile("BookOpening.gif");
            gifClose = Image.FromFile("BoolClosing.gif");
            pngOpen = Image.FromFile("IdleBook.png");
            pngClose = Image.FromFile("ClosedBook.png");
            gifTurnLeft = Image.FromFile("PageTurnLeft.gif");
            gifTurnRight = Image.FromFile("PageTurnRight.gif");
            gifContentAppear = Image.FromFile("ContentAppear.gif");

            pictureBox1.Image = gifOpen;
            ImageAnimator.Animate(gifOpen, new EventHandler(OnFrameChanged));
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (!ImageAnimator.IsAnimating(gifOpen))
            {
                // First GIF is finished, display the second GIF
                pictureBox1.Image = gifContentAppear;
                ImageAnimator.Animate(gifContentAppear, new EventHandler(OnSecondGifFinished));
            }
        }
        private void OnSecondGifFinished(object sender, EventArgs e)
        {
            if (!ImageAnimator.IsAnimating(gifContentAppear))
            {
                // Second GIF is finished, display the PNG
                pictureBox1.Image = pngOpen;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelOgStories_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = gifTurnLeft;
            ImageAnimator.Animate(gifTurnLeft);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelThemeStories_Click(object sender, EventArgs e)
        {

        }

        private void labelCredits_Click(object sender, EventArgs e)
        {

        }
    }
}
