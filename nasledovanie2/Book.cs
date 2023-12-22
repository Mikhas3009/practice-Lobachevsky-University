using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie2
{
    public class Book
    {
        private string title;
        public string Name
        {
            get { return this.title; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) {
                    value = "";
                }
                title = value;
            }
        }

        private string author;
        public string Author
        {
            get { return this.author; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    value = "";
                }
                this.author = value;
            }
        }


        private double price;
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                    value = 0;
                this.price = value;
            }
        }

        public Book(string title, string author, double price)
        {
            this.Name = title;
            this.Author = author;
            this.Price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Название: {this.Name}\nАвтор: {this.Author}\nЦена: {this.Price}");
        }
    }
}
