using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class DeathStar : SpaceStation
    {
        public override string atisma { get ; set; }

        public override string fireloser()
        {
            return $"laserin sesi  ---  {atisma}" ;
        }
    }
}
