using System.Net.Cache;

namespace Tuple
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            var b = (Name: "박정섭", Age: 16);
            Console.WriteLine($"{b.Name}, {b.Age}");

            var (name, age) = b;
            Console.WriteLine($"{name}, {age}");

            var (name2, age2) = ("황정빈", 16);
            Console.WriteLine($"{name2}, {age2}");

            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");
        }
    }
}
