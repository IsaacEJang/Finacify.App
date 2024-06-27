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
            label1 = new Label();
            buttonSubmitExpense = new RoundedButton();
            buttonBackLogin = new Button();
            roundedGroupBox1 = new RoundedGroupBox();
            dateTimePicker = new DateTimePicker();
            label5 = new Label();
            groupBoxDescription = new RoundedGroupBox();
            label3 = new Label();
            textBoxExpenseDescription = new TextBox();
            groupBoxAmount = new RoundedGroupBox();
            label2 = new Label();
            textBoxExpenseAmount = new TextBox();
            groupBoxCategory = new RoundedGroupBox();
            label4 = new Label();
            radioButtonShopping = new RadioButton();
            radioButtonMisc = new RadioButton();
            radioButtonDiningOut = new RadioButton();
            radioButtonGas = new RadioButton();
            radioButtonGroceries = new RadioButton();
            roundedGroupBox1.SuspendLayout();
            groupBoxDescription.SuspendLayout();
            groupBoxAmount.SuspendLayout();
            groupBoxCategory.SuspendLayout();
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
            // buttonSubmitExpense
            // 
            buttonSubmitExpense.BackColor = Color.FromArgb(123, 114, 229);
            buttonSubmitExpense.FlatAppearance.BorderSize = 0;
            buttonSubmitExpense.FlatStyle = FlatStyle.Flat;
            buttonSubmitExpense.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmitExpense.ForeColor = Color.White;
            buttonSubmitExpense.Location = new Point(182, 574);
            buttonSubmitExpense.Name = "buttonSubmitExpense";
            buttonSubmitExpense.Size = new Size(179, 57);
            buttonSubmitExpense.TabIndex = 18;
            buttonSubmitExpense.Text = "💸 Submit";
            buttonSubmitExpense.UseVisualStyleBackColor = false;
            buttonSubmitExpense.Click += buttonSubmitExpense_Click_1;
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
            buttonBackLogin.Click += buttonBackLogin_Click_1;
            // 
            // roundedGroupBox1
            // 
            roundedGroupBox1.BackColor = Color.White;
            roundedGroupBox1.Controls.Add(dateTimePicker);
            roundedGroupBox1.Controls.Add(label5);
            roundedGroupBox1.Location = new Point(51, 102);
            roundedGroupBox1.Name = "roundedGroupBox1";
            roundedGroupBox1.Size = new Size(420, 77);
            roundedGroupBox1.TabIndex = 34;
            roundedGroupBox1.TabStop = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(112, 30);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(288, 30);
            dateTimePicker.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 33);
            label5.Name = "label5";
            label5.Size = new Size(60, 26);
            label5.TabIndex = 1;
            label5.Text = "Date:";
            // 
            // groupBoxDescription
            // 
            groupBoxDescription.BackColor = Color.White;
            groupBoxDescription.Controls.Add(label3);
            groupBoxDescription.Controls.Add(textBoxExpenseDescription);
            groupBoxDescription.Location = new Point(51, 472);
            groupBoxDescription.Name = "groupBoxDescription";
            groupBoxDescription.Size = new Size(420, 77);
            groupBoxDescription.TabIndex = 35;
            groupBoxDescription.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(23, 30);
            label3.Name = "label3";
            label3.Size = new Size(60, 26);
            label3.TabIndex = 1;
            label3.Text = "Item:";
            // 
            // textBoxExpenseDescription
            // 
            textBoxExpenseDescription.Location = new Point(171, 30);
            textBoxExpenseDescription.Name = "textBoxExpenseDescription";
            textBoxExpenseDescription.Size = new Size(217, 30);
            textBoxExpenseDescription.TabIndex = 0;
            textBoxExpenseDescription.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBoxAmount
            // 
            groupBoxAmount.BackColor = Color.White;
            groupBoxAmount.Controls.Add(label2);
            groupBoxAmount.Controls.Add(textBoxExpenseAmount);
            groupBoxAmount.Location = new Point(51, 389);
            groupBoxAmount.Name = "groupBoxAmount";
            groupBoxAmount.Size = new Size(420, 77);
            groupBoxAmount.TabIndex = 33;
            groupBoxAmount.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(23, 31);
            label2.Name = "label2";
            label2.Size = new Size(127, 26);
            label2.TabIndex = 1;
            label2.Text = "Amount ($):";
            // 
            // textBoxExpenseAmount
            // 
            textBoxExpenseAmount.Location = new Point(171, 31);
            textBoxExpenseAmount.Name = "textBoxExpenseAmount";
            textBoxExpenseAmount.Size = new Size(217, 30);
            textBoxExpenseAmount.TabIndex = 0;
            textBoxExpenseAmount.TextAlign = HorizontalAlignment.Right;
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
            groupBoxCategory.Location = new Point(51, 182);
            groupBoxCategory.Name = "groupBoxCategory";
            groupBoxCategory.Size = new Size(420, 203);
            groupBoxCategory.TabIndex = 32;
            groupBoxCategory.TabStop = false;
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
            radioButtonShopping.CheckedChanged += radioButton_CheckedChanged;
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
            radioButtonMisc.CheckedChanged += radioButton_CheckedChanged;
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
            radioButtonDiningOut.CheckedChanged += radioButton_CheckedChanged;
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
            radioButtonGas.CheckedChanged += radioButton_CheckedChanged;
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
            radioButtonGroceries.CheckedChanged += radioButton_CheckedChanged;
            // 
            // TrackExpenseForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 643);
            Controls.Add(roundedGroupBox1);
            Controls.Add(groupBoxDescription);
            Controls.Add(groupBoxAmount);
            Controls.Add(groupBoxCategory);
            Controls.Add(buttonBackLogin);
            Controls.Add(buttonSubmitExpense);
            Controls.Add(label1);
            Controls.Add(label7);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TrackExpenseForm";
            Text = "Track Expense";
            Load += TrackExpenseForm_Load;
            roundedGroupBox1.ResumeLayout(false);
            roundedGroupBox1.PerformLayout();
            groupBoxDescription.ResumeLayout(false);
            groupBoxDescription.PerformLayout();
            groupBoxAmount.ResumeLayout(false);
            groupBoxAmount.PerformLayout();
            groupBoxCategory.ResumeLayout(false);
            groupBoxCategory.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label1;
        private RoundedButton buttonSubmitExpense;
        private Button buttonBackLogin;
        private RoundedGroupBox roundedGroupBox1;
        private DateTimePicker dateTimePicker;
        private Label label5;
        private RoundedGroupBox groupBoxDescription;
        private Label label3;
        private TextBox textBoxExpenseDescription;
        private RoundedGroupBox groupBoxAmount;
        private Label label2;
        private TextBox textBoxExpenseAmount;
        private RoundedGroupBox groupBoxCategory;
        private Label label4;
        private RadioButton radioButtonShopping;
        private RadioButton radioButtonMisc;
        private RadioButton radioButtonDiningOut;
        private RadioButton radioButtonGas;
        private RadioButton radioButtonGroceries;
    }
}