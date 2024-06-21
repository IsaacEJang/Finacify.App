namespace MiniProject___Budgetting_App.Forms
{
    partial class FeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            buttonBackHome = new Button();
            label1 = new Label();
            label7 = new Label();
            roundedGroupBoxIncome = new RoundedGroupBox();
            roundedButtonSaveBudget = new RoundedButton();
            richTextBoxFeedbackComment = new RichTextBox();
            label2 = new Label();
            comboBoxFeedbackPage = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxTypeOfFeedback = new ComboBox();
            roundedGroupBoxIncome.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBackHome
            // 
            buttonBackHome.BackColor = Color.FromArgb(123, 114, 229);
            buttonBackHome.FlatAppearance.BorderSize = 0;
            buttonBackHome.FlatStyle = FlatStyle.Flat;
            buttonBackHome.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackHome.ForeColor = Color.White;
            buttonBackHome.Location = new Point(11, 13);
            buttonBackHome.Name = "buttonBackHome";
            buttonBackHome.Size = new Size(49, 49);
            buttonBackHome.TabIndex = 23;
            buttonBackHome.Text = "↩️";
            buttonBackHome.UseVisualStyleBackColor = false;
            buttonBackHome.Click += buttonBackHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(227, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 53);
            label1.TabIndex = 22;
            label1.Text = "📝";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(110, 77);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(299, 45);
            label7.TabIndex = 21;
            label7.Text = "Leave Feedback";
            // 
            // roundedGroupBoxIncome
            // 
            roundedGroupBoxIncome.BackColor = Color.White;
            roundedGroupBoxIncome.Controls.Add(label4);
            roundedGroupBoxIncome.Controls.Add(comboBoxTypeOfFeedback);
            roundedGroupBoxIncome.Controls.Add(label3);
            roundedGroupBoxIncome.Controls.Add(comboBoxFeedbackPage);
            roundedGroupBoxIncome.Controls.Add(label2);
            roundedGroupBoxIncome.Controls.Add(richTextBoxFeedbackComment);
            roundedGroupBoxIncome.Location = new Point(17, 161);
            roundedGroupBoxIncome.Name = "roundedGroupBoxIncome";
            roundedGroupBoxIncome.Size = new Size(488, 371);
            roundedGroupBoxIncome.TabIndex = 24;
            roundedGroupBoxIncome.TabStop = false;
            // 
            // roundedButtonSaveBudget
            // 
            roundedButtonSaveBudget.BackColor = Color.FromArgb(123, 114, 229);
            roundedButtonSaveBudget.FlatAppearance.BorderSize = 0;
            roundedButtonSaveBudget.FlatStyle = FlatStyle.Flat;
            roundedButtonSaveBudget.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButtonSaveBudget.ForeColor = Color.White;
            roundedButtonSaveBudget.Location = new Point(170, 564);
            roundedButtonSaveBudget.Name = "roundedButtonSaveBudget";
            roundedButtonSaveBudget.Size = new Size(176, 47);
            roundedButtonSaveBudget.TabIndex = 28;
            roundedButtonSaveBudget.Text = "📪 Submit ";
            roundedButtonSaveBudget.UseVisualStyleBackColor = false;
            // 
            // richTextBoxFeedbackComment
            // 
            richTextBoxFeedbackComment.Location = new Point(29, 181);
            richTextBoxFeedbackComment.Name = "richTextBoxFeedbackComment";
            richTextBoxFeedbackComment.Size = new Size(436, 170);
            richTextBoxFeedbackComment.TabIndex = 0;
            richTextBoxFeedbackComment.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 156);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 1;
            label2.Text = "Comments:";
            // 
            // comboBoxFeedbackPage
            // 
            comboBoxFeedbackPage.FormattingEnabled = true;
            comboBoxFeedbackPage.Location = new Point(197, 99);
            comboBoxFeedbackPage.Name = "comboBoxFeedbackPage";
            comboBoxFeedbackPage.Size = new Size(268, 30);
            comboBoxFeedbackPage.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 102);
            label3.Name = "label3";
            label3.Size = new Size(110, 22);
            label3.TabIndex = 3;
            label3.Text = "Which Page:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 43);
            label4.Name = "label4";
            label4.Size = new Size(157, 22);
            label4.TabIndex = 5;
            label4.Text = "Type of Feedback:";
            // 
            // comboBoxTypeOfFeedback
            // 
            comboBoxTypeOfFeedback.FormattingEnabled = true;
            comboBoxTypeOfFeedback.Location = new Point(197, 40);
            comboBoxTypeOfFeedback.Name = "comboBoxTypeOfFeedback";
            comboBoxTypeOfFeedback.Size = new Size(268, 30);
            comboBoxTypeOfFeedback.TabIndex = 4;
            // 
            // FeedbackForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 623);
            Controls.Add(roundedButtonSaveBudget);
            Controls.Add(roundedGroupBoxIncome);
            Controls.Add(buttonBackHome);
            Controls.Add(label1);
            Controls.Add(label7);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FeedbackForm";
            Text = "FeedbackForm";
            roundedGroupBoxIncome.ResumeLayout(false);
            roundedGroupBoxIncome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBackHome;
        private Label label1;
        private Label label7;
        private RoundedGroupBox roundedGroupBoxIncome;
        private RoundedButton roundedButtonSaveBudget;
        private RichTextBox richTextBoxFeedbackComment;
        private Label label3;
        private ComboBox comboBoxFeedbackPage;
        private Label label2;
        private Label label4;
        private ComboBox comboBoxTypeOfFeedback;
    }
}