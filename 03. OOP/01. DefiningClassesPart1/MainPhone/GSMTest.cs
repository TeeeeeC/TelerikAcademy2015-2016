namespace GSMTest
{
    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static void Main()
        {
            var gsms = new List<GSM>();
            gsms.Add(new GSM(new Display(10, 20, 5, 20), new Battery(BatteryType.NiCd, 43, 34), "Lumia", "Nokia", 100, "Pesho"));
            gsms.Add(new GSM(new Display(1, 240, 55, 200), new Battery(BatteryType.LiIon, 3, 34), "Galaxy", "Samsung", 20, "Gosho"));
            gsms.Add(new GSM(new Display(106, 260, 5, 2000), new Battery(BatteryType.NiMH, 43, 4), "Tipo", "Sony", 400, "Vankata"));
            gsms.Add(new GSM(new Display(140, 204, 54, 20040), new Battery(BatteryType.NiCd, 463, 349), "Lumia", "Nokia", 1050, "Toshko"));

            for (int i = 0; i < gsms.Count; i++)
            {
                Console.WriteLine("GSM {0}:", i + 1);
                gsms[i].PrintInfoGSM();
                Console.WriteLine(new string('-', 20));
            }
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
