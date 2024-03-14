using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._101_Miscellaneous
{
    internal class ParallelForeach
    {
        public static void parallelMain()
        {
            List<Action> list = new List<Action>();

            Dictionary<int, Predicate<int>> d = new Dictionary<int,Predicate<int>>();



            for(int i = 0;i < 24;i++)
            {
                d.Add(i, new Predicate<int>(
                    (int x) =>
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"Check {x}");
                        return true;
                    })
                    );
                //list.Add(new Action(
                //    () =>
                //    {
                //        Thread.Sleep(1000);
                //        Console.WriteLine("Check");
                //    }));
            }
            #region
            //foreach(var item in d)
            //{
            //    item.Value.Invoke(item.Key);
            //}
            #endregion

            Parallel.ForEach(d,item => {

                item.Value.Invoke(item.Key);
            
            });


        }
    }
}
