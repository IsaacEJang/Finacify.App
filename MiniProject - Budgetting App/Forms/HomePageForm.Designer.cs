namespace MiniProject___Budgetting_App
{
    partial class HomePageForm
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
            buttonTrackExpenseForm = new Button();
            buttonViewTransactionsForm = new Button();
            buttonAnnualSummaryForm = new Button();
            buttonMonthsSummaryForm = new Button();
            label7 = new Label();
            TitleLabel1 = new Label();
            buttonLogOut = new Button();
            SuspendLayout();
            // 
            // buttonTrackExpenseForm
            // 
            buttonTrackExpenseForm.Font = new Font("Times New Roman", 18F);
            buttonTrackExpenseForm.Location = new Point(280, 163);
            buttonTrackExpenseForm.Name = "buttonTrackExpenseForm";
            buttonTrackExpenseForm.Size = new Size(230, 120);
            buttonTrackExpenseForm.TabIndex = 0;
            buttonTrackExpenseForm.Text = "💳 Track Expense";
            buttonTrackExpenseForm.UseVisualStyleBackColor = true;
            buttonTrackExpenseForm.Click += buttonTrackExpenseForm_Click;
            // 
            // buttonViewTransactionsForm
            // 
            buttonViewTransactionsForm.Font = new Font("Times New Roman", 18F);
            buttonViewTransactionsForm.Location = new Point(12, 317);
            buttonViewTransactionsForm.Name = "buttonViewTransactionsForm";
            buttonViewTransactionsForm.Size = new Size(230, 120);
            buttonViewTransactionsForm.TabIndex = 1;
            buttonViewTransactionsForm.Text = "\U0001f9fe View All Transactions";
            buttonViewTransactionsForm.UseVisualStyleBackColor = true;
            buttonViewTransactionsForm.Click += buttonViewTransactionsForm_Click;
            // 
            // buttonAnnualSummaryForm
            // 
            buttonAnnualSummaryForm.Font = new Font("Times New Roman", 18F);
            buttonAnnualSummaryForm.Location = new Point(280, 317);
            buttonAnnualSummaryForm.Name = "buttonAnnualSummaryForm";
            buttonAnnualSummaryForm.Size = new Size(230, 120);
            buttonAnnualSummaryForm.TabIndex = 2;
            buttonAnnualSummaryForm.Text = "📊 Annual Summary";
            buttonAnnualSummaryForm.UseVisualStyleBackColor = true;
            buttonAnnualSummaryForm.Click += buttonAnnualSummaryForm_Click;
            // 
            // buttonMonthsSummaryForm
            // 
            buttonMonthsSummaryForm.Font = new Font("Times New Roman", 18F);
            buttonMonthsSummaryForm.Location = new Point(12, 163);
            buttonMonthsSummaryForm.Name = "buttonMonthsSummaryForm";
            buttonMonthsSummaryForm.Size = new Size(230, 120);
            buttonMonthsSummaryForm.TabIndex = 3;
            buttonMonthsSummaryForm.Text = "💸 Month's Summary";
            buttonMonthsSummaryForm.UseVisualStyleBackColor = true;
            buttonMonthsSummaryForm.Click += buttonMonthsSummaryForm_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold);
            label7.ForeColor = Color.SeaShell;
            label7.Location = new Point(159, 77);
            label7.Name = "label7";
            label7.Size = new Size(212, 53);
            label7.TabIndex = 15;
            label7.Text = "PennyPal";
            // 
            // TitleLabel1
            // 
            TitleLabel1.AutoSize = true;
            TitleLabel1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel1.ForeColor = Color.SeaShell;
            TitleLabel1.Location = new Point(219, 9);
            TitleLabel1.Name = "TitleLabel1";
            TitleLabel1.Size = new Size(95, 68);
            TitleLabel1.TabIndex = 14;
            TitleLabel1.Text = "💰";
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = SystemColors.ActiveCaption;
            buttonLogOut.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogOut.ForeColor = Color.SeaShell;
            buttonLogOut.Location = new Point(172, 469);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(184, 46);
            buttonLogOut.TabIndex = 16;
            buttonLogOut.Text = "🔒Log Out";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(522, 553);
            Controls.Add(buttonLogOut);
            Controls.Add(label7);
            Controls.Add(TitleLabel1);
            Controls.Add(buttonMonthsSummaryForm);
            Controls.Add(buttonAnnualSummaryForm);
            Controls.Add(buttonViewTransactionsForm);
            Controls.Add(buttonTrackExpenseForm);
            Name = "HomePageForm";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTrackExpenseForm;
        private Button buttonViewTransactionsForm;
        private Button buttonAnnualSummaryForm;
        private Button buttonMonthsSummaryForm;
        private Label label7;
        private Label TitleLabel1;
        private Button buttonLogOut;
    }
}