namespace MiniProject___Budgetting_App.Forms
{
    partial class BudgetTrackerProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetTrackerProgressForm));
            label2 = new Label();
            roundedGroupBoxSetBudget = new RoundedGroupBox();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            roundedGroupBoxSetBudget.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(124, 23);
            label2.Name = "label2";
            label2.Size = new Size(275, 42);
            label2.TabIndex = 30;
            label2.Text = "Budget Progress";
            // 
            // roundedGroupBoxSetBudget
            // 
            roundedGroupBoxSetBudget.BackColor = Color.White;
            roundedGroupBoxSetBudget.Controls.Add(cartesianChart1);
            roundedGroupBoxSetBudget.ForeColor = Color.Black;
            roundedGroupBoxSetBudget.Location = new Point(10, 68);
            roundedGroupBoxSetBudget.Name = "roundedGroupBoxSetBudget";
            roundedGroupBoxSetBudget.Size = new Size(500, 399);
            roundedGroupBoxSetBudget.TabIndex = 27;
            roundedGroupBoxSetBudget.TabStop = false;
            // 
            // cartesianChart1
            // 
            cartesianChart1.ForeColor = Color.Black;
            cartesianChart1.Location = new Point(6, 40);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(475, 343);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // BudgetTrackerProgressForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 493);
            Controls.Add(label2);
            Controls.Add(roundedGroupBoxSetBudget);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BudgetTrackerProgressForm";
            Text = "Budget Progress";
            roundedGroupBoxSetBudget.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private RoundedGroupBox roundedGroupBoxSetBudget;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}