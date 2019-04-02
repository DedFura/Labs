using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        private static void SumDiagon(int[,] matrix)
        {
            int[] diag = new int[2 * matrix.GetLength(0) - 1];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int s = 0;
                for (int j = 0; j < i + 1; j++)
                {
                    int i1 = matrix.GetLength(0) - 1 - i + j;

                    s += matrix[i1, j];
                }
                diag[i] = s;               
            }
            for (int c = 0; c < matrix.GetLength(0) - 1; c++)
            {
                Console.WriteLine("Номер диагонали = {0}, Сумма элементов = {1}", c + 1, diag[c]);
            }        
            
        }
        private static int [,] Matrix(int N)
        {
            
            int[,] matrix = new int[N, N];
            
            Random rnd = new Random();
            Console.WriteLine("Матрица");
            for (int i = 0; i < N; i++)
            {
                for (int t = 0; t < N; t++)
                {
                    matrix[i, t] = rnd.Next(0, 10);
                    Console.Write(matrix[i, t] + " ");
                }
                Console.WriteLine();
            }
            return (matrix);
        }
        static void Main(string[] args)
        {
            const int N = 6;                     
            SumDiagon(Matrix(N));
            
            Console.ReadKey();
        }
    }
}

