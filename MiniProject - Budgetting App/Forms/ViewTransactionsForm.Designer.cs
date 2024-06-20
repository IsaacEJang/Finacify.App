namespace MiniProject___Budgetting_App.Forms
{
    partial class ViewTransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTransactionsForm));
            label1 = new Label();
            label7 = new Label();
            buttonBackLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(246, 12);
            label1.Name = "label1";
            label1.Size = new Size(76, 53);
            label1.TabIndex = 19;
            label1.Text = "\U0001f9fe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SeaShell;
            label7.Location = new Point(95, 65);
            label7.Name = "label7";
            label7.Size = new Size(391, 45);
            label7.TabIndex = 17;
            label7.Text = "View All Transactions";
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
            buttonBackLogin.TabIndex = 23;
            buttonBackLogin.Text = "↩️";
            buttonBackLogin.UseVisualStyleBackColor = false;
            // 
            // ViewTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(552, 553);
            Controls.Add(buttonBackLogin);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "ViewTransactionsForm";
            Text = "View Transactions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Button buttonBackLogin;
    }
}