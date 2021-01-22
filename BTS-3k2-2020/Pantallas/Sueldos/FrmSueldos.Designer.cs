namespace BTS_3k2_2020.Pantallas.Sueldos
{
    partial class FrmSueldos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSueldos));
            this.BtnVerDet = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblSueldo = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DgvSueldos = new System.Windows.Forms.DataGridView();
            this.Id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo_bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblIdUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVerDetalle = new System.Windows.Forms.Button();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmListadoUsuario = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtSueldo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSueldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVerDet
            // 
            this.BtnVerDet.Location = new System.Drawing.Point(653, -87);
            this.BtnVerDet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVerDet.Name = "BtnVerDet";
            this.BtnVerDet.Size = new System.Drawing.Size(171, 83);
            this.BtnVerDet.TabIndex = 40;
            this.BtnVerDet.Text = "Ver Detalle";
            this.BtnVerDet.UseVisualStyleBackColor = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(253, -41);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(321, 27);
            this.TxtNombre.TabIndex = 39;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(19, -41);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(137, 23);
            this.LblNombre.TabIndex = 38;
            this.LblNombre.Text = "Nombre del Usuario";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(532, 430);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(184, 38);
            this.BtnEliminar.TabIndex = 36;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(253, -97);
            this.TxtIdUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(321, 27);
            this.TxtIdUsuario.TabIndex = 35;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificar.Location = new System.Drawing.Point(532, 382);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(184, 38);
            this.BtnModificar.TabIndex = 33;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Location = new System.Drawing.Point(532, 337);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(184, 38);
            this.BtnAgregar.TabIndex = 32;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblSueldo
            // 
            this.LblSueldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSueldo.AutoSize = true;
            this.LblSueldo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSueldo.Location = new System.Drawing.Point(457, 148);
            this.LblSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSueldo.Name = "LblSueldo";
            this.LblSueldo.Size = new System.Drawing.Size(67, 26);
            this.LblSueldo.TabIndex = 31;
            this.LblSueldo.Text = "Sueldo:";
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(463, 186);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(61, 26);
            this.LblFecha.TabIndex = 30;
            this.LblFecha.Text = "Fecha:";
            // 
            // DgvSueldos
            // 
            this.DgvSueldos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvSueldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvSueldos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.DgvSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSueldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_usuario,
            this.Nombre_Usuario,
            this.Fecha,
            this.Sueldo_bruto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSueldos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSueldos.Location = new System.Drawing.Point(23, 77);
            this.DgvSueldos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvSueldos.Name = "DgvSueldos";
            this.DgvSueldos.Size = new System.Drawing.Size(415, 363);
            this.DgvSueldos.TabIndex = 28;
            // 
            // Id_usuario
            // 
            this.Id_usuario.HeaderText = "ID";
            this.Id_usuario.Name = "Id_usuario";
            this.Id_usuario.ReadOnly = true;
            this.Id_usuario.Width = 47;
            // 
            // Nombre_Usuario
            // 
            this.Nombre_Usuario.HeaderText = "Nombre Usuario";
            this.Nombre_Usuario.Name = "Nombre_Usuario";
            this.Nombre_Usuario.ReadOnly = true;
            this.Nombre_Usuario.Width = 139;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 75;
            // 
            // Sueldo_bruto
            // 
            this.Sueldo_bruto.HeaderText = "Sueldo Bruto";
            this.Sueldo_bruto.Name = "Sueldo_bruto";
            this.Sueldo_bruto.ReadOnly = true;
            this.Sueldo_bruto.Width = 115;
            // 
            // LblIdUsuario
            // 
            this.LblIdUsuario.AutoSize = true;
            this.LblIdUsuario.Location = new System.Drawing.Point(19, -85);
            this.LblIdUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdUsuario.Name = "LblIdUsuario";
            this.LblIdUsuario.Size = new System.Drawing.Size(94, 23);
            this.LblIdUsuario.TabIndex = 26;
            this.LblIdUsuario.Text = "Id de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, -57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 25;
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnVerDetalle.Location = new System.Drawing.Point(134, 447);
            this.BtnVerDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(179, 34);
            this.BtnVerDetalle.TabIndex = 55;
            this.BtnVerDetalle.Text = "Ver Detalle";
            this.BtnVerDetalle.UseVisualStyleBackColor = true;
            this.BtnVerDetalle.Click += new System.EventHandler(this.BtnVerDetalle_Click);
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreUsuario.Location = new System.Drawing.Point(532, 110);
            this.TxtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(184, 27);
            this.TxtNombreUsuario.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nombre: ";
            // 
            // TxtId_Usuario
            // 
            this.TxtId_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtId_Usuario.Location = new System.Drawing.Point(532, 73);
            this.TxtId_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtId_Usuario.Name = "TxtId_Usuario";
            this.TxtId_Usuario.Size = new System.Drawing.Size(184, 27);
            this.TxtId_Usuario.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 41;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFecha.CustomFormat = "dd/MM/yyyy";
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(532, 184);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(184, 27);
            this.DtpFecha.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(313, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ingrese los datos del USUARIO y seleccione lo que desea hacer.";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 20);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(60, 23);
            this.bunifuCustomLabel1.TabIndex = 50;
            this.bunifuCustomLabel1.Text = "Sueldos";
            // 
            // SalirFrmListadoUsuario
            // 
            this.SalirFrmListadoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmListadoUsuario.Image")));
            this.SalirFrmListadoUsuario.Location = new System.Drawing.Point(13, 13);
            this.SalirFrmListadoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.SalirFrmListadoUsuario.Name = "SalirFrmListadoUsuario";
            this.SalirFrmListadoUsuario.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmListadoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmListadoUsuario.TabIndex = 49;
            this.SalirFrmListadoUsuario.TabStop = false;
            this.SalirFrmListadoUsuario.Click += new System.EventHandler(this.SalirFrmListadoUsuario_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "(Fecha minima: 01/01/1900)";
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
            this.btnBuscarUsuario.Location = new System.Drawing.Point(541, 247);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscarUsuario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarUsuario.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.selected = false;
            this.btnBuscarUsuario.Size = new System.Drawing.Size(175, 40);
            this.btnBuscarUsuario.TabIndex = 49;
            this.btnBuscarUsuario.TabStop = false;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarUsuario.Textcolor = System.Drawing.Color.White;
            this.btnBuscarUsuario.TextFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarSueldo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 299);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtSueldo
            // 
            this.TxtSueldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSueldo.Location = new System.Drawing.Point(532, 148);
            this.TxtSueldo.Mask = "9999999999";
            this.TxtSueldo.Name = "TxtSueldo";
            this.TxtSueldo.Size = new System.Drawing.Size(184, 27);
            this.TxtSueldo.TabIndex = 57;
            this.TxtSueldo.ValidatingType = typeof(int);
            // 
            // FrmSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(752, 489);
            this.Controls.Add(this.TxtSueldo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmListadoUsuario);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.BtnVerDetalle);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnVerDet);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtIdUsuario);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LblSueldo);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.DgvSueldos);
            this.Controls.Add(this.LblIdUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmSueldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSueldos";
            this.Load += new System.EventHandler(this.FrmSueldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSueldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmListadoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVerDet;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblSueldo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DataGridView DgvSueldos;
        private System.Windows.Forms.Label LblIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVerDetalle;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmListadoUsuario;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo_bruto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox TxtSueldo;
    }
}