namespace BTS_3k2_2020.Pantallas.Reportes.RepObjetivos
{
    partial class FrmListadoObjetivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoObjetivos));
            this.lblNombreLargo = new System.Windows.Forms.Label();
            this.txtNombreLargo = new System.Windows.Forms.TextBox();
            this.lblNombreCorto = new System.Windows.Forms.Label();
            this.txtNombreCorto = new System.Windows.Forms.TextBox();
            this.rwObjetivos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChkIncluirInactivos = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmDescuentos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreLargo
            // 
            this.lblNombreLargo.AutoSize = true;
            this.lblNombreLargo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLargo.ForeColor = System.Drawing.Color.White;
            this.lblNombreLargo.Location = new System.Drawing.Point(192, 105);
            this.lblNombreLargo.Name = "lblNombreLargo";
            this.lblNombreLargo.Size = new System.Drawing.Size(128, 28);
            this.lblNombreLargo.TabIndex = 27;
            this.lblNombreLargo.Text = "Nombre Largo:";
            // 
            // txtNombreLargo
            // 
            this.txtNombreLargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLargo.Location = new System.Drawing.Point(327, 106);
            this.txtNombreLargo.Name = "txtNombreLargo";
            this.txtNombreLargo.Size = new System.Drawing.Size(190, 26);
            this.txtNombreLargo.TabIndex = 26;
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCorto.ForeColor = System.Drawing.Color.White;
            this.lblNombreCorto.Location = new System.Drawing.Point(194, 71);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(127, 28);
            this.lblNombreCorto.TabIndex = 25;
            this.lblNombreCorto.Text = "Nombre Corto:";
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCorto.Location = new System.Drawing.Point(327, 72);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(190, 26);
            this.txtNombreCorto.TabIndex = 24;
            // 
            // rwObjetivos
            // 
            this.rwObjetivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.rwObjetivos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rwObjetivos.LocalReport.ReportEmbeddedResource = "BTS_3k2_2020.Pantallas.Reportes.RepObjetivos.InformeObjetivos.rdlc";
            this.rwObjetivos.Location = new System.Drawing.Point(0, 181);
            this.rwObjetivos.Name = "rwObjetivos";
            this.rwObjetivos.ServerReport.BearerToken = null;
            this.rwObjetivos.Size = new System.Drawing.Size(642, 506);
            this.rwObjetivos.TabIndex = 29;
            // 
            // ChkIncluirInactivos
            // 
            this.ChkIncluirInactivos.AutoSize = true;
            this.ChkIncluirInactivos.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkIncluirInactivos.ForeColor = System.Drawing.Color.White;
            this.ChkIncluirInactivos.Location = new System.Drawing.Point(347, 140);
            this.ChkIncluirInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.ChkIncluirInactivos.Name = "ChkIncluirInactivos";
            this.ChkIncluirInactivos.Size = new System.Drawing.Size(171, 27);
            this.ChkIncluirInactivos.TabIndex = 36;
            this.ChkIncluirInactivos.Text = "Mostrar desactivados";
            this.ChkIncluirInactivos.UseVisualStyleBackColor = true;
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
            this.btnConsultar.Location = new System.Drawing.Point(535, 82);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnConsultar.OnHovercolor = System.Drawing.Color.LightBlue;
            this.btnConsultar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConsultar.selected = false;
            this.btnConsultar.Size = new System.Drawing.Size(42, 40);
            this.btnConsultar.TabIndex = 37;
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(142, 23);
            this.bunifuCustomLabel1.TabIndex = 67;
            this.bunifuCustomLabel1.Text = "Informe de Objetivos";
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
            // FrmListadoObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(642, 687);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmDescuentos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.ChkIncluirInactivos);
            this.Controls.Add(this.rwObjetivos);
            this.Controls.Add(this.lblNombreLargo);
            this.Controls.Add(this.txtNombreLargo);
            this.Controls.Add(this.lblNombreCorto);
            this.Controls.Add(this.txtNombreCorto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoObjetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoObjetivos";
            this.Load += new System.EventHandler(this.FrmListadoObjetivos_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmListadoObjetivos_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreLargo;
        private System.Windows.Forms.TextBox txtNombreLargo;
        private System.Windows.Forms.Label lblNombreCorto;
        private System.Windows.Forms.TextBox txtNombreCorto;
        private Microsoft.Reporting.WinForms.ReportViewer rwObjetivos;
        private System.Windows.Forms.CheckBox ChkIncluirInactivos;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmDescuentos;
    }
}