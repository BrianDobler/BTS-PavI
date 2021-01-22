namespace BTS_3k2_2020.Pantallas.Cursos
{
    partial class CursoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursoNuevo));
            this.label3 = new System.Windows.Forms.Label();
            this.TipoCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmNuevoUsuario = new System.Windows.Forms.PictureBox();
            this.btnGuardarNuevoCurso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chkIncluirCateg = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmNuevoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descripcion  (*)";
            this.label3.UseMnemonic = false;
            // 
            // TipoCategoria
            // 
            this.TipoCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoCategoria.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoCategoria.FormattingEnabled = true;
            this.TipoCategoria.Location = new System.Drawing.Point(214, 150);
            this.TipoCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TipoCategoria.Name = "TipoCategoria";
            this.TipoCategoria.Size = new System.Drawing.Size(254, 27);
            this.TipoCategoria.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Categoria  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre  (*)";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(214, 102);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(254, 29);
            this.TxtNombre.TabIndex = 16;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(214, 221);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(254, 29);
            this.TxtDescripcion.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(457, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Complete los siguientes campos para crear el CURSO en el sistema.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(92, 21);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Nuevo Curso";
            // 
            // SalirFrmNuevoUsuario
            // 
            this.SalirFrmNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmNuevoUsuario.Image")));
            this.SalirFrmNuevoUsuario.Location = new System.Drawing.Point(12, 12);
            this.SalirFrmNuevoUsuario.Name = "SalirFrmNuevoUsuario";
            this.SalirFrmNuevoUsuario.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmNuevoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmNuevoUsuario.TabIndex = 43;
            this.SalirFrmNuevoUsuario.TabStop = false;
            this.SalirFrmNuevoUsuario.Click += new System.EventHandler(this.SalirFrmNuevoUsuario_Click);
            // 
            // btnGuardarNuevoCurso
            // 
            this.btnGuardarNuevoCurso.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarNuevoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarNuevoCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarNuevoCurso.BorderRadius = 0;
            this.btnGuardarNuevoCurso.ButtonText = "Aceptar";
            this.btnGuardarNuevoCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarNuevoCurso.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarNuevoCurso.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoCurso.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarNuevoCurso.Iconimage = null;
            this.btnGuardarNuevoCurso.Iconimage_right = null;
            this.btnGuardarNuevoCurso.Iconimage_right_Selected = null;
            this.btnGuardarNuevoCurso.Iconimage_Selected = null;
            this.btnGuardarNuevoCurso.IconMarginLeft = 0;
            this.btnGuardarNuevoCurso.IconMarginRight = 0;
            this.btnGuardarNuevoCurso.IconRightVisible = true;
            this.btnGuardarNuevoCurso.IconRightZoom = 0D;
            this.btnGuardarNuevoCurso.IconVisible = true;
            this.btnGuardarNuevoCurso.IconZoom = 40D;
            this.btnGuardarNuevoCurso.IsTab = false;
            this.btnGuardarNuevoCurso.Location = new System.Drawing.Point(268, 273);
            this.btnGuardarNuevoCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarNuevoCurso.Name = "btnGuardarNuevoCurso";
            this.btnGuardarNuevoCurso.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarNuevoCurso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarNuevoCurso.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGuardarNuevoCurso.selected = false;
            this.btnGuardarNuevoCurso.Size = new System.Drawing.Size(158, 48);
            this.btnGuardarNuevoCurso.TabIndex = 45;
            this.btnGuardarNuevoCurso.Text = "Aceptar";
            this.btnGuardarNuevoCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarNuevoCurso.Textcolor = System.Drawing.Color.White;
            this.btnGuardarNuevoCurso.TextFont = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoCurso.Click += new System.EventHandler(this.btnGuardarNuevoCurso_Click);
            // 
            // chkIncluirCateg
            // 
            this.chkIncluirCateg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIncluirCateg.AutoSize = true;
            this.chkIncluirCateg.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncluirCateg.ForeColor = System.Drawing.Color.White;
            this.chkIncluirCateg.Location = new System.Drawing.Point(294, 184);
            this.chkIncluirCateg.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkIncluirCateg.Name = "chkIncluirCateg";
            this.chkIncluirCateg.Size = new System.Drawing.Size(117, 22);
            this.chkIncluirCateg.TabIndex = 61;
            this.chkIncluirCateg.Text = "Incluir categoria";
            this.chkIncluirCateg.UseVisualStyleBackColor = true;
            this.chkIncluirCateg.CheckedChanged += new System.EventHandler(this.chkIncluirCateg_CheckedChanged);
            // 
            // CursoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(508, 347);
            this.Controls.Add(this.chkIncluirCateg);
            this.Controls.Add(this.btnGuardarNuevoCurso);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmNuevoUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TipoCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CursoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoCurso";
            this.Load += new System.EventHandler(this.NuevoCurso_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NuevoCurso_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmNuevoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipoCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmNuevoUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarNuevoCurso;
        private System.Windows.Forms.CheckBox chkIncluirCateg;
    }
}