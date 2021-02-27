using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            graphics.DrawLine(pen, 250, 10, 300, 50);

            graphics.DrawEllipse(pen, new Rectangle(0, 0, 200, 200));

            graphics.DrawRectangle(pen, new Rectangle(0, 0, 200, 200));

            SolidBrush brush = new SolidBrush(Color.Red);
            graphics.FillRectangle(new SolidBrush(Color.Blue), 0, 0, 200, 200);
            graphics.FillEllipse(brush, 0, 0, 200, 200);
            Point[] point =
             {
               new Point(50,  50),
               new Point(100, 25),
               new Point(200, 5),
               new Point(250, 50),
               new Point(300, 100),
               new Point(350, 200),
               new Point(50, 50)
             };
            graphics.DrawPolygon(pen, point);

        }
    }
}
