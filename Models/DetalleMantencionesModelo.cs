using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class DetalleMantencionesModelo
    {
        [Key]
        public int DetalleID { get; set; }
        public int MantencionID { get; set; }
        public int ComputadorID { get; set; }
        public MantencionesModelo Mantencion { get; set; }
        public ComputadorModelo Computador { get; set; }
    }
}
