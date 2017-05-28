namespace _09.StudentGroups.ExtensionMethods
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Methods
    {
        public static List<string> SelectInGroup2(this List<Student> list)
        {
            List<string> studentsInGroup2 = new List<string>();
            foreach (var student in list)
            {
                if(student.GroupNumber == 2)
                {
                    studentsInGroup2.Add(student.Firstname);
                }
            }

            return studentsInGroup2;
        }

        public static void SortByFirstName(this List<string> list)
        {
            list.Sort();
        }

        public static int FindGroupNumber(this List<Student> list, int groupNumber)
        {
            foreach (var student in list)
            {
                if (student.GroupNumber == 2)
                {
                    groupNumber = student.GroupNumber;
                    break;
                }
            }

            return groupNumber;
        }

        public static List<string> FindStudentsWithTwoMarks2(this List<Student> list)
        {
            List<string> studentsWithTwoMarks2 = new List<string>();
            foreach (var student in list)
            {
                int count = 0;
                foreach (var mark in student.Marks)
                {
                    if(mark == 2)
                    {
                        count++;
                    }
                }

                if(count == 2)
                {
                    studentsWithTwoMarks2.Add(student.Firstname + " " + student.Lastname);
                }
            }

            return studentsWithTwoMarks2;
        }

        public static List<string> GroupedByGroupName(this List<Student> list)
        {
            var result = new List<string>();
            var studentsInGroupLinq =
                from student in list
                group student by student.GroupNumber;

            foreach (var studentsOfGroup in studentsInGroupLinq)
            {
                result.Add(studentsOfGroup.Key.ToString());
                foreach (var group in studentsOfGroup)
                {
                    result.Add(group.Firstname + " " + group.Lastname + " - " + group.GroupNumber);
                }
            }

            return result;
        }
    }
}
