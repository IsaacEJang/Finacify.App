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
            richTextBoxUserPassword = new RichTextBox();
            buttonSignIn = new RoundedButton();
            groupBox1 = new RoundedGroupBox();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            linkLabelCreateAccount = new LinkLabel();
            linkLabelForgotPassword = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            TitleLabel1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxUserPassword
            // 
            richTextBoxUserPassword.Location = new Point(25, 146);
            richTextBoxUserPassword.Name = "richTextBoxUserPassword";
            richTextBoxUserPassword.Size = new Size(373, 38);
            richTextBoxUserPassword.TabIndex = 4;
            richTextBoxUserPassword.Text = "";
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.FromArgb(123, 114, 229);
            buttonSignIn.FlatAppearance.BorderSize = 0;
            buttonSignIn.FlatStyle = FlatStyle.Flat;
            buttonSignIn.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignIn.ForeColor = Color.White;
            buttonSignIn.Location = new Point(123, 205);
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
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(linkLabelCreateAccount);
            groupBox1.Controls.Add(richTextBoxUserPassword);
            groupBox1.Controls.Add(linkLabelForgotPassword);
            groupBox1.Controls.Add(buttonSignIn);
            groupBox1.Location = new Point(56, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 336);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 121);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(373, 38);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelCreateAccount.Location = new Point(25, 272);
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
            linkLabelForgotPassword.Location = new Point(298, 272);
            linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            linkLabelForgotPassword.Size = new Size(100, 46);
            linkLabelForgotPassword.TabIndex = 6;
            linkLabelForgotPassword.TabStop = true;
            linkLabelForgotPassword.Text = "Forgot\r\nPassword?";
            linkLabelForgotPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 106);
            label3.Name = "label3";
            label3.Size = new Size(404, 68);
            label3.TabIndex = 7;
            label3.Text = "Welcome Back";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(184, 61);
            label4.Name = "label4";
            label4.Size = new Size(153, 38);
            label4.TabIndex = 8;
            label4.Text = "Financify";
            // 
            // TitleLabel1
            // 
            TitleLabel1.AutoSize = true;
            TitleLabel1.BackColor = Color.Transparent;
            TitleLabel1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel1.ForeColor = Color.White;
            TitleLabel1.Location = new Point(225, 10);
            TitleLabel1.Name = "TitleLabel1";
            TitleLabel1.Size = new Size(71, 51);
            TitleLabel1.TabIndex = 0;
            TitleLabel1.Text = "💰";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 553);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TitleLabel1);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBoxUserPassword;
        private RoundedButton buttonSignIn;
        private RoundedGroupBox groupBox1;
        private LinkLabel linkLabelForgotPassword;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabelCreateAccount;
        private Label label3;
        private Label label4;
        private Label TitleLabel1;
    }
}
