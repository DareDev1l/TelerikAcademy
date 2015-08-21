using System;
class Program
{
    class Matrix
    {
        private int[,] matrix;
        public Matrix(int sizeX, int sizeY)
        {
            this.matrix = new int[sizeX,sizeY];
        }
        public double this[int x, int y]
        {
            get 
            { 
                return matrix[x, y]; 
            }
            set 
            { 
                matrix[x, y] = value; 
            }
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix sumMatrix = new Matrix(m1.GetLength(0), m2.GetLength(1));
            for (int i = 0; i < m1.; i++)
            {
                
            }
        }
    }
    static void Main(string[] args)
    {
    }
}