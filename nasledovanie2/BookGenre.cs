using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie2
{
    public class BookGenre : Book
    {
        private string genre;
        public string Genre
        {
            get {return this.genre; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) {
                    value = "";
                }
                this.genre = value;
            }
        }
        public BookGenre(string name, string author, double price, string genre) : base(name, author, price)
        {
            this.Genre = genre;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Жанр: {this.Genre}");
        }
    }
}
