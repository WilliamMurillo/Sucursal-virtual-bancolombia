using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vista
{
    public partial class Form1 : Form
    {
        #region variables

        private ClsControl objControl = null;
        private ClsVariables objVariables = null;
        private bool miBool = false;
        #endregion

        #region contructores
        public Form1()
        {
            
            InitializeComponent();
            
        }
        #endregion

        #region metodos

         private void Form1_Load(object sender, EventArgs e)
        {
                mtNumeros();
        }

        //este metodo sirve para asignar los numeros a el teclado en pantalla
        public void mtNumeros()
        {
            try
            {
                objVariables = new ClsVariables();
                objControl = new ClsControl(objVariables);
           
                objControl.mtAsignarNumeros();
               
                btnUno.Text = objVariables.strBtnUno;
                btnDos.Text = objVariables.strbtnDos;
                btnTres.Text = objVariables.strbtnTres;
                btnCuatro.Text = objVariables.strbtnCuatro;
                btnCinco.Text = objVariables.strbtnCinco;
                btnSeis.Text = objVariables.strbtnSeis;
                btnSiete.Text = objVariables.strbtnSiete;
                btnOcho.Text = objVariables.strbtnOcho;
                btnNueve.Text = objVariables.strbtnNueve;
                btnCero.Text = objVariables.strbtnCero;
                pnlEnun.BackColor = Color.DarkBlue;
                pnlError.BackColor = Color.White;
                lblError.Text = string.Empty;
                txtContraseña.MaxLength = 4;
                lblEnun3.Text = "Sucursal Virtual Personas";
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error, intente ejecutar la operacion mas tarde");
            }
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }

        //default
        private void btnIngresar_Click(object sender, EventArgs e)
        {
           try
            {
                objVariables.parStrContraseña = txtContraseña.Text;
                txtContraseña.Text = string.Empty;
                objVariables.parStrNombre = txtUsuario.Text;
                txtUsuario.Text = string.Empty;
                objControl = new ClsControl(objVariables);
                objControl.mtLoginControl();
                miBool = objControl.mtConfirmacionLogin();

                if (miBool == true)
                {
                    fmPrincipal uno = new fmPrincipal();
                    uno.Show();
                    this.Hide();
                }
            }
           catch (Exception ex)
            {
                pnlError.BackColor = Color.LightPink;
                lblError.Text = "Error, alguno de los datos que ingreso no es correcto. Ingrese información valida";
                lblError.ForeColor = Color.Black;
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnUno.Text;
        }

        private void pnlOcultar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnDos.Text;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnTres.Text;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnCuatro.Text;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnCinco.Text;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnSeis.Text;
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnSiete.Text;
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnOcho.Text;
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnNueve.Text;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtContraseña.Text += btnCero.Text;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = string.Empty;
        }

        //validaciones
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private void pnlOcultar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pnlOcultar_MouseHover(object sender, EventArgs e)
        {
        
        }


        
    }
}
