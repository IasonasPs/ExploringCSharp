namespace Exploring._101_Miscellaneous
{
    public class Test
    {
        public static void testMain()
        {
            WordReverse("This is a text");

        }

        public static string WordReverse(string word)
        {
            var array = word.Split(' ');

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return null;
        }


    }
}
