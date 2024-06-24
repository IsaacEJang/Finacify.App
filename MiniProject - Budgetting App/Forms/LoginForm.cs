using MiniProject___Budgetting_App.Classes;
using MiniProject___Budgetting_App.Forms;
using System.Windows.Forms;

namespace MiniProject___Budgetting_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxLoginEmail.Text;
            string password = textBoxLoginPassword.Text;

            if (User.ValidateLogin(email, password))
            {
                HomePageForm homePageForm = new HomePageForm();
                homePageForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }

    }
}
