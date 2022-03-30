using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_4번___짝수와홀수
{
    class Solution
    {
        public string solution(int num)
        {
            return num % 2 == 0 ? "Even" : "Odd";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            Solution s = new Solution();
            string answer = s.solution(num);
            Console.WriteLine(answer);
        }
    }
}
