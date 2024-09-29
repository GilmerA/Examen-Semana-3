using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public class Dragon : Enemigo
    {
        public Dragon() : base("Dragón", 100, 40, new Hacha())
        {
            Recompensas.Add(new PocionFuerza());
        }
    }
}
