namespace BTS_3k2_2020.Pantallas.Usuarios
{
    partial class FrmEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminar));
            this.GbEstado = new System.Windows.Forms.GroupBox();
            this.RbInactivo = new System.Windows.Forms.RadioButton();
            this.RbActivo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.CbPerfil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmNuevoUsuario = new System.Windows.Forms.PictureBox();
            this.btnGuardarModUsuar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.GbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmNuevoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // GbEstado
            // 
            this.GbEstado.Controls.Add(this.RbInactivo);
            this.GbEstado.Controls.Add(this.RbActivo);
            this.GbEstado.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEstado.Location = new System.Drawing.Point(137, 250);
            this.GbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbEstado.Name = "GbEstado";
            this.GbEstado.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbEstado.Size = new System.Drawing.Size(307, 71);
            this.GbEstado.TabIndex = 39;
            this.GbEstado.TabStop = false;
            this.GbEstado.Text = "Estado";
            // 
            // RbInactivo
            // 
            this.RbInactivo.AutoSize = true;
            this.RbInactivo.Location = new System.Drawing.Point(167, 28);
            this.RbInactivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbInactivo.Name = "RbInactivo";
            this.RbInactivo.Size = new System.Drawing.Size(79, 27);
            this.RbInactivo.TabIndex = 1;
            this.RbInactivo.TabStop = true;
            this.RbInactivo.Text = "Inactivo";
            this.RbInactivo.UseVisualStyleBackColor = true;
            // 
            // RbActivo
            // 
            this.RbActivo.AutoSize = true;
            this.RbActivo.Location = new System.Drawing.Point(71, 28);
            this.RbActivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbActivo.Name = "RbActivo";
            this.RbActivo.Size = new System.Drawing.Size(68, 27);
            this.RbActivo.TabIndex = 0;
            this.RbActivo.TabStop = true;
            this.RbActivo.Text = "Activo";
            this.RbActivo.UseVisualStyleBackColor = true;
            this.RbActivo.CheckedChanged += new System.EventHandler(this.RbActivo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(137, 198);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(307, 31);
            this.TxtEmail.TabIndex = 37;
            // 
            // CbPerfil
            // 
            this.CbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPerfil.Enabled = false;
            this.CbPerfil.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPerfil.FormattingEnabled = true;
            this.CbPerfil.Location = new System.Drawing.Point(137, 150);
            this.CbPerfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbPerfil.Name = "CbPerfil";
            this.CbPerfil.Size = new System.Drawing.Size(307, 31);
            this.CbPerfil.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "Perfil  (*)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre  (*)";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(137, 99);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(307, 31);
            this.TxtNombre.TabIndex = 33;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 23);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Eliminar Usuario";
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
            // btnGuardarModUsuar
            // 
            this.btnGuardarModUsuar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarModUsuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModUsuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarModUsuar.BorderRadius = 0;
            this.btnGuardarModUsuar.ButtonText = "     Guardar";
            this.btnGuardarModUsuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarModUsuar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarModUsuar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModUsuar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarModUsuar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarModUsuar.Iconimage")));
            this.btnGuardarModUsuar.Iconimage_right = null;
            this.btnGuardarModUsuar.Iconimage_right_Selected = null;
            this.btnGuardarModUsuar.Iconimage_Selected = null;
            this.btnGuardarModUsuar.IconMarginLeft = 0;
            this.btnGuardarModUsuar.IconMarginRight = 0;
            this.btnGuardarModUsuar.IconRightVisible = true;
            this.btnGuardarModUsuar.IconRightZoom = 0D;
            this.btnGuardarModUsuar.IconVisible = true;
            this.btnGuardarModUsuar.IconZoom = 40D;
            this.btnGuardarModUsuar.IsTab = false;
            this.btnGuardarModUsuar.Location = new System.Drawing.Point(197, 347);
            this.btnGuardarModUsuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarModUsuar.Name = "btnGuardarModUsuar";
            this.btnGuardarModUsuar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModUsuar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarModUsuar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGuardarModUsuar.selected = false;
            this.btnGuardarModUsuar.Size = new System.Drawing.Size(186, 57);
            this.btnGuardarModUsuar.TabIndex = 45;
            this.btnGuardarModUsuar.Text = "     Guardar";
            this.btnGuardarModUsuar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarModUsuar.Textcolor = System.Drawing.Color.White;
            this.btnGuardarModUsuar.TextFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModUsuar.Click += new System.EventHandler(this.btnGuardarModUsuar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Completa los siguientes campos para eliminar el USUARIO.";
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(471, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardarModUsuar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmNuevoUsuario);
            this.Controls.Add(this.GbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.CbPerfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEliminar";
            this.Load += new System.EventHandler(this.FrmBajaUsuario_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmEliminar_MouseMove);
            this.GbEstado.ResumeLayout(false);
            this.GbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmNuevoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GbEstado;
        private System.Windows.Forms.RadioButton RbInactivo;
        private System.Windows.Forms.RadioButton RbActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.ComboBox CbPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmNuevoUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarModUsuar;
        private System.Windows.Forms.Label label6;
    }
}