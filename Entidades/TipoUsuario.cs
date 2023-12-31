﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoUsuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; } = null!;
    }
}
