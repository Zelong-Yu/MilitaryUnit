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
            Vehicle bee= new Vehicle("Bumbble bee");
            Helicopter heli = new Helicopter("Apache");
            bee.MoveTo(3, 3);
            Console.WriteLine(Entity.numEntities);
            Console.WriteLine(Vehicle.numVehicles);
            Console.WriteLine(Helicopter.numHelicopters);
            heli.MoveTo(2, 2);
            bee.Stop();
            heli.Stop();
        }
    }
}
