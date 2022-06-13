
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bPerto = new System.Windows.Forms.Button();
            this.cbGrupos = new System.Windows.Forms.ComboBox();
            this.lRecomendaGrupo = new System.Windows.Forms.Label();
            this.bProdutos = new System.Windows.Forms.Button();
            this.llMinhasCategorias = new System.Windows.Forms.LinkLabel();
            this.llCategorias = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sair1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcSair();
            this.botoesRodape1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcBotoesRodape();
            this.bPesquisar = new System.Windows.Forms.Button();
            this.ucSair1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcSair();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Todos os produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(149, 77);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(685, 244);
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
            this.cbGrupos.Location = new System.Drawing.Point(660, 55);
            this.cbGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrupos.Name = "cbGrupos";
            this.cbGrupos.Size = new System.Drawing.Size(82, 21);
            this.cbGrupos.TabIndex = 6;
            // 
            // lRecomendaGrupo
            // 
            this.lRecomendaGrupo.AutoSize = true;
            this.lRecomendaGrupo.Location = new System.Drawing.Point(493, 62);
            this.lRecomendaGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRecomendaGrupo.Name = "lRecomendaGrupo";
            this.lRecomendaGrupo.Size = new System.Drawing.Size(163, 13);
            this.lRecomendaGrupo.TabIndex = 7;
            this.lRecomendaGrupo.Text = "Recomendado para o meu grupo";
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
            // llMinhasCategorias
            // 
            this.llMinhasCategorias.AutoSize = true;
            this.llMinhasCategorias.Location = new System.Drawing.Point(3, 77);
            this.llMinhasCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llMinhasCategorias.Name = "llMinhasCategorias";
            this.llMinhasCategorias.Size = new System.Drawing.Size(103, 13);
            this.llMinhasCategorias.TabIndex = 9;
            this.llMinhasCategorias.TabStop = true;
            this.llMinhasCategorias.Text = "Minhas Preferências";
            this.llMinhasCategorias.Click += new System.EventHandler(this.llMinhasCategorias_Click);
            // 
            // llCategorias
            // 
            this.llCategorias.AutoSize = true;
            this.llCategorias.Location = new System.Drawing.Point(3, 103);
            this.llCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llCategorias.Name = "llCategorias";
            this.llCategorias.Size = new System.Drawing.Size(57, 13);
            this.llCategorias.TabIndex = 10;
            this.llCategorias.TabStop = true;
            this.llCategorias.Text = "Categorias";
            this.llCategorias.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCategorias_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 185);
            this.panel1.TabIndex = 11;
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
            // bPesquisar
            // 
            this.bPesquisar.Location = new System.Drawing.Point(747, 53);
            this.bPesquisar.Name = "bPesquisar";
            this.bPesquisar.Size = new System.Drawing.Size(75, 23);
            this.bPesquisar.TabIndex = 12;
            this.bPesquisar.Text = "Pesquisar";
            this.bPesquisar.UseVisualStyleBackColor = true;
            this.bPesquisar.Click += new System.EventHandler(this.cbGrupos_SelectionChangeCommitted);
            // 
            // ucSair1
            // 
            this.ucSair1.Location = new System.Drawing.Point(776, 6);
            this.ucSair1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucSair1.Name = "ucSair1";
            this.ucSair1.Size = new System.Drawing.Size(57, 22);
            this.ucSair1.TabIndex = 13;
            // 
            // Fcarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 402);
            this.Controls.Add(this.ucSair1);
            this.Controls.Add(this.bPesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llCategorias);
            this.Controls.Add(this.llMinhasCategorias);
            this.Controls.Add(this.bProdutos);
            this.Controls.Add(this.lRecomendaGrupo);
            this.Controls.Add(this.cbGrupos);
            this.Controls.Add(this.bPerto);
            this.Controls.Add(this.flowLayoutPanel1);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bPerto;
        private System.Windows.Forms.ComboBox cbGrupos;
        private System.Windows.Forms.Label lRecomendaGrupo;
        private System.Windows.Forms.Button bProdutos;
        private System.Windows.Forms.LinkLabel llMinhasCategorias;
        private System.Windows.Forms.LinkLabel llCategorias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bPesquisar;
        private UcSair ucSair1;
    }
}