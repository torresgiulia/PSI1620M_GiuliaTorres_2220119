
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
            this.SuspendLayout();
            // 
            // lNomeProduto
            // 
            this.lNomeProduto.AutoSize = true;
            this.lNomeProduto.Location = new System.Drawing.Point(45, 12);
            this.lNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomeProduto.Name = "lNomeProduto";
            this.lNomeProduto.Size = new System.Drawing.Size(41, 13);
            this.lNomeProduto.TabIndex = 0;
            this.lNomeProduto.Text = "[Nome]";
            // 
            // bdetalhes
            // 
            this.bdetalhes.Location = new System.Drawing.Point(41, 44);
            this.bdetalhes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bdetalhes.Name = "bdetalhes";
            this.bdetalhes.Size = new System.Drawing.Size(50, 19);
            this.bdetalhes.TabIndex = 1;
            this.bdetalhes.Text = "detalhes";
            this.bdetalhes.UseVisualStyleBackColor = true;
            this.bdetalhes.Click += new System.EventHandler(this.bdetalhes_Click);
            // 
            // UcProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bdetalhes);
            this.Controls.Add(this.lNomeProduto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcProdutos";
            this.Size = new System.Drawing.Size(128, 77);
            this.Load += new System.EventHandler(this.UcProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNomeProduto;
        private System.Windows.Forms.Button bdetalhes;
    }
}
