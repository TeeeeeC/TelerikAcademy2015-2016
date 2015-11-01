namespace GSMTest
{
    using System;
    using System.Collections.Generic;

    public class GSM 
    {
        private static string iPhone4S = "IPhone 4S";

        private const decimal InitialNumber = 0;
        private const string InitialString = null;
        private const decimal PricePerSecond = 0.37M / 60;

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Display display;
        private Battery battery;
        private List<Call> callHistory;

        public GSM()
        {
            this.Model = InitialString;
            this.Manufacturer = InitialString;
            this.Price = InitialNumber;
            this.Owner = InitialString;
        }

        public GSM(Display newDisplay, Battery newBattery, string modelOfPhone, string manufacturerOfPhone, decimal price, string owner) 
        {
            this.Model = modelOfPhone;
            this.Manufacturer = manufacturerOfPhone;
            this.Price = price;
            this.Owner = owner;
            this.display = newDisplay;
            this.battery = newBattery;
        }

        public static string IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value; 
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be null or empty!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer cannot be null or empty!");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Owner cannot be null or empty!");
                }
                this.owner = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public override string ToString()
        {
 	        return this.Model + "\n" + this.Manufacturer + "\n" + this.Price + "\n" +
                this.Owner + "\n" + this.display.Width + " " + this.display.Heigth + " " + this.display.NumberOfColors +
                "\n" + this.battery.Model + " " + this.battery.HoursIdle + " " + this.battery.HoursTalk;
        }

        public void PrintInfoGSM()
        {
            Console.WriteLine("Model of Phone: {0}", this.Model);
            Console.WriteLine("Manufacturer of Phone: {0}", this.Manufacturer);
            Console.WriteLine("Price of Phone: {0}", this.Price);
            Console.WriteLine("Owner of Phone: {0}", this.Owner);
            Console.WriteLine("Display characteristics: width = {0}, heigth = {1}, number of colors = {2}", this.display.Width, this.display.Heigth, this.display.NumberOfColors);
            Console.WriteLine("Battery characteristics: model -> {0}, hours idle -> {1}, hours talk -> {2}", this.battery.Model, this.battery.HoursIdle, this.battery.HoursTalk);
        }

        public List<Call> AddCall(Call call)
        {

            callHistory.Add(new Call(call.Date, call.Time, call.DilledPhoneNumber, call.DurationOfCall));

            return callHistory;
        }

        public List<Call> DeleteCall(List<Call> newCalls, int index)
        {
            newCalls.RemoveAt(index);
            return newCalls;
        }

        public List<Call> ClearCallHistory(List<Call> newCalls)
        {
            newCalls.Clear();
            return newCalls;
        }

        public decimal CalculateTotalPrice(List<Call> calls)
        {
            decimal result = 0;
            foreach (var call in calls)
            {
                result += call.DurationOfCall;
            }
            result *= PricePerSecond;

            return result;
        }
    }
}
