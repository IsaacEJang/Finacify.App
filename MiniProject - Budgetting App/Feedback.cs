using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject___Budgetting_App
{
    public enum FeedbackType
    {
        ReportBug,
        RequestFeature,
        Other
    }

    public enum PageLocation
    {
        AnnualSummaryForm,
        BudgetTrackerForm,
        BuildBudgetForm,
        CreateAccountForm,
        FeedbackForm,
        ForgotPasswordForm,
        HomePageForm,
        LogIncomeForm,
        LoginForm,
        TrackExpenseForm,
        ViewTransactionsForm,
        Other
    }

    internal class Feedback
    {
        public FeedbackType Type { get; set; }
        public PageLocation Location { get; set; }
        public string Comment { get; set; }
        public DateTime DateSubmitted { get; set; }

        public Feedback(FeedbackType type, PageLocation location, string comment)
        {
            Type = type;
            Location = location;
            Comment = comment;
            DateSubmitted = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Date Submitted: {DateSubmitted}\n" +
                $"Type: {Type}\n" +
                $"Page: {Location}\n" +
                $"Comment: {Comment}\n";
        }

    }
}
