using LiveCharts.Wpf;
using LiveCharts;
using MiniProject___Budgetting_App.Classes;
using MiniProject___Budgetting_App.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace MiniProject___Budgetting_App
{
    public partial class BudgetTrackerForm : Form
    {

        public BudgetTrackerForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 300);

            CurrentMonth();
            
            // Use the current date for the initial load
            DateTime currentDate = DateTime.Now;
            LoadBudgetTracker(currentDate);
            LoadBarChart(currentDate);
            LoadPieChart(currentDate);
            roundedGroupBoxPieChart.Visible = false;
        }

        // Populates Month Text Box
        public void CurrentMonth()
        {

            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Format the date to display only the month and year
            string currentMonthYear = currentDate.ToString("MMMM yyyy"); // "MMMM" for full month name, "yyyy" for the year

            // Display the current month and year in the label
            textBoxCurrentMonth.Text = currentMonthYear;
        }


        // Populates Data for TextBoxes
        public void LoadBudgetTracker(DateTime monthDate)
        {
            // Budget Column Text Boxes
            textBoxGroceryBudget.Text = DataBudget.defaultBudget.BudgetGroceries.ToString("C");
            textBoxGasBudget.Text = DataBudget.defaultBudget.BudgetGas.ToString("C");
            textBoxDiningOutBudget.Text = DataBudget.defaultBudget.BudgetDiningOut.ToString("C");
            textBoxShoppingBudget.Text = DataBudget.defaultBudget.BudgetShopping.ToString("C");
            textBoxMiscBudget.Text = DataBudget.defaultBudget.BudgetMisc.ToString("C");
            textBoxTotalBudget.Text = DataBudget.defaultBudget.GetTotalBudget().ToString("C");

            // Spent Column Text Boxes
            textBoxGroceriesSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.Groceries, monthDate).ToString("C");
            textBoxGasSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.Gas, monthDate).ToString("C");
            textBoxDiningOutSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.DiningOut, monthDate).ToString("C");
            textBoxShoppingSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.Shopping, monthDate).ToString("C");
            textBoxMiscSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.Misc, monthDate).ToString("C");
            textBoxTotalSpent.Text = Expense.GetTotalSumForMonth(monthDate).ToString("C");

            // Remaining Column Text Boxes
            textBoxGroceryRemaining.Text = (DataBudget.defaultBudget.BudgetGroceries - Expense.GetCategorySumForMonth(ExpenseCategory.Groceries, monthDate)).ToString("C");
            textBoxGasRemaining.Text = (DataBudget.defaultBudget.BudgetGas - Expense.GetCategorySumForMonth(ExpenseCategory.Gas, monthDate)).ToString("C");
            textBoxDiningRemaining.Text = (DataBudget.defaultBudget.BudgetDiningOut - Expense.GetCategorySumForMonth(ExpenseCategory.DiningOut, monthDate)).ToString("C");
            textBoxShoppingRemaining.Text = (DataBudget.defaultBudget.BudgetShopping - Expense.GetCategorySumForMonth(ExpenseCategory.Shopping, monthDate)).ToString("C");
            textBoxMiscRemaining.Text = (DataBudget.defaultBudget.BudgetMisc - Expense.GetCategorySumForMonth(ExpenseCategory.Misc, monthDate)).ToString("C");
            textBoxTotalRemaining.Text = (DataBudget.defaultBudget.GetTotalBudget() - Expense.GetTotalSumForMonth(monthDate)).ToString("C");

            // Update the total days in the month
            int daysInMonth = DateTime.DaysInMonth(monthDate.Year, monthDate.Month);
            textBoxTotalDays.Text = daysInMonth.ToString();

            // Update the current day based on the selected month
            DateTime currentDate = DateTime.Now;
            if (monthDate.Year < currentDate.Year || (monthDate.Year == currentDate.Year && monthDate.Month < currentDate.Month))
            {
                // Past month
                textBoxCurrentDay.Text = daysInMonth.ToString();
            }
            else if (monthDate.Year > currentDate.Year || (monthDate.Year == currentDate.Year && monthDate.Month > currentDate.Month))
            {
                // Future month
                textBoxCurrentDay.Text = "0";
            }
            else
            {
                // Current month
                textBoxCurrentDay.Text = currentDate.Day.ToString();
            }

            // Update days remaining
            textBoxDaysRemaining.Text = (daysInMonth - int.Parse(textBoxCurrentDay.Text)).ToString();
        }


        // Populates Bar Graph Data
        public void LoadBarChart(DateTime monthDate)
        {
            // Get the total number of days in the selected month
            int daysInMonth = DateTime.DaysInMonth(monthDate.Year, monthDate.Month);

            // Get the current date
            DateTime currentDate = DateTime.Now;
            decimal daysCurrent;

            // Update daysCurrent based on the selected month
            if (monthDate.Year < currentDate.Year || (monthDate.Year == currentDate.Year && monthDate.Month < currentDate.Month))
            {
                // If the selected month is in the past, set daysCurrent to the total number of days in that month
                daysCurrent = daysInMonth;
            }
            else if (monthDate.Year > currentDate.Year || (monthDate.Year == currentDate.Year && monthDate.Month > currentDate.Month))
            {
                // If the selected month is in the future, set daysCurrent to 0
                daysCurrent = 0;
            }
            else
            {
                // If the selected month is the current month, set daysCurrent to the current day
                daysCurrent = currentDate.Day;
            }

            decimal daysPercent = daysCurrent / daysInMonth * 100;
            decimal daysRemainingPercent = 100 - daysPercent;

            decimal miscPercent = Expense.GetCategorySumForMonth(ExpenseCategory.Misc, monthDate) / DataBudget.defaultBudget.BudgetMisc * 100;
            decimal shoppingPercent = Expense.GetCategorySumForMonth(ExpenseCategory.Shopping, monthDate) / DataBudget.defaultBudget.BudgetShopping * 100;
            decimal diningOutPercent = Expense.GetCategorySumForMonth(ExpenseCategory.DiningOut, monthDate) / DataBudget.defaultBudget.BudgetDiningOut * 100;
            decimal gasPercent = Expense.GetCategorySumForMonth(ExpenseCategory.Gas, monthDate) / DataBudget.defaultBudget.BudgetGas * 100;
            decimal groceriesPercent = Expense.GetCategorySumForMonth(ExpenseCategory.Groceries, monthDate) / DataBudget.defaultBudget.BudgetGroceries * 100;

            decimal daysRemaining = daysInMonth - daysPercent;
            decimal miscRemaining = 100 - miscPercent;
            decimal shoppingRemaining = 100 - shoppingPercent;
            decimal diningOutRemaining = 100 - diningOutPercent;
            decimal gasRemaining = 100 - gasPercent;
            decimal groceriesRemaining = 100 - groceriesPercent;

            // Find the maximum percentage value to set the MaxValue of the axis
            decimal[] percentages = { miscPercent, shoppingPercent, diningOutPercent, gasPercent, groceriesPercent, 100 };
            decimal maxValue = percentages.Max();

            // Individual colors for each category
            var miscColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(180, 167, 214));         // Purple
            var shoppingColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(125, 206, 206));     // Green
            var diningOutColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 229, 153));    // Yellow
            var gasColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(249, 203, 156));          // Orange
            var groceriesColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(234, 153, 153));    // Red
            var daysColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(183, 183, 183));         // Gray
            var percentColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));      // White
            var textColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0));               // Black

            cartesianChart1.Series = new SeriesCollection
            {
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { (decimal)daysPercent, 0, 0, 0, 0, 0 },
                    StackMode = StackMode.Values,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F0") + "%",
                    Title = "Days",
                    Fill = daysColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0, miscPercent, 0, 0, 0, 0 },
                    StackMode = StackMode.Values,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F0") + "%",
                    Title = "Misc",
                    Fill = miscColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0, 0, shoppingPercent, 0, 0, 0 },
                    StackMode = StackMode.Values,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F0") + "%",
                    Title = "Shopping",
                    Fill = shoppingColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0, 0, 0, diningOutPercent, 0, 0 },
                    StackMode = StackMode.Values,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F0") + "%",
                    Title = "Dining Out",
                    Fill = diningOutColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0, 0, 0, 0, gasPercent, 0 },
                    StackMode = StackMode.Values,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F0") + "%",
                    Title = "Gas",
                    Fill = gasColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0, 0, 0, 0, 0, groceriesPercent },
                    StackMode = StackMode.Values,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F0") + "%",
                    Title = "Groceries",
                    Fill = groceriesColor,
                    Foreground = percentColor
                }
            };

            // Add remaining series
            cartesianChart1.Series.Add(new StackedRowSeries
            {
                Values = new ChartValues<decimal>
                    {
                        daysRemaining,
                        miscRemaining,
                        shoppingRemaining,
                        diningOutRemaining,
                        gasRemaining,
                        groceriesRemaining
                    },
                StackMode = StackMode.Values,
                DataLabels = false,
                Foreground = textColor,
                Fill = new SolidColorBrush(System.Windows.Media.Colors.Transparent), // Set color to transparent
                LabelPoint = p => p.X.ToString()
            });

            // Clear existing axes before adding new ones
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisX.Clear();

            cartesianChart1.AxisY.Add(new Axis
            {
                Labels = new[] { "Days", "Misc", "Shopping", "Dining Out", "Gas", "Groceries" },
                Foreground = textColor,
                FontWeight = System.Windows.FontWeights.Bold, // Make title bold
            });

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Percent(%) Of Budget",
                MinValue = 0,
                MaxValue = (double)(maxValue), // Dynamically set the max value
                LabelFormatter = val => (val).ToString("F0") + "%", // Format as percentage
                FontWeight = System.Windows.FontWeights.Bold, // Make title bold
                Foreground = textColor,
            });

            // Disable the tooltip
            cartesianChart1.DataTooltip = null;
        }


        // Populates Pie Graph Data
        public void LoadPieChart(DateTime monthDate)
        {
            // Calculate the percentages for each category
            decimal miscPercent = Math.Round(Expense.GetCategorySumForMonth(ExpenseCategory.Misc, monthDate) / DataBudget.defaultBudget.BudgetMisc * 100, 2);
            decimal shoppingPercent = Math.Round(Expense.GetCategorySumForMonth(ExpenseCategory.Shopping, monthDate) / DataBudget.defaultBudget.BudgetShopping * 100, 2);
            decimal diningOutPercent = Math.Round(Expense.GetCategorySumForMonth(ExpenseCategory.DiningOut, monthDate) / DataBudget.defaultBudget.BudgetDiningOut * 100, 2);
            decimal gasPercent = Math.Round(Expense.GetCategorySumForMonth(ExpenseCategory.Gas, monthDate) / DataBudget.defaultBudget.BudgetGas * 100, 2);
            decimal groceriesPercent = Math.Round(Expense.GetCategorySumForMonth(ExpenseCategory.Groceries, monthDate) / DataBudget.defaultBudget.BudgetGroceries * 100, 2);

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P2})", chartPoint.SeriesView.Title, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Misc",
                    Values = new ChartValues<double> { (double)miscPercent },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(180, 167, 214)) // Purple
                },
                new PieSeries
                {
                    Title = "Shopping",
                    Values = new ChartValues<double> { (double)shoppingPercent },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(125, 206, 166)) // Green
                },
                new PieSeries
                {
                    Title = "Dining Out",
                    Values = new ChartValues<double> { (double)diningOutPercent },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 229, 153)) // Yellow
                },
                new PieSeries
                {
                    Title = "Gas",
                    Values = new ChartValues<double> { (double)gasPercent },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(249, 203, 156)) // Orange
                },
                new PieSeries
                {
                    Title = "Groceries",
                    Values = new ChartValues<double> { (double)groceriesPercent },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(234, 153, 153)) // Red
                }
            };

            // Remove the legend
            pieChart1.LegendLocation = LegendLocation.None;
            // Disable the tooltip
            pieChart1.DataTooltip = null;
        }


        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

        private void buttonViewTransactions_Click(object sender, EventArgs e)
        {
            ViewTransactionsForm viewTransactionsForm = new ViewTransactionsForm();
            viewTransactionsForm.Show();
            this.Hide();
        }

        private void BudgetTrackerForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBarChart_Click(object sender, EventArgs e)
        {
            // Hide the roundedGroupBoxBarChart when the button is clicked
            roundedGroupBoxBarChart.Visible = true;
            roundedGroupBoxPieChart.Visible = false;

            // Get the current month date from the text box
            DateTime currentDate = DateTime.ParseExact(textBoxCurrentMonth.Text, "MMMM yyyy", null);
            LoadBarChart(currentDate);
        }

        private void buttonPieChart_Click(object sender, EventArgs e)
        {
            // Hide the roundedGroupBoxBarChart when the button is clicked
            roundedGroupBoxBarChart.Visible = false;
            roundedGroupBoxPieChart.Visible = true;

            // Get the current month date from the text box
            DateTime currentDate = DateTime.ParseExact(textBoxCurrentMonth.Text, "MMMM yyyy", null);
            LoadPieChart(currentDate);
        }

        private void buttonSubtractMonth_Click(object sender, EventArgs e)
        {
            // Get the current value from textBoxCurrentMonth
            string currentMonthYear = textBoxCurrentMonth.Text;

            // Parse the current month and year
            DateTime currentDate = DateTime.ParseExact(currentMonthYear, "MMMM yyyy", null);

            // Subtract one month
            DateTime previousMonthDate = currentDate.AddMonths(-1);

            // Update textBoxCurrentMonth with the new month and year
            textBoxCurrentMonth.Text = previousMonthDate.ToString("MMMM yyyy");

            // Recalculate the sum of expenses for the previous month
            UpdateSpentColumn(previousMonthDate);

            // Refresh the textboxes and graphs with the new month data
            LoadBudgetTracker(previousMonthDate);
            LoadBarChart(previousMonthDate);
            LoadPieChart(previousMonthDate);
        }

        private void buttonAddMonth_Click(object sender, EventArgs e)
        {
            // Get the current value from textBoxCurrentMonth
            string currentMonthYear = textBoxCurrentMonth.Text;

            // Parse the current month and year
            DateTime currentDate = DateTime.ParseExact(currentMonthYear, "MMMM yyyy", null);

            // Add one month
            DateTime nextMonthDate = currentDate.AddMonths(1);

            // Update textBoxCurrentMonth with the new month and year
            textBoxCurrentMonth.Text = nextMonthDate.ToString("MMMM yyyy");

            // Recalculate the sum of expenses for the next month
            UpdateSpentColumn(nextMonthDate);

            // Refresh the textboxes and graphs with the new month data
            LoadBudgetTracker(nextMonthDate);
            LoadBarChart(nextMonthDate);
            LoadPieChart(nextMonthDate);
        }

        private void UpdateSpentColumn(DateTime monthDate)
        {
            // Update the "Spent" column text boxes with the recalculated sums for the given month
            textBoxGroceriesSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.Groceries, monthDate).ToString("C");
            textBoxGasSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.Gas, monthDate).ToString("C");
            textBoxDiningOutSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.DiningOut, monthDate).ToString("C");
            textBoxShoppingSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.Shopping, monthDate).ToString("C");
            textBoxMiscSpent.Text = Expense.GetCategorySumForMonth(ExpenseCategory.Misc, monthDate).ToString("C");
            textBoxTotalSpent.Text = Expense.GetTotalSumForMonth(monthDate).ToString("C");
        }

    }
}