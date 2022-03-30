using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_level_1___하샤드_수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*양의 정수 x가 하샤드 수이려면 x의 자릿수의 합으로 x가 나누어져야 합니다.*/
            int x = Convert.ToInt32(Console.ReadLine());
            int tmp = x;
            int value = 0;
            bool answer = false;
            while(tmp > 0)
            {
                value += tmp % 10;
                tmp = tmp / 10;
            }

            if(x % value == 0)
            {
                answer = true;
            }

            Console.WriteLine(answer);
        }
    }
}
