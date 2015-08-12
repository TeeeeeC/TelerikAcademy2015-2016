namespace GSMTest
{
    using System;

    public class Battery 
    {
        private const int InitialNumber = 0;
        private const string InitialString = null;

        private int hoursIdle;
        private int hoursTalk;
        private BatteryType model;

        public Battery(BatteryType newModel, int hoursIdle, int hoursTalk)
        {
            this.Model = newModel;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
        }

        public Battery()
        {
            this.Model = BatteryType.None;
            this.HoursTalk = InitialNumber;
            this.HoursIdle = InitialNumber;
        }
        public BatteryType Model
        { 
            get
            {
                return this.model;
            }
            set
            {
                if (value != BatteryType.LiIon && value != BatteryType.NiCd && value != BatteryType.NiMH)
                {
                    throw new ArgumentException("Invalid name of model!");
                }
                this.model = value;
            }
        } 

        public int HoursIdle 
        { 
            get
            {
                return this.hoursIdle;
            }
            set
            {

                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid number!");
                }
                this.hoursIdle = value;
                
            }
        }

        public int HoursTalk 
        { 
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid number!");
                }
                this.hoursTalk = value;
            }
        }
    }
}
