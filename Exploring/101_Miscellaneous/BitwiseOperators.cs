namespace Exploring._101_Miscellaneous
{
    internal static class BitWiseOperators
    {
        internal static void BitWiseOperatorsMain()
        {
            int a, b, c, d;

            //exponent_3210   
            //outcome__8421   
            a = 6;   //0110
            b = 15;  //1111 


            //Console.WriteLine(c = a & b); //0010
            c = a & b;
            Console.WriteLine("{2} & {3} = {0} , which in base 2 is {1}", c, Convert.ToString(c, 2), a, b);
            Console.WriteLine(". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ");
            //Console.WriteLine(c = a | b);
            c = a | b;
            Console.WriteLine("{2} | {3} = {0} , which in base 2 is {1}", c, Convert.ToString(c, 2), a, b);
            Console.WriteLine(". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ");
            //Console.WriteLine(c = a ^ b);
            c = a ^ b;
            Console.WriteLine("{2} ^ {3} = {0} , which in base 2 is {1}", c, Convert.ToString(c, 2), a, b);
            Console.WriteLine(". . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ");

            Console.WriteLine(Convert.ToString(3,2));
            Console.WriteLine(Convert.ToString(-3,2));
        }
    }
}