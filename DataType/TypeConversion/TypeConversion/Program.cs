using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        // 데이터형(Datatype)의 바구니 크기나 부호가 다른 경우 형변환(TypeCasting)한다.
        static void Main(string[] args)
        {
        // 1. 바구니 크기가 다른 경우
            int big = 0x0FFFFFFF;
            short casting = (short)big;
            // 큰 바구니를 작은 바구니에 옮길 경우 명시해주어야한다.

            Console.WriteLine(casting);

            short small = 100;
            int conversion = small;
            // 분실이 안되므로 명시하지 않는다.

            Console.WriteLine(conversion);


        // 2. 바구니 크기는 같지만 부호가 다른 경우
            // byte(1바이트 0~255), sbyte(1바이트 -128~127)

            // 오버플로우(Overflow)
            byte zero = 255;
            sbyte min = (sbyte)zero;
                // 0xFF = 0b11111111 = -1

            Console.WriteLine(min);

            // 언더플로우(Underflow)
            sbyte minu = -128;
            byte up = (byte)minu;

            Console.WriteLine(up);



        // 3. 소수
            // 소수는 정확하기 표현하기 힘들어서 인접한 숫자로 변환된다.

            float six = 3.1414f;
            double fifteen = six;

            Console.WriteLine(fifteen);

            double fif = 3.15923456;
            float tsix = (float)fif;

            Console.WriteLine(tsix);

        }
    }
}
