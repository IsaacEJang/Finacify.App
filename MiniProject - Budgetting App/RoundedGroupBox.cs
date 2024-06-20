using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MiniProject___Budgetting_App
{
    public class RoundedGroupBox : GroupBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            // Set the smoothing mode to high quality
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Get the dimensions of the group box
            Rectangle rect = new Rectangle(this.ClientRectangle.X, this.ClientRectangle.Y + 10, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 11);

            // Define the radius for the corners
            int radius = 20; // Adjust the radius value as needed

            // Create a path with rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Set the region of the group box to the path with rounded corners
            this.Region = new Region(path);

            // Draw the border of the group box
            using (Pen pen = new Pen(Color.Gray))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // Draw the text of the group box
            SizeF stringSize = e.Graphics.MeasureString(this.Text, this.Font);
            Rectangle textRect = new Rectangle(10, 0, (int)stringSize.Width, (int)stringSize.Height);
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 10, 0);
        }
    }
}
