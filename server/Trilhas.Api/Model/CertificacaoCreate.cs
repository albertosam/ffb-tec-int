﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trilhas.Api.Model
{
    public class CertificacaoCreate
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Provedor { get; set; }
    }
}
