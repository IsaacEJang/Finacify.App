using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject___Budgetting_App.Classes
{
    internal class Income
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public DateTime DateReceived { get; set; }


        // Foreign key reference
        public User User { get; set; }
    }
}
