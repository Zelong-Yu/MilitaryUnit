using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain
{
    public interface ISound
    {
        string Sound { get; set; }

        void MakeSound();
    }
}
