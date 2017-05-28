namespace _01.StudentClass
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        public enum Specialties
        {
            Telecommunications,
            Electronics,
            Mechatronics,
            Mechanical_Engineering,
            Industrial_Technologies
        };

        public enum Universities
        {
            TU,
            SU,
            MGU
        };

        public enum Faculties
        {
            FCSE,
            FITT,
            FTK,
            FIM,
            FPA
        };

        public Student()
        {
        }

        public Student(string firstName, string middleName, string lastName, int sSN, string permanentAddress,
            string mobilePhone, string email, int course, Specialties specialy, Universities university, Faculties faculty)
        {
            this.FistName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = sSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialy;
            this.Universiy = university;
            this.Faculty = faculty;
        }

        public string FistName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }

        public Specialties Specialty { get; set; }
        public Universities Universiy { get; set; }
        public Faculties Faculty { get; set; }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
                return false;

            if (this.FistName != student.FistName || this.MiddleName != student.MiddleName
                || this.LastName != student.LastName || this.SSN != student.SSN
                || this.PermanentAddress != student.PermanentAddress || this.MobilePhone != student.MobilePhone
                || this.Email != student.Email || this.Course != student.Course)
                return false;

            if (this.Specialty != student.Specialty || this.Universiy != student.Universiy
                || this.Faculty != student.Faculty)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return FistName.GetHashCode() ^ Course.GetHashCode();
        }

        public override string ToString()
        {
            return this.FistName + " " + this.MiddleName + " " + this.LastName;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        public object Clone()
        {
            var newStudent = new Student();
            newStudent.FistName = this.FistName;
            newStudent.MiddleName = this.MiddleName;
            newStudent.LastName = this.LastName;
            newStudent.SSN = this.SSN;
            newStudent.PermanentAddress = this.PermanentAddress;
            newStudent.MobilePhone = this.MobilePhone;
            newStudent.Email = this.Email;
            newStudent.Course = this.Course;
            newStudent.Specialty = this.Specialty;
            newStudent.Universiy = this.Universiy;
            newStudent.Faculty = this.Faculty;

            return newStudent;
        }

        public int CompareTo(Student student)
        {
            string firstStudentName = student.FistName + " " + student.MiddleName + " " + student.LastName;
            string secondStudentName = this.FistName + " " + this.MiddleName + " " + this.LastName;

            int compareNames = firstStudentName.CompareTo(secondStudentName);

            if (compareNames == 0)
                return student.SSN.CompareTo(this.SSN);

            return compareNames;
        }
    }
}
