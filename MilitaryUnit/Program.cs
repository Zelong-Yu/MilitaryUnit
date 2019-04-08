using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Domain;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Hmmwv vee= new Hmmwv("Humvee");
            Helicopter heli = new Helicopter("Apache");
            Console.WriteLine(Entity.numEntities);
            Console.WriteLine(Vehicle.numVehicles);
            Console.WriteLine(Helicopter.numHelicopters);


            vee.MoveTo(3, 3);
            vee.Stop();

            heli.MoveTo(2, 2);
            heli.Stop();
        }
    }
}
