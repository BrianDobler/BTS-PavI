namespace BTS_3k2_2020.Pantallas.Asignaciones
{
    partial class FrmAsignarAsignacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignarAsignacion));
            this.txtCantidadMasked = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdAsig = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtbAsignarDesc = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo_bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoAsig = new System.Windows.Forms.TextBox();
            this.txtNombreAsig = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmModificarDescuentos = new System.Windows.Forms.PictureBox();
            this.btnGuardarAsigAsignac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtbAsignarDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidadMasked
            // 
            this.txtCantidadMasked.Location = new System.Drawing.Point(182, 189);
            this.txtCantidadMasked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadMasked.Mask = "99999";
            this.txtCantidadMasked.Name = "txtCantidadMasked";
            this.txtCantidadMasked.Size = new System.Drawing.Size(230, 27);
            this.txtCantidadMasked.TabIndex = 47;
            this.txtCantidadMasked.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label11.Location = new System.Drawing.Point(3, 189);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 28);
            this.label11.TabIndex = 46;
            this.label11.Text = "Ingrese la cantidad:";
            // 
            // txtIdAsig
            // 
            this.txtIdAsig.Enabled = false;
            this.txtIdAsig.Location = new System.Drawing.Point(183, 78);
            this.txtIdAsig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdAsig.Name = "txtIdAsig";
            this.txtIdAsig.Size = new System.Drawing.Size(229, 27);
            this.txtIdAsig.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label10.Location = new System.Drawing.Point(52, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 28);
            this.label10.TabIndex = 44;
            this.label10.Text = "ID Asignación:";
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
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtbAsignarDesc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtbAsignarDesc.Location = new System.Drawing.Point(473, 71);
            this.dtbAsignarDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtbAsignarDesc.Name = "dtbAsignarDesc";
            this.dtbAsignarDesc.ReadOnly = true;
            this.dtbAsignarDesc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtbAsignarDesc.Size = new System.Drawing.Size(405, 237);
            this.dtbAsignarDesc.TabIndex = 41;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Width = 5;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 120;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha ";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 120;
            // 
            // sueldo_bruto
            // 
            this.sueldo_bruto.HeaderText = "Sueldo bruto";
            this.sueldo_bruto.Name = "sueldo_bruto";
            this.sueldo_bruto.ReadOnly = true;
            this.sueldo_bruto.Width = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(468, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 26);
            this.label9.TabIndex = 40;
            this.label9.Text = "Seleccione el Sueldo.";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtMontoAsig
            // 
            this.txtMontoAsig.Enabled = false;
            this.txtMontoAsig.Location = new System.Drawing.Point(182, 152);
            this.txtMontoAsig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoAsig.Name = "txtMontoAsig";
            this.txtMontoAsig.Size = new System.Drawing.Size(230, 27);
            this.txtMontoAsig.TabIndex = 39;
            // 
            // txtNombreAsig
            // 
            this.txtNombreAsig.Enabled = false;
            this.txtNombreAsig.Location = new System.Drawing.Point(183, 115);
            this.txtNombreAsig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreAsig.Name = "txtNombreAsig";
            this.txtNombreAsig.Size = new System.Drawing.Size(229, 27);
            this.txtNombreAsig.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(17, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 28);
            this.label4.TabIndex = 37;
            this.label4.Text = "Monto asignación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre asignación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(246, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "ASIGNACIÓN";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(135, 23);
            this.bunifuCustomLabel1.TabIndex = 49;
            this.bunifuCustomLabel1.Text = "Asignar Asignación";
            // 
            // SalirFrmModificarDescuentos
            // 
            this.SalirFrmModificarDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmModificarDescuentos.Image")));
            this.SalirFrmModificarDescuentos.Location = new System.Drawing.Point(12, 12);
            this.SalirFrmModificarDescuentos.Name = "SalirFrmModificarDescuentos";
            this.SalirFrmModificarDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmModificarDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmModificarDescuentos.TabIndex = 48;
            this.SalirFrmModificarDescuentos.TabStop = false;
            this.SalirFrmModificarDescuentos.Click += new System.EventHandler(this.SalirFrmModificarDescuentos_Click);
            // 
            // btnGuardarAsigAsignac
            // 
            this.btnGuardarAsigAsignac.Activecolor = System.Drawing.Color.Transparent;
            this.btnGuardarAsigAsignac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarAsigAsignac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarAsigAsignac.BorderRadius = 0;
            this.btnGuardarAsigAsignac.ButtonText = "Confirmar Asignación";
            this.btnGuardarAsigAsignac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAsigAsignac.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarAsigAsignac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsigAsignac.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarAsigAsignac.Iconimage = null;
            this.btnGuardarAsigAsignac.Iconimage_right = null;
            this.btnGuardarAsigAsignac.Iconimage_right_Selected = null;
            this.btnGuardarAsigAsignac.Iconimage_Selected = null;
            this.btnGuardarAsigAsignac.IconMarginLeft = 0;
            this.btnGuardarAsigAsignac.IconMarginRight = 0;
            this.btnGuardarAsigAsignac.IconRightVisible = true;
            this.btnGuardarAsigAsignac.IconRightZoom = 0D;
            this.btnGuardarAsigAsignac.IconVisible = true;
            this.btnGuardarAsigAsignac.IconZoom = 40D;
            this.btnGuardarAsigAsignac.IsTab = false;
            this.btnGuardarAsigAsignac.Location = new System.Drawing.Point(333, 324);
            this.btnGuardarAsigAsignac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAsigAsignac.Name = "btnGuardarAsigAsignac";
            this.btnGuardarAsigAsignac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnGuardarAsigAsignac.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarAsigAsignac.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGuardarAsigAsignac.selected = false;
            this.btnGuardarAsigAsignac.Size = new System.Drawing.Size(255, 48);
            this.btnGuardarAsigAsignac.TabIndex = 50;
            this.btnGuardarAsigAsignac.Text = "Confirmar Asignación";
            this.btnGuardarAsigAsignac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarAsigAsignac.Textcolor = System.Drawing.Color.White;
            this.btnGuardarAsigAsignac.TextFont = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsigAsignac.Click += new System.EventHandler(this.btnGuardarAsigAsignac_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCantidadMasked);
            this.panel1.Controls.Add(this.txtNombreAsig);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtMontoAsig);
            this.panel1.Controls.Add(this.txtIdAsig);
            this.panel1.Location = new System.Drawing.Point(19, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 237);
            this.panel1.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(11, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ingrese los datos requeridos y seleccione lo que desea hacer.\r\n";
            // 
            // FrmAsignarAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(897, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarAsigAsignac);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmModificarDescuentos);
            this.Controls.Add(this.dtbAsignarDesc);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAsignarAsignacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsignarAsignacion";
            this.Load += new System.EventHandler(this.FrmAsignarAsignacion_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAsignarAsignacion_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtbAsignarDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCantidadMasked;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdAsig;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtbAsignarDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo_bruto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoAsig;
        private System.Windows.Forms.TextBox txtNombreAsig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmModificarDescuentos;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarAsigAsignac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}