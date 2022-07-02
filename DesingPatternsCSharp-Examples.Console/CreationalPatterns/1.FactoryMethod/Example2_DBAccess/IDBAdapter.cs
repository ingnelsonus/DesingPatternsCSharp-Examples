﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2_DBAccess
{
    internal interface IDBAdapter
    {

        IDbConnection GetConnection();
    }
}
