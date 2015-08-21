namespace Phone
{
    using System;
    using System.Collections.Generic;
    public class GSMTest
    {
        public static List<GSM> GeneratePhones()
        {
            // Array with all instaces of GSM
            List<GSM> phones = new List<GSM>();

            // Add phones to the array
            phones.Add(new GSM
                ("Lumia 900", "Nokia", 700, "Pesho Vasilev", new Battery(BatteryType.NiCd), new Display(3.5f, 2.4f, 320000000)));

            phones.Add(new GSM
                ("Xperia", "Sony",250, "Ivan Georgiev", new Battery(BatteryType.LiIon), new Display(3.1f, 2.1f, 1000000)));

            phones.Add(new GSM
                ("Galaxy S6", "Samsung", 1050, "Simona Nikolaeva", new Battery(BatteryType.NiMH), new Display(4.1f, 3.1f, 64000000)));

            phones.Add(GSM.IPhone);

            return phones;
        }
            
        
    }
}
