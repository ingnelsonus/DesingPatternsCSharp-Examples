﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Juego_Strategy
{
    internal class Bazooka : Arma
    {
        public override string Disparar()
        {
            return "Disparando con una Bazooka";
        }
    }
}
