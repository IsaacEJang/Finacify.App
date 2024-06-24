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
            buttonBackHome = new Button();
            dataGridViewTransactions = new DataGridView();
            roundedEditTransaction = new RoundedButton();
            roundedButtonDeleteTransaction = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(221, 12);
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
            label7.Location = new Point(113, 65);
            label7.Name = "label7";
            label7.Size = new Size(332, 45);
            label7.TabIndex = 17;
            label7.Text = "View Transactions";
            // 
            // buttonBackHome
            // 
            buttonBackHome.BackColor = Color.FromArgb(123, 114, 229);
            buttonBackHome.FlatAppearance.BorderSize = 0;
            buttonBackHome.FlatStyle = FlatStyle.Flat;
            buttonBackHome.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackHome.ForeColor = Color.White;
            buttonBackHome.Location = new Point(12, 12);
            buttonBackHome.Name = "buttonBackHome";
            buttonBackHome.Size = new Size(49, 49);
            buttonBackHome.TabIndex = 23;
            buttonBackHome.Text = "↩️";
            buttonBackHome.UseVisualStyleBackColor = false;
            buttonBackHome.Click += buttonBackHome_Click_1;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(12, 113);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.Size = new Size(498, 423);
            dataGridViewTransactions.TabIndex = 24;
            // 
            // roundedEditTransaction
            // 
            roundedEditTransaction.BackColor = Color.FromArgb(123, 114, 229);
            roundedEditTransaction.FlatAppearance.BorderSize = 0;
            roundedEditTransaction.FlatStyle = FlatStyle.Flat;
            roundedEditTransaction.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedEditTransaction.ForeColor = Color.White;
            roundedEditTransaction.Location = new Point(310, 556);
            roundedEditTransaction.Name = "roundedEditTransaction";
            roundedEditTransaction.Size = new Size(200, 55);
            roundedEditTransaction.TabIndex = 26;
            roundedEditTransaction.Text = "Edit Transaction";
            roundedEditTransaction.UseVisualStyleBackColor = false;
            roundedEditTransaction.Click += roundedEditTransaction_Click;
            // 
            // roundedButtonDeleteTransaction
            // 
            roundedButtonDeleteTransaction.BackColor = Color.FromArgb(255, 128, 128);
            roundedButtonDeleteTransaction.FlatAppearance.BorderSize = 0;
            roundedButtonDeleteTransaction.FlatStyle = FlatStyle.Flat;
            roundedButtonDeleteTransaction.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButtonDeleteTransaction.ForeColor = Color.White;
            roundedButtonDeleteTransaction.Location = new Point(12, 556);
            roundedButtonDeleteTransaction.Name = "roundedButtonDeleteTransaction";
            roundedButtonDeleteTransaction.Size = new Size(200, 55);
            roundedButtonDeleteTransaction.TabIndex = 27;
            roundedButtonDeleteTransaction.Text = "Delete Transaction";
            roundedButtonDeleteTransaction.UseVisualStyleBackColor = false;
            roundedButtonDeleteTransaction.Click += roundedButtonDeleteTransaction_Click;
            // 
            // ViewTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 623);
            Controls.Add(roundedButtonDeleteTransaction);
            Controls.Add(roundedEditTransaction);
            Controls.Add(dataGridViewTransactions);
            Controls.Add(buttonBackHome);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "ViewTransactionsForm";
            Text = "View Transactions";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Button buttonBackHome;
        private DataGridView dataGridViewTransactions;
        private RoundedButton roundedEditTransaction;
        private RoundedButton roundedButtonDeleteTransaction;
    }
}