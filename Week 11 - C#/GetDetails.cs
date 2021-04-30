using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11_CS_PersonnelDatabase
{
    public partial class GetDetails : Form
    {
        public GetDetails()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void GetDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.personnelDataSet.Table);

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
