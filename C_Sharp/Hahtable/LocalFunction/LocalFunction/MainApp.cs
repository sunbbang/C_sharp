namespace LocalFunction
{
    internal class MainApp
    {

        static string toLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // A ~ Z의 ASCII 값 : 65 ~ 90
                    return arr[i];
                else // a ~ z의 ASCII 값 : 97 ~ 122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(toLowerString("Hello!"));
            Console.WriteLine(toLowerString("Good Morning."));
            Console.WriteLine(toLowerString("I am Iron Man."));

     
        }
    }
}
