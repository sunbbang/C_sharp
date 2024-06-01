namespace Switch
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("나라 (한국, 중국, 일본, 영국) : ");
            string national = Console.ReadLine();

            switch (national)
            {
                case "KOREA":
                    Console.WriteLine("서울");
                    break;

                case "CHINA":
                    Console.WriteLine("베이징");
                    break;

                case "JAPAN":
                    Console.WriteLine("도쿄");
                    break;

                case "ENGLAND":
                case "UNITED KINGDOM":
                    Console.WriteLine("런던");
                    break;
                case "UK":
                    goto case "UNITED KINGDOM";

                default:
                    Console.WriteLine("서울");
                    break;
            }
            
        }
    }
}
