
namespace CapaPresentacion
{
    partial class FrmMantRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantRegistro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textIdTutoria = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textIdEstudiante = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.topFormulario = new System.Windows.Forms.Panel();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dgvRegistroDocenteTutoria = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvEstudianteRegistrarTutoria = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBuscarTutoriaDocente = new System.Windows.Forms.TextBox();
            this.txtBuscarTutoriaEstudiante = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.topFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroDocenteTutoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudianteRegistrarTutoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TUTORIA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(767, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textIdTutoria
            // 
            this.textIdTutoria.BackColor = System.Drawing.Color.White;
            this.textIdTutoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIdTutoria.Enabled = false;
            this.textIdTutoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdTutoria.ForeColor = System.Drawing.Color.Black;
            this.textIdTutoria.Location = new System.Drawing.Point(26, 91);
            this.textIdTutoria.Margin = new System.Windows.Forms.Padding(4);
            this.textIdTutoria.Name = "textIdTutoria";
            this.textIdTutoria.Size = new System.Drawing.Size(209, 21);
            this.textIdTutoria.TabIndex = 71;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 82);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(237, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // textIdEstudiante
            // 
            this.textIdEstudiante.BackColor = System.Drawing.Color.White;
            this.textIdEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIdEstudiante.Enabled = false;
            this.textIdEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdEstudiante.ForeColor = System.Drawing.Color.Black;
            this.textIdEstudiante.Location = new System.Drawing.Point(19, 342);
            this.textIdEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.textIdEstudiante.Name = "textIdEstudiante";
            this.textIdEstudiante.Size = new System.Drawing.Size(209, 21);
            this.textIdEstudiante.TabIndex = 69;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 333);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "ID TUTORIA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "               GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(14, 501);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(236, 59);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "               GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "ID ESTUDIANTE";
            // 
            // topFormulario
            // 
            this.topFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.topFormulario.Controls.Add(this.label1);
            this.topFormulario.Controls.Add(this.pictureBox1);
            this.topFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFormulario.Location = new System.Drawing.Point(0, 0);
            this.topFormulario.Margin = new System.Windows.Forms.Padding(4);
            this.topFormulario.Name = "topFormulario";
            this.topFormulario.Size = new System.Drawing.Size(809, 44);
            this.topFormulario.TabIndex = 61;
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this.topFormulario;
            this.MoverFormulario.Vertical = true;
            // 
            // dgvRegistroDocenteTutoria
            // 
            this.dgvRegistroDocenteTutoria.AllowUserToAddRows = false;
            this.dgvRegistroDocenteTutoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRegistroDocenteTutoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistroDocenteTutoria.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRegistroDocenteTutoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistroDocenteTutoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegistroDocenteTutoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroDocenteTutoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistroDocenteTutoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroDocenteTutoria.ColumnHeadersVisible = false;
            this.dgvRegistroDocenteTutoria.DoubleBuffered = true;
            this.dgvRegistroDocenteTutoria.EnableHeadersVisualStyles = false;
            this.dgvRegistroDocenteTutoria.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvRegistroDocenteTutoria.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvRegistroDocenteTutoria.Location = new System.Drawing.Point(17, 63);
            this.dgvRegistroDocenteTutoria.Name = "dgvRegistroDocenteTutoria";
            this.dgvRegistroDocenteTutoria.ReadOnly = true;
            this.dgvRegistroDocenteTutoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRegistroDocenteTutoria.RowHeadersVisible = false;
            this.dgvRegistroDocenteTutoria.RowHeadersWidth = 51;
            this.dgvRegistroDocenteTutoria.RowTemplate.Height = 24;
            this.dgvRegistroDocenteTutoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistroDocenteTutoria.Size = new System.Drawing.Size(462, 150);
            this.dgvRegistroDocenteTutoria.TabIndex = 72;
            this.dgvRegistroDocenteTutoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroDocenteTutoria_CellClick);
            this.dgvRegistroDocenteTutoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroDocenteTutoria_CellContentClick);
            this.dgvRegistroDocenteTutoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvRegistroDocenteTutoria_MouseClick);
            // 
            // dgvEstudianteRegistrarTutoria
            // 
            this.dgvEstudianteRegistrarTutoria.AllowUserToAddRows = false;
            this.dgvEstudianteRegistrarTutoria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEstudianteRegistrarTutoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstudianteRegistrarTutoria.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEstudianteRegistrarTutoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudianteRegistrarTutoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudianteRegistrarTutoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstudianteRegistrarTutoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudianteRegistrarTutoria.ColumnHeadersVisible = false;
            this.dgvEstudianteRegistrarTutoria.DoubleBuffered = true;
            this.dgvEstudianteRegistrarTutoria.EnableHeadersVisualStyles = false;
            this.dgvEstudianteRegistrarTutoria.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvEstudianteRegistrarTutoria.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvEstudianteRegistrarTutoria.Location = new System.Drawing.Point(18, 68);
            this.dgvEstudianteRegistrarTutoria.Name = "dgvEstudianteRegistrarTutoria";
            this.dgvEstudianteRegistrarTutoria.ReadOnly = true;
            this.dgvEstudianteRegistrarTutoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstudianteRegistrarTutoria.RowHeadersVisible = false;
            this.dgvEstudianteRegistrarTutoria.RowHeadersWidth = 51;
            this.dgvEstudianteRegistrarTutoria.RowTemplate.Height = 24;
            this.dgvEstudianteRegistrarTutoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudianteRegistrarTutoria.Size = new System.Drawing.Size(462, 150);
            this.dgvEstudianteRegistrarTutoria.TabIndex = 73;
            this.dgvEstudianteRegistrarTutoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudianteRegistrarTutoria_CellContentClick);
            // 
            // txtBuscarTutoriaDocente
            // 
            this.txtBuscarTutoriaDocente.Location = new System.Drawing.Point(17, 25);
            this.txtBuscarTutoriaDocente.Name = "txtBuscarTutoriaDocente";
            this.txtBuscarTutoriaDocente.Size = new System.Drawing.Size(324, 22);
            this.txtBuscarTutoriaDocente.TabIndex = 74;
            this.txtBuscarTutoriaDocente.TextChanged += new System.EventHandler(this.txtBuscarTutoriaDocente_TextChanged);
            // 
            // txtBuscarTutoriaEstudiante
            // 
            this.txtBuscarTutoriaEstudiante.Location = new System.Drawing.Point(18, 23);
            this.txtBuscarTutoriaEstudiante.Name = "txtBuscarTutoriaEstudiante";
            this.txtBuscarTutoriaEstudiante.Size = new System.Drawing.Size(330, 22);
            this.txtBuscarTutoriaEstudiante.TabIndex = 75;
            this.txtBuscarTutoriaEstudiante.TextChanged += new System.EventHandler(this.txtBuscarTutoriaEstudiante_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarTutoriaDocente);
            this.groupBox1.Controls.Add(this.dgvRegistroDocenteTutoria);
            this.groupBox1.Location = new System.Drawing.Point(277, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 227);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR TUTOR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarTutoriaEstudiante);
            this.groupBox2.Controls.Add(this.dgvEstudianteRegistrarTutoria);
            this.groupBox2.Location = new System.Drawing.Point(276, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 243);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR ESTUDIANTE";
            // 
            // FrmMantRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textIdTutoria);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textIdEstudiante);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.topFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMantRegistro";
            this.Text = "Tutor";
            this.Load += new System.EventHandler(this.FrmMantRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.topFormulario.ResumeLayout(false);
            this.topFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroDocenteTutoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudianteRegistrarTutoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox textIdTutoria;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox textIdEstudiante;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel topFormulario;
        private Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRegistroDocenteTutoria;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEstudianteRegistrarTutoria;
        private System.Windows.Forms.TextBox txtBuscarTutoriaDocente;
        private System.Windows.Forms.TextBox txtBuscarTutoriaEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}