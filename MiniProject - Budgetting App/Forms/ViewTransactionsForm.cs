using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ClosedXML.Excel;
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

            // Sort the list of expenses by date in descending order will show most recent first
            var sortedExpenses = expenses.OrderByDescending(expense => expense.Date).ToList();

            // Bind the DataGridView to the sorted list of expenses
            dataGridViewTransactions.DataSource = sortedExpenses;

            // Set the column headers to the desired text
            dataGridViewTransactions.Columns["Date"].HeaderText = "Date";
            dataGridViewTransactions.Columns["Category"].HeaderText = "Category";
            dataGridViewTransactions.Columns["Amount"].HeaderText = "Amount ($)";
            dataGridViewTransactions.Columns["Description"].HeaderText = "Description";

            // Auto-size the columns to fit the DataGridView width
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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


        private void buttonDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction. \n\n Click on the first column and ensure the whole row is highlighted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the index of the selected transaction
            var selectedIndex = dataGridViewTransactions.SelectedRows[0].Index;

            // Ask the user for confirmation
            var result = MessageBox.Show("Are you sure you want to DELETE the selected transaction?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            TrackExpenseForm trackExpenseForm = new TrackExpenseForm();
            trackExpenseForm.Show();
            this.Hide();
        }

        private void buttonEditTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction. \n\n Click on the first column and ensure the whole row is highlighted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the index of the selected transaction
            var selectedIndex = dataGridViewTransactions.SelectedRows[0].Index;

            // Ask the user for confirmation
            var result = MessageBox.Show("Are you sure you want to EDIT the selected transaction?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Save the selected transaction in the Expense class
                Expense.EditTransaction = (Expense)dataGridViewTransactions.SelectedRows[0].DataBoundItem;

                // Remove the transaction at the selected index
                Expense.GetExpenses().RemoveAt(selectedIndex);

                EditTransactionForm editTransactionForm = new EditTransactionForm();
                editTransactionForm.Show();
                this.Hide();
            }

        }

        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            // Ask the user for confirmation
            var result = MessageBox.Show("Are you sure you want to EXPORT all transaction?", "Confirm Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                // Get the current date and time for the file name
                string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                string filePath = $@"C:\MSSA\Assignments\MiniProject - Budgetting App\DataFiles\AllTransactions\{currentDateTime}_All_Transactions.xlsx";

                // Create a new Excel workbook
                using (var workbook = new XLWorkbook())
                {
                    // Create a new worksheet
                    var worksheet = workbook.Worksheets.Add("Transactions");

                    // Add the column headers to the worksheet
                    for (int i = 0; i < dataGridViewTransactions.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridViewTransactions.Columns[i].HeaderText;
                    }

                    // Add the rows to the worksheet
                    for (int i = 0; i < dataGridViewTransactions.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewTransactions.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dataGridViewTransactions.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Save the workbook to the specified file path
                    workbook.SaveAs(filePath);
                }

                // Notify the user that the export was successful
                MessageBox.Show($"Data exported successfully to {filePath}");
            }
        }
    }
}
