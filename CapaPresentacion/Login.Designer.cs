﻿
namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnIniciar = new System.Windows.Forms.Button();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 2;
            this.gunaElipse1.TargetControl = this;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 11;
            this.bunifuElipse3.TargetControl = this.pictureBox1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.cerrar;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources._163809372_3937792012970771_1511004919839933106_n1;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Name = "lblError";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.LL;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.labelContraseña);
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Controls.Add(this.labelUsuario);
            this.panel3.Controls.Add(this.txtcontraseña);
            this.panel3.Controls.Add(this.txtusuario);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // labelContraseña
            // 
            resources.ApplyResources(this.labelContraseña, "labelContraseña");
            this.labelContraseña.BackColor = System.Drawing.Color.Transparent;
            this.labelContraseña.ForeColor = System.Drawing.Color.White;
            this.labelContraseña.Name = "labelContraseña";
            // 
            // labelUsuario
            // 
            resources.ApplyResources(this.labelUsuario, "labelUsuario");
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Name = "labelUsuario";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.SeaShell;
            resources.ApplyResources(this.txtcontraseña, "txtcontraseña");
            this.txtcontraseña.Name = "txtcontraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.SeaShell;
            resources.ApplyResources(this.txtusuario, "txtusuario");
            this.txtusuario.Name = "txtusuario";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            resources.ApplyResources(this.btnIniciar, "btnIniciar");
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.OldLace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblError;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btnIniciar;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
    }
}