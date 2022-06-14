
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configurações";
            // 
            // bPreferencias
            // 
            this.bPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPreferencias.Image = ((System.Drawing.Image)(resources.GetObject("bPreferencias.Image")));
            this.bPreferencias.Location = new System.Drawing.Point(424, 195);
            this.bPreferencias.Name = "bPreferencias";
            this.bPreferencias.Size = new System.Drawing.Size(178, 120);
            this.bPreferencias.TabIndex = 2;
            this.bPreferencias.UseVisualStyleBackColor = true;
            this.bPreferencias.Click += new System.EventHandler(this.bPreferencias_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPerfil.Image = ((System.Drawing.Image)(resources.GetObject("bPerfil.Image")));
            this.bPerfil.Location = new System.Drawing.Point(732, 195);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(178, 120);
            this.bPerfil.TabIndex = 3;
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // botoesRodape1
            // 
            this.botoesRodape1.BackColor = System.Drawing.Color.Transparent;
            this.botoesRodape1.Location = new System.Drawing.Point(75, 500);
            this.botoesRodape1.Margin = new System.Windows.Forms.Padding(2);
            this.botoesRodape1.Name = "botoesRodape1";
            this.botoesRodape1.Size = new System.Drawing.Size(1174, 112);
            this.botoesRodape1.TabIndex = 4;
            // 
            // ucSair1
            // 
            this.ucSair1.BackColor = System.Drawing.Color.Transparent;
            this.ucSair1.Location = new System.Drawing.Point(1173, 20);
            this.ucSair1.Name = "ucSair1";
            this.ucSair1.Size = new System.Drawing.Size(75, 51);
            this.ucSair1.TabIndex = 5;
            // 
            // Fperfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1342, 618);
            this.Controls.Add(this.ucSair1);
            this.Controls.Add(this.botoesRodape1);
            this.Controls.Add(this.bPerfil);
            this.Controls.Add(this.bPreferencias);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private UcBotoesRodape botoesRodape1;
        private UcSair ucSair1;
    }
}