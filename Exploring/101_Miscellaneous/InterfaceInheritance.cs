namespace Exploring._101_Miscellaneous
{
    internal class InterfaceInheritance
    {
        public static void InterfaceInheritanceMain()
        {
            A alpha =  new Alpha();

            Console.WriteLine(alpha.age);
            Console.WriteLine(alpha.Name);

            B alpha2 =  new Alpha2();

            Console.WriteLine(alpha2.age);
            Console.WriteLine(alpha2.Name);

            A alpha2a =  new Alpha2();

            Console.WriteLine(alpha2.age);
            Console.WriteLine(alpha2.Name);
        }

    }

    public interface A
    {
        string Name { get; }
        int age { get; }
    }

    public interface B : A
    {
        string A.Name => "i am A";

    }

    public class Alpha : A
    {
        public string Name { get; set; }
        public int age { get; set; }
    }

    public class Alpha2 : B
    {
        public int age { get; set; }
    }


}
