// See https://aka.ms/new-console-template for more information
using nasledovanie_1_;
using System.Linq;

Console.WriteLine("Hello, World!");
Person_Student_Teacher[] people = new Person_Student_Teacher[]
       {
            new Person_Student_Teacher("John Smith", 25),
            new Person_Student_Teacher("Emily Johnson", 30),
            new Person_Student_Teacher("Michael Williams", 28),
            new Person_Student_Teacher("Olivia Jones", 22),
            new Person_Student_Teacher("William Brown", 35),
            new Person_Student_Teacher("Sophia Davis", 29),
            new Person_Student_Teacher("James Miller", 27),
            new Person_Student_Teacher("Ava Wilson", 31),
            new Person_Student_Teacher("Alexander Taylor", 26),
            new Person_Student_Teacher("Charlotte Martinez", 24)
 };

Console.WriteLine($"Рандомный person:{ Person.GetRandomPerson(people)}");

Teacher[] teachers = new Teacher[]
        {
            new Teacher("Robert Johnson", 35),
            new Teacher("Emily Davis", 40),
            new Teacher("Michael Clark", 28),
            new Teacher("Olivia Thomas", 32),
            new Teacher("William Wilson", 37),
            new Teacher("Sophia Miller", 29),
            new Teacher("James Garcia", 42),
            new Teacher("Ava Martinez", 31),
            new Teacher("Alexander Taylor", 36),
            new Teacher("Charlotte Lopez", 34)
        };
Console.WriteLine($"Рандомный учитель:{Teacher.GetRandomPerson(teachers)}");
teachers[0].AddStudents(people);
foreach (var student in people) {
    student.AssignToTeacher(teachers[0]);
}
Console.WriteLine($"учитель:{teachers[0]}");
Console.WriteLine($"Рандомный Учиеник:{Person.GetRandomPerson(people)}");