﻿
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class UcSair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSair));
            this.bSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSair
            // 
            this.bSair.BackColor = System.Drawing.Color.Transparent;
            this.bSair.ForeColor = System.Drawing.Color.Black;
            this.bSair.Image = ((System.Drawing.Image)(resources.GetObject("bSair.Image")));
            this.bSair.Location = new System.Drawing.Point(3, 3);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(69, 38);
            this.bSair.TabIndex = 0;
            this.bSair.UseVisualStyleBackColor = false;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // UcSair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bSair);
            this.Name = "UcSair";
            this.Size = new System.Drawing.Size(75, 51);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSair;
    }
}
