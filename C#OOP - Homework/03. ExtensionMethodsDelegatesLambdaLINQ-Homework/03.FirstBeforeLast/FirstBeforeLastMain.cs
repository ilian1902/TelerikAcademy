namespace FirstBeforeLast
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class FirstBeforeLastMain
    {
        //Problem 3, 4, 5 
        public static void Main()
        {
            
            Student[] students =
            {
                new Student("Pesho", "Ivanov", 18),
                new Student("Maria","Petkova",34),
                new Student("Ivan","Stoqnov",54),
                new Student("Sonq","Kolqnova",23),
                new Student("Polq","Pesheva",12),
                new Student("Miroslav","Balkanski",20),
                new Student("Ivan","Toshev",43),
                new Student("Gosho","Bratanov",33),
                new Student("Dragan","Kirov",18),
                new Student("Maria","Paraskeva",24),
            };
            // Problem 3
            var sortStudent = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
            Print(sortStudent);
            Console.WriteLine();
            var sortLinqOnly = from st in students where st.FirstName.CompareTo(st.LastName) < 0 select st;
            Print(sortLinqOnly);
            Console.WriteLine(new string('-', 20));

            //Problem 4 
            var sortStudentByAge = students.Where(st => st.Age >= 18 && st.Age <= 24);
            Print(sortStudentByAge);
            Console.WriteLine();
            var sortStudentLinqAge = from st in students where st.Age >= 18 && st.Age <= 24 select st;
            Print(sortStudentLinqAge);
            Console.WriteLine(new string('-', 20));
            //Problem 5
            var sortDescanding = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
            Print(sortDescanding);
            Console.WriteLine();
            var sortDescandingOther = from st in students orderby st.FirstName descending, st.LastName descending select st;
            Print(sortDescandingOther);

        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st);
            }
        }
    }
}
