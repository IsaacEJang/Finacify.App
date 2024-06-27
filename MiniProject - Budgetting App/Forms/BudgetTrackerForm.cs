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
            CurrentMonth();

            LoadBudgetTracker();
            LoadBudgetChart();

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
        public void LoadBudgetTracker()
        {
            // Budget Column Text Boxes
            textBoxGroceryBudget.Text = DataBudget.defaultBudget.BudgetGroceries.ToString("C");
            textBoxGasBudget.Text = DataBudget.defaultBudget.BudgetGas.ToString("C");
            textBoxDiningOutBudget.Text = DataBudget.defaultBudget.BudgetDiningOut.ToString("C");
            textBoxShoppingBudget.Text = DataBudget.defaultBudget.BudgetShopping.ToString("C");
            textBoxMiscBudget.Text = DataBudget.defaultBudget.BudgetMisc.ToString("C");
            textBoxTotalBudget.Text = DataBudget.defaultBudget.GetTotalBudget().ToString("C");

            // Spent Column Text Boxes
            textBoxGroceriesSpent.Text = Expense.GetCategorySum(ExpenseCategory.Groceries).ToString("C");
            textBoxGasSpent.Text = Expense.GetCategorySum(ExpenseCategory.Gas).ToString("C");
            textBoxDiningOutSpent.Text = Expense.GetCategorySum(ExpenseCategory.DiningOut).ToString("C");
            textBoxShoppingSpent.Text = Expense.GetCategorySum(ExpenseCategory.Shopping).ToString("C");
            textBoxMiscSpent.Text = Expense.GetCategorySum(ExpenseCategory.Misc).ToString("C");
            textBoxTotalSpent.Text = Expense.GetTotalSum().ToString("C");

            // Remaining Column Text Boxes
            textBoxGroceryRemaining.Text = (DataBudget.defaultBudget.BudgetGroceries - Expense.GetCategorySum(ExpenseCategory.Groceries)).ToString("C");
            textBoxGasRemaining.Text = (DataBudget.defaultBudget.BudgetGas - Expense.GetCategorySum(ExpenseCategory.Gas)).ToString("C");
            textBoxDiningRemaining.Text = (DataBudget.defaultBudget.BudgetDiningOut - Expense.GetCategorySum(ExpenseCategory.DiningOut)).ToString("C");
            textBoxShoppingRemaining.Text = (DataBudget.defaultBudget.BudgetShopping - Expense.GetCategorySum(ExpenseCategory.Shopping)).ToString("C");
            textBoxMiscRemaining.Text = (DataBudget.defaultBudget.BudgetMisc - Expense.GetCategorySum(ExpenseCategory.Misc)).ToString("C");
            textBoxTotalRemaining.Text = (DataBudget.defaultBudget.GetTotalBudget() - Expense.GetTotalSum()).ToString("C");

            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Declare Variable for Dates
            int daysCurrent = DateTime.Now.Day;
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            // Days Row Text Boxes
            textBoxTotalDays.Text = daysInMonth.ToString();
            textBoxCurrentDay.Text = daysCurrent.ToString();
            textBoxDaysRemaining.Text = (daysInMonth - daysCurrent).ToString();


        }

        // Populates Bar Graph Data
        public void LoadBudgetChart()
        {
            DateTime currentDate = DateTime.Now;
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);


            decimal daysCurrent = currentDate.Day;
            decimal miscPercent = Expense.GetCategorySum(ExpenseCategory.Misc) / DataBudget.defaultBudget.BudgetMisc * 100;
            decimal shoppingPercent = Expense.GetCategorySum(ExpenseCategory.Shopping) / DataBudget.defaultBudget.BudgetShopping * 100;
            decimal diningOutPercent = Expense.GetCategorySum(ExpenseCategory.DiningOut) / DataBudget.defaultBudget.BudgetDiningOut * 100;
            decimal gasPercent = Expense.GetCategorySum(ExpenseCategory.Gas) / DataBudget.defaultBudget.BudgetGas * 100;
            decimal groceriesPercent = Expense.GetCategorySum(ExpenseCategory.Groceries) / DataBudget.defaultBudget.BudgetGroceries * 100;

            decimal daysRemaining = daysInMonth - daysCurrent;
            decimal miscRemaining = 100 - miscPercent;
            decimal shoppingRemaining = 100 - shoppingPercent;
            decimal diningOutRemaining = 100 - diningOutPercent;
            decimal gasRemaining = 100 - gasPercent;
            decimal groceriesRemaining = 100 - groceriesPercent;

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
                    Values = new ChartValues<decimal> { daysCurrent, 0, 0, 0, 0, 0 },
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F0"),
                    Title = "Days",
                    Fill = daysColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> {0, miscPercent, 0, 0, 0, 0},
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Misc",
                    Fill = miscColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0,0, shoppingPercent, 0, 0, 0 },
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Shopping",
                    Fill = shoppingColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> {0, 0, 0, diningOutPercent, 0, 0},
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Dining Out",
                    Fill = diningOutColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0,0, 0, 0, gasPercent, 0 },
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Gas",
                    Fill = gasColor,
                    Foreground = percentColor
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0, 0, 0, 0, 0, groceriesPercent},
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Groceries",
                    Fill = groceriesColor,
                    Foreground = percentColor
                }

            };

            //adding series updates and animates the chart
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
                StackMode = StackMode.Percentage,
                DataLabels = false,
                Foreground = textColor,
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255)), // Set color
                LabelPoint = p => p.X.ToString("F2") + "%"
            });

            // Clear existing axes before adding new ones
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisX.Clear();

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Categories",
                Labels = new[] { "Days", "Misc", "Shopping", "DiningOut", "Gas", "Groceries" },
                Foreground = textColor,
                FontWeight = System.Windows.FontWeights.Bold, // Make title bold
            });


            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Percentage",
                LabelFormatter = val => val.ToString(), // Format as whole numbers
                FontWeight = System.Windows.FontWeights.Bold, // Make title bold
                Foreground = textColor,
            });

            // Disable the tooltip
            cartesianChart1.DataTooltip = null;
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

            LoadBudgetChart();
        }

        private void buttonPieChart_Click(object sender, EventArgs e)
        {
            // Hide the roundedGroupBoxBarChart when the button is clicked
            roundedGroupBoxBarChart.Visible = false;
            roundedGroupBoxPieChart.Visible = true;
        }
    }
}