using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MiniProject___Budgetting_App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Windows.Media;

namespace MiniProject___Budgetting_App.Forms
{
    public partial class BudgetTrackerProgressForm : Form
    {
        public BudgetTrackerProgressForm()
        {
            InitializeComponent();
            LoadBudget();

        }

        public void LoadBudget()
        {
            decimal daysCurrent = DateTime.Now.Day;
            decimal miscPercent = Expense.GetCategorySum(ExpenseCategory.Misc) / DataBudget.defaultBudget.BudgetMisc * 100;
            decimal shoppingPercent = Expense.GetCategorySum(ExpenseCategory.Shopping) / DataBudget.defaultBudget.BudgetShopping * 100;
            decimal diningOutPercent = Expense.GetCategorySum(ExpenseCategory.DiningOut) / DataBudget.defaultBudget.BudgetDiningOut * 100;
            decimal gasPercent = Expense.GetCategorySum(ExpenseCategory.Gas) / DataBudget.defaultBudget.BudgetGas * 100;
            decimal groceriesPercent = Expense.GetCategorySum(ExpenseCategory.Groceries) / DataBudget.defaultBudget.BudgetGroceries * 100;

            decimal daysRemaining = 30 - daysCurrent;
            decimal miscRemaining = 100 - miscPercent;
            decimal shoppingRemaining = 100 - shoppingPercent;
            decimal diningOutRemaining = 100 - diningOutPercent;
            decimal gasRemaining = 100 - gasPercent;
            decimal groceriesRemaining = 100 - groceriesPercent;

            // Individual colors for each category
            var miscColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(180, 167, 214)); // Purple
            var shoppingColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(125, 206, 166)); // Green
            var diningOutColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 229, 153)); // Yellow
            var gasColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(249, 203, 156)); // Orange
            var groceriesColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(244, 153, 153)); // Red
            var daysColor = new SolidColorBrush(System.Windows.Media.Color.FromRgb(183, 183, 183));



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
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> {0, miscPercent, 0, 0, 0, 0},
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Misc",
                    Fill = miscColor,
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0,0, shoppingPercent, 0, 0, 0 },
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Shopping",
                    Fill = shoppingColor,
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> {0, 0, 0, diningOutPercent, 0, 0},
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Dining Out",
                    Fill = diningOutColor,
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0,0, 0, 0, gasPercent, 0 },
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Gas",
                    Fill = gasColor,
                },
                new StackedRowSeries
                {
                    Values = new ChartValues<decimal> { 0, 0, 0, 0, 0, groceriesPercent},
                    StackMode = StackMode.Percentage,
                    DataLabels = true,
                    LabelPoint = p => p.X.ToString("F2") + "%",
                    Title = "Groceries",
                    Fill = groceriesColor,
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
                Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255)), // Set color
                LabelPoint = p => p.X.ToString("F2") + "%"
            });


            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Categories",
                Labels = new[] { "Days", "Misc", "Shopping", "DiningOut", "Gas", "Groceries" }
            });


            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Percentage",
                LabelFormatter = val => val.ToString(), // Format as whole numbers
                FontWeight = System.Windows.FontWeights.Bold, // Make title bold
                
            });

            var tooltip = new DefaultTooltip { SelectionMode = TooltipSelectionMode.SharedYValues };

            cartesianChart1.DataTooltip = tooltip;
        }
    }
}