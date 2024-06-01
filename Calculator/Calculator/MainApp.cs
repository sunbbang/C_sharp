using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }

    internal class MainApp
    {
        public static void Main()
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);

            double result2 = Calculator.Division(9, 2);
            Console.WriteLine(result2);

            result = Calculator.Multiplication(4, 4);
            Console.WriteLine(result);
        }
    }
}
