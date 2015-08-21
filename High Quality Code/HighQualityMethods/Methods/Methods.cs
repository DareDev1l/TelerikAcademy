namespace Methods
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            Console.WriteLine("--------- Calc Utils Tests ------------");
            TestUtils.CalcUtilsTests();

            Console.WriteLine("--------- Print Utils Tests -----------");
            TestUtils.PrintUtilsTests();

            Console.WriteLine("--------- Line Tests ------------------");
            TestUtils.LineTests();

            Console.WriteLine("--------- Student Tests ---------------");
            TestUtils.StudentsTests();
        }
    }
}
