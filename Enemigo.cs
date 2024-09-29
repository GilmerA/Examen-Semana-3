using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public abstract class Enemigo : Personaje
    {
        public List<Item> Recompensas { get; set; }

        public Enemigo(string nombre, int salud, int ataque, Arma arma)
            : base(nombre, salud, ataque)
        {
            Arma = arma;
            Recompensas = new List<Item>();
        }

        public override void Atacar(ICombatiente objetivo)
        {
            Console.WriteLine($"{Nombre} ataca a {objetivo.GetType().Name} con {Arma.Nombre}.");
            Arma.Usar(objetivo);
        }
    }
}
