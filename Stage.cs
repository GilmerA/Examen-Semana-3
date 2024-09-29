using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public class Stage
    {
        public List<Enemigo> Enemigos { get; set; }

        public Stage()
        {
            Enemigos = new List<Enemigo>();
        }

        public bool Completo()
        {
            return Enemigos.TrueForAll(e => !e.EstaVivo());
        }
    }
}
