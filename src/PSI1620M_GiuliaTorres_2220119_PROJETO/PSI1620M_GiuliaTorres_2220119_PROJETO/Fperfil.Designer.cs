
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
            this.label1 = new System.Windows.Forms.Label();
            this.bPreferencias = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.botoesRodape1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.BotoesRodape();
            this.sair1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.Sair();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configurações";
            // 
            // bPreferencias
            // 
            this.bPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPreferencias.Location = new System.Drawing.Point(425, 196);
            this.bPreferencias.Name = "bPreferencias";
            this.bPreferencias.Size = new System.Drawing.Size(178, 120);
            this.bPreferencias.TabIndex = 2;
            this.bPreferencias.Text = "Alterar Peferencias";
            this.bPreferencias.UseVisualStyleBackColor = true;
            this.bPreferencias.Click += new System.EventHandler(this.bPreferencias_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPerfil.Location = new System.Drawing.Point(732, 196);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(178, 120);
            this.bPerfil.TabIndex = 3;
            this.bPerfil.Text = "Perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            // 
            // botoesRodape1
            // 
            this.botoesRodape1.Location = new System.Drawing.Point(75, 500);
            this.botoesRodape1.Name = "botoesRodape1";
            this.botoesRodape1.Size = new System.Drawing.Size(1175, 112);
            this.botoesRodape1.TabIndex = 4;
            // 
            // sair1
            // 
            this.sair1.Location = new System.Drawing.Point(1165, 12);
            this.sair1.Name = "sair1";
            this.sair1.Size = new System.Drawing.Size(85, 34);
            this.sair1.TabIndex = 5;
            // 
            // Fperfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 618);
            this.Controls.Add(this.sair1);
            this.Controls.Add(this.botoesRodape1);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.bPreferencias);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private BotoesRodape botoesRodape1;
        private Sair sair1;
    }
}