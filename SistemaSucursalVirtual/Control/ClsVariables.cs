using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Control
{
    public class ClsVariables
    {
        //parametros para login
        public string parStrNombre { get; set; }
        public string parStrContraseña { get; set; }

        //variables recuperar informacion
        public string St_rNombre { get; set; }
        public string StrContraseña { get; set; }
        public string strUsuario { get; set; }
        public int intCedula { get; set; }
        public string str_TipoCuenta { get; set; }
        public string str_NumeroCuenta { get; set; }
        public double dbl_SaldoCuenta { get; set; }
        //mtactualizar
        public string strNombre { get; set; }
        public string strCorreo { get; set; }
        public double dbl_Celular { get; set; }
        public string strDireccion { get; set; }
        public string strEmpleado { get; set; }

        //variables llenar cuenta
        public int Ced = 0;

         //variables botones login

        public string strBtnUno { get; set; }
        public string strbtnDos { get; set; }
        public string strbtnTres { get; set; }
        public string strbtnCuatro { get; set; }
        public string strbtnCinco { get; set; }
        public string strbtnSeis { get; set; }
        public string strbtnSiete { get; set; }
        public string strbtnOcho { get; set; }
        public string strbtnNueve { get; set; }
        public string strbtnCero { get; set; }
        //metodo registar movimientos
        public string strNombreCuenta { get; set; }
        public string strFechaMov { get; set; }
        public double dblValor { get; set; }
        public int intNumeroCuenta { get; set; }
    }
}
