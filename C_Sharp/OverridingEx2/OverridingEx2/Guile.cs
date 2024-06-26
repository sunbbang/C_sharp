using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEx2
{
    internal class Guile : Fighter
    {
        public override void energy()
        {
            Console.WriteLine("┎");
        }
        public override void kick()
        {
            Console.WriteLine("회오리 차기!");
        }
    }
}
