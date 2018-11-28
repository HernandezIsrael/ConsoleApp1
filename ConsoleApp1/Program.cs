using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] N;
            float[,] M;
            float[,] Z;

            int nRows;
            int nCols;
            int mRows;
            int mCols;

            Console.WriteLine("Multiplicación de matrices N*M");

            Console.Write("Número de filas de N: ");
            int.TryParse(Console.ReadLine(), out nRows);

            Console.Write("Número de columnas de N: ");
            int.TryParse(Console.ReadLine(), out nCols);

            Console.Write("\nNúmero de filas de M: ");
            int.TryParse(Console.ReadLine(), out mRows);

            Console.Write("Número de columnas de M: ");
            int.TryParse(Console.ReadLine(), out mCols);

            if (nCols != mRows)
            {
                Console.WriteLine("Estas matrices no se pueden multiplicar. Por favor, intenta de nuevo...");
                return;
            }

            N = new float[nRows, nCols];
            M = new float[mRows, mCols];
            Z = new float[nRows, mCols];

            Console.WriteLine("\nEsta es tu matriz N ahora:\n");
            PrintMatrix(N, nRows, nCols, true);

            Console.WriteLine("\nEsta es tu matriz M ahora:\n");
            PrintMatrix(M, mRows, mCols, true);

            Console.WriteLine("\nPara la matriz N...");
            FillMatrix(N, nRows, nCols);

            Console.WriteLine("\nPara la matriz M...");
            FillMatrix(M, mRows, mCols);

            Console.WriteLine("\nEsta es tu matriz N ahora:\n");
            PrintMatrix(N, nRows, nCols, false);

            Console.WriteLine("\nEsta es tu matriz M ahora:\n");
            PrintMatrix(M, mRows, mCols, false);

            Console.WriteLine("\nEl resultado de la multiplicación es: \n");
            multiplyMatrix(N, M, Z, nRows, mCols, nCols);
            PrintMatrix(Z, nRows, mCols, false);

            Console.WriteLine("\nPresione un tecla para terminar...");
            Console.ReadKey();
        }

        static void PrintMatrix(float[,] a, int rows, int cols, bool showIndex)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (showIndex == true)
                    {
                        Console.Write(string.Format("[ {0} , {1} ] ", i, j));
                    }
                    else
                    {
                        Console.Write(string.Format("[ {0} ] ", a[i, j]));
                    }
                }
                Console.WriteLine();
            }
        }

        static void FillMatrix(float[,] a, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("Dame el valor de [ {0} , {1} ]: ", i, j));
                    float.TryParse(Console.ReadLine(), out a[i, j]);
                }
                Console.WriteLine();
            } 
        }

        static void multiplyMatrix(float[,] A, float[,] B, float[,] C, int rows, int cols, int commonValue)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; k < commonValue; k++)
                    {
                        C[i,j] += (A[i,k] * B[k,j]);
                    }
                }
            }
        }
    }
}
