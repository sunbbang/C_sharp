using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod
{
    internal class Derived : Base
    {
        public sealed override void SealMe()
        {

        }
    }
}
