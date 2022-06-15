
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fhome));
            this.bNovoGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnome = new System.Windows.Forms.Label();
            this.lbGrupos = new System.Windows.Forms.ListBox();
            this.ucSair1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcSair();
            this.botoesRodape1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcBotoesRodape();
            this.SuspendLayout();
            // 
            // bNovoGrupo
            // 
            this.bNovoGrupo.BackColor = System.Drawing.Color.Transparent;
            this.bNovoGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bNovoGrupo.FlatAppearance.BorderSize = 0;
            this.bNovoGrupo.Image = ((System.Drawing.Image)(resources.GetObject("bNovoGrupo.Image")));
            this.bNovoGrupo.Location = new System.Drawing.Point(763, 253);
            this.bNovoGrupo.Name = "bNovoGrupo";
            this.bNovoGrupo.Size = new System.Drawing.Size(57, 48);
            this.bNovoGrupo.TabIndex = 1;
            this.bNovoGrupo.UseVisualStyleBackColor = false;
            this.bNovoGrupo.Click += new System.EventHandler(this.bNovoGrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Olá, ";
            // 
            // lnome
            // 
            this.lnome.AutoSize = true;
            this.lnome.BackColor = System.Drawing.Color.Transparent;
            this.lnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnome.Location = new System.Drawing.Point(173, 23);
            this.lnome.Name = "lnome";
            this.lnome.Size = new System.Drawing.Size(0, 31);
            this.lnome.TabIndex = 3;
            // 
            // lbGrupos
            // 
            this.lbGrupos.FormattingEnabled = true;
            this.lbGrupos.Location = new System.Drawing.Point(135, 113);
            this.lbGrupos.Name = "lbGrupos";
            this.lbGrupos.Size = new System.Drawing.Size(351, 160);
            this.lbGrupos.TabIndex = 6;
            this.lbGrupos.DoubleClick += new System.EventHandler(this.lbGrupos_SelectedIndexChanged);
            // 
            // ucSair1
            // 
            this.ucSair1.BackColor = System.Drawing.Color.Transparent;
            this.ucSair1.Location = new System.Drawing.Point(783, 11);
            this.ucSair1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ucSair1.Name = "ucSair1";
            this.ucSair1.Size = new System.Drawing.Size(50, 33);
            this.ucSair1.TabIndex = 7;
            // 
            // botoesRodape1
            // 
            this.botoesRodape1.BackColor = System.Drawing.Color.Transparent;
            this.botoesRodape1.Location = new System.Drawing.Point(50, 325);
            this.botoesRodape1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.botoesRodape1.Name = "botoesRodape1";
            this.botoesRodape1.Size = new System.Drawing.Size(783, 77);
            this.botoesRodape1.TabIndex = 4;
            // 
            // Fhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(895, 402);
            this.Controls.Add(this.ucSair1);
            this.Controls.Add(this.lbGrupos);
            this.Controls.Add(this.botoesRodape1);
            this.Controls.Add(this.lnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNovoGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Fhome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bNovoGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lnome;
        private UcBotoesRodape botoesRodape1;
        private System.Windows.Forms.ListBox lbGrupos;
        private UcSair ucSair1;
    }
}