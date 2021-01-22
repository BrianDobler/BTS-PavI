namespace BTS_3k2_2020.Pantallas.UsuariosXCursos
{
    partial class FrmNuevoUsuarioXCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoUsuarioXCurso));
            this.btnGuardarModDesc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.LblPuntaje = new System.Windows.Forms.Label();
            this.LblFechaInicio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CbUsuarios = new System.Windows.Forms.ComboBox();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TxtPuntaje = new System.Windows.Forms.TextBox();
            this.LblCurso = new System.Windows.Forms.Label();
            this.CbCursos = new System.Windows.Forms.ComboBox();
            this.LblFechaFin = new System.Windows.Forms.Label();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.SalirFrmListadoUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarModDesc
            // 
            this.btnGuardarModDesc.Activecolor = System.Drawing.Color.Transparent;
            this.btnGuardarModDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarModDesc.BorderRadius = 0;
            this.btnGuardarModDesc.ButtonText = "Agregar";
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
            this.btnGuardarModDesc.Location = new System.Drawing.Point(250, 396);
            this.btnGuardarModDesc.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.btnGuardarModDesc.Name = "btnGuardarModDesc";
            this.btnGuardarModDesc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModDesc.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarModDesc.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGuardarModDesc.selected = false;
            this.btnGuardarModDesc.Size = new System.Drawing.Size(180, 48);
            this.btnGuardarModDesc.TabIndex = 69;
            this.btnGuardarModDesc.Text = "Agregar";
            this.btnGuardarModDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarModDesc.Textcolor = System.Drawing.Color.White;
            this.btnGuardarModDesc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModDesc.Click += new System.EventHandler(this.btnGuardarModDesc_Click);
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.LblNombreUsuario.Location = new System.Drawing.Point(19, 145);
            this.LblNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(172, 28);
            this.LblNombreUsuario.TabIndex = 68;
            this.LblNombreUsuario.Text = "Nombre del Usuario:";
            // 
            // LblPuntaje
            // 
            this.LblPuntaje.AutoSize = true;
            this.LblPuntaje.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntaje.ForeColor = System.Drawing.Color.White;
            this.LblPuntaje.Location = new System.Drawing.Point(115, 226);
            this.LblPuntaje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPuntaje.Name = "LblPuntaje";
            this.LblPuntaje.Size = new System.Drawing.Size(75, 28);
            this.LblPuntaje.TabIndex = 67;
            this.LblPuntaje.Text = "Puntaje:";
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.LblFechaInicio.Location = new System.Drawing.Point(56, 305);
            this.LblFechaInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(135, 28);
            this.LblFechaInicio.TabIndex = 66;
            this.LblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 23);
            this.label6.TabIndex = 65;
            this.label6.Text = "Completa los siguientes campos para asignar un usuario a un curso .";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(58, 18);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(168, 23);
            this.LblTitulo.TabIndex = 64;
            this.LblTitulo.Text = "Nuevo Usuario por Curso";
            // 
            // CbUsuarios
            // 
            this.CbUsuarios.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbUsuarios.FormattingEnabled = true;
            this.CbUsuarios.Location = new System.Drawing.Point(201, 142);
            this.CbUsuarios.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.CbUsuarios.Name = "CbUsuarios";
            this.CbUsuarios.Size = new System.Drawing.Size(293, 30);
            this.CbUsuarios.TabIndex = 63;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaInicio.Location = new System.Drawing.Point(201, 306);
            this.DtpFechaInicio.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(293, 27);
            this.DtpFechaInicio.TabIndex = 62;
            // 
            // TxtPuntaje
            // 
            this.TxtPuntaje.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntaje.Location = new System.Drawing.Point(201, 226);
            this.TxtPuntaje.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.TxtPuntaje.Name = "TxtPuntaje";
            this.TxtPuntaje.Size = new System.Drawing.Size(293, 27);
            this.TxtPuntaje.TabIndex = 61;
            // 
            // LblCurso
            // 
            this.LblCurso.AutoSize = true;
            this.LblCurso.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurso.ForeColor = System.Drawing.Color.White;
            this.LblCurso.Location = new System.Drawing.Point(129, 186);
            this.LblCurso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCurso.Name = "LblCurso";
            this.LblCurso.Size = new System.Drawing.Size(61, 28);
            this.LblCurso.TabIndex = 71;
            this.LblCurso.Text = "Curso:";
            // 
            // CbCursos
            // 
            this.CbCursos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCursos.FormattingEnabled = true;
            this.CbCursos.Location = new System.Drawing.Point(201, 185);
            this.CbCursos.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.CbCursos.Name = "CbCursos";
            this.CbCursos.Size = new System.Drawing.Size(293, 30);
            this.CbCursos.TabIndex = 70;
            // 
            // LblFechaFin
            // 
            this.LblFechaFin.AutoSize = true;
            this.LblFechaFin.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaFin.ForeColor = System.Drawing.Color.White;
            this.LblFechaFin.Location = new System.Drawing.Point(76, 345);
            this.LblFechaFin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaFin.Name = "LblFechaFin";
            this.LblFechaFin.Size = new System.Drawing.Size(115, 28);
            this.LblFechaFin.TabIndex = 73;
            this.LblFechaFin.Text = "Fecha de Fin:";
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaFin.Location = new System.Drawing.Point(201, 346);
            this.DtpFechaFin.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(293, 27);
            this.DtpFechaFin.TabIndex = 72;
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.ForeColor = System.Drawing.Color.White;
            this.LblObservaciones.Location = new System.Drawing.Point(55, 265);
            this.LblObservaciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(135, 28);
            this.LblObservaciones.TabIndex = 75;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(201, 265);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(293, 27);
            this.TxtObservaciones.TabIndex = 74;
            // 
            // SalirFrmListadoUsuario
            // 
            this.SalirFrmListadoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmListadoUsuario.Image")));
            this.SalirFrmListadoUsuario.Location = new System.Drawing.Point(13, 13);
            this.SalirFrmListadoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.SalirFrmListadoUsuario.Name = "SalirFrmListadoUsuario";
            this.SalirFrmListadoUsuario.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmListadoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmListadoUsuario.TabIndex = 76;
            this.SalirFrmListadoUsuario.TabStop = false;
            this.SalirFrmListadoUsuario.Click += new System.EventHandler(this.SalirFrmListadoUsuario_Click);
            // 
            // FrmNuevoUsuarioXCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(523, 464);
            this.Controls.Add(this.SalirFrmListadoUsuario);
            this.Controls.Add(this.LblObservaciones);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.LblFechaFin);
            this.Controls.Add(this.DtpFechaFin);
            this.Controls.Add(this.LblCurso);
            this.Controls.Add(this.CbCursos);
            this.Controls.Add(this.btnGuardarModDesc);
            this.Controls.Add(this.LblNombreUsuario);
            this.Controls.Add(this.LblPuntaje);
            this.Controls.Add(this.LblFechaInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.CbUsuarios);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.TxtPuntaje);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNuevoUsuarioXCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevoUsuarioXCurso";
            this.Load += new System.EventHandler(this.FrmNuevoUsuarioXCurso_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmNuevoUsuarioXCurso_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarModDesc;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Label LblPuntaje;
        private System.Windows.Forms.Label LblFechaInicio;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomLabel LblTitulo;
        private System.Windows.Forms.ComboBox CbUsuarios;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.TextBox TxtPuntaje;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.ComboBox CbCursos;
        private System.Windows.Forms.Label LblFechaFin;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.PictureBox SalirFrmListadoUsuario;
    }
}