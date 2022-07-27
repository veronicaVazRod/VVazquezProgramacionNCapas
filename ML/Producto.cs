using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stok { get; set; }
      
        public ML.Proveedor Proveedor { get; set; }
        public ML.Departamento Departamento { get; set; }
 


    }

 
}
