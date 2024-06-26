using System;

namespace Overflow
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.Write("숫자를 입력하세요 : ");
            uint a1 = UInt32.Parse(Console.ReadLine());

            if (a < a1)
            {
                Console.Write("숫자가 너무 큼");
                return;
            }
            else
            {
                Console.WriteLine(a1);
            }
            
            

            
        }
    }
}
