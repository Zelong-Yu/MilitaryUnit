using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain
{
    public interface IMove
    {
        void MoveTo(int x, int y);
        void Stop();
    }
}
