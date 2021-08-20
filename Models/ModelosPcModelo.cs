using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class ModelosPcModelo
    {
        [Key]
        public int ModeloID { get; set; }
        public string ModeloNombre { get; set; }
        public int MarcaID { get; set; }

        //navegacion
        public MarcaPcModelo Marca { get; set; }
    }
}
