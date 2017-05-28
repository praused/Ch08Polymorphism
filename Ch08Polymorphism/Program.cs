using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example: EatFood() is implicitly hidden by derived classes."); //VS warns in Error List window
            Cow myCow = new Cow();
            Chicken myChicken = new Chicken();
            Console.WriteLine("myCow: " + myCow.EatFood()); //Returns derived implementation, "Cow Eating"
            Console.WriteLine("myChichen: " + myChicken.EatFood()); //Returns derived implementation, "Chicken Eating"
            Animal myAnimal = myCow;
            Console.WriteLine("myCow assigned to Animal variable: " + myAnimal.EatFood()); //Returns base implementation, "Animal Eating"
            myAnimal = myChicken;
            Console.WriteLine("myChicken assigned to Animal variable: " + myAnimal.EatFood()); //Returns base implementation, "Animal Eating"

            Console.WriteLine();
            Console.WriteLine("Example: Talk() is explicitly hidden using the new keyword."); //Same behavior as implicit hiding, but no warning           
            Console.WriteLine("myCow: " + myCow.Talk()); //Returns derived implementation, "Moo"
            Console.WriteLine("myChichen: " + myChicken.Talk()); //Returns derived implementation, "Cluck"
            myAnimal = myCow;
            Console.WriteLine("myCow assigned to Animal variable: " + myAnimal.Talk()); //Returns base implementation, "Hi"
            myAnimal = myChicken;
            Console.WriteLine("myChicken assigned to Animal variable: " + myAnimal.Talk()); //Returns base implementation, "Hi"

            Console.WriteLine();
            Console.WriteLine("Example: Virtual Run() is overridden."); //Now the derived implementation is always used           
            Console.WriteLine("myCow: " + myCow.Run()); //Returns derived implementation, "Cow running"
            Console.WriteLine("myChichen: " + myChicken.Run()); //Returns derived implementation, "Cicken running"
            myAnimal = myCow;
            Console.WriteLine("myCow assigned to Animal variable: " + myAnimal.Run()); //Returns derived implementation, "Cow running"
            myAnimal = myChicken;
            Console.WriteLine("myChicken assigned to Animal variable: " + myAnimal.Run()); //Returns derived implementation, "Cicken running"

            Console.WriteLine();
            Console.WriteLine("Example: Virtual Jump() is hidden with the new keyword."); //Same behavior as hiding a non-virtual methos           
            Console.WriteLine("myCow: " + myCow.Jump()); //Returns derived implementation, "Cow jumping"
            Console.WriteLine("myChichen: " + myChicken.Jump()); //Returns derived implementation, "Cicken jumping"
            myAnimal = myCow;
            Console.WriteLine("myCow assigned to Animal variable: " + myAnimal.Jump()); //Returns base implementation, "Animal jumping"
            myAnimal = myChicken;
            Console.WriteLine("myChicken assigned to Animal variable: " + myAnimal.Jump()); //Returns base implementation, "Animal jumping"

        }
    }
}
