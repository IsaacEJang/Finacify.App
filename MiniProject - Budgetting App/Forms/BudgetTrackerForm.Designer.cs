namespace MiniProject___Budgetting_App
{
    partial class BudgetTrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetTrackerForm));
            label1 = new Label();
            label7 = new Label();
            buttonBackLogin = new Button();
            roundedGroupBudgetTracker = new RoundedGroupBox();
            buttonSubtractMonth = new Button();
            textBoxCurrentMonth = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBoxDaysRemaining = new TextBox();
            textBoxCurrentDay = new TextBox();
            textBoxTotalDays = new TextBox();
            textBoxTotalRemaining = new TextBox();
            textBoxTotalSpent = new TextBox();
            textBoxTotalBudget = new TextBox();
            textBox18 = new TextBox();
            textBoxMiscRemaining = new TextBox();
            textBoxMiscSpent = new TextBox();
            textBoxMiscBudget = new TextBox();
            textBox14 = new TextBox();
            textBoxShoppingRemaining = new TextBox();
            textBoxShoppingSpent = new TextBox();
            textBoxShoppingBudget = new TextBox();
            textBox10 = new TextBox();
            textBoxDiningRemaining = new TextBox();
            textBoxDiningOutSpent = new TextBox();
            textBoxDiningOutBudget = new TextBox();
            textBox6 = new TextBox();
            textBoxGasRemaining = new TextBox();
            textBoxGasSpent = new TextBox();
            textBoxGasBudget = new TextBox();
            textBoxGroceryRemaining = new TextBox();
            textBoxGroceriesSpent = new TextBox();
            textBoxGroceryBudget = new TextBox();
            textBoxRemaining = new TextBox();
            textBoxSpent = new TextBox();
            textBoxBudget = new TextBox();
            buttonAddMonth = new Button();
            buttonViewTransactions = new Button();
            roundedGroupBoxBarChart = new RoundedGroupBox();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            roundedGroupBox1 = new RoundedGroupBox();
            buttonBarChart = new Button();
            buttonPieChart = new Button();
            roundedGroupBoxPieChart = new RoundedGroupBox();
            label2 = new Label();
            pieChart1 = new LiveCharts.WinForms.PieChart();
            label3 = new Label();
            roundedGroupBudgetTracker.SuspendLayout();
            roundedGroupBoxBarChart.SuspendLayout();
            roundedGroupBox1.SuspendLayout();
            roundedGroupBoxPieChart.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(496, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 53);
            label1.TabIndex = 19;
            label1.Text = "💸";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(390, 60);
            label7.Name = "label7";
            label7.Size = new Size(289, 45);
            label7.TabIndex = 17;
            label7.Text = "Budget Tracker";
            // 
            // buttonBackLogin
            // 
            buttonBackLogin.BackColor = Color.FromArgb(123, 114, 229);
            buttonBackLogin.FlatAppearance.BorderSize = 0;
            buttonBackLogin.FlatStyle = FlatStyle.Flat;
            buttonBackLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackLogin.ForeColor = Color.White;
            buttonBackLogin.Location = new Point(12, 12);
            buttonBackLogin.Name = "buttonBackLogin";
            buttonBackLogin.Size = new Size(49, 49);
            buttonBackLogin.TabIndex = 21;
            buttonBackLogin.Text = "↩️";
            buttonBackLogin.UseVisualStyleBackColor = false;
            buttonBackLogin.Click += buttonBackLogin_Click;
            // 
            // roundedGroupBudgetTracker
            // 
            roundedGroupBudgetTracker.BackColor = Color.White;
            roundedGroupBudgetTracker.BackgroundImageLayout = ImageLayout.Center;
            roundedGroupBudgetTracker.Controls.Add(buttonSubtractMonth);
            roundedGroupBudgetTracker.Controls.Add(textBoxCurrentMonth);
            roundedGroupBudgetTracker.Controls.Add(textBox3);
            roundedGroupBudgetTracker.Controls.Add(textBox5);
            roundedGroupBudgetTracker.Controls.Add(textBoxDaysRemaining);
            roundedGroupBudgetTracker.Controls.Add(textBoxCurrentDay);
            roundedGroupBudgetTracker.Controls.Add(textBoxTotalDays);
            roundedGroupBudgetTracker.Controls.Add(textBoxTotalRemaining);
            roundedGroupBudgetTracker.Controls.Add(textBoxTotalSpent);
            roundedGroupBudgetTracker.Controls.Add(textBoxTotalBudget);
            roundedGroupBudgetTracker.Controls.Add(textBox18);
            roundedGroupBudgetTracker.Controls.Add(textBoxMiscRemaining);
            roundedGroupBudgetTracker.Controls.Add(textBoxMiscSpent);
            roundedGroupBudgetTracker.Controls.Add(textBoxMiscBudget);
            roundedGroupBudgetTracker.Controls.Add(textBox14);
            roundedGroupBudgetTracker.Controls.Add(textBoxShoppingRemaining);
            roundedGroupBudgetTracker.Controls.Add(textBoxShoppingSpent);
            roundedGroupBudgetTracker.Controls.Add(textBoxShoppingBudget);
            roundedGroupBudgetTracker.Controls.Add(textBox10);
            roundedGroupBudgetTracker.Controls.Add(textBoxDiningRemaining);
            roundedGroupBudgetTracker.Controls.Add(textBoxDiningOutSpent);
            roundedGroupBudgetTracker.Controls.Add(textBoxDiningOutBudget);
            roundedGroupBudgetTracker.Controls.Add(textBox6);
            roundedGroupBudgetTracker.Controls.Add(textBoxGasRemaining);
            roundedGroupBudgetTracker.Controls.Add(textBoxGasSpent);
            roundedGroupBudgetTracker.Controls.Add(textBoxGasBudget);
            roundedGroupBudgetTracker.Controls.Add(textBoxGroceryRemaining);
            roundedGroupBudgetTracker.Controls.Add(textBoxGroceriesSpent);
            roundedGroupBudgetTracker.Controls.Add(textBoxGroceryBudget);
            roundedGroupBudgetTracker.Controls.Add(textBoxRemaining);
            roundedGroupBudgetTracker.Controls.Add(textBoxSpent);
            roundedGroupBudgetTracker.Controls.Add(textBoxBudget);
            roundedGroupBudgetTracker.Controls.Add(buttonAddMonth);
            roundedGroupBudgetTracker.Location = new Point(14, 108);
            roundedGroupBudgetTracker.Name = "roundedGroupBudgetTracker";
            roundedGroupBudgetTracker.Size = new Size(495, 571);
            roundedGroupBudgetTracker.TabIndex = 24;
            roundedGroupBudgetTracker.TabStop = false;
            // 
            // buttonSubtractMonth
            // 
            buttonSubtractMonth.BackColor = Color.White;
            buttonSubtractMonth.Font = new Font("Times New Roman", 24F);
            buttonSubtractMonth.ForeColor = Color.Black;
            buttonSubtractMonth.Location = new Point(-4, 10);
            buttonSubtractMonth.Name = "buttonSubtractMonth";
            buttonSubtractMonth.Size = new Size(61, 56);
            buttonSubtractMonth.TabIndex = 38;
            buttonSubtractMonth.Text = "◀";
            buttonSubtractMonth.UseVisualStyleBackColor = false;
            buttonSubtractMonth.Click += buttonSubtractMonth_Click;
            // 
            // textBoxCurrentMonth
            // 
            textBoxCurrentMonth.BackColor = Color.White;
            textBoxCurrentMonth.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxCurrentMonth.Location = new Point(56, 12);
            textBoxCurrentMonth.Name = "textBoxCurrentMonth";
            textBoxCurrentMonth.ReadOnly = true;
            textBoxCurrentMonth.Size = new Size(380, 53);
            textBoxCurrentMonth.TabIndex = 6;
            textBoxCurrentMonth.Text = "Month";
            textBoxCurrentMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(244, 153, 153);
            textBox3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(0, 99);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(495, 39);
            textBox3.TabIndex = 10;
            textBox3.Text = "Groceries";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(249, 203, 156);
            textBox5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(0, 172);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(495, 39);
            textBox5.TabIndex = 14;
            textBox5.Text = "Gas";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDaysRemaining
            // 
            textBoxDaysRemaining.BackColor = Color.White;
            textBoxDaysRemaining.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxDaysRemaining.Location = new Point(330, 538);
            textBoxDaysRemaining.Name = "textBoxDaysRemaining";
            textBoxDaysRemaining.ReadOnly = true;
            textBoxDaysRemaining.Size = new Size(165, 34);
            textBoxDaysRemaining.TabIndex = 36;
            textBoxDaysRemaining.Text = "DaysRemaining";
            textBoxDaysRemaining.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCurrentDay
            // 
            textBoxCurrentDay.BackColor = Color.White;
            textBoxCurrentDay.Font = new Font("Times New Roman", 13.8F);
            textBoxCurrentDay.ForeColor = Color.Black;
            textBoxCurrentDay.Location = new Point(165, 538);
            textBoxCurrentDay.Name = "textBoxCurrentDay";
            textBoxCurrentDay.ReadOnly = true;
            textBoxCurrentDay.Size = new Size(165, 34);
            textBoxCurrentDay.TabIndex = 35;
            textBoxCurrentDay.Text = "CurrentDay";
            textBoxCurrentDay.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTotalDays
            // 
            textBoxTotalDays.BackColor = Color.White;
            textBoxTotalDays.Font = new Font("Times New Roman", 13.8F);
            textBoxTotalDays.ForeColor = Color.Black;
            textBoxTotalDays.Location = new Point(0, 538);
            textBoxTotalDays.Name = "textBoxTotalDays";
            textBoxTotalDays.ReadOnly = true;
            textBoxTotalDays.Size = new Size(165, 34);
            textBoxTotalDays.TabIndex = 34;
            textBoxTotalDays.Text = "Total Days";
            textBoxTotalDays.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTotalRemaining
            // 
            textBoxTotalRemaining.BackColor = Color.White;
            textBoxTotalRemaining.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxTotalRemaining.Location = new Point(330, 504);
            textBoxTotalRemaining.Name = "textBoxTotalRemaining";
            textBoxTotalRemaining.ReadOnly = true;
            textBoxTotalRemaining.Size = new Size(165, 34);
            textBoxTotalRemaining.TabIndex = 33;
            textBoxTotalRemaining.Text = "TotalRemaining";
            textBoxTotalRemaining.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTotalSpent
            // 
            textBoxTotalSpent.BackColor = Color.White;
            textBoxTotalSpent.Font = new Font("Times New Roman", 13.8F);
            textBoxTotalSpent.ForeColor = Color.Black;
            textBoxTotalSpent.Location = new Point(165, 504);
            textBoxTotalSpent.Name = "textBoxTotalSpent";
            textBoxTotalSpent.ReadOnly = true;
            textBoxTotalSpent.Size = new Size(165, 34);
            textBoxTotalSpent.TabIndex = 32;
            textBoxTotalSpent.Text = "TotalSpent";
            textBoxTotalSpent.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTotalBudget
            // 
            textBoxTotalBudget.BackColor = Color.White;
            textBoxTotalBudget.Font = new Font("Times New Roman", 13.8F);
            textBoxTotalBudget.ForeColor = Color.Black;
            textBoxTotalBudget.Location = new Point(0, 504);
            textBoxTotalBudget.Name = "textBoxTotalBudget";
            textBoxTotalBudget.ReadOnly = true;
            textBoxTotalBudget.Size = new Size(165, 34);
            textBoxTotalBudget.TabIndex = 31;
            textBoxTotalBudget.Text = "Total Budget";
            textBoxTotalBudget.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            textBox18.BackColor = Color.FromArgb(183, 183, 183);
            textBox18.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox18.Location = new Point(0, 465);
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.Size = new Size(495, 39);
            textBox18.TabIndex = 30;
            textBox18.Text = "Totals";
            textBox18.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxMiscRemaining
            // 
            textBoxMiscRemaining.BackColor = Color.White;
            textBoxMiscRemaining.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxMiscRemaining.Location = new Point(330, 431);
            textBoxMiscRemaining.Name = "textBoxMiscRemaining";
            textBoxMiscRemaining.ReadOnly = true;
            textBoxMiscRemaining.Size = new Size(165, 34);
            textBoxMiscRemaining.TabIndex = 29;
            textBoxMiscRemaining.Text = "MiscRemaining";
            textBoxMiscRemaining.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxMiscSpent
            // 
            textBoxMiscSpent.BackColor = Color.White;
            textBoxMiscSpent.Font = new Font("Times New Roman", 13.8F);
            textBoxMiscSpent.ForeColor = Color.Black;
            textBoxMiscSpent.Location = new Point(165, 431);
            textBoxMiscSpent.Name = "textBoxMiscSpent";
            textBoxMiscSpent.ReadOnly = true;
            textBoxMiscSpent.Size = new Size(165, 34);
            textBoxMiscSpent.TabIndex = 28;
            textBoxMiscSpent.Text = "MiscSpent";
            textBoxMiscSpent.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxMiscBudget
            // 
            textBoxMiscBudget.BackColor = Color.White;
            textBoxMiscBudget.Font = new Font("Times New Roman", 13.8F);
            textBoxMiscBudget.ForeColor = Color.Black;
            textBoxMiscBudget.Location = new Point(0, 431);
            textBoxMiscBudget.Name = "textBoxMiscBudget";
            textBoxMiscBudget.ReadOnly = true;
            textBoxMiscBudget.Size = new Size(165, 34);
            textBoxMiscBudget.TabIndex = 27;
            textBoxMiscBudget.Text = "Misc Budget";
            textBoxMiscBudget.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            textBox14.BackColor = Color.FromArgb(180, 167, 214);
            textBox14.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox14.Location = new Point(0, 392);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(495, 39);
            textBox14.TabIndex = 26;
            textBox14.Text = "Misc";
            textBox14.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxShoppingRemaining
            // 
            textBoxShoppingRemaining.BackColor = Color.White;
            textBoxShoppingRemaining.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxShoppingRemaining.Location = new Point(330, 358);
            textBoxShoppingRemaining.Name = "textBoxShoppingRemaining";
            textBoxShoppingRemaining.ReadOnly = true;
            textBoxShoppingRemaining.Size = new Size(165, 34);
            textBoxShoppingRemaining.TabIndex = 25;
            textBoxShoppingRemaining.Text = "ShoppingRemaining";
            textBoxShoppingRemaining.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxShoppingSpent
            // 
            textBoxShoppingSpent.BackColor = Color.White;
            textBoxShoppingSpent.Font = new Font("Times New Roman", 13.8F);
            textBoxShoppingSpent.ForeColor = Color.Black;
            textBoxShoppingSpent.Location = new Point(165, 358);
            textBoxShoppingSpent.Name = "textBoxShoppingSpent";
            textBoxShoppingSpent.ReadOnly = true;
            textBoxShoppingSpent.Size = new Size(165, 34);
            textBoxShoppingSpent.TabIndex = 24;
            textBoxShoppingSpent.Text = "ShoppingSpent";
            textBoxShoppingSpent.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxShoppingBudget
            // 
            textBoxShoppingBudget.BackColor = Color.White;
            textBoxShoppingBudget.Font = new Font("Times New Roman", 13.8F);
            textBoxShoppingBudget.ForeColor = Color.Black;
            textBoxShoppingBudget.Location = new Point(0, 358);
            textBoxShoppingBudget.Name = "textBoxShoppingBudget";
            textBoxShoppingBudget.ReadOnly = true;
            textBoxShoppingBudget.Size = new Size(165, 34);
            textBoxShoppingBudget.TabIndex = 23;
            textBoxShoppingBudget.Text = "Shopping Budget";
            textBoxShoppingBudget.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(125, 206, 166);
            textBox10.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(0, 319);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(495, 39);
            textBox10.TabIndex = 22;
            textBox10.Text = "Shopping";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDiningRemaining
            // 
            textBoxDiningRemaining.BackColor = Color.White;
            textBoxDiningRemaining.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxDiningRemaining.Location = new Point(330, 285);
            textBoxDiningRemaining.Name = "textBoxDiningRemaining";
            textBoxDiningRemaining.ReadOnly = true;
            textBoxDiningRemaining.Size = new Size(165, 34);
            textBoxDiningRemaining.TabIndex = 21;
            textBoxDiningRemaining.Text = "DiningRemaining";
            textBoxDiningRemaining.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDiningOutSpent
            // 
            textBoxDiningOutSpent.BackColor = Color.White;
            textBoxDiningOutSpent.Font = new Font("Times New Roman", 13.8F);
            textBoxDiningOutSpent.ForeColor = Color.Black;
            textBoxDiningOutSpent.Location = new Point(165, 285);
            textBoxDiningOutSpent.Name = "textBoxDiningOutSpent";
            textBoxDiningOutSpent.ReadOnly = true;
            textBoxDiningOutSpent.Size = new Size(165, 34);
            textBoxDiningOutSpent.TabIndex = 20;
            textBoxDiningOutSpent.Text = "DiningOutSpent";
            textBoxDiningOutSpent.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDiningOutBudget
            // 
            textBoxDiningOutBudget.BackColor = Color.White;
            textBoxDiningOutBudget.Font = new Font("Times New Roman", 13.8F);
            textBoxDiningOutBudget.ForeColor = Color.Black;
            textBoxDiningOutBudget.Location = new Point(0, 285);
            textBoxDiningOutBudget.Name = "textBoxDiningOutBudget";
            textBoxDiningOutBudget.ReadOnly = true;
            textBoxDiningOutBudget.Size = new Size(165, 34);
            textBoxDiningOutBudget.TabIndex = 19;
            textBoxDiningOutBudget.Text = "Dining Out Budget";
            textBoxDiningOutBudget.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(255, 229, 153);
            textBox6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(0, 246);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(495, 39);
            textBox6.TabIndex = 18;
            textBox6.Text = "Dining Out";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxGasRemaining
            // 
            textBoxGasRemaining.BackColor = Color.White;
            textBoxGasRemaining.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxGasRemaining.Location = new Point(330, 212);
            textBoxGasRemaining.Name = "textBoxGasRemaining";
            textBoxGasRemaining.ReadOnly = true;
            textBoxGasRemaining.Size = new Size(165, 34);
            textBoxGasRemaining.TabIndex = 17;
            textBoxGasRemaining.Text = "GasRemaining";
            textBoxGasRemaining.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxGasSpent
            // 
            textBoxGasSpent.BackColor = Color.White;
            textBoxGasSpent.Font = new Font("Times New Roman", 13.8F);
            textBoxGasSpent.ForeColor = Color.Black;
            textBoxGasSpent.Location = new Point(165, 212);
            textBoxGasSpent.Name = "textBoxGasSpent";
            textBoxGasSpent.ReadOnly = true;
            textBoxGasSpent.Size = new Size(165, 34);
            textBoxGasSpent.TabIndex = 16;
            textBoxGasSpent.Text = "GasSpent";
            textBoxGasSpent.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxGasBudget
            // 
            textBoxGasBudget.BackColor = Color.White;
            textBoxGasBudget.Font = new Font("Times New Roman", 13.8F);
            textBoxGasBudget.ForeColor = Color.Black;
            textBoxGasBudget.Location = new Point(0, 212);
            textBoxGasBudget.Name = "textBoxGasBudget";
            textBoxGasBudget.ReadOnly = true;
            textBoxGasBudget.Size = new Size(165, 34);
            textBoxGasBudget.TabIndex = 15;
            textBoxGasBudget.Text = "Gas Budget";
            textBoxGasBudget.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxGroceryRemaining
            // 
            textBoxGroceryRemaining.BackColor = Color.White;
            textBoxGroceryRemaining.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxGroceryRemaining.Location = new Point(330, 138);
            textBoxGroceryRemaining.Name = "textBoxGroceryRemaining";
            textBoxGroceryRemaining.ReadOnly = true;
            textBoxGroceryRemaining.Size = new Size(165, 34);
            textBoxGroceryRemaining.TabIndex = 13;
            textBoxGroceryRemaining.Text = "GroceryRemaining";
            textBoxGroceryRemaining.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxGroceriesSpent
            // 
            textBoxGroceriesSpent.BackColor = Color.White;
            textBoxGroceriesSpent.Font = new Font("Times New Roman", 13.8F);
            textBoxGroceriesSpent.ForeColor = Color.Black;
            textBoxGroceriesSpent.Location = new Point(165, 138);
            textBoxGroceriesSpent.Name = "textBoxGroceriesSpent";
            textBoxGroceriesSpent.ReadOnly = true;
            textBoxGroceriesSpent.Size = new Size(165, 34);
            textBoxGroceriesSpent.TabIndex = 12;
            textBoxGroceriesSpent.Text = "GroceriesSpent";
            textBoxGroceriesSpent.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxGroceryBudget
            // 
            textBoxGroceryBudget.BackColor = Color.White;
            textBoxGroceryBudget.Font = new Font("Times New Roman", 13.8F);
            textBoxGroceryBudget.ForeColor = Color.Black;
            textBoxGroceryBudget.Location = new Point(0, 138);
            textBoxGroceryBudget.Name = "textBoxGroceryBudget";
            textBoxGroceryBudget.ReadOnly = true;
            textBoxGroceryBudget.Size = new Size(165, 34);
            textBoxGroceryBudget.TabIndex = 11;
            textBoxGroceryBudget.Text = "Groceries";
            textBoxGroceryBudget.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxRemaining
            // 
            textBoxRemaining.BackColor = Color.White;
            textBoxRemaining.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxRemaining.Location = new Point(330, 65);
            textBoxRemaining.Name = "textBoxRemaining";
            textBoxRemaining.ReadOnly = true;
            textBoxRemaining.Size = new Size(165, 34);
            textBoxRemaining.TabIndex = 9;
            textBoxRemaining.Text = "Remaining";
            textBoxRemaining.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxSpent
            // 
            textBoxSpent.BackColor = Color.White;
            textBoxSpent.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxSpent.Location = new Point(165, 65);
            textBoxSpent.Name = "textBoxSpent";
            textBoxSpent.ReadOnly = true;
            textBoxSpent.Size = new Size(165, 34);
            textBoxSpent.TabIndex = 8;
            textBoxSpent.Text = "Spent";
            textBoxSpent.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxBudget
            // 
            textBoxBudget.BackColor = Color.White;
            textBoxBudget.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            textBoxBudget.Location = new Point(0, 65);
            textBoxBudget.Name = "textBoxBudget";
            textBoxBudget.ReadOnly = true;
            textBoxBudget.Size = new Size(165, 34);
            textBoxBudget.TabIndex = 7;
            textBoxBudget.Text = "Budget";
            textBoxBudget.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAddMonth
            // 
            buttonAddMonth.BackColor = Color.White;
            buttonAddMonth.Font = new Font("Times New Roman", 24F);
            buttonAddMonth.ForeColor = Color.Black;
            buttonAddMonth.Location = new Point(435, 10);
            buttonAddMonth.Name = "buttonAddMonth";
            buttonAddMonth.Size = new Size(61, 56);
            buttonAddMonth.TabIndex = 39;
            buttonAddMonth.Text = "▶";
            buttonAddMonth.UseVisualStyleBackColor = false;
            buttonAddMonth.Click += buttonAddMonth_Click;
            // 
            // buttonViewTransactions
            // 
            buttonViewTransactions.BackColor = Color.FromArgb(123, 114, 229);
            buttonViewTransactions.FlatAppearance.BorderSize = 0;
            buttonViewTransactions.FlatStyle = FlatStyle.Flat;
            buttonViewTransactions.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonViewTransactions.ForeColor = Color.White;
            buttonViewTransactions.Location = new Point(987, 0);
            buttonViewTransactions.Name = "buttonViewTransactions";
            buttonViewTransactions.Size = new Size(63, 62);
            buttonViewTransactions.TabIndex = 25;
            buttonViewTransactions.Text = "\U0001f9fe";
            buttonViewTransactions.UseVisualStyleBackColor = false;
            buttonViewTransactions.Click += buttonViewTransactions_Click;
            // 
            // roundedGroupBoxBarChart
            // 
            roundedGroupBoxBarChart.BackColor = Color.White;
            roundedGroupBoxBarChart.Controls.Add(label3);
            roundedGroupBoxBarChart.Controls.Add(cartesianChart1);
            roundedGroupBoxBarChart.ForeColor = Color.Black;
            roundedGroupBoxBarChart.Location = new Point(534, 193);
            roundedGroupBoxBarChart.Name = "roundedGroupBoxBarChart";
            roundedGroupBoxBarChart.Size = new Size(497, 486);
            roundedGroupBoxBarChart.TabIndex = 28;
            roundedGroupBoxBarChart.TabStop = false;
            // 
            // cartesianChart1
            // 
            cartesianChart1.ForeColor = Color.Black;
            cartesianChart1.Location = new Point(19, 70);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(448, 392);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // roundedGroupBox1
            // 
            roundedGroupBox1.BackColor = Color.White;
            roundedGroupBox1.Controls.Add(buttonBarChart);
            roundedGroupBox1.Controls.Add(buttonPieChart);
            roundedGroupBox1.ForeColor = Color.Black;
            roundedGroupBox1.Location = new Point(534, 108);
            roundedGroupBox1.Name = "roundedGroupBox1";
            roundedGroupBox1.Size = new Size(497, 79);
            roundedGroupBox1.TabIndex = 29;
            roundedGroupBox1.TabStop = false;
            // 
            // buttonBarChart
            // 
            buttonBarChart.Font = new Font("Times New Roman", 22.2F);
            buttonBarChart.Location = new Point(0, 0);
            buttonBarChart.Name = "buttonBarChart";
            buttonBarChart.Size = new Size(253, 88);
            buttonBarChart.TabIndex = 0;
            buttonBarChart.Text = "📊";
            buttonBarChart.UseVisualStyleBackColor = true;
            buttonBarChart.Click += buttonBarChart_Click;
            // 
            // buttonPieChart
            // 
            buttonPieChart.Font = new Font("Times New Roman", 22.2F);
            buttonPieChart.Location = new Point(251, 0);
            buttonPieChart.Name = "buttonPieChart";
            buttonPieChart.Size = new Size(253, 88);
            buttonPieChart.TabIndex = 1;
            buttonPieChart.Text = "\U0001f967";
            buttonPieChart.UseVisualStyleBackColor = true;
            buttonPieChart.Click += buttonPieChart_Click;
            // 
            // roundedGroupBoxPieChart
            // 
            roundedGroupBoxPieChart.BackColor = Color.White;
            roundedGroupBoxPieChart.Controls.Add(label2);
            roundedGroupBoxPieChart.Controls.Add(pieChart1);
            roundedGroupBoxPieChart.ForeColor = Color.Black;
            roundedGroupBoxPieChart.Location = new Point(534, 193);
            roundedGroupBoxPieChart.Name = "roundedGroupBoxPieChart";
            roundedGroupBoxPieChart.Size = new Size(497, 486);
            roundedGroupBoxPieChart.TabIndex = 29;
            roundedGroupBoxPieChart.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 26);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 1;
            label2.Text = "Percent(%) Of Spend";
            // 
            // pieChart1
            // 
            pieChart1.Location = new Point(19, 70);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(458, 399);
            pieChart1.TabIndex = 0;
            pieChart1.Text = "pieChart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 26);
            label3.Name = "label3";
            label3.Size = new Size(242, 25);
            label3.TabIndex = 2;
            label3.Text = "Percent(%) Of Budget";
            // 
            // BudgetTrackerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1050, 708);
            Controls.Add(roundedGroupBox1);
            Controls.Add(roundedGroupBoxBarChart);
            Controls.Add(buttonViewTransactions);
            Controls.Add(roundedGroupBudgetTracker);
            Controls.Add(buttonBackLogin);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(roundedGroupBoxPieChart);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "BudgetTrackerForm";
            Text = "Budget Tracker";
            Load += BudgetTrackerForm_Load;
            roundedGroupBudgetTracker.ResumeLayout(false);
            roundedGroupBudgetTracker.PerformLayout();
            roundedGroupBoxBarChart.ResumeLayout(false);
            roundedGroupBoxBarChart.PerformLayout();
            roundedGroupBox1.ResumeLayout(false);
            roundedGroupBoxPieChart.ResumeLayout(false);
            roundedGroupBoxPieChart.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonBackLogin;
        private RoundedGroupBox roundedGroupBudgetTracker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spent;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftOver;
        private TextBox textBoxCurrentMonth;
        private TextBox textBoxRemaining;
        private TextBox textBoxSpent;
        private TextBox textBox3;
        private TextBox textBoxGroceryRemaining;
        private TextBox textBoxGroceriesSpent;
        private TextBox textBoxGroceryBudget;
        private TextBox textBoxShoppingRemaining;
        private TextBox textBoxShoppingSpent;
        private TextBox textBoxShoppingBudget;
        private TextBox textBox10;
        private TextBox textBoxDiningRemaining;
        private TextBox textBoxDiningOutSpent;
        private TextBox textBoxDiningOutBudget;
        private TextBox textBox6;
        private TextBox textBoxGasRemaining;
        private TextBox textBoxGasSpent;
        private TextBox textBoxGasBudget;
        private TextBox textBox5;
        private TextBox textBoxMiscRemaining;
        private TextBox textBoxMiscSpent;
        private TextBox textBoxMiscBudget;
        private TextBox textBox14;
        private TextBox textBoxTotalRemaining;
        private TextBox textBoxTotalSpent;
        private TextBox textBoxTotalBudget;
        private TextBox textBox18;
        private TextBox textBoxDaysRemaining;
        private TextBox textBoxCurrentDay;
        private TextBox textBoxTotalDays;
        private TextBox textBoxBudget;
        private Button buttonViewTransactions;
        private RoundedGroupBox roundedGroupBoxBarChart;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private RoundedGroupBox roundedGroupBox1;
        private Button buttonBarChart;
        private Button buttonPieChart;
        private RoundedGroupBox roundedGroupBoxPieChart;
        private Button button3;
        private Button button2;
        private Button buttonSubtractMonth;
        private Button buttonAddMonth;
        private LiveCharts.WinForms.PieChart pieChart1;
        private Label label2;
        private Label label3;
    }
}