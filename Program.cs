using System;

namespace RectangularMatrixTranspose
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangularMatrixTranspose();
        }

        private static void RectangularMatrixTranspose()
        {
            Console.WriteLine("Please enter the number of rows and columns for the matrix:");

            var numberOfRows = int.Parse(Console.ReadLine());
            var numberOfColumns = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the rectangular matrix:");

            int[,] matrix = new int[numberOfRows, numberOfColumns];

            for(int i=0; i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The entered matrix is as follows:\n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] transposeOfMatrix = new int[numberOfColumns, numberOfRows];
            for (int i = 0; i < numberOfColumns; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    transposeOfMatrix[i, j] = matrix[j, i];
                }
            }

            Console.WriteLine("The transpose of the entered matrix is as follows:\n");

            for (int i = 0; i < transposeOfMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < transposeOfMatrix.GetLength(1); j++)
                {
                    Console.Write(transposeOfMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
