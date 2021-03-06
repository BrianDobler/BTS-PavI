﻿namespace BTS_3k2_2020.Pantallas.Reportes.EstAsignaciones
{
    partial class FrmEstAsignaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstAsignaciones));
            this.rwEstAsig = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblFecha = new System.Windows.Forms.Label();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMonto = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMenor = new System.Windows.Forms.RadioButton();
            this.rbMayor = new System.Windows.Forms.RadioButton();
            this.SalirFrmDescuentos = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // rwEstAsig
            // 
            this.rwEstAsig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.rwEstAsig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rwEstAsig.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwEstAsig.LocalReport.ReportEmbeddedResource = "BTS_3k2_2020.Pantallas.Reportes.EstAsignaciones.InfEstAsig.rdlc";
            this.rwEstAsig.Location = new System.Drawing.Point(0, 181);
            this.rwEstAsig.Name = "rwEstAsig";
            this.rwEstAsig.ServerReport.BearerToken = null;
            this.rwEstAsig.Size = new System.Drawing.Size(642, 506);
            this.rwEstAsig.TabIndex = 0;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(173, 61);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(158, 28);
            this.LblFecha.TabIndex = 59;
            this.LblFecha.Text = "Monto Asignación:";
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
            this.btnConsultar.Location = new System.Drawing.Point(554, 52);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnConsultar.OnHovercolor = System.Drawing.Color.LightBlue;
            this.btnConsultar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConsultar.selected = false;
            this.btnConsultar.Size = new System.Drawing.Size(43, 43);
            this.btnConsultar.TabIndex = 57;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultar.Textcolor = System.Drawing.Color.White;
            this.btnConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(337, 61);
            this.txtMonto.Mask = "9999999999";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(199, 27);
            this.txtMonto.TabIndex = 60;
            this.txtMonto.ValidatingType = typeof(int);
            this.txtMonto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtMonto_MaskInputRejected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMenor);
            this.groupBox1.Controls.Add(this.rbMayor);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(337, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 80);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monto";
            // 
            // rbMenor
            // 
            this.rbMenor.AutoSize = true;
            this.rbMenor.ForeColor = System.Drawing.Color.White;
            this.rbMenor.Location = new System.Drawing.Point(30, 45);
            this.rbMenor.Name = "rbMenor";
            this.rbMenor.Size = new System.Drawing.Size(101, 26);
            this.rbMenor.TabIndex = 1;
            this.rbMenor.Text = "Menor que -";
            this.rbMenor.UseVisualStyleBackColor = true;
            // 
            // rbMayor
            // 
            this.rbMayor.AutoSize = true;
            this.rbMayor.Checked = true;
            this.rbMayor.ForeColor = System.Drawing.Color.White;
            this.rbMayor.Location = new System.Drawing.Point(30, 19);
            this.rbMayor.Name = "rbMayor";
            this.rbMayor.Size = new System.Drawing.Size(101, 26);
            this.rbMayor.TabIndex = 0;
            this.rbMayor.TabStop = true;
            this.rbMayor.Text = "Mayor que -";
            this.rbMayor.UseVisualStyleBackColor = true;
            // 
            // SalirFrmDescuentos
            // 
            this.SalirFrmDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmDescuentos.Image")));
            this.SalirFrmDescuentos.Location = new System.Drawing.Point(12, 13);
            this.SalirFrmDescuentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalirFrmDescuentos.Name = "SalirFrmDescuentos";
            this.SalirFrmDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmDescuentos.TabIndex = 62;
            this.SalirFrmDescuentos.TabStop = false;
            this.SalirFrmDescuentos.Click += new System.EventHandler(this.SalirFrmDescuentos_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(199, 23);
            this.bunifuCustomLabel1.TabIndex = 63;
            this.bunifuCustomLabel1.Text = "Estadísticas de Asignaciones";
            // 
            // FrmEstAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(642, 687);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmDescuentos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rwEstAsig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstAsignaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstAsignaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEstAsignaciones_FormClosing);
            this.Load += new System.EventHandler(this.FrmEstAsignaciones_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmEstAsignaciones_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwEstAsig;
        private System.Windows.Forms.Label LblFecha;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultar;
        private System.Windows.Forms.MaskedTextBox txtMonto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMenor;
        private System.Windows.Forms.RadioButton rbMayor;
        private System.Windows.Forms.PictureBox SalirFrmDescuentos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}