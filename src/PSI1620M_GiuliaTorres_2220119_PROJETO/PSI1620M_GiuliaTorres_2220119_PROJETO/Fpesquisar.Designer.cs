
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class Fpesquisar
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
            this.botoesRodape1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcBotoesRodape();
            this.sair1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcSair();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbGrupos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // botoesRodape1
            // 
            this.botoesRodape1.Location = new System.Drawing.Point(75, 500);
            this.botoesRodape1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botoesRodape1.Name = "botoesRodape1";
            this.botoesRodape1.Size = new System.Drawing.Size(1174, 112);
            this.botoesRodape1.TabIndex = 0;
            // 
            // sair1
            // 
            this.sair1.Location = new System.Drawing.Point(1166, 12);
            this.sair1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sair1.Name = "sair1";
            this.sair1.Size = new System.Drawing.Size(86, 34);
            this.sair1.TabIndex = 1;
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(75, 54);
            this.tbPesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(961, 26);
            this.tbPesquisa.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1047, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbGrupos
            // 
            this.lbGrupos.FormattingEnabled = true;
            this.lbGrupos.ItemHeight = 20;
            this.lbGrupos.Location = new System.Drawing.Point(459, 158);
            this.lbGrupos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbGrupos.Name = "lbGrupos";
            this.lbGrupos.Size = new System.Drawing.Size(428, 264);
            this.lbGrupos.TabIndex = 4;
            this.lbGrupos.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // Fpesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 618);
            this.Controls.Add(this.lbGrupos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.sair1);
            this.Controls.Add(this.botoesRodape1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fpesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.Fpesquisar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcBotoesRodape botoesRodape1;
        private UcSair sair1;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbGrupos;
    }
}