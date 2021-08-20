using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaGestion.Models
{
    public class ComputadorModelo
    {
        [Key]
        public int ComputadorID { get; set; }
        public string PcRam { get; set; }
        public string PcDisco1 { get; set; }
        public string PcDisco2 { get; set; }
        public string PcProcesador { get; set; }
        public string PcVideo { get; set; }
        public int ModeloID { get; set; }
        public ModelosPcModelo Modelo { get; set; }
        public int SistemaID { get; set; }
        public SistemaOperativoModelo Sistema { get; set; }
        public int CategoriaID { get; set; }
        public CategoriaPcModelo Categoria { get; set; }
    }
}
