namespace _2.DefiningClassesPart2
{
    using System;

    public class VersionAtribute : Attribute
    {
        private string version;

        public VersionAtribute(string version)
        {
            this.Version = version;
        }

        public string Version 
        { 
            get
            {
                return this.version;
            }
            set
            {
                int countDigit = 0;
                bool isDot = false;
                foreach (var digit in value)
                {
                    if(char.IsDigit(digit))
                    {
                        countDigit++;
                    }

                    if(digit == '.')
                    {
                        isDot = true;
                    }
                }

                if(countDigit == value.Length - 1 && isDot && value[0] != '.' && value[value.Length - 1] != '.')
                {
                    this.version = value;
                }
                else
                {
                    throw new ArgumentException("Enter version in forma major.minor (2.11)");
                }
            }
        }
    }
}
