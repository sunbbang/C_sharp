﻿using System;
using static System.Console;

namespace Hello
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)  
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            } 
            else if(args.Length == 2)
            {   
                Console.WriteLine("Hello, {0} {1}!", args[0], args[1]);
                return;
            }
           
            WriteLine("Hello, {0}!", args[0]);
        }   
    }
}
