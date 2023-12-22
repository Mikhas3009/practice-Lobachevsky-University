using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie_1_
{
    public class Person
    {
        protected static Random rnd = new();

        private string fio="";
        public string Fio
        {
            get { return this.fio; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    value = "";
                fio = value;
            }
        }

        private int age;
        public int Age
        {
            get => age;
            private set
            {
                if (value < 0)
                    value = 0;
                age = value;
            }
        }

        public Person(string fio, int age)
        {
            this.Fio = fio;
            this.Age = age;
        }

        public virtual void Print() {
            Console.WriteLine(this.ToString());
        }

        public virtual Person Clone()
        {
            return new Person(this.Fio, this.Age);
        }

        public static Person GetRandomPerson(Person[] people)
        {
            return people[rnd.Next(people.Length)];
        }

        public override string ToString()
        {
            return "{fio:" + $"{this.fio},\nage: {Age}" +"}";
        }

        public override int GetHashCode()
        {
            return fio.GetHashCode() ^ age.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return obj != null && obj.GetType() == this.GetType()
                && obj.GetHashCode() == this.GetHashCode();
        }
    }
}
