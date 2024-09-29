using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public class CaballeroOscuro : Enemigo
    {
        public CaballeroOscuro() : base("Caballero Oscuro", 80, 30, new Espada())
        {
            Recompensas.Add(new PocionSalud());
        }
    }
}
