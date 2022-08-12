﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Colonia
    {
        public static ML.Result GetByIdMunicipio(int IdMunicipio)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {

                    var query = context.ColoniaGetByIdMunicipio(IdMunicipio).ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {

                        foreach (var obj in query)
                        {

                            ML.Colonia colonia = new ML.Colonia();

                            colonia.IdColonia = obj.IdColonia;
                            colonia.Nombre = obj.Nombre;
                            colonia.Municipio = new ML.Municipio();
                            colonia.Municipio.IdMunicipio = obj.IdMunicipio.Value;

                            result.Objects.Add(colonia);
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