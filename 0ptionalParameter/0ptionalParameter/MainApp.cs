namespace _0ptionalParameter
{
    internal class MainApp
    {

        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile("정섭");
            PrintProfile("정렬", "010-4665-2016");
            PrintProfile(name: "정빈");
            PrintProfile(name: "정주", phone: "112");

        }
    }
}
