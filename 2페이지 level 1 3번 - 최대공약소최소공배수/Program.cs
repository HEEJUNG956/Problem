using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_3번___최대공약소최소공배수
{
    class Solution
    {
        public int[] solutioin(int n, int m)
        {
            int abc = gcd(n, m);
            int[] answer = new int[] {abc, n * m / abc};
            return answer;
        }

        int gcd(int a, int b)
        {
            return (a % b == 0 ? b : (gcd(b, a % b)));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Solution solution = new Solution();
            int[] answer = solution.solutioin(a, b);
            

        }
    }
}
