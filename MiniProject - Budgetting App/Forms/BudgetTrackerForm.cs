using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject___Budgetting_App
{
    public partial class BudgetTrackerForm : Form
    {
        public BudgetTrackerForm()
        {
            InitializeComponent();
        }

        private void BudgetTrackerForm_Load(object sender, EventArgs e)
        {
            // Set the text of textBoxCurrentMonth to the current month and year
            textBoxCurrentMonth.Text = DateTime.Now.ToString("MMMM yyyy");

            //BudgetValueStorage budgetStorage = new BudgetValueStorage();

            // Load budget values
            //textBoxBudgetGroceries.Text = budgetStorage.BudgetValues.TryGetValue("Groceries", out double groceries) ? groceries.ToString("C") : "$0.00";
            //textBoxBudgetGas.Text = budgetStorage.BudgetValues.TryGetValue("Gas", out double gas) ? gas.ToString("C") : "$0.00";
            //textBoxBudgetDiningOut.Text = budgetStorage.BudgetValues.TryGetValue("DiningOut", out double diningOut) ? diningOut.ToString("C") : "$0.00";
            //textBoxBudgetShopping.Text = budgetStorage.BudgetValues.TryGetValue("Shopping", out double shopping) ? shopping.ToString("C") : "$0.00";
            //textBoxBudgetMisc.Text = budgetStorage.BudgetValues.TryGetValue("Misc", out double misc) ? misc.ToString("C") : "$0.00";

            //// Initialize spent and leftover text boxes
            //textBoxSpentGroceries.Text = "$0.00";
            //textBoxSpentGas.Text = "$0.00";
            //textBoxSpentDiningOut.Text = "$0.00";
            //textBoxSpentShopping.Text = "$0.00";
            //textBoxSpentMisc.Text = "$0.00";

            //textBoxLeftOverGroceries.Text = textBoxBudgetGroceries.Text;
            //textBoxLeftOverGas.Text = textBoxBudgetGas.Text;
            //textBoxLeftOverDiningOut.Text = textBoxBudgetDiningOut.Text;
            //textBoxLeftOverShopping.Text = textBoxBudgetShopping.Text;
            //textBoxLeftOverMisc.Text = textBoxBudgetMisc.Text;

            //// Calculate totals
            //CalculateTotals();
        }

        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }
    }
}
