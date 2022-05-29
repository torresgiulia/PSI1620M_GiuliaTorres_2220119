
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class FnovoGrupo
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeGrupo = new System.Windows.Forms.TextBox();
            this.bCriarGrupo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar novo Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do grupo:";
            // 
            // tbNomeGrupo
            // 
            this.tbNomeGrupo.Location = new System.Drawing.Point(332, 105);
            this.tbNomeGrupo.Name = "tbNomeGrupo";
            this.tbNomeGrupo.Size = new System.Drawing.Size(100, 20);
            this.tbNomeGrupo.TabIndex = 2;
            // 
            // bCriarGrupo
            // 
            this.bCriarGrupo.Location = new System.Drawing.Point(515, 224);
            this.bCriarGrupo.Name = "bCriarGrupo";
            this.bCriarGrupo.Size = new System.Drawing.Size(75, 23);
            this.bCriarGrupo.TabIndex = 3;
            this.bCriarGrupo.Text = "Criar Grupo";
            this.bCriarGrupo.UseVisualStyleBackColor = true;
            this.bCriarGrupo.Click += new System.EventHandler(this.bCriarGrupo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição: ";
            // 
            // tbDescricao
            // 
            this.tbDescricao.AccessibleName = "opcional";
            this.tbDescricao.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbDescricao.Location = new System.Drawing.Point(332, 144);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(100, 47);
            this.tbDescricao.TabIndex = 5;
            // 
            // FnovoGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 310);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCriarGrupo);
            this.Controls.Add(this.tbNomeGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FnovoGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeGrupo;
        private System.Windows.Forms.Button bCriarGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescricao;
    }
}