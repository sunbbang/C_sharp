using System.Security.Cryptography;

namespace Record
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            RTransaction tr1 = new RTransaction
            {
                From="Alice", To="Bob", Amount =100
            };

            RTransaction tr2 = new RTransaction
            {
                From = "Alice",
                To = "Charlie",
                Amount = 100
            };
            
            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
        }
    }
}
