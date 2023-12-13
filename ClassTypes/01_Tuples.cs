using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes
{
    internal class Tuples
    {
        internal static void tuplesMain(string[] args)
        {
            #region basic
            var author = new Tuple<string, string, int, int>("Nikos", "Bita", 55, 2008);
            //Console.WriteLine("Author {0} {1} is {2} yo and wrote a book in {3}", author.Item1, author.Item2, author.Item3, author.Item4);
            #endregion

            #region Tuple.Create
            var tupleWithCreate = Tuple.Create(1, 2, "3");
            #endregion

            #region nested Tuple
            //var nested = new 
            //    Tuple<int, Tuple<string, int,Tuple<int,int>>>(12,Tuple.Create("First",32,Tuple.Create(12,12)));
            //Console.WriteLine(nested);
            //Console.WriteLine(nested.Item1);
            //Console.WriteLine(nested.Item2);
            //Console.WriteLine(nested.Item2.Item1);
            //Console.WriteLine(nested.Item2.Item2);
            //Console.WriteLine(nested.Item2.Item3);
            #endregion

            #region Pass Tuple as a parameter
            var tuple = Tuple.Create(1, 2);

            //TupleMethod(tuple);
            #endregion

            #region Return tuple from a method
            var numSet = Tuple.Create(10, 2);
            var result = TupleReturn(numSet);
            Console.WriteLine(result);
            #endregion
        }

        public static void TupleMethod(Tuple<int, int> test)
        {
            Console.WriteLine(test.Item1);
            Console.WriteLine(test.Item2);
        }

        public static Tuple<bool, Tuple<int, int>> TupleReturn(Tuple<int, int> tuple)
        {
            bool control = false;
            if (tuple.Item1 > tuple.Item2)
                control =  true;

            var result = Tuple.Create(control,tuple);
            return result;
        }

    }
}
