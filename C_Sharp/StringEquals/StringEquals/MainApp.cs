namespace StringEquals
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string text1 = "안녕?";
            object text2 = "안녕?";

            if (text1 == text2)
            {
                Console.WriteLine("== True");
            } 
            else
            {
                Console.WriteLine("== False");
            }

            if (text1.Equals(text2))
            {
                Console.WriteLine("Equals True");
            }
            else
            {
                Console.WriteLine("Equals False");
            }
        }
    }
}
