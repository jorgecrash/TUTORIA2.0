
namespace CapaPresentacion
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.TablaRegistro = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRegistrarEstudianteATutoria = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRegistro)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Principal
            // 
            this.panel_Principal.Controls.Add(this.TablaRegistro);
            this.panel_Principal.Controls.Add(this.panel9);
            this.panel_Principal.Controls.Add(this.panel8);
            this.panel_Principal.Controls.Add(this.panel7);
            this.panel_Principal.Controls.Add(this.panel5);
            this.panel_Principal.Controls.Add(this.panel6);
            this.panel_Principal.Controls.Add(this.panel4);
            this.panel_Principal.Controls.Add(this.panel3);
            this.panel_Principal.Controls.Add(this.panel2);
            this.panel_Principal.Controls.Add(this.panel1);
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 0);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(1040, 612);
            this.panel_Principal.TabIndex = 0;
            // 
            // TablaRegistro
            // 
            this.TablaRegistro.AllowUserToAddRows = false;
            this.TablaRegistro.AllowUserToOrderColumns = true;
            this.TablaRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaRegistro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.TablaRegistro.BackgroundColor = System.Drawing.Color.White;
            this.TablaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaRegistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.TablaRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.TablaRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaRegistro.Location = new System.Drawing.Point(29, 115);
            this.TablaRegistro.Name = "TablaRegistro";
            this.TablaRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaRegistro.RowHeadersVisible = false;
            this.TablaRegistro.RowHeadersWidth = 51;
            this.TablaRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaRegistro.Size = new System.Drawing.Size(982, 458);
            this.TablaRegistro.TabIndex = 33;
            this.TablaRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaRegistro_CellContentClick);
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.MinimumWidth = 6;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Width = 69;
            // 
            // ELIMINAR
            // 
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
            this.panel9.Location = new System.Drawing.Point(29, 573);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(982, 20);
            this.panel9.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SlateGray;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1011, 115);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 478);
            this.panel8.TabIndex = 31;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SlateGray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(19, 115);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 478);
            this.panel7.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateGray;
            this.panel5.Controls.Add(this.btnRegistrarEstudianteATutoria);
            this.panel5.Controls.Add(this.textBuscar);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(19, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1002, 76);
            this.panel5.TabIndex = 29;
            // 
            // btnRegistrarEstudianteATutoria
            // 
            this.btnRegistrarEstudianteATutoria.ActiveBorderThickness = 1;
            this.btnRegistrarEstudianteATutoria.ActiveCornerRadius = 20;
            this.btnRegistrarEstudianteATutoria.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnRegistrarEstudianteATutoria.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistrarEstudianteATutoria.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarEstudianteATutoria.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegistrarEstudianteATutoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarEstudianteATutoria.BackgroundImage")));
            this.btnRegistrarEstudianteATutoria.ButtonText = "Registrar Estudiante a Tutoria";
            this.btnRegistrarEstudianteATutoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarEstudianteATutoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEstudianteATutoria.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarEstudianteATutoria.IdleBorderThickness = 1;
            this.btnRegistrarEstudianteATutoria.IdleCornerRadius = 20;
            this.btnRegistrarEstudianteATutoria.IdleFillColor = System.Drawing.Color.White;
            this.btnRegistrarEstudianteATutoria.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarEstudianteATutoria.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarEstudianteATutoria.Location = new System.Drawing.Point(369, 14);
            this.btnRegistrarEstudianteATutoria.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrarEstudianteATutoria.Name = "btnRegistrarEstudianteATutoria";
            this.btnRegistrarEstudianteATutoria.Size = new System.Drawing.Size(253, 44);
            this.btnRegistrarEstudianteATutoria.TabIndex = 33;
            this.btnRegistrarEstudianteATutoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrarEstudianteATutoria.Click += new System.EventHandler(this.btnRegistrarEstudianteATutoria_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(69, 24);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(235, 21);
            this.textBuscar.TabIndex = 7;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel6.Controls.Add(this.Salir);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(19, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1002, 20);
            this.panel6.TabIndex = 28;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Image = global::CapaPresentacion.Properties.Resources.cerrar;
            this.Salir.Location = new System.Drawing.Point(969, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(27, 20);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 8;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1021, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 574);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 574);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 19);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 19);
            this.panel1.TabIndex = 8;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 612);
            this.Controls.Add(this.panel_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.panel_Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaRegistro)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Principal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrarEstudianteATutoria;
        private System.Windows.Forms.DataGridView TablaRegistro;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}