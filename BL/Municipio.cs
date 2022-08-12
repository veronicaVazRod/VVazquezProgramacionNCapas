﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Municipio
    {

        public static ML.Result GetByIdEstado(int IdEstado)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {

                    var query = context.MunicipioGetByIdEstado(IdEstado).ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {

                        foreach (var obj in query)
                        {

                            ML.Municipio municipio = new ML.Municipio();

                            municipio.IdMunicipio = obj.IdMunicipio;
                            municipio.Nombre = obj.Nombre;
                            municipio.Estado = new ML.Estado();
                            municipio.Estado.IdEstado = obj.IdEstado.Value;

                            result.Objects.Add(municipio);
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