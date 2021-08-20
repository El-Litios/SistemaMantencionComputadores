using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class SistemaOperativoModelo
    {
        [Key]
        public int SistemaID { get; set; }
        public string SistemaNombre { get; set; }
        public int ProveedorID { get; set; }

        //navegacion
        public ProveedorSIstemaModelo Proveedor { get; set; }
    }
}
