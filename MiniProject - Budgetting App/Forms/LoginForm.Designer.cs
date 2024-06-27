namespace MiniProject___Budgetting_App
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            buttonSignIn = new RoundedButton();
            groupBox1 = new RoundedGroupBox();
            label4 = new Label();
            label3 = new Label();
            textBoxLoginPassword = new TextBox();
            textBoxLoginEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            linkLabelCreateAccount = new LinkLabel();
            linkLabelForgotPassword = new LinkLabel();
            AppName = new Label();
            AppLogo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.FromArgb(123, 114, 229);
            buttonSignIn.FlatAppearance.BorderSize = 0;
            buttonSignIn.FlatStyle = FlatStyle.Flat;
            buttonSignIn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignIn.ForeColor = Color.White;
            buttonSignIn.Location = new Point(128, 278);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(175, 46);
            buttonSignIn.TabIndex = 5;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonLogin_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxLoginPassword);
            groupBox1.Controls.Add(textBoxLoginEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(linkLabelCreateAccount);
            groupBox1.Controls.Add(linkLabelForgotPassword);
            groupBox1.Controls.Add(buttonSignIn);
            groupBox1.Location = new Point(64, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 407);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(25, 67);
            label4.Name = "label4";
            label4.Size = new Size(184, 19);
            label4.TabIndex = 14;
            label4.Text = "Please sign in to continue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 25);
            label3.Name = "label3";
            label3.Size = new Size(104, 42);
            label3.TabIndex = 13;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginPassword.Location = new Point(25, 220);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(359, 34);
            textBoxLoginPassword.TabIndex = 12;
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginEmail.Location = new Point(25, 139);
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.Size = new Size(359, 34);
            textBoxLoginEmail.TabIndex = 11;
            textBoxLoginEmail.TextChanged += textBoxLoginEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(25, 195);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(25, 114);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 9;
            label1.Text = "Email:";
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelCreateAccount.Location = new Point(25, 338);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(110, 46);
            linkLabelCreateAccount.TabIndex = 7;
            linkLabelCreateAccount.TabStop = true;
            linkLabelCreateAccount.Text = "Don't have \r\nan account?";
            linkLabelCreateAccount.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelCreateAccount.LinkClicked += linkLabelCreateAccount_LinkClicked;
            // 
            // linkLabelForgotPassword
            // 
            linkLabelForgotPassword.AutoSize = true;
            linkLabelForgotPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelForgotPassword.Location = new Point(298, 338);
            linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            linkLabelForgotPassword.Size = new Size(100, 46);
            linkLabelForgotPassword.TabIndex = 6;
            linkLabelForgotPassword.TabStop = true;
            linkLabelForgotPassword.Text = "Forgot\r\nPassword?";
            linkLabelForgotPassword.TextAlign = ContentAlignment.MiddleCenter;
            linkLabelForgotPassword.LinkClicked += linkLabelForgotPassword_LinkClicked;
            // 
            // AppName
            // 
            AppName.AutoSize = true;
            AppName.BackColor = Color.Transparent;
            AppName.Font = new Font("Times New Roman", 36F, FontStyle.Bold);
            AppName.ForeColor = Color.White;
            AppName.Location = new Point(131, 117);
            AppName.Name = "AppName";
            AppName.Size = new Size(274, 68);
            AppName.TabIndex = 17;
            AppName.Text = "Financify";
            // 
            // AppLogo
            // 
            AppLogo.AutoSize = true;
            AppLogo.BackColor = Color.Transparent;
            AppLogo.Font = new Font("Times New Roman", 55.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppLogo.ForeColor = Color.White;
            AppLogo.Location = new Point(192, 12);
            AppLogo.Name = "AppLogo";
            AppLogo.Size = new Size(152, 105);
            AppLogo.TabIndex = 16;
            AppLogo.Text = "💰";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 623);
            Controls.Add(AppName);
            Controls.Add(AppLogo);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundedButton buttonSignIn;
        private RoundedGroupBox groupBox1;
        private LinkLabel linkLabelForgotPassword;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabelCreateAccount;
        private Label AppName;
        private Label AppLogo;
        private TextBox textBoxLoginPassword;
        private TextBox textBoxLoginEmail;
        private Label label3;
        private Label label4;
    }
}
