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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            buttonTrackExpenseForm = new RoundedButton();
            buttonViewTransactionsForm = new RoundedButton();
            buttonMonthsSummaryForm = new RoundedButton();
            buttonLogOut = new RoundedButton();
            AppName = new Label();
            AppLogo = new Label();
            ButtonBuildBudget = new RoundedButton();
            roundedButtonInformation = new RoundedButton();
            roundedButtonFeedback = new RoundedButton();
            SuspendLayout();
            // 
            // buttonTrackExpenseForm
            // 
            buttonTrackExpenseForm.BackColor = Color.White;
            buttonTrackExpenseForm.Font = new Font("Times New Roman", 16.2F);
            buttonTrackExpenseForm.Location = new Point(275, 154);
            buttonTrackExpenseForm.Name = "buttonTrackExpenseForm";
            buttonTrackExpenseForm.Size = new Size(220, 110);
            buttonTrackExpenseForm.TabIndex = 0;
            buttonTrackExpenseForm.Text = "💳 \r\nTrack Expense";
            buttonTrackExpenseForm.UseVisualStyleBackColor = false;
            buttonTrackExpenseForm.Click += buttonTrackExpenseForm_Click;
            // 
            // buttonViewTransactionsForm
            // 
            buttonViewTransactionsForm.BackColor = Color.White;
            buttonViewTransactionsForm.Font = new Font("Times New Roman", 16.2F);
            buttonViewTransactionsForm.Location = new Point(36, 291);
            buttonViewTransactionsForm.Name = "buttonViewTransactionsForm";
            buttonViewTransactionsForm.Size = new Size(220, 110);
            buttonViewTransactionsForm.TabIndex = 1;
            buttonViewTransactionsForm.Text = "\U0001f9fe\r\nView Transactions";
            buttonViewTransactionsForm.UseVisualStyleBackColor = false;
            buttonViewTransactionsForm.Click += buttonViewTransactionsForm_Click;
            // 
            // buttonMonthsSummaryForm
            // 
            buttonMonthsSummaryForm.BackColor = Color.White;
            buttonMonthsSummaryForm.Font = new Font("Times New Roman", 16.2F);
            buttonMonthsSummaryForm.Location = new Point(36, 154);
            buttonMonthsSummaryForm.Name = "buttonMonthsSummaryForm";
            buttonMonthsSummaryForm.Size = new Size(220, 110);
            buttonMonthsSummaryForm.TabIndex = 3;
            buttonMonthsSummaryForm.Text = "💸 \r\nBudget Tracker";
            buttonMonthsSummaryForm.UseVisualStyleBackColor = false;
            buttonMonthsSummaryForm.Click += buttonMonthsSummaryForm_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.FromArgb(123, 114, 229);
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOut.ForeColor = Color.White;
            buttonLogOut.Location = new Point(175, 425);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(184, 46);
            buttonLogOut.TabIndex = 16;
            buttonLogOut.Text = "🔒 Log Out";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // AppName
            // 
            AppName.AutoSize = true;
            AppName.BackColor = Color.Transparent;
            AppName.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold);
            AppName.ForeColor = Color.White;
            AppName.Location = new Point(159, 77);
            AppName.Name = "AppName";
            AppName.Size = new Size(213, 53);
            AppName.TabIndex = 15;
            AppName.Text = "Financify";
            // 
            // AppLogo
            // 
            AppLogo.AutoSize = true;
            AppLogo.BackColor = Color.Transparent;
            AppLogo.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppLogo.ForeColor = Color.White;
            AppLogo.Location = new Point(219, 10);
            AppLogo.Name = "AppLogo";
            AppLogo.Size = new Size(95, 68);
            AppLogo.TabIndex = 14;
            AppLogo.Text = "💰";
            // 
            // ButtonBuildBudget
            // 
            ButtonBuildBudget.BackColor = Color.White;
            ButtonBuildBudget.Font = new Font("Times New Roman", 16.2F);
            ButtonBuildBudget.Location = new Point(275, 291);
            ButtonBuildBudget.Name = "ButtonBuildBudget";
            ButtonBuildBudget.Size = new Size(220, 110);
            ButtonBuildBudget.TabIndex = 17;
            ButtonBuildBudget.Text = "🏦 \r\nBuild Budget";
            ButtonBuildBudget.UseVisualStyleBackColor = false;
            ButtonBuildBudget.Click += ButtonBuildBudget_Click;
            // 
            // roundedButtonInformation
            // 
            roundedButtonInformation.BackColor = Color.FromArgb(123, 114, 229);
            roundedButtonInformation.FlatAppearance.BorderSize = 0;
            roundedButtonInformation.FlatStyle = FlatStyle.Flat;
            roundedButtonInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButtonInformation.ForeColor = Color.White;
            roundedButtonInformation.Location = new Point(471, 1);
            roundedButtonInformation.Name = "roundedButtonInformation";
            roundedButtonInformation.Size = new Size(49, 49);
            roundedButtonInformation.TabIndex = 19;
            roundedButtonInformation.Text = "ℹ️";
            roundedButtonInformation.UseVisualStyleBackColor = false;
            roundedButtonInformation.Click += roundedButtonInformation_Click;
            // 
            // roundedButtonFeedback
            // 
            roundedButtonFeedback.BackColor = Color.Transparent;
            roundedButtonFeedback.FlatAppearance.BorderSize = 0;
            roundedButtonFeedback.FlatStyle = FlatStyle.Flat;
            roundedButtonFeedback.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButtonFeedback.ForeColor = Color.Gray;
            roundedButtonFeedback.Location = new Point(471, 438);
            roundedButtonFeedback.Name = "roundedButtonFeedback";
            roundedButtonFeedback.Size = new Size(49, 49);
            roundedButtonFeedback.TabIndex = 20;
            roundedButtonFeedback.Text = "📝";
            roundedButtonFeedback.UseVisualStyleBackColor = false;
            roundedButtonFeedback.Click += roundedButtonFeedback_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 492);
            Controls.Add(roundedButtonFeedback);
            Controls.Add(roundedButtonInformation);
            Controls.Add(ButtonBuildBudget);
            Controls.Add(buttonLogOut);
            Controls.Add(AppName);
            Controls.Add(AppLogo);
            Controls.Add(buttonMonthsSummaryForm);
            Controls.Add(buttonViewTransactionsForm);
            Controls.Add(buttonTrackExpenseForm);
            Name = "HomePageForm";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AppName;
        private Label AppLogo;
        private RoundedButton buttonTrackExpenseForm;
        private RoundedButton buttonViewTransactionsForm;
        private RoundedButton buttonMonthsSummaryForm;
        private RoundedButton buttonLogOut;
        private RoundedButton ButtonBuildBudget;
        private RoundedButton roundedButtonInformation;
        private RoundedButton roundedButtonFeedback;
    }
}