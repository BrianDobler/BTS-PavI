﻿namespace BTS_3k2_2020.Pantallas.Reportes.EstObjetivos
{
    partial class FrmEstObjetivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstObjetivos));
            this.rwEstObj = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmDescuentos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // rwEstObj
            // 
            this.rwEstObj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.rwEstObj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rwEstObj.LocalReport.ReportEmbeddedResource = "BTS_3k2_2020.Pantallas.Reportes.EstObjetivos.InfEstObj.rdlc";
            this.rwEstObj.Location = new System.Drawing.Point(0, 181);
            this.rwEstObj.Name = "rwEstObj";
            this.rwEstObj.ServerReport.BearerToken = null;
            this.rwEstObj.Size = new System.Drawing.Size(642, 506);
            this.rwEstObj.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(172, 23);
            this.bunifuCustomLabel1.TabIndex = 65;
            this.bunifuCustomLabel1.Text = "Estadísticas de Objetivos";
            // 
            // SalirFrmDescuentos
            // 
            this.SalirFrmDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmDescuentos.Image")));
            this.SalirFrmDescuentos.Location = new System.Drawing.Point(12, 13);
            this.SalirFrmDescuentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalirFrmDescuentos.Name = "SalirFrmDescuentos";
            this.SalirFrmDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmDescuentos.TabIndex = 64;
            this.SalirFrmDescuentos.TabStop = false;
            this.SalirFrmDescuentos.Click += new System.EventHandler(this.SalirFrmDescuentos_Click);
            // 
            // FrmEstObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(642, 687);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmDescuentos);
            this.Controls.Add(this.rwEstObj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstObjetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstObjetivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEstObjetivos_FormClosing);
            this.Load += new System.EventHandler(this.FrmEstObjetivos_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmEstObjetivos_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwEstObj;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmDescuentos;
    }
}