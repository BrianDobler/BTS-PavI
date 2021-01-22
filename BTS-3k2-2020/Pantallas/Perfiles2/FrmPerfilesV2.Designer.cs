namespace BTS_3k2_2020.Pantallas.Perfiles2
{
    partial class FrmPerfilesV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilesV2));
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.Id_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalirFrmListadoPerfiles = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarPerfil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblNombrePerfil = new System.Windows.Forms.Label();
            this.lblIdPerfil = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxRefrescar = new System.Windows.Forms.PictureBox();
            this.ChkIncluirInactivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPerfiles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_perfil,
            this.nombre});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerfiles.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPerfiles.Location = new System.Drawing.Point(57, 65);
            this.dgvPerfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerfiles.Size = new System.Drawing.Size(262, 371);
            this.dgvPerfiles.TabIndex = 5;
            this.dgvPerfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerfiles_CellContentClick);
            // 
            // Id_perfil
            // 
            this.Id_perfil.HeaderText = "ID";
            this.Id_perfil.Name = "Id_perfil";
            this.Id_perfil.Width = 47;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 87;
            // 
            // SalirFrmListadoPerfiles
            // 
            this.SalirFrmListadoPerfiles.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmListadoPerfiles.Image")));
            this.SalirFrmListadoPerfiles.Location = new System.Drawing.Point(13, 14);
            this.SalirFrmListadoPerfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalirFrmListadoPerfiles.Name = "SalirFrmListadoPerfiles";
            this.SalirFrmListadoPerfiles.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmListadoPerfiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmListadoPerfiles.TabIndex = 16;
            this.SalirFrmListadoPerfiles.TabStop = false;
            this.SalirFrmListadoPerfiles.Click += new System.EventHandler(this.SalirFrmListadoPerfiles_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(464, 104);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 27);
            this.txtNombre.TabIndex = 17;
            // 
            // btnBuscarPerfil
            // 
            this.btnBuscarPerfil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPerfil.BorderRadius = 0;
            this.btnBuscarPerfil.ButtonText = "Buscar";
            this.btnBuscarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPerfil.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPerfil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarPerfil.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPerfil.Iconimage")));
            this.btnBuscarPerfil.Iconimage_right = null;
            this.btnBuscarPerfil.Iconimage_right_Selected = null;
            this.btnBuscarPerfil.Iconimage_Selected = null;
            this.btnBuscarPerfil.IconMarginLeft = 0;
            this.btnBuscarPerfil.IconMarginRight = 0;
            this.btnBuscarPerfil.IconRightVisible = true;
            this.btnBuscarPerfil.IconRightZoom = 0D;
            this.btnBuscarPerfil.IconVisible = true;
            this.btnBuscarPerfil.IconZoom = 60D;
            this.btnBuscarPerfil.IsTab = false;
            this.btnBuscarPerfil.Location = new System.Drawing.Point(485, 186);
            this.btnBuscarPerfil.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.btnBuscarPerfil.Name = "btnBuscarPerfil";
            this.btnBuscarPerfil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarPerfil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.btnBuscarPerfil.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBuscarPerfil.selected = false;
            this.btnBuscarPerfil.Size = new System.Drawing.Size(138, 40);
            this.btnBuscarPerfil.TabIndex = 21;
            this.btnBuscarPerfil.Text = "Buscar";
            this.btnBuscarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarPerfil.Textcolor = System.Drawing.Color.White;
            this.btnBuscarPerfil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPerfil.Click += new System.EventHandler(this.btnBuscarPerfil_Click);
            // 
            // lblNombrePerfil
            // 
            this.lblNombrePerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombrePerfil.AutoSize = true;
            this.lblNombrePerfil.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePerfil.Location = new System.Drawing.Point(380, 105);
            this.lblNombrePerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePerfil.Name = "lblNombrePerfil";
            this.lblNombrePerfil.Size = new System.Drawing.Size(75, 26);
            this.lblNombrePerfil.TabIndex = 22;
            this.lblNombrePerfil.Text = "Nombre:";
            // 
            // lblIdPerfil
            // 
            this.lblIdPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdPerfil.AutoSize = true;
            this.lblIdPerfil.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPerfil.Location = new System.Drawing.Point(425, 65);
            this.lblIdPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPerfil.Name = "lblIdPerfil";
            this.lblIdPerfil.Size = new System.Drawing.Size(30, 26);
            this.lblIdPerfil.TabIndex = 23;
            this.lblIdPerfil.Text = "ID:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(464, 302);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(190, 38);
            this.BtnAgregar.TabIndex = 25;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Modificar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(464, 350);
            this.Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(190, 38);
            this.Modificar.TabIndex = 26;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(464, 398);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 38);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(57, 21);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 23);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Perfiles";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(259, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ingrese los datos del PERFIL y seleccione lo que desea hacer.";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(464, 65);
            this.txtID.Mask = "99999999";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(190, 27);
            this.txtID.TabIndex = 44;
            this.txtID.ValidatingType = typeof(int);
            this.txtID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtID_MaskInputRejected);
            // 
            // pictureBoxRefrescar
            // 
            this.pictureBoxRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescar.Image")));
            this.pictureBoxRefrescar.Location = new System.Drawing.Point(540, 240);
            this.pictureBoxRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxRefrescar.Name = "pictureBoxRefrescar";
            this.pictureBoxRefrescar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescar.TabIndex = 45;
            this.pictureBoxRefrescar.TabStop = false;
            this.pictureBoxRefrescar.Click += new System.EventHandler(this.pictureBoxRefrescar_Click);
            // 
            // ChkIncluirInactivos
            // 
            this.ChkIncluirInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkIncluirInactivos.AutoSize = true;
            this.ChkIncluirInactivos.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkIncluirInactivos.Location = new System.Drawing.Point(508, 142);
            this.ChkIncluirInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.ChkIncluirInactivos.Name = "ChkIncluirInactivos";
            this.ChkIncluirInactivos.Size = new System.Drawing.Size(146, 23);
            this.ChkIncluirInactivos.TabIndex = 46;
            this.ChkIncluirInactivos.Text = "Mostrar desactivados";
            this.ChkIncluirInactivos.UseVisualStyleBackColor = true;
            this.ChkIncluirInactivos.CheckedChanged += new System.EventHandler(this.ChkIncluirInactivos_CheckedChanged);
            // 
            // FrmPerfilesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(207)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(684, 480);
            this.Controls.Add(this.ChkIncluirInactivos);
            this.Controls.Add(this.pictureBoxRefrescar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.lblIdPerfil);
            this.Controls.Add(this.lblNombrePerfil);
            this.Controls.Add(this.btnBuscarPerfil);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.SalirFrmListadoPerfiles);
            this.Controls.Add(this.dgvPerfiles);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmPerfilesV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.FrmPerfilesV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.PictureBox SalirFrmListadoPerfiles;
        private System.Windows.Forms.TextBox txtNombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarPerfil;
        private System.Windows.Forms.Label lblNombrePerfil;
        private System.Windows.Forms.Label lblIdPerfil;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.PictureBox pictureBoxRefrescar;
        private System.Windows.Forms.CheckBox ChkIncluirInactivos;
    }
}