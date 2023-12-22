using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie2
{
    public sealed class BookGenrePubl : BookGenre
    {
        private string publisher;
        public string Publisher
        {
            get { return this.publisher; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) {
                    value = "";
                }
                this.publisher = value;
            }
        }
        public BookGenrePubl(string name, string author, double price, string genre, string publisher) : base(name, author, price, genre)
        {
            this.Publisher = publisher;
        }
    }
}
