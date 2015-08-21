using System;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

class Program
{
    static void Main(string[] args)
    {
        // string[,] matrix = 
        // {
        //     {"ha",  "fifi", "ho", "hi"},     // ha
        //     {"fo",  "ha",   "hi", "xx"},     //      ha
        //     {"xxx", "ho",   "ha", "xx"}      //           ha
        // };

        string[,] matrix = 
        {
            {"ha",  "fifi", "ho", "xx"},        // "xx"
            {"fo",  "ha",   "hi", "xx"},        // "xx"
            {"st",  "ho",   "ga", "xx"},        // "xx"
            {"ch",  "ho",   "ti", "xx"},        // "xx"
            {"xxx", "ho",   "ma", "xx"},        // "xx"
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int maxCounter = 0;
        string word="";
        string str="";

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int i = row;
                int j = col;
                int counter = 1;
                
                // Diagonally
                while ((i < rows - 1 && j < cols - 1) && matrix[i,j] == matrix[i+1,j+1])
                {
                    counter++;
                    i++;
                    j++;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    word = "diagonally";
                    str = matrix[i, j];
                }


                i = row;
                j = col;
                counter = 1;

                // Horizontally
                while (j < cols - 1 && matrix[i, j] == matrix[i, j + 1])
                {
                    counter++;
                    j++;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    word = "horizontally";
                    str = matrix[i, j];
                }


                i = row;
                j = col;
                counter = 1;

                // Vertically
                while (i < rows - 1 && matrix[i, j] == matrix[i+1,j])
                {
                    counter++;
                    i++;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    word = "vertically";
                    str = matrix[i, j];
                }
            }
        }

        Console.WriteLine("{0} times \"{1}\" {2}", maxCounter,str,word);
    }
}
