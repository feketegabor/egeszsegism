using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace egeszsegismProject
{
    public partial class Form2 : Form
    {
        List<FeladatTabla> eredmények;
        List<FeladatMoTabla> megoldasok;
        int imagesProcessedCount = 0;
        public Form2(List<FeladatTabla> eredmények)
        {
            InitializeComponent();
            this.eredmények = eredmények;

            //panel1.Width = (int)(660 * szorzo);
            //panel1.Height = (int)(891 * szorzo);
            //printButton.Left = 70;
            //printButton.Top = 1030;
            //tovabbButton.Left = 470;
            //tovabbButton.Top = panel1.Height + 20;
            //this.Height = panel1.Height + 70;
            //this.Width = panel1.Width;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            List<Bitmap> imagesToUserControl = new List<Bitmap>();
            // a megjelenítendő képek létrehozása
            foreach (var feladat in this.eredmények)
            {

                byte[] imageByte = feladat.Kep;
                using (MemoryStream ms = new MemoryStream(imageByte))
                {
                    Bitmap image = new Bitmap(ms);

                    //if (CheckSize(imagesToUserControl, image))
                    //{
                        imagesToUserControl.Add(image);
                        imagesProcessedCount++;
                    //}
                    //else
                    //{
                    //    break;
                    //}
                }
            }

            //if (this.imagesProcessedCount == this.eredmények.Count)
            //{
            //    tovabbButton.Enabled = false;
            //}

            UserControl1 imagesUserControl = new UserControl1(imagesToUserControl);
            panel1.Controls.Add(imagesUserControl);
        }

        // konstruktor a megoldások megjelenítéséhez
        public Form2(List<FeladatMoTabla> megoldasok)
        {
            InitializeComponent();
            this.megoldasok = megoldasok;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            List<Bitmap> imagesToUserControl = new List<Bitmap>();
            // a megjelenítendő képek létrehozása
            foreach (var megoldas in this.megoldasok)
            {

                byte[] imageByte = megoldas.Kep;
                using (MemoryStream ms = new MemoryStream(imageByte))
                {
                    Bitmap image = new Bitmap(ms);

                    //if (CheckSize(imagesToUserControl, image))
                    //{
                    imagesToUserControl.Add(image);
                    imagesProcessedCount++;
                    //}
                    //else
                    //{
                    //    break;
                    //}
                }
            }

            //if (this.imagesProcessedCount == this.eredmények.Count)
            //{
            //    tovabbButton.Enabled = false;
            //}

            UserControl1 imagesUserControl = new UserControl1(imagesToUserControl);
            panel1.Controls.Add(imagesUserControl);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //CaptureScreen();
            //printDocument1.Print();
        }

        //private bool CheckSize(List<Bitmap> imagesToUserControl, Bitmap image)
        //{
        //    // eddigi usercontrol-on lévő képek összmagassága
        //    int sumHeight = 0;
        //    if (imagesToUserControl.Any())
        //    {
        //        //sumHeight = imagesToUserControl.Sum(x => x.Height / (x.Width / (int)(660 * szorzo)));
        //        sumHeight = imagesToUserControl.Sum(x => x.Height * (panel1.Width / x.Width));
        //    }

        //    //int imageSize = image.Height / (image.Width / (int)(660 * szorzo));
        //    int imageSize = image.Height * (panel1.Width / image.Width);
        //    return sumHeight + imageSize <= panel1.Height;
        //}

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TovabbButton_Click(object sender, EventArgs e)
        {
            List<Bitmap> imagesToUserControl = new List<Bitmap>();
            foreach (var feladat in this.eredmények)
            {
                if (this.eredmények.IndexOf(feladat) > this.imagesProcessedCount)
                {
                    byte[] imageByte = feladat.Kep;
                    using (MemoryStream ms = new MemoryStream(imageByte))
                    {
                        Bitmap image = new Bitmap(ms);

                        //if (CheckSize(imagesToUserControl, image))
                        //{
                            imagesToUserControl.Add(image);
                            imagesProcessedCount++;
                        //}
                        //else
                        //{
                        //    break;
                        //}
                    }
                }
            }

            //if (this.imagesProcessedCount == this.eredmények.Count)
            //{
            //    tovabbButton.Enabled = false;
            //}

            UserControl1 imagesUserControl = new UserControl1(imagesToUserControl);
            panel1.Controls.Clear();
            panel1.Controls.Add(imagesUserControl);
        }
    }
}
