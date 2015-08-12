namespace GSMCallHistoryTest
{
    using System;
    using System.Collections.Generic;

    using GSMTest;
    
    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM gsm = new GSM(new Display(10, 20, 5, 20), new Battery(BatteryType.NiCd, 43, 34), "Lumia", "Nokia", 100, "Pesho");
            var someCalls = new List<Call>();
            someCalls.Add(new Call(new DateTime(2015, 3, 13, 13, 24, 45), "0889666060", 100));
            someCalls.Add(new Call(new DateTime(2015, 3, 11, 13, 4, 45), "0899606060", 2000));
            someCalls.Add(new Call(new DateTime(2015, 3, 12, 13, 2, 4), "0899606060", 130));
            someCalls.Add(new Call(new DateTime(2015, 3, 3, 13, 24, 5), "0899606060", 400));
            foreach (var call in someCalls)
            {
                gsm.AddCall(call);   
            }

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("Date: {0}.{1}.{2} - {3}:{4}:{5}, Phone number: {6}, Duration: {7}s", call.Date.Day, call.Date.Month, call.Date.Year, 
                    call.Date.Hour, call.Date.Minute, call.Date.Second, call.DilledPhoneNumber, call.DurationOfCall);
            }

            decimal  resultTotalPrice = gsm.CalculateTotalPrice(gsm.CallHistory);
            Console.WriteLine("Total price of all calls: {0:F2}", resultTotalPrice);

            int longestCall = 0;
            int indexOfLongestCall = 0;
            for(int i = 0; i < gsm.CallHistory.Count; i++)
            {
                if(gsm.CallHistory[i].DurationOfCall > longestCall)
                {
                    longestCall = gsm.CallHistory[i].DurationOfCall;
                    indexOfLongestCall = i;
                }
            }

            gsm.DeleteCall(indexOfLongestCall);
            resultTotalPrice = gsm.CalculateTotalPrice(gsm.CallHistory);
            Console.WriteLine("Total price without longest call: {0:F2}", resultTotalPrice);
            gsm.ClearCallHistory();
        }
    }
}
