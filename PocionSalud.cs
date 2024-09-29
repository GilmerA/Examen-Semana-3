using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public class PocionSalud : Item
    {
        public int Curacion { get; set; }

        public PocionSalud()
        {
            Nombre = "Poción de Salud";
            Curacion = 50;
        }

        public override void Usar(Jugador jugador)
        {
            Console.WriteLine($"Usando {Nombre}, recuperando {Curacion} puntos de salud.");
            jugador.Salud += Curacion;
        }
    }
}
