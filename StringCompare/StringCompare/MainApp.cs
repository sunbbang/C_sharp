namespace StringCompare
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            char c1 = 'a';
            char c2 = 'A';
            char c3 = 'a';
            char c4 = 'b';
            Console.WriteLine(c1.CompareTo(c2));
            //Console.WriteLine(strig.Compare(c1, c2));
            Console.WriteLine(c1.CompareTo(c3));
            Console.WriteLine(c1.CompareTo(c4));

            string str1 = "abc";
            string str2 = "abc";
            string str3 = "abd";
            string str4 = "aab";
            Console.WriteLine("compareTo : {0}", str1.CompareTo(str2));
            Console.WriteLine("compareTo : {0}", str1.CompareTo(str3));
        }
    }
}
