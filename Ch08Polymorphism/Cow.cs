using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08Polymorphism
{
    public class Cow : Animal
    {
        public string EatFood()
        {
            return "Cow eating";
        }

        new public string Talk()
        {
            return "Moo (Cow Talking)";
        }

        public override string Run()
        {
            string myString = base.Run(); //base keyword can access even overridden methods
            return "Cow running (also is an " + myString + ")";
        }

        new public string Jump()
        {
            return "Cow jumping";
        }
    }
}
