
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarEstudianteTutoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaBuscarTutoriaEstudiante = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBuscarTutoriaEstudiante = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscarTutoriaEstudiante)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaBuscarTutoriaEstudiante);
            this.groupBox1.Controls.Add(this.txtBuscarTutoriaEstudiante);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(11, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(505, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tablaBuscarTutoriaEstudiante
            // 
            this.tablaBuscarTutoriaEstudiante.AllowUserToAddRows = false;
            this.tablaBuscarTutoriaEstudiante.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaBuscarTutoriaEstudiante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaBuscarTutoriaEstudiante.BackgroundColor = System.Drawing.Color.Snow;
            this.tablaBuscarTutoriaEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaBuscarTutoriaEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaBuscarTutoriaEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaBuscarTutoriaEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaBuscarTutoriaEstudiante.DoubleBuffered = true;
            this.tablaBuscarTutoriaEstudiante.EnableHeadersVisualStyles = false;
            this.tablaBuscarTutoriaEstudiante.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.tablaBuscarTutoriaEstudiante.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.tablaBuscarTutoriaEstudiante.Location = new System.Drawing.Point(11, 62);
            this.tablaBuscarTutoriaEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.tablaBuscarTutoriaEstudiante.Name = "tablaBuscarTutoriaEstudiante";
            this.tablaBuscarTutoriaEstudiante.ReadOnly = true;
            this.tablaBuscarTutoriaEstudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaBuscarTutoriaEstudiante.RowHeadersWidth = 51;
            this.tablaBuscarTutoriaEstudiante.RowTemplate.Height = 24;
            this.tablaBuscarTutoriaEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaBuscarTutoriaEstudiante.Size = new System.Drawing.Size(490, 205);
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
            this.txtBuscarTutoriaEstudiante.Location = new System.Drawing.Point(11, 15);
            this.txtBuscarTutoriaEstudiante.Name = "txtBuscarTutoriaEstudiante";
            this.txtBuscarTutoriaEstudiante.Size = new System.Drawing.Size(300, 42);
            this.txtBuscarTutoriaEstudiante.TabIndex = 0;
            this.txtBuscarTutoriaEstudiante.text = "";
            this.txtBuscarTutoriaEstudiante.OnTextChange += new System.EventHandler(this.txtBuscarTutoriaEstudiante_OnTextChange);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 344);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.button1.Image = global::CapaPresentacion.Properties.Resources.clos1;
            this.button1.Location = new System.Drawing.Point(503, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 20);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 24);
            this.panel2.TabIndex = 5;
            // 
            // FrmBuscarEstudianteTutoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 344);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBuscarEstudianteTutoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarEstudianteTutoria";
            this.Load += new System.EventHandler(this.FrmBuscarEstudianteTutoria_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscarTutoriaEstudiante)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaBuscarTutoriaEstudiante;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarTutoriaEstudiante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}