namespace BTS_3k2_2020.Pantallas.UsuariosXCursos
{
    partial class FrmUsuariosXCursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuariosXCursos));
            this.DgvUsuariosXCursos = new System.Windows.Forms.DataGridView();
            this.Id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LblNombreCurso = new System.Windows.Forms.Label();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtPuntaje = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblPuntaje = new System.Windows.Forms.Label();
            this.CbCursos = new System.Windows.Forms.ComboBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmListadoUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefrescar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuariosXCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUsuariosXCursos
            // 
            this.DgvUsuariosXCursos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DgvUsuariosXCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuariosXCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUsuariosXCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuariosXCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_usuario,
            this.Usuario,
            this.Id_curso,
            this.Curso,
            this.Puntuacion,
            this.Observaciones,
            this.Fecha_Inicio,
            this.Fecha_Fin});
            this.DgvUsuariosXCursos.Location = new System.Drawing.Point(13, 241);
            this.DgvUsuariosXCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvUsuariosXCursos.MaximumSize = new System.Drawing.Size(838, 226);
            this.DgvUsuariosXCursos.MinimumSize = new System.Drawing.Size(623, 226);
            this.DgvUsuariosXCursos.Name = "DgvUsuariosXCursos";
            this.DgvUsuariosXCursos.Size = new System.Drawing.Size(623, 226);
            this.DgvUsuariosXCursos.TabIndex = 2;
            this.DgvUsuariosXCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuariosXCursos_CellContentClick);
            // 
            // Id_usuario
            // 
            this.Id_usuario.HeaderText = "ID Usuario";
            this.Id_usuario.Name = "Id_usuario";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Id_curso
            // 
            this.Id_curso.HeaderText = "ID Curso";
            this.Id_curso.Name = "Id_curso";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // Puntuacion
            // 
            this.Puntuacion.HeaderText = "Puntaje";
            this.Puntuacion.Name = "Puntuacion";
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.HeaderText = "Fecha Inicio";
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.HeaderText = "Fecha Fin";
            this.Fecha_Fin.Name = "Fecha_Fin";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.BorderRadius = 0;
            this.btnBuscar.ButtonText = "Buscar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Iconimage")));
            this.btnBuscar.Iconimage_right = null;
            this.btnBuscar.Iconimage_right_Selected = null;
            this.btnBuscar.Iconimage_Selected = null;
            this.btnBuscar.IconMarginLeft = 0;
            this.btnBuscar.IconMarginRight = 0;
            this.btnBuscar.IconRightVisible = true;
            this.btnBuscar.IconRightZoom = 0D;
            this.btnBuscar.IconVisible = true;
            this.btnBuscar.IconZoom = 40D;
            this.btnBuscar.IsTab = false;
            this.btnBuscar.Location = new System.Drawing.Point(225, 194);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5, 12, 5, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBuscar.selected = false;
            this.btnBuscar.Size = new System.Drawing.Size(172, 35);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Textcolor = System.Drawing.Color.White;
            this.btnBuscar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LblNombreCurso
            // 
            this.LblNombreCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblNombreCurso.AutoSize = true;
            this.LblNombreCurso.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCurso.Location = new System.Drawing.Point(50, 105);
            this.LblNombreCurso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombreCurso.Name = "LblNombreCurso";
            this.LblNombreCurso.Size = new System.Drawing.Size(128, 25);
            this.LblNombreCurso.TabIndex = 60;
            this.LblNombreCurso.Text = "Nombre Curso: ";
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.Location = new System.Drawing.Point(41, 67);
            this.LblNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(136, 25);
            this.LblNombreUsuario.TabIndex = 58;
            this.LblNombreUsuario.Text = "Nombre Usuario:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(455, 143);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(182, 35);
            this.BtnEliminar.TabIndex = 57;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtPuntaje
            // 
            this.TxtPuntaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtPuntaje.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntaje.Location = new System.Drawing.Point(188, 145);
            this.TxtPuntaje.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtPuntaje.Name = "TxtPuntaje";
            this.TxtPuntaje.Size = new System.Drawing.Size(257, 32);
            this.TxtPuntaje.TabIndex = 62;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(455, 103);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(182, 35);
            this.BtnModificar.TabIndex = 56;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(455, 60);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(182, 35);
            this.BtnAgregar.TabIndex = 55;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblPuntaje
            // 
            this.LblPuntaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPuntaje.AutoSize = true;
            this.LblPuntaje.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntaje.Location = new System.Drawing.Point(96, 145);
            this.LblPuntaje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPuntaje.Name = "LblPuntaje";
            this.LblPuntaje.Size = new System.Drawing.Size(72, 25);
            this.LblPuntaje.TabIndex = 54;
            this.LblPuntaje.Text = "Puntaje:";
            // 
            // CbCursos
            // 
            this.CbCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CbCursos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCursos.FormattingEnabled = true;
            this.CbCursos.Location = new System.Drawing.Point(188, 105);
            this.CbCursos.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CbCursos.Name = "CbCursos";
            this.CbCursos.Size = new System.Drawing.Size(257, 27);
            this.CbCursos.TabIndex = 66;
            this.CbCursos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.Location = new System.Drawing.Point(188, 65);
            this.TxtNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(257, 29);
            this.TxtNombreUsuario.TabIndex = 67;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 20);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(141, 21);
            this.bunifuCustomLabel1.TabIndex = 69;
            this.bunifuCustomLabel1.Text = "Usuarios por Cursos";
            // 
            // SalirFrmListadoUsuario
            // 
            this.SalirFrmListadoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmListadoUsuario.Image")));
            this.SalirFrmListadoUsuario.Location = new System.Drawing.Point(13, 13);
            this.SalirFrmListadoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.SalirFrmListadoUsuario.Name = "SalirFrmListadoUsuario";
            this.SalirFrmListadoUsuario.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmListadoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmListadoUsuario.TabIndex = 68;
            this.SalirFrmListadoUsuario.TabStop = false;
            this.SalirFrmListadoUsuario.Click += new System.EventHandler(this.SalirFrmListadoUsuario_Click);
            // 
            // pictureBoxRefrescar
            // 
            this.pictureBoxRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescar.Image")));
            this.pictureBoxRefrescar.Location = new System.Drawing.Point(420, 194);
            this.pictureBoxRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxRefrescar.Name = "pictureBoxRefrescar";
            this.pictureBoxRefrescar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescar.TabIndex = 70;
            this.pictureBoxRefrescar.TabStop = false;
            this.pictureBoxRefrescar.Click += new System.EventHandler(this.pictureBoxRefrescar_Click);
            // 
            // FrmUsuariosXCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(207)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(648, 480);
            this.Controls.Add(this.pictureBoxRefrescar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmListadoUsuario);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.CbCursos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.LblNombreCurso);
            this.Controls.Add(this.LblNombreUsuario);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtPuntaje);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblPuntaje);
            this.Controls.Add(this.DgvUsuariosXCursos);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(648, 480);
            this.Name = "FrmUsuariosXCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuariosXCursos";
            this.Load += new System.EventHandler(this.FrmUsuariosXCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuariosXCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuariosXCursos;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscar;
        private System.Windows.Forms.Label LblNombreCurso;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtPuntaje;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblPuntaje;
        private System.Windows.Forms.ComboBox CbCursos;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmListadoUsuario;
        private System.Windows.Forms.PictureBox pictureBoxRefrescar;
    }
}