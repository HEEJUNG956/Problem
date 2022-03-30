using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_level_1___x만큼_간격이_있는_n개의_숫자
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 정수 x와 자연수 n을 입력 받아, x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트를 리턴해야 합니다. 
            // n개의숫자 분기확인용
            String[] s;
            s = Console.ReadLine().Split(' ');

            int x = Int32.Parse(s[0]);
            int n = Int32.Parse(s[1]);


            long[] answer = new long[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(answer[i] = x);
                }
                else
                {
                    Console.WriteLine(answer[i] = x + answer[i - 1]);
                }
            }
        }

    }
}
