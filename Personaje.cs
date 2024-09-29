using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public abstract class Personaje : ICombatiente
    {
        public string Nombre { get; set; }
        public int Salud { get; set; }
        public int Ataque { get; set; }
        public Arma Arma { get; set; }

        public Personaje(string nombre, int salud, int ataque)
        {
            Nombre = nombre;
            Salud = salud;
            Ataque = ataque;
        }

        public bool EstaVivo()
        {
            return Salud > 0;
        }

        public abstract void Atacar(ICombatiente objetivo);
    }

}
