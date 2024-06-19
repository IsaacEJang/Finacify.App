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
            label7 = new Label();
            buttonBackHome = new Button();
            groupBoxCategory = new GroupBox();
            radioButtonShopping = new RadioButton();
            radioButtonMisc = new RadioButton();
            radioButtonDiningOut = new RadioButton();
            radioButtonGas = new RadioButton();
            radioButtonGroceries = new RadioButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            button5 = new Button();
            groupBoxCategory.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SeaShell;
            label7.Location = new Point(138, 52);
            label7.Name = "label7";
            label7.Size = new Size(275, 45);
            label7.TabIndex = 13;
            label7.Text = "Track Expense";
            // 
            // buttonBackHome
            // 
            buttonBackHome.BackColor = SystemColors.ActiveCaption;
            buttonBackHome.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackHome.ForeColor = Color.SeaShell;
            buttonBackHome.Location = new Point(12, 12);
            buttonBackHome.Name = "buttonBackHome";
            buttonBackHome.Size = new Size(49, 49);
            buttonBackHome.TabIndex = 14;
            buttonBackHome.Text = "↩️";
            buttonBackHome.UseVisualStyleBackColor = false;
            buttonBackHome.Click += buttonBackHome_Click;
            // 
            // groupBoxCategory
            // 
            groupBoxCategory.BackColor = Color.SeaShell;
            groupBoxCategory.Controls.Add(radioButtonShopping);
            groupBoxCategory.Controls.Add(radioButtonMisc);
            groupBoxCategory.Controls.Add(radioButtonDiningOut);
            groupBoxCategory.Controls.Add(radioButtonGas);
            groupBoxCategory.Controls.Add(radioButtonGroceries);
            groupBoxCategory.Location = new Point(12, 110);
            groupBoxCategory.Name = "groupBoxCategory";
            groupBoxCategory.Size = new Size(498, 203);
            groupBoxCategory.TabIndex = 15;
            groupBoxCategory.TabStop = false;
            groupBoxCategory.Text = "Category";
            // 
            // radioButtonShopping
            // 
            radioButtonShopping.AutoSize = true;
            radioButtonShopping.Location = new Point(42, 129);
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
            radioButtonMisc.Location = new Point(42, 161);
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
            radioButtonDiningOut.Location = new Point(42, 97);
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
            radioButtonGas.Location = new Point(42, 65);
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
            radioButtonGroceries.Location = new Point(42, 33);
            radioButtonGroceries.Name = "radioButtonGroceries";
            radioButtonGroceries.Size = new Size(110, 26);
            radioButtonGroceries.TabIndex = 1;
            radioButtonGroceries.TabStop = true;
            radioButtonGroceries.Text = "Groceries";
            radioButtonGroceries.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(225, -1);
            label1.Name = "label1";
            label1.Size = new Size(76, 53);
            label1.TabIndex = 16;
            label1.Text = "💳";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 331);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 91);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Amount ($)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 30);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SeaShell;
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(12, 441);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(498, 91);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 30);
            textBox2.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.SeaShell;
            button5.Location = new Point(174, 554);
            button5.Name = "button5";
            button5.Size = new Size(179, 57);
            button5.TabIndex = 18;
            button5.Text = "💸 Submit";
            button5.UseVisualStyleBackColor = false;
            // 
            // TrackExpenseForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(522, 623);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBoxCategory);
            Controls.Add(buttonBackHome);
            Controls.Add(label7);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TrackExpenseForm";
            Text = "TrackExpenseForm";
            groupBoxCategory.ResumeLayout(false);
            groupBoxCategory.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button buttonBackHome;
        private GroupBox groupBoxCategory;
        private Label label1;
        private RadioButton radioButtonShopping;
        private RadioButton radioButtonMisc;
        private RadioButton radioButtonDiningOut;
        private RadioButton radioButtonGas;
        private RadioButton radioButtonGroceries;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Button button5;
    }
}