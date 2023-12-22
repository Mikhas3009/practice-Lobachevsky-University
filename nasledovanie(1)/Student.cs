using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie_1_
{
    public  class Student : Person
    {
        public Student(string fio, int age) : base(fio, age)
        {
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
