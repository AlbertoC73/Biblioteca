﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Modelos
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El Campo Nombre es Requerido")]
        [MaxLength(60,ErrorMessage ="El Nombre solo se compone de 60 Caracteres como Máximo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Campo Descripción es Requerido")]
        [MaxLength(100, ErrorMessage = "La Descripción solo se compone de 100 Caracteres como Máximo")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El estado de la Marca es Requerido")]
        public bool Estado { get; set; }
    }
}
