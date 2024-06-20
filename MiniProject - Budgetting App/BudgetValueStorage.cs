using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject___Budgetting_App
{
    public class BudgetValueStorage
    {
        // A dictionary to hold budget categories and their corresponding values
        public Dictionary<string, double> BudgetValues { get; private set; }

        // Constructor initializes the dictionary
        public BudgetValueStorage()
        {
            BudgetValues = new Dictionary<string, double>();
        }

        // Method to save budget values into the dictionary
        // It replaces the existing dictionary with a new one containing the given values
        public void SaveBudgetValues(Dictionary<string, double> values)
        {
            BudgetValues = new Dictionary<string, double>(values);
        }
    }
}
