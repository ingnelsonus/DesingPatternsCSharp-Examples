﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_OrdenCompra_Commad
{
    internal class BajaStockCommand:OrdenCommand
    {
        public BajaStockCommand(ProductoReceiver producto,double cantidad):base(producto,cantidad)
        {

        }

        public override void Ejecutar()
        {
            _producto.RestarStock(_cantidad);
        }
    }
}
