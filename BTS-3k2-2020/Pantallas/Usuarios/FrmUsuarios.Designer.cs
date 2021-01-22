namespace BTS_3k2_2020.Pantallas.Usuarios
{
    partial class FrmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TipoPerfil = new System.Windows.Forms.ComboBox();
            this.ChkIncluirInactivos = new System.Windows.Forms.CheckBox();
            this.DgvCursos = new System.Windows.Forms.DataGridView();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.lblNombreUs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SalirFrmListadoUsuario = new System.Windows.Forms.PictureBox();
            this.btnBuscarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).BeginInit();
            this.PanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(454, 67);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(190, 32);
            this.TxtNombre.TabIndex = 1;
            // 
            // TipoPerfil
            // 
            this.TipoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPerfil.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoPerfil.FormattingEnabled = true;
            this.TipoPerfil.Location = new System.Drawing.Point(454, 128);
            this.TipoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.TipoPerfil.Name = "TipoPerfil";
            this.TipoPerfil.Size = new System.Drawing.Size(190, 29);
            this.TipoPerfil.TabIndex = 3;
            // 
            // ChkIncluirInactivos
            // 
            this.ChkIncluirInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkIncluirInactivos.AutoSize = true;
            this.ChkIncluirInactivos.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkIncluirInactivos.Location = new System.Drawing.Point(502, 102);
            this.ChkIncluirInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.ChkIncluirInactivos.Name = "ChkIncluirInactivos";
            this.ChkIncluirInactivos.Size = new System.Drawing.Size(145, 22);
            this.ChkIncluirInactivos.TabIndex = 4;
            this.ChkIncluirInactivos.Text = "Mostrar desactivados";
            this.ChkIncluirInactivos.UseVisualStyleBackColor = true;
            this.ChkIncluirInactivos.CheckedChanged += new System.EventHandler(this.ChkIncluirInactivos_CheckedChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.usuario,
            this.email});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCursos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCursos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvCursos.Location = new System.Drawing.Point(58, 67);
            this.DgvCursos.MultiSelect = false;
            this.DgvCursos.Name = "DgvCursos";
            this.DgvCursos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCursos.RowHeadersWidth = 51;
            this.DgvCursos.RowTemplate.Height = 24;
            this.DgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCursos.Size = new System.Drawing.Size(302, 379);
            this.DgvCursos.TabIndex = 5;
            this.DgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellContentClick);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(454, 369);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(190, 35);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarBaja.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDarBaja.Location = new System.Drawing.Point(454, 411);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(190, 35);
            this.BtnDarBaja.TabIndex = 12;
            this.BtnDarBaja.Text = "Eliminar";
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click);
            // 
            // lblNombreUs
            // 
            this.lblNombreUs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUs.AutoSize = true;
            this.lblNombreUs.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUs.Location = new System.Drawing.Point(367, 69);
            this.lblNombreUs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUs.Name = "lblNombreUs";
            this.lblNombreUs.Size = new System.Drawing.Size(76, 25);
            this.lblNombreUs.TabIndex = 13;
            this.lblNombreUs.Text = "Nombre:";
            this.lblNombreUs.Click += new System.EventHandler(this.lblNombreUs_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Perfil:";
            // 
            // SalirFrmListadoUsuario
            // 
            this.SalirFrmListadoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmListadoUsuario.Image")));
            this.SalirFrmListadoUsuario.Location = new System.Drawing.Point(12, 13);
            this.SalirFrmListadoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.SalirFrmListadoUsuario.Name = "SalirFrmListadoUsuario";
            this.SalirFrmListadoUsuario.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmListadoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmListadoUsuario.TabIndex = 15;
            this.SalirFrmListadoUsuario.TabStop = false;
            this.SalirFrmListadoUsuario.Click += new System.EventHandler(this.btnSalirUsuario_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarUsuario.BorderRadius = 0;
            this.btnBuscarUsuario.ButtonText = "Buscar";
            this.btnBuscarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuario.Iconimage")));
            this.btnBuscarUsuario.Iconimage_right = null;
            this.btnBuscarUsuario.Iconimage_right_Selected = null;
            this.btnBuscarUsuario.Iconimage_Selected = null;
            this.btnBuscarUsuario.IconMarginLeft = 0;
            this.btnBuscarUsuario.IconMarginRight = 0;
            this.btnBuscarUsuario.IconRightVisible = true;
            this.btnBuscarUsuario.IconRightZoom = 0D;
            this.btnBuscarUsuario.IconVisible = true;
            this.btnBuscarUsuario.IconZoom = 40D;
            this.btnBuscarUsuario.IsTab = false;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(481, 190);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarUsuario.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.selected = false;
            this.btnBuscarUsuario.Size = new System.Drawing.Size(138, 40);
            this.btnBuscarUsuario.TabIndex = 20;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarUsuario.Textcolor = System.Drawing.Color.White;
            this.btnBuscarUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(55, 20);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(110, 21);
            this.bunifuCustomLabel1.TabIndex = 41;
            this.bunifuCustomLabel1.Text = "Listado Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(235, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ingrese los datos del USUARIO y seleccione lo que desea hacer.";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(454, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 38);
            this.button1.TabIndex = 43;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelUser
            // 
            this.PanelUser.Controls.Add(this.pictureBox1);
            this.PanelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUser.Location = new System.Drawing.Point(0, 0);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(684, 480);
            this.PanelUser.TabIndex = 44;
            this.PanelUser.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelUser_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 242);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "Id";
            this.id_usuario.MinimumWidth = 6;
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            this.id_usuario.Width = 51;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Nombre";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 96;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.ToolTipText = "Tool tip Email";
            this.email.Width = 78;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(207)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(684, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.SalirFrmListadoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreUs);
            this.Controls.Add(this.BtnDarBaja);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.DgvCursos);
            this.Controls.Add(this.ChkIncluirInactivos);
            this.Controls.Add(this.TipoPerfil);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.PanelUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).EndInit();
            this.PanelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox TipoPerfil;
        private System.Windows.Forms.CheckBox ChkIncluirInactivos;
        private System.Windows.Forms.DataGridView DgvCursos;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Label lblNombreUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox SalirFrmListadoUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}