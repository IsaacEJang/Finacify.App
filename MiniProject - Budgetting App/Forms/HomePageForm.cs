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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 300);
        }

        private void buttonTrackExpenseForm_Click(object sender, EventArgs e)
        {
            TrackExpenseForm trackExpenseForm = new TrackExpenseForm();
            trackExpenseForm.Show();
            this.Hide();
        }

        private void buttonMonthsSummaryForm_Click(object sender, EventArgs e)
        {
            BudgetTrackerForm budgetTrackerForm = new BudgetTrackerForm();
            budgetTrackerForm.Show();
            this.Hide();
        }

        private void buttonViewTransactionsForm_Click(object sender, EventArgs e)
        {
            ViewTransactionsForm viewTransactionsForm = new ViewTransactionsForm();
            viewTransactionsForm.Show();
            this.Hide();
        }

        private void buttonAnnualSummaryForm_Click(object sender, EventArgs e)
        {
            AnnualSummaryForm annualSummaryForm = new AnnualSummaryForm();
            annualSummaryForm.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            // Ask the user for confirmation
            var result = MessageBox.Show("Are you sure you want to exit the program?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { 
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void ButtonBuildBudget_Click(object sender, EventArgs e)
        {
            BuildBudgetForm buildBudgetForm = new BuildBudgetForm();
            buildBudgetForm.Show();
            this.Hide();
        }

        private void roundedButtonLogIncome_Click(object sender, EventArgs e)
        {
            LogIncomeForm logIncomeForm = new LogIncomeForm();
            logIncomeForm.Show();
            this.Hide();
        }

        private void roundedButtonInformation_Click(object sender, EventArgs e)
        {
            // Ask the user if they want to take a tour
            DialogResult result = MessageBox.Show("Would you like to take a tour?", "Welcome", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                UserTour();
            }
            
        }

        private void roundedButtonFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm feedbackForm = new FeedbackForm();
            feedbackForm.Show();
            this.Hide();
        }

        public void UserTour()
        {
            // Start the tour by showing the first form and a message
            BuildBudgetForm buildBudgetForm = new BuildBudgetForm();
            buildBudgetForm.Show();
            this.Hide();

            DialogResult result = MessageBox.Show("This page is where you can create your own budget. \n\n" +
                "Start by inputting your Total Monthly Income (Post Tax) and click the 'Calculate' button. \n\n" +
                "You can read more by clicking on the 'Recommendations' and 'Set Your Budget' links!\n\n" +
                "After you input whatever numbers your comforatble with, make sure to click '💾 Save Budget'!", "🏦 Build Budget Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (result == DialogResult.OK)
            {
                TrackExpenseForm trackExpenseForm = new TrackExpenseForm();
                trackExpenseForm.Show();
                buildBudgetForm.Hide();

                result = MessageBox.Show("This page is where you can track all your expenses.\n\n" +
                    "Select a Date, Category, enter the Amount, and an Item Description. \n\n" +
                    "Once you click on the '💸 Submit' button, your expense will be saved!", "💳 Track Expense Page", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    ViewTransactionsForm viewTransactionsForm = new ViewTransactionsForm();
                    viewTransactionsForm.Show();
                    trackExpenseForm.Hide();

                    result = MessageBox.Show("This page is where you can see all your transactions.\n\n" +
                        "You can Delete(🗑), Edit(✏️), or Add(➕) transactions!\n\n" +
                        "The most recent transactions will be at the top!\n\n" +
                        "At the top right, you can find the Export to Excel(📤) Button", "🧾 View Transactions Page", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        BudgetTrackerForm budgetTrackerForm = new BudgetTrackerForm();
                        budgetTrackerForm.Show();
                        viewTransactionsForm.Hide();

                        result = MessageBox.Show("This page is where you can see a budget summary of your current month.\n\n" +
                            "On the left, you will the current month's budget breakdown summary. " +
                            "You can view other months by clicking the ◀ and ▶ arrow buttons. \n\n" +
                            "On the right, you will find different ways of visualizing your budget:\n" +
                            "📊 will show you the Bar Graph.\n" +
                            "🥧 will show you the Pie Chart.\n\n" +
                            "On the top right, you can quickly access the '🧾 View Transactions Page'.", "💸 Budget Tracker Page", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            FeedbackForm feedbackForm = new FeedbackForm();
                            feedbackForm.Show();
                            budgetTrackerForm.Hide();

                            result = MessageBox.Show("This page is where you can leave feedback, whether that is to report a bug or request a feature.\n\n" +
                                "Choose the Type of Feedback, and on Which Page. Then leave a comment and click '📪 Submit'!", "📝 Leave Feedback Page", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (result == DialogResult.OK)
                            {

                                // Show the HomePageForm at the end of the tour
                                HomePageForm homePageForm = new HomePageForm();
                                homePageForm.Show();
                                feedbackForm.Hide();

                                MessageBox.Show("Welcome to the Finacify®️ App!\n\n Hope you enjoy!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
            }
        }
    }
}
