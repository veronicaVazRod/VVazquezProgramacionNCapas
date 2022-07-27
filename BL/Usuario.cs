using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ML;
using DL_EF;



namespace BL
{
    public class Usuario
    {
        //SP
        public static ML.Result AddSP(ML.Usuario usuario)


        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UsuarioAdd";
                    cmd.Connection = context;


                    SqlParameter[] collection = new SqlParameter[13];
                    collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;
                    collection[1] = new SqlParameter("IdRol", SqlDbType.VarChar);
                    collection[1].Value = usuario.Rol.IdRol;
                    collection[2] = new SqlParameter("UserName",SqlDbType.VarChar);
                    collection[2].Value = usuario.UserName;
                    collection[3] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                    collection[3].Value = usuario.ApellidoPaterno;
                    collection[4] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                    collection[4].Value = usuario.ApellidoMaterno;
                    collection[5] = new SqlParameter("Email", SqlDbType.VarChar);
                    collection[5].Value = usuario.Email;
                    collection[6] = new SqlParameter("Password", SqlDbType.VarChar);
                    collection[6].Value = usuario.Password;
                    collection[7] = new SqlParameter("Sexo", SqlDbType.VarChar);
                    collection[7].Value = usuario.Sexo;
                    collection[8] = new SqlParameter("Telefono", SqlDbType.VarChar);
                    collection[8].Value = usuario.Telefono;
                    collection[9] = new SqlParameter("Celular", SqlDbType.VarChar);
                    collection[9].Value = usuario.Celular;
                    collection[10] = new SqlParameter("FechaNacimiento", SqlDbType.DateTime);
                    //collection[10].Value = usuario.FechaNacimiento;
                    collection[11] = new SqlParameter("CURP", SqlDbType.VarChar);
                    collection[11].Value = usuario.CURP;
                    collection[12] = new SqlParameter("Imagen", SqlDbType.VarBinary);
                    collection[12].Value = usuario.Imagen;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();
                    int RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;

                    }
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;
                result.Ex = ex;
            }
            return result;

        }

        public static ML.Result UpdateSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UsuarioUpdate";
                    cmd.Connection = context;


                    SqlParameter[] collection = new SqlParameter[13];
                    collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                    collection[0].Value = usuario.Nombre;
                    collection[1] = new SqlParameter("IdRol", SqlDbType.VarChar);
                    collection[1].Value = usuario.Rol.IdRol;
                    collection[2] = new SqlParameter("UserName", SqlDbType.VarChar);
                    collection[2].Value = usuario.UserName;
                    collection[3] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                    collection[3].Value = usuario.ApellidoPaterno;
                    collection[4] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                    collection[4].Value = usuario.ApellidoMaterno;
                    collection[5] = new SqlParameter("Email", SqlDbType.VarChar);
                    collection[5].Value = usuario.Email;
                    collection[6] = new SqlParameter("Password", SqlDbType.VarChar);
                    collection[6].Value = usuario.Password;
                    collection[7] = new SqlParameter("Sexo", SqlDbType.VarChar);
                    collection[7].Value = usuario.Sexo;
                    collection[8] = new SqlParameter("Telefono", SqlDbType.VarChar);
                    collection[8].Value = usuario.Telefono;
                    collection[9] = new SqlParameter("Celular", SqlDbType.VarChar);
                    collection[9].Value = usuario.Celular;
                    collection[10] = new SqlParameter("FechaNacimiento", SqlDbType.DateTime);
                    //collection[10].Value = usuario.FechaNacimieneto;
                    collection[11] = new SqlParameter("CURP", SqlDbType.VarChar);
                    collection[11].Value = usuario.CURP;
                    collection[12] = new SqlParameter("Imagen", SqlDbType.VarBinary);
                    collection[12].Value = usuario.Imagen;
                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();
                    int RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;

                    }
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;
                result.Ex = ex;
            }
            return result;

        }

        public static ML.Result DeleteSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "ProductoDelete";
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("IdUsuario", SqlDbType.VarChar);
                    collection[0].Value = usuario.IdUsuario;


                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();
                    int RowAffected = cmd.ExecuteNonQuery();

                    if (RowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;

                    }
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;
                result.Ex = ex;
            }
            return result;

        }

        public static ML.Result GetAllSP()
        {

            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    string query = "ProductoGetAll";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable tableUsuario = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in tableUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();

                                usuario.Nombre = row[0].ToString();
                                usuario.IdUsuario = int.Parse(row[1].ToString());
                                usuario.Rol.IdRol= int.Parse(row[2].ToString());   
                                usuario.UserName = row[3].ToString();
                                usuario.ApellidoPaterno= row[4].ToString();
                                usuario.ApellidoMaterno= row[5].ToString();
                                usuario.Sexo= row[6].ToString();
                                usuario.Telefono= row[7].ToString();
                                usuario.Celular= row[8].ToString();
                            //    usuario.FechaNacimiento = 
                                usuario.CURP= row[10].ToString();
                             //   usuario.Imagen = int.Parse(row[11].ToString);

                                result.Objects.Add(usuario);

                            }
                            result.Correct = true;

                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;
            }
            return result;
        }

        public static ML.Result GetByIdSP()

        {

            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {


                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "UsuarioGetById";
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
                   // collection[0].Value = IdUsuario;


                    cmd.Parameters.AddRange(collection);
                    DataTable tableUsuario = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tableUsuario);


                    if (tableUsuario.Rows.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (DataRow row in tableUsuario.Rows)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.Nombre = row[0].ToString();
                            usuario.IdUsuario = int.Parse(row[1].ToString());
                            usuario.Rol.IdRol = int.Parse(row[2].ToString());
                            usuario.UserName = row[3].ToString();
                            usuario.ApellidoPaterno = row[4].ToString();
                            usuario.ApellidoMaterno = row[5].ToString();
                            usuario.Sexo = row[6].ToString();
                            usuario.Telefono = row[7].ToString();
                            usuario.Celular = row[8].ToString();
                        //  usuario.FechaNacimiento = DataTime.Parse(row[9].ToString());
                            usuario.CURP = row[10].ToString();
                            //usuario.Imagen = int.Parse(row[11].ToString);

                            result.Objects.Add(usuario);

                        }
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;

            }
            return result;


        }




        //entity framework


        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {
                    var usuarios = context.UsuarioGetAll().ToList();

                    result.Objects = new List<object>();

                    if (usuarios != null)
                    {
                        foreach (var obj in usuarios)
                        {
                            ML.Usuario usuario= new ML.Usuario();
                            usuario.Nombre = obj.Nombre;
                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.Rol= new ML.Rol();
                            usuario.Rol.IdRol = obj.IdRol.Value;
                            usuario.UserName = obj.UserName;
                            usuario.Email= obj.Email;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Sexo = obj.Sexo;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.FechaNacimiento = obj.FechaNacimiento.ToString(); 
                            usuario.CURP = obj.CURP;
                            usuario.Imagen = usuario.Imagen;
                            result.Objects.Add(usuario);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetById(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {
                    var obj = context.UsuarioGetById(IdUsuario).FirstOrDefault();

                    if (obj != null)
                    {

                        ML.Usuario usuario = new ML.Usuario();
                        usuario.Nombre = obj.Nombre;
                        usuario.IdUsuario = obj.IdUsuario;
                        usuario.Rol = new ML.Rol();
                        usuario.Rol.IdRol= obj.IdRol.Value;
                        usuario.UserName = obj.UserName;
                        usuario.ApellidoPaterno = obj.ApellidoPaterno;
                        usuario.ApellidoMaterno = obj.ApellidoMaterno;
                        usuario.Sexo = obj.Sexo;
                        usuario.Telefono = obj.Telefono;
                        usuario.Password = obj.PAssword;
                        usuario.Email= obj.Email;
                        usuario.Celular = obj.Celular;
                        usuario.FechaNacimiento = obj.FechaNacimiento.Value.ToString("dd-MM-yyy"); 
                        usuario.CURP = obj.CURP;
                        usuario.Imagen = usuario.Imagen ;
                       

                        result.Object = usuario;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {
                    var query = context.UsuarioUpdate(usuario.Nombre, usuario.Rol.IdRol, usuario.UserName, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Password, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.FechaNacimiento.ToString(), usuario.CURP, null, usuario.IdUsuario);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {
                    var query = context.UsuarioAdd(usuario.Nombre, usuario.Rol.IdRol, usuario.UserName, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Password, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.FechaNacimiento, usuario.CURP,null);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result Delete(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {

                    var query = context.UsuarioDelete(usuario.IdUsuario);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Messages = ex.Message;
                result.Ex = ex;
            }

            return result;
        }



    }
}
