namespace Throw
{
    internal class MainApp
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 큼");
        }

        static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i < 14; i += 2)
                {
                    DoSomething(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("빠이널리");
            }

            Console.WriteLine("떼쓰트");
        }
    }
}
