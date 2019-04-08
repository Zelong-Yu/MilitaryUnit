using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain
{
    public class Medic : Personnel
    {
        public static int numMedic = 0;
        public Medic()
        {
            Name = "Medic 68W";
            numMedic++;
        }

        public Medic(string name) : base(name)
        {
            numMedic++;
        }

        protected override void Speak()
        {
            base.Speak();
            Console.WriteLine($"Medic {Name} gonna save you.");
        }
    }
}
