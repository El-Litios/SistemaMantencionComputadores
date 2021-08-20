using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class MarcaPcModelo
    {
        [Key]
        public int MarcaID { get; set; }
        public string MarcaNombre { get; set; }
    }
}
