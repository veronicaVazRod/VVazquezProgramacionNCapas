using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Usuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Usuario.svc o Usuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Usuario : IUsuario
    {

        public SL_WCF.Result Add(ML.Usuario usuario)
        {

         ML. Result result = BL.Usuario.Add(usuario );

        return new Result { Correct=result.Correct, ErrorMessage= result.ErrorMessage, Ex=result.Ex };


        }


        public SL_WCF.Result Update(ML.Usuario usuario)
        {


            ML.Result result = BL.Usuario.Update(usuario);

            return new Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex };


        }


        public SL_WCF.Result Delete(int IdUSuario)
        {

            ML.Usuario usuario = new ML.Usuario();
            usuario.IdUsuario = IdUSuario;
            ML.Result result = BL.Usuario.Delete(usuario);

            return new Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex };

        }


      

    }

}