namespace BTS_3k2_2020.Pantallas.Sueldos
{
    partial class FrmVerDetalleSueldo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerDetalleSueldo));
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DgvHistoricos = new System.Windows.Forms.DataGridView();
            this.id_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSueldo_bruto = new System.Windows.Forms.TextBox();
            this.TxtId_usuario = new System.Windows.Forms.TextBox();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.LblSueldo_bruto = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblId_usuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SalirFrmModificarDescuentos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistoricos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(206, 130);
            this.TxtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.ReadOnly = true;
            this.TxtFecha.Size = new System.Drawing.Size(221, 27);
            this.TxtFecha.TabIndex = 35;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(206, 90);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(221, 27);
            this.TxtNombre.TabIndex = 34;
            // 
            // DgvHistoricos
            // 
            this.DgvHistoricos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHistoricos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHistoricos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistoricos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_perfil,
            this.Perfil,
            this.fecha,
            this.sueldo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHistoricos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvHistoricos.Location = new System.Drawing.Point(496, 77);
            this.DgvHistoricos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvHistoricos.Name = "DgvHistoricos";

            this.DgvHistoricos.Size = new System.Drawing.Size(434, 222);

            this.DgvHistoricos.TabIndex = 33;
            // 
            // id_perfil
            // 
            this.id_perfil.HeaderText = "ID Perfil";
            this.id_perfil.Name = "id_perfil";
            this.id_perfil.ReadOnly = true;
            // 
            // Perfil
            // 
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // sueldo
            // 
            this.sueldo.HeaderText = "Sueldo";
            this.sueldo.Name = "sueldo";
            this.sueldo.ReadOnly = true;
            // 
            // TxtSueldo_bruto
            // 
            this.TxtSueldo_bruto.Location = new System.Drawing.Point(206, 167);
            this.TxtSueldo_bruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSueldo_bruto.Name = "TxtSueldo_bruto";
            this.TxtSueldo_bruto.ReadOnly = true;
            this.TxtSueldo_bruto.Size = new System.Drawing.Size(221, 27);
            this.TxtSueldo_bruto.TabIndex = 31;
            // 
            // TxtId_usuario
            // 
            this.TxtId_usuario.Location = new System.Drawing.Point(206, 52);
            this.TxtId_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtId_usuario.Name = "TxtId_usuario";
            this.TxtId_usuario.ReadOnly = true;
            this.TxtId_usuario.Size = new System.Drawing.Size(221, 27);
            this.TxtId_usuario.TabIndex = 30;
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.LblNombreUsuario.Location = new System.Drawing.Point(9, 89);
            this.LblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(172, 28);
            this.LblNombreUsuario.TabIndex = 63;
            this.LblNombreUsuario.Text = "Nombre del Usuario:";
            // 
            // LblSueldo_bruto
            // 
            this.LblSueldo_bruto.AutoSize = true;
            this.LblSueldo_bruto.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSueldo_bruto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.LblSueldo_bruto.Location = new System.Drawing.Point(66, 166);
            this.LblSueldo_bruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSueldo_bruto.Name = "LblSueldo_bruto";
            this.LblSueldo_bruto.Size = new System.Drawing.Size(115, 28);
            this.LblSueldo_bruto.TabIndex = 62;
            this.LblSueldo_bruto.Text = "Sueldo Bruto:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.LblFecha.Location = new System.Drawing.Point(117, 129);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(64, 28);
            this.LblFecha.TabIndex = 61;
            this.LblFecha.Text = "Fecha:";
            // 
            // LblId_usuario
            // 
            this.LblId_usuario.AutoSize = true;
            this.LblId_usuario.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.LblId_usuario.Location = new System.Drawing.Point(58, 52);
            this.LblId_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblId_usuario.Name = "LblId_usuario";
            this.LblId_usuario.Size = new System.Drawing.Size(123, 28);
            this.LblId_usuario.TabIndex = 60;
            this.LblId_usuario.Text = "ID del Usuario:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.LblNombreUsuario);
            this.panel1.Controls.Add(this.TxtId_usuario);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LblSueldo_bruto);
            this.panel1.Controls.Add(this.TxtSueldo_bruto);
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.LblId_usuario);
            this.panel1.Controls.Add(this.TxtFecha);
            this.panel1.Location = new System.Drawing.Point(17, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 222);
            this.panel1.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.label6.Location = new System.Drawing.Point(23, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 23);
            this.label6.TabIndex = 65;
            this.label6.Text = "Ingrese los datos requeridos y seleccione lo que desea hacer.\r\n";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 23);
            this.bunifuCustomLabel1.TabIndex = 67;
            this.bunifuCustomLabel1.Text = "Detalle de Sueldo";
            // 
            // SalirFrmModificarDescuentos
            // 
            this.SalirFrmModificarDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("SalirFrmModificarDescuentos.Image")));
            this.SalirFrmModificarDescuentos.Location = new System.Drawing.Point(12, 12);
            this.SalirFrmModificarDescuentos.Name = "SalirFrmModificarDescuentos";
            this.SalirFrmModificarDescuentos.Size = new System.Drawing.Size(36, 33);
            this.SalirFrmModificarDescuentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirFrmModificarDescuentos.TabIndex = 66;
            this.SalirFrmModificarDescuentos.TabStop = false;
            this.SalirFrmModificarDescuentos.Click += new System.EventHandler(this.SalirFrmModificarDescuentos_Click);
            // 
            // FrmVerDetalleSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(956, 320);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SalirFrmModificarDescuentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvHistoricos);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVerDetalleSueldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerDetalleSueldo";
            this.Load += new System.EventHandler(this.FrmVerDetalleSueldo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmVerDetalleSueldo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistoricos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirFrmModificarDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView DgvHistoricos;
        private System.Windows.Forms.TextBox TxtSueldo_bruto;
        private System.Windows.Forms.TextBox TxtId_usuario;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Label LblSueldo_bruto;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblId_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox SalirFrmModificarDescuentos;
    }
}