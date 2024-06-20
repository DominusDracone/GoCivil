using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal abstract class AZgrada
    {
        public int PlotId { get; set; }
        public int VremeZidanja {  get; set; }
        public int PreostaloVreme {  get; set; }

        internal abstract int Cena(List<AResursi> resursi);
        internal abstract void PromeniPrirastaj(List<AResursi> resursi);
        internal abstract string VratiNaziv();
        internal abstract List<AZgrada> VratiZgradeZaZidanje();
    }
}
