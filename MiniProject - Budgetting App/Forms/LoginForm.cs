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

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 300);

            // Set the placeholder text for the email TextBox and add event handlers
            SetExampleEmail();
            textBoxLoginEmail.Enter += textBoxLoginEmail_Enter;
            textBoxLoginEmail.Leave += textBoxLoginEmail_Leave;

            // Set the placeholder text for the password TextBox and add event handlers
            SetExamplePassword();
            textBoxLoginPassword.Enter += textBoxLoginPassword_Enter;
            textBoxLoginPassword.Leave += textBoxLoginPassword_Leave;
        }

        // Method to set the example email as placeholder text
        private void SetExampleEmail()
        {
            textBoxLoginEmail.Text = "📧 Infinity.Coders@outlook.com";
            textBoxLoginEmail.ForeColor = Color.Gray; // Set the text color to gray to indicate it is a placeholder
        }

        // Event handler for when the email TextBox gains focus
        private void textBoxLoginEmail_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text and change the text color to black
            if (textBoxLoginEmail.Text == "📧 Infinity.Coders@outlook.com")
            {
                textBoxLoginEmail.Text = "";
                textBoxLoginEmail.ForeColor = Color.Black;
            }
        }

        // Event handler for when the email TextBox loses focus
        private void textBoxLoginEmail_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty, reset the placeholder text
            if (string.IsNullOrWhiteSpace(textBoxLoginEmail.Text))
            {
                SetExampleEmail();
            }
        }

        // Method to set the example password as placeholder text
        private void SetExamplePassword()
        {
            textBoxLoginPassword.UseSystemPasswordChar = false;
            textBoxLoginPassword.Text = "🔒 Password";
            textBoxLoginPassword.ForeColor = Color.Gray;
        }

        // Event handler for when the password TextBox gains focus
        private void textBoxLoginPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxLoginPassword.Text == "🔒 Password")
            {
                textBoxLoginPassword.Text = "";
                textBoxLoginPassword.ForeColor = Color.Black;
                textBoxLoginPassword.UseSystemPasswordChar = true;
            }
        }

        // Event handler for when the password TextBox loses focus
        private void textBoxLoginPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLoginPassword.Text))
            {
                textBoxLoginPassword.UseSystemPasswordChar = false;
                textBoxLoginPassword.Text = "🔒 Password";
                textBoxLoginPassword.ForeColor = Color.Gray;
            }
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

                // Ask the user if they want to take a tour
                DialogResult result = MessageBox.Show("Are you a new user? Would you like to take a tour?", "Welcome", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    homePageForm.UserTour();
                }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLoginEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
