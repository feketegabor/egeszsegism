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
    public partial class UserControl4 : UserControl
    {
        Database1Entities context = new Database1Entities();
        public UserControl4()
        {
            InitializeComponent();

            context.TemakorListaTabla.Load();
            temakorListaTablaBindingSource.DataSource = context.TemakorListaTabla.Local;
        }

        private void temakorListaTablaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            temakorListaTablaBindingSource.EndEdit();
            try
            {
                context.SaveChanges();        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            temakorListaTablaDataGridView.Refresh();
        }
    }
}
