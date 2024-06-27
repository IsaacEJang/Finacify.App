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

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 300);

            // Set the placeholder text for the expense amount TextBox and add event handlers
            SetExampleExpenseAmount();
            textBoxExpenseAmount.Enter += textBoxExpenseAmount_Enter;
            textBoxExpenseAmount.Leave += textBoxExpenseAmount_Leave;

            // Set the placeholder text for the expense description TextBox and add event handlers
            SetExampleExpenseDescription();
            textBoxExpenseDescription.Enter += textBoxExpenseDescription_Enter;
            textBoxExpenseDescription.Leave += textBoxExpenseDescription_Leave;
        }

        // Method to set the example expense amount as placeholder text
        private void SetExampleExpenseAmount()
        {
            textBoxExpenseAmount.Text = "100.00";
            textBoxExpenseAmount.ForeColor = Color.Gray; // Set the text color to gray to indicate it is a placeholder
        }

        // Event handler for when the expense amount TextBox gains focus
        private void textBoxExpenseAmount_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change the text color to black
            if (textBoxExpenseAmount.Text == "100.00")
            {
                textBoxExpenseAmount.Text = "";
                textBoxExpenseAmount.ForeColor = Color.Black;
            }
        }

        // Event handler for when the expense amount TextBox loses focus
        private void textBoxExpenseAmount_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty, reset the placeholder text
            if (string.IsNullOrWhiteSpace(textBoxExpenseAmount.Text))
            {
                SetExampleExpenseAmount();
            }
        }

        // Method to set the example expense description as placeholder text
        private void SetExampleExpenseDescription()
        {
            textBoxExpenseDescription.Text = "Description";
            textBoxExpenseDescription.ForeColor = Color.Gray; // Set the text color to gray to indicate it is a placeholder
        }

        // Event handler for when the expense description TextBox gains focus
        private void textBoxExpenseDescription_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change the text color to black
            if (textBoxExpenseDescription.Text == "Description")
            {
                textBoxExpenseDescription.Text = "";
                textBoxExpenseDescription.ForeColor = Color.Black;
            }
        }

        // Event handler for when the expense description TextBox loses focus
        private void textBoxExpenseDescription_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty, reset the placeholder text
            if (string.IsNullOrWhiteSpace(textBoxExpenseDescription.Text))
            {
                SetExampleExpenseDescription();
            }
        }

        private void buttonBackLogin_Click_1(object sender, EventArgs e)
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

        private void buttonSubmitExpense_Click_1(object sender, EventArgs e)
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
                    Date = dateTimePicker.Value.Date,    // Set the full date from dateTimePicker
                    Category = selectedCategory,         // Set the selected category
                    Amount = amount,                     // Set the entered amount
                    Description = description            // Set the entered description
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

        private void TrackExpenseForm_Load(object sender, EventArgs e)
        {

        }

    }
}
