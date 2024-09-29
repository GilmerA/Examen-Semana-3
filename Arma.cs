using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public abstract class Arma
    {
        public string Nombre { get; set; }
        public int Daño { get; set; }

        public Arma(string nombre, int daño)
        {
            Nombre = nombre;
            Daño = daño;
        }

        public abstract void Usar(ICombatiente objetivo);
    }
}
