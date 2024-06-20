using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject___Budgetting_App
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
            Centered();

        }
        private void Centered()
        {
            TitleLabel1.Location = new Point((this.ClientSize.Width - TitleLabel1.Width) / 2, TitleLabel1.Location.Y);
        }

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
