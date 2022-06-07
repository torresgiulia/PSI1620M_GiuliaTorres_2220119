
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class UcProdutosFiltros
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.llPreferencias = new System.Windows.Forms.LinkLabel();
            this.llGrupos = new System.Windows.Forms.LinkLabel();
            this.llCategorias = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // llPreferencias
            // 
            this.llPreferencias.AutoSize = true;
            this.llPreferencias.Location = new System.Drawing.Point(4, 105);
            this.llPreferencias.Name = "llPreferencias";
            this.llPreferencias.Size = new System.Drawing.Size(152, 20);
            this.llPreferencias.TabIndex = 0;
            this.llPreferencias.TabStop = true;
            this.llPreferencias.Text = "Minhas preferencias";
            this.llPreferencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llGrupos
            // 
            this.llGrupos.AutoSize = true;
            this.llGrupos.Location = new System.Drawing.Point(4, 135);
            this.llGrupos.Name = "llGrupos";
            this.llGrupos.Size = new System.Drawing.Size(101, 20);
            this.llGrupos.TabIndex = 1;
            this.llGrupos.TabStop = true;
            this.llGrupos.Text = "Meus grupos";
            // 
            // llCategorias
            // 
            this.llCategorias.AutoSize = true;
            this.llCategorias.Location = new System.Drawing.Point(4, 166);
            this.llCategorias.Name = "llCategorias";
            this.llCategorias.Size = new System.Drawing.Size(86, 20);
            this.llCategorias.TabIndex = 2;
            this.llCategorias.TabStop = true;
            this.llCategorias.Text = "Categorias";
            this.llCategorias.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCategorias_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 287);
            this.panel1.TabIndex = 3;
            // 
            // UcFiltrosProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llCategorias);
            this.Controls.Add(this.llGrupos);
            this.Controls.Add(this.llPreferencias);
            this.Name = "UcFiltrosProdutos";
            this.Size = new System.Drawing.Size(582, 612);
            this.Load += new System.EventHandler(this.UcFiltrosProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llPreferencias;
        private System.Windows.Forms.LinkLabel llGrupos;
        private System.Windows.Forms.LinkLabel llCategorias;
        private System.Windows.Forms.Panel panel1;
    }
}
