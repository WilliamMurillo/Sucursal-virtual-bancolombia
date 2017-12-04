using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Control
{
    public class ClsControl
    {
        #region variables
        private DataTable dtBaseDatos = null;
        private ClsModelo objModelo = null;
        private ClsVariables objVariables = null;
        private Random Aleatorio = null;
        private int i = 0;
        private int j = 0;
        private int[] vector = null;
        private int cont = 0;
        #endregion

        #region constructor
        public ClsControl(ClsVariables objVariables)
        {
            this.objVariables = objVariables;
        }
        #endregion

        #region metodos

        public void mtLoginControl()
        {
            try
            {
                objModelo = new ClsModelo();
                dtBaseDatos = objModelo.mtLogin(objVariables.parStrNombre, objVariables.parStrContraseña);
                
                objVariables.strUsuario = dtBaseDatos.Rows[0]["var_Usuario"].ToString();
                objVariables.StrContraseña = dtBaseDatos.Rows[0]["var_Contraseña"].ToString();
                objVariables.intCedula = Convert.ToInt32(dtBaseDatos.Rows[0]["int_CedulaPK"]);
                objVariables.strNombre = dtBaseDatos.Rows[0]["var_Nombre"].ToString();

                //ingreso datos temporales
                objModelo.mtLlenarTemporales(objVariables.intCedula,objVariables.strNombre);
               
            }
            catch (Exception ex)
            {     
                throw new Exception(ex.Message);
            }
          
        }

        //metodo para registrar el pago de servicios
        public void mtPagarServicios(string movimientos, double valor, string fecha, int cuenta)
        {
            try
            {
                objModelo = new ClsModelo();

                objModelo.mtPagarServicio(movimientos, valor, fecha, cuenta);
               
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        //metodo para confimar la clave, esto para el cambio de clave
        public bool mtConfimarClave(string nom, string con)
        {
            dtBaseDatos = new DataTable();
            dtBaseDatos = mtExtracClave(nom, con);

            if (dtBaseDatos.Rows[0]["var_Contraseña"].ToString() == con)
            {
                return true;

            }
            else
            {
                return false;
                     
            }
        }

        //metodo para sacar las temporales
        public DataTable mtconsultaTemporales()
        {
            objModelo = new ClsModelo();
           dtBaseDatos = objModelo.mtSacarTemporales();
           return dtBaseDatos;
        }

        //metodo confirmar login
        public bool mtConfirmacionLogin()
        {
            if (objVariables.parStrNombre == objVariables.strUsuario && objVariables.parStrContraseña == objVariables.StrContraseña)
            {
                return true;
            }
            else
            {
                return false;
            }

           
            
        }

        //metodo para sacar datos de la tabla movimiento
        public DataTable mtSacarMovi(int cuenta)
        {
            objModelo = new ClsModelo();
            dtBaseDatos = new DataTable();
            dtBaseDatos = objModelo.mtSacarMovimiento(cuenta);

            return dtBaseDatos;
        }

        //metodo para sacar contraseña de un cliente
        public DataTable mtExtracClave(string nom, string con)
        {
            try
            {
                objModelo = new ClsModelo();
                dtBaseDatos = objModelo.mtSacarClave(nom, con);
                return dtBaseDatos;

              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //metodo para la tabla saldos del productos 

        public DataTable mtExtracCuenta(int cedula)
        {
             try
            {
                objModelo = new ClsModelo();
                dtBaseDatos = objModelo.mtExtraerSaldos(cedula);

                return dtBaseDatos;

                /*objVariables.str_TipoCuenta = dtBaseDatos.Rows[0]["Var_TipoCuenta"].ToString();
                objVariables.str_NumeroCuenta = dtBaseDatos.Rows[0]["str_NumeroCuentaPK"].ToString();
                objVariables.dbl_SaldoCuenta = double.Parse(dtBaseDatos.Rows[0]["flt_Monto"].ToString());
                */
            }
           catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //metodo para actualizar datos

        public void mtActualizarDatos(int cedula,string nombre, string correo, string direccion,Double celular,string empleado)
        {
            try
            {
                objModelo = new ClsModelo();

                objModelo.mtActualizarDatos(cedula,nombre,correo,direccion,celular,empleado);
                i = 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       //metodo para cambiar la clave
        public void mtCambiarClav(string nom, string contras)
        {
            try
            {
                objModelo = new ClsModelo();
                objModelo.mtCambioContraseña(nom, contras);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //metodo para registar los movimientos de las cuentas
        public void mtRegistarMovi()
        {
            try
            {
                objModelo = new ClsModelo();
                objModelo.mtRegistrarMov(objVariables.strNombreCuenta, objVariables.dblValor, objVariables.strFechaMov, objVariables.intNumeroCuenta);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //numeros sin repetir
       public void mtAsignarNumeros()
        {
            try
            {
                vector = new int[10];
                Aleatorio = new Random();
                // int num = 0;
                vector[0] = Aleatorio.Next(0, 9);
                for (i = 0; i < vector.Length; i++)
                {
                    vector[i] = i;
                }

                /*for (i = 1; i <= 9; i++)
                 {
                     num = Aleatorio.Next(0,9);
                     cont = 0;
                 
                     for (j = 0; j < i; j++)
                     {
                         if (num == vector[j])
                         {
                             cont++;
                         }
                     }
                 
                     while (cont != 0)
                     {
                         cont = 0;
                         num = Aleatorio.Next(0,9);
                         for (j = 0; j < i; j++)
                         {
                             if (num == vector[j])
                             {
                                 cont++;
                             }
                         }
                    
                         if (cont == 0)
                         {
                             bvreak;
                         }
                     }
                     vector[i] = num;
                 }*/
                objVariables.strbtnCero = vector[0].ToString();
                objVariables.strBtnUno = vector[1].ToString();
                objVariables.strbtnDos = vector[2].ToString();
                objVariables.strbtnTres = vector[3].ToString();
                objVariables.strbtnCuatro = vector[4].ToString();
                objVariables.strbtnCinco = vector[5].ToString();
                objVariables.strbtnSeis = vector[6].ToString();
                objVariables.strbtnSiete = vector[7].ToString();
                objVariables.strbtnOcho = vector[8].ToString();
                objVariables.strbtnNueve = vector[9].ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
       
        #endregion

    }
}
