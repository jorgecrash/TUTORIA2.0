
namespace CapaPresentacion
{
    partial class FrmDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocente));
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panel_principal_medio = new System.Windows.Forms.Panel();
            this.TablaDocente = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNuevoDocente = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_principal.SuspendLayout();
            this.panel_principal_medio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDocente)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_principal
            // 
            this.panel_principal.Controls.Add(this.panel_principal_medio);
            this.panel_principal.Controls.Add(this.panel4);
            this.panel_principal.Controls.Add(this.panel3);
            this.panel_principal.Controls.Add(this.panel2);
            this.panel_principal.Controls.Add(this.panel1);
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(0, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(1040, 612);
            this.panel_principal.TabIndex = 0;
            // 
            // panel_principal_medio
            // 
            this.panel_principal_medio.Controls.Add(this.TablaDocente);
            this.panel_principal_medio.Controls.Add(this.panel9);
            this.panel_principal_medio.Controls.Add(this.panel8);
            this.panel_principal_medio.Controls.Add(this.panel7);
            this.panel_principal_medio.Controls.Add(this.panel5);
            this.panel_principal_medio.Controls.Add(this.panel6);
            this.panel_principal_medio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal_medio.Location = new System.Drawing.Point(19, 19);
            this.panel_principal_medio.Name = "panel_principal_medio";
            this.panel_principal_medio.Size = new System.Drawing.Size(1002, 574);
            this.panel_principal_medio.TabIndex = 4;
            // 
            // TablaDocente
            // 
            this.TablaDocente.AllowUserToAddRows = false;
            this.TablaDocente.AllowUserToOrderColumns = true;
            this.TablaDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablaDocente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.TablaDocente.BackgroundColor = System.Drawing.Color.White;
            this.TablaDocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaDocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TablaDocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.TablaDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.TablaDocente.DefaultCellStyle = dataGridViewCellStyle1;
            this.TablaDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaDocente.Location = new System.Drawing.Point(10, 96);
            this.TablaDocente.Name = "TablaDocente";
            this.TablaDocente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaDocente.RowHeadersVisible = false;
            this.TablaDocente.RowHeadersWidth = 51;
            this.TablaDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaDocente.Size = new System.Drawing.Size(982, 458);
            this.TablaDocente.TabIndex = 28;
            this.TablaDocente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDocente_CellContentClick);
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
            this.panel9.Location = new System.Drawing.Point(10, 554);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(982, 20);
            this.panel9.TabIndex = 27;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SlateGray;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(992, 96);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 478);
            this.panel8.TabIndex = 26;
            this.panel8.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SlateGray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 96);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 478);
            this.panel7.TabIndex = 25;
            this.panel7.Click += new System.EventHandler(this.panel9_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateGray;
            this.panel5.Controls.Add(this.textBuscar);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.btnNuevoDocente);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1002, 76);
            this.panel5.TabIndex = 24;
            this.panel5.Click += new System.EventHandler(this.panel9_Click);
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
            // btnNuevoDocente
            // 
            this.btnNuevoDocente.ActiveBorderThickness = 1;
            this.btnNuevoDocente.ActiveCornerRadius = 20;
            this.btnNuevoDocente.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.btnNuevoDocente.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevoDocente.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuevoDocente.BackColor = System.Drawing.Color.SlateGray;
            this.btnNuevoDocente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoDocente.BackgroundImage")));
            this.btnNuevoDocente.ButtonText = "Agregar Docente";
            this.btnNuevoDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoDocente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDocente.ForeColor = System.Drawing.Color.DarkRed;
            this.btnNuevoDocente.IdleBorderThickness = 1;
            this.btnNuevoDocente.IdleCornerRadius = 20;
            this.btnNuevoDocente.IdleFillColor = System.Drawing.Color.White;
            this.btnNuevoDocente.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNuevoDocente.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuevoDocente.Location = new System.Drawing.Point(362, 15);
            this.btnNuevoDocente.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevoDocente.Name = "btnNuevoDocente";
            this.btnNuevoDocente.Size = new System.Drawing.Size(181, 44);
            this.btnNuevoDocente.TabIndex = 1;
            this.btnNuevoDocente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoDocente.Click += new System.EventHandler(this.btnNuevoDocente_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.panel6.Controls.Add(this.Salir);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1002, 20);
            this.panel6.TabIndex = 23;
            this.panel6.Click += new System.EventHandler(this.panel9_Click);
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
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 574);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 19);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 19);
            this.panel1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.panel_principal_medio;
            // 
            // FrmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 612);
            this.Controls.Add(this.panel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDocente";
            this.Text = "FrmDocente";
            this.panel_principal.ResumeLayout(false);
            this.panel_principal_medio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDocente)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_principal_medio;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuevoDocente;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.DataGridView TablaDocente;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}