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
    public partial class UserControl6 : UserControl
    {
        Database1Entities context = new Database1Entities();
        public UserControl6()
        {
            InitializeComponent();
            context.FeladatFajtaListaTabla.Load();
            feladatFajtaListaTablaBindingSource.DataSource = context.FeladatFajtaListaTabla.Local;
            context.FeladatTipusTabla.Load();
            feladatTipusTablaBindingSource.DataSource = context.FeladatTipusTabla.Local;
        }

        private void feladatTipusTablaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            feladatTipusTablaBindingSource.EndEdit();
            try
            {
                context.SaveChanges();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            feladatTipusTablaDataGridView.Refresh();
        }
    }
}
