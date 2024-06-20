namespace MiniProject___Budgetting_App.Forms
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            buttonBackLogin = new Button();
            label7 = new Label();
            TitleLabel1 = new Label();
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
            buttonBackLogin.TabIndex = 22;
            buttonBackLogin.Text = "↩️";
            buttonBackLogin.UseVisualStyleBackColor = false;
            buttonBackLogin.Click += buttonBackLogin_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(100, 103);
            label7.Name = "label7";
            label7.Size = new Size(309, 45);
            label7.TabIndex = 21;
            label7.Text = "Forgot Password";
            // 
            // TitleLabel1
            // 
            TitleLabel1.Anchor = AnchorStyles.Top;
            TitleLabel1.AutoSize = true;
            TitleLabel1.BackColor = Color.Transparent;
            TitleLabel1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel1.ForeColor = Color.White;
            TitleLabel1.Location = new Point(208, 11);
            TitleLabel1.Name = "TitleLabel1";
            TitleLabel1.Size = new Size(124, 90);
            TitleLabel1.TabIndex = 20;
            TitleLabel1.Text = "👤";
            TitleLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 553);
            Controls.Add(buttonBackLogin);
            Controls.Add(label7);
            Controls.Add(TitleLabel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBackLogin;
        private Label label7;
        private Label TitleLabel1;
    }
}