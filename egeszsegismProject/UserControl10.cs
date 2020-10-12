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
    public partial class UserControl10 : UserControl
    {
        Database1Entities context = new Database1Entities();
        public UserControl10()
        {
            InitializeComponent();
            context.TemakorFeladatKapcsolo.Load();
            temakorFeladatKapcsoloBindingSource.DataSource = context.TemakorFeladatKapcsolo.Local;
            context.FeladatTabla.Load();
            feladatTablaBindingSource.DataSource = context.FeladatTabla.Local;
            context.TemaTabla.Load();
            temaTablaBindingSource.DataSource = context.TemaTabla.Local;
        }

        private void temakorFeladatKapcsoloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            temakorFeladatKapcsoloBindingSource.EndEdit();
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            temakorFeladatKapcsoloDataGridView.Refresh();
        }
    }
}
