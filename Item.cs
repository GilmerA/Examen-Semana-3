﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3
{
    public abstract class Item
    {
        public string Nombre { get; set; }
        public abstract void Usar(Jugador jugador);
    }
}
