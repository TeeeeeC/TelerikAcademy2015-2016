namespace GSMTest
{
    using System;
    using System.Text.RegularExpressions;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dilledPhoneNumber;
        private int durationOfCall;

        public Call()
        {

        }

        public Call(DateTime newDate, DateTime newTime, string newDilledPhoneNumber, int newDurationOfCall)
        {
            this.Date = newDate;
            this.Time = newTime;
            this.DilledPhoneNumber = newDilledPhoneNumber;
            this.DurationOfCall = newDurationOfCall;
        }

        public DateTime Date 
        {
            get
            {
                return this.date;
            }
            set
            {
                if(DateTime.TryParse("dd.MM.YYYY", out value))
                {
                    throw new ArgumentException("Invalid date (dd.MM.YYYY)");
                }
                this.date = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                if (DateTime.TryParse("hh:mm:ss", out value))
                {
                    throw new ArgumentException("Invalid time (hh:mm:ss)");
                }
                this.time = value;
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
                Regex reg = new Regex(@"\A(08)[789]([0-9]{7})");
                if (reg.IsMatch(value))
                {
                    throw new ArgumentNullException("Invalid phone number");
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
