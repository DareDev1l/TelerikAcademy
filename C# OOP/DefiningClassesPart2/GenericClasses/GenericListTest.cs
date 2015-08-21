namespace GenericClasses
{
    using System;
    class GenericListTest
    {
        public static void Main()
        {
            GenericList<int> list = new GenericList<int>(4);

            Console.WriteLine("Add , auto-grow and ToString() test");
            Console.WriteLine();
            // Testing add method and auto-grow
            for (int i = 1; i <= 20; i++)
            {
                list.Add(i);
            }
            Console.WriteLine(list.ToString());
            AddSeparator();

            // Add 100 on position 5
            Console.WriteLine("Test insert at position (insert 100 on position 5)");
            Console.WriteLine();
            list.Add(100, 5);
            Console.WriteLine(list.ToString());
            AddSeparator();

            // Test min and max
            Console.WriteLine("Min --> {0}", list.Min());
            Console.WriteLine("Max --> {0}", list.Max());
            AddSeparator();

            // Indexer test
            Console.WriteLine("Indexer test:");
            Console.WriteLine("list[5] --> {0}", list[5]);
            AddSeparator();

        }
        public static void AddSeparator()
        {
            Console.WriteLine(new string('-', Console.WindowWidth));
        }
    }
}
