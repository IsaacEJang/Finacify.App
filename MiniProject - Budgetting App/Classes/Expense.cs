using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject___Budgetting_App.Classes
{
    public enum ExpenseCategory
    {
        Groceries,
        Gas,
        DiningOut,
        Shopping,
        Misc
    }

    internal class Expense
    {
        public DateTime Date { get; set; }
        public ExpenseCategory Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        // List to hold the expense objects
        public static List<Expense> expenses = new List<Expense> {
            new Expense { Date = DateTime.Now, Category = ExpenseCategory.DiningOut, Amount = 50.00m,  Description = "Food"},
            new Expense { Date = DateTime.Now, Category = ExpenseCategory.Groceries, Amount = 50.00m,  Description = "Groceries"},
            new Expense { Date = DateTime.Now, Category = ExpenseCategory.Shopping, Amount = 50.00m,  Description = "Shopping"},
            new Expense { Date = DateTime.Now, Category = ExpenseCategory.Misc, Amount = 50.00m,  Description = "Food"},
            new Expense { Date = DateTime.Now, Category = ExpenseCategory.Gas, Amount = 50.00m,  Description = "Gas"},

            };


        // Method to add a new expense to the list
        public static void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        // Method to retrieve all stored expenses
        public static List<Expense> GetExpenses()
        {
            return expenses;
        }
    }

}
