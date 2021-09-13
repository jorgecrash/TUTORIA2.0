
namespace CapaPresentacion
{
    partial class FrmEstudiante
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiante));
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel_principal = new System.Windows.Forms.Panel();
            this.Panel_principal_medio = new System.Windows.Forms.Panel();
            this.TablaEstudiante = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNuevoEstudiante = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel_principal.SuspendLayout();
            this.Panel_principal_medio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiante)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 2;
            this.gunaElipse2.TargetControl = this;
            // 
            // panel_principal
            // 
            this.panel_principal.Controls.Add(this.Panel_principal_medio);
            this.panel_principal.Controls.Add(this.panel6);
            this.panel_principal.Controls.Add(this.panel4);
            this.panel_principal.Controls.Add(this.panel3);
            this.panel_principal.Controls.Add(this.panel1);
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(0, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(1092, 699);
            this.panel_principal.TabIndex = 1;
            // 
            // Panel_principal_medio
            // 
            this.Panel_principal_medio.BackColor = System.Drawing.Color.Transparent;
            this.Panel_principal_medio.Controls.Add(this.TablaEstudiante);
            this.Panel_principal_medio.Controls.Add(this.panel9);
            this.Panel_principal_medio.Controls.Add(this.panel8);
            this.Panel_principal_medio.Controls.Add(this.panel7);
            this.Panel_principal_medio.Controls.Add(this.panel5);
            this.Panel_principal_medio.Controls.Add(this.panel2);
            this.Panel_principal_medio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_principal_medio.Location = new System.Drawing.Point(19, 19);
            this.Panel_principal_medio.Name = "Panel_principal_medio";
            this.Panel_principal_medio.Size = new System.Drawing.Size(1028, 655);
            this.Panel_principal_medio.TabIndex = 15;
            // 
            // TablaEstudiante
            // 
            this.TablaEstudiante.AllowUserToAddRows = false;
            this.TablaEstudiante.AllowUserToOrderColumns = true;
            this.TablaEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaEstudiante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.TablaEstudiante.BackgroundColor = System.Drawing.Color.White;
            this.TablaEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaEstudiante.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.TablaEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR,
            this.ELIMINAR});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaEstudiante.DefaultCellStyle = dataGridViewCellStyle1;
            this.TablaEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaEstudiante.Location = new System.Drawing.Point(10, 96);
            this.TablaEstudiante.Name = "TablaEstudiante";
            this.TablaEstudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaEstudiante.RowHeadersVisible = false;
            this.TablaEstudiante.RowHeadersWidth = 51;
            this.TablaEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaEstudiante.Size = new System.Drawing.Size(1008, 539);
            this.TablaEstudiante.TabIndex = 25;
            this.TablaEstudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaEstudiante_CellContentClick);
            // 
            // EDITAR
            // 
            this.EDITAR.FillWeight = 1.196411F;
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.MinimumWidth = 6;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Width = 69;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.FillWeight = 198.8035F;
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
            this.ELIMINAR.MinimumWidth = 6;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Width = 80;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SlateGray;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(10, 635);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1008, 20);
            this.panel9.TabIndex = 22;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SlateGray;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1018, 96);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 559);
            this.panel8.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SlateGray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 96);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 559);
            this.panel7.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateGray;
            this.panel5.Controls.Add(this.textBuscar);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.btnNuevoEstudiante);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1028, 76);
            this.panel5.TabIndex = 18;
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(68, 25);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(235, 21);
            this.textBuscar.TabIndex = 7;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNuevoEstudiante
            // 
            this.btnNuevoEstudiante.ActiveBorderThickness = 1;
            this.btnNuevoEstudiante.ActiveCornerRadius = 20;
            this.btnNuevoEstudiante.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnNuevoEstudiante.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevoEstudiante.ActiveLineColor = System.Drawing.Color.Maroon;
            this.btnNuevoEstudiante.BackColor = System.Drawing.Color.SlateGray;
            this.btnNuevoEstudiante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoEstudiante.BackgroundImage")));
            this.btnNuevoEstudiante.ButtonText = "Agregar Estudiante";
            this.btnNuevoEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEstudiante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEstudiante.ForeColor = System.Drawing.Color.Maroon;
            this.btnNuevoEstudiante.IdleBorderThickness = 1;
            this.btnNuevoEstudiante.IdleCornerRadius = 20;
            this.btnNuevoEstudiante.IdleFillColor = System.Drawing.Color.Maroon;
            this.btnNuevoEstudiante.IdleForecolor = System.Drawing.Color.White;
            this.btnNuevoEstudiante.IdleLineColor = System.Drawing.Color.Maroon;
            this.btnNuevoEstudiante.Location = new System.Drawing.Point(362, 15);
            this.btnNuevoEstudiante.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevoEstudiante.Name = "btnNuevoEstudiante";
            this.btnNuevoEstudiante.Size = new System.Drawing.Size(181, 44);
            this.btnNuevoEstudiante.TabIndex = 1;
            this.btnNuevoEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoEstudiante.Click += new System.EventHandler(this.btnNuevoEstudiante_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.Salir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 20);
            this.panel2.TabIndex = 17;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Image = global::CapaPresentacion.Properties.Resources.cerrar;
            this.Salir.Location = new System.Drawing.Point(995, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(27, 20);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 8;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(19, 674);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1028, 25);
            this.panel6.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(19, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 19);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1047, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 699);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 699);
            this.panel1.TabIndex = 9;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 5;
            this.gunaElipse3.TargetControl = this.Panel_principal_medio;
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 699);
            this.Controls.Add(this.panel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiante";
            this.Text = "FrmEstudiante";
            this.panel_principal.ResumeLayout(false);
            this.Panel_principal_medio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiante)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private System.Windows.Forms.Panel Panel_principal_medio;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuevoEstudiante;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.DataGridView TablaEstudiante;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}