namespace ConstReadOnlyExam
{
    class ConstExample
    {
        public const int number = 5;
        public ConstExample() { }
    }

    class ReadOnlyExample
    {
        public readonly int number = 5;

        public ReadOnlyExample()
        {
            number = 50;
        }

        public ReadOnlyExample(int pNum)
        {
            number = pNum;
        }
    }
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConstExample.number);

            const int num = 10;
            Console.WriteLine(num);

            //num = 20;

            ReadOnlyExample roExam01 = new ReadOnlyExample();
            Console.WriteLine(roExam01.number);

            ReadOnlyExample roExam02 = new ReadOnlyExample(200);
            Console.WriteLine(roExam02.number);

            //roExam01.number = 300;
        }
    }
}
