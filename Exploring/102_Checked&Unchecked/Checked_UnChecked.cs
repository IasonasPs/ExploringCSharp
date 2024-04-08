namespace Exploring._102_Checked_Unchecked
{
    public class Checked_UnChecked
    {
        public static void cUMain()
        {
            int val = int.MaxValue;
            Console.WriteLine(val + 2);

            Console.WriteLine("P0");

            //The checked keyword is used to explicitly check overflow and conversion of integral type values at compile time.
            try
            {
                checked
                {
                    int newVal = int.MaxValue;
                    Console.WriteLine(newVal + 2);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception caught : {0}",e.Message);
            }

            Console.WriteLine("P1");

            unchecked
            {
                int newestVal = int.MaxValue;
                Console.WriteLine(newestVal + 2);
            }

            Console.WriteLine("P2");


        }

    }
}
