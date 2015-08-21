using System;

// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// Assume that repeating the same subset several times is not a problem.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());

        bool foundSolutions = false;

        if (a == 0)
        {
            Console.WriteLine("{0}", a);
            foundSolutions = true;
        }
        if (b == 0)
        {
            Console.WriteLine("{0}", b);
            foundSolutions = true;
        }
        if (c == 0)
        {
            Console.WriteLine("{0}", c);
            foundSolutions = true;
        }
        if (d == 0)
        {
            Console.WriteLine("{0}", d);
            foundSolutions = true;
        }
        if (e == 0)
        {
            Console.WriteLine("{0}", e);
            foundSolutions = true;
        }


        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1}", a, b);
            foundSolutions = true;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1}", a, c);
            foundSolutions = true;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1}", a, d);
            foundSolutions = true;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1}", a, e);
            foundSolutions = true;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1}", b, c);
            foundSolutions = true;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1}", b, d);
            foundSolutions = true;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1}", b, e);
            foundSolutions = true;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1}", c, d);
            foundSolutions = true;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1}", c, e);
            foundSolutions = true;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1}", d, e);
            foundSolutions = true;
        }


        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, b, c);
            foundSolutions = true;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, b, d);
            foundSolutions = true;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, b, e);
            foundSolutions = true;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, c, d);
            foundSolutions = true;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, c, e);
            foundSolutions = true;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", a, d, e);
            foundSolutions = true;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", b, c, d);
            foundSolutions = true;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", b, c, e);
            foundSolutions = true;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", b, d, e);
            foundSolutions = true;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2}", c, d, e);
            foundSolutions = true;
        }



        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}", a, b, c, d);
            foundSolutions = true;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}", a, b, c, e);
            foundSolutions = true;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}", a, b, d, e);
            foundSolutions = true;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}", a, c, d, e);
            foundSolutions = true;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3}", b, c, d, e);
            foundSolutions = true;
        }


        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4}", a, b, c, d, e);
            foundSolutions = true;
        }

        if(!foundSolutions)
        {
            Console.WriteLine("no zero subset");
        }
       
    }
}