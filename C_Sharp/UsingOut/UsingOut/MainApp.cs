﻿namespace UsingOut
{
    internal class MainApp
    {

        static void Divide(int a, int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }

        static void Main(string[] args)
        { 
            int a = 20;
            int b = 3;
            
            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }
    }
} 