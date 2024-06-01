using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx
{
    internal class Orc : Monster
    {
        public override void hit()
        {
            Console.WriteLine("Orc Hit");
        }
    }
}
