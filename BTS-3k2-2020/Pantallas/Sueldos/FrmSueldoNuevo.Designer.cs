namespace BTS_3k2_2020.Pantallas.Sueldos
{
    partial class FrmSueldoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSueldoNuevo));
            this.CbUsuarios = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtSueldo_bruto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SalirFrmNuevoUsuario = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.LblSueldo_bruto = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.btnGuardarModDesc = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmNuevoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // CbUsuarios
            // 
            this.CbUsuarios.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbUsuarios.FormattingEnabled = true;
            this.CbUsuarios.Location = new System.Drawing.Point(203, 118);
            this.CbUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbUsuarios.Name = "CbUsuarios";
            this.CbUsuarios.Size = new System.Drawing.Size(221, 27);
            this.CbUsuarios.TabIndex = 24;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Location = new System.Drawing.Point(203, 159);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(221, 25);
            this.DtpFecha.TabIndex = 23;
            // 
            // TxtSueldo_bruto
            // 
            this.TxtSueldo_bruto.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSueldo_bruto.Location = new System.Drawing.Point(203, 197);
            this.TxtSueldo_bruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSueldo_bruto.Name = "TxtSueldo_bruto";
            this.TxtSueldo_bruto.Size = new System.Drawing.Size(221, 27);
            this.TxtSueldo_bruto.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Completa los siguientes campos para agregar el nuevo SUELDO.";
            // 
            // SalirFrmNuevoUsuario
            // 
            this.SalirFrmNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmNuevoUsuario.Image")));
            this.SalirFrmNuevoUsuario.Location = new System.Drawing.Point(13, 14);
            this.SalirFrmNuevoUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalirFrmNuevoUsuario.Name = "SalirFrmNuevoUsuario";
            this.SalirFrmNuevoUsuario.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmNuevoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmNuevoUsuario.TabIndex = 53;
            this.SalirFrmNuevoUsuario.TabStop = false;
            this.SalirFrmNuevoUsuario.Click += new System.EventHandler(this.SalirFrmNuevoUsuario_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(57, 22);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(94, 16);
            this.bunifuCustomLabel1.TabIndex = 54;
            this.bunifuCustomLabel1.Text = "Nuevo Sueldo";
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.LblNombreUsuario.Location = new System.Drawing.Point(33, 120);
            this.LblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(153, 20);
            this.LblNombreUsuario.TabIndex = 59;
            this.LblNombreUsuario.Text = "Nombre del Usuario:";
            // 
            // LblSueldo_bruto
            // 
            this.LblSueldo_bruto.AutoSize = true;
            this.LblSueldo_bruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSueldo_bruto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.LblSueldo_bruto.Location = new System.Drawing.Point(80, 196);
            this.LblSueldo_bruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSueldo_bruto.Name = "LblSueldo_bruto";
            this.LblSueldo_bruto.Size = new System.Drawing.Size(106, 20);
            this.LblSueldo_bruto.TabIndex = 58;
            this.LblSueldo_bruto.Text = "Sueldo Bruto:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.LblFecha.Location = new System.Drawing.Point(131, 159);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(58, 20);
            this.LblFecha.TabIndex = 57;
            this.LblFecha.Text = "Fecha:";
            // 
            // btnGuardarModDesc
            // 
            this.btnGuardarModDesc.Activecolor = System.Drawing.Color.Transparent;
            this.btnGuardarModDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarModDesc.BorderRadius = 0;
            this.btnGuardarModDesc.ButtonText = "Agregar";
            this.btnGuardarModDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarModDesc.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarModDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModDesc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarModDesc.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarModDesc.Iconimage")));
            this.btnGuardarModDesc.Iconimage_right = null;
            this.btnGuardarModDesc.Iconimage_right_Selected = null;
            this.btnGuardarModDesc.Iconimage_Selected = null;
            this.btnGuardarModDesc.IconMarginLeft = 0;
            this.btnGuardarModDesc.IconMarginRight = 0;
            this.btnGuardarModDesc.IconRightVisible = true;
            this.btnGuardarModDesc.IconRightZoom = 0D;
            this.btnGuardarModDesc.IconVisible = true;
            this.btnGuardarModDesc.IconZoom = 40D;
            this.btnGuardarModDesc.IsTab = false;
            this.btnGuardarModDesc.Location = new System.Drawing.Point(235, 268);
            this.btnGuardarModDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarModDesc.Name = "btnGuardarModDesc";
            this.btnGuardarModDesc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModDesc.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarModDesc.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGuardarModDesc.selected = false;
            this.btnGuardarModDesc.Size = new System.Drawing.Size(158, 48);
            this.btnGuardarModDesc.TabIndex = 60;
            this.btnGuardarModDesc.Text = "Agregar";
            this.btnGuardarModDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarModDesc.Textcolor = System.Drawing.Color.White;
            this.btnGuardarModDesc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModDesc.Click += new System.EventHandler(this.btnGuardarModDesc_Click);
            // 
            // FrmSueldoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(465, 334);
            this.Controls.Add(this.btnGuardarModDesc);
            this.Controls.Add(this.LblNombreUsuario);
            this.Controls.Add(this.LblSueldo_bruto);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmNuevoUsuario);
            this.Controls.Add(this.CbUsuarios);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.TxtSueldo_bruto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSueldoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSueldoNuevo";
            this.Load += new System.EventHandler(this.FrmSueldoNuevo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSueldoNuevo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmNuevoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbUsuarios;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtSueldo_bruto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox SalirFrmNuevoUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Label LblSueldo_bruto;
        private System.Windows.Forms.Label LblFecha;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarModDesc;
    }
}