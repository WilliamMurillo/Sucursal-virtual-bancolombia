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
    public partial class fmPrincipal : Form
    {
        #region variables

        private ClsControl objControl = null;
        private ClsVariables objVariables = null;
        private DataTable BD = null;
        private int intCedTemp = 0;
        private int NumCuenta = 0;
        private bool MiBool = false;
        private string btnActual = string.Empty;
        public int idCuenta = 0;
        #endregion

        #region contructores
        public fmPrincipal()
        {
            InitializeComponent();
        }
        #endregion
      
        #region metodos 
        private void fmPrincipal_Load(object sender, EventArgs e)
        {
                mtllenarInfoCuenta();
                mtDeshabilitarBotonesPago();
        }

        private void pnlSubPagos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }
        //metodo para dejar los txtbox vacios
        public void mtVaciar()
        {
            txtConfirmarContra.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtNuevaContra.Text = string.Empty;
            lblCorrectamente.ForeColor = Color.LightGray;
           
        }

        //metodo para habilitar botones de pago
        public void mtHabilitarBotonesPago()
        {
            btnPagoServicios.Visible = true;
            btnRetiroCajero.Visible = true;
            btntransferencia.Visible = true;
            btnPagoTarjetaCredito.Visible = true;
        }

        //metodo para deshabilitar botones de pago
        public void mtDeshabilitarBotonesPago()
        {
            btnPagoServicios.Visible = false;
            btnRetiroCajero.Visible = false;
            btntransferencia.Visible = false;
            btnPagoTarjetaCredito.Visible = false;
        }

        //metodo para el boton inicio
        private void mtBtnInicio()
        {
            dtgInfoCuenta.Show();
            pnlApoyo.Show();
            panelBotones.Hide();
            panelCambio.Hide();
            dgvMovimientos.Show();
            pnlAdor.Show();
            mtVaciar();
            
        }

        //este metodo llena la informacion basica (Load)
        public void mtllenarInfoCuenta()
        {
            try
            {
                objControl = new ClsControl(objVariables);
                BD = objControl.mtconsultaTemporales();
                intCedTemp = Convert.ToInt32(BD.Rows[0]["CedulaTemporal"].ToString());
                lblNom.Text = BD.Rows[0]["NombreTemporal"].ToString();
                dtgInfoCuenta.DataSource = objControl.mtExtracCuenta(intCedTemp);
                BD = new DataTable();
                BD = objControl.mtExtracCuenta(intCedTemp);
                idCuenta = Convert.ToInt32(BD.Rows[0]["idCuenta"].ToString());
                dtgInfoCuenta.ReadOnly = true;

                dtgInfoCuenta.Columns[0].HeaderText = "Id Cuenta";
                dtgInfoCuenta.Columns[1].HeaderText = "Tipo";
                dtgInfoCuenta.Columns[2].HeaderText = "Numero Cuenta";
                dtgInfoCuenta.Columns[3].HeaderText = "Saldo Disponible";

                dtgInfoCuenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvMovimientos.AllowUserToAddRows = false;
                dgvMovimientos.AllowUserToDeleteRows = false;
                dgvMovimientos.AllowUserToResizeColumns = false;
                dgvMovimientos.AllowUserToResizeRows = false;

                pnlBotones.BackColor = Color.SkyBlue;
                dgvMovimientos.BorderStyle = BorderStyle.None;
                pnlBotones.BackColor = Color.DarkBlue;
                pnlApoyo.BackColor = Color.SteelBlue;
                pnlAdor.BackColor = Color.White;

                dgvMovimientos.ColumnHeadersVisible = true;
                dtgInfoCuenta.ColumnHeadersVisible = true;

                panelBotones.Hide();
                panelCambio.Hide();

                pnlE.BackColor = Color.LightGray;
                lblCorrectamente.ForeColor = Color.LightGray;
                pnlSubPagos.Visible = false;
                lblFecha.Text = DateTime.Now.ToString();

                txtConfirmarContra.MaxLength = 4;
                txtNuevaContra.MaxLength = 4;
             
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrion un error inesperado intente la operación mas tarde");
            }
            
        }
     
        //este metodo da formato 
        public void mtDarFormato()
        {
            try
            {
                dgvMovimientos.ReadOnly = true;
                dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMovimientos.AllowUserToAddRows = false;
                dgvMovimientos.AllowUserToDeleteRows = false;
                dgvMovimientos.AllowUserToResizeColumns = false;
                dgvMovimientos.AllowUserToResizeRows = false;
                pnlAdor.BackColor = Color.SteelBlue;
                lblMovimiento.Text = "Movimientos Cuenta de Ahorro No " + NumCuenta;
                pxbSeleccionar.Hide();
            }
            catch (Exception e)
            {
                //controlar la excepcion de acuedo a la pag de bncombia
            }
            
        }

        //activar opciones btn actualizar
        private void mtCambiarContraseña()
        {
            try
            {
                if (txtNuevaContra.Text == txtConfirmarContra.Text && txtConfirmarContra.Text != string.Empty && txtNuevaContra.Text != string.Empty)
                {
                    objControl = new ClsControl(objVariables);
                    objControl.mtCambiarClav(lblNom.Text, txtNuevaContra.Text);
                    txtConfirmarContra.Text = string.Empty;
                    txtNuevaContra.Text = string.Empty;
                    mtCancelarCambioContra();
                    panelCambio.Hide();
                    lblCorrectamente.ForeColor = Color.DarkRed;
                }
                else
                {
                    txtNuevaContra.Text = string.Empty;
                    txtConfirmarContra.Text = string.Empty;
                    lblDeNuevo.Text = "Error, ingrese bien los datos.";

                }
            }
            catch (Exception e)
            {
                lblDeNuevo.Text = "Ocurrio un error, no se puedo ejecutar la operación";
            }
        }

        //metodo para descartivar las opciones de pago
        public void mtDescactivarOpcionesPago()
        {
            txtPagoServicios.Visible = false;
            btnPagarServicio.Visible = false;
        }

        //metodo para inhabilitar datgrid
        private void mtInhabilitarDataGrid()
        {
            lblCorrectamente.ForeColor = Color.LightGray;
            dtgInfoCuenta.Hide();
            dgvMovimientos.Hide();
            pnlAdor.Hide();
            pnlApoyo.Hide();
            panelBotones.Show();
            pxbSeleccionar.Hide();
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
        }

        //metodo para desactivar una operacion en proceso
        //y volver parcialmente al inicio
        private void mtCancelarCambioContra()
        {
            dtgInfoCuenta.Show();
            dgvMovimientos.Show();
            pnlAdor.Show();
            pnlApoyo.Show();
            panelBotones.Hide();
            txtContraseña.Text = string.Empty;
            lblDeNuevo.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            lblSubPanelError.Text = string.Empty;
            panelBotones.Hide();
            panelCambio.Hide();
            lblCorrectamente.ForeColor = Color.LightGray;
        }

        //metodo para Confirmar informacion contraseña para cambiarla
        public void mtConfimarC()
        {
            try
            {
                lblSubPanelError.Text = string.Empty;
                objVariables = new ClsVariables();
                objControl = new ClsControl(objVariables);
                objVariables.parStrNombre = lblNom.Text;
                objVariables.parStrContraseña = txtContraseña.Text;
                pxbSeleccionar.Hide();
                MiBool = objControl.mtConfimarClave(objVariables.parStrNombre, objVariables.parStrContraseña);
                
                if (MiBool == true)
                {
                    panelCambio.Show();
                    objVariables = new ClsVariables();
                    objControl = new ClsControl(objVariables);
                    objControl.mtAsignarNumeros();
                }
                else
                {
                    lblSubPanelError.Text = "ERROR, ingrese datos correctos";
                    txtContraseña.Text = string.Empty;
                    txtConfirmarContra.Text = string.Empty;
                    txtNuevaContra.Text = string.Empty;
                }
            }
            catch (Exception e)
            {
                lblSubPanelError.Text = "ERROR, ingrese datos correctos";
                txtContraseña.Text = string.Empty;
                
            }
        }

        //metodo para abrir el form para actualizar
        private void btnActuDatos_Click(object sender, EventArgs e)
        {
            fmActualizarDatos uno = new fmActualizarDatos();
            uno.Show();
            this.Hide();
            txtPagoServicios.Text = string.Empty;
            lblCorrectamente.ForeColor = Color.LightGray;
            mtDeshabilitarBotonesPago();
            pnlSubPagos.Visible = false;

        }

        //metodo para registrar los pagos
        public void mtRegistraPagos()
        {
            try
            {
                objControl = new ClsControl(objVariables);

                objControl.mtPagarServicios(btnActual, Convert.ToDouble(txtPagoServicios.Text), lblFecha.Text, idCuenta);

                //las siguientes tres lineas las hago para actualizar en tiempo
                //real la información de la cuenta
                BD = objControl.mtconsultaTemporales();
                int ced = Convert.ToInt32(BD.Rows[0]["CedulaTemporal"].ToString());
                dtgInfoCuenta.DataSource = objControl.mtExtracCuenta(ced);

                MessageBox.Show("La operacion se realizo con existo");
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            txtPagoServicios.Text = string.Empty;
            lblCorrectamente.ForeColor = Color.LightGray;
            mtHabilitarBotonesPago();
        }

        private void btnPagoTarjetaCredito_Click(object sender, EventArgs e)
        {
            txtPagoServicios.Text = string.Empty;
            pnlSubPagos.Visible = true;
            btnActual = btnPagoTarjetaCredito.Text;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            txtPagoServicios.Text = string.Empty;
            mtBtnInicio();
            mtDeshabilitarBotonesPago();
            pnlSubPagos.Visible = false;
        }

        private void btnPagoServicios_Click(object sender, EventArgs e)
        {
            pnlSubPagos.Visible = true;
            btnActual = btnPagoServicios.Text;
            txtPagoServicios.Text = string.Empty;
        }

        private void btnRetiroCajero_Click(object sender, EventArgs e)
        {
            txtPagoServicios.Text = string.Empty;
            pnlSubPagos.Visible = true;
            btnActual = btnRetiroCajero.Text;
        }

        private void btntransferencia_Click(object sender, EventArgs e)
        {
            txtPagoServicios.Text = string.Empty;
            pnlSubPagos.Visible = true;
            btnActual = btntransferencia.Text;
        }

        private void btnPagarServicio_Click(object sender, EventArgs e)
        {
            if (txtPagoServicios.Text != string.Empty)
            {
                mtRegistraPagos();
                txtPagoServicios.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error, intentelo de nuevo");
                txtPagoServicios.Text = string.Empty;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblSubPanelError.Text = string.Empty;
            mtCancelarCambioContra();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            mtConfimarC();
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            txtPagoServicios.Text = string.Empty;
            mtInhabilitarDataGrid();
            mtDeshabilitarBotonesPago();
            pnlSubPagos.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNuevaContra.Text = string.Empty;
            txtConfirmarContra.Text = string.Empty;
            mtCancelarCambioContra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mtCambiarContraseña();
        }

        #region metodos Default vacios

        private void lblDeNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void panelCambio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPagoServicios_TextChanged(object sender, EventArgs e)
        {

        }

        private void subPanelContr_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnUno_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnUno.Text;
        }

        private void btnTres_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnTres.Text;
        }

        private void btnDos_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnDos.Text;

        }

        private void btnCuatro_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnCuatro.Text;
        }

        private void btnCinco_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnCinco.Text;
        }

        private void btnSeis_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnSeis.Text;
        }

        private void btnSiete_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnSiete.Text;
        }

        private void btnOcho_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnOcho.Text;
        }

        private void btnNueve_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnNueve.Text;
        }

        private void btnCero_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text += btnCero.Text;
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtContraseña.Text = string.Empty;
        }

        private void dtgInfoCuenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvMovimientos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 UNO = new Form1();
            UNO.Show();
            this.Hide();
        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlApoyo_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion

        #region validaciones

        private void dtgInfoCuenta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                objControl = new ClsControl(objVariables);
                DataGridView gridView = (sender as DataGridView);
                DataGridViewRow row = gridView.Rows[e.RowIndex];

                idCuenta = Convert.ToInt32(row.Cells["idCuenta"].Value.ToString());
                NumCuenta = Convert.ToInt32(row.Cells["int_NumeroCuenta"].Value.ToString());

                //asignar una variable para que entre como parametro al metodo pagar servicios
                dgvMovimientos.DataSource = objControl.mtSacarMovi(NumCuenta);
                dgvMovimientos.BorderStyle = BorderStyle.FixedSingle;
                dgvMovimientos.Columns[0].HeaderText = "Transacción";
                dgvMovimientos.Columns[1].HeaderText = "Fecha";
                dgvMovimientos.Columns[2].HeaderText = "Valor";

                mtDarFormato();
            }
            catch (Exception ec)
            {
                lblDeNuevo.Text = "Ocurrio un error, no se puedo ejecutar la operación";
            }
        }

        private void txtNuevaContra_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void dtgInfoCuenta_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void txtPagoServicios_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNuevaContra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtConfirmarContra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        #endregion
    }
}
