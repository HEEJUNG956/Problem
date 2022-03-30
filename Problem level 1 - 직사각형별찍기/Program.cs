using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_level_1___직사각형별찍기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 별(*) 문자를 이용해 가로의 길이가 n, 세로의 길이가 m인 직사각형 형태를 출력해보세요.
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
