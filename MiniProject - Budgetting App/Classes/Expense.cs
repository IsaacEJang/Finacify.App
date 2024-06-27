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
            // July Expenses
            new Expense { Date = new DateTime(2024, 7, 5), Category = ExpenseCategory.Groceries, Amount = 50, Description = "Sprouts" },
            new Expense { Date = new DateTime(2024, 7, 10), Category = ExpenseCategory.Gas, Amount = 70, Description = "Exxon" },
            new Expense { Date = new DateTime(2024, 7, 15), Category = ExpenseCategory.Shopping, Amount = 95, Description = "Macy's" },
            new Expense { Date = new DateTime(2024, 7, 20), Category = ExpenseCategory.Misc, Amount = 40, Description = "Pet Supplies" },
            new Expense { Date = new DateTime(2024, 7, 25), Category = ExpenseCategory.DiningOut, Amount = 75, Description = "Sushi Bar" },

            // June Expenses
            new Expense { Date = new DateTime(2024, 6, 16), Category = ExpenseCategory.Groceries, Amount = 100, Description = "Commissary" },
            new Expense { Date = new DateTime(2024, 6, 16), Category = ExpenseCategory.Gas, Amount = 100, Description = "Gas" },
            new Expense { Date = new DateTime(2024, 6, 16), Category = ExpenseCategory.Shopping, Amount = 100, Description = "Home goods" },
            new Expense { Date = new DateTime(2024, 6, 9), Category = ExpenseCategory.Misc, Amount = 100, Description = "Stylevana " },
            new Expense { Date = new DateTime(2024, 6, 30), Category = ExpenseCategory.DiningOut, Amount = 100, Description = "Food" },
            new Expense { Date = new DateTime(2024, 6, 10), Category = ExpenseCategory.Groceries, Amount = 65, Description = "Whole Foods" },
            new Expense { Date = new DateTime(2024, 6, 15), Category = ExpenseCategory.Gas, Amount = 55, Description = "Chevron" },
            new Expense { Date = new DateTime(2024, 6, 20), Category = ExpenseCategory.Shopping, Amount = 85, Description = "Best Buy" },
            new Expense { Date = new DateTime(2024, 6, 25), Category = ExpenseCategory.Misc, Amount = 100, Description = "Home Depot" },
            new Expense { Date = new DateTime(2024, 6, 30), Category = ExpenseCategory.DiningOut, Amount = 60, Description = "Steakhouse" },

            // May Expenses
            new Expense { Date = new DateTime(2024, 5, 5), Category = ExpenseCategory.Groceries, Amount = 45, Description = "Trader Joe's" },
            new Expense { Date = new DateTime(2024, 5, 8), Category = ExpenseCategory.Gas, Amount = 60, Description = "Shell" },
            new Expense { Date = new DateTime(2024, 5, 15), Category = ExpenseCategory.Shopping, Amount = 120, Description = "Amazon" },
            new Expense { Date = new DateTime(2024, 5, 20), Category = ExpenseCategory.Misc, Amount = 75, Description = "Target" },
            new Expense { Date = new DateTime(2024, 5, 25), Category = ExpenseCategory.DiningOut, Amount = 50, Description = "Restaurant" },

            // April Expenes
            new Expense { Date = new DateTime(2024, 4, 16), Category = ExpenseCategory.Groceries, Amount = 86, Description = "Commissary" },
            new Expense { Date = new DateTime(2024, 4, 16), Category = ExpenseCategory.Gas, Amount = 77, Description = "Gas" },
            new Expense { Date = new DateTime(2024, 4, 16), Category = ExpenseCategory.Groceries, Amount = 75, Description = "Trader Joe’s" },
            new Expense { Date = new DateTime(2024, 4, 16), Category = ExpenseCategory.Shopping, Amount = 86, Description = "Home goods" },
            new Expense { Date = new DateTime(2024, 4, 9), Category = ExpenseCategory.Misc, Amount = 107, Description = "Stylevana (skincare)" },
            new Expense { Date = new DateTime(2024, 4, 8), Category = ExpenseCategory.DiningOut, Amount = 250, Description = "Depop" },
            new Expense { Date = new DateTime(2024, 4, 6), Category = ExpenseCategory.Shopping, Amount = 23, Description = "Amazon (Mercedes baby gift)" },
            
            // March Expenses
            new Expense { Date = new DateTime(2024, 3, 31), Category = ExpenseCategory.Gas, Amount = 46, Description = "Gas" },
            new Expense { Date = new DateTime(2024, 3, 23), Category = ExpenseCategory.Gas, Amount = 71, Description = "Gas" },
            new Expense { Date = new DateTime(2024, 3, 19), Category = ExpenseCategory.Groceries, Amount = 63, Description = "Commissary" },
            new Expense { Date = new DateTime(2024, 3, 8), Category = ExpenseCategory.DiningOut, Amount = 95, Description = "Baekjeong" },
            new Expense { Date = new DateTime(2024, 3, 8), Category = ExpenseCategory.Gas, Amount = 70, Description = "Gas" },
            new Expense { Date = new DateTime(2024, 3, 5), Category = ExpenseCategory.Groceries, Amount = 80, Description = "Hmart" },
            new Expense { Date = new DateTime(2024, 3, 5), Category = ExpenseCategory.Shopping, Amount = 30, Description = "Depop" },
            new Expense { Date = new DateTime(2024, 3, 3), Category = ExpenseCategory.Shopping, Amount = 80, Description = "Depop" },
            new Expense { Date = new DateTime(2024, 3, 3), Category = ExpenseCategory.DiningOut, Amount = 23, Description = "In n out" },
            new Expense { Date = new DateTime(2024, 3, 2), Category = ExpenseCategory.DiningOut, Amount = 50, Description = "Kura" },
            new Expense { Date = new DateTime(2024, 3, 1), Category = ExpenseCategory.Gas, Amount = 70, Description = "Gas" },
            new Expense { Date = new DateTime(2024, 3, 1), Category = ExpenseCategory.Misc, Amount = 102, Description = "Stylevana (skincare)" }


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

        // Method to calculate the sum for a specific category for a given month
        public static decimal GetCategorySumForMonth(ExpenseCategory category, DateTime monthDate)
        {
            decimal sum = 0;

            // Iterate over each expense
            foreach (var expense in expenses)
            {
                // If the expense category matches the input category and the expense is in the given month, add the amount to the sum
                if (expense.Category == category && expense.Date.Year == monthDate.Year && expense.Date.Month == monthDate.Month)
                {
                    sum += expense.Amount;
                }
            }

            return sum;
        }

        // Method to calculate the total sum of all expenses for a given month
        public static decimal GetTotalSumForMonth(DateTime monthDate)
        {
            decimal totalSum = 0;

            // Iterate over each expense and add the amount to the total sum if it is in the given month
            foreach (var expense in expenses)
            {
                if (expense.Date.Year == monthDate.Year && expense.Date.Month == monthDate.Month)
                {
                    totalSum += expense.Amount;
                }
            }

            return totalSum;
        }
    }
}