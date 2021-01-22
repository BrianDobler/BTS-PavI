namespace BTS_3k2_2020.Pantallas.Asignaciones
{
    partial class FrmAsigXSueldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsigXSueldo));
            this.txtCantidad2 = new System.Windows.Forms.MaskedTextBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.ckbFecha = new System.Windows.Forms.CheckBox();
            this.descSueldos = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_asignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreAsignacion = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxRefrescar = new System.Windows.Forms.PictureBox();
            this.btnBuscarDescuento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmModificarDescuentos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.descSueldos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.BackColor = System.Drawing.Color.White;
            this.txtCantidad2.Location = new System.Drawing.Point(152, 229);
            this.txtCantidad2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad2.Mask = "99999";
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(257, 27);
            this.txtCantidad2.TabIndex = 53;
            this.txtCantidad2.ValidatingType = typeof(int);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(152, 192);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.Mask = "99999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(257, 27);
            this.txtMonto.TabIndex = 52;
            this.txtMonto.ValidatingType = typeof(int);
            // 
            // ckbFecha
            // 
            this.ckbFecha.AutoSize = true;
            this.ckbFecha.Location = new System.Drawing.Point(423, 76);
            this.ckbFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbFecha.Name = "ckbFecha";
            this.ckbFecha.Size = new System.Drawing.Size(15, 14);
            this.ckbFecha.TabIndex = 51;
            this.ckbFecha.UseVisualStyleBackColor = true;
            this.ckbFecha.CheckedChanged += new System.EventHandler(this.ckbFecha_CheckedChanged);
            // 
            // descSueldos
            // 
            this.descSueldos.AllowUserToDeleteRows = false;
            this.descSueldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.descSueldos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.descSueldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.descSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.descSueldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.n_asignacion,
            this.fecha,
            this.monto,
            this.cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.descSueldos.DefaultCellStyle = dataGridViewCellStyle2;
            this.descSueldos.Location = new System.Drawing.Point(488, 66);
            this.descSueldos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descSueldos.Name = "descSueldos";
            this.descSueldos.ReadOnly = true;
            this.descSueldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.descSueldos.Size = new System.Drawing.Size(536, 344);
            this.descSueldos.TabIndex = 48;
            this.descSueldos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbAsigSueld_CellContentClick);
            // 
            // usuario
            // 
            this.usuario.Frozen = true;
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 84;
            // 
            // n_asignacion
            // 
            this.n_asignacion.Frozen = true;
            this.n_asignacion.HeaderText = "Nombre Asignación";
            this.n_asignacion.Name = "n_asignacion";
            this.n_asignacion.ReadOnly = true;
            this.n_asignacion.Width = 162;
            // 
            // fecha
            // 
            this.fecha.Frozen = true;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 75;
            // 
            // monto
            // 
            this.monto.Frozen = true;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 75;
            // 
            // cantidad
            // 
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 97;
            // 
            // txtNombreAsignacion
            // 
            this.txtNombreAsignacion.BackColor = System.Drawing.Color.White;
            this.txtNombreAsignacion.Location = new System.Drawing.Point(152, 150);
            this.txtNombreAsignacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreAsignacion.Name = "txtNombreAsignacion";
            this.txtNombreAsignacion.Size = new System.Drawing.Size(257, 27);
            this.txtNombreAsignacion.TabIndex = 45;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.White;
            this.txtNombreUsuario.Location = new System.Drawing.Point(152, 109);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(257, 27);
            this.txtNombreUsuario.TabIndex = 44;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.LightBlue;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(152, 69);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(257, 27);
            this.dtpFecha.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBoxRefrescar);
            this.panel1.Controls.Add(this.ckbFecha);
            this.panel1.Controls.Add(this.txtCantidad2);
            this.panel1.Controls.Add(this.btnBuscarDescuento);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.txtNombreAsignacion);
            this.panel1.Controls.Add(this.txtNombreUsuario);
            this.panel1.Location = new System.Drawing.Point(14, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 344);
            this.panel1.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.label7.Location = new System.Drawing.Point(19, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(404, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ingrese los datos requeridos y seleccione lo que desea hacer.\r\n";
            // 
            // pictureBoxRefrescar
            // 
            this.pictureBoxRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescar.Image")));
            this.pictureBoxRefrescar.Location = new System.Drawing.Point(179, 282);
            this.pictureBoxRefrescar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxRefrescar.Name = "pictureBoxRefrescar";
            this.pictureBoxRefrescar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescar.TabIndex = 52;
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
            this.btnBuscarDescuento.Location = new System.Drawing.Point(226, 275);
            this.btnBuscarDescuento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscarDescuento.Name = "btnBuscarDescuento";
            this.btnBuscarDescuento.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarDescuento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarDescuento.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBuscarDescuento.selected = false;
            this.btnBuscarDescuento.Size = new System.Drawing.Size(160, 40);
            this.btnBuscarDescuento.TabIndex = 53;
            this.btnBuscarDescuento.Text = "Buscar";
            this.btnBuscarDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarDescuento.Textcolor = System.Drawing.Color.White;
            this.btnBuscarDescuento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDescuento.Click += new System.EventHandler(this.btnBuscarDescuento_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.label8.Location = new System.Drawing.Point(28, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nombre Usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.label9.Location = new System.Drawing.Point(8, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nombre Asginación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.label10.Location = new System.Drawing.Point(92, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Monto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.label11.Location = new System.Drawing.Point(70, 228);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.label12.Location = new System.Drawing.Point(92, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "Fecha:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(168, 23);
            this.bunifuCustomLabel1.TabIndex = 57;
            this.bunifuCustomLabel1.Text = "Asignaciones por Sueldo";
            // 
            // SalirFrmModificarDescuentos
            // 
            this.SalirFrmModificarDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmModificarDescuentos.Image")));
            this.SalirFrmModificarDescuentos.Location = new System.Drawing.Point(12, 12);
            this.SalirFrmModificarDescuentos.Name = "SalirFrmModificarDescuentos";
            this.SalirFrmModificarDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmModificarDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmModificarDescuentos.TabIndex = 56;
            this.SalirFrmModificarDescuentos.TabStop = false;
            this.SalirFrmModificarDescuentos.Click += new System.EventHandler(this.SalirFrmModificarDescuentos_Click);
            // 
            // FrmAsigXSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(1041, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmModificarDescuentos);
            this.Controls.Add(this.descSueldos);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAsigXSueldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsigXSueldo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAsigXSueldo_FormClosing);
            this.Load += new System.EventHandler(this.FrmAsigXSueldo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAsigXSueldo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.descSueldos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCantidad2;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.CheckBox ckbFecha;
        private System.Windows.Forms.DataGridView descSueldos;
        private System.Windows.Forms.TextBox txtNombreAsignacion;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_asignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxRefrescar;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarDescuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmModificarDescuentos;
    }
}