﻿
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class Fcarrinho
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
            this.bSideBar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bPerto = new System.Windows.Forms.Button();
            this.cbGrupos = new System.Windows.Forms.ComboBox();
            this.lRecomendaGrupo = new System.Windows.Forms.Label();
            this.sair1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcSair();
            this.botoesRodape1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcBotoesRodape();
            this.bProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Todos os produtos";
            // 
            // bSideBar
            // 
            this.bSideBar.Location = new System.Drawing.Point(3, 20);
            this.bSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.bSideBar.Name = "bSideBar";
            this.bSideBar.Size = new System.Drawing.Size(50, 23);
            this.bSideBar.TabIndex = 3;
            this.bSideBar.Text = "_____";
            this.bSideBar.UseVisualStyleBackColor = true;
            this.bSideBar.Click += new System.EventHandler(this.bSide_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 77);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(727, 244);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // bPerto
            // 
            this.bPerto.Location = new System.Drawing.Point(251, 54);
            this.bPerto.Margin = new System.Windows.Forms.Padding(2);
            this.bPerto.Name = "bPerto";
            this.bPerto.Size = new System.Drawing.Size(105, 22);
            this.bPerto.TabIndex = 5;
            this.bPerto.Text = "Perto do mim";
            this.bPerto.UseVisualStyleBackColor = true;
            this.bPerto.Click += new System.EventHandler(this.bPerto_Click);
            // 
            // cbGrupos
            // 
            this.cbGrupos.FormattingEnabled = true;
            this.cbGrupos.Location = new System.Drawing.Point(753, 55);
            this.cbGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrupos.Name = "cbGrupos";
            this.cbGrupos.Size = new System.Drawing.Size(82, 21);
            this.cbGrupos.TabIndex = 6;
            // 
            // lRecomendaGrupo
            // 
            this.lRecomendaGrupo.AutoSize = true;
            this.lRecomendaGrupo.Location = new System.Drawing.Point(580, 60);
            this.lRecomendaGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRecomendaGrupo.Name = "lRecomendaGrupo";
            this.lRecomendaGrupo.Size = new System.Drawing.Size(163, 13);
            this.lRecomendaGrupo.TabIndex = 7;
            this.lRecomendaGrupo.Text = "Recomendado para o meu grupo";
            // 
            // sair1
            // 
            this.sair1.Location = new System.Drawing.Point(777, 8);
            this.sair1.Margin = new System.Windows.Forms.Padding(1);
            this.sair1.Name = "sair1";
            this.sair1.Size = new System.Drawing.Size(57, 22);
            this.sair1.TabIndex = 1;
            // 
            // botoesRodape1
            // 
            this.botoesRodape1.Location = new System.Drawing.Point(50, 325);
            this.botoesRodape1.Margin = new System.Windows.Forms.Padding(1);
            this.botoesRodape1.Name = "botoesRodape1";
            this.botoesRodape1.Size = new System.Drawing.Size(783, 73);
            this.botoesRodape1.TabIndex = 0;
            // 
            // bProdutos
            // 
            this.bProdutos.Location = new System.Drawing.Point(107, 53);
            this.bProdutos.Name = "bProdutos";
            this.bProdutos.Size = new System.Drawing.Size(121, 23);
            this.bProdutos.TabIndex = 8;
            this.bProdutos.Text = "Todos os Produtos";
            this.bProdutos.UseVisualStyleBackColor = true;
            this.bProdutos.Click += new System.EventHandler(this.Fcarrinho_Load);
            // 
            // Fcarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 402);
            this.Controls.Add(this.bProdutos);
            this.Controls.Add(this.lRecomendaGrupo);
            this.Controls.Add(this.cbGrupos);
            this.Controls.Add(this.bPerto);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bSideBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sair1);
            this.Controls.Add(this.botoesRodape1);
            this.Name = "Fcarrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.Fcarrinho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcBotoesRodape botoesRodape1;
        private UcSair sair1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSideBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bPerto;
        private System.Windows.Forms.ComboBox cbGrupos;
        private System.Windows.Forms.Label lRecomendaGrupo;
        private System.Windows.Forms.Button bProdutos;
    }
}