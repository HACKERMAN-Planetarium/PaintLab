using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP
{
    public abstract class Figure
    {
        public Point[] points;
        public Color color { get; set; }
        public float penWidth { get; set; }
        public Boolean isFeel { get; set; }

        protected Pen pen;

        public Figure() { }

        public Figure(Color color, float penWidth)
        {
            this.color = color;
            this.penWidth = penWidth;

            pen = new Pen(color, penWidth);
        }


        public void SetPen()
        {
            pen = new Pen(color, penWidth);
        }

        public abstract Figure Clone();

        public abstract void Draw(Graphics graphics);
    }
}
