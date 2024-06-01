using System.Threading.Tasks.Dataflow;

namespace PositionalPattern
{
    internal class MainAPp
    {
        private static double Get(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2,
                ("학생", _) => 0.1,
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) => 0.05,
                _ => 0,
            };
        }
        static void Main(string[] args)
        {
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var sam = (job: "일반", age: 15);
            var dave = (job: "일반", age: 21);

            Console.WriteLine($"alice : {Get(alice)}");
            Console.WriteLine($"bob : {Get(bob)}");
            Console.WriteLine($"sam : {Get(sam)}");
            Console.WriteLine($"dave : {Get(dave)}");
        }
    }
}
