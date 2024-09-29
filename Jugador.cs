using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public class Jugador : Personaje
    {
        public List<Item> Inventario { get; set; }

        public Jugador(string nombre, int salud, int ataque, Arma arma)
            : base(nombre, salud, ataque)
        {
            Arma = arma;
            Inventario = new List<Item>();
        }

        public override void Atacar(ICombatiente objetivo)
        {
            Console.WriteLine($"{Nombre} ataca a {objetivo.GetType().Name} con {Arma.Nombre}.");
            Arma.Usar(objetivo);
        }

        public void UsarItem(int indice)
        {
            if (indice >= 0 && indice < Inventario.Count)
            {
                Inventario[indice].Usar(this);
                Inventario.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("Índice de item inválido.");
            }
        }
    }
}
