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
 public  class Producto
    {
        //METODOS CON SQL CLIENT JUNTO CON SP

        public static ML.Result AddSP(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "ProductoAdd";
                  //  cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = context;
                

                    SqlParameter[] collection = new SqlParameter[5];
                   collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                  collection[0].Value = producto.Nombre;
                  collection[1] = new SqlParameter("PrecioUnitario", SqlDbType.VarChar);
                  collection[1].Value = producto.PrecioUnitario;
                  collection[2] = new SqlParameter("Stok", SqlDbType.VarChar);
                   collection[2].Value = producto.Stok;
                   collection[3] = new SqlParameter("IdProveedor", SqlDbType.VarChar);
                   collection[3].Value = producto.Proveedor.IdProveedor;
                    collection[4] = new SqlParameter("IdDepartamento", SqlDbType.VarChar);
                    collection[4].Value = producto.Departamento.IdDepartamento;

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
        public static ML.Result UpdateSP(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "ProductoUpdate";
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[6];
                collection[0] = new SqlParameter("IdProducto", SqlDbType.VarChar);
                collection[0].Value = producto.IdProducto;
                collection[1] = new SqlParameter("Nombre", SqlDbType.VarChar);
                collection[1].Value = producto.Nombre;
                collection[2] = new SqlParameter("PrecioUnitario", SqlDbType.VarChar);
                collection[2].Value = producto.PrecioUnitario;
                collection[3] = new SqlParameter("Stok", SqlDbType.VarChar);
                collection[3].Value = producto.Stok;
                collection[4] = new SqlParameter("IdProveedor", SqlDbType.VarChar);
                collection[4].Value = producto.Proveedor.IdProveedor;
                collection[5] = new SqlParameter("IdDepartamento", SqlDbType.VarChar);
                collection[5].Value = producto.Departamento.IdDepartamento;


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

        public static ML.Result DeleteSP(ML.Producto producto)
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
                    collection[0] = new SqlParameter("IdProducto", SqlDbType.VarChar);
                    collection[0].Value = producto.IdProducto;
                 

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

                        DataTable tableProducto = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(tableProducto);

                        if (tableProducto.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in tableProducto.Rows)
                            {
                                ML.Producto producto = new ML.Producto();

                                producto.IdProducto = int.Parse(row[0].ToString());
                                producto.Nombre = row[1].ToString();
                                producto.PrecioUnitario = decimal.Parse(row[2].ToString());
                                producto.Stok = int.Parse(row[3].ToString());
                                //producto.IdProveedor = int.Parse(row[4].ToString());
                                //producto.IdDepartamento = int.Parse(row[5].ToString());


                                result.Objects.Add(producto);

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

        public static ML.Result GetByIdSP( )
        
        {

            ML.Result result = new ML.Result();
            try
            {

                using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
                {


                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "ProductoGetById";
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("IdProducto", SqlDbType.Int);
              //      collection[0].Value = IdProducto;


                    cmd.Parameters.AddRange(collection);
                    DataTable tableProducto = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tableProducto);


                    if (tableProducto.Rows.Count > 0)
                    {
                        DataRow row = tableProducto.Rows[0];

                        ML.Producto producto = new ML.Producto();
                        producto.IdProducto = int.Parse(row[0].ToString());
                        producto.Nombre = row[1].ToString();
                        producto.PrecioUnitario = decimal.Parse(row[2].ToString());
                        producto.Stok = int.Parse(row[3].ToString());
                        //producto.IdProveedor = int.Parse(row[4].ToString());
                        //producto.IdDepartamento = int.Parse(row[5].ToString());



                        result.Object = producto;

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


        // METODOS CON EF

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {
                    var productos = context.ProductoGetAll().ToList();

                    result.Objects = new List<object>();

                    if (productos != null)
                    {
                        foreach (var obj in productos)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.IdProducto = obj.IdProducto;
                            producto.Nombre = obj.Nombre;
                            producto.PrecioUnitario = obj.PrecioUnitario;
                            producto.Stok = obj.Stok;
                            producto.Proveedor = new ML.Proveedor();
                            producto.Proveedor.IdProveedor = obj.IdProveedor.Value;
                            producto.Departamento = new ML.Departamento();
                            producto.Departamento.IdDepartamento = obj.IdDepartamento.Value;
                            //Agreagr instancia de departamento producto.Departamento = new ML.Departamento
                            //Agregar el id producto.Departamento.IdDepartamento = obj.IdDepartamento

                            result.Objects.Add(producto);

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

        public static ML.Result GetByIdEF(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {
                    var obj = context.ProductoGetById(IdProducto).FirstOrDefault();

                    if (obj != null)
                    {

                        ML.Producto producto = new ML.Producto();                      
                        producto.IdProducto = obj.IdProducto;
                        producto.Nombre = obj.Nombre;
                        producto.PrecioUnitario = obj.PrecioUnitario;
                        producto.Stok=obj.Stok;
                        producto.Proveedor= new ML.Proveedor();
                        producto.Proveedor.IdProveedor = obj.IdProveedor.Value;
                        producto.Departamento= new ML.Departamento();
                        producto.Departamento.IdDepartamento= obj.IdDepartamento.Value;


                        result.Object= producto;
                        
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

        public static ML.Result UpdateEF(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {
                    var query = context.ProductoUpdate(producto.IdProducto,producto.Nombre,producto.PrecioUnitario,producto.Stok,producto.Proveedor.IdProveedor,producto.Departamento.IdDepartamento);

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

        public static ML.Result AddEF(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities())
                {
                    var query = context.ProductoAdd(producto.Nombre, producto.PrecioUnitario, producto.Stok, producto.Proveedor.IdProveedor, producto.Departamento.IdDepartamento);

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

        public static ML.Result DeleteEF(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.VVazquezProgramacionNCapasEntities context = new DL_EF.VVazquezProgramacionNCapasEntities()) 
                {

                    var query = context.ProductoDelete(producto.IdProducto);

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
                                            

