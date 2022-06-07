
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class FpesquisarGrupoInfo
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
            this.lnomeGrupo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bParticipar = new System.Windows.Forms.Button();
            this.ldescricao = new System.Windows.Forms.Label();
            this.lstatus = new System.Windows.Forms.Label();
            this.lLider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnomeGrupo
            // 
            this.lnomeGrupo.AutoSize = true;
            this.lnomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnomeGrupo.Location = new System.Drawing.Point(235, 18);
            this.lnomeGrupo.Name = "lnomeGrupo";
            this.lnomeGrupo.Size = new System.Drawing.Size(86, 31);
            this.lnomeGrupo.TabIndex = 0;
            this.lnomeGrupo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Utilizador líder";
            // 
            // bParticipar
            // 
            this.bParticipar.Location = new System.Drawing.Point(547, 297);
            this.bParticipar.Name = "bParticipar";
            this.bParticipar.Size = new System.Drawing.Size(118, 52);
            this.bParticipar.TabIndex = 4;
            this.bParticipar.Text = "Participar";
            this.bParticipar.UseVisualStyleBackColor = true;
            this.bParticipar.Click += new System.EventHandler(this.bParticipar_Click);
            // 
            // ldescricao
            // 
            this.ldescricao.AutoSize = true;
            this.ldescricao.Location = new System.Drawing.Point(299, 108);
            this.ldescricao.Name = "ldescricao";
            this.ldescricao.Size = new System.Drawing.Size(35, 13);
            this.ldescricao.TabIndex = 5;
            this.ldescricao.Text = "label4";
            // 
            // lstatus
            // 
            this.lstatus.AutoSize = true;
            this.lstatus.Location = new System.Drawing.Point(299, 179);
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(35, 13);
            this.lstatus.TabIndex = 6;
            this.lstatus.Text = "label5";
            // 
            // lLider
            // 
            this.lLider.AutoSize = true;
            this.lLider.Location = new System.Drawing.Point(299, 261);
            this.lLider.Name = "lLider";
            this.lLider.Size = new System.Drawing.Size(35, 13);
            this.lLider.TabIndex = 7;
            this.lLider.Text = "label6";
            // 
            // FpesquisarGrupoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 358);
            this.Controls.Add(this.lLider);
            this.Controls.Add(this.lstatus);
            this.Controls.Add(this.ldescricao);
            this.Controls.Add(this.bParticipar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnomeGrupo);
            this.Name = "FpesquisarGrupoInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FpesquisarGrupoInfo";
            this.Load += new System.EventHandler(this.FpesquisarGrupoInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnomeGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bParticipar;
        private System.Windows.Forms.Label ldescricao;
        private System.Windows.Forms.Label lstatus;
        private System.Windows.Forms.Label lLider;
    }
}