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

namespace MiniProject___Budgetting_App.Forms
{
    public partial class EditTransactionForm : Form
    {
        
        public EditTransactionForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 300);

            LoadTransactionData();
        }

        private void LoadTransactionData()
        {
            if (Expense.EditTransaction != null)
            {
                dateTimePicker.Value = Expense.EditTransaction.Date;

                switch (Expense.EditTransaction.Category)
                {
                    case ExpenseCategory.Groceries:
                        radioButtonGroceries.Checked = true;
                        break;
                    case ExpenseCategory.Gas:
                        radioButtonGas.Checked = true;
                        break;
                    case ExpenseCategory.DiningOut:
                        radioButtonDiningOut.Checked = true;
                        break;
                    case ExpenseCategory.Shopping:
                        radioButtonShopping.Checked = true;
                        break;
                    case ExpenseCategory.Misc:
                        radioButtonMisc.Checked = true;
                        break;
                }

                textBoxExpenseAmount.Text = Expense.EditTransaction.Amount.ToString();
                textBoxExpenseDescription.Text = Expense.EditTransaction.Description;
            }
        }

        private void buttonBackViewTransactions_Click(object sender, EventArgs e)
        {
            // Add back the previously removed transaction
            if (Expense.EditTransaction != null)
            {
                Expense.AddExpense(Expense.EditTransaction);
            }

            ViewTransactionsForm viewTransactionsForm = new ViewTransactionsForm();
            viewTransactionsForm.Show();
            this.Hide();
        }


        private void buttonSaveExpense_Click(object sender, EventArgs e)
        {
            // Update the expense with the new data
            if (Expense.EditTransaction != null)
            {
                Expense.EditTransaction.Date = dateTimePicker.Value;

                if (radioButtonGroceries.Checked) { Expense.EditTransaction.Category = ExpenseCategory.Groceries; }
                else if (radioButtonGas.Checked) { Expense.EditTransaction.Category = ExpenseCategory.Gas; }
                else if (radioButtonDiningOut.Checked) { Expense.EditTransaction.Category = ExpenseCategory.DiningOut; }
                else if (radioButtonShopping.Checked) { Expense.EditTransaction.Category = ExpenseCategory.Shopping; }
                else if (radioButtonMisc.Checked) { Expense.EditTransaction.Category = ExpenseCategory.Misc; }

                Expense.EditTransaction.Amount = decimal.Parse(textBoxExpenseAmount.Text);
                Expense.EditTransaction.Description = textBoxExpenseDescription.Text;

                // Add the updated transaction back to the list
                Expense.AddExpense(Expense.EditTransaction);

                // Clear the static properties
                Expense.EditTransaction = null;

                // Show the ViewTransactionsForm
                ViewTransactionsForm viewTransactionsForm = new ViewTransactionsForm();
                viewTransactionsForm.Show();
                this.Close();
            }

        }
    }
}
