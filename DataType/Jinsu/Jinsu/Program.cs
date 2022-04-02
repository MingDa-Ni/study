using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinsu
{
    class Program
    {
        // 10진수 : 0 ~ 9
        // 2진수 : 0 ~ 1
        // 16진수 : 0 ~ 15 → (0 ~ 9)와 (A ~ F)

        // 0b00 0b01 → 2진수(binary digit, 약자 b)
        // bx00 0x01 → 16진수(hexadecimal digit, 약자 x)
        // 2진수↔16진수 : 숫자 4개씩 모아서 변환하자
        static void Main(string[] args)
        {
            int hex = 0x100;
            Console.WriteLine("Hello Hexadecimal! {0}", hex);

            int bin = 0b10001111;
            Console.WriteLine("Hello Binary! {0}", bin);
        }
    }
}
