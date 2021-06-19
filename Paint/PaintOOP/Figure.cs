using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PaintOOP
{
    [DataContract]
    public abstract class Figure
    {
        [DataMember]
        public Point[] points;
        [DataMember]
        public Color color { get; set; }
        [DataMember]
        public float penWidth { get; set; }
        [DataMember]
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
