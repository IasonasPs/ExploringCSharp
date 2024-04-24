namespace Exploring._101_Miscellaneous
{
    public class Yield
    {
        public static void YieldMain()
        {
            withoutYield();
            Console.WriteLine("...........................................");
            withYield();
        }

        #region No Yield
        public static void withoutYield()
        {
            int[] a = new int[10];
            a = func(2, 10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public static int[] func(int start,int number)
        {
            int[] _number = new int[number];
            for (int i = 0; i < number; i++)
            {
                _number[i] = start + 2 * i;
            }

            return _number;
        }
        #endregion
        #region Yield
        public static void withYield()
        {
            foreach (var item in unusualFunc(2, 10))
            {
                Console.WriteLine("----->>" + item);
            }
        }

        public static IEnumerable<int> unusualFunc(int start,int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("<<<<--------------Inside 'yield' loop");
                yield return start + 2 * i;
            }
        }
        #endregion

    }
}





//Quote from MSDN

//"The yield keyword signals to the compiler that the method in which it appears is an iterator block. The compiler generates a class to implement the behavior that is expressed in the iterator block. In the iterator block, the yield keyword is used together with the return keyword to provide a value to the enumerator object. This is the value that is returned, for example, in each loop of a foreach statement. The yield keyword is also used with a break to signal the end of the iteration."













