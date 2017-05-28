using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08Polymorphism
{
    public class Animal
    {
        public string EatFood()
        {
            return "Animal eating";
        }

        public string Talk()
        {
            return "Hi (Animal Talking)";
        }

        public virtual string Run()
        {
            return "Animal running";
        }

        public virtual string Jump()
        {
            return "Animal jumping";
        }
    }
}
