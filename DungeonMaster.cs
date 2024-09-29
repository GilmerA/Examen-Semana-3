using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public class DungeonMaster
    {
        public List<Enemigo> Enemigos { get; set; }
        public List<Stage> Stages { get; set; }

        public DungeonMaster()
        {
            Enemigos = new List<Enemigo>();
            Stages = new List<Stage>();
        }

        public void CrearEnemigos()
        {
            Enemigos.Add(new Dragon());
            Enemigos.Add(new CaballeroOscuro());
        }

        public void CrearStage(int cantidadEnemigos)
        {
            var stage = new Stage();
            for (int i = 0; i < cantidadEnemigos; i++)
            {
                stage.Enemigos.Add(Enemigos[i % Enemigos.Count]);
            }
            Stages.Add(stage);
        }
    }
}
