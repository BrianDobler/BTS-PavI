namespace BTS_3k2_2020.Pantallas.Reportes.RepUsuarios
{
    partial class FrmListadoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoUsuarios));
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreUs = new System.Windows.Forms.Label();
            this.ChkIncluirInactivos = new System.Windows.Forms.CheckBox();
            this.TipoPerfil = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.rwUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmDescuentos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Perfil:";
            // 
            // lblNombreUs
            // 
            this.lblNombreUs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUs.AutoSize = true;
            this.lblNombreUs.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUs.ForeColor = System.Drawing.Color.White;
            this.lblNombreUs.Location = new System.Drawing.Point(157, 70);
            this.lblNombreUs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUs.Name = "lblNombreUs";
            this.lblNombreUs.Size = new System.Drawing.Size(79, 28);
            this.lblNombreUs.TabIndex = 24;
            this.lblNombreUs.Text = "Nombre:";
            // 
            // ChkIncluirInactivos
            // 
            this.ChkIncluirInactivos.AutoSize = true;
            this.ChkIncluirInactivos.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkIncluirInactivos.ForeColor = System.Drawing.Color.White;
            this.ChkIncluirInactivos.Location = new System.Drawing.Point(328, 148);
            this.ChkIncluirInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.ChkIncluirInactivos.Name = "ChkIncluirInactivos";
            this.ChkIncluirInactivos.Size = new System.Drawing.Size(158, 26);
            this.ChkIncluirInactivos.TabIndex = 23;
            this.ChkIncluirInactivos.Text = "Mostrar desactivados";
            this.ChkIncluirInactivos.UseVisualStyleBackColor = true;
            // 
            // TipoPerfil
            // 
            this.TipoPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPerfil.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoPerfil.FormattingEnabled = true;
            this.TipoPerfil.Location = new System.Drawing.Point(242, 106);
            this.TipoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.TipoPerfil.Name = "TipoPerfil";
            this.TipoPerfil.Size = new System.Drawing.Size(244, 31);
            this.TipoPerfil.TabIndex = 22;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(242, 68);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(244, 30);
            this.TxtNombre.TabIndex = 21;
            // 
            // rwUsuarios
            // 
            this.rwUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.rwUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rwUsuarios.LocalReport.ReportEmbeddedResource = "BTS_3k2_2020.Pantallas.Reportes.RepUsuarios.InformeUsuarios.rdlc";
            this.rwUsuarios.Location = new System.Drawing.Point(0, 181);
            this.rwUsuarios.Name = "rwUsuarios";
            this.rwUsuarios.ServerReport.BearerToken = null;
            this.rwUsuarios.Size = new System.Drawing.Size(642, 506);
            this.rwUsuarios.TabIndex = 27;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Activecolor = System.Drawing.Color.LightBlue;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.BorderRadius = 0;
            this.btnConsultar.ButtonText = "Consultar";
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Iconimage")));
            this.btnConsultar.Iconimage_right = null;
            this.btnConsultar.Iconimage_right_Selected = null;
            this.btnConsultar.Iconimage_Selected = null;
            this.btnConsultar.IconMarginLeft = 0;
            this.btnConsultar.IconMarginRight = 0;
            this.btnConsultar.IconRightVisible = true;
            this.btnConsultar.IconRightZoom = 0D;
            this.btnConsultar.IconVisible = true;
            this.btnConsultar.IconZoom = 40D;
            this.btnConsultar.IsTab = false;
            this.btnConsultar.Location = new System.Drawing.Point(503, 82);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnConsultar.OnHovercolor = System.Drawing.Color.LightBlue;
            this.btnConsultar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConsultar.selected = false;
            this.btnConsultar.Size = new System.Drawing.Size(39, 40);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultar.Textcolor = System.Drawing.Color.White;
            this.btnConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(138, 23);
            this.bunifuCustomLabel1.TabIndex = 67;
            this.bunifuCustomLabel1.Text = "Informe de Usuarios";
            // 
            // SalirFrmDescuentos
            // 
            this.SalirFrmDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmDescuentos.Image")));
            this.SalirFrmDescuentos.Location = new System.Drawing.Point(12, 13);
            this.SalirFrmDescuentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalirFrmDescuentos.Name = "SalirFrmDescuentos";
            this.SalirFrmDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmDescuentos.TabIndex = 66;
            this.SalirFrmDescuentos.TabStop = false;
            this.SalirFrmDescuentos.Click += new System.EventHandler(this.SalirFrmDescuentos_Click);
            // 
            // FrmListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(642, 687);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmDescuentos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rwUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreUs);
            this.Controls.Add(this.ChkIncluirInactivos);
            this.Controls.Add(this.TipoPerfil);
            this.Controls.Add(this.TxtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoUsuarios";
            this.Load += new System.EventHandler(this.FrmListadoUsuarios_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmListadoUsuarios_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreUs;
        private System.Windows.Forms.CheckBox ChkIncluirInactivos;
        private System.Windows.Forms.ComboBox TipoPerfil;
        private System.Windows.Forms.TextBox TxtNombre;
        private Microsoft.Reporting.WinForms.ReportViewer rwUsuarios;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmDescuentos;
    }
}