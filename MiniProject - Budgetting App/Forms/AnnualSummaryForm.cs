using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject___Budgetting_App.Forms
{
    public partial class AnnualSummaryForm : Form
    {
        public AnnualSummaryForm()
        {
            InitializeComponent();
        }

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }
    }
}
