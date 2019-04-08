using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain
{
    public class Infrantry : Personnel
    {
        public static int numInfrantry;
        public Infrantry()
        {
            Name = "New infrantryman";
            numInfrantry++;
        }

        public Infrantry(string name) : base(name)
        {
            numInfrantry++;
        }

        protected override void Speak()
        {
            base.Speak();
            Console.WriteLine($"Infrantryman {Name} says Hooah.");
        }
    }
}
