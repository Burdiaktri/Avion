using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avion
{
    public class AvionCarga:Avion
    {
        public AvionCarga(int peso, string tipoMercaderia, string Piloto, string CoPiloto, string Azafata) : base(Piloto, CoPiloto, Azafata)
        {
            Peso = peso;
            TipoMercaderia = tipoMercaderia;
        }

        public int Peso { get; set; }
        public string TipoMercaderia { get; set; }

        public override string Aterriza()
        {
            return "... Avión de Carga";
        }

        public override string Despega()
        {
            return "... Avión de Carga";
        }
    }
}
