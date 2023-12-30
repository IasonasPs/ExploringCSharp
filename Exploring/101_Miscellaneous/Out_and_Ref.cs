using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._101_Miscellaneous
{
    internal class Out_and_Ref
    {
        public static void Square(int x , out int y)
        {
            y = x * x;
        }

        public static void Square2(int x ,ref int y) 
        {
            y += x * x;
        }

        public static int Square3(int x,out int y)
        {
            int square = x * x;
            y = square;
            return square;
        }

        public static int Square4(int x, ref int y)
        {
            int square = x *x;
            y += square;
            return square;
        }

    }
}
