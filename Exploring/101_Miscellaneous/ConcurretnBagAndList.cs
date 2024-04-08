using System.Collections.Concurrent;

namespace Exploring._101_Miscellaneous;

internal class ConcurretnBagAndList
{
    public static void bagToListMain()
    {
        Console.WriteLine("Check in ConcurrentBagAndList");
        Console.WriteLine("--------------------------------------------");

        #region List
        //List<string> list = new List<string>() { "1123"};

        //helperModel helperModel = new helperModel(list);

        //Model model = new Model(helperModel.List);
        //model._list.ForEach(l => { Console.WriteLine(l); });

        //helperModel.List.Clear();
        //helperModel.List.Add("Cleared");
        //Console.WriteLine();
        //Console.WriteLine("model list after clearance : ");
        //model._list.ForEach(l => { Console.WriteLine(l); });
        //Console.WriteLine("");
        #endregion
        #region Concurrentbag
        //Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        //Console.WriteLine("Concurrent Bag");
        //ConcurrentBag<string> bag = new ConcurrentBag<string>() { "581321" };

        //helperCbModel.Bag = bag;

        //CbModel cbModel = new CbModel(helperCbModel.Bag);
        //foreach (var item in cbModel._bag) { Console.WriteLine(item); }

        ////If, instead of using Clear method, we create a new ConcurrentBag object
        ////then we dont preserve the reference of the old object!!!!

        //helperCbModel.Bag = new ConcurrentBag<string>() ;
        //Console.WriteLine("Bag cleared? : ");
        //helperCbModel.Bag.Add("Bag cleared");

        //foreach (var item in cbModel._bag) { Console.WriteLine(item); }
        #endregion
        #region ConcurrentBag Remove all elements
        //ConcurrentBag<string> bag = new ConcurrentBag<string>();
        //bag.Add("11");
        //bag.Add("12");
        //bag.Add("23");

        //Console.WriteLine(bag.Count);
        //EmptyBag(ref bag);
        //Console.WriteLine(bag.Count);
        #endregion
        #region string.Join with concurrentBag

        string text = "start";

        ConcurrentBag<string> join = new ConcurrentBag<string>() { "1", "2" , " 3" };

        string result  = text + string.Join("!!",join);

        Console.WriteLine(result);



        #endregion


        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Check out ConcurrentBagAndList");
    }
    #region ConcurrentBag TryTake 
    public static ConcurrentBag<string> EmptyBag(ref ConcurrentBag<string> bag)
    {
        int count = bag.Count;
        bool control = true;
        while (control)
        {
            control = bag.TryTake(out string result);
            //In older versions of .net and also in .net framework 4.8
            //there is no 'Clear' method for Concurrentbag<T>.
            //Thus, an alternate way of emptying the ConcurrentBag object was needed
        }
        return bag;
    }
    #endregion
}
#region List
internal class Model
{
    internal List<string> _list;
    public Model(List<string> list)
    {
        _list = list;
    }
}
internal class helperModel
{
    private List<string> _list;

    public List<string> List { get { return _list; } set { _list = value; } }

    public helperModel(List<string> strings)
    {
        List = strings;
    }
}
#endregion

#region ConcurrentBag
internal class CbModel
{
    internal ConcurrentBag<string> _bag;
    public CbModel(ConcurrentBag<string> bag)
    {
        _bag = bag;
    }
}
internal class helperCbModel
{
    private static ConcurrentBag<string> _bag;

    public static ConcurrentBag<string> Bag { get { return _bag; } set { _bag = value; } }

    //public helperCbModel(ConcurrentBag<string> strings)
    //{
    //    Bag = strings;
    //}
}
#endregion







