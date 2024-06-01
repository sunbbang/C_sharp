namespace Interface
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            ClimaterMonitor monitor = new ClimaterMonitor(new FileLogger("MyLog.txt"));
            //ClimaterMonitor monitor = new ClimaterMonitor(new ConsoleLogger());

            monitor.start();
        }
    }
}
