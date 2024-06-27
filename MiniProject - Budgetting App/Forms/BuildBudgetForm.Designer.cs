namespace MiniProject___Budgetting_App.Forms
{
    partial class BuildBudgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildBudgetForm));
            buttonBackLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            roundedGroupBoxIncome = new RoundedGroupBox();
            roundedCalculate = new RoundedButton();
            textBoxPostTaxMonthlyIncome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            roundedGroupBox2 = new RoundedGroupBox();
            dataGridViewRecommend = new DataGridView();
            linkLabelRecommendations = new LinkLabel();
            roundedGroupBoxSetBudget = new RoundedGroupBox();
            textBoxSetBudgetMisc = new TextBox();
            textBoxSetBudgetShopping = new TextBox();
            textBoxSetBudgetDiningOut = new TextBox();
            textBoxSetBudgetGas = new TextBox();
            textBoxSetBudgetGroceries = new TextBox();
            linkLabelSetBudget = new LinkLabel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            roundedButtonSaveBudget = new RoundedButton();
            roundedGroupBoxIncome.SuspendLayout();
            roundedGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecommend).BeginInit();
            roundedGroupBoxSetBudget.SuspendLayout();
            SuspendLayout();
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
            buttonBackLogin.TabIndex = 20;
            buttonBackLogin.Text = "↩️";
            buttonBackLogin.UseVisualStyleBackColor = false;
            buttonBackLogin.Click += buttonBackLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 68);
            label1.TabIndex = 21;
            label1.Text = "🏦 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(140, 77);
            label2.Name = "label2";
            label2.Size = new Size(260, 42);
            label2.TabIndex = 22;
            label2.Text = "Build A Budget";
            // 
            // roundedGroupBoxIncome
            // 
            roundedGroupBoxIncome.BackColor = Color.White;
            roundedGroupBoxIncome.Controls.Add(roundedCalculate);
            roundedGroupBoxIncome.Controls.Add(textBoxPostTaxMonthlyIncome);
            roundedGroupBoxIncome.Controls.Add(label4);
            roundedGroupBoxIncome.Controls.Add(label3);
            roundedGroupBoxIncome.Location = new Point(17, 130);
            roundedGroupBoxIncome.Name = "roundedGroupBoxIncome";
            roundedGroupBoxIncome.Size = new Size(488, 88);
            roundedGroupBoxIncome.TabIndex = 23;
            roundedGroupBoxIncome.TabStop = false;
            // 
            // roundedCalculate
            // 
            roundedCalculate.BackColor = Color.FromArgb(123, 114, 229);
            roundedCalculate.FlatAppearance.BorderSize = 0;
            roundedCalculate.FlatStyle = FlatStyle.Flat;
            roundedCalculate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedCalculate.ForeColor = Color.White;
            roundedCalculate.Location = new Point(351, 29);
            roundedCalculate.Name = "roundedCalculate";
            roundedCalculate.Size = new Size(122, 42);
            roundedCalculate.TabIndex = 25;
            roundedCalculate.Text = "Calculate";
            roundedCalculate.UseVisualStyleBackColor = false;
            roundedCalculate.Click += roundedCalculate_Click;
            // 
            // textBoxPostTaxMonthlyIncome
            // 
            textBoxPostTaxMonthlyIncome.Location = new Point(208, 36);
            textBoxPostTaxMonthlyIncome.Name = "textBoxPostTaxMonthlyIncome";
            textBoxPostTaxMonthlyIncome.Size = new Size(127, 30);
            textBoxPostTaxMonthlyIncome.TabIndex = 2;
            textBoxPostTaxMonthlyIncome.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 34);
            label4.Name = "label4";
            label4.Size = new Size(36, 33);
            label4.TabIndex = 1;
            label4.Text = "$:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 26);
            label3.Name = "label3";
            label3.Size = new Size(154, 44);
            label3.TabIndex = 0;
            label3.Text = "Total Monthly \r\nIncome (Post Tax)\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedGroupBox2
            // 
            roundedGroupBox2.BackColor = Color.White;
            roundedGroupBox2.Controls.Add(dataGridViewRecommend);
            roundedGroupBox2.Controls.Add(linkLabelRecommendations);
            roundedGroupBox2.Location = new Point(17, 218);
            roundedGroupBox2.Name = "roundedGroupBox2";
            roundedGroupBox2.Size = new Size(488, 137);
            roundedGroupBox2.TabIndex = 25;
            roundedGroupBox2.TabStop = false;
            // 
            // dataGridViewRecommend
            // 
            dataGridViewRecommend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecommend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecommend.Location = new Point(-51, 54);
            dataGridViewRecommend.Name = "dataGridViewRecommend";
            dataGridViewRecommend.RowHeadersWidth = 51;
            dataGridViewRecommend.Size = new Size(538, 99);
            dataGridViewRecommend.TabIndex = 1;
            // 
            // linkLabelRecommendations
            // 
            linkLabelRecommendations.AutoSize = true;
            linkLabelRecommendations.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelRecommendations.LinkColor = Color.FromArgb(123, 114, 229);
            linkLabelRecommendations.Location = new Point(170, 23);
            linkLabelRecommendations.Name = "linkLabelRecommendations";
            linkLabelRecommendations.Size = new Size(163, 23);
            linkLabelRecommendations.TabIndex = 0;
            linkLabelRecommendations.TabStop = true;
            linkLabelRecommendations.Text = "Recommendations";
            linkLabelRecommendations.LinkClicked += linkLabelRecommendations_LinkClicked;
            // 
            // roundedGroupBoxSetBudget
            // 
            roundedGroupBoxSetBudget.BackColor = Color.White;
            roundedGroupBoxSetBudget.Controls.Add(textBoxSetBudgetMisc);
            roundedGroupBoxSetBudget.Controls.Add(textBoxSetBudgetShopping);
            roundedGroupBoxSetBudget.Controls.Add(textBoxSetBudgetDiningOut);
            roundedGroupBoxSetBudget.Controls.Add(textBoxSetBudgetGas);
            roundedGroupBoxSetBudget.Controls.Add(textBoxSetBudgetGroceries);
            roundedGroupBoxSetBudget.Controls.Add(linkLabelSetBudget);
            roundedGroupBoxSetBudget.Controls.Add(label10);
            roundedGroupBoxSetBudget.Controls.Add(label9);
            roundedGroupBoxSetBudget.Controls.Add(label8);
            roundedGroupBoxSetBudget.Controls.Add(label7);
            roundedGroupBoxSetBudget.Controls.Add(label6);
            roundedGroupBoxSetBudget.Location = new Point(16, 358);
            roundedGroupBoxSetBudget.Name = "roundedGroupBoxSetBudget";
            roundedGroupBoxSetBudget.Size = new Size(488, 192);
            roundedGroupBoxSetBudget.TabIndex = 26;
            roundedGroupBoxSetBudget.TabStop = false;
            // 
            // textBoxSetBudgetMisc
            // 
            textBoxSetBudgetMisc.Location = new Point(346, 116);
            textBoxSetBudgetMisc.Name = "textBoxSetBudgetMisc";
            textBoxSetBudgetMisc.Size = new Size(125, 30);
            textBoxSetBudgetMisc.TabIndex = 16;
            textBoxSetBudgetMisc.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxSetBudgetShopping
            // 
            textBoxSetBudgetShopping.Location = new Point(347, 69);
            textBoxSetBudgetShopping.Name = "textBoxSetBudgetShopping";
            textBoxSetBudgetShopping.Size = new Size(125, 30);
            textBoxSetBudgetShopping.TabIndex = 15;
            textBoxSetBudgetShopping.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxSetBudgetDiningOut
            // 
            textBoxSetBudgetDiningOut.Location = new Point(116, 136);
            textBoxSetBudgetDiningOut.Name = "textBoxSetBudgetDiningOut";
            textBoxSetBudgetDiningOut.Size = new Size(129, 30);
            textBoxSetBudgetDiningOut.TabIndex = 14;
            textBoxSetBudgetDiningOut.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxSetBudgetGas
            // 
            textBoxSetBudgetGas.Location = new Point(116, 97);
            textBoxSetBudgetGas.Name = "textBoxSetBudgetGas";
            textBoxSetBudgetGas.Size = new Size(129, 30);
            textBoxSetBudgetGas.TabIndex = 13;
            textBoxSetBudgetGas.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxSetBudgetGroceries
            // 
            textBoxSetBudgetGroceries.Location = new Point(116, 55);
            textBoxSetBudgetGroceries.Name = "textBoxSetBudgetGroceries";
            textBoxSetBudgetGroceries.Size = new Size(129, 30);
            textBoxSetBudgetGroceries.TabIndex = 12;
            textBoxSetBudgetGroceries.TextAlign = HorizontalAlignment.Right;
            // 
            // linkLabelSetBudget
            // 
            linkLabelSetBudget.AutoSize = true;
            linkLabelSetBudget.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelSetBudget.LinkColor = Color.FromArgb(123, 114, 229);
            linkLabelSetBudget.Location = new Point(180, 24);
            linkLabelSetBudget.Name = "linkLabelSetBudget";
            linkLabelSetBudget.Size = new Size(146, 23);
            linkLabelSetBudget.TabIndex = 11;
            linkLabelSetBudget.TabStop = true;
            linkLabelSetBudget.Text = "Set Your Budget";
            linkLabelSetBudget.LinkClicked += linkLabelSetBudget_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(284, 124);
            label10.Name = "label10";
            label10.Size = new Size(56, 22);
            label10.TabIndex = 5;
            label10.Text = "Misc:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 105);
            label9.Name = "label9";
            label9.Size = new Size(47, 22);
            label9.TabIndex = 4;
            label9.Text = "Gas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 144);
            label8.Name = "label8";
            label8.Size = new Size(102, 22);
            label8.TabIndex = 3;
            label8.Text = "Dining Out:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(258, 77);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 2;
            label7.Text = "Shopping:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 63);
            label6.Name = "label6";
            label6.Size = new Size(95, 22);
            label6.TabIndex = 1;
            label6.Text = "Groceries:";
            // 
            // roundedButtonSaveBudget
            // 
            roundedButtonSaveBudget.BackColor = Color.FromArgb(123, 114, 229);
            roundedButtonSaveBudget.FlatAppearance.BorderSize = 0;
            roundedButtonSaveBudget.FlatStyle = FlatStyle.Flat;
            roundedButtonSaveBudget.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButtonSaveBudget.ForeColor = Color.White;
            roundedButtonSaveBudget.Location = new Point(182, 564);
            roundedButtonSaveBudget.Name = "roundedButtonSaveBudget";
            roundedButtonSaveBudget.Size = new Size(176, 47);
            roundedButtonSaveBudget.TabIndex = 27;
            roundedButtonSaveBudget.Text = "💾 Save Budget";
            roundedButtonSaveBudget.UseVisualStyleBackColor = false;
            roundedButtonSaveBudget.Click += roundedButtonSaveBudget_Click;
            // 
            // BuildBudgetForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 623);
            Controls.Add(roundedButtonSaveBudget);
            Controls.Add(roundedGroupBoxSetBudget);
            Controls.Add(roundedGroupBox2);
            Controls.Add(roundedGroupBoxIncome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBackLogin);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            Name = "BuildBudgetForm";
            Text = "Build A Budget";
            roundedGroupBoxIncome.ResumeLayout(false);
            roundedGroupBoxIncome.PerformLayout();
            roundedGroupBox2.ResumeLayout(false);
            roundedGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecommend).EndInit();
            roundedGroupBoxSetBudget.ResumeLayout(false);
            roundedGroupBoxSetBudget.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBackLogin;
        private Label label1;
        private Label label2;
        private RoundedGroupBox roundedGroupBoxIncome;
        private Label label3;
        private Label label4;
        private TextBox textBoxPostTaxMonthlyIncome;
        private RoundedButton roundedCalculate;
        private RoundedGroupBox roundedGroupBox2;
        private LinkLabel linkLabelRecommendations;
        private DataGridView dataGridViewRecommend;
        private RoundedGroupBox roundedGroupBoxSetBudget;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private LinkLabel linkLabelSetBudget;
        private RoundedButton roundedButtonSaveBudget;
        private TextBox textBoxSetBudgetGas;
        private TextBox textBoxSetBudgetGroceries;
        private TextBox textBoxSetBudgetMisc;
        private TextBox textBoxSetBudgetShopping;
        private TextBox textBoxSetBudgetDiningOut;
    }
}