using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class TipoCModelo
    {
        [Key]
        public int TipoID { get; set; }
        public string TipoNombre { get; set; }
    }
}
