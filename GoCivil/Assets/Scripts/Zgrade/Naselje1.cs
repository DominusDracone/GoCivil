using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Zgrade
{
    internal class Naselje1 : AZgrada
    {
        internal override string VratiNaziv()
        {
            return "Naselje I";
        }

        internal override List<AZgrada> VratiZgradeZaZidanje()
        {
            throw new NotImplementedException();
        }
    }
}
