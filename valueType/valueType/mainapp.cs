namespace valueType
{
    internal class mainapp
    {
        public static void TestValueType(int param, int param2)
        {
            param += 10;
            Console.WriteLine("in TestValueType : a ==> {0}{1}", param, param2);

        }
        static void Main(string[] args)
        {
            int value = 20;
            int value2 = 40;
            Console.WriteLine(value);

            TestValueType(value, value2);
            Console.WriteLine(value);
        }
    }
}
