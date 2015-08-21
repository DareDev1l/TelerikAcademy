namespace Matrix
{
    using System;
    class MatrixTest
    {
        static void Main()
        {
            var matrix1 = new Matrix<int>(1,1);
            var matrix2 = new Matrix<int>(1, 1);

            matrix1[0, 0] = 4;
            matrix2[0, 0] = 5;

            var matrix3 = matrix1 + matrix2;
            var matrix4 = matrix2 - matrix1;

            Console.WriteLine(matrix3[0,0]);
            Console.WriteLine(matrix4[0,0]);
        }
    }
}
