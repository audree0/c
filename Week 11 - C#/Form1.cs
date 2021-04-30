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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.personnelDataSet.Table);

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDetails detailsForm = new GetDetails();
            detailsForm.ShowDialog();
            tableTableAdapter.Fill(personnelDataSet.Table);
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            tableTableAdapter.FillByHourlyWageA(personnelDataSet.Table);
        }

        private void btnDecending_Click(object sender, EventArgs e)
        {
            tableTableAdapter.FillByHourlyPayD(personnelDataSet.Table);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchByName = textBox1.Text;
            tableTableAdapter.FillByNameResult(personnelDataSet.Table);

        }

        private void btnLowestPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The lowest pay rate is : \n" + tableTableAdapter.SearchLowestPay().ToString());
        }

        private void btnHighestPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The highest pay rate is : \n"+ tableTableAdapter.SearchHighestPay().ToString());
        }
    }
}
