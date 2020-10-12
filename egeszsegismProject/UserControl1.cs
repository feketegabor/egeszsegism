using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egeszsegismProject
{
    public partial class UserControl1 : UserControl
    {
        private List<Bitmap> kepek;

        public UserControl1(List<Bitmap> kepek)
        {
            InitializeComponent();
            this.kepek = kepek;
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            int kepMagassag = 0;
            foreach (var kep in kepek)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = kep;
                pictureBox.Size = new Size(630, kep.Height / (kep.Width / 630));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Top = kepMagassag;
                kepMagassag += pictureBox.Height;
                pictureBoxes.Add(pictureBox);
                this.Controls.Add(pictureBox);
            }
        }
    }
}
