using MiniProject___Budgetting_App.Classes;
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
            // Ensure this is the correct instance usage
            var defaultBudget = Budget.DefaultBudget;

            // Access each text box through the roundedGroupBudgetTracker container
            ((TextBox)roundedGroupBudgetTracker.Controls["textBoxGroceryBudget"]).Text = defaultBudget.BudgetGroceries.ToString("C");
            ((TextBox)roundedGroupBudgetTracker.Controls["textBoxGasBudget"]).Text = defaultBudget.BudgetGas.ToString("C");
            ((TextBox)roundedGroupBudgetTracker.Controls["textBoxDiningOutBudget"]).Text = defaultBudget.BudgetDiningOut.ToString("C");
            ((TextBox)roundedGroupBudgetTracker.Controls["textBoxShoppingBudget"]).Text = defaultBudget.BudgetShopping.ToString("C");
            ((TextBox)roundedGroupBudgetTracker.Controls["textBoxMiscBudget"]).Text = defaultBudget.BudgetMisc.ToString("C");

        }


        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

    }
}