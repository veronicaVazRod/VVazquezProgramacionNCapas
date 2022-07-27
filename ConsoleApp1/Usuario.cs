using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL

{
    public class Usuario
    {

        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();


            Console.WriteLine("Ingrese el nombre del usuario: ");
            usuario.Nombre = Console.ReadLine();
            usuario.Rol= new ML.Rol();
            Console.WriteLine("ingrese el rol: ");
            usuario.Rol.IdRol= int.Parse( Console.ReadLine());  
            Console.WriteLine("ingrese el User Name: ");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido Paterno: ");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido Materno: ");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el email: ");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese el password: ");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingrese el Sexo: ");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingrese el Telefono: ");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el Celular: ");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingrese el FechaNacimiento: ");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese el CURP: ");
            usuario.CURP = Console.ReadLine();
           // Console.WriteLine("Ingrese la imagen: ");
          //  usuario.Imagen =byte[].Parse(Console.ReadLine());








           // ML.Result result = BL.Usuario.AddSP(usuario);//Linea que entra a EF
            ML.Result result = BL.Usuario.Add(usuario);

            if (result.Correct)
            {
                Console.WriteLine("usuario agregado exitosamente");  // agregado correctamente
            }
            else
            {
                Console.WriteLine("ocurrio un problema" + result.Messages);
            }




        }
        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();


            Console.WriteLine("Ingrese el id del Usuario");
            usuario.IdUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nombre del usuario: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del usuario: ");
            usuario.Nombre = Console.ReadLine();
            usuario.Rol = new ML.Rol();
            Console.WriteLine("ingrese el rol: ");
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el User Name: ");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido Paterno: ");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido Materno: ");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el email: ");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese el password: ");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingrese el Sexo: ");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingrese el Telefono: ");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el Celular: ");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingrese el FechaNacimiento: ");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese el CURP: ");
            usuario.CURP = Console.ReadLine();
       //     Console.WriteLine("Ingrese la imagen: ");
        //    usuario.Imagen = Console.ReadLine(Array[]);

        //  ML.Result result = BL.Usuario.UpdateSP(usuario);
            ML.Result result = BL.Usuario.Update(usuario);
            if (result.Correct)
            {
                Console.WriteLine("Usuario actualizado exitosamente");  // agregado correctamente
            }
            else
            {
                Console.WriteLine("ocurrio un problema" + result.Messages);
            }
        }
        public static void Delete()
        {
            ML.Usuario usuario= new ML.Usuario();


            Console.WriteLine("Ingrese el id del usuario a eliminar: ");
            usuario.IdUsuario = int.Parse(Console.ReadLine());




               ML.Result result = BL.Usuario.Delete(usuario);
       //     ML.Result result = BL.Usuario.DeleteEF(usuario);
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
           // ML.Result result = BL.Usuario.GetAllSP();
            ML.Result result = BL.Usuario.GetAll(); //Llama al metodo GetAlEFF dentro de la capa BL

            if (result.Correct) 
            {
                foreach (ML.Usuario usuario in result.Objects) // Nos ayuda a recorrer una lista de objetos y guardarlos en nuesta instancia de ML.Producto producto
                {
                    Console.WriteLine("___________");
                    Console.WriteLine("El Id del usuario es: " + usuario.IdUsuario);
                    Console.WriteLine("El nombre del usuario es: " + usuario.Nombre);
                    Console.WriteLine("El rol es:  "+ usuario.Rol.IdRol);
                    Console.WriteLine("El User name es: " + usuario.UserName);
                    Console.WriteLine("El apellido paterno es: "+usuario.ApellidoPaterno);
                    Console.WriteLine("El apellido Materno es: "+usuario.ApellidoMaterno);
                    Console.WriteLine("El email del usuario es: "+usuario.Email);
                    Console.WriteLine("El password del usuario es: " + usuario.Password);
                    Console.WriteLine("El sexo del usuario es: " + usuario.Sexo);
                    Console.WriteLine("El telefono del usuario es: " + usuario.Telefono);
                    Console.WriteLine("El celullar del usuario es: " + usuario.Celular);
                    Console.WriteLine("El CURP del usuario es: " + usuario.CURP);
                    Console.WriteLine("La fecha de nacimiento del usuario es: " + usuario.FechaNacimiento);
                    Console.WriteLine("La imagen es: " + usuario.Imagen);

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
            Console.WriteLine("Ingrese el id del usuario que quieres consultar");
            int IdUsuario= int.Parse(Console.ReadLine());

           
            ML.Usuario usuario = new ML.Usuario();
             ML.Result result = BL.Usuario.GetById(IdUsuario);
            //ML.Result result = BL.Usuario.GetByIdEF(IdUsuario); //Descomentar cuando cree mi metodo GetByIdEF en la capa de BL

            if (result.Correct)

            {
                Console.WriteLine("___________");
                Console.WriteLine("El Id del usuario es: " + usuario.IdUsuario);
                Console.WriteLine("El nombre del usuario es: " + usuario.Nombre);
                Console.WriteLine("El rol es:  " + usuario.Rol.IdRol);
                Console.WriteLine("El User name es: " + usuario.UserName);
                Console.WriteLine("El apellido paterno es: " + usuario.ApellidoPaterno);
                Console.WriteLine("El apellido Materno es: " + usuario.ApellidoMaterno);
                Console.WriteLine("El email del usuario es: " + usuario.Email);
                Console.WriteLine("El password del usuario es: " + usuario.Password);
                Console.WriteLine("El sexo del usuario es: " + usuario.Sexo);
                Console.WriteLine("El telefono del usuario es: " + usuario.Telefono);
                Console.WriteLine("El celullar del usuario es: " + usuario.Celular);
                Console.WriteLine("El CURP del usuario es: " + usuario.CURP);
                Console.WriteLine("La fecha de nacimiento del usuario es: " + usuario.FechaNacimiento);
                Console.WriteLine("La imagen es: " + usuario.Imagen);


            }

            else
            {
                Console.WriteLine("No se ha podido consular" + result.Messages);

            }
            Console.ReadKey();
        }





    }
}
