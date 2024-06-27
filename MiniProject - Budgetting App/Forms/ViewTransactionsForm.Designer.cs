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
            roundedGroupBox1 = new RoundedGroupBox();
            buttonEditTransaction = new Button();
            buttonAddTransaction = new Button();
            buttonDeleteTransaction = new Button();
            buttonExportToExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            roundedGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 12);
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
            label7.ForeColor = Color.White;
            label7.Location = new Point(100, 65);
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
            dataGridViewTransactions.Location = new Point(12, 200);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.Size = new Size(498, 411);
            dataGridViewTransactions.TabIndex = 24;
            // 
            // roundedGroupBox1
            // 
            roundedGroupBox1.BackColor = Color.White;
            roundedGroupBox1.Controls.Add(buttonEditTransaction);
            roundedGroupBox1.Controls.Add(buttonAddTransaction);
            roundedGroupBox1.Controls.Add(buttonDeleteTransaction);
            roundedGroupBox1.Location = new Point(12, 111);
            roundedGroupBox1.Name = "roundedGroupBox1";
            roundedGroupBox1.Size = new Size(498, 70);
            roundedGroupBox1.TabIndex = 29;
            roundedGroupBox1.TabStop = false;
            // 
            // buttonEditTransaction
            // 
            buttonEditTransaction.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditTransaction.Location = new Point(161, 1);
            buttonEditTransaction.Name = "buttonEditTransaction";
            buttonEditTransaction.Size = new Size(175, 72);
            buttonEditTransaction.TabIndex = 2;
            buttonEditTransaction.Text = "✏️";
            buttonEditTransaction.UseVisualStyleBackColor = true;
            buttonEditTransaction.Click += buttonEditTransaction_Click;
            // 
            // buttonAddTransaction
            // 
            buttonAddTransaction.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddTransaction.Location = new Point(325, 2);
            buttonAddTransaction.Name = "buttonAddTransaction";
            buttonAddTransaction.Size = new Size(175, 72);
            buttonAddTransaction.TabIndex = 3;
            buttonAddTransaction.Text = "➕";
            buttonAddTransaction.UseVisualStyleBackColor = true;
            buttonAddTransaction.Click += buttonAddTransaction_Click;
            // 
            // buttonDeleteTransaction
            // 
            buttonDeleteTransaction.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteTransaction.Location = new Point(-4, 2);
            buttonDeleteTransaction.Name = "buttonDeleteTransaction";
            buttonDeleteTransaction.Size = new Size(175, 72);
            buttonDeleteTransaction.TabIndex = 0;
            buttonDeleteTransaction.Text = "🗑";
            buttonDeleteTransaction.UseVisualStyleBackColor = true;
            buttonDeleteTransaction.Click += buttonDeleteTransaction_Click;
            // 
            // buttonExportToExcel
            // 
            buttonExportToExcel.BackColor = Color.FromArgb(123, 114, 229);
            buttonExportToExcel.FlatAppearance.BorderSize = 0;
            buttonExportToExcel.FlatStyle = FlatStyle.Flat;
            buttonExportToExcel.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExportToExcel.ForeColor = Color.White;
            buttonExportToExcel.Location = new Point(466, 1);
            buttonExportToExcel.Name = "buttonExportToExcel";
            buttonExportToExcel.Size = new Size(60, 60);
            buttonExportToExcel.TabIndex = 30;
            buttonExportToExcel.Text = "📤";
            buttonExportToExcel.UseVisualStyleBackColor = false;
            buttonExportToExcel.Click += buttonExportToExcel_Click;
            // 
            // ViewTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 623);
            Controls.Add(buttonExportToExcel);
            Controls.Add(roundedGroupBox1);
            Controls.Add(dataGridViewTransactions);
            Controls.Add(buttonBackHome);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "ViewTransactionsForm";
            Text = "View Transactions";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            roundedGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Button buttonBackHome;
        private DataGridView dataGridViewTransactions;
        private RoundedGroupBox roundedGroupBox1;
        private Button buttonDeleteTransaction;
        private Button buttonAddTransaction;
        private Button buttonEditTransaction;
        private Button buttonExportToExcel;
    }
}