using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avion
{
    public class AvionComercial : Avion
    {
        public AvionComercial(int capacidad, string lineaAerea, string Piloto, string CoPiloto, string Azafata) : base(Piloto, CoPiloto, Azafata)
        {
            Capacidad = capacidad;
            LineaAerea = lineaAerea;
        }

        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }

        public override string Aterriza()
        {
            return "... Avión Comercial";
        }
        public override string Despega()
        {
            return "... Avión Comercial";
        }

        public override string Propiedades()
        {
            return $"Piloto:{Piloto}, Copiloto:{CoPiloto}, Azafata: {Azafata}, Capacidad: { Capacidad}, Linea Aerea: { LineaAerea}";
        }
    }
}
