﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEC
{
        //criando DTO de dados para montar minha table
        public class CursoDTO
        {
            public int CursoId { get; set; } //esta é a chave primária
            public string Titulo { get; set; }
            public string Professor { get; set; }
            public string CargaHoraria { get; set; }
            public string Descricao { get; set; }
        }
}
