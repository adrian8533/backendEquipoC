﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace administrador.Persistence.Entities
{
    public class AseguradoEntity:BaseEntity
    {
        [Required]
        public int ci { get; set; }
        [Required]
        public string primer_n { get; set; }
        [Required]
        public string segundo_n { get; set; }
        [Required]
        public string primer_a { get; set; }
        [Required]
        public string segundo_a { get; set; }
        [Required]
        public char sexo { get; set; }
        [Required]
        public HashSet<PolizaEntity> asegurado { get; set; }
    }
}