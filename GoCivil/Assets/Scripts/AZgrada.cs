﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal abstract class AZgrada
    {
        internal abstract string VratiNaziv();
        internal abstract List<AZgrada> VratiZgradeZaZidanje();
    }
}
