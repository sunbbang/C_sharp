namespace Return
{
    internal class MainApp
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n -1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name.Equals(""))
            {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }

            Console.WriteLine($"Name : {name}, Phone : {phone}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"10번 째 피보나치 수 : {Fibonacci(10)}");

            PrintProfile("", "123");
            PrintProfile("박정섭", "010-6488-0980");
        }
    }
}
