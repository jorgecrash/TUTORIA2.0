
namespace CapaPresentacion
{
    partial class FrmBuscarEstudianteTutoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarEstudianteTutoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaBuscarTutoriaEstudiante = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBuscarTutoriaEstudiante = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscarTutoriaEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaBuscarTutoriaEstudiante);
            this.groupBox1.Controls.Add(this.txtBuscarTutoriaEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 333);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tablaBuscarTutoriaEstudiante
            // 
            this.tablaBuscarTutoriaEstudiante.AllowUserToAddRows = false;
            this.tablaBuscarTutoriaEstudiante.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaBuscarTutoriaEstudiante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaBuscarTutoriaEstudiante.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tablaBuscarTutoriaEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaBuscarTutoriaEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaBuscarTutoriaEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaBuscarTutoriaEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaBuscarTutoriaEstudiante.DoubleBuffered = true;
            this.tablaBuscarTutoriaEstudiante.EnableHeadersVisualStyles = false;
            this.tablaBuscarTutoriaEstudiante.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.tablaBuscarTutoriaEstudiante.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.tablaBuscarTutoriaEstudiante.Location = new System.Drawing.Point(15, 96);
            this.tablaBuscarTutoriaEstudiante.Name = "tablaBuscarTutoriaEstudiante";
            this.tablaBuscarTutoriaEstudiante.ReadOnly = true;
            this.tablaBuscarTutoriaEstudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaBuscarTutoriaEstudiante.RowHeadersWidth = 51;
            this.tablaBuscarTutoriaEstudiante.RowTemplate.Height = 24;
            this.tablaBuscarTutoriaEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaBuscarTutoriaEstudiante.Size = new System.Drawing.Size(634, 217);
            this.tablaBuscarTutoriaEstudiante.TabIndex = 1;
            this.tablaBuscarTutoriaEstudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaBuscarTutoriaEstudiante_CellClick);
            this.tablaBuscarTutoriaEstudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaBuscarTutoriaEstudiante_CellContentClick);
            this.tablaBuscarTutoriaEstudiante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaBuscarTutoriaEstudiante_CellDoubleClick);
            // 
            // txtBuscarTutoriaEstudiante
            // 
            this.txtBuscarTutoriaEstudiante.BackColor = System.Drawing.Color.Silver;
            this.txtBuscarTutoriaEstudiante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarTutoriaEstudiante.BackgroundImage")));
            this.txtBuscarTutoriaEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarTutoriaEstudiante.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarTutoriaEstudiante.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarTutoriaEstudiante.Icon")));
            this.txtBuscarTutoriaEstudiante.Location = new System.Drawing.Point(15, 19);
            this.txtBuscarTutoriaEstudiante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarTutoriaEstudiante.Name = "txtBuscarTutoriaEstudiante";
            this.txtBuscarTutoriaEstudiante.Size = new System.Drawing.Size(400, 52);
            this.txtBuscarTutoriaEstudiante.TabIndex = 0;
            this.txtBuscarTutoriaEstudiante.text = "Bunifu TextBox";
            this.txtBuscarTutoriaEstudiante.OnTextChange += new System.EventHandler(this.txtBuscarTutoriaEstudiante_OnTextChange);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalir.Location = new System.Drawing.Point(287, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 43);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmBuscarEstudianteTutoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 424);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBuscarEstudianteTutoria";
            this.Text = "FrmBuscarEstudianteTutoria";
            this.Load += new System.EventHandler(this.FrmBuscarEstudianteTutoria_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscarTutoriaEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaBuscarTutoriaEstudiante;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarTutoriaEstudiante;
        private System.Windows.Forms.Button btnSalir;
    }
}