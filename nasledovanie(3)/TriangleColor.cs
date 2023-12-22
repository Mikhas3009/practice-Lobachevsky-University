using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie_3_
{
    public class TriangleColor : Triangle
    {
        private Color color;
        public Color Color
        {
            get { return this.color; }
            set
            {
                this.color = value;
            }
        }

        public TriangleColor(int a, int b, int c, Color color, string name = "Треугольник с цветом") : base(a, b, c, name)
        {
            this.Color = color;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(Color.ToString());
        }
    }
}
