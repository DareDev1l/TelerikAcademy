using System;

// Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
// The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
// The card faces should start from 2 to A.
// Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a
// switch-case statement.

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch(i)
                    {
                        case 2:
                            Console.Write("{0} of ", 2);
                            break;
                        case 3:
                            Console.Write("{0} of ", 3);
                            break;
                        case 4:
                            Console.Write("{0} of ", 4);
                            break;
                        case 5:
                            Console.Write("{0} of ", 5);
                            break;
                        case 6:
                            Console.Write("{0} of ", 6);
                            break;
                        case 7:
                            Console.Write("{0} of ", 7);
                            break;
                        case 8:
                            Console.Write("{0} of ", 8);
                            break;
                        case 9:
                            Console.Write("{0} of ", 9);
                            break;
                        case 10:
                            Console.Write("{0} of ", 10);
                            break;
                        case 11:
                            Console.Write("{0} of ", "J");
                            break;
                        case 12:
                            Console.Write("{0} of ", "Q");
                            break;
                        case 13:
                            Console.Write("{0} of ", "K");
                            break;
                        case 14:
                            Console.Write("{0} of ", "A");
                            break;
                    }

                    if(j % 4 == 0)
                    {
                        Console.Write("{0}", "spades, ");
                    }
                    else if (j % 4 == 1)
                    {
                        Console.Write("{0}", "clubs, ");
                    }
                    else if (j % 4 == 2)
                    {
                        Console.Write("{0}", "gearts, ");
                    }
                    if (j % 4 == 3)
                    {
                        Console.Write("{0}", "diamonds, ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
