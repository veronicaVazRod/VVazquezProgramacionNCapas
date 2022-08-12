using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
   public  class Direccion
    {
        public int IdDireccion { get; set; }    
        public string Calle { get; set; }   
        public ML.Colonia Colonia { get; set; }
        public ML.Estado estado { get; set; }
        public ML.Pais Pais { get; set; }
        public ML.Municipio Municipio { get; set; } 
        public string NumeroInterior { get; set; }
        public string NumeroExterior { get; set; }
        public int IdColonia { get; set; }
        public int IdUsuario { get; set; }
       

    }
}
