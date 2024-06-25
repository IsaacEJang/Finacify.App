using MiniProject___Budgetting_App.Classes;
using MiniProject___Budgetting_App.Forms;
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
            CurrentMonth();
            LoadBudgetTracker();
        }

        public void CurrentMonth()
        {

            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Format the date to display only the month and year
            string currentMonthYear = currentDate.ToString("MMMM yyyy"); // "MMMM" for full month name, "yyyy" for the year

            // Display the current month and year in the label
            textBoxCurrentMonth.Text = currentMonthYear;
        }

        public void LoadBudgetTracker()
        {

            // Get the default budget instance from the static property
            //Budget defaultBudget = new Budget();


            //// Setting text boxes with formatted currency values
            textBoxGroceryBudget.Text = Data.defaultBudget.BudgetGroceries.ToString("C");
            textBoxGasBudget.Text = Data.defaultBudget.BudgetGas.ToString("C");
            textBoxDiningOutBudget.Text = Data.defaultBudget.BudgetDiningOut.ToString("C");
            textBoxShoppingBudget.Text = Data.defaultBudget.BudgetShopping.ToString("C");
            textBoxMiscBudget.Text = Data.defaultBudget.BudgetMisc.ToString("C");
        }



        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

        private void buttonViewTransactions_Click(object sender, EventArgs e)
        {
            ViewTransactionsForm viewTransactionsForm = new ViewTransactionsForm();
            viewTransactionsForm.Show();
            this.Hide();
        }
    }
}