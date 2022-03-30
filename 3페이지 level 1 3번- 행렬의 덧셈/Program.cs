using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_level_1___행렬의_덧셈
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*행렬의 덧셈은 행과 열의 크기가 같은 두 행렬의 같은 행, 같은 열의 값을 서로 더한 결과가 됩니다. 
            2개의 행렬 arr1과 arr2를 입력받아, 행렬 덧셈의 결과를 반환하는 함수, solution을 완성해주세요.*/
            string[] x;
            x = Console.ReadLine().Split(' ');

            int a = Int32.Parse(x[0]);
            int b = Int32.Parse(x[1]);


            string[] y;
            y = Console.ReadLine().Split(' ');

            int c = Int32.Parse(y[0]);
            int d = Int32.Parse(y[1]);


            int[,] arr1 = { { a }, { b } };
            int[,] arr2 = { { c }, { d } };

            int[,] answer = (int[,])arr1.Clone();
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.WriteLine(answer[i, j] += arr2[i, j]);
                }
            }
        
        }
    }
}
