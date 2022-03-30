using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_2번___콜라츠추측
{
    class Solution
    {
        /*1937년 Collatz란 사람에 의해 제기된 이 추측은, 주어진 수가 1이 될때까지 다음 작업을 반복하면, 모든 수를 1로 만들 수 있다는 추측입니다.
        1-1. 입력된 수가 짝수라면 2로 나눕니다.
        1-2. 입력된 수가 홀수라면 3을 곱하고 1을 더합니다.
        2. 결과로 나온 수에 같은 작업을 1이 될 때까지 반복합니다.*/
        public int solution(int num)
        {
            long answer = num;

            for (int i = 0; i < 500; i++)
            {
                if (answer == 1)
                {
                    return i;
                }
                answer = answer % 2 == 0 ? answer / 2 : answer * 3 + 1;
            }
            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            Solution solution = new Solution();
            long answer = (long)solution.solution(num);
            Console.WriteLine(answer);
        }
    }
}
