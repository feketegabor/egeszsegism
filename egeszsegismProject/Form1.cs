using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace egeszsegismProject
{
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs ea)
        {
            temakorComboBox.DataSource = (from t in context.TemakorListaTabla select t).ToList();
            temakorComboBox.DisplayMember = "Temakor";
            temakorComboBox.ValueMember = "Id";
            temakorComboBox.Enabled = false;

            fajtaComboBox.DataSource = (from f in context.FeladatFajtaListaTabla select f).ToList();
            fajtaComboBox.DisplayMember = "FeladatFajta";
            fajtaComboBox.ValueMember = "Id";
            fajtaComboBox.Enabled = false;

            evComboBox.DataSource = (from e in context.FeladatTabla group e by new { e.Ev } into evgroup select evgroup.Key.Ev.Value ).ToList();
            evComboBox.Enabled = false;

            honapComboBox.DataSource = (from e in context.FeladatTabla group e by new { e.Honap } into evgroup select evgroup.Key.Honap).ToList();
            honapComboBox.Enabled = false;

            tipusListBox.DataSource = (from x in context.FeladatTipusTabla
                                       where x.FeladatFajtaFK == (int)fajtaComboBox.SelectedValue
                                       select x).ToList();
            tipusListBox.DisplayMember = "FeladatTipus";
            tipusListBox.ValueMember = "Id";
            tipusListBox.Enabled = false;

            temaListBox.DataSource = (from x in context.TemaTabla
                                      where x.TemakorFK == (int)temakorComboBox.SelectedValue
                                      select x).ToList();
            temaListBox.DisplayMember = "Tema";
            temaListBox.ValueMember = "Id";
            temaListBox.Enabled = false;
        }

        private void SzuresButton_Click(object sender, EventArgs e)
        {
            var eredmény = (from x in context.FeladatTabla
            select x);

            if (feladatTipusCheckBox.Checked == true)
            {
                eredmény = from x in eredmény
                           where x.FeladatTipusFK == ((FeladatTipusTabla)tipusListBox.SelectedItem).Id
                           select x;
            }
            if (temaCheckBox.Checked == true)
            {
                eredmény = from x in eredmény
                           where x.TemakorFeladatKapcsolo.Any(tema => tema.TemaFK == ((TemaTabla)temaListBox.SelectedItem).Id)
                           select x;
            }
            if (evCheckBox.Checked == true)
            {
                eredmény = from x in eredmény
                           where x.Ev == (int)evComboBox.SelectedItem
                           select x;
            }
            if (honapCheckBox.Checked == true)
            {
                eredmény = from x in eredmény
                           where x.Honap == (string)honapComboBox.SelectedItem
                           select x;
            }
            Form2 form2 = new Form2(eredmény.ToList());
            form2.Show();
        }

        private void FajtaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipusListBox.DataSource = (from x in context.FeladatTipusTabla
                                       where x.FeladatFajtaFK == ((FeladatFajtaListaTabla)fajtaComboBox.SelectedItem).Id
                                       select x).ToList();

        }

        private void TemakorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            temaListBox.DataSource = (from x in context.TemaTabla
                                      where x.TemakorFK == ((TemakorListaTabla)temakorComboBox.SelectedItem).Id
                                      select x).ToList();
        }

        private void feladatTipusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tipusListBox.Enabled = !tipusListBox.Enabled;
        }

        private void feladatFajtaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fajtaComboBox.Enabled = !fajtaComboBox.Enabled;
        }

        private void temakorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            temakorComboBox.Enabled = !temakorComboBox.Enabled;
        }

        private void temaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            temaListBox.Enabled = !temaListBox.Enabled;
        }

        private void evCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            evComboBox.Enabled = !evComboBox.Enabled;
        }

        private void honapCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            honapComboBox.Enabled = !honapComboBox.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void megoldasButton_Click(object sender, EventArgs e)
        {
            var eredmény = (from x in context.FeladatTabla
                            select x);

            if (feladatTipusCheckBox.Checked == true)
            {
                eredmény = from x in eredmény
                           where x.FeladatTipusFK == ((FeladatTipusTabla)tipusListBox.SelectedItem).Id
                           select x;
            }
            if (temaCheckBox.Checked == true)
            {
                eredmény = from x in eredmény
                           where x.TemakorFeladatKapcsolo.Any(tema => tema.TemaFK == ((TemaTabla)temaListBox.SelectedItem).Id)
                           select x;
            }
            if (evCheckBox.Checked == true)
            {
                eredmény = from x in eredmény
                           where x.Ev == (int)evComboBox.SelectedItem
                           select x;
            }
            if (honapCheckBox.Checked == true)
            {
                eredmény = from x in eredmény
                           where x.Honap == (string)honapComboBox.SelectedItem
                           select x;
            }

            var feladatIdList = (from x in eredmény select x.Id).ToList();

            var megoldasok = from x in context.FeladatMoTabla where feladatIdList.Contains(x.Id) select x;

            Form2 form2 = new Form2(megoldasok.ToList());
            form2.Show();
        }






        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    //int sorszam = int.Parse(textBox1.Text);
        //    //byte[] kep = context.FeladatTabla.Single(x => x.Id == sorszam).Kep;
        //    //using (MemoryStream ms = new MemoryStream(kep))
        //    //{
        //    //    Bitmap image = new Bitmap(ms);
        //    //    pictureBox1.Image = image;
        //    //}
        //}
    }
}
