// Write a program to check if in a given expression the brackets are put correctly.

using System;
class Program
{
    static bool CheckBrackets(string input)
    {
        int leftBrackets = 0;
        int rightBrackets = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if(input[i] == '(')
            {
                leftBrackets++;
            }
            else if (input[i] == ')')
            {
                rightBrackets++;
            }
        }

        return leftBrackets == rightBrackets;
    }
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string expression = Console.ReadLine();

        bool isCorrect = CheckBrackets(expression);
        Console.WriteLine(isCorrect ? "Brackets are put correctly" : "Brackets are not put correctly");
    }
}