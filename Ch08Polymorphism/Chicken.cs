using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08Polymorphism
{
    public class Chicken : Animal
    {
        public string EatFood()
        {
            return "Chicken eating";
        }

        new public string Talk()
        {
            return "Cluck (Chicken Talking)";
        }

        public override string Run()
        {
            string myString = base.Run(); //base keyword can access even overridden methods
            return "Chicken running (also is an " + myString + ")";
        }

        new public string Jump()
        {
            return "Chicken jumping";
        }
    }
}
