using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._101_Miscellaneous
{
    internal class ParallelForeach
    {
        public static void parallelMain()
        {
            List<Action> list = new List<Action>();
            Dictionary<int, Predicate<int>> d = new Dictionary<int, Predicate<int>>();
            #region

            //for(int i = 0;i < 24;i++)
            //{
            //    d.Add(i, new Predicate<int>(
            //        (int x) =>
            //        {
            //            Thread.Sleep(1000);
            //            Console.WriteLine($"Check {x}");
            //            return true;
            //        })
            //        );
            //    #region List
            //    //list.Add(new Action(
            //    //    () =>
            //    //    {
            //    //        Thread.Sleep(1000);
            //    //        Console.WriteLine("Check");
            //    //    }));
            //    #endregion
            //}
            //#region
            ////foreach(var item in d)
            ////{
            ////    item.Value.Invoke(item.Key);
            ////}
            //#endregion

            //Parallel.ForEach(d,item => {
            //    item.Value.Invoke(item.Key);

            //});
            #endregion

            #region MyRegion
            //using(var mos = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity"))
            //{
            //    using(ManagementObjectCollection collection = mos.Get())
            //    {

            //        Parallel.ForEach(collection.Cast<ManagementBaseObject>()
            //            , d =>
            //            {
            //                try
            //                {
            //                    var t = d.Properties["VendorId"].Value;
            //                }
            //                catch(Exception e)
            //                {
            //                    Console.WriteLine("Check");
            //                }
            //            });

            //        Console.WriteLine("Parallel out");




            //        //IEnumerable<ManagementBaseObject> newCollection = collection as IEnumerable<ManagementBaseObject>;
            //        //Parallel.ForEach(collection as IEnumerable<ManagementBaseObject>,
            //        //    device => {
            //        //    var t = device.GetType();
            //        //    });

            //    }
            //} 
            #endregion

            var props = typeof(MyInterface).GetProperties();

            foreach (var prop in props)
            { Console.WriteLine(prop); }
        }

        public interface MyInterface
        {
            public int MyProperty0 { get; set; }
            public int MyProperty1 { get; set; }
            public int MyProperty2 { get; set; }
        }
    }
}