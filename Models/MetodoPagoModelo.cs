using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class MetodoPagoModelo
    {
        [Key]
        public int MetodoID { get; set; }
        public string MetodoNombre { get; set; }

    }
}
