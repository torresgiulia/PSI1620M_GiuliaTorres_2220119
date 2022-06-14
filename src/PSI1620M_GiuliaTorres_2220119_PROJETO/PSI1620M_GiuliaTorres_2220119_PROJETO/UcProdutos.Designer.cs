
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class UcProdutos
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
            this.lNomeProduto = new System.Windows.Forms.Label();
            this.bdetalhes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNomeProduto
            // 
            this.lNomeProduto.Location = new System.Drawing.Point(3, 11);
            this.lNomeProduto.Name = "lNomeProduto";
            this.lNomeProduto.Size = new System.Drawing.Size(240, 31);
            this.lNomeProduto.TabIndex = 0;
            this.lNomeProduto.Text = "[Nome]";
            this.lNomeProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bdetalhes
            // 
            this.bdetalhes.Location = new System.Drawing.Point(88, 56);
            this.bdetalhes.Name = "bdetalhes";
            this.bdetalhes.Size = new System.Drawing.Size(75, 29);
            this.bdetalhes.TabIndex = 1;
            this.bdetalhes.Text = "detalhes";
            this.bdetalhes.UseVisualStyleBackColor = true;
            this.bdetalhes.Click += new System.EventHandler(this.bdetalhes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.lNomeProduto);
            this.panel1.Controls.Add(this.bdetalhes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 118);
            this.panel1.TabIndex = 2;
            // 
            // UcProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcProdutos";
            this.Size = new System.Drawing.Size(243, 118);
            this.Load += new System.EventHandler(this.UcProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lNomeProduto;
        private System.Windows.Forms.Button bdetalhes;
        private System.Windows.Forms.Panel panel1;
    }
}
