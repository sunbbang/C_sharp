namespace RequiredProperty
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo() { Name = "정빈", Birthday = new DateTime(1970, 4, 1) };
            //birth.Birthday = new DateTime(1000, 10, 1);
            
            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}", birth.Age);
        }
    }
}
