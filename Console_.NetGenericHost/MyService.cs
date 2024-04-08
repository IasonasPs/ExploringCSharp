namespace Console_.NetGenericHost
{
    internal class MyService : IMyService
    {
        private DateTime creationTime { get; } = DateTime.Now;

        public void Run()
        {
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine(""+creationTime.TimeOfDay + "   NanoSeconds :" + creationTime.Nanosecond);
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
        }
    }
}
