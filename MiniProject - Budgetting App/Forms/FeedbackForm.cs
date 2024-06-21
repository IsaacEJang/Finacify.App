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
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();

            // Populate FeedbackType combo box
            comboBoxTypeOfFeedback.Items.Add(""); // Add empty item
            comboBoxTypeOfFeedback.Items.AddRange(Enum.GetNames(typeof(FeedbackType)));
            comboBoxTypeOfFeedback.SelectedIndex = 0; // Select the empty item

            // Populate PageLocation combo box
            comboBoxFeedbackPage.Items.Add(""); // Add empty item
            comboBoxFeedbackPage.Items.AddRange(Enum.GetNames(typeof(PageLocation)));
            comboBoxFeedbackPage.SelectedIndex = 0; // Select the empty item

        }

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

        private void roundedButtonSaveBudget_Click(object sender, EventArgs e)
        {
            // Validate selection
            if (comboBoxTypeOfFeedback.SelectedIndex == 0 || comboBoxFeedbackPage.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid options for Type of Feedback and Which Page.");
                return;
            }

            // Get the selected feedback type and page location
            FeedbackType type = (FeedbackType)Enum.Parse(typeof(FeedbackType), comboBoxTypeOfFeedback.SelectedItem.ToString());
            PageLocation location = (PageLocation)Enum.Parse(typeof(PageLocation), comboBoxFeedbackPage.SelectedItem.ToString());
            string comment = richTextBoxFeedbackComment.Text;

            // Create a new feedback object
            Feedback feedback = new Feedback(type, location, comment);

            // Write feedback to file
            WriteFeedbackToFile(feedback);

            // Refresh and clear the form
            ClearForm();
        }

        private void ClearForm()
        {
            comboBoxTypeOfFeedback.SelectedIndex = 0;
            comboBoxFeedbackPage.SelectedIndex = 0;
            richTextBoxFeedbackComment.Clear();
        }

        private void WriteFeedbackToFile(Feedback feedback)
        {
            string directoryPath = @"C:\MSSA\Assignments\MiniProject - Budgetting App";
            string filePath = Path.Combine(directoryPath, "feedback.txt");
            string feedbackText = feedback.ToString();

            try
            {
                // Ensure the directory exists
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Append the feedback to the file
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(feedbackText);
                }

                MessageBox.Show("Feedback submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to the file: {ex.Message}");
            }
        }
    

    }
}
