namespace BTS_3k2_2020.Pantallas
{
    partial class FrmDescuentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDescuentos));
            this.dtbDescuentos = new System.Windows.Forms.DataGridView();
            this.id_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.SalirFrmDescuentos = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxRefrescar = new System.Windows.Forms.PictureBox();
            this.btnBuscarDescuento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnElimDesc = new System.Windows.Forms.Button();
            this.btnModifcarDesc = new System.Windows.Forms.Button();
            this.btnAgregrar = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnDescuentoAsign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtbDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtbDescuentos
            // 
            this.dtbDescuentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtbDescuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtbDescuentos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtbDescuentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtbDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbDescuentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_descuento,
            this.nombre,
            this.monto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtbDescuentos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtbDescuentos.Location = new System.Drawing.Point(58, 69);
            this.dtbDescuentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtbDescuentos.Name = "dtbDescuentos";
            this.dtbDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtbDescuentos.Size = new System.Drawing.Size(316, 357);
            this.dtbDescuentos.TabIndex = 4;
            // 
            // id_descuento
            // 
            this.id_descuento.Frozen = true;
            this.id_descuento.HeaderText = "ID Descuento";
            this.id_descuento.Name = "id_descuento";
            this.id_descuento.Width = 114;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 82;
            // 
            // monto
            // 
            this.monto.Frozen = true;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 70;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(221, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingrese los datos del DESCUENTO y seleccione lo que desea hacer.";
            // 
            // SalirFrmDescuentos
            // 
            this.SalirFrmDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmDescuentos.Image")));
            this.SalirFrmDescuentos.Location = new System.Drawing.Point(12, 13);
            this.SalirFrmDescuentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalirFrmDescuentos.Name = "SalirFrmDescuentos";
            this.SalirFrmDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmDescuentos.TabIndex = 16;
            this.SalirFrmDescuentos.TabStop = false;
            this.SalirFrmDescuentos.Click += new System.EventHandler(this.SalirFrmDescuentos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(461, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(461, 116);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonto.Mask = "99999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(192, 22);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.ValidatingType = typeof(int);
            // 
            // pictureBoxRefrescar
            // 
            this.pictureBoxRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescar.Image")));
            this.pictureBoxRefrescar.Location = new System.Drawing.Point(539, 214);
            this.pictureBoxRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxRefrescar.Name = "pictureBoxRefrescar";
            this.pictureBoxRefrescar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescar.TabIndex = 10;
            this.pictureBoxRefrescar.TabStop = false;
            this.pictureBoxRefrescar.Click += new System.EventHandler(this.pictureBoxRefrescar_Click);
            // 
            // btnBuscarDescuento
            // 
            this.btnBuscarDescuento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarDescuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarDescuento.BorderRadius = 0;
            this.btnBuscarDescuento.ButtonText = "Buscar";
            this.btnBuscarDescuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDescuento.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDescuento.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarDescuento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscarDescuento.Iconimage")));
            this.btnBuscarDescuento.Iconimage_right = null;
            this.btnBuscarDescuento.Iconimage_right_Selected = null;
            this.btnBuscarDescuento.Iconimage_Selected = null;
            this.btnBuscarDescuento.IconMarginLeft = 0;
            this.btnBuscarDescuento.IconMarginRight = 0;
            this.btnBuscarDescuento.IconRightVisible = true;
            this.btnBuscarDescuento.IconRightZoom = 0D;
            this.btnBuscarDescuento.IconVisible = true;
            this.btnBuscarDescuento.IconZoom = 40D;
            this.btnBuscarDescuento.IsTab = false;
            this.btnBuscarDescuento.Location = new System.Drawing.Point(487, 165);
            this.btnBuscarDescuento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscarDescuento.Name = "btnBuscarDescuento";
            this.btnBuscarDescuento.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarDescuento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarDescuento.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBuscarDescuento.selected = false;
            this.btnBuscarDescuento.Size = new System.Drawing.Size(138, 40);
            this.btnBuscarDescuento.TabIndex = 21;
            this.btnBuscarDescuento.Text = "Buscar";
            this.btnBuscarDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarDescuento.Textcolor = System.Drawing.Color.White;
            this.btnBuscarDescuento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDescuento.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // BtnElimDesc
            // 
            this.BtnElimDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnElimDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimDesc.Location = new System.Drawing.Point(462, 391);
            this.BtnElimDesc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnElimDesc.Name = "BtnElimDesc";
            this.BtnElimDesc.Size = new System.Drawing.Size(191, 35);
            this.BtnElimDesc.TabIndex = 24;
            this.BtnElimDesc.Text = "Eliminar";
            this.BtnElimDesc.UseVisualStyleBackColor = true;
            this.BtnElimDesc.Click += new System.EventHandler(this.BtnElimDesc_Click);
            // 
            // btnModifcarDesc
            // 
            this.btnModifcarDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifcarDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifcarDesc.Location = new System.Drawing.Point(461, 310);
            this.btnModifcarDesc.Name = "btnModifcarDesc";
            this.btnModifcarDesc.Size = new System.Drawing.Size(192, 35);
            this.btnModifcarDesc.TabIndex = 23;
            this.btnModifcarDesc.Text = "Modificar";
            this.btnModifcarDesc.UseVisualStyleBackColor = true;
            this.btnModifcarDesc.Click += new System.EventHandler(this.btnModificarDesc_Click);
            // 
            // btnAgregrar
            // 
            this.btnAgregrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregrar.Location = new System.Drawing.Point(462, 269);
            this.btnAgregrar.Name = "btnAgregrar";
            this.btnAgregrar.Size = new System.Drawing.Size(191, 35);
            this.btnAgregrar.TabIndex = 22;
            this.btnAgregrar.Text = "Agregar";
            this.btnAgregrar.UseVisualStyleBackColor = true;
            this.btnAgregrar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(80, 16);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Descuentos";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(461, 351);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(192, 35);
            this.btnAsignar.TabIndex = 43;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnDescuentoAsign
            // 
            this.btnDescuentoAsign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDescuentoAsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuentoAsign.Location = new System.Drawing.Point(109, 433);
            this.btnDescuentoAsign.Name = "btnDescuentoAsign";
            this.btnDescuentoAsign.Size = new System.Drawing.Size(191, 35);
            this.btnDescuentoAsign.TabIndex = 44;
            this.btnDescuentoAsign.Text = "Ver descuentos asignados";
            this.btnDescuentoAsign.UseVisualStyleBackColor = true;
            this.btnDescuentoAsign.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(207)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(684, 480);
            this.Controls.Add(this.btnDescuentoAsign);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.BtnElimDesc);
            this.Controls.Add(this.btnModifcarDesc);
            this.Controls.Add(this.btnAgregrar);
            this.Controls.Add(this.btnBuscarDescuento);
            this.Controls.Add(this.SalirFrmDescuentos);
            this.Controls.Add(this.pictureBoxRefrescar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtbDescuentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Descuentos";
            this.Load += new System.EventHandler(this.FrmDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtbDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtbDescuentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox SalirFrmDescuentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.PictureBox pictureBoxRefrescar;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarDescuento;
        private System.Windows.Forms.Button BtnElimDesc;
        private System.Windows.Forms.Button btnModifcarDesc;
        private System.Windows.Forms.Button btnAgregrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnDescuentoAsign;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
    }
}