﻿
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class Fperfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fperfil));
            this.label1 = new System.Windows.Forms.Label();
            this.bPreferencias = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.botoesRodape1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcBotoesRodape();
            this.ucSair1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcSair();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configurações";
            // 
            // bPreferencias
            // 
            this.bPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPreferencias.Image = ((System.Drawing.Image)(resources.GetObject("bPreferencias.Image")));
            this.bPreferencias.Location = new System.Drawing.Point(283, 127);
            this.bPreferencias.Margin = new System.Windows.Forms.Padding(2);
            this.bPreferencias.Name = "bPreferencias";
            this.bPreferencias.Size = new System.Drawing.Size(119, 78);
            this.bPreferencias.TabIndex = 2;
            this.bPreferencias.UseVisualStyleBackColor = true;
            this.bPreferencias.Click += new System.EventHandler(this.bPreferencias_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPerfil.Image = ((System.Drawing.Image)(resources.GetObject("bPerfil.Image")));
            this.bPerfil.Location = new System.Drawing.Point(488, 127);
            this.bPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(119, 78);
            this.bPerfil.TabIndex = 3;
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // botoesRodape1
            // 
            this.botoesRodape1.Location = new System.Drawing.Point(50, 325);
            this.botoesRodape1.Margin = new System.Windows.Forms.Padding(1);
            this.botoesRodape1.Name = "botoesRodape1";
            this.botoesRodape1.Size = new System.Drawing.Size(783, 73);
            this.botoesRodape1.TabIndex = 4;
            // 
            // ucSair1
            // 
            this.ucSair1.Location = new System.Drawing.Point(782, 13);
            this.ucSair1.Margin = new System.Windows.Forms.Padding(2);
            this.ucSair1.Name = "ucSair1";
            this.ucSair1.Size = new System.Drawing.Size(50, 33);
            this.ucSair1.TabIndex = 5;
            // 
            // Fperfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 402);
            this.Controls.Add(this.ucSair1);
            this.Controls.Add(this.botoesRodape1);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.bPreferencias);
            this.Controls.Add(this.label1);
            this.Name = "Fperfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPreferencias;
        private System.Windows.Forms.Button bPerfil;
        private UcBotoesRodape botoesRodape1;
        private UcSair ucSair1;
    }
}