namespace BTS_3k2_2020.Pantallas.Reportes.EstCategorias
{
    partial class FrmEstCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstCategorias));
            this.rwEstCateg = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmDescuentos = new System.Windows.Forms.PictureBox();
            this.ChkIncluirInactivos = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // rwEstCateg
            // 
            this.rwEstCateg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.rwEstCateg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rwEstCateg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rwEstCateg.LocalReport.ReportEmbeddedResource = "BTS_3k2_2020.Pantallas.Reportes.EstCategorias.InfEstCat.rdlc";
            this.rwEstCateg.Location = new System.Drawing.Point(0, 181);
            this.rwEstCateg.Name = "rwEstCateg";
            this.rwEstCateg.ServerReport.BearerToken = null;
            this.rwEstCateg.Size = new System.Drawing.Size(642, 506);
            this.rwEstCateg.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(185, 23);
            this.bunifuCustomLabel1.TabIndex = 61;
            this.bunifuCustomLabel1.Text = "Estadísticas de Categorías";
            // 
            // SalirFrmDescuentos
            // 
            this.SalirFrmDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmDescuentos.Image")));
            this.SalirFrmDescuentos.Location = new System.Drawing.Point(12, 13);
            this.SalirFrmDescuentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SalirFrmDescuentos.Name = "SalirFrmDescuentos";
            this.SalirFrmDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmDescuentos.TabIndex = 60;
            this.SalirFrmDescuentos.TabStop = false;
            this.SalirFrmDescuentos.Click += new System.EventHandler(this.SalirFrmDescuentos_Click);
            // 
            // ChkIncluirInactivos
            // 
            this.ChkIncluirInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkIncluirInactivos.AutoSize = true;
            this.ChkIncluirInactivos.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkIncluirInactivos.ForeColor = System.Drawing.Color.White;
            this.ChkIncluirInactivos.Location = new System.Drawing.Point(438, 89);
            this.ChkIncluirInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.ChkIncluirInactivos.Name = "ChkIncluirInactivos";
            this.ChkIncluirInactivos.Size = new System.Drawing.Size(171, 27);
            this.ChkIncluirInactivos.TabIndex = 62;
            this.ChkIncluirInactivos.Text = "Mostrar desactivados";
            this.ChkIncluirInactivos.UseVisualStyleBackColor = true;
            this.ChkIncluirInactivos.CheckedChanged += new System.EventHandler(this.ChkIncluirInactivos_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Activecolor = System.Drawing.Color.LightSteelBlue;
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
            this.btnConsultar.Location = new System.Drawing.Point(388, 63);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnConsultar.OnHovercolor = System.Drawing.Color.LightSteelBlue;
            this.btnConsultar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnConsultar.selected = false;
            this.btnConsultar.Size = new System.Drawing.Size(43, 43);
            this.btnConsultar.TabIndex = 63;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultar.Textcolor = System.Drawing.Color.White;
            this.btnConsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmEstCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(642, 687);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.ChkIncluirInactivos);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmDescuentos);
            this.Controls.Add(this.rwEstCateg);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstCategorias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEstCategorias_FormClosing);
            this.Load += new System.EventHandler(this.FrmEstCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwEstCateg;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmDescuentos;
        private System.Windows.Forms.CheckBox ChkIncluirInactivos;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultar;
    }
}