namespace StringFormatBasic
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2,30}";

            Console.WriteLine(fmt, "PUblisher", "Author", "Title");
            Console.WriteLine("012345678901234567890123456789");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            Console.WriteLine(fmt, "Hanbit", "Sanghyun", "This is C#");
            Console.WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}
