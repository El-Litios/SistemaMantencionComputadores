using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class EstadoMantencionModelo
    {
        [Key]
        public int EstadoID { get; set; }
        public string EstadoNombre { get; set; }
    }
}
