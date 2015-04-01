namespace FirstBeforeLast
{
    // Problem 3 
    // Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    // Use LINQ query operators.

    public class Student
    {
        public Student()
        {
        }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }



        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Age;
        }
    }
}
