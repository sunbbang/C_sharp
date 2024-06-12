using System;
using System.Collections;
using System.Collections.Generic;



namespace Enumeralble
{
    internal class MyList : IEnumerable, IEnumerator
    {



        object IEnumerator.Current => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
