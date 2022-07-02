﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal abstract class Empanada
    {
        protected string _descripcion;

        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
    }
}
