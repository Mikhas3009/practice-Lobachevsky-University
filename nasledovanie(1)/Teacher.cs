using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledovanie_1_
{
    public class Teacher : Person
    {
        public List<Person> Students { get; private set; }
        public Teacher(string fio, int age, List<Person> students = null)
            : base(fio, age)
        {
            AddStudents(students);
        }


        public void AddStudents(IEnumerable<Person> students)
        {
            if (students == null) {
                return;
            }
            if (Students == null) {
                Students = new List<Person>();
            }
            foreach (var student in students) {
                Students.Add(student);
            }
                
        }

        public static Teacher GetRandomTeacher(Teacher[] teachers)
        {
            return teachers[rnd.Next(teachers.Length)];
        }

        public override Person Clone()
        {
            List<Person> students = new();
            if (Students != null) {
                foreach (var student in Students) {
                    students.Add(student.Clone() as Person);
                }
            }
                

            return new Teacher( this.Fio, this.Age, students);
        }

        public override string ToString()
        {
            string teacher = base.ToString();
            string result = teacher.Substring(0, teacher.Length - 1);

            result += $",\nStudents:";
            if (this.Students != null)
            {
                result += '[';
                foreach (var student in Students) {
                    result += $"{student.Fio}, ";
                }
                result += ']';
            }
            else
                result +="[]";
            return result+'}';
        }

        public override int GetHashCode()
        {
            var hash = base.GetHashCode();
            foreach (var student in Students) {
                hash^=student.GetHashCode();
            }
            return hash;
        }

        public override bool Equals(object? obj)
        {
            var result = base.Equals(obj);
            if (result)
            {
                Teacher t2 = obj as Teacher;
                var except = Students.Except(t2.Students);
                for (int i = 0; i < this.Students.Count; i++) {
                    if (!this.Students[i].Equals(t2.Students[i])) {
                        return false;
                    }  
                }
                result = except.Count() == 0;
            }

            return result;
        }
    }
}
