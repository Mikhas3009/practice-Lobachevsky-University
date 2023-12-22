using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie_1_
{
    internal class Person_Student_Teacher:Student
    {
        public Teacher CurrentTeacher { get; set; }

        public Person_Student_Teacher(string fio, int age, Teacher teacher = null) : base(fio, age)
        {
            AssignToTeacher(teacher);
        }

        public void AssignToTeacher(Teacher teacher)
        {
            if (teacher == null) {
                return;
            }

            this.CurrentTeacher = teacher;
        }

        public static Person_Student_Teacher GetRandomStudent(Person_Student_Teacher[] students)
        {
            return students[rnd.Next(students.Length)];
        }

        public override Person Clone()
        {

            var result = new Person_Student_Teacher(this.Fio, this.Age);
            if (CurrentTeacher != null) {
                result.AssignToTeacher(CurrentTeacher.Clone() as Teacher);
            }
            return result;
        }

        public override string ToString()
        {
            string teacher = base.ToString();
            string result = teacher.Substring(0, teacher.Length - 1);

            result += $",\nCurrentTeacher:";
            if (this.CurrentTeacher != null)
            {
                result += $"{CurrentTeacher.Fio} ";
            }
            else
                result += "-";
            return result + '}';
        }
    }
}
