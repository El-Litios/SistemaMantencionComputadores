using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class CategoriaPcModelo
    {
        [Key]
        public int CategoriaID { get; set; }
        public string CategoriaNombre { get; set; }
    }
}
