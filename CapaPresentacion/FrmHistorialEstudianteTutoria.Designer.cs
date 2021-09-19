
namespace CapaPresentacion
{
    partial class FrmHistorialEstudianteTutoria
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
            this.TablaHistorial = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaHistorial
            // 
            this.TablaHistorial.AllowUserToAddRows = false;
            this.TablaHistorial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TablaHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaHistorial.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.TablaHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaHistorial.DoubleBuffered = true;
            this.TablaHistorial.EnableHeadersVisualStyles = false;
            this.TablaHistorial.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.TablaHistorial.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.TablaHistorial.Location = new System.Drawing.Point(28, 33);
            this.TablaHistorial.Name = "TablaHistorial";
            this.TablaHistorial.ReadOnly = true;
            this.TablaHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TablaHistorial.RowHeadersWidth = 51;
            this.TablaHistorial.RowTemplate.Height = 24;
            this.TablaHistorial.Size = new System.Drawing.Size(566, 258);
            this.TablaHistorial.TabIndex = 0;
            this.TablaHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaHistorial_CellClick);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(223, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHistorialEstudianteTutoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablaHistorial);
            this.Name = "FrmHistorialEstudianteTutoria";
            this.Text = "FrmHistorialEstudianteTutoria";
            this.Load += new System.EventHandler(this.FrmHistorialEstudianteTutoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid TablaHistorial;
    }
}