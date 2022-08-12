using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
   public class Colonia
    {

        public string  Nombre { get; set; }
        public string CodigoPostal { get; set; }
        public string IdMunicipio { get; set; }
        public ML.Municipio Municipio { get; set; }
        public int IdColonia { get; set; }
        public List<Colonia> Colonias { get; set; }
    }
}
