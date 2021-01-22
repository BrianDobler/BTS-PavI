namespace BTS_3k2_2020.Pantallas.Reportes.RepSueldos
{
    partial class FrmListadoSueldos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoSueldos));
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSueldo = new System.Windows.Forms.TextBox();
            this.LblSueldo = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.rwSueldos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmDescuentos = new System.Windows.Forms.PictureBox();
            this.chbFiltrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFecha
            // 
            this.DtpFecha.CustomFormat = "dd/MM/yyyy";
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(287, 121);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(214, 24);
            this.DtpFecha.TabIndex = 54;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(288, 57);
            this.TxtNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(214, 24);
            this.TxtNombreUsuario.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre: ";
            // 
            // TxtSueldo
            // 
            this.TxtSueldo.Location = new System.Drawing.Point(288, 89);
            this.TxtSueldo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtSueldo.Name = "TxtSueldo";
            this.TxtSueldo.Size = new System.Drawing.Size(214, 24);
            this.TxtSueldo.TabIndex = 53;
            // 
            // LblSueldo
            // 
            this.LblSueldo.AutoSize = true;
            this.LblSueldo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSueldo.ForeColor = System.Drawing.Color.White;
            this.LblSueldo.Location = new System.Drawing.Point(211, 89);
            this.LblSueldo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSueldo.Name = "LblSueldo";
            this.LblSueldo.Size = new System.Drawing.Size(67, 26);
            this.LblSueldo.TabIndex = 50;
            this.LblSueldo.Text = "Sueldo:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(167, 120);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(111, 26);
            this.LblFecha.TabIndex = 49;
            this.LblFecha.Text = "Fecha desde:";
            // 
            // rwSueldos
            // 
            this.rwSueldos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.rwSueldos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rwSueldos.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwSueldos.LocalReport.ReportEmbeddedResource = "BTS_3k2_2020.Pantallas.Reportes.RepSueldos.InformeSueldos.rdlc";
            this.rwSueldos.Location = new System.Drawing.Point(0, 181);
            this.rwSueldos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rwSueldos.Name = "rwSueldos";
            this.rwSueldos.ServerReport.BearerToken = null;
            this.rwSueldos.Size = new System.Drawing.Size(642, 506);
            this.rwSueldos.TabIndex = 56;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Activecolor = System.Drawing.Color.LightBlue;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.BorderRadius = 0;
            this.btnConsultar.ButtonText = "";
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
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
            this.btnConsultar.Location = new System.Drawing.Point(523, 78);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnConsultar.OnHovercolor = System.Drawing.Color.LightBlue;
            this.btnConsultar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConsultar.selected = false;
            this.btnConsultar.Size = new System.Drawing.Size(44, 43);
            this.btnConsultar.TabIndex = 57;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(124, 16);
            this.bunifuCustomLabel1.TabIndex = 59;
            this.bunifuCustomLabel1.Text = "Informe de Sueldos";
            // 
            // SalirFrmDescuentos
            // 
            this.SalirFrmDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmDescuentos.Image")));
            this.SalirFrmDescuentos.Location = new System.Drawing.Point(12, 13);
            this.SalirFrmDescuentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalirFrmDescuentos.Name = "SalirFrmDescuentos";
            this.SalirFrmDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmDescuentos.TabIndex = 58;
            this.SalirFrmDescuentos.TabStop = false;
            this.SalirFrmDescuentos.Click += new System.EventHandler(this.SalirFrmDescuentos_Click);
            // 
            // chbFiltrar
            // 
            this.chbFiltrar.AutoSize = true;
            this.chbFiltrar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFiltrar.ForeColor = System.Drawing.Color.White;
            this.chbFiltrar.Location = new System.Drawing.Point(371, 149);
            this.chbFiltrar.Name = "chbFiltrar";
            this.chbFiltrar.Size = new System.Drawing.Size(131, 27);
            this.chbFiltrar.TabIndex = 60;
            this.chbFiltrar.Text = "Filtrar por fecha";
            this.chbFiltrar.UseVisualStyleBackColor = true;
            this.chbFiltrar.CheckedChanged += new System.EventHandler(this.chbFiltrar_CheckedChanged);
            // 
            // FrmListadoSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(642, 687);
            this.Controls.Add(this.chbFiltrar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmDescuentos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rwSueldos);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSueldo);
            this.Controls.Add(this.LblSueldo);
            this.Controls.Add(this.LblFecha);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmListadoSueldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoSueldos";
            this.Load += new System.EventHandler(this.FrmListadoSueldos_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmListadoSueldos_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSueldo;
        private System.Windows.Forms.Label LblSueldo;
        private System.Windows.Forms.Label LblFecha;
        private Microsoft.Reporting.WinForms.ReportViewer rwSueldos;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmDescuentos;
        private System.Windows.Forms.CheckBox chbFiltrar;
    }
}