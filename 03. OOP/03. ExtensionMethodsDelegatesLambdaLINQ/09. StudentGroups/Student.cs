namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public Student()
        {
        }

        public Student(string firstName, string lastname, string fN,
            string tel, string email, List<int> marks, int groupNumber)
        {
            this.Firstname = firstName;
            this.Lastname = lastname;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }
    }
}
