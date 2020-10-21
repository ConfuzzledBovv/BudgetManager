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
    public partial class AddBillForm : Form
    {
        string date;
        Database database;

        public AddBillForm(Database db)
        {
            database = db;
            InitializeComponent();
            MenuItems();
            AddBillsMenuButton.Enabled = false;
        }

        private void Bill_Name_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter a valid character");
                return;
            }

        }

        private void BillPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please Enter a valid number");
                return;
            }
        }

        private void BillCalendarDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(e.Start.ToShortDateString());
            date = e.Start.ToShortDateString();
        }

        private void Enter_Data_Button(object sender, EventArgs e)
        {
            if(Bill_Name_Text.Text != "" && BillPrice.Value != 0 && date != null)
            {
                database.AddBill(Bill_Name_Text.Text, BillPrice.Value, date, recurringCheck.Checked);
                MessageBox.Show("Bill: " + Bill_Name_Text.Text + "\nPrice: " + BillPrice.Text + "\nDate: " + date + "\nRecurring bill: " + recurringCheck.Checked + "\nHas been added to the database");
                Bill_Name_Text.Text = "";
                BillPrice.Value = 0;
            }
            else
            {
                MessageBox.Show("Please fill all data fields\nBill: " + Bill_Name_Text.Text + "\nPrice: " + BillPrice.Text + "\nDate: " + date);
            }
        }

        private void SetFoodRemainingLabelData()
        {
            decimal value = RetrieveMonthlyFoodBudget() - RetrieveFoodSpentAmount();
            FoodRemainingLabel.Text = "Budget remaining £" + value;
        }

        private void SetFoodSpentLabelData()
        {
            FoodSpentLabel.Text = "Budget spent £" + RetrieveFoodSpentAmount();
        }

        private void AddFoodBillButton_Click(object sender, EventArgs e)
        {
            if (FoodBillTextBox.Value == 0)
            {
                MessageBox.Show("Please fill all data fields");
                return;
            }
            decimal value = RetrieveFoodSpentAmount() + FoodBillTextBox.Value;
            database.AddFoodBill(value);
            FoodBillTextBox.Value = 0;
            MessageBox.Show("Food bill added");
            Console.WriteLine(RetrieveFoodSpentAmount());
            if(RemoveFoodBillButton.Visible == false && RetrieveFoodSpentAmount() > 0)
            {
                RemoveFoodBillButton.Visible = true;
            }
            UpdateLabels();
        }
        private void RemoveFoodBillButton_Click(object sender, EventArgs e)
        {
            if (FoodBillTextBox.Value == 0)
            {
                MessageBox.Show("Please fill all data fields");
                return;
            }

            decimal value = RetrieveFoodSpentAmount();
            value = value - FoodBillTextBox.Value;
            database.AddFoodBill(value);
            MessageBox.Show("Food bill updated");
            UpdateLabels();
            FoodBillTextBox.Value = 0;

            if(RetrieveFoodSpentAmount() <= 0)
            {
                RemoveFoodBillButton.Visible = false;
            }
        }

        private void UpdateLabels()
        {
            SetFoodRemainingLabelData();
            SetFoodSpentLabelData();
        }

        private decimal RetrieveFoodSpentAmount()
        {
            decimal.TryParse(database.RetrieveBudget("FoodSpent"), out decimal temp);

            return temp;
        }


        private void FoodBillTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter a valid character");
                return;
            }

        }

        private decimal RetrieveMonthlyFoodBudget()
        {
            decimal.TryParse(database.RetrieveBudget("MonthlyFoodBudget"), out decimal temp);

            return temp;
        }

        private void AddBillForm_Load(object sender, EventArgs e)
        {
            this.monthlyFoodTableAdapter.Fill(this.billTrackerDataSet.MonthlyFood);
        }

        private void ViewMenuButton_Click(object sender, EventArgs e)
        {
            ViewBillsForm viewForm = new ViewBillsForm(this, database);
            viewForm.Show();
            Bill_Name_Text.Text = "";
            BillPrice.Value = 0;
            ViewMenuButton.Enabled = false;
        }

        private void AddFoodBillsMenuButton_Click(object sender, EventArgs e)
        {
            ShowAddFoodForm();
            UpdateLabels();
            AddFoodBillsMenuButton.Enabled = false;
            AddBillsMenuButton.Enabled = true;
            this.monthlyFoodTableAdapter.Fill(this.billTrackerDataSet.MonthlyFood);
            if (RetrieveFoodSpentAmount() <= 0)
            {
                RemoveFoodBillButton.Visible = false;
            }
        }

        private void AddBillsMenuButton_Click(object sender, EventArgs e)
        {
            AddFoodBillsMenuButton.Enabled = true;       
            AddBillsMenuButton.Enabled = false;           
            FoodBillTextBox.Dispose();
            MonthlyFoodTable.Dispose();
            billTrackerDataSet.Dispose();
            monthlyFoodBindingSource.Dispose();
            monthlyFoodTableAdapter.Dispose();
            monthDataGridViewTextBoxColumn.Dispose();
            yearDataGridViewTextBoxColumn.Dispose();
            spentDataGridViewTextBoxColumn.Dispose();
            remainsDataGridViewTextBoxColumn.Dispose();
            Title.Dispose();
            PriceLabel.Dispose();
            RemoveFoodBillButton.Dispose();
            AddFoodBillButton.Dispose();
            FoodRemainingLabel.Dispose();
            FoodSpentLabel.Dispose();
            components.Dispose();
            
            InitializeComponent();
            this.leftOverMonthlyTableAdapter.Fill(this.billTrackerDataSet3.LeftOverMonthly);
        }

        private void NewMonthMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Start a fresh month", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            decimal.TryParse(database.RetrieveBudget("FoodSpent"), out decimal foodSpent);
            decimal.TryParse(database.RetrieveBudget("FoodRemains"), out decimal foodRemains);
            decimal.TryParse(database.RetrieveBudget("MonthlyBudget"), out decimal budget);
            decimal budgetSpent = database.WorkOutSpentMoney(false);

            if(!database.NewMonth(foodSpent, foodRemains, budget - budgetSpent))
            {
                MessageBox.Show("There was an error!");
                return;
            }
            MessageBox.Show("New month started, tables updated");
        }

        private void SetButtonEnabled()
        {
            if(AddBillsMenuButton.Enabled == true)
            {
                Console.WriteLine("AddBillButton was true now false");
                AddBillsMenuButton.Enabled = false;
            }
            else
            {
                AddBillsMenuButton.Enabled = true;
            }

            if(AddFoodBillsMenuButton.Enabled == true)
            {
                AddFoodBillsMenuButton.Enabled = false;
            }
            else
            {
                AddFoodBillsMenuButton.Enabled = true;
            }
        }

        private void AddBillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddBillForm_Load_1(object sender, EventArgs e)
        {
            this.leftOverMonthlyTableAdapter.Fill(this.billTrackerDataSet3.LeftOverMonthly);
        }
    }
}
