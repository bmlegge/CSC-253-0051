using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void ascendingPopButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPop(this.cityDBDataSet.City);
        }

        private void descendingPopButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopDesc(this.cityDBDataSet.City);
        }

        private void ascendingNameButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByCity(this.cityDBDataSet.City);
        }

        private void totalPopButton_Click(object sender, EventArgs e)
        {
            double totalPop;

            totalPop = this.cityTableAdapter.PopulationSum(this.cityDBDataSet.City);

            MessageBox.Show($"Total Population of all cities is: {totalPop}.");
        }

        private void avgPopButton_Click(object sender, EventArgs e)
        {
            double avgPop;

            avgPop = this.cityTableAdapter.PopulationAvg(this.cityDBDataSet.City);

            MessageBox.Show($"Average population of all cities is: {avgPop}.");
        }

        private void maxPopButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.HighestPop(this.cityDBDataSet.City);
        }

        private void minPopButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.LowestPop(this.cityDBDataSet.City);
        }
    }
}
