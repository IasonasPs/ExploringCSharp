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

        public void Move(); 
        //All animals are capable of movement,but each animal category or subcategory moves
        //in its own unique way.In this context,the Move() method signature serves as a contract to which every class
        //inheriting from the Animal interface is bound.
    }


    //All mammals are animals (but not every animal is a mammal)
    public abstract class Mammal : Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfLegs; //(Except aquatic mammals)   :)
        public void Move()
        {
            Console.WriteLine("This mammal is moving!");
        }
    }

    //All humans are mammals and by extension animals
    public class Human : Mammal
    {
        public void Thinking()
        {
            Console.WriteLine("Cogito, ergo sum...\n...............");
            Console.WriteLine("I am {0}!", this.Name);
        }
    }
}
