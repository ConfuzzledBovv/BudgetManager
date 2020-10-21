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
    public partial class Homepage : Form
    {
        Database database;
        AddBillForm billForm;
        ViewBillsForm viewForm;
        decimal budgetRemaining;
        public Homepage(Database db, AddBillForm abf, ViewBillsForm vbf)
        {
            InitializeComponent();
            database = db;
            billForm = abf;
            viewForm = vbf;
            PopulateGraph();
        }

        private void PopulateGraph()
        {

            this.chart1.Series["Spent"].Points.AddXY("Bills spent", GraphData("Standard"));
            this.chart1.Series["Budget"].Points.AddXY("Budget", database.RetrieveBudget("MonthlyBudget"));

            this.chart1.Series["Spent"].Points.AddXY("Food", GraphData("Food"));
            this.chart1.Series["Budget"].Points.AddXY("Budget", database.RetrieveBudget("MonthlyFoodBudget"));

        }

        private decimal GraphData(string name)
        {
            decimal budget;
            switch (name)
            {
                case "Food":
                budget = database.WorkOutSpentMoney(true, "FoodSpent");
                    Console.WriteLine(budget);
                break;
                case "Standard":
                    budget = database.WorkOutSpentMoney(false);
                    Console.WriteLine(budget);
                    break;
                default:
                    budget = -1;
                    MessageBox.Show("There was an error!");
                    break;    
            }
            return budget;
        }

        private void IdentifierTexts()
        {
            BudgetIdentifier.Text = "£" + database.RetrieveBudget("MonthlyBudget");
            BudgetRemainingIdentifier.Text = "£" + WorkoutBudgetRemaining();
            FoodIdentifier.Text = "£" + database.RetrieveBudget("MonthlyFoodBudget");
            FoodRemainingIdentifier.Text = "£" + SetFoodRemainingIdentifier();

            UpdateFinalTotal();

        }

        private void UpdateFinalTotal()
        {
            decimal finalTotal = WorkoutBudgetRemaining() + SetFoodRemainingIdentifier();
            FinalLeftOverBudget.Text = "Total Remaining £" + finalTotal;
        }


        private decimal SetFoodRemainingIdentifier()
        {
            decimal.TryParse(database.RetrieveBudget("MonthlyFoodBudget"), out decimal budget);
            budget -= database.WorkOutSpentMoney(true, "FoodSpent");
            return budget;
        }

        private decimal WorkoutBudgetRemaining()
        {
            decimal.TryParse(database.RetrieveBudget("MonthlyBudget"), out budgetRemaining);
            budgetRemaining -= database.WorkOutSpentMoney(false);
            return budgetRemaining;
        }

        private decimal WorkoutRemainingFoodBudget()
        {
            decimal temp = ChangeFoodBudgetText.Value - database.WorkOutSpentMoney(true, "FoodSpent");

            return temp;
        }
    
        private void BudgetButton_Click(object sender, EventArgs e)
        {
            database.UpdateMonthlyBudgetValue(ChangeBudgetText.Value);
            BudgetIdentifier.Text = "£" + database.RetrieveBudget("MonthlyBudget");
            BudgetRemainingIdentifier.Text = "£" + WorkoutBudgetRemaining();
            UpdateFinalTotal();
        }
        private void FoodBudgetButton_Click(object sender, EventArgs e)
        {
            database.UpdateMonthlyFoodBudgetValue(ChangeFoodBudgetText.Value);
            FoodIdentifier.Text = "£" + ChangeFoodBudgetText.Value;
            FoodRemainingIdentifier.Text = "£" + WorkoutRemainingFoodBudget();
            UpdateFinalTotal();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            RemoveManagerPage();
            InitializeComponent();
            ManageBudgetsButton.Enabled = true;
            PopulateGraph();
        }

        private void RemoveManagerPage()
        {
            TitleLabel.Dispose();
            SubTitleBudgetLabel.Dispose();
            SubTitleFoodLabel.Dispose();
            BudgetButton.Dispose();
            FoodBudgetButton.Dispose();
            FoodBudgetLabel.Dispose();
            CurrentBudget.Dispose();
            RemainingBudgetLabel.Dispose();
            BudgetIdentifier.Dispose();
            ChangeBudgetText.Dispose();
            ChangeFoodBudgetText.Dispose();
            BudgetRemainingIdentifier.Dispose();
            FoodIdentifier.Dispose();
            DividerX.Dispose();
            DividerXBottom.Dispose();
            DividerY.Dispose();
            BackButton.Dispose();
            FoodRemainingIdentifier.Dispose();
            RemainingFoodLabel.Dispose();
            FinalLeftOverBudget.Dispose();
        }

        private void AddBillsButton_Click(object sender, EventArgs e)
        {
            billForm.Show();
            this.Hide();
        }

        private void ViewBillsButton_Click(object sender, EventArgs e)
        {
            viewForm.Show();
            this.Hide();
        }

        private void ManageBudgetsButton_Click(object sender, EventArgs e)
        {
            this.chart1.Dispose();
            InitializeBudgetManagement();
            IdentifierTexts();
            ManageBudgetsButton.Enabled = false;
        }
    }
}
