using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public class Hacha : Arma
    {
        public Hacha() : base("Hacha", 30) { }

        public override void Usar(ICombatiente objetivo)
        {
            Console.WriteLine($"Atacando con {Nombre}. Causando {Daño} de daño.");
            objetivo.Salud -= Daño;
        }
    }
}
