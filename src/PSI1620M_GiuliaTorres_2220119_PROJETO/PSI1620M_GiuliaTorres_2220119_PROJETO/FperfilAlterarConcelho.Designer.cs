﻿
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class FperfilAlterarConcelho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FperfilAlterarConcelho));
            this.label1 = new System.Windows.Forms.Label();
            this.cbConcelhos = new System.Windows.Forms.ComboBox();
            this.bSubmeter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo concelho:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbConcelhos
            // 
            this.cbConcelhos.FormattingEnabled = true;
            this.cbConcelhos.Location = new System.Drawing.Point(252, 135);
            this.cbConcelhos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbConcelhos.Name = "cbConcelhos";
            this.cbConcelhos.Size = new System.Drawing.Size(180, 28);
            this.cbConcelhos.TabIndex = 1;
            // 
            // bSubmeter
            // 
            this.bSubmeter.Location = new System.Drawing.Point(550, 235);
            this.bSubmeter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSubmeter.Name = "bSubmeter";
            this.bSubmeter.Size = new System.Drawing.Size(123, 52);
            this.bSubmeter.TabIndex = 2;
            this.bSubmeter.Text = "Submeter";
            this.bSubmeter.UseVisualStyleBackColor = true;
            this.bSubmeter.Click += new System.EventHandler(this.bSubmeter_Click);
            // 
            // FperfilAlterarConcelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 306);
            this.Controls.Add(this.bSubmeter);
            this.Controls.Add(this.cbConcelhos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FperfilAlterarConcelho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil - Concelho";
            this.Load += new System.EventHandler(this.FperfilAlterarConcelho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConcelhos;
        private System.Windows.Forms.Button bSubmeter;
    }
}