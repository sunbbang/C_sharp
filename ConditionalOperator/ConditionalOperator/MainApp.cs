﻿namespace ConditionalOperator
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            
            string result = (a % 2) == 0 ? "짝수" : "홀수";

            Console.Write(result);
        }
    }
}
