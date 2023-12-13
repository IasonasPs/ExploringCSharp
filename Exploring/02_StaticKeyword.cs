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

     class Brick
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

    #region https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators
    public readonly struct Digit
    {
        private readonly byte digit;

        public byte _digit { get { return digit; } }
        public Digit(byte digit)
        {
            if (digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "Digit cannot be greater than nine.");
            }
            this.digit = digit;
        }

        public static implicit operator byte(Digit d) => d.digit;
        public static explicit operator Digit(byte b) => new Digit(b);

        public override string ToString() => $"{digit}";
    }

    public static class UserDefinedConversions
    {
        public static void udcMain()
        {
            Digit d = new Digit(7);
            Console.WriteLine(d._digit);

            byte number = d;
            Console.WriteLine(number);  // output: 7

            Digit digit = (Digit)number;
            Console.WriteLine(digit._digit);
        }
    } 
    #endregion

}
