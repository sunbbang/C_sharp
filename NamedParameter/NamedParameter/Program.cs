namespace NamedParameter
{
    internal class Program
    {

        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine("Name:{0}, Phone:{1}", name, phone);
        }

        static void Main(string[] args)
        {
            PrintProfile(phone : "010-6488-0980", name: "박정섭");
        }
    }
}
