namespace BTS_3k2_2020.Pantallas.Categorias
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarCategoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SalirFrmListadoUsuario = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreUs = new System.Windows.Forms.Label();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvCategoria = new System.Windows.Forms.DataGridView();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkIncluirInactivos = new System.Windows.Forms.CheckBox();
            this.TxtNombreCat = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdCat = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxRefrescar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBuscarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCategoria.BorderRadius = 0;
            this.btnBuscarCategoria.ButtonText = "Buscar";
            this.btnBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCategoria.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarCategoria.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCategoria.Iconimage")));
            this.btnBuscarCategoria.Iconimage_right = null;
            this.btnBuscarCategoria.Iconimage_right_Selected = null;
            this.btnBuscarCategoria.Iconimage_Selected = null;
            this.btnBuscarCategoria.IconMarginLeft = 0;
            this.btnBuscarCategoria.IconMarginRight = 0;
            this.btnBuscarCategoria.IconRightVisible = true;
            this.btnBuscarCategoria.IconRightZoom = 0D;
            this.btnBuscarCategoria.IconVisible = true;
            this.btnBuscarCategoria.IconZoom = 40D;
            this.btnBuscarCategoria.IsTab = false;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(490, 224);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarCategoria.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(193)))));
            this.btnBuscarCategoria.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBuscarCategoria.selected = false;
            this.btnBuscarCategoria.Size = new System.Drawing.Size(138, 40);
            this.btnBuscarCategoria.TabIndex = 31;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarCategoria.Textcolor = System.Drawing.Color.White;
            this.btnBuscarCategoria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // SalirFrmListadoUsuario
            // 
            this.SalirFrmListadoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmListadoUsuario.Image")));
            this.SalirFrmListadoUsuario.Location = new System.Drawing.Point(14, 18);
            this.SalirFrmListadoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalirFrmListadoUsuario.Name = "SalirFrmListadoUsuario";
            this.SalirFrmListadoUsuario.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmListadoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmListadoUsuario.TabIndex = 30;
            this.SalirFrmListadoUsuario.TabStop = false;
            this.SalirFrmListadoUsuario.Click += new System.EventHandler(this.SalirFrmListadoUsuario_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Descripción:";
            // 
            // lblNombreUs
            // 
            this.lblNombreUs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUs.AutoSize = true;
            this.lblNombreUs.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUs.Location = new System.Drawing.Point(386, 113);
            this.lblNombreUs.Name = "lblNombreUs";
            this.lblNombreUs.Size = new System.Drawing.Size(76, 25);
            this.lblNombreUs.TabIndex = 28;
            this.lblNombreUs.Text = "Nombre:";
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarBaja.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDarBaja.Location = new System.Drawing.Point(467, 400);
            this.BtnDarBaja.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(191, 35);
            this.BtnDarBaja.TabIndex = 27;
            this.BtnDarBaja.Text = "Eliminar";
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            this.BtnDarBaja.Click += new System.EventHandler(this.BtnDarBaja_Click_1);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(467, 355);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(191, 35);
            this.BtnModificar.TabIndex = 26;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(467, 310);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(191, 35);
            this.BtnAgregar.TabIndex = 25;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvCategoria
            // 
            this.DgvCategoria.AllowUserToAddRows = false;
            this.DgvCategoria.AllowUserToDeleteRows = false;
            this.DgvCategoria.AllowUserToResizeColumns = false;
            this.DgvCategoria.AllowUserToResizeRows = false;
            this.DgvCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCategoria.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_categoria,
            this.Nombre,
            this.Descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCategoria.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvCategoria.Location = new System.Drawing.Point(49, 77);
            this.DgvCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DgvCategoria.MultiSelect = false;
            this.DgvCategoria.Name = "DgvCategoria";
            this.DgvCategoria.ReadOnly = true;
            this.DgvCategoria.RowHeadersWidth = 51;
            this.DgvCategoria.RowTemplate.Height = 24;
            this.DgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCategoria.Size = new System.Drawing.Size(303, 358);
            this.DgvCategoria.TabIndex = 24;
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "ID Categoria";
            this.id_categoria.MinimumWidth = 6;
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Width = 102;
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
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 99;
            // 
            // ChkIncluirInactivos
            // 
            this.ChkIncluirInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkIncluirInactivos.AutoSize = true;
            this.ChkIncluirInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkIncluirInactivos.Location = new System.Drawing.Point(531, 186);
            this.ChkIncluirInactivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChkIncluirInactivos.Name = "ChkIncluirInactivos";
            this.ChkIncluirInactivos.Size = new System.Drawing.Size(127, 17);
            this.ChkIncluirInactivos.TabIndex = 23;
            this.ChkIncluirInactivos.Text = "Mostrar desactivados";
            this.ChkIncluirInactivos.UseVisualStyleBackColor = true;
            this.ChkIncluirInactivos.CheckedChanged += new System.EventHandler(this.ChkIncluirInactivos_CheckedChanged);
            // 
            // TxtNombreCat
            // 
            this.TxtNombreCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreCat.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCat.Location = new System.Drawing.Point(467, 112);
            this.TxtNombreCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNombreCat.Name = "TxtNombreCat";
            this.TxtNombreCat.Size = new System.Drawing.Size(191, 29);
            this.TxtNombreCat.TabIndex = 21;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(76, 21);
            this.bunifuCustomLabel1.TabIndex = 43;
            this.bunifuCustomLabel1.Text = "Categoría";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(216, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ingrese los datos de la CATEGORÍA y seleccione lo que desea hacer.";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescripcion.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(467, 145);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(191, 29);
            this.TxtDescripcion.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            // 
            // TxtIdCat
            // 
            this.TxtIdCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIdCat.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCat.Location = new System.Drawing.Point(467, 78);
            this.TxtIdCat.Mask = "99999999";
            this.TxtIdCat.Name = "TxtIdCat";
            this.TxtIdCat.Size = new System.Drawing.Size(191, 29);
            this.TxtIdCat.TabIndex = 48;
            this.TxtIdCat.ValidatingType = typeof(int);
            this.TxtIdCat.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtIdCat_MaskInputRejected);
            // 
            // pictureBoxRefrescar
            // 
            this.pictureBoxRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescar.Image")));
            this.pictureBoxRefrescar.Location = new System.Drawing.Point(553, 275);
            this.pictureBoxRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxRefrescar.Name = "pictureBoxRefrescar";
            this.pictureBoxRefrescar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescar.TabIndex = 49;
            this.pictureBoxRefrescar.TabStop = false;
            this.pictureBoxRefrescar.Click += new System.EventHandler(this.pictureBoxRefrescar_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(207)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(684, 480);
            this.Controls.Add(this.pictureBoxRefrescar);
            this.Controls.Add(this.TxtIdCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.SalirFrmListadoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreUs);
            this.Controls.Add(this.BtnDarBaja);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvCategoria);
            this.Controls.Add(this.ChkIncluirInactivos);
            this.Controls.Add(this.TxtNombreCat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarCategoria;
        private System.Windows.Forms.PictureBox SalirFrmListadoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreUs;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvCategoria;
        private System.Windows.Forms.CheckBox ChkIncluirInactivos;
        private System.Windows.Forms.TextBox TxtNombreCat;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.MaskedTextBox TxtIdCat;
        private System.Windows.Forms.PictureBox pictureBoxRefrescar;
    }
}