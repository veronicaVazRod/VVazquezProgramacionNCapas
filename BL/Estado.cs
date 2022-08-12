
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Estado
    {
        public static ML.Result GetByIdPais(int IdPais)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {


                    var query = context.EstadoGetByIdPais(IdPais).ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {


                        foreach (var obj in query)
                        {

                            ML.Estado estado = new ML.Estado();

                            estado.IdEstado = obj.IdEstado;
                            estado.Nombre = obj.Nombre;
                            estado.Pais = new ML.Pais();
                            estado.Pais.IdPais = obj.IdPais.Value;

                            result.Objects.Add(estado);
                        }


                        result.Correct = true;

                    }
                    else
                    {

                        result.Correct = false;

                    }
                }
            }
            catch (Exception Ex)
            {

                result.Correct = false;
                result.Messages = Ex.Message;
                result.Ex = Ex;

            }

            return result;
        }
    }
}