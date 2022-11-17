﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroContable.Entidades
{
    [Serializable]
    public class MovimientoCuenta
    {
        public Cuenta Cuenta { get; set; }
        public Double Debe { get; set; }
        public Double Haber { get; set; }
    }
}
