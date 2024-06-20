namespace MiniProject___Budgetting_App.Forms
{
    partial class BuildBudgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildBudgetForm));
            buttonBackLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
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
            buttonBackLogin.TabIndex = 20;
            buttonBackLogin.Text = "↩️";
            buttonBackLogin.UseVisualStyleBackColor = false;
            buttonBackLogin.Click += buttonBackLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 12);
            label1.Name = "label1";
            label1.Size = new Size(95, 68);
            label1.TabIndex = 21;
            label1.Text = "\U0001fa99";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(151, 80);
            label2.Name = "label2";
            label2.Size = new Size(260, 42);
            label2.TabIndex = 22;
            label2.Text = "Build A Budget";
            // 
            // BuildBudgetForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(552, 553);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBackLogin);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4);
            Name = "BuildBudgetForm";
            Text = "Build A Budget";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBackLogin;
        private Label label1;
        private Label label2;
    }
}