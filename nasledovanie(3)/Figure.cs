using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie_3_
{
    public abstract class Figure
    {

        public Figure(string name)
        {
            this.Name = name;
        }

        private string name;
        public string Name
        {
            get {return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) {
                    value = "";
                }
                this.name = value;
            }
        }

        public abstract double Area2 { get; }

        protected abstract double Area();

        public virtual void Print() {
            Console.WriteLine(Name);
        }
    }
}
