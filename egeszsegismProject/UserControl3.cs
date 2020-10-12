using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.IO;
using System.Text.RegularExpressions;

namespace egeszsegismProject
{
    public partial class UserControl3 : UserControl
    {
        Database1Entities context = new Database1Entities();
        byte[] flFile;
        byte[] moFile;

        public UserControl3()
        {
            InitializeComponent();
            flTipusTextBox.DisplayMember = "FeladatTipus";
            flHonapComboBox.DataSource = new List<string>() { "május", "október" };
            flTipusTextBox.DataSource = (from x in context.FeladatTipusTabla select x).ToList();
        }

        private void hozzaadasButton_Click(object sender, EventArgs e)
        {
            string pdf = flPdfTextBox.Text;
            int ev = 0;
            if (!string.IsNullOrWhiteSpace(flEvTextBox.Text))
            {
                ev = int.Parse(flEvTextBox.Text);
            }
            string honap = (string)flHonapComboBox.SelectedItem;
            int sorszam = int.Parse(flSorszamTextBox.Text);
            int feladatTipus = ((FeladatTipusTabla)flTipusTextBox.SelectedItem).Id;
            int szelesseg = int.Parse(flSzelessegTextBox.Text);
            int magassag = int.Parse(flMagassagTextBox.Text);

            string megoldasPdf = moPdfTextBox.Text;
            int megoldasSzelesseg = int.Parse(moSzelessegTextBox.Text);
            int megoldasMagassag = int.Parse(moMagassagTextBox.Text);

            context.FeladatTabla.Add(new FeladatTabla()
            {
                FeladatPdf = pdf,
                Ev = ev,
                Honap = honap,
                FeladatSorszama = sorszam,
                FeladatTipusFK = feladatTipus,
                Szelesseg = szelesseg,
                Magassag = magassag,
                Kep = flFile.Length == 0 ? null : flFile
            });
            context.SaveChanges();

            int newId = context.FeladatTabla.Max(x => x.Id);
            context.FeladatMoTabla.Add(new FeladatMoTabla()
            {
                Id = newId,
                FeladatMoPdf = megoldasPdf,
                Szelesseg = megoldasSzelesseg,
                Magassag = megoldasMagassag,
                Kep = moFile.Length == 0 ? null : moFile
            });

            context.SaveChanges();
        }
        private bool ValidPdfURL(string pdfURL)
        {
            Regex r = new Regex("^(https://drive.google.com/file).+(/preview)$");
            return r.IsMatch(pdfURL);
        }

        private bool ValidEv(string ev)
        {
            Regex r = new Regex("^20[0-9]{2}$");
            return r.IsMatch(ev);
        }
        private bool ValidMeret(string meret)
        {
            Regex r = new Regex("^[0-9]{1,5}$");
            return r.IsMatch(meret);
        }
        private bool ValidSorszam(string sorszam)
        {
            Regex r = new Regex("^[0-9]{1,2}$");
            return r.IsMatch(sorszam);
        }

        private void moHonapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void moEvTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void flFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                flKepTextBox.Text = "Hiba!";
                return;
            }
            flKepTextBox.Text = dialog.FileName;
            flFile = File.ReadAllBytes(dialog.FileName);
        }

        private void moFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                moKepTextBox.Text = "Hiba!";
                return;
            }
            moKepTextBox.Text = dialog.FileName;
            moFile = File.ReadAllBytes(dialog.FileName);
        }

        private void flPdfTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidPdfURL(flPdfTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(flPdfTextBox, "A pdf URL nem helyes formátumú! Példa: https://drive.google.com/file/d/.../preview");
            }
        }

        private void flPdfTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(flPdfTextBox, "");            
        }

        private void moPdfTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidPdfURL(moPdfTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(moPdfTextBox, "A pdf URL nem helyes formátumú! Példa: https://drive.google.com/file/d/.../preview");
            }
        }

        private void moPdfTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(moPdfTextBox, "");
        }

        private void flEvTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidEv(flEvTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(flEvTextBox, "Az évnek 2000 és 2099 között kell lennie");
            }
        }

        private void flEvTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(flEvTextBox, "");
        }

        private void moSzelessegTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidMeret(moSzelessegTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(moSzelessegTextBox, "Legalább 1, maximum 5 számjegyű számnak kell lennie!");
            }
        }

        private void moSzelessegTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(moSzelessegTextBox, "");
        }

        private void moMagassagTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidMeret(moSzelessegTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(moMagassagTextBox, "Legalább 1, maximum 5 számjegyű számnak kell lennie!");
            }
        }

        private void moMagassagTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(moMagassagTextBox, "");
        }

        private void flSzelessegTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidMeret(flSzelessegTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(flSzelessegTextBox, "Legalább 1, maximum 5 számjegyű számnak kell lennie!");
            }
        }

        private void flSzelessegTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(flSzelessegTextBox, "");
        }

        private void flMagassagTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidMeret(flMagassagTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(flMagassagTextBox, "Legalább 1, maximum 5 számjegyű számnak kell lennie!");
            }
        }

        private void flMagassagTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(flMagassagTextBox, "");
        }

        private void flSorszamTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidSorszam(flSorszamTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(flSorszamTextBox, "Maximum 2 számjegyű szám lehet!");
            }
        }

        private void flSorszamTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(flSorszamTextBox, "");
        }
    }
}
