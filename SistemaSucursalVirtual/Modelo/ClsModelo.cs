using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class ClsModelo
    {
        #region variables
        SqlConnection cnBaseDatos = null;
        SqlCommand cmdBaseDatos = null;
        string strConexion = string.Empty;
        SqlDataReader drBaseDatos = null;
        DataTable dttBaseDatos = null;
        #endregion

        #region constructor
        public ClsModelo()
        {
            strConexion = "Data Source=WILLIAMKHALIFA; Initial catalog=BD_SucursalVirtual; Integrated Security=True";
        }

        #endregion

        #region metodos

        //Consulta para el login
        public DataTable mtLogin(string nombre, string contraseña )
        {

            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                dttBaseDatos = new DataTable();
                cmdBaseDatos = new SqlCommand();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_InicioSesion";
                cmdBaseDatos.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                cmdBaseDatos.Parameters.Add("@contraseña", SqlDbType.VarChar, 30).Value = contraseña;

                //ejecutar la consulta y almacenar datos

                cnBaseDatos.Open();
                drBaseDatos = cmdBaseDatos.ExecuteReader();
                dttBaseDatos.Load(drBaseDatos);

                return dttBaseDatos;
            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        public DataTable mtExtraerSaldos(int cedula)
        {
            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                dttBaseDatos = new DataTable();
                cmdBaseDatos = new SqlCommand();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_ExtraccionCuenta";
                cmdBaseDatos.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;

                //ejecutar la consulta y almacenar datos

                cnBaseDatos.Open();
                drBaseDatos = cmdBaseDatos.ExecuteReader();
                dttBaseDatos.Load(drBaseDatos);

                return dttBaseDatos;
            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        public void mtActualizarDatos(double cedula, string nombre, string correo, string direccion, double celular, string empleado )
        {
            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                dttBaseDatos = new DataTable();
                cmdBaseDatos = new SqlCommand();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_Actualizacion";
                cmdBaseDatos.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
                cmdBaseDatos.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                cmdBaseDatos.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = correo;
                cmdBaseDatos.Parameters.Add("@direccion", SqlDbType.VarChar, 30).Value = direccion;
                cmdBaseDatos.Parameters.Add("@celular", SqlDbType.Float).Value = celular;
                cmdBaseDatos.Parameters.Add("@empleado", SqlDbType.VarChar, 2).Value = empleado;

                //ejecutar la consulta y almacenar datos
                cnBaseDatos.Open();
                cmdBaseDatos.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        public void mtCambioContraseña(string nom, string contraseña)
        {
            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                cmdBaseDatos = new SqlCommand();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_CambioContraseña";
                cmdBaseDatos.Parameters.Add("@contraseña", SqlDbType.VarChar, 50).Value = contraseña;
                cmdBaseDatos.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nom;
              

                //ejecutar la consulta y almacenar datos

                cnBaseDatos.Open();
                drBaseDatos = cmdBaseDatos.ExecuteReader();

            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        public void mtRegistrarMov(string nombreCuenta, double valor, string fecha, int NumeroCuenta)
        {
            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                cmdBaseDatos = new SqlCommand();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_RegistrarMovimiento";
                cmdBaseDatos.Parameters.Add("@fecha", SqlDbType.VarChar, 20).Value = fecha;
                cmdBaseDatos.Parameters.Add("@cuenta", SqlDbType.Int).Value = NumeroCuenta;
                cmdBaseDatos.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = nombreCuenta;
                cmdBaseDatos.Parameters.Add("@valor", SqlDbType.Float).Value = valor;

                //ejecutar la consulta y almacenar datos

                cnBaseDatos.Open();
                cmdBaseDatos.ExecuteReader();

            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        //metodo para almacenar el nombre y la cedula temporales
        public void mtLlenarTemporales(int cedula, string nombre)
        {
            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                cmdBaseDatos = new SqlCommand();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_LlenarCedTemporal";
                cmdBaseDatos.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
                cmdBaseDatos.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = nombre;

                //ejecutar la consulta y almacenar datos

                cnBaseDatos.Open();
                cmdBaseDatos.ExecuteReader();

            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        //metodo para sacar las temporales
        public DataTable mtSacarTemporales()
        {
            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                cmdBaseDatos = new SqlCommand();
                dttBaseDatos = new DataTable();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_DatosTemporales";
              


                //ejecutar la consulta y almacenar datos

                cnBaseDatos.Open();
                drBaseDatos =cmdBaseDatos.ExecuteReader();
                dttBaseDatos.Load(drBaseDatos);

                return dttBaseDatos;
            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        //metodo para sacar la tabla movimiento
        public DataTable mtSacarMovimiento(int valor)
        {
            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                cmdBaseDatos = new SqlCommand();
                dttBaseDatos = new DataTable();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_SacarMovimientos";
                cmdBaseDatos.Parameters.Add("@cuenta", SqlDbType.Int).Value = valor;


                //ejecutar la consulta y almacenar datos

                cnBaseDatos.Open();
                drBaseDatos = cmdBaseDatos.ExecuteReader();
                dttBaseDatos.Load(drBaseDatos);

                return dttBaseDatos;
            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        //metodo para sacar la clave de un cliente
        public DataTable mtSacarClave(string nombre, string clave)
        {
            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                cmdBaseDatos = new SqlCommand();
                dttBaseDatos = new DataTable();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_sacarClave";
                cmdBaseDatos.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = nombre;
                cmdBaseDatos.Parameters.Add("@clave", SqlDbType.VarChar,50).Value = clave;

                //ejecutar la consulta y almacenar datos

                cnBaseDatos.Open();
                drBaseDatos = cmdBaseDatos.ExecuteReader();
                dttBaseDatos.Load(drBaseDatos);

                return dttBaseDatos;
            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        //metodo para registrar Pago de servicios
        public void mtPagarServicio(string movimientos, double valor, string fecha, int cuenta)
        {
            try
            {
                //conexion base de datos y preparacion de consulta
                cnBaseDatos = new SqlConnection(strConexion);
                cmdBaseDatos = new SqlCommand();
                dttBaseDatos = new DataTable();
                cmdBaseDatos.Connection = cnBaseDatos;
                cmdBaseDatos.CommandType = CommandType.StoredProcedure;
                cmdBaseDatos.CommandText = "SP_RegistrarPagoServicios";
                cmdBaseDatos.Parameters.Add("@fecha", SqlDbType.VarChar, 10).Value = fecha;
                cmdBaseDatos.Parameters.Add("@tipoTrans", SqlDbType.VarChar, 30).Value = movimientos;
                cmdBaseDatos.Parameters.Add("@cuenta", SqlDbType.VarChar,20).Value = cuenta;
                cmdBaseDatos.Parameters.Add("@valor", SqlDbType.Float).Value = valor;

                //ejecutar la consulta y almacenar datos

                cnBaseDatos.Open();
                cmdBaseDatos.ExecuteReader();
            }
            catch (Exception ex)
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
                throw new Exception(ex.Message);
            }
            finally
            {
                //garbage collector
                cnBaseDatos.Dispose();
                cmdBaseDatos.Dispose();
            }
        }

        #endregion
    }
}
