using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_2번___콜라츠추측
{
    class Solution
    {
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
