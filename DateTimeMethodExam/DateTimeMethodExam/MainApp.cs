namespace DateTimeMethodExam
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            TimeSpan duration = new TimeSpan(36, 0, 0, 0);
            Console.WriteLine("AddTimeSpan : {0}", now.Add(duration));
            Console.WriteLine("AddDays : {0}", now.AddDays(36));
            Console.WriteLine("==============================");
            double[] hours = { 0.8333, 0.16667, 0.5, 2, 31 };
            foreach(double hour in hours)
            {
                Console.WriteLine("{0} + {1} hour = {2}", now, hour, now.AddHours(hour));
            }
            Console.WriteLine("============================");
            double[] minutes = { .1667, 1, 60 * 24 };
            foreach (double minute in minutes)
                Console.WriteLine("{0} + {1} = {2}", now, minute, now.AddMinutes(minute));

            Console.WriteLine("=============================");
            DateTime UtcNow = DateTime.UtcNow;
            DateTime currNow = DateTime.Now;
            DateTime copyNow = UtcNow;

            bool result = UtcNow.Equals(currNow);
            Console.WriteLine("{0}", result);
            result = UtcNow.Equals(copyNow);
            Console.WriteLine("{0}", result);


        }
    }
}
