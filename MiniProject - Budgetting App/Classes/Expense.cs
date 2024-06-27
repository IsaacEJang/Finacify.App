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
            new Expense { Date = new DateTime(2024, 6, 16), Category = ExpenseCategory.Groceries, Amount = 100, Description = "Commissary" },
            new Expense { Date = new DateTime(2024, 6, 16), Category = ExpenseCategory.Gas, Amount = 100, Description = "Gas" },
            new Expense { Date = new DateTime(2024, 6, 16), Category = ExpenseCategory.Shopping, Amount = 100, Description = "Home goods" },
            new Expense { Date = new DateTime(2024, 6, 9), Category = ExpenseCategory.Misc, Amount = 100, Description = "Stylevana " },
            new Expense { Date = new DateTime(2024, 6, 30), Category = ExpenseCategory.DiningOut, Amount = 100, Description = "Food" }
        };

        // Static property to hold the selected expense for editing
        public static Expense EditTransaction { get; set; }


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

        // Method to calculate the sum for a specific category
        public static decimal GetCategorySum(ExpenseCategory category)
        {
            decimal sum = 0;
            DateTime currentDate = DateTime.Now;

            // Iterate over each expense
            foreach (var expense in expenses)
            {
                // If the expense category matches the input category and the expense is in the current month, add the amount to the sum
                if (expense.Category == category && expense.Date.Year == currentDate.Year && expense.Date.Month == currentDate.Month)
                {
                    sum += expense.Amount;
                }
            }

            return sum;
        }

        // Method to calculate the total sum of all expenses
        public static decimal GetTotalSum()
        {
            decimal totalSum = 0;

            // Iterate over each expense and add the amount to the total sum
            foreach (var expense in expenses)
            {
                totalSum += expense.Amount;
            }

            return totalSum;
        }
    }
}
