namespace GSMTest
{
    using System;
    using System.Text;

    public class Call
    {
        private DateTime date;
        private string dilledPhoneNumber;
        private int durationOfCall;

        public Call()
        {

        }

        public Call(DateTime newDate, string newDilledPhoneNumber, int newDurationOfCall)
        {
            this.Date = newDate;
            this.DilledPhoneNumber = newDilledPhoneNumber;
            this.DurationOfCall = newDurationOfCall;
        }

        public DateTime Date 
        {
            get
            {
                if(this.date.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public string DilledPhoneNumber
        {
            get
            {
                return this.dilledPhoneNumber;
            }
            set
            {
                
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid phone number (08XYYYYYYY; X = 7,8 or 9; Y = digit)");
                }

                if (value.Length != 10 || value[0] != '0' || value[1] != '8' || (value[2] != '7' && value[2] != '8' && value[2] != '9'))
                {
                    throw new ArgumentException("Invalid phone number (08XYYYYYYY; X = 7,8 or 9; Y = digit)");
                }

                for (int i = 3; i < 10; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        throw new ArgumentException("Invalid phone number (08XYYYYYYY; X = 7,8 or 9; Y = digit)");
                    }
                }
                this.dilledPhoneNumber = value;
            }
        }

        public int DurationOfCall
        {
            get
            {
                return this.durationOfCall;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Invalid duration of call");
                }
                this.durationOfCall = value;
            }
        }
    }
}
