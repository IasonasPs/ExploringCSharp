namespace Console_.NetGenericHost
{
    internal class MyService : IMyService
    {
        private DateTime creationTime { get; } = DateTime.Now;

        //private int  Id  = new Random().Next(0,1000);
        private Guid  Id  = Guid.NewGuid();


        public void Run()
        {
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            //Console.WriteLine(""+creationTime.TimeOfDay + "   NanoSeconds :" + creationTime.Nanosecond);
            Console.WriteLine(Id);
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
        }
    }
}
