using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillTracker
{
    public partial class ViewBillsForm : Form
    {
        AddBillForm billForm;
        Database database;
        public ViewBillsForm(AddBillForm bf, Database db)
        {
            billForm = bf;
            database = db;
            InitializeComponent();
        }

        private void ViewBillsForm_Load(object sender, EventArgs e)
        {
            this.monthlyBillsTableAdapter.Fill(this.billTrackerDataSet5.MonthlyBills);
        }

        private void ViewBillsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (billForm.ViewMenuButton.Enabled == false)
            {
                billForm.ViewMenuButton.Enabled = true;
            }
            if (billForm.Visible != true)
            {
                billForm.Show();
            }
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter a valid number");
                return;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(database.UpdateDatabase(idTextBox.Text, BillTextBox.Text, PriceTextBox.Text, DateTextBox.Text))
            {
                MessageBox.Show("Data Updated");
                monthlyBillsTableAdapter.Fill(this.billTrackerDataSet5.MonthlyBills);
                idTextBox.Text = string.Empty;
                BillTextBox.Text = string.Empty;
                PriceTextBox.Text = string.Empty;
                DateTextBox.Text = string.Empty;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (database.DeleteBill(idTextBox.Text))
            {
                MessageBox.Show("Bill Deleted");
                monthlyBillsTableAdapter.Fill(this.billTrackerDataSet5.MonthlyBills);
                idTextBox.Text = string.Empty;
                BillTextBox.Text = string.Empty;
                PriceTextBox.Text = string.Empty;
                DateTextBox.Text = string.Empty;
            }
        }

        private void AddBillsButton_Click(object sender, EventArgs e)
        {
            if (billForm.Visible != true)
            {
                billForm.Show();
                billForm.ViewMenuButton.Enabled = false;
            }
        }
    }
}
