using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintOOP
{
    public partial class MainForm : Form
    {
        private Graphics graphics;

        public MainForm()
        {
            InitializeComponent();

            graphics = CreateGraphics(pictureBox.Width, pictureBox.Height);

            Figures.Rectangle rectangle1 = new Figures.Rectangle(new PointF(10.0F, 10.0F), new PointF(100.0F, 100.0F), Color.Black, Color.White, 5.0F);
            rectangle1.Draw(graphics);

            Figures.RegularPolygon polygon1 = new Figures.RegularPolygon(new PointF(200.0F, 60.0F), 50.0F, 4, Color.Black, Color.Red, 5.0F);
            polygon1.Draw(graphics);

            Figures.Ellipse ellipse1 = new Figures.Ellipse(new PointF(50.0F, 150.0F), new PointF(100.0F, 200.0F), Color.Black, Color.Green, 3.0F);
            ellipse1.Draw(graphics);

            Figures.Line line1 = new Figures.Line(new PointF(300.0F, 150.0F), new PointF(400.0F, 150.0F), Color.Black, 2.5F);
            line1.Draw(graphics);

        }

        private Graphics CreateGraphics(int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            pictureBox.Image = bitmap;
            return Graphics.FromImage(bitmap);
        }

     
    }
}
