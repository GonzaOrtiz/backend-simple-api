﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_api_sample.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}
