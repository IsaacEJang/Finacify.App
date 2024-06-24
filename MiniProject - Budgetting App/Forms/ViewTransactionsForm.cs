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
    public partial class ViewTransactionsForm : Form
    {
        public ViewTransactionsForm()
        {
            InitializeComponent();

            ViewTransactionsForm_Load();

        }

        private void buttonBackHome_Click_1(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

        public void ViewTransactionsForm_Load()
        {

            // Retrieve the list of expenses
            List<Expense> expenses = Expense.GetExpenses();

            // Bind the DataGridView to the list of expenses
            dataGridViewTransactions.DataSource = expenses;


            // Set the column headers to the desired text
            dataGridViewTransactions.Columns["Date"].HeaderText = "Date";
            dataGridViewTransactions.Columns["Category"].HeaderText = "Category";
            dataGridViewTransactions.Columns["Amount"].HeaderText = "Amount ($)";
            dataGridViewTransactions.Columns["Description"].HeaderText = "Description";
        }


        private void roundedEditTransaction_Click(object sender, EventArgs e)
        {
            
        }

        private void roundedButtonDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the index of the selected transaction
            var selectedIndex = dataGridViewTransactions.SelectedRows[0].Index;

            // Ask the user for confirmation
            var result = MessageBox.Show("Are you sure you want to delete the selected transaction?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Remove the transaction at the selected index
                Expense.GetExpenses().RemoveAt(selectedIndex);

                // Refresh the DataGridView
                RefreshDataGridView();

                // Display confirmation message
                MessageBox.Show("Transaction has been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshDataGridView()
        {
            dataGridViewTransactions.DataSource = null;
            dataGridViewTransactions.DataSource = Expense.GetExpenses();

            // Optional: Set the column headers to the desired text
            dataGridViewTransactions.Columns["Date"].HeaderText = "Date";
            dataGridViewTransactions.Columns["Category"].HeaderText = "Category";
            dataGridViewTransactions.Columns["Amount"].HeaderText = "Amount";
            dataGridViewTransactions.Columns["Description"].HeaderText = "Description";
        }
    }
}
