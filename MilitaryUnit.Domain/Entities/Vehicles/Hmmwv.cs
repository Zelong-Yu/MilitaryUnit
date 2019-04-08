using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain
{
    public class Hmmwv : Vehicle
    {
        public static int numHmmwv = 0;
        public Hmmwv()
        {
            Name = "Default Hmmwv";
            numHmmwv++;
        }

        public Hmmwv(string name) : base(name)
        {
            numHmmwv++;
        }

        public override void Drive()
        {
            Console.WriteLine($"Hmmwv {Name} motoring");
        }

        protected override void Move(int x, int y)
        {
            Accelerate();
            Drive();
            base.Move(x, y);
            Brake();
        }

        private void Brake()
        {
            Console.WriteLine($"Hmmwv {Name} braking");
        }

        private void Accelerate()
        {
            Console.WriteLine($"Hmmwv {Name} accelerating");
        }
    }
}
