using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exploring._101_Miscellaneous
{
    internal class Out_and_Ref
    {


        //y parameter needs to be declared before declaration of the method
        public static void Square(int x , out int y)
        {
            y = x * x;
        }

        //y parameter needs to be declared and also initialized before the declaration of the method
        public static void Square2(int x ,ref int y) 
        {
            y += x * x;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
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
