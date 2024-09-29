using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public class PocionFuerza : Item
    {
        public int AumentoAtaque { get; set; }

        public PocionFuerza()
        {
            Nombre = "Poción de Fuerza";
            AumentoAtaque = 10;
        }

        public override void Usar(Jugador jugador)
        {
            Console.WriteLine($"Usando {Nombre}, aumentando {AumentoAtaque} puntos de ataque.");
            jugador.Ataque += AumentoAtaque;
        }
    }
}
