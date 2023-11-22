using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_2task_
{
    internal class Pizza
    {

        public Pizza(int time, string name) {
            this.timeCooking = time;
            this.name = name;
        }

        private readonly int timeCooking;
        private string name;

        public int getTimeCook() {
            return Convert.ToInt32(this.timeCooking);
        }
    }
}
