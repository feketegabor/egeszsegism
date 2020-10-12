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
    public partial class UserControl8 : UserControl
    {
        Database1Entities context = new Database1Entities();
        public UserControl8()
        {
            InitializeComponent();
            context.FeladatTipusTabla.Load();
            feladatTipusTablaBindingSource.DataSource = context.FeladatTipusTabla.Local;
            context.FeladatTabla.Load();
            feladatTablaBindingSource.DataSource = context.FeladatTabla.Local;
        }

        private void feladatTablaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            feladatTablaBindingSource.EndEdit();
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            feladatTablaDataGridView.Refresh();
        }
    }
}
