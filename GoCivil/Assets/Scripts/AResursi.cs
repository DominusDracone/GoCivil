using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public abstract class AResursi
    {
        public String Naziv { get; set; }
        public int Vrednost { get; set; }
        public int Prirastaj { get; set; }

        public override string ToString()
        {
            return Naziv + $": {Vrednost} (+{Prirastaj})";
        }
    }
}
