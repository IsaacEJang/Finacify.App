using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MiniProject___Budgetting_App
{
    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath graphicsPath = new GraphicsPath();
            int radius = 20; // Adjust this value to change the roundness
            int diameter = radius * 2;

            graphicsPath.StartFigure();
            graphicsPath.AddArc(new Rectangle(0, 0, diameter, diameter), 180, 90);
            graphicsPath.AddArc(new Rectangle(Width - diameter, 0, diameter, diameter), -90, 90);
            graphicsPath.AddArc(new Rectangle(Width - diameter, Height - diameter, diameter, diameter), 0, 90);
            graphicsPath.AddArc(new Rectangle(0, Height - diameter, diameter, diameter), 90, 90);
            graphicsPath.CloseFigure();

            Region = new Region(graphicsPath);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(Pens.Transparent, graphicsPath);
        }

    }
}
