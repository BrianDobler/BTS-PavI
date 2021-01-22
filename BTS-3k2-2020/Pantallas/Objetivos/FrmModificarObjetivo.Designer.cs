namespace BTS_3k2_2020.Pantallas.Objetivos
{
    partial class FrmModificarObjetivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarObjetivo));
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.lblIDObjetivo = new System.Windows.Forms.Label();
            this.lblNombreCorto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDObjetivo = new System.Windows.Forms.TextBox();
            this.txtNombreCortoActual = new System.Windows.Forms.TextBox();
            this.txtNombreLargoActual = new System.Windows.Forms.TextBox();
            this.txtNuevoNombreLargo = new System.Windows.Forms.TextBox();
            this.txtNuevoNombreCorto = new System.Windows.Forms.TextBox();
            this.lblNuevoNombreLargo = new System.Windows.Forms.Label();
            this.lblNuevoNombreCorto = new System.Windows.Forms.Label();
            this.btnGuardarModUsuar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNuevoID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(13, 11);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(36, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 43;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblIDObjetivo
            // 
            this.lblIDObjetivo.AutoSize = true;
            this.lblIDObjetivo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.lblIDObjetivo.Location = new System.Drawing.Point(94, 57);
            this.lblIDObjetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDObjetivo.Name = "lblIDObjetivo";
            this.lblIDObjetivo.Size = new System.Drawing.Size(101, 28);
            this.lblIDObjetivo.TabIndex = 45;
            this.lblIDObjetivo.Text = "ID Objetivo:";
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCorto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.lblNombreCorto.Location = new System.Drawing.Point(17, 93);
            this.lblNombreCorto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(181, 28);
            this.lblNombreCorto.TabIndex = 46;
            this.lblNombreCorto.Text = "Nombre corto actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(17, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nombre largo actual:";
            // 
            // txtIDObjetivo
            // 
            this.txtIDObjetivo.Enabled = false;
            this.txtIDObjetivo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDObjetivo.Location = new System.Drawing.Point(206, 56);
            this.txtIDObjetivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDObjetivo.Name = "txtIDObjetivo";
            this.txtIDObjetivo.ReadOnly = true;
            this.txtIDObjetivo.Size = new System.Drawing.Size(219, 27);
            this.txtIDObjetivo.TabIndex = 48;
            this.txtIDObjetivo.TextChanged += new System.EventHandler(this.txtIDObjetivo_TextChanged);
            // 
            // txtNombreCortoActual
            // 
            this.txtNombreCortoActual.Enabled = false;
            this.txtNombreCortoActual.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCortoActual.Location = new System.Drawing.Point(206, 93);
            this.txtNombreCortoActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCortoActual.Name = "txtNombreCortoActual";
            this.txtNombreCortoActual.ReadOnly = true;
            this.txtNombreCortoActual.Size = new System.Drawing.Size(219, 27);
            this.txtNombreCortoActual.TabIndex = 49;
            // 
            // txtNombreLargoActual
            // 
            this.txtNombreLargoActual.Enabled = false;
            this.txtNombreLargoActual.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLargoActual.Location = new System.Drawing.Point(206, 130);
            this.txtNombreLargoActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreLargoActual.Name = "txtNombreLargoActual";
            this.txtNombreLargoActual.ReadOnly = true;
            this.txtNombreLargoActual.Size = new System.Drawing.Size(219, 27);
            this.txtNombreLargoActual.TabIndex = 50;
            // 
            // txtNuevoNombreLargo
            // 
            this.txtNuevoNombreLargo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoNombreLargo.Location = new System.Drawing.Point(178, 102);
            this.txtNuevoNombreLargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoNombreLargo.Name = "txtNuevoNombreLargo";
            this.txtNuevoNombreLargo.Size = new System.Drawing.Size(216, 27);
            this.txtNuevoNombreLargo.TabIndex = 55;
            // 
            // txtNuevoNombreCorto
            // 
            this.txtNuevoNombreCorto.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoNombreCorto.Location = new System.Drawing.Point(178, 65);
            this.txtNuevoNombreCorto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoNombreCorto.Name = "txtNuevoNombreCorto";
            this.txtNuevoNombreCorto.Size = new System.Drawing.Size(216, 27);
            this.txtNuevoNombreCorto.TabIndex = 54;
            // 
            // lblNuevoNombreLargo
            // 
            this.lblNuevoNombreLargo.AutoSize = true;
            this.lblNuevoNombreLargo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoNombreLargo.ForeColor = System.Drawing.Color.White;
            this.lblNuevoNombreLargo.Location = new System.Drawing.Point(14, 104);
            this.lblNuevoNombreLargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoNombreLargo.Name = "lblNuevoNombreLargo";
            this.lblNuevoNombreLargo.Size = new System.Drawing.Size(157, 28);
            this.lblNuevoNombreLargo.TabIndex = 53;
            this.lblNuevoNombreLargo.Text = "Nuevo nom. Largo:";
            // 
            // lblNuevoNombreCorto
            // 
            this.lblNuevoNombreCorto.AutoSize = true;
            this.lblNuevoNombreCorto.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoNombreCorto.ForeColor = System.Drawing.Color.White;
            this.lblNuevoNombreCorto.Location = new System.Drawing.Point(15, 68);
            this.lblNuevoNombreCorto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoNombreCorto.Name = "lblNuevoNombreCorto";
            this.lblNuevoNombreCorto.Size = new System.Drawing.Size(156, 28);
            this.lblNuevoNombreCorto.TabIndex = 52;
            this.lblNuevoNombreCorto.Text = "Nuevo nom. Corto:";
            // 
            // btnGuardarModUsuar
            // 
            this.btnGuardarModUsuar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarModUsuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModUsuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarModUsuar.BorderRadius = 0;
            this.btnGuardarModUsuar.ButtonText = "Guardar";
            this.btnGuardarModUsuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarModUsuar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarModUsuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnGuardarModUsuar.Location = new System.Drawing.Point(357, 271);
            this.btnGuardarModUsuar.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.btnGuardarModUsuar.Name = "btnGuardarModUsuar";
            this.btnGuardarModUsuar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModUsuar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGuardarModUsuar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGuardarModUsuar.selected = false;
            this.btnGuardarModUsuar.Size = new System.Drawing.Size(221, 52);
            this.btnGuardarModUsuar.TabIndex = 56;
            this.btnGuardarModUsuar.Text = "Guardar";
            this.btnGuardarModUsuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarModUsuar.Textcolor = System.Drawing.Color.White;
            this.btnGuardarModUsuar.TextFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModUsuar.Click += new System.EventHandler(this.btnGuardarModUsuar_Click);
            // 
            // txtNuevoID
            // 
            this.txtNuevoID.Enabled = false;
            this.txtNuevoID.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoID.Location = new System.Drawing.Point(458, 286);
            this.txtNuevoID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoID.Name = "txtNuevoID";
            this.txtNuevoID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNuevoID.Size = new System.Drawing.Size(56, 27);
            this.txtNuevoID.TabIndex = 58;
            this.txtNuevoID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtNombreCortoActual);
            this.panel1.Controls.Add(this.lblIDObjetivo);
            this.panel1.Controls.Add(this.lblNombreCorto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIDObjetivo);
            this.panel1.Controls.Add(this.txtNombreLargoActual);
            this.panel1.Location = new System.Drawing.Point(16, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 181);
            this.panel1.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label13.Location = new System.Drawing.Point(18, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(404, 23);
            this.label13.TabIndex = 51;
            this.label13.Text = "Ingrese los datos requeridos y seleccione lo que desea hacer.\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(100)))), ((int)(((byte)(116)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNuevoNombreLargo);
            this.panel2.Controls.Add(this.txtNuevoNombreLargo);
            this.panel2.Controls.Add(this.lblNuevoNombreCorto);
            this.panel2.Controls.Add(this.txtNuevoNombreCorto);
            this.panel2.Location = new System.Drawing.Point(482, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 181);
            this.panel2.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Ingrese aqui abajo los nuevos valores.";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(57, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(133, 23);
            this.bunifuCustomLabel1.TabIndex = 61;
            this.bunifuCustomLabel1.Text = "Modificar Objetivos";
            // 
            // FrmModificarObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(917, 338);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarModUsuar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNuevoID);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModificarObjetivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarObjetivo";
            this.Load += new System.EventHandler(this.FrmModificarObjetivo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmModificarObjetivo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblIDObjetivo;
        private System.Windows.Forms.Label lblNombreCorto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDObjetivo;
        private System.Windows.Forms.TextBox txtNombreCortoActual;
        private System.Windows.Forms.TextBox txtNombreLargoActual;
        private System.Windows.Forms.TextBox txtNuevoNombreLargo;
        private System.Windows.Forms.TextBox txtNuevoNombreCorto;
        private System.Windows.Forms.Label lblNuevoNombreLargo;
        private System.Windows.Forms.Label lblNuevoNombreCorto;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarModUsuar;
        private System.Windows.Forms.TextBox txtNuevoID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}