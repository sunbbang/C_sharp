using System.Security.Cryptography.X509Certificates;

namespace Yield
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
