using System.Drawing.Drawing2D;

namespace Prakt_08_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;

        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            Point[] points = 
                {new Point(5,10),new Point(23,130),new Point(80,57)
            };
           Graphics g = e.Graphics;
           Pen pen=new Pen(Brushes.Black, 3);
            pen.DashStyle = DashStyle.Dot;
            g.DrawEllipse(pen, 50, 50, 100, 100);
            g.DrawRectangle(pen,200,50, 150, 100);
            g.DrawPolygon(pen, points);

      
           g.Dispose();
        }
    }
}