using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._10
{
    class Program
    {
        static private int[,] Matrix(int N)
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
        static private int[] GetMatches( int [,] Matrix)
        {
            int a = 0;
            bool flag = false;
            int[] valueArray = new int[Matrix.Length];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int k = 0; k < Matrix.GetLength(0); k++)
                {
                    valueArray[a] = Matrix[i, k];
                    Console.Write(valueArray[a]);
                    a++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < valueArray.Length; i++)
            {
                flag = true;
                for (int k = 0; k < valueArray.Length; k++)
                {


                    if ((valueArray[i] == valueArray[k]) && i != k)
                    {
                        flag = false;


                    }

                }
                if (flag)
                {
                    Console.Write(valueArray[i] + "");
                }
            }


            return (valueArray);
            
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            GetMatches(Matrix(N));
            Console.ReadKey();
           
        }
    }
}
