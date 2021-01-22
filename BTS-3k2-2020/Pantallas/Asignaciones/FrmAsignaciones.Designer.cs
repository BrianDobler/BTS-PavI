namespace BTS_3k2_2020.Pantallas.Asignaciones
{
    partial class FrmAsignaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnElimAsignacion = new System.Windows.Forms.Button();
            this.btnModifcarAsignacion = new System.Windows.Forms.Button();
            this.btnAgregrar = new System.Windows.Forms.Button();
            this.btnBuscaAsignacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SalirFrmAsignaciones = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefrescar = new System.Windows.Forms.PictureBox();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtbAsginaciones = new System.Windows.Forms.DataGridView();
            this.id_asignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbAsginaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(61, 17);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(97, 21);
            this.bunifuCustomLabel1.TabIndex = 55;
            this.bunifuCustomLabel1.Text = "Asignaciones";
            // 
            // BtnElimAsignacion
            // 
            this.BtnElimAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnElimAsignacion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimAsignacion.Location = new System.Drawing.Point(472, 395);
            this.BtnElimAsignacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnElimAsignacion.Name = "BtnElimAsignacion";
            this.BtnElimAsignacion.Size = new System.Drawing.Size(191, 34);
            this.BtnElimAsignacion.TabIndex = 54;
            this.BtnElimAsignacion.Text = "Eliminar";
            this.BtnElimAsignacion.UseVisualStyleBackColor = true;
            this.BtnElimAsignacion.Click += new System.EventHandler(this.BtnElimAsignacion_Click);
            // 
            // btnModifcarAsignacion
            // 
            this.btnModifcarAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifcarAsignacion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifcarAsignacion.Location = new System.Drawing.Point(472, 307);
            this.btnModifcarAsignacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModifcarAsignacion.Name = "btnModifcarAsignacion";
            this.btnModifcarAsignacion.Size = new System.Drawing.Size(191, 34);
            this.btnModifcarAsignacion.TabIndex = 53;
            this.btnModifcarAsignacion.Text = "Modificar";
            this.btnModifcarAsignacion.UseVisualStyleBackColor = true;
            this.btnModifcarAsignacion.Click += new System.EventHandler(this.btnModifcarAsignacion_Click);
            // 
            // btnAgregrar
            // 
            this.btnAgregrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregrar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregrar.Location = new System.Drawing.Point(472, 261);
            this.btnAgregrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregrar.Name = "btnAgregrar";
            this.btnAgregrar.Size = new System.Drawing.Size(191, 34);
            this.btnAgregrar.TabIndex = 52;
            this.btnAgregrar.Text = "Agregar";
            this.btnAgregrar.UseVisualStyleBackColor = true;
            this.btnAgregrar.Click += new System.EventHandler(this.btnAgregrar_Click);
            // 
            // btnBuscaAsignacion
            // 
            this.btnBuscaAsignacion.Activecolor = System.Drawing.Color.IndianRed;
            this.btnBuscaAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscaAsignacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaAsignacion.BorderRadius = 0;
            this.btnBuscaAsignacion.ButtonText = "Buscar";
            this.btnBuscaAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaAsignacion.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscaAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaAsignacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscaAsignacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBuscaAsignacion.Iconimage")));
            this.btnBuscaAsignacion.Iconimage_right = null;
            this.btnBuscaAsignacion.Iconimage_right_Selected = null;
            this.btnBuscaAsignacion.Iconimage_Selected = null;
            this.btnBuscaAsignacion.IconMarginLeft = 0;
            this.btnBuscaAsignacion.IconMarginRight = 0;
            this.btnBuscaAsignacion.IconRightVisible = true;
            this.btnBuscaAsignacion.IconRightZoom = 0D;
            this.btnBuscaAsignacion.IconVisible = true;
            this.btnBuscaAsignacion.IconZoom = 40D;
            this.btnBuscaAsignacion.IsTab = false;
            this.btnBuscaAsignacion.Location = new System.Drawing.Point(496, 155);
            this.btnBuscaAsignacion.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.btnBuscaAsignacion.Name = "btnBuscaAsignacion";
            this.btnBuscaAsignacion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnBuscaAsignacion.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btnBuscaAsignacion.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBuscaAsignacion.selected = false;
            this.btnBuscaAsignacion.Size = new System.Drawing.Size(138, 40);
            this.btnBuscaAsignacion.TabIndex = 51;
            this.btnBuscaAsignacion.Text = "Buscar";
            this.btnBuscaAsignacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscaAsignacion.Textcolor = System.Drawing.Color.White;
            this.btnBuscaAsignacion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaAsignacion.Click += new System.EventHandler(this.btnBuscaAsignacion_Click);
            // 
            // SalirFrmAsignaciones
            // 
            this.SalirFrmAsignaciones.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmAsignaciones.Image")));
            this.SalirFrmAsignaciones.Location = new System.Drawing.Point(13, 12);
            this.SalirFrmAsignaciones.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.SalirFrmAsignaciones.Name = "SalirFrmAsignaciones";
            this.SalirFrmAsignaciones.Size = new System.Drawing.Size(40, 37);
            this.SalirFrmAsignaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmAsignaciones.TabIndex = 50;
            this.SalirFrmAsignaciones.TabStop = false;
            this.SalirFrmAsignaciones.Click += new System.EventHandler(this.SalirFrmAsignaciones_Click);
            // 
            // pictureBoxRefrescar
            // 
            this.pictureBoxRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefrescar.Image")));
            this.pictureBoxRefrescar.Location = new System.Drawing.Point(553, 210);
            this.pictureBoxRefrescar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.pictureBoxRefrescar.Name = "pictureBoxRefrescar";
            this.pictureBoxRefrescar.Size = new System.Drawing.Size(23, 37);
            this.pictureBoxRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefrescar.TabIndex = 49;
            this.pictureBoxRefrescar.TabStop = false;
            this.pictureBoxRefrescar.Click += new System.EventHandler(this.pictureBoxRefrescar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(472, 110);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtMonto.Mask = "99999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(191, 29);
            this.txtMonto.TabIndex = 45;
            this.txtMonto.ValidatingType = typeof(int);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNombre.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(472, 70);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 29);
            this.txtNombre.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(217, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ingrese los datos de la ASIGNACIÓN y seleccione lo que desea hacer.";
            // 
            // dtbAsginaciones
            // 
            this.dtbAsginaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtbAsginaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtbAsginaciones.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtbAsginaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbAsginaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_asignacion,
            this.nombre,
            this.monto});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtbAsginaciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtbAsginaciones.Location = new System.Drawing.Point(48, 70);
            this.dtbAsginaciones.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dtbAsginaciones.Name = "dtbAsginaciones";
            this.dtbAsginaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtbAsginaciones.Size = new System.Drawing.Size(307, 354);
            this.dtbAsginaciones.TabIndex = 47;
            // 
            // id_asignacion
            // 
            this.id_asignacion.Frozen = true;
            this.id_asignacion.HeaderText = "ID";
            this.id_asignacion.Name = "id_asignacion";
            this.id_asignacion.Width = 51;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 96;
            // 
            // monto
            // 
            this.monto.Frozen = true;
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 82;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nombre:";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(472, 351);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(191, 34);
            this.btnAsignar.TabIndex = 56;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 32);
            this.button1.TabIndex = 57;
            this.button1.Text = "Ver asignaciones por sueldo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(207)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(684, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.BtnElimAsignacion);
            this.Controls.Add(this.btnModifcarAsignacion);
            this.Controls.Add(this.btnAgregrar);
            this.Controls.Add(this.btnBuscaAsignacion);
            this.Controls.Add(this.SalirFrmAsignaciones);
            this.Controls.Add(this.pictureBoxRefrescar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtbAsginaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmAsignaciones";
            this.Text = "FrmAsignaciones";
            this.Load += new System.EventHandler(this.FrmAsignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbAsginaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button BtnElimAsignacion;
        private System.Windows.Forms.Button btnModifcarAsignacion;
        private System.Windows.Forms.Button btnAgregrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscaAsignacion;
        private System.Windows.Forms.PictureBox SalirFrmAsignaciones;
        private System.Windows.Forms.PictureBox pictureBoxRefrescar;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtbAsginaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_asignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
    }
}