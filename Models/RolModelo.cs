using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class RolModelo
    {
        [Key]
        public int RolID { get; set; }
        public string RolNombre { get; set; }
        
    }
}
