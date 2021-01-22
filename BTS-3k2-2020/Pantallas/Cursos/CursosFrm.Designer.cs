namespace BTS_3k2_2020.Pantallas.Cursos
{
    partial class CursosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursosFrm));
            this.TxtCurso = new System.Windows.Forms.TextBox();
            this.DgvCursos = new System.Windows.Forms.DataGridView();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoCategoria = new System.Windows.Forms.ComboBox();
            this.CkIncluirInactivos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCursos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SalirFrmListadoCursado = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.chkSinCateg = new System.Windows.Forms.CheckBox();
            this.pictureBoxRefrescar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoCursado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCurso
            // 
            this.TxtCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCurso.Location = new System.Drawing.Point(492, 75);
            this.TxtCurso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtCurso.Name = "TxtCurso";
            this.TxtCurso.Size = new System.Drawing.Size(190, 24);
            this.TxtCurso.TabIndex = 1;
            // 
            // DgvCursos
            // 
            this.DgvCursos.AllowUserToAddRows = false;
            this.DgvCursos.AllowUserToDeleteRows = false;
            this.DgvCursos.AllowUserToResizeColumns = false;
            this.DgvCursos.AllowUserToResizeRows = false;
            this.DgvCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCursos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_curso,
            this.Nombre,
            this.Descripcion,
            this.fecha_vigencia});
            this.DgvCursos.Location = new System.Drawing.Point(43, 70);
            this.DgvCursos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DgvCursos.MultiSelect = false;
            this.DgvCursos.Name = "DgvCursos";
            this.DgvCursos.ReadOnly = true;
            this.DgvCursos.RowHeadersWidth = 51;
            this.DgvCursos.RowTemplate.Height = 24;
            this.DgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCursos.Size = new System.Drawing.Size(305, 357);
            this.DgvCursos.TabIndex = 6;
            this.DgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCursos_CellContentClick);
            // 
            // id_curso
            // 
            this.id_curso.HeaderText = "Id";
            this.id_curso.MinimumWidth = 6;
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            this.id_curso.Visible = false;
            this.id_curso.Width = 42;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 77;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 97;
            // 
            // fecha_vigencia
            // 
            this.fecha_vigencia.HeaderText = "Vigencia";
            this.fecha_vigencia.Name = "fecha_vigencia";
            this.fecha_vigencia.ReadOnly = true;
            this.fecha_vigencia.Visible = false;
            this.fecha_vigencia.Width = 79;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(491, 318);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(190, 35);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(491, 273);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(190, 35);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(491, 409);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(190, 35);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Categoria: ";
            // 
            // TipoCategoria
            // 
            this.TipoCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoCategoria.FormattingEnabled = true;
            this.TipoCategoria.Location = new System.Drawing.Point(492, 136);
            this.TipoCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TipoCategoria.Name = "TipoCategoria";
            this.TipoCategoria.Size = new System.Drawing.Size(190, 23);
            this.TipoCategoria.TabIndex = 13;
            // 
            // CkIncluirInactivos
            // 
            this.CkIncluirInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CkIncluirInactivos.AutoSize = true;
            this.CkIncluirInactivos.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkIncluirInactivos.Location = new System.Drawing.Point(571, 108);
            this.CkIncluirInactivos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CkIncluirInactivos.Name = "CkIncluirInactivos";
            this.CkIncluirInactivos.Size = new System.Drawing.Size(115, 23);
            this.CkIncluirInactivos.TabIndex = 14;
            this.CkIncluirInactivos.Text = "Incluir Inactivos";
            this.CkIncluirInactivos.UseVisualStyleBackColor = true;
            this.CkIncluirInactivos.CheckedChanged += new System.EventHandler(this.CkIncluirInactivos_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre Curso:";
            // 
            // btnBuscarCursos
            // 
            this.btnBuscarCursos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCursos.BorderRadius = 0;
            this.btnBuscarCursos.ButtonText = "Buscar";
            this.btnBuscarCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCursos.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCursos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarCursos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCursos.Iconimage")));
            this.btnBuscarCursos.Iconimage_right = null;
            this.btnBuscarCursos.Iconimage_right_Selected = null;
            this.btnBuscarCursos.Iconimage_Selected = null;
            this.btnBuscarCursos.IconMarginLeft = 0;
            this.btnBuscarCursos.IconMarginRight = 0;
            this.btnBuscarCursos.IconRightVisible = true;
            this.btnBuscarCursos.IconRightZoom = 0D;
            this.btnBuscarCursos.IconVisible = true;
            this.btnBuscarCursos.IconZoom = 40D;
            this.btnBuscarCursos.IsTab = false;
            this.btnBuscarCursos.Location = new System.Drawing.Point(526, 198);
            this.btnBuscarCursos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscarCursos.Name = "btnBuscarCursos";
            this.btnBuscarCursos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarCursos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarCursos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBuscarCursos.selected = false;
            this.btnBuscarCursos.Size = new System.Drawing.Size(138, 34);
            this.btnBuscarCursos.TabIndex = 19;
            this.btnBuscarCursos.Text = "Buscar";
            this.btnBuscarCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCursos.Textcolor = System.Drawing.Color.White;
            this.btnBuscarCursos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCursos.Click += new System.EventHandler(this.btnBuscarCursos_Click);
            // 
            // SalirFrmListadoCursado
            // 
            this.SalirFrmListadoCursado.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmListadoCursado.Image")));
            this.SalirFrmListadoCursado.Location = new System.Drawing.Point(12, 13);
            this.SalirFrmListadoCursado.Name = "SalirFrmListadoCursado";
            this.SalirFrmListadoCursado.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmListadoCursado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmListadoCursado.TabIndex = 20;
            this.SalirFrmListadoCursado.TabStop = false;
            this.SalirFrmListadoCursado.Click += new System.EventHandler(this.SalirFrmListadoCursado_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(55, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(116, 16);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Listado de Cursos";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(298, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ingrese los datos del CURSO y seleccione lo que desea hacer.";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(91, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 32);
            this.button1.TabIndex = 59;
            this.button1.Text = "Ver cursos por Categoría";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(491, 364);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(191, 34);
            this.btnAsignar.TabIndex = 58;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // chkSinCateg
            // 
            this.chkSinCateg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSinCateg.AutoSize = true;
            this.chkSinCateg.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinCateg.Location = new System.Drawing.Point(539, 172);
            this.chkSinCateg.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkSinCateg.Name = "chkSinCateg";
            this.chkSinCateg.Size = new System.Drawing.Size(144, 23);
            this.chkSinCateg.TabIndex = 60;
            this.chkSinCateg.Text = "Mostrar sin categoría";
            this.chkSinCateg.UseVisualStyleBackColor = true;
            this.chkSinCateg.CheckedChanged += new System.EventHandler(this.chkSinCateg_CheckedChanged);
            // 
            // pictureBoxRefrescar
            // 
            this.pictureBoxRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescar.Image")));
            this.pictureBoxRefrescar.Location = new System.Drawing.Point(578, 236);
            this.pictureBoxRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxRefrescar.Name = "pictureBoxRefrescar";
            this.pictureBoxRefrescar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescar.TabIndex = 61;
            this.pictureBoxRefrescar.TabStop = false;
            this.pictureBoxRefrescar.Click += new System.EventHandler(this.pictureBoxRefrescar_Click);
            // 
            // CursosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(207)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(709, 480);
            this.Controls.Add(this.pictureBoxRefrescar);
            this.Controls.Add(this.chkSinCateg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalirFrmListadoCursado);
            this.Controls.Add(this.btnBuscarCursos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CkIncluirInactivos);
            this.Controls.Add(this.TipoCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvCursos);
            this.Controls.Add(this.TxtCurso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "CursosFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoCursos";
            this.Load += new System.EventHandler(this.ListadoCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoCursado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtCurso;
        private System.Windows.Forms.DataGridView DgvCursos;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoCategoria;
        private System.Windows.Forms.CheckBox CkIncluirInactivos;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarCursos;
        private System.Windows.Forms.PictureBox SalirFrmListadoCursado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.CheckBox chkSinCateg;
        private System.Windows.Forms.PictureBox pictureBoxRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vigencia;
    }
}