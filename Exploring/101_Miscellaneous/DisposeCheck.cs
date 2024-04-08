using System.ComponentModel;

namespace Exploring._101_Miscellaneous
{
    internal class DisposeCheck
    {
        public static void DisposeCheckMain()
        {

            Console.WriteLine("!!");
            List<int> first = new List<int> { 1, 2, 3 };
            List<int> second = new List<int> { 3,4,5 };

            var test = first.Except(second).ToList();

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

            test = second.Except(first).ToList();

            test.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("!!");
            Console.WriteLine(nameof(Car));



        }
    }

    public class Car : IDisposable
    {
        public int ID { get; set; }

        private IntPtr _unmanagedResource;
        private Component _managedResource;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing) 
        { 
            if (disposing) 
            {
                if(_managedResource != null)
                    _managedResource.Dispose();
            }

            if(_unmanagedResource != IntPtr.Zero) 
            {
                _unmanagedResource = IntPtr.Zero;
            }
        }
        //Destructor
        ~Car() 
        {
            Dispose(false);
        }
    }



}
