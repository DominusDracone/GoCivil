using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Zgrade
{
    internal class Park : AZgrada
    {
        internal override string VratiNaziv()
        {
            return "Park";
        }

        internal override List<AZgrada> VratiZgradeZaZidanje()
        {
            throw new NotImplementedException();
        }
    }
}
