using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egeszsegismProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl3 userControl3 = new UserControl3();
            szerkesztoPanel.Controls.Clear();
            szerkesztoPanel.Controls.Add(userControl3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl8 userControl8 = new UserControl8();
            szerkesztoPanel.Controls.Clear();
            szerkesztoPanel.Controls.Add(userControl8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl4 userControl4 = new UserControl4();
            szerkesztoPanel.Controls.Clear();
            szerkesztoPanel.Controls.Add(userControl4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl5 userControl5 = new UserControl5();
            szerkesztoPanel.Controls.Clear();
            szerkesztoPanel.Controls.Add(userControl5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserControl6 userControl6 = new UserControl6();
            szerkesztoPanel.Controls.Clear();
            szerkesztoPanel.Controls.Add(userControl6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserControl7 userControl7 = new UserControl7();
            szerkesztoPanel.Controls.Clear();
            szerkesztoPanel.Controls.Add(userControl7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserControl9 userControl9 = new UserControl9();
            szerkesztoPanel.Controls.Clear();
            szerkesztoPanel.Controls.Add(userControl9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserControl10 userControl10 = new UserControl10();
            szerkesztoPanel.Controls.Clear();
            szerkesztoPanel.Controls.Add(userControl10);
        }
    }
}
