using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class ProveedorSIstemaModelo
    {
        [Key]
        public int ProveedorID { get; set; }
        public string ProveedorNombre { get; set; }
    }
}
