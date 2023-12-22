using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie_3_
{
    public class Triangle : Figure
    {
        private int a, b, c;
        public Triangle(int a, int b, int c, string type = "Треугольник") : base(type)
        {
            SetABC(a, b, c);
        }

        public void SetABC(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void GetABC(out int a, out int b, out int c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }

        public override double Area2 => Area();

        protected override double Area()
        {
            double p = (a + b + c) / 2;
            return (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"A = {a}, B = {b}, C = {c}");
        }
    }
}
