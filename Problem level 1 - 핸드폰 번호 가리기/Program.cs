using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_level_1___핸드폰_번호_가리기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*전화번호가 문자열 phone_number로 주어졌을 때, 전화번호의 뒷 4자리를 제외한 나머지 숫자를 전부* 으로 가린 문자열을 리턴하는 함수*/
            string phone_number;
            phone_number = Console.ReadLine();
            string answer = phone_number.Substring(phone_number.Length - 4);
            answer = answer.PadLeft(phone_number.Length, '*');
            Console.WriteLine(answer);
        }
    }
}
