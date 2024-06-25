using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject___Budgetting_App.Classes;

namespace MiniProject___Budgetting_App.Forms
{
    public partial class BuildBudgetForm : Form
    {
        public BuildBudgetForm()
        {
            InitializeComponent();
        }

        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

        private void roundedCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxPostTaxMonthlyIncome.Text, out double monthlyIncome))
            {
                double groceriesRecBudget = monthlyIncome * 0.10;
                double gasRecBudget = monthlyIncome * 0.055;
                double diningOutRecBudget = monthlyIncome * 0.05;
                double shoppingRecBudget = monthlyIncome * 0.05;
                double miscRecBudget = monthlyIncome * 0.04;

                PopulateDataGridView(groceriesRecBudget, gasRecBudget, diningOutRecBudget, shoppingRecBudget, miscRecBudget);
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void PopulateDataGridView(double groceriesRecBudget, double gasRecBudget, double diningOutRecBudget, double shoppingRecBudget, double miscRecBudget)
        {
            // Clear existing columns and rows
            dataGridViewRecommend.Columns.Clear();
            dataGridViewRecommend.Rows.Clear();

            // Add columns
            dataGridViewRecommend.Columns.Add("Groceries", "Groceries");
            dataGridViewRecommend.Columns.Add("Gas", "Gas");
            dataGridViewRecommend.Columns.Add("Dining Out", "Dining Out");
            dataGridViewRecommend.Columns.Add("Shopping", "Shopping");
            dataGridViewRecommend.Columns.Add("Misc", "Misc");


            // Add rows
            dataGridViewRecommend.Rows.Add(groceriesRecBudget.ToString("C"), gasRecBudget.ToString("C"), diningOutRecBudget.ToString("C"), shoppingRecBudget.ToString("C"), miscRecBudget.ToString("C"));
        }

        private void linkLabelRecommendations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string description = "Here are the general recommended budget allocations for different expense categories:";
            string recommendations = "1. Rent: 25-30%\n" +
                                     "2. Utilities: 5-10%\n" +
                                     "3. Groceries: 10-15%\n" +
                                     "4. Dining Out: 5-10%\n" +
                                     "5. Shopping: 5-10%\n" +
                                     "6. Gas/Transportation: 10-15%\n" +
                                     "7. Miscellaneous Expenses: 5-10%\n" +
                                     "8. Savings and Investments: 10-20%";

            string usedPercentages = "For the recommendations shown, the percentages used are:\n" +
                                     "Groceries: 10% \n" +
                                     "Gas: 5.5% \n" +
                                     "Dining Out: 5% \n" +
                                     "Shopping: 5% \n" +
                                     "Miscellaneous Expenses: 4%";

            string message = $"{description}\n\n{recommendations}\n\n{usedPercentages}";

            MessageBox.Show(message, "Budget Recommendations");
        }


        private void linkLabelSetBudget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Here, you can set your own budget! \n\n" +
                     "If the recommended amount is too much or too little in a certain category, " +
                     "feel free to adjust it to suit your needs! " +
                     "\n\nTake control of your finances and make your budget work for you!";

            MessageBox.Show(message, "Set Your Own Budget");
        }


        private void roundedButtonSaveBudget_Click(object sender, EventArgs e)
        {
            

            if (true)
            {
                Data.defaultBudget.BudgetGroceries = decimal.Parse(textBoxSetBudgetGroceries.Text);
                Data.defaultBudget.BudgetGas = decimal.Parse(textBoxSetBudgetGas.Text);
                Data.defaultBudget.BudgetDiningOut = decimal.Parse(textBoxSetBudgetDiningOut.Text);
                Data.defaultBudget.BudgetShopping = decimal.Parse(textBoxSetBudgetShopping.Text);
                Data.defaultBudget.BudgetMisc = decimal.Parse(textBoxSetBudgetMisc.Text);

                textBoxSetBudgetGroceries.Clear();
                textBoxSetBudgetGas.Clear();
                textBoxSetBudgetDiningOut.Clear();
                textBoxSetBudgetShopping.Clear();
                textBoxSetBudgetMisc.Clear();
                MessageBox.Show("Your budget has been saved! \n\nYou can see it on '💸 Budget Tracker'", "Budget Saved");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in all fields.", "Invalid Input");
            }
        }

    }
}
