using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using ConsoleUI;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee employee1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
            Employee employee2 = new Employee("Mark Jones", 39119, "IT", "Programmer");
            Employee employee3 = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");

            employeeListBox.Items.Add($"{employee1.Name}\t{employee1.IdNumber}\t\t{employee1.Department}\t\t{employee1.Position}");
            employeeListBox.Items.Add($"{employee2.Name}\t{employee2.IdNumber}\t\t{employee2.Department}\t\t\t{employee2.Position}");
            employeeListBox.Items.Add($"{employee3.Name}\t{employee3.IdNumber}\t\t{employee3.Department}\t\t{employee3.Position}");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
