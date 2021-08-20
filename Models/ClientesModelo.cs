using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaGestion.Models
{
    public class ClientesModelo
    {
        [Key]
        public int ClienteID { get; set; }
        public string ClienteNombre { get; set; }
        [NotMapped]
        public string ClienteNombreCompleto { get { return ClienteNombre + " " + ClienteApellidos; } }
        public string ClienteApellidos { get; set; }
        public string ClienteTelefono { get; set; }
        public string ClienteDireccion { get; set; }
        public string ClienteCorreo { get; set; }
        public int TipoID { get; set; }
        public TipoCModelo Tipo { get; set; }
    }
}
