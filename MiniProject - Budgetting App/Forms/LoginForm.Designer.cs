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
            TitleLabel1 = new Label();
            richTextBoxUserPassword = new RichTextBox();
            buttonLogin = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel1
            // 
            TitleLabel1.AutoSize = true;
            TitleLabel1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel1.ForeColor = Color.SeaShell;
            TitleLabel1.Location = new Point(145, 20);
            TitleLabel1.Name = "TitleLabel1";
            TitleLabel1.Size = new Size(238, 32);
            TitleLabel1.TabIndex = 0;
            TitleLabel1.Text = "💰Budgetting App";
            // 
            // richTextBoxUserPassword
            // 
            richTextBoxUserPassword.Location = new Point(28, 138);
            richTextBoxUserPassword.Name = "richTextBoxUserPassword";
            richTextBoxUserPassword.Size = new Size(450, 38);
            richTextBoxUserPassword.TabIndex = 4;
            richTextBoxUserPassword.Text = "";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaption;
            buttonLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.SeaShell;
            buttonLogin.Location = new Point(159, 200);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(175, 46);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(richTextBoxUserPassword);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Location = new Point(12, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 322);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 113);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(28, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(450, 38);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(28, 274);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(161, 23);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(317, 274);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(161, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SeaShell;
            label3.Location = new Point(55, 99);
            label3.Name = "label3";
            label3.Size = new Size(424, 68);
            label3.TabIndex = 7;
            label3.Text = "Welcome Back!";
            label3.Click += this.label3_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(522, 553);
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

        private Label TitleLabel1;
        private RichTextBox richTextBoxUserPassword;
        private Button buttonLogin;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabel2;
        private Label label3;
    }
}
