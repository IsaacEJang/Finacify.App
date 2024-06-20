namespace MiniProject___Budgetting_App
{
    partial class TrackExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackExpenseForm));
            label7 = new Label();
            groupBoxCategory = new RoundedGroupBox();
            radioButtonShopping = new RadioButton();
            radioButtonMisc = new RadioButton();
            radioButtonDiningOut = new RadioButton();
            radioButtonGas = new RadioButton();
            radioButtonGroceries = new RadioButton();
            label1 = new Label();
            groupBoxAmount = new RoundedGroupBox();
            textBox1 = new TextBox();
            groupBoxDescription = new RoundedGroupBox();
            label3 = new Label();
            textBox2 = new TextBox();
            buttonSubmitExpense = new RoundedButton();
            buttonBackLogin = new Button();
            label2 = new Label();
            label4 = new Label();
            groupBoxCategory.SuspendLayout();
            groupBoxAmount.SuspendLayout();
            groupBoxDescription.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(138, 52);
            label7.Name = "label7";
            label7.Size = new Size(275, 45);
            label7.TabIndex = 13;
            label7.Text = "Track Expense";
            // 
            // groupBoxCategory
            // 
            groupBoxCategory.BackColor = Color.White;
            groupBoxCategory.Controls.Add(label4);
            groupBoxCategory.Controls.Add(radioButtonShopping);
            groupBoxCategory.Controls.Add(radioButtonMisc);
            groupBoxCategory.Controls.Add(radioButtonDiningOut);
            groupBoxCategory.Controls.Add(radioButtonGas);
            groupBoxCategory.Controls.Add(radioButtonGroceries);
            groupBoxCategory.Location = new Point(54, 100);
            groupBoxCategory.Name = "groupBoxCategory";
            groupBoxCategory.Size = new Size(418, 203);
            groupBoxCategory.TabIndex = 15;
            groupBoxCategory.TabStop = false;
            // 
            // radioButtonShopping
            // 
            radioButtonShopping.AutoSize = true;
            radioButtonShopping.Location = new Point(239, 129);
            radioButtonShopping.Name = "radioButtonShopping";
            radioButtonShopping.Size = new Size(105, 26);
            radioButtonShopping.TabIndex = 5;
            radioButtonShopping.TabStop = true;
            radioButtonShopping.Text = "Shopping";
            radioButtonShopping.UseVisualStyleBackColor = true;
            // 
            // radioButtonMisc
            // 
            radioButtonMisc.AutoSize = true;
            radioButtonMisc.Location = new Point(239, 161);
            radioButtonMisc.Name = "radioButtonMisc";
            radioButtonMisc.Size = new Size(71, 26);
            radioButtonMisc.TabIndex = 4;
            radioButtonMisc.TabStop = true;
            radioButtonMisc.Text = "Misc";
            radioButtonMisc.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiningOut
            // 
            radioButtonDiningOut.AutoSize = true;
            radioButtonDiningOut.Location = new Point(239, 97);
            radioButtonDiningOut.Name = "radioButtonDiningOut";
            radioButtonDiningOut.Size = new Size(117, 26);
            radioButtonDiningOut.TabIndex = 3;
            radioButtonDiningOut.TabStop = true;
            radioButtonDiningOut.Text = "Dining Out";
            radioButtonDiningOut.UseVisualStyleBackColor = true;
            // 
            // radioButtonGas
            // 
            radioButtonGas.AutoSize = true;
            radioButtonGas.Location = new Point(239, 65);
            radioButtonGas.Name = "radioButtonGas";
            radioButtonGas.Size = new Size(62, 26);
            radioButtonGas.TabIndex = 2;
            radioButtonGas.TabStop = true;
            radioButtonGas.Text = "Gas";
            radioButtonGas.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroceries
            // 
            radioButtonGroceries.AutoSize = true;
            radioButtonGroceries.Location = new Point(239, 33);
            radioButtonGroceries.Name = "radioButtonGroceries";
            radioButtonGroceries.Size = new Size(110, 26);
            radioButtonGroceries.TabIndex = 1;
            radioButtonGroceries.TabStop = true;
            radioButtonGroceries.Text = "Groceries";
            radioButtonGroceries.UseVisualStyleBackColor = true;
            radioButtonGroceries.CheckedChanged += radioButtonGroceries_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(225, -1);
            label1.Name = "label1";
            label1.Size = new Size(76, 53);
            label1.TabIndex = 16;
            label1.Text = "💳";
            // 
            // groupBoxAmount
            // 
            groupBoxAmount.BackColor = Color.White;
            groupBoxAmount.Controls.Add(label2);
            groupBoxAmount.Controls.Add(textBox1);
            groupBoxAmount.Location = new Point(54, 322);
            groupBoxAmount.Name = "groupBoxAmount";
            groupBoxAmount.Size = new Size(418, 91);
            groupBoxAmount.TabIndex = 16;
            groupBoxAmount.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 30);
            textBox1.TabIndex = 0;
            // 
            // groupBoxDescription
            // 
            groupBoxDescription.BackColor = Color.White;
            groupBoxDescription.Controls.Add(label3);
            groupBoxDescription.Controls.Add(textBox2);
            groupBoxDescription.Location = new Point(54, 437);
            groupBoxDescription.Name = "groupBoxDescription";
            groupBoxDescription.Size = new Size(418, 91);
            groupBoxDescription.TabIndex = 17;
            groupBoxDescription.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 40);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 1;
            label3.Text = "Description:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 30);
            textBox2.TabIndex = 0;
            // 
            // buttonSubmitExpense
            // 
            buttonSubmitExpense.BackColor = Color.FromArgb(123, 114, 229);
            buttonSubmitExpense.FlatAppearance.BorderSize = 0;
            buttonSubmitExpense.FlatStyle = FlatStyle.Flat;
            buttonSubmitExpense.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmitExpense.ForeColor = Color.White;
            buttonSubmitExpense.Location = new Point(168, 546);
            buttonSubmitExpense.Name = "buttonSubmitExpense";
            buttonSubmitExpense.Size = new Size(179, 57);
            buttonSubmitExpense.TabIndex = 18;
            buttonSubmitExpense.Text = "💸 Submit";
            buttonSubmitExpense.UseVisualStyleBackColor = false;
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
            buttonBackLogin.TabIndex = 22;
            buttonBackLogin.Text = "↩️";
            buttonBackLogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(23, 42);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 1;
            label2.Text = "Amount ($):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 90);
            label4.Name = "label4";
            label4.Size = new Size(123, 33);
            label4.TabIndex = 6;
            label4.Text = "Category:";
            // 
            // TrackExpenseForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 623);
            Controls.Add(buttonBackLogin);
            Controls.Add(buttonSubmitExpense);
            Controls.Add(groupBoxDescription);
            Controls.Add(groupBoxAmount);
            Controls.Add(label1);
            Controls.Add(groupBoxCategory);
            Controls.Add(label7);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TrackExpenseForm";
            Text = "Track Expense";
            groupBoxCategory.ResumeLayout(false);
            groupBoxCategory.PerformLayout();
            groupBoxAmount.ResumeLayout(false);
            groupBoxAmount.PerformLayout();
            groupBoxDescription.ResumeLayout(false);
            groupBoxDescription.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private RoundedGroupBox groupBoxCategory;
        private Label label1;
        private RadioButton radioButtonShopping;
        private RadioButton radioButtonMisc;
        private RadioButton radioButtonDiningOut;
        private RadioButton radioButtonGas;
        private RadioButton radioButtonGroceries;
        private RoundedGroupBox groupBoxAmount;
        private TextBox textBox1;
        private RoundedGroupBox groupBoxDescription;
        private TextBox textBox2;
        private RoundedButton buttonSubmitExpense;
        private Button buttonBackLogin;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}