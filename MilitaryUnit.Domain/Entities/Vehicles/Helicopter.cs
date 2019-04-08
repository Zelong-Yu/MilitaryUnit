using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain
{
    public class Helicopter : Vehicle, ISound
    {
        public static int numHelicopters= 0;
        
        public Helicopter()
        {
            Name = "Default Helicopter";
            Sound = "Chuff chuff chuff";
            numHelicopters++;
        }

        public Helicopter(string name) : base(name)
        {
            Sound = "Chuff chuff chuff";
            numHelicopters++;
        }

        public override void Drive()
        {
            Console.WriteLine($"Helicopter {Name} Flying");
        }

        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }

        protected override void Move(int x, int y)
        {
            TakeOff();
            Drive();
            base.Move(x, y);
            Land();
        }

        private void Land()
        {
            Console.WriteLine($"Helicopter {Name} landing");
        }

        private void TakeOff()
        {
            Console.WriteLine($"Helicopter {Name} taking off");
        }
    }
}
