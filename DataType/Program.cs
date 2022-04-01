using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    // Program = Data + Logic
    // 지정된 데이터에 따라 로직을 실행하는 것
    // 한 줄 선택 : Shift + Home(뒤에서 앞으로) , Shift + End(앞에서 뒤로)
    class Program
    {
        // 데이터형 1.정수 2.소수 3.문자열 4.불리언(논리형) 값
        // 변수 : 데이터를 감싸고 있는 상자
        static void Main(string[] args)
        {
            // 01. 정수
            // 활용 ↑: byte(1바이트 *0~255), short(2바이트 -3만~3만), int(integer의 약자, 4바이트 -21억~21억), long(8바이트) 
            // 활용 ↓: sbyte(side의 약자, -128~127) , ushort(2바이트 0~6만) , uint(4바이트 0~43억) , ulong(8바이트) << 잘 활용 안됨
            int hp;

            hp = 700;
            short level = 30; // 일부러 넉넉하게 한 단계 위로 담는다.
            long id; // 고치기 까다롭기 떄문에 처음부터 큰 상자에 담는다.

            // 범위의 문제 ( 체력이 이미 0인데 공격을 당할 경우)
            byte attack = 0;
            attack--; // 255로 Underflow.

            Console.WriteLine("Hello Attack! {0}", attack); // 변수 출력시 사용
        }
    }
}
