﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDoSeuManoel.Application.DTOs.Request
{
    public class LoginRequest
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
