using System;
using System.Collections;

namespace Hottable
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Data1", new HongsClass() { name = "홍지원1", intCount = 1 });
            hashtable.Add("Data2", new HongsClass() { name = "홍지원2", intCount = 2 });
            if (hashtable.ContainsKey("Data1").Equals(true))
            {
                HongsClass temp = hashtable["Data1"] as HongsClass;
                Console.WriteLine(temp.name);
            }

            foreach (string NowKey in hashtable.Keys)
            {
                HongsClass temp = hashtable[NowKey] as HongsClass;
                Console.WriteLine(temp.name);
            }
        }
    }
}
