namespace BTS_3k2_2020.Pantallas.Perfiles2
{
    partial class FrmModificarPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarPerfil));
            this.lblNombrePerfil = new System.Windows.Forms.Label();
            this.lblNombrePerfilActual = new System.Windows.Forms.Label();
            this.txtNombreActual = new System.Windows.Forms.TextBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmNuevoUsuario = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarModDesc = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmNuevoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePerfil
            // 
            this.lblNombrePerfil.AutoSize = true;
            this.lblNombrePerfil.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePerfil.ForeColor = System.Drawing.Color.White;
            this.lblNombrePerfil.Location = new System.Drawing.Point(19, 165);
            this.lblNombrePerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePerfil.Name = "lblNombrePerfil";
            this.lblNombrePerfil.Size = new System.Drawing.Size(222, 28);
            this.lblNombrePerfil.TabIndex = 43;
            this.lblNombrePerfil.Text = "Nuevo nombre de perfil (*)";
            // 
            // lblNombrePerfilActual
            // 
            this.lblNombrePerfilActual.AutoSize = true;
            this.lblNombrePerfilActual.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePerfilActual.ForeColor = System.Drawing.Color.White;
            this.lblNombrePerfilActual.Location = new System.Drawing.Point(37, 119);
            this.lblNombrePerfilActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePerfilActual.Name = "lblNombrePerfilActual";
            this.lblNombrePerfilActual.Size = new System.Drawing.Size(204, 28);
            this.lblNombrePerfilActual.TabIndex = 44;
            this.lblNombrePerfilActual.Text = "Nombre de perfil actual:";
            // 
            // txtNombreActual
            // 
            this.txtNombreActual.Enabled = false;
            this.txtNombreActual.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreActual.Location = new System.Drawing.Point(249, 119);
            this.txtNombreActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreActual.Name = "txtNombreActual";
            this.txtNombreActual.ReadOnly = true;
            this.txtNombreActual.Size = new System.Drawing.Size(221, 27);
            this.txtNombreActual.TabIndex = 45;
            this.txtNombreActual.TextChanged += new System.EventHandler(this.txtNombreActual_TextChanged);
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoNombre.Location = new System.Drawing.Point(249, 164);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(221, 27);
            this.txtNuevoNombre.TabIndex = 46;
            this.txtNuevoNombre.TextChanged += new System.EventHandler(this.txtNuevoNombre_TextChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 23);
            this.bunifuCustomLabel1.TabIndex = 49;
            this.bunifuCustomLabel1.Text = "Modificar Perfil";
            // 
            // SalirFrmNuevoUsuario
            // 
            this.SalirFrmNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmNuevoUsuario.Image")));
            this.SalirFrmNuevoUsuario.Location = new System.Drawing.Point(12, 12);
            this.SalirFrmNuevoUsuario.Name = "SalirFrmNuevoUsuario";
            this.SalirFrmNuevoUsuario.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmNuevoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmNuevoUsuario.TabIndex = 48;
            this.SalirFrmNuevoUsuario.TabStop = false;
            this.SalirFrmNuevoUsuario.Click += new System.EventHandler(this.SalirFrmNuevoUsuario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(91, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "Completa los siguientes campos para modificar el PERFIL.";
            // 
            // btnGuardarModDesc
            // 
            this.btnGuardarModDesc.Activecolor = System.Drawing.Color.Transparent;
            this.btnGuardarModDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarModDesc.BorderRadius = 0;
            this.btnGuardarModDesc.ButtonText = "Guardar";
            this.btnGuardarModDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarModDesc.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarModDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModDesc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarModDesc.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarModDesc.Iconimage")));
            this.btnGuardarModDesc.Iconimage_right = null;
            this.btnGuardarModDesc.Iconimage_right_Selected = null;
            this.btnGuardarModDesc.Iconimage_Selected = null;
            this.btnGuardarModDesc.IconMarginLeft = 0;
            this.btnGuardarModDesc.IconMarginRight = 0;
            this.btnGuardarModDesc.IconRightVisible = true;
            this.btnGuardarModDesc.IconRightZoom = 0D;
            this.btnGuardarModDesc.IconVisible = true;
            this.btnGuardarModDesc.IconZoom = 40D;
            this.btnGuardarModDesc.IsTab = false;
            this.btnGuardarModDesc.Location = new System.Drawing.Point(280, 213);
            this.btnGuardarModDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarModDesc.Name = "btnGuardarModDesc";
            this.btnGuardarModDesc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModDesc.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarModDesc.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGuardarModDesc.selected = false;
            this.btnGuardarModDesc.Size = new System.Drawing.Size(158, 48);
            this.btnGuardarModDesc.TabIndex = 51;
            this.btnGuardarModDesc.Text = "Guardar";
            this.btnGuardarModDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarModDesc.Textcolor = System.Drawing.Color.White;
            this.btnGuardarModDesc.TextFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModDesc.Click += new System.EventHandler(this.btnGuardarModDesc_Click);
            // 
            // FrmModificarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(495, 284);
            this.Controls.Add(this.btnGuardarModDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmNuevoUsuario);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.txtNombreActual);
            this.Controls.Add(this.lblNombrePerfilActual);
            this.Controls.Add(this.lblNombrePerfil);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModificarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarPerfil";
            this.Load += new System.EventHandler(this.FrmModificarPerfil_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmModificarPerfil_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmNuevoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombrePerfil;
        private System.Windows.Forms.Label lblNombrePerfilActual;
        private System.Windows.Forms.TextBox txtNombreActual;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmNuevoUsuario;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarModDesc;
    }
}