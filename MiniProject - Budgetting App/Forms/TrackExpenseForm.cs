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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniProject___Budgetting_App
{
    public partial class TrackExpenseForm : Form
    {
        // Variable to hold the selected category
        private ExpenseCategory selectedCategory;


        public TrackExpenseForm()
        {
            InitializeComponent();
        }


        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }


        // Event handler for radio button CheckedChanged event
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Cast sender to RadioButton
            RadioButton radioButton = sender as RadioButton;

            // Check if the radio button is checked and not null
            if (radioButton != null && radioButton.Checked)
            {
                // Set the selected category to the corresponding enum value
                switch (radioButton.Text)
                {
                    case "Groceries":
                        selectedCategory = ExpenseCategory.Groceries;
                        break;
                    case "Gas":
                        selectedCategory = ExpenseCategory.Gas;
                        break;
                    case "Dining Out":
                        selectedCategory = ExpenseCategory.DiningOut;
                        break;
                    case "Shopping":
                        selectedCategory = ExpenseCategory.Shopping;
                        break;
                    case "Misc":
                        selectedCategory = ExpenseCategory.Misc;
                        break;
                }
            }
        }

        private void buttonSubmitExpense_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert the text from textBoxExpenseAmount to decimal for amount
                decimal amount = Convert.ToDecimal(textBoxExpenseAmount.Text);

                // Get the description from textBoxExpenseDescription
                string description = textBoxExpenseDescription.Text;

                // Create a new Expense object
                Expense newExpense = new Expense
                {
                    Date = DateTime.Today,          // Set the current date
                    Category = selectedCategory,    // Set the selected category
                    Amount = amount,                // Set the entered amount
                    Description = description       // Set the entered description
                };

                // Add the new expense to the storage
                Expense.AddExpense(newExpense);

                // Show a success message
                MessageBox.Show("Expense recorded successfully!");

                // Clear the form for new entries
                ClearForm();
            }
            catch (FormatException)
            {
                // Show an error message if the amount is not a valid decimal
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        // Method to clear the form fields
        public void ClearForm()
        {
            textBoxExpenseAmount.Clear();   // Clear the amount text box
            textBoxExpenseDescription.Clear();   // Clear the description text box
        }
    }
}
