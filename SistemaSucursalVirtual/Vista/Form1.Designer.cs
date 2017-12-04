namespace Vista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.lblEnu = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnun2 = new System.Windows.Forms.Label();
            this.lblEnum1 = new System.Windows.Forms.Label();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.lblEnund = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlEnun = new System.Windows.Forms.Panel();
            this.lblEnun = new System.Windows.Forms.Label();
            this.pnlError = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.lblEnun3 = new System.Windows.Forms.Label();
            this.pnlOcultar = new System.Windows.Forms.Panel();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            this.pnlEnun.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.pnlOcultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.ptbUsuario);
            this.panel1.Controls.Add(this.lblEnu);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Location = new System.Drawing.Point(41, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 254);
            this.panel1.TabIndex = 0;
            // 
            // ptbUsuario
            // 
            this.ptbUsuario.BackgroundImage = global::Vista.Properties.Resources.usuario;
            this.ptbUsuario.Location = new System.Drawing.Point(29, 76);
            this.ptbUsuario.Name = "ptbUsuario";
            this.ptbUsuario.Size = new System.Drawing.Size(48, 41);
            this.ptbUsuario.TabIndex = 3;
            this.ptbUsuario.TabStop = false;
            // 
            // lblEnu
            // 
            this.lblEnu.AutoSize = true;
            this.lblEnu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEnu.Location = new System.Drawing.Point(25, 40);
            this.lblEnu.Name = "lblEnu";
            this.lblEnu.Size = new System.Drawing.Size(166, 25);
            this.lblEnu.TabIndex = 2;
            this.lblEnu.Text = "Ingrese su usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(75, 76);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(239, 41);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblEnun2);
            this.panel2.Controls.Add(this.lblEnum1);
            this.panel2.Controls.Add(this.pbContraseña);
            this.panel2.Controls.Add(this.lblEnund);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.txtContraseña);
            this.panel2.Location = new System.Drawing.Point(490, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 339);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(52, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite la clave que utiliza en el cajero automático";
            // 
            // lblEnun2
            // 
            this.lblEnun2.AutoSize = true;
            this.lblEnun2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnun2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEnun2.Location = new System.Drawing.Point(27, 96);
            this.lblEnun2.Name = "lblEnun2";
            this.lblEnun2.Size = new System.Drawing.Size(177, 15);
            this.lblEnun2.TabIndex = 4;
            this.lblEnun2.Text = "su seguridad no ingrese la clave.";
            this.lblEnun2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblEnum1
            // 
            this.lblEnum1.AutoSize = true;
            this.lblEnum1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnum1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEnum1.Location = new System.Drawing.Point(27, 76);
            this.lblEnum1.Name = "lblEnum1";
            this.lblEnum1.Size = new System.Drawing.Size(298, 15);
            this.lblEnum1.TabIndex = 4;
            this.lblEnum1.Text = "Si la imagen y la frase no son las que usted definió, por ";
            this.lblEnum1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbContraseña
            // 
            this.pbContraseña.Image = global::Vista.Properties.Resources.contraseña1;
            this.pbContraseña.Location = new System.Drawing.Point(30, 114);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(48, 41);
            this.pbContraseña.TabIndex = 3;
            this.pbContraseña.TabStop = false;
            // 
            // lblEnund
            // 
            this.lblEnund.AutoSize = true;
            this.lblEnund.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnund.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEnund.Location = new System.Drawing.Point(25, 26);
            this.lblEnund.Name = "lblEnund";
            this.lblEnund.Size = new System.Drawing.Size(146, 25);
            this.lblEnund.TabIndex = 2;
            this.lblEnund.Text = "Ingrese su clave";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackgroundImage = global::Vista.Properties.Resources.botn_ingresar;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(77, 208);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(88, 46);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Vista.Properties.Resources.boton_cancelar;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(195, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 46);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(77, 113);
            this.txtContraseña.MaxLength = 4;
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '•';
            this.txtContraseña.Size = new System.Drawing.Size(273, 41);
            this.txtContraseña.TabIndex = 0;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(47, 31);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(54, 34);
            this.btnUno.TabIndex = 1;
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(107, 31);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(54, 34);
            this.btnDos.TabIndex = 1;
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(167, 31);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(54, 34);
            this.btnTres.TabIndex = 1;
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(47, 71);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(54, 34);
            this.btnCuatro.TabIndex = 1;
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(107, 71);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(54, 34);
            this.btnCinco.TabIndex = 1;
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(167, 71);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(54, 34);
            this.btnSeis.TabIndex = 1;
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(47, 111);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(54, 34);
            this.btnSiete.TabIndex = 1;
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(107, 111);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(54, 34);
            this.btnOcho.TabIndex = 1;
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(167, 111);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(54, 34);
            this.btnNueve.TabIndex = 1;
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(47, 151);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(54, 34);
            this.btnCero.TabIndex = 1;
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(107, 151);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 34);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnlEnun
            // 
            this.pnlEnun.Controls.Add(this.lblEnun);
            this.pnlEnun.Location = new System.Drawing.Point(21, 90);
            this.pnlEnun.Name = "pnlEnun";
            this.pnlEnun.Size = new System.Drawing.Size(1290, 50);
            this.pnlEnun.TabIndex = 3;
            // 
            // lblEnun
            // 
            this.lblEnun.AutoSize = true;
            this.lblEnun.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnun.ForeColor = System.Drawing.Color.White;
            this.lblEnun.Location = new System.Drawing.Point(42, 9);
            this.lblEnun.Name = "lblEnun";
            this.lblEnun.Size = new System.Drawing.Size(290, 27);
            this.lblEnun.TabIndex = 0;
            this.lblEnun.Text = "Sucursal Virtual Personas";
            // 
            // pnlError
            // 
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Location = new System.Drawing.Point(21, 147);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(1290, 42);
            this.pnlError.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(34, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(25, 24);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "...";
            // 
            // lblEnun3
            // 
            this.lblEnun3.AutoSize = true;
            this.lblEnun3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnun3.ForeColor = System.Drawing.Color.Navy;
            this.lblEnun3.Location = new System.Drawing.Point(1067, 31);
            this.lblEnun3.Name = "lblEnun3";
            this.lblEnun3.Size = new System.Drawing.Size(244, 30);
            this.lblEnun3.TabIndex = 5;
            this.lblEnun3.Text = "Sucursal Virtual Personas";
            // 
            // pnlOcultar
            // 
            this.pnlOcultar.Controls.Add(this.btnTres);
            this.pnlOcultar.Controls.Add(this.btnUno);
            this.pnlOcultar.Controls.Add(this.btnCuatro);
            this.pnlOcultar.Controls.Add(this.btnSiete);
            this.pnlOcultar.Controls.Add(this.btnDos);
            this.pnlOcultar.Controls.Add(this.btnNueve);
            this.pnlOcultar.Controls.Add(this.btnCero);
            this.pnlOcultar.Controls.Add(this.btnSeis);
            this.pnlOcultar.Controls.Add(this.btnCinco);
            this.pnlOcultar.Controls.Add(this.btnOcho);
            this.pnlOcultar.Controls.Add(this.btnLimpiar);
            this.pnlOcultar.Location = new System.Drawing.Point(894, 259);
            this.pnlOcultar.Name = "pnlOcultar";
            this.pnlOcultar.Size = new System.Drawing.Size(267, 211);
            this.pnlOcultar.TabIndex = 6;
            this.pnlOcultar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOcultar_Paint);
            this.pnlOcultar.MouseLeave += new System.EventHandler(this.pnlOcultar_MouseLeave);
            this.pnlOcultar.MouseHover += new System.EventHandler(this.pnlOcultar_MouseHover);
            // 
            // pbImagen
            // 
            this.pbImagen.BackgroundImage = global::Vista.Properties.Resources.new1;
            this.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagen.Location = new System.Drawing.Point(21, 2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(192, 59);
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1340, 578);
            this.Controls.Add(this.pnlOcultar);
            this.Controls.Add(this.lblEnun3);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.pnlEnun);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            this.pnlEnun.ResumeLayout(false);
            this.pnlEnun.PerformLayout();
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            this.pnlOcultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEnu;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEnund;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel pnlEnun;
        private System.Windows.Forms.Label lblEnun;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.PictureBox pbContraseña;
        private System.Windows.Forms.Label lblEnun2;
        private System.Windows.Forms.Label lblEnum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblEnun3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel pnlOcultar;
    }
}

