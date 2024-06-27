namespace MiniProject___Budgetting_App
{
    partial class CreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            buttonSignUp = new RoundedButton();
            groupBox1 = new RoundedGroupBox();
            textBoxPassword2 = new TextBox();
            textBoxPassword1 = new TextBox();
            textBoxEmail = new TextBox();
            textBoxUserLastName = new TextBox();
            textBoxUserFirstName = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            TitleLabel1 = new Label();
            buttonBackLogin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.FromArgb(123, 114, 229);
            buttonSignUp.FlatAppearance.BorderSize = 0;
            buttonSignUp.FlatStyle = FlatStyle.Flat;
            buttonSignUp.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignUp.ForeColor = Color.White;
            buttonSignUp.Location = new Point(113, 362);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(174, 40);
            buttonSignUp.TabIndex = 5;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBoxPassword2);
            groupBox1.Controls.Add(textBoxPassword1);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxUserLastName);
            groupBox1.Controls.Add(textBoxUserFirstName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonSignUp);
            groupBox1.Location = new Point(70, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 424);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // textBoxPassword2
            // 
            textBoxPassword2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword2.Location = new Point(23, 314);
            textBoxPassword2.Name = "textBoxPassword2";
            textBoxPassword2.PasswordChar = '•';
            textBoxPassword2.Size = new Size(356, 30);
            textBoxPassword2.TabIndex = 22;
            // 
            // textBoxPassword1
            // 
            textBoxPassword1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword1.Location = new Point(23, 232);
            textBoxPassword1.Name = "textBoxPassword1";
            textBoxPassword1.PasswordChar = '•';
            textBoxPassword1.Size = new Size(356, 30);
            textBoxPassword1.TabIndex = 21;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(23, 149);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(356, 30);
            textBoxEmail.TabIndex = 20;
            // 
            // textBoxUserLastName
            // 
            textBoxUserLastName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserLastName.Location = new Point(213, 69);
            textBoxUserLastName.Name = "textBoxUserLastName";
            textBoxUserLastName.Size = new Size(166, 30);
            textBoxUserLastName.TabIndex = 19;
            // 
            // textBoxUserFirstName
            // 
            textBoxUserFirstName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserFirstName.Location = new Point(23, 70);
            textBoxUserFirstName.Name = "textBoxUserFirstName";
            textBoxUserFirstName.Size = new Size(158, 30);
            textBoxUserFirstName.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(213, 44);
            label6.Name = "label6";
            label6.Size = new Size(94, 22);
            label6.TabIndex = 17;
            label6.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 45);
            label3.Name = "label3";
            label3.Size = new Size(98, 22);
            label3.TabIndex = 15;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 289);
            label4.Name = "label4";
            label4.Size = new Size(158, 22);
            label4.TabIndex = 12;
            label4.Text = "Validate Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 207);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 124);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(100, 102);
            label7.Name = "label7";
            label7.Size = new Size(340, 45);
            label7.TabIndex = 11;
            label7.Text = "Create An Account";
            // 
            // TitleLabel1
            // 
            TitleLabel1.Anchor = AnchorStyles.Top;
            TitleLabel1.AutoSize = true;
            TitleLabel1.BackColor = Color.Transparent;
            TitleLabel1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel1.ForeColor = Color.White;
            TitleLabel1.Location = new Point(208, 10);
            TitleLabel1.Name = "TitleLabel1";
            TitleLabel1.Size = new Size(124, 90);
            TitleLabel1.TabIndex = 10;
            TitleLabel1.Text = "👤";
            TitleLabel1.TextAlign = ContentAlignment.MiddleCenter;
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
            buttonBackLogin.TabIndex = 19;
            buttonBackLogin.Text = "↩️";
            buttonBackLogin.UseVisualStyleBackColor = false;
            buttonBackLogin.Click += buttonBackHome_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(522, 623);
            Controls.Add(buttonBackLogin);
            Controls.Add(label7);
            Controls.Add(TitleLabel1);
            Controls.Add(groupBox1);
            Name = "CreateAccountForm";
            Text = "Create Account";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundedButton buttonSignUp;
        private RoundedGroupBox groupBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label3;
        private Label label7;
        private Label TitleLabel1;
        private TextBox textBoxPassword2;
        private TextBox textBoxPassword1;
        private TextBox textBoxEmail;
        private TextBox textBoxUserLastName;
        private TextBox textBoxUserFirstName;
        private Button buttonBackLogin;
    }
}