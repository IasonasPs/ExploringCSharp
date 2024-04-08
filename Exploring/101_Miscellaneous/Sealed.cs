namespace Exploring._101_Miscellaneous
{

    public class firstClass
    {
        public  int Number { get; set; }
        public virtual void myMethod()
        {
            Console.WriteLine("Method from firstClass");
        }
    }
    internal sealed class Sealed : firstClass
    {
        public override void myMethod()
        {
            Console.WriteLine(" Method from SealedClass ");
        }

        public void BaseMyMethod()
        {
            base.myMethod();
        }
        public static void MainMethod()
        {
            Sealed sealedClass = new Sealed();

            sealedClass.Number = 1;
            sealedClass.myMethod();
            sealedClass.BaseMyMethod();
        }
    }

    //Sealed class are able to inherit from other class but it is forbiden to be inherited!






}
