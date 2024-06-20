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
            this.textBoxCurrentMonth = new System.Windows.Forms.TextBox();
            label1 = new Label();
            label7 = new Label();
            buttonBackLogin = new Button();
            roundedGroupBudgetTracker = new RoundedGroupBox();
            textBoxCurrentMonth = new TextBox();
            roundedGroupBudgetTracker.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(225, 9);
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
            label7.Location = new Point(105, 62);
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
            roundedGroupBudgetTracker.Controls.Add(textBoxCurrentMonth);
            roundedGroupBudgetTracker.Location = new Point(19, 109);
            roundedGroupBudgetTracker.Name = "roundedGroupBudgetTracker";
            roundedGroupBudgetTracker.Size = new Size(488, 461);
            roundedGroupBudgetTracker.TabIndex = 24;
            roundedGroupBudgetTracker.TabStop = false;
            // 
            // textBoxCurrentMonth
            // 
            textBoxCurrentMonth.BackColor = Color.White;
            textBoxCurrentMonth.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCurrentMonth.ForeColor = Color.Black;
            textBoxCurrentMonth.Location = new Point(6, 24);
            this.textBoxCurrentMonth.ReadOnly = true; // Make it read-only
            textBoxCurrentMonth.Name = "textBoxCurrentMonth";
            textBoxCurrentMonth.Size = new Size(476, 50);
            textBoxCurrentMonth.TabIndex = 0;
            textBoxCurrentMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // BudgetTrackerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 623);
            Controls.Add(roundedGroupBudgetTracker);
            Controls.Add(buttonBackLogin);
            Controls.Add(label1);
            Controls.Add(label7);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "BudgetTrackerForm";
            Text = "Budget Tracker";
            roundedGroupBudgetTracker.ResumeLayout(false);
            roundedGroupBudgetTracker.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Button buttonBackLogin;
        private RoundedGroupBox roundedGroupBudgetTracker;
        private TextBox textBoxCurrentMonth;
    }
}