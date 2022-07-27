using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult GetAll()
        {

            ML.Usuario usuario = new ML.Usuario();

            ML.Result result = BL.Usuario.GetAll();

            if (result.Correct)
            {
                usuario.Usuarios= result.Objects;
            }
            else
            {
                //Error
            }
            return View(usuario); //ACTION RESULT: Tipos de retorno EJEMPLO: ActionResult -> Vista en HTML
        }




        [HttpGet]
        public ActionResult Form(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();

            if (IdUsuario == null)// ADD
            {
   

                return View(usuario);
            }
            else //UPDATE
            {
                ML.Result result = BL.Usuario.GetById(IdUsuario.Value);
                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object; //Unboxing
                    return View(usuario);
                }
                else
                {
                    //Mostrar mensaje de Error 
                    return View("Modal");
                }
            }

        }

        [HttpPost]
        public ActionResult Form(ML.Usuario usuario)
        {
        if (usuario.IdUsuario == 0) //ADD
        {
            ML.Result result = BL.Usuario.Add(usuario);

            if (result.Correct)
            {
                ViewBag.Mensaje = "Registro existoso";
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error" ;
            }
        }
        else  //UPDATE
        {
            ML.Result result = BL.Usuario.Update(usuario);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Actualización existosa";
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error";
            }
        }


        return View("Modal");
        }

        public ActionResult Delete(int IdUsuario )
        {

            ML.Usuario usuario = new ML.Usuario();
            usuario.IdUsuario = IdUsuario;

            ML.Result result = BL.Usuario.Delete(usuario);

            if (result.Correct)
            {
                ViewBag.Mensaje = "Se elimino";
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error";
            }
            return View("Modal"); 
        }

    }
}
