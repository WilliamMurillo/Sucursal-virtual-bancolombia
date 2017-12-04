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
    public partial class fmActualizarDatos : Form
    {
        #region variables

        private ClsControl objControl = null;
        private ClsVariables objVariables = null;
        private DataTable BD = null;
        private int intCedTemp = 0;
        private int NumCuenta = 0;
        private bool MiBool = false;
        private string btnActual = string.Empty;
        #endregion

        #region constructores
        public fmActualizarDatos()
        {
            InitializeComponent();
        }
        #endregion

        #region metodos comunes

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fmPrincipal uno = new fmPrincipal();
            uno.Show();
            this.Hide();
        }

        private void btnIngresarActu_Click_1(object sender, EventArgs e)
        {
            mtComprobarDatos();
            mtBlanqueaBotones();
        }

        private void mtBlanqueaBotones()
        {
            txtCelularActu.Text = string.Empty;
            txtCorreoActu.Text = string.Empty;
            txtDirecciónActu.Text = string.Empty;
            txtNombreActu.Text = string.Empty;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fmActualizarDatos_Load(object sender, EventArgs e)
        {
            cmbEmpleadoActu.Items.Add("Si");
            cmbEmpleadoActu.Items.Add("No");
            txtCelularActu.MaxLength = 10;
            txtCorreoActu.MaxLength = 50;
            txtDirecciónActu.MaxLength = 50;
            txtNombreActu.MaxLength = 50;

        }
        private void lbEmpleadoActu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresarActu_Click(object sender, EventArgs e)
        {
            
             
        }

        public void mtComprobarDatos()
        {
            try
            {
                if (txtNombreActu.Text == string.Empty || txtCorreoActu.Text == string.Empty || txtCelularActu.Text == string.Empty || txtDirecciónActu.Text == string.Empty)
                {
                    lblErrorActu.Text = "Error, ingrese la totalidad de los campos en forma correcta";
                }
                else
                {
                    mtActualizar();
                    txtCelularActu.Text = string.Empty;
                    txtCorreoActu.Text = string.Empty;
                    txtDirecciónActu.Text = string.Empty;
                    txtNombreActu.Text = string.Empty;

                    lblErrorActu.Text = "Los datos se modificarón correctamente";
                    
                }
            }
            catch (Exception e)
            {
                lblErrorActu.Text = "Ocurrio un error inesperado, vuelva a intentarlo en 5 minutos.";
            }
        }
        private void mtActualizar()
        {
            try
            {
                objControl = new ClsControl(objVariables);
                BD = objControl.mtconsultaTemporales();
                intCedTemp = Convert.ToInt32(BD.Rows[0]["CedulaTemporal"].ToString());

                objControl.mtActualizarDatos(intCedTemp, txtNombreActu.Text, txtCorreoActu.Text, txtDirecciónActu.Text, double.Parse(txtCelularActu.Text), cmbEmpleadoActu.Text);
            }
            catch (Exception e)
            {

            }
        }
        #endregion

        #region metodos para validaciones
        private void txtNombreActu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        private void txtCelularActu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void cmbEmpleadoActu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtCorreoActu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }
        #endregion
    }
}
