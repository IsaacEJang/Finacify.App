using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject___Budgetting_App
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password1 = textBoxPassword1.Text;
            string password2 = textBoxPassword2.Text;

            if (User.ArePasswordsMatching(password1, password2))
            {
                User newUser = new User(email, password1);

                if (newUser.IsValidEmail())
                {
                    if (newUser.AddUser())
                    {
                        MessageBox.Show("Account created successfully!");
                        // Navigate to LoginForm
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Email already exists.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email format. Please use gmail.com, yahoo.com, or outlook.com.");
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }
        }

    }
}
