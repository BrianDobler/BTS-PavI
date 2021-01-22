namespace BTS_3k2_2020.Pantallas.Cursos
{
    partial class FrmCursoXCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursoXCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxRefrescar = new System.Windows.Forms.PictureBox();
            this.btnBuscarDescuento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmModificarDescuentos = new System.Windows.Forms.PictureBox();
            this.dgvCurCat = new System.Windows.Forms.DataGridView();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBoxRefrescar);
            this.panel1.Controls.Add(this.btnBuscarDescuento);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNombreCategoria);
            this.panel1.Controls.Add(this.txtNombreCurso);
            this.panel1.Location = new System.Drawing.Point(16, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 230);
            this.panel1.TabIndex = 62;
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
            this.pictureBoxRefrescar.Location = new System.Drawing.Point(179, 160);
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
            this.btnBuscarDescuento.Location = new System.Drawing.Point(226, 153);
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
            this.label8.Location = new System.Drawing.Point(28, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nombre Curso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.label9.Location = new System.Drawing.Point(8, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nombre Categoría:";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.BackColor = System.Drawing.Color.White;
            this.txtNombreCategoria.Location = new System.Drawing.Point(152, 104);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(257, 24);
            this.txtNombreCategoria.TabIndex = 45;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.BackColor = System.Drawing.Color.White;
            this.txtNombreCurso.Location = new System.Drawing.Point(152, 63);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(257, 24);
            this.txtNombreCurso.TabIndex = 44;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(142, 23);
            this.bunifuCustomLabel1.TabIndex = 61;
            this.bunifuCustomLabel1.Text = "Curso por Categoría";
            // 
            // SalirFrmModificarDescuentos
            // 
            this.SalirFrmModificarDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmModificarDescuentos.Image")));
            this.SalirFrmModificarDescuentos.Location = new System.Drawing.Point(14, 12);
            this.SalirFrmModificarDescuentos.Name = "SalirFrmModificarDescuentos";
            this.SalirFrmModificarDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmModificarDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmModificarDescuentos.TabIndex = 60;
            this.SalirFrmModificarDescuentos.TabStop = false;
            this.SalirFrmModificarDescuentos.Click += new System.EventHandler(this.SalirFrmModificarDescuentos_Click);
            // 
            // dgvCurCat
            // 
            this.dgvCurCat.AllowUserToDeleteRows = false;
            this.dgvCurCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCurCat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.curso,
            this.categoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurCat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurCat.Location = new System.Drawing.Point(490, 66);
            this.dgvCurCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCurCat.Name = "dgvCurCat";
            this.dgvCurCat.ReadOnly = true;
            this.dgvCurCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurCat.Size = new System.Drawing.Size(465, 230);
            this.dgvCurCat.TabIndex = 59;
            // 
            // curso
            // 
            this.curso.HeaderText = "Nombre Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            this.curso.Width = 113;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Nombre Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 135;
            // 
            // FrmCursoXCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(977, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmModificarDescuentos);
            this.Controls.Add(this.dgvCurCat);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCursoXCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCursoXCategoria";
            this.Load += new System.EventHandler(this.FrmCursoXCategoria_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCursoXCategoria_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxRefrescar;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarDescuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmModificarDescuentos;
        private System.Windows.Forms.DataGridView dgvCurCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}