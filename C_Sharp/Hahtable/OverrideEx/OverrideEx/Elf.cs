using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx
{
    internal class Elf : Monster
    {
        public new void hit()
        {
            Console.WriteLine("Elf Hit");
        }
    }
}
