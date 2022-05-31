
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class Fhome
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
            this.bNovoGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnome = new System.Windows.Forms.Label();
            this.sair1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.Sair();
            this.botoesRodape1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.BotoesRodape();
            this.SuspendLayout();
            // 
            // bNovoGrupo
            // 
            this.bNovoGrupo.Location = new System.Drawing.Point(1013, 391);
            this.bNovoGrupo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bNovoGrupo.Name = "bNovoGrupo";
            this.bNovoGrupo.Size = new System.Drawing.Size(237, 74);
            this.bNovoGrupo.TabIndex = 1;
            this.bNovoGrupo.Text = "Novo Grupo";
            this.bNovoGrupo.UseVisualStyleBackColor = true;
            this.bNovoGrupo.Click += new System.EventHandler(this.bNovoGrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Olá, ";
            // 
            // lnome
            // 
            this.lnome.AutoSize = true;
            this.lnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnome.Location = new System.Drawing.Point(165, 35);
            this.lnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnome.Name = "lnome";
            this.lnome.Size = new System.Drawing.Size(0, 47);
            this.lnome.TabIndex = 3;
            // 
            // sair1
            // 
            this.sair1.Location = new System.Drawing.Point(1164, 12);
            this.sair1.Name = "sair1";
            this.sair1.Size = new System.Drawing.Size(86, 35);
            this.sair1.TabIndex = 5;
            // 
            // botoesRodape1
            // 
            this.botoesRodape1.Location = new System.Drawing.Point(75, 500);
            this.botoesRodape1.Name = "botoesRodape1";
            this.botoesRodape1.Size = new System.Drawing.Size(1175, 118);
            this.botoesRodape1.TabIndex = 4;
            // 
            // Fhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 618);
            this.Controls.Add(this.sair1);
            this.Controls.Add(this.botoesRodape1);
            this.Controls.Add(this.lnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNovoGrupo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bNovoGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lnome;
        private BotoesRodape botoesRodape1;
        private Sair sair1;
    }
}