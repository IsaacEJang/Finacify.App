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

            // Set the placeholder text for the specified TextBoxes and add event handlers
            SetExamplePostTaxMonthlyIncome();
            textBoxPostTaxMonthlyIncome.Enter += textBoxPostTaxMonthlyIncome_Enter;
            textBoxPostTaxMonthlyIncome.Leave += textBoxPostTaxMonthlyIncome_Leave;

            SetExampleSetBudgetGroceries();
            textBoxSetBudgetGroceries.Enter += textBoxSetBudgetGroceries_Enter;
            textBoxSetBudgetGroceries.Leave += textBoxSetBudgetGroceries_Leave;

            SetExampleSetBudgetGas();
            textBoxSetBudgetGas.Enter += textBoxSetBudgetGas_Enter;
            textBoxSetBudgetGas.Leave += textBoxSetBudgetGas_Leave;

            SetExampleSetBudgetDiningOut();
            textBoxSetBudgetDiningOut.Enter += textBoxSetBudgetDiningOut_Enter;
            textBoxSetBudgetDiningOut.Leave += textBoxSetBudgetDiningOut_Leave;

            SetExampleSetBudgetShopping();
            textBoxSetBudgetShopping.Enter += textBoxSetBudgetShopping_Enter;
            textBoxSetBudgetShopping.Leave += textBoxSetBudgetShopping_Leave;

            SetExampleSetBudgetMisc();
            textBoxSetBudgetMisc.Enter += textBoxSetBudgetMisc_Enter;
            textBoxSetBudgetMisc.Leave += textBoxSetBudgetMisc_Leave;
        }

        #region EnterAndLeaveEventHandler
        private void SetExamplePostTaxMonthlyIncome()
        {
            textBoxPostTaxMonthlyIncome.Text = "10000";
            textBoxPostTaxMonthlyIncome.ForeColor = Color.Gray; // Set the text color to gray to indicate it is a placeholder
        }

        private void textBoxPostTaxMonthlyIncome_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change the text color to black
            if (textBoxPostTaxMonthlyIncome.Text == "10000")
            {
                textBoxPostTaxMonthlyIncome.Text = "";
                textBoxPostTaxMonthlyIncome.ForeColor = Color.Black;
            }
        }

        private void textBoxPostTaxMonthlyIncome_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty, reset the placeholder text
            if (string.IsNullOrWhiteSpace(textBoxPostTaxMonthlyIncome.Text))
            {
                SetExamplePostTaxMonthlyIncome();
            }
        }

        private void SetExampleSetBudgetGroceries()
        {
            textBoxSetBudgetGroceries.Text = "750";
            textBoxSetBudgetGroceries.ForeColor = Color.Gray; // Set the text color to gray to indicate it is a placeholder
        }

        private void textBoxSetBudgetGroceries_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change the text color to black
            if (textBoxSetBudgetGroceries.Text == "750")
            {
                textBoxSetBudgetGroceries.Text = "";
                textBoxSetBudgetGroceries.ForeColor = Color.Black;
            }
        }

        private void textBoxSetBudgetGroceries_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty, reset the placeholder text
            if (string.IsNullOrWhiteSpace(textBoxSetBudgetGroceries.Text))
            {
                SetExampleSetBudgetGroceries();
            }
        }

        private void SetExampleSetBudgetGas()
        {
            textBoxSetBudgetGas.Text = "550";
            textBoxSetBudgetGas.ForeColor = Color.Gray; // Set the text color to gray to indicate it is a placeholder
        }

        private void textBoxSetBudgetGas_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change the text color to black
            if (textBoxSetBudgetGas.Text == "550")
            {
                textBoxSetBudgetGas.Text = "";
                textBoxSetBudgetGas.ForeColor = Color.Black;
            }
        }

        private void textBoxSetBudgetGas_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty, reset the placeholder text
            if (string.IsNullOrWhiteSpace(textBoxSetBudgetGas.Text))
            {
                SetExampleSetBudgetGas();
            }
        }

        private void SetExampleSetBudgetDiningOut()
        {
            textBoxSetBudgetDiningOut.Text = "450";
            textBoxSetBudgetDiningOut.ForeColor = Color.Gray; // Set the text color to gray to indicate it is a placeholder
        }

        private void textBoxSetBudgetDiningOut_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change the text color to black
            if (textBoxSetBudgetDiningOut.Text == "450")
            {
                textBoxSetBudgetDiningOut.Text = "";
                textBoxSetBudgetDiningOut.ForeColor = Color.Black;
            }
        }

        private void textBoxSetBudgetDiningOut_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty, reset the placeholder text
            if (string.IsNullOrWhiteSpace(textBoxSetBudgetDiningOut.Text))
            {
                SetExampleSetBudgetDiningOut();
            }
        }

        private void SetExampleSetBudgetShopping()
        {
            textBoxSetBudgetShopping.Text = "450";
            textBoxSetBudgetShopping.ForeColor = Color.Gray; // Set the text color to gray to indicate it is a placeholder
        }

        private void textBoxSetBudgetShopping_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change the text color to black
            if (textBoxSetBudgetShopping.Text == "450")
            {
                textBoxSetBudgetShopping.Text = "";
                textBoxSetBudgetShopping.ForeColor = Color.Black;
            }
        }

        private void textBoxSetBudgetShopping_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty, reset the placeholder text
            if (string.IsNullOrWhiteSpace(textBoxSetBudgetShopping.Text))
            {
                SetExampleSetBudgetShopping();
            }
        }

        private void SetExampleSetBudgetMisc()
        {
            textBoxSetBudgetMisc.Text = "500";
            textBoxSetBudgetMisc.ForeColor = Color.Gray; // Set the text color to gray to indicate it is a placeholder
        }

        private void textBoxSetBudgetMisc_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change the text color to black
            if (textBoxSetBudgetMisc.Text == "500")
            {
                textBoxSetBudgetMisc.Text = "";
                textBoxSetBudgetMisc.ForeColor = Color.Black;
            }
        }

        private void textBoxSetBudgetMisc_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty, reset the placeholder text
            if (string.IsNullOrWhiteSpace(textBoxSetBudgetMisc.Text))
            {
                SetExampleSetBudgetMisc();
            }
        } 
        #endregion


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
            // Validate inputs
            if (decimal.TryParse(textBoxSetBudgetGroceries.Text, out decimal budgetGroceries) &&
                decimal.TryParse(textBoxSetBudgetGas.Text, out decimal budgetGas) &&
                decimal.TryParse(textBoxSetBudgetDiningOut.Text, out decimal budgetDiningOut) &&
                decimal.TryParse(textBoxSetBudgetShopping.Text, out decimal budgetShopping) &&
                decimal.TryParse(textBoxSetBudgetMisc.Text, out decimal budgetMisc))
            {
                // Save budgets
                DataBudget.defaultBudget.BudgetGroceries = decimal.Parse(textBoxSetBudgetGroceries.Text);
                DataBudget.defaultBudget.BudgetGas = decimal.Parse(textBoxSetBudgetGas.Text);
                DataBudget.defaultBudget.BudgetDiningOut = decimal.Parse(textBoxSetBudgetDiningOut.Text);
                DataBudget.defaultBudget.BudgetShopping = decimal.Parse(textBoxSetBudgetShopping.Text);
                DataBudget.defaultBudget.BudgetMisc = decimal.Parse(textBoxSetBudgetMisc.Text);

                // Clear text boxes
                textBoxSetBudgetGroceries.Clear();
                textBoxSetBudgetGas.Clear();
                textBoxSetBudgetDiningOut.Clear();
                textBoxSetBudgetShopping.Clear();
                textBoxSetBudgetMisc.Clear();

                // Show success message
                MessageBox.Show("Your budget has been saved! \n\nYou can see it on '💸 Budget Tracker'", "Budget Saved");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in all fields.", "Invalid Input");
            }
        }

    }
}
