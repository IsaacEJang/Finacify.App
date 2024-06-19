namespace MiniProject___Budgetting_App.Forms
{
    partial class AnnualSummaryForm
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
            label1 = new Label();
            buttonBackHome = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(231, 16);
            label1.Name = "label1";
            label1.Size = new Size(76, 53);
            label1.TabIndex = 19;
            label1.Text = "📊";
            // 
            // buttonBackHome
            // 
            buttonBackHome.BackColor = SystemColors.ActiveCaption;
            buttonBackHome.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackHome.ForeColor = Color.SeaShell;
            buttonBackHome.Location = new Point(12, 12);
            buttonBackHome.Name = "buttonBackHome";
            buttonBackHome.Size = new Size(49, 49);
            buttonBackHome.TabIndex = 18;
            buttonBackHome.Text = "↩️";
            buttonBackHome.UseVisualStyleBackColor = false;
            buttonBackHome.Click += buttonBackHome_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SeaShell;
            label7.Location = new Point(113, 69);
            label7.Name = "label7";
            label7.Size = new Size(321, 45);
            label7.TabIndex = 17;
            label7.Text = "Annual Summary";
            // 
            // AnnualSummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(552, 553);
            Controls.Add(label1);
            Controls.Add(buttonBackHome);
            Controls.Add(label7);
            Name = "AnnualSummaryForm";
            Text = "AnnualSummaryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBackHome;
        private Label label7;
    }
}