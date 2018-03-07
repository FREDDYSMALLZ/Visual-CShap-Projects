using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Polymorphism
{
    public class Animal
    {
        public virtual void Eat()
        {

        }
    }
    class Lion : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The Lion eats only Flesh.");
        }
         public void Attack()
        {
            Console.WriteLine("The Lion can attack you any time.");
        }
    }
    class Giraffe : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The Girraffe has a long neck.");
        }
        public void browse()
        {
            Console.WriteLine("Girraffes are animals that browse tall trees.");
        }
    }
    class UseAnimals
    {
        public static void Feed(Animal [] theZoo)
        {
            for (int i = 0; i < theZoo.Length; i++)
            {
                theZoo[i].Eat();

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            Giraffe giraffe = new Giraffe();
            Animal[] two = { lion, giraffe };
            giraffe.Eat();
            lion.Attack();


            Console.ReadLine();
        }
    }
}
