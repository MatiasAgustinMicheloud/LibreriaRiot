﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    internal class Cliente
    {
        public int Id_Cliente { get; set; }
        public string? Domicilio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int id_Persona { get; set; }
    }
}
