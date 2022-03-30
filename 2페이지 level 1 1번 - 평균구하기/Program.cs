using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_1번___평균구하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())};
            Console.WriteLine(arr.Average());
        }
    }
}
