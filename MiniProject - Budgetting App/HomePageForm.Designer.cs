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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            TitleLabel1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 18F);
            button1.Location = new Point(280, 157);
            button1.Name = "button1";
            button1.Size = new Size(230, 120);
            button1.TabIndex = 0;
            button1.Text = "💳 Track Expense";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 18F);
            button2.Location = new Point(12, 311);
            button2.Name = "button2";
            button2.Size = new Size(230, 120);
            button2.TabIndex = 1;
            button2.Text = "\U0001f9fe View All Transactions";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 18F);
            button3.Location = new Point(280, 311);
            button3.Name = "button3";
            button3.Size = new Size(230, 120);
            button3.TabIndex = 2;
            button3.Text = "📊 Annual Summary";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 18F);
            button4.Location = new Point(12, 157);
            button4.Name = "button4";
            button4.Size = new Size(230, 120);
            button4.TabIndex = 3;
            button4.Text = "💸 Month's Summary";
            button4.UseVisualStyleBackColor = true;
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
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.SeaShell;
            button5.Location = new Point(184, 495);
            button5.Name = "button5";
            button5.Size = new Size(146, 46);
            button5.TabIndex = 16;
            button5.Text = "🔒Log Out";
            button5.UseVisualStyleBackColor = false;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(522, 553);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(TitleLabel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "HomePageForm";
            Text = "HomePageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private Label TitleLabel1;
        private Button button5;
    }
}