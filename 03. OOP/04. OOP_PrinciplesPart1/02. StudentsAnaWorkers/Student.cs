namespace _02.StudentsAnaWorkers
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " - " + Grade;
        }
    }
}
