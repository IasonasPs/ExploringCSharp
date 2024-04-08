using Exploring._101_Miscellaneous;

namespace Exploring
{
    internal class Program
    {
        delegate void Del();
        public static void Main(string[] args)
        {
            #region Main method's args parameter :
#if DEBUG
            args = new string[] { "12", "13", "14" };
#else
            args = new string[] { "16", "17", "18" };
#endif

            //args.ToList().ForEach(x => Console.WriteLine(x));
            #endregion

            //DataStructuresMainClass.StructuresMain(args);

            MiscellaneousMain.MiscellaneousMainMethod(args);

            Console.ReadKey();
        }

        private static void DevideByZero()
        {
            Console.WriteLine("====");
            var input = Console.ReadLine();

            int intInput = int.Parse(input);

            try
            {
                var x0 = 4 / intInput;
            }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);
            }

            var x = 4 / intInput;
        }
    }














}