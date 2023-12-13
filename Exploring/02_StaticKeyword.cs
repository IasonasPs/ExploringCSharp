using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploring
{
    public class StaticKeyword
    {
        public static void SkMain(string[] args)
        {
            Brick brick0 = new Brick(1);
            Brick brick1 = new Brick(1);
            Brick brick2 = new Brick(1);
            Brick brick3 = new Brick(1);

            Console.WriteLine("{0} instances of the Brick class have been created.", Brick.Counter);
        }
    }

    internal class Brick
    {
        private static int _Counter = 0;  // Use of private static keyword for a variable operating as a Counter

        public static int Counter
        { get { return _Counter; } }
        public int Weight { get; set; }
        public Brick(int weight)
        {
            Weight = weight;
            _Counter++;
        }
    }
}
