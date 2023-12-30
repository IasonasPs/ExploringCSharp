using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._101_Miscellaneous
{
    internal class Abstract_vs_Interface
    {
        public static void Abstract_vs_InterfaceMain()
        {
            Human RenéDescartes = new Human
            {
                Name = "Rene Descartes",
                NumberOfLegs = 2,
                Description = "Philosopher,Scientist"
            };
            RenéDescartes.Move();
            RenéDescartes.Thinking();
        }
    }

    public interface Animal
    {
        public string Name { get; set; }
        public abstract string Description { get; set; }
    }

    public abstract class Mammal : Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfLegs; //(Except aquatic mammals)
        public void Move()
        {
            Console.WriteLine("This mammal is moving!");
        }
    }

    public class Human : Mammal
    {
        public void Thinking()
        {
            Console.WriteLine("Cogito, ergo sum...\n...............");
            Console.WriteLine("I am {0}!", this.Name);
        }
    }




}
