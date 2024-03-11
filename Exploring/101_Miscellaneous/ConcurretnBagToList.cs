using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._101_Miscellaneous
{
    internal class ConcurretnBagToList
    {
        public static void bagToListMain()
        {
            Console.WriteLine("Check");

            cbagProvider cbagProvider = new cbagProvider();

            cbagProvider.bag = new ConcurrentBag<string>();

            List<string> list = new List<string>() { "134","6575"};
            list.ForEach(i => cbagProvider.bag.Add(i));

            foreach (var item in cbagProvider.bag)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class cbagProvider
    {
        public ConcurrentBag<string> bag = new ConcurrentBag<string>()
        {
            "1",
            "2",
            "3"
        };
    }
}
