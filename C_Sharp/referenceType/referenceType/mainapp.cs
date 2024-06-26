namespace referenceType
{
    internal class mainapp
    {
        public static void TestRefType(int[] array)
        {
            array[0] = 1000;
        }
        public static void TestRefType(string name)
        {
            name = "TEST";
            Console.WriteLine("IN TestRefType : {0}", name);
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40 };
            Console.WriteLine(arr[0]);

            TestRefType(arr);
            Console.WriteLine(arr[0]);

            String name = "LUNA PARK";
            Console.WriteLine(name);
            TestRefType(name);
            Console.WriteLine(name);
        }
    }
}
