using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public interface ICombatiente
    {
        int Salud { get; set; }
        int Ataque { get; set; }
        bool EstaVivo();
    }
}
