using System;

namespace School
{
    public class Student
    {
        private const int MIN_VALUE_UNIQUE_NUMBER = 10000;
        private const int MAX_VALUE_UNIQUE_NUMBER = 99999;

        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length == 0) 
                {
                    throw new ArgumentOutOfRangeException("The name cannot be empty");
                }
                this.name = value;
            }
        }

        public int UniqueNumber 
        { 
            get
            {
                return this.uniqueNumber;
            }
            private set
            {
                if (value < MIN_VALUE_UNIQUE_NUMBER || MAX_VALUE_UNIQUE_NUMBER < value) 
                {
                    throw new ArgumentOutOfRangeException(string.Format("The unique number must be between {0} and {1}", MIN_VALUE_UNIQUE_NUMBER, MAX_VALUE_UNIQUE_NUMBER));
                }

                this.uniqueNumber = value;
            }
        }
    }
}
