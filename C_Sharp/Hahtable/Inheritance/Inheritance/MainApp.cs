using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();
            Derived b = new Derived("b");
            b.BaseMethod();
            b.DervidMethod();
        }
    }
}
