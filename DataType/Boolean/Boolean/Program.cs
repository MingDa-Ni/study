using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    // 불리언(1byte) : 참과 거짓으로 나뉘는 논리값 (단순 조건 상황) → 죽음 판정, 지상 유닛 혹은 공중 유닛
    // 1bit보다 1byte 연산이 빠르기 때문에 1byte 설정이다.
    class Program
    {
        // 중단점(break point) : 특정 지점에서 프로그램 실행을 멈추는 것 → 빨간점부터 프로그램이 중단
        // 소스코드를 한 줄씩 실행 : F10(노란색 화살표)
        // 진단도구 : Ctrl + Alt + F2 (디버깅 오류시 CPU 사용을 통해 의도치 않은 무한 루프 확인 가능 
        static void Main(string[] args)
        {
            bool life;

            life = true;
            life = false;
            Console.WriteLine("Hello Life! {0}", life);

            // 글자(2byte)
            char a = 'a';
            Console.WriteLine("{0}, apple", a);

            // 문자열 (캐릭터의 집합)
            string str = "Hello World";
            Console.WriteLine("{0}, My Life!", str);

        }
    }
}
