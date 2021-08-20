using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaGestion.Models
{
    public class UsuarioModelo
    {
        [Key]
        public int UsuarioID { get; set; }
        public string UsuarioAlias { get; set; }
        public string UsuarioPass { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioAP { get; set; }
        public string UsuarioAM { get; set; }

        [NotMapped]
        public string UsuarioNombreCompleto { 
            get { 
                return UsuarioNombre + " " + UsuarioAP + " " + UsuarioAM; 
            } 
        }
        public int RolID { get; set; }
        public RolModelo Rol { get; set; }
    }
}
