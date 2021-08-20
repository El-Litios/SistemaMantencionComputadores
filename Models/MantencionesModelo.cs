using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class MantencionesModelo
    {
        [Key]
        public int MantencionID { get; set; }
        public string MantencionFallas { get; set; }
        public string MantencionProceso { get; set; }
        public DateTime MantencionFecha { get; set; }
        public int MantencionPrecio { get; set; }
        public int MantencionImpuesto { get; set; }
        public int MantencionTotal { get; set; }
        public int MetodoID { get; set; }
        public MetodoPagoModelo Metodo { get; set; }
        public int ClienteID { get; set; }
        public ClientesModelo Cliente { get; set; }
        public int UsuarioID { get; set; }
        public UsuarioModelo Usuario { get; set; }
        public int EstadoID { get; set; }
        public EstadoMantencionModelo Estado { get; set; }

        public List<DetalleMantencionesModelo> ListaDetalleM { get; set; }
    }
}
