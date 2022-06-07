
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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sair1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcSair();
            this.botoesRodape1 = new PSI1620M_GiuliaTorres_2220119_PROJETO.UcBotoesRodape();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Todos os produtos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "_____";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(160, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1090, 422);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // sair1
            // 
            this.sair1.Location = new System.Drawing.Point(1165, 12);
            this.sair1.Name = "sair1";
            this.sair1.Size = new System.Drawing.Size(85, 34);
            this.sair1.TabIndex = 1;
            // 
            // botoesRodape1
            // 
            this.botoesRodape1.Location = new System.Drawing.Point(75, 500);
            this.botoesRodape1.Name = "botoesRodape1";
            this.botoesRodape1.Size = new System.Drawing.Size(1175, 112);
            this.botoesRodape1.TabIndex = 0;
            // 
            // Fcarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 618);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sair1);
            this.Controls.Add(this.botoesRodape1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}