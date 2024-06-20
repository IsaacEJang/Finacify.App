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
        }

        private void buttonTrackExpenseForm_Click(object sender, EventArgs e)
        {
            TrackExpenseForm trackExpenseForm = new TrackExpenseForm();
            trackExpenseForm.Show();
            this.Hide();
        }

        private void buttonMonthsSummaryForm_Click(object sender, EventArgs e)
        {
            MonthsSummary monthsSummaryForm = new MonthsSummary();
            monthsSummaryForm.Show();
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
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
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
    }
}
