using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._100_DataStructures
{
    internal class HashSet
    {
        public static void HashSetMain()
        {

            #region
            HashSet<int> set = new HashSet<int>(2);
            set.Add(11);
            set.Add(21);
            var enumerator = set.GetEnumerator();

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            #endregion
        }

        public static bool Check(string str)
        {
            str = str.ToLower();
            str = str.Trim();

            HashSet<char> set = new HashSet<char>();

            var charArray = str.ToCharArray();

            foreach (char item in charArray)
            {
                _ = set.Contains(item) ? set.Remove(item) : set.Add(item);
            }
            Console.WriteLine(new String((char[])set.ToArray()));


            if (set.Count > 1)
                return false;
            else
                return true;

        }
    }
}







//# doesnt accept duplicate entries