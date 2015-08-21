using System;

// Write a program that fills and prints a matrix of size (n, n)

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write("\n");
        Console.WriteLine("a)");
        a(n);
        Console.Write("\n \n");
        Console.WriteLine("b)");
        b(n);
        Console.Write("\n \n");
        Console.WriteLine("c)");
        c(n);
        Console.Write("\n \n");
        Console.WriteLine("d)");
        d(n);
    }


    // This function prints on the console the figure a
    static void a(int n)
    {
        int[,] arr = new int[n, n];
        int counter = 1;

        // Filling the matrix
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                arr[row, col] = counter;
                counter++;
            }
        }

        // Printing the matrix on the console
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-2} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void b(int n)
    {
        int[,] arr = new int[n, n];
        int counter = 1;

        // Filling the matrix on even cols
        for (int col = 0; col < n; col += 2)
        {
            for (int row = 0; row < n; row++)
            {
                arr[row, col] = counter;
                counter++;
            }
            counter += n;
        }

        counter = n+1;
        // Filling the matrix on odd cols
        for (int col = 1; col < n; col += 2)
        {
            for (int row = n - 1; row >= 0; row--)
            {
                arr[row, col] = counter;
                counter++;
            }
            counter += n;
        }

        // Printing the matrix on the console
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-2} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void c(int n)
    {
        int[,] arr = new int[n, n];
        int counter = 1;
        int col = 0;

        // Filling the matrix from bottom left side
        for (int row = n-1; row >= 0; row--)
        {
            int i = row;
            while(i < n && col < n)
            {
                arr[i, col] = counter;
                counter++;
                col++;
                i++;
            }
            col = 0;
        }

        counter = n * n;
        col = n - 1;
        // Filling the matrix from top right side
        for (int row = 0; row < n-1; row++)
        {
            int i = row;
            while (i >= 0 && col >= 0)
            {
                arr[i, col] = counter;
                counter--;
                col--;
                i--;
            }
            col = n-1;
        }

        // Printing the matrix on the console
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-2} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void d(int n)
    {
        int rows = n;
        int cols = n;
        int leftEnd = 1;
        int upperEnd = 2;
        int regulator = 0;
        int curPosI = 1;
        int curPosJ = 1;
        int curNumber = 1;
        int i, j;

        // Set matrix (square with side root of n)
        int[,] matrix = new int[n + 1, n + 1];

        // Assign 0s
        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n; j++)
            {
                matrix[i, j] = 0;
            }
        }

        // Until reaching last number
        while (curNumber <= n * n)
        {
            // 1. Going right until end
            if (regulator % 4 == 0)
            {
                while (curPosJ <= rows)
                {
                    matrix[curPosI, curPosJ] = curNumber;
                    curNumber++;
                    curPosJ++;
                }
                rows--;
                curPosI++;
                curPosJ--;
                regulator++;
            }
            // 2. Goind down until end 
            else if (regulator % 4 == 1)
            {
                while (curPosI <= cols)
                {
                    matrix[curPosI, curPosJ] = curNumber;
                    curNumber++;
                    curPosI++;
                }
                cols--;
                curPosJ--;
                curPosI--;
                regulator++;
            }
            // 3. Goind left until end 
            else if (regulator % 4 == 2)
            {
                while (curPosJ >= leftEnd)
                {
                    matrix[curPosI, curPosJ] = curNumber;
                    curNumber++;
                    curPosJ--;
                }
                leftEnd++;
                curPosI--;
                curPosJ++;
                regulator++;
            }
            // 4. Goind up until end 
            else if (regulator % 4 == 3)
            {
                while (curPosI >= upperEnd)
                {
                    matrix[curPosI, curPosJ] = curNumber;
                    curNumber++;
                    curPosI--;
                }
                upperEnd++;
                curPosJ++;
                curPosI++;
                regulator++;
            }
        }

        // Print Matrix
        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n; j++)
            {
                Console.Write("{0,-3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }      
    }
}
