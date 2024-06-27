using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject___Budgetting_App.Classes
{
    public static class DataBudget 
    {
        public static Budget defaultBudget = new Budget();
    }

    public class Budget
    {
        public decimal BudgetGroceries { get; set; }
        public decimal BudgetGas { get; set; }
        public decimal BudgetDiningOut { get; set; }
        public decimal BudgetShopping { get; set; }
        public decimal BudgetMisc { get; set; }

        public Budget()
        {
            BudgetGroceries = 750;
            BudgetGas = 500;
            BudgetDiningOut = 450; 
            BudgetShopping = 450;
            BudgetMisc = 500;
            
        }

        // Method to calculate the total budget
        public decimal GetTotalBudget()
        {
            return BudgetGroceries + BudgetGas + BudgetDiningOut + BudgetShopping + BudgetMisc;
        }
    }
}

