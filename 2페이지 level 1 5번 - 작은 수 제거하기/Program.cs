using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_5번___작은_수_제거하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 1 };
            int v = arr.Min();
            int[] answer = arr.Where(x => x != v).ToArray();

            if(answer.Count() == 0)
            {
                answer = new int[] { -1 };
            }
            for(int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
