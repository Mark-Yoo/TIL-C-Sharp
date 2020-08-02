/* CLR(Common Language Runtime) 프로그램이 실행되는 환경 */

using System;
using static System.Console;

// 다른 namespace에서 서로의 namespace가 가진 class를 참조하기 위한 공간에 이름을 할당하는 것
namespace BrainCSharp
{
    class HelloWorld
    {
        /* 프로그램이 시작되는 곳
        static은 한정자라고 불리우며 이들은 메소드나 변수 등을 수식한다.
        static을 사용하면 코드가 실행되는 시점이 아닌, 구동되는 시점에서 메모리를 할당된다.
        static 이후에 오는 void는 이 함수가 반환하는 값의 타입을 명시해주는 것이며 Main() 메소드는
        프로그램을 실행할 때에 들어오는 인자들을 전달받으므로 꼭 존재해야 하며 중요한 역할을 한다. (진입점 역할도 한다)
        */
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : HelloWorld <이름>");
                return;
            }

            WriteLine("Hello, {0}", args[0]);
        }
    }
}
