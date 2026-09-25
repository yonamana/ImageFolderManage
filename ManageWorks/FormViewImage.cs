using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManageWorks
{
    public partial class FormViewImage : Form
    {
        C_Slideshow slideshow = new C_Slideshow();


        public FormViewImage(string filePath)
        {
            InitializeComponent();

            slideshow.LoadImageList(pictureBox, filePath);
            return;
        }

        ////////////////////////////////////////////////////////////
        // 関数
        ////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////
        // UI操作
        ////////////////////////////////////////////////////////////

        private void BackBtn_Click(object sender, EventArgs e)
        {
            slideshow.BackImage(pictureBox);
            return;
        }


        private void NextBtn_Click(object sender, EventArgs e)
        {
            slideshow.NextImage(pictureBox);
            return;
        }

        private void AllKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    slideshow.BackImage(pictureBox);
                    NextBtn.Focus();
                    break;
                case Keys.Right:
                    slideshow.NextImage(pictureBox);
                    BackBtn.Focus();
                    break;
            }
            return;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
