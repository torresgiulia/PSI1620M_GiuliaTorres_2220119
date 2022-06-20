
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class FperfilAlterarCampo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FperfilAlterarCampo));
            this.label1 = new System.Windows.Forms.Label();
            this.tbAlteracao = new System.Windows.Forms.TextBox();
            this.bSubmeter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAlteracao
            // 
            this.tbAlteracao.Location = new System.Drawing.Point(286, 98);
            this.tbAlteracao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAlteracao.Name = "tbAlteracao";
            this.tbAlteracao.Size = new System.Drawing.Size(148, 26);
            this.tbAlteracao.TabIndex = 1;
            // 
            // bSubmeter
            // 
            this.bSubmeter.Location = new System.Drawing.Point(550, 232);
            this.bSubmeter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSubmeter.Name = "bSubmeter";
            this.bSubmeter.Size = new System.Drawing.Size(129, 55);
            this.bSubmeter.TabIndex = 2;
            this.bSubmeter.Text = "Submeter";
            this.bSubmeter.UseVisualStyleBackColor = true;
            this.bSubmeter.Click += new System.EventHandler(this.bSubmeter_Click);
            // 
            // FperfilAlterarCampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 306);
            this.Controls.Add(this.bSubmeter);
            this.Controls.Add(this.tbAlteracao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FperfilAlterarCampo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil - Configuração";
            this.Load += new System.EventHandler(this.FalterarPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlteracao;
        private System.Windows.Forms.Button bSubmeter;
    }
}