using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Producto
    {
        public static void Add()
        {
            ML.Producto producto = new ML.Producto();


            Console.WriteLine("Ingrese el nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio Unitario");
            producto.PrecioUnitario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Stok");
            producto.Stok = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el id del proveedor");
            //Instacnia de proveedor y departamento ..
            producto.Proveedor = new ML.Proveedor();
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el id del Departamento");
            producto.Departamento= new ML.Departamento();
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

       //     ML.Result result = BL.Producto.AddSP(producto);//Linea que entra a EF
            ML.Result result = BL.Producto.AddEF(producto);

            if (result.Correct)
            {
                Console.WriteLine("producto agregado exitosamente");  // agregado correctamente
            }
            else
            {
                Console.WriteLine("ocurrio un problema" + result.Messages);
            }




        }
        public static void Update()
        {
            ML.Producto producto = new ML.Producto();


            Console.WriteLine("Ingrese el id del producto");
            producto.IdProducto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nombre");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio Unitario");
            producto.PrecioUnitario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Stok");
            producto.Stok = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el id del proveedor");
            //CREAR instancia provedor y Departamento
            producto.Proveedor = new ML.Proveedor();    
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());
            //
            producto.Departamento=new ML.Departamento();
            Console.WriteLine("Ingrese el id del Departamento");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());


            //ML.Result result = BL.Producto.UpdateSP(producto);
            ML.Result result = BL.Producto.UpdateEF(producto);
            if (result.Correct)
            {
                Console.WriteLine("producto actualizado exitosamente");  // agregado correctamente
            }
            else
            {
                Console.WriteLine("ocurrio un problema" + result.Messages);
            }

        }
        public static void Delete()
        {
            ML.Producto producto = new ML.Producto();


            Console.WriteLine("Ingrese el id del producto a eliminar");
            producto.IdProducto = int.Parse(Console.ReadLine());




            //    ML.Result result = BL.Producto.DeleteSP(producto);
            ML.Result result = BL.Producto.DeleteEF(producto);
            if (result.Correct)
            {
                Console.WriteLine("producto se a eliminado exitosamente");  // agregado correctamente
            }
            else
            {
                Console.WriteLine("ocurrio un problema" + result.Messages);
            }




        }
        public static void GetAll()
        {
            //ML.Result result = BL.Producto.GetAllSP();
            ML.Result result = BL.Producto.GetAllEF(); //Llama al metodo GetAlEFF dentro de la capa BL

            if (result.Correct) //Valida que el metodo de BL que tenga información 
            {
                foreach(ML.Producto producto in result.Objects) // Nos ayuda a recorrer una lista de objetos y guardarlos en nuesta instancia de ML.Producto producto
                {
                    Console.WriteLine("___________");
                    Console.WriteLine("El Id del producto es: " + producto.IdProducto);
                    Console.WriteLine("el nombre del producto es: " + producto.Nombre);
                    Console.WriteLine("el precio unitario del producto es: " + producto.PrecioUnitario);
                    Console.WriteLine("el stok es: " + producto.Stok);
                    Console.WriteLine("el Id del proveedor es: " + producto.Proveedor.IdProveedor);
                    Console.WriteLine("el Id del departamento es: " + producto.Departamento.IdDepartamento);//Copiar linea para mostrar IdDepartamento
                }
            }
            else //Entra a este bloque si el método de BL no funciono correctamente
            {
                Console.WriteLine("No se ha podido consular" + result.Messages);

            }
            Console.ReadKey();
        }
        public static void GetById()
        {
            Console.WriteLine("Ingrese el id del producto que quieres consultar");
            int IdProducto = int.Parse(Console.ReadLine());

            ML.Producto producto = new ML.Producto();
          //  ML.Result result = BL.Producto.GetById(IdProducto);
            ML.Result result = BL.Producto.GetByIdEF(IdProducto); //Descomentar cuando cree mi metodo GetByIdEF en la capa de BL
            
            if (result.Correct)
            
                {
                producto = (ML.Producto)result.Object; //especifica el tipo de dato que almacena object (unboxing)
                Console.WriteLine("___________");
                Console.WriteLine("El Id del producto es" + producto.IdProducto);
                Console.WriteLine("el nombre del producto es" + producto.Nombre);
                Console.WriteLine("el precio unitario del producto es" + producto.PrecioUnitario);
                Console.WriteLine("el stok es" + producto.Stok);
                Console.WriteLine("el Id del proveedor es" + producto.Proveedor.IdProveedor);
                Console.WriteLine("el Id del departamento es" + producto.Departamento.IdDepartamento);
            }
            
            else
            {
                Console.WriteLine("No se ha podido consular" + result.Messages);

            }
            Console.ReadKey();
        }
    }
}
