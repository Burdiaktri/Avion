using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avion
{
    public abstract class Avion

    {
        public Avion(string Piloto, string CoPiloto, string Azafata) {
            this.Piloto = Piloto;
            this.CoPiloto = CoPiloto;
            this.Azafata = Azafata;
        }
        public string Piloto { get; set; }
        
        public string CoPiloto { get; set; }
        public string Azafata { get; set; }

        public virtual string Aterriza()
        {
            return "...Aterrizando";
        }

        public virtual string Despega()
        {
            return "...Despegando";
        }

        public virtual string Propiedades()
        {
            return $"Piloto:{ Piloto}, Copiloto:{ CoPiloto}, Azafata: { Azafata}";
        }
    }
}
