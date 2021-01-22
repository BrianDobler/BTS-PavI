namespace BTS_3k2_2020.Pantallas.Descuentos
{
    partial class FrmAsignarDescuento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignarDescuento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCantidadMasked = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMontoDesc = new System.Windows.Forms.TextBox();
            this.txtNombreDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmModificarDescuentos = new System.Windows.Forms.PictureBox();
            this.btnGuardarModDesc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtbAsignarDesc = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo_bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbAsignarDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidadMasked
            // 
            this.txtCantidadMasked.Location = new System.Drawing.Point(181, 197);
            this.txtCantidadMasked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadMasked.Mask = "99999";
            this.txtCantidadMasked.Name = "txtCantidadMasked";
            this.txtCantidadMasked.Size = new System.Drawing.Size(244, 27);
            this.txtCantidadMasked.TabIndex = 34;
            this.txtCantidadMasked.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label11.Location = new System.Drawing.Point(5, 196);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 28);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ingrese la cantidad:";
            // 
            // txtIdDesc
            // 
            this.txtIdDesc.Enabled = false;
            this.txtIdDesc.Location = new System.Drawing.Point(181, 81);
            this.txtIdDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdDesc.Name = "txtIdDesc";
            this.txtIdDesc.Size = new System.Drawing.Size(244, 27);
            this.txtIdDesc.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label10.Location = new System.Drawing.Point(54, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 28);
            this.label10.TabIndex = 31;
            this.label10.Text = "ID descuento:";
            // 
            // txtMontoDesc
            // 
            this.txtMontoDesc.Enabled = false;
            this.txtMontoDesc.Location = new System.Drawing.Point(181, 156);
            this.txtMontoDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoDesc.Name = "txtMontoDesc";
            this.txtMontoDesc.Size = new System.Drawing.Size(244, 27);
            this.txtMontoDesc.TabIndex = 26;
            // 
            // txtNombreDesc
            // 
            this.txtNombreDesc.Enabled = false;
            this.txtNombreDesc.Location = new System.Drawing.Point(181, 118);
            this.txtNombreDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreDesc.Name = "txtNombreDesc";
            this.txtNombreDesc.Size = new System.Drawing.Size(244, 27);
            this.txtNombreDesc.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(19, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Monto descuento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(5, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre descuento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(162, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "DESCUENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, -39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Asignar descuento a un sueldo.";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(132, 23);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "Asignar Descuento";
            // 
            // SalirFrmModificarDescuentos
            // 
            this.SalirFrmModificarDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmModificarDescuentos.Image")));
            this.SalirFrmModificarDescuentos.Location = new System.Drawing.Point(12, 12);
            this.SalirFrmModificarDescuentos.Name = "SalirFrmModificarDescuentos";
            this.SalirFrmModificarDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmModificarDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmModificarDescuentos.TabIndex = 35;
            this.SalirFrmModificarDescuentos.TabStop = false;
            this.SalirFrmModificarDescuentos.Click += new System.EventHandler(this.SalirFrmModificarDescuentos_Click);
            // 
            // btnGuardarModDesc
            // 
            this.btnGuardarModDesc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarModDesc.BorderRadius = 0;
            this.btnGuardarModDesc.ButtonText = "Confirmar Descuento";
            this.btnGuardarModDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarModDesc.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarModDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModDesc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarModDesc.Iconimage = null;
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
            this.btnGuardarModDesc.Location = new System.Drawing.Point(305, 335);
            this.btnGuardarModDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarModDesc.Name = "btnGuardarModDesc";
            this.btnGuardarModDesc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarModDesc.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarModDesc.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGuardarModDesc.selected = false;
            this.btnGuardarModDesc.Size = new System.Drawing.Size(314, 48);
            this.btnGuardarModDesc.TabIndex = 37;
            this.btnGuardarModDesc.Text = "Confirmar Descuento";
            this.btnGuardarModDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarModDesc.Textcolor = System.Drawing.Color.White;
            this.btnGuardarModDesc.TextFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModDesc.Click += new System.EventHandler(this.btnGuardarModDesc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMontoDesc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCantidadMasked);
            this.panel1.Controls.Add(this.txtNombreDesc);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtIdDesc);
            this.panel1.Location = new System.Drawing.Point(17, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 243);
            this.panel1.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(21, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ingrese los datos requeridos y seleccione lo que desea hacer.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(482, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Por favor seleccione el Sueldo.";
            // 
            // dtbAsignarDesc
            // 
            this.dtbAsignarDesc.AllowUserToDeleteRows = false;
            this.dtbAsignarDesc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.dtbAsignarDesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbAsignarDesc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.usuario,
            this.fecha,
            this.sueldo_bruto});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtbAsignarDesc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtbAsignarDesc.Location = new System.Drawing.Point(486, 71);
            this.dtbAsignarDesc.Name = "dtbAsignarDesc";
            this.dtbAsignarDesc.ReadOnly = true;
            this.dtbAsignarDesc.Size = new System.Drawing.Size(340, 243);
            this.dtbAsignarDesc.TabIndex = 40;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "Column1";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // sueldo_bruto
            // 
            this.sueldo_bruto.HeaderText = "Sueldo Bruto";
            this.sueldo_bruto.Name = "sueldo_bruto";
            this.sueldo_bruto.ReadOnly = true;
            // 
            // FrmAsignarDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(851, 399);
            this.Controls.Add(this.dtbAsignarDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarModDesc);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmModificarDescuentos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAsignarDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsignarDescuento";
            this.Load += new System.EventHandler(this.FrmAsignarDescuento_Load_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAsignarDescuento_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbAsignarDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCantidadMasked;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMontoDesc;
        private System.Windows.Forms.TextBox txtNombreDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmModificarDescuentos;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarModDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtbAsignarDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo_bruto;
    }
}