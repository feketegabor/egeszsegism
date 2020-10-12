using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace egeszsegismProject
{
    public partial class UserControl2 : UserControl
    {
        Database1Entities context = new Database1Entities();
        public UserControl2()
        {
            InitializeComponent();
            feladatListBox.DisplayMember = "Id";
            feladatListBox.ValueMember = "Id";
            feladatListBox.DataSource = (from x in context.FeladatTabla select x).ToList();

            context.FeladatTabla.Load();
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            int idToDelete = (int)feladatListBox.SelectedValue;

            //FeladatMoTabla megoldasToDelete = (from x in context.FeladatMoTabla where x.Id == idToDelete select x).FirstOrDefault();
            FeladatMoTabla megoldasToDelete = context.FeladatMoTabla.Local.FirstOrDefault(x => x.Id == idToDelete);
            context.FeladatMoTabla.Local.Remove(megoldasToDelete);
            //context.Entry(megoldasToDelete).State = EntityState.Deleted;
            context.SaveChanges();

            //TemakorFeladatKapcsolo temakorFeladatKapcsoloToDelete = (from x in context.TemakorFeladatKapcsolo where x.FeladatFK == idToDelete select x).FirstOrDefault();
            TemakorFeladatKapcsolo temakorFeladatKapcsoloToDelete = context.TemakorFeladatKapcsolo.Local.FirstOrDefault(x => x.FeladatFK == idToDelete);
            context.TemakorFeladatKapcsolo.Local.Remove(temakorFeladatKapcsoloToDelete);
            //context.Entry(temakorFeladatKapcsoloToDelete).State = EntityState.Deleted;
            context.SaveChanges();

            //FeladatTabla feladatToDelete = (from x in context.FeladatTabla where x.Id == idToDelete select x).FirstOrDefault();
            FeladatTabla feladatToDelete = context.FeladatTabla.Local.FirstOrDefault(x => x.Id == idToDelete);
            context.FeladatTabla.Local.Remove(feladatToDelete);
            //context.Entry(feladatToDelete).State = EntityState.Deleted;

            context.SaveChanges();

            //feladatListBox.Refresh();
        }
    }
}
