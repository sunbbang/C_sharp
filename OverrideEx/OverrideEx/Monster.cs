using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx
{
    internal class Monster
    {
        public virtual void hit()
        {
            Console.WriteLine("Monster Hit;");
        }
    }
}
