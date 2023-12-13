using ClassTypes._01_User_defined_conversion_operators;
using System.Management;

namespace ClassTypes
{
    internal class Program
    {
        delegate void Del();
        public static void Main(string[] args)
        {

#if DEBUG
            args = new string[] { "12", "13", "14" };
#else
            args = new string[] { "16", "17", "18" };
#endif

            //args.ToList().ForEach(x => Console.WriteLine(x));

            //Tuples.tuplesMain(args);

            //DiscardVariable.discardsMain(args);

            Convertor.ConvertorMain(args);

            Console.ReadKey();
        }
    }
    #region X and Y
    //class X
    //{
    //    protected virtual void F()
    //    {
    //        Console.WriteLine("X.F");

    //    }
    //    protected virtual void F2()
    //    {
    //        Console.WriteLine("X.F2");
    //    }
    //}
    //class Y : X
    //{
    //    protected sealed override void F()
    //    {
    //        Console.WriteLine("Y.F");
    //    }

    //    protected virtual void F2()
    //    {
    //        Console.WriteLine("X.F2");
    //    }

    //} 
    #endregion













}