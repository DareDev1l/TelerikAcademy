namespace PersonClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PersonClassTest
    {
        static void Main()
        {
            Person rado = new Person("Gosho", 16);
            Person radorado = new Person("GoshoGosho", null);

            Console.WriteLine(rado.ToString());
            Console.WriteLine(radorado.ToString());
        }
    }
}