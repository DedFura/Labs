using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8
{
    class Program
    {
        static private int [,] Matrix(int N)
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

        static private void GetSum(int[,] matrix)
        {
            int[] kor = new int[2] { 0, 0 };
            int max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[i, 0];
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[i, k] < min)
                    {
                        min = matrix[i, k];
                        
                    }
                    if ((k == matrix.GetLength(0)-1)&&(max < min))
                    {
                        max = min;                      
                        kor[0] = i+1;
                        kor[1] = k + 1;
                    }
                        
                }
                Console.WriteLine("Минимальное число в строке {0} = {1}", i+1, min);
            }
            Console.WriteLine("Максимальное число среди минимальных = {0}, находится в строке {1}, столбец {2} ", max, kor[0], kor[1]);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int N = Convert.ToInt32(Console.ReadLine());           
            GetSum(Matrix(N));
            Console.ReadKey();


        }
    }
}
