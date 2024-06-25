using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject___Budgetting_App.Classes
{
    public class Budget
    {
        public decimal BudgetGroceries { get; set; }
        public decimal BudgetGas { get; set; }
        public decimal BudgetDiningOut { get; set; }
        public decimal BudgetShopping { get; set; }
        public decimal BudgetMisc { get; set; }

        public static Budget DefaultBudget = new Budget
        {
            BudgetGroceries = 750,
            BudgetGas = 500,
            BudgetDiningOut = 450,
            BudgetShopping = 450,
            BudgetMisc = 500
        };
    }
}

