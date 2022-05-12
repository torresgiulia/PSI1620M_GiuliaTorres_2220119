
namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    partial class SignIn
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
            System.Windows.Forms.Label LCriarConta;
            this.Lnome = new System.Windows.Forms.Label();
            this.Lemail = new System.Windows.Forms.Label();
            this.Lutilizador = new System.Windows.Forms.Label();
            this.Lconcelho = new System.Windows.Forms.Label();
            this.Lpassword = new System.Windows.Forms.Label();
            this.LvPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TBnome = new System.Windows.Forms.TextBox();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.TButilizador = new System.Windows.Forms.TextBox();
            this.TBtelemovel = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.TBvPassword = new System.Windows.Forms.TextBox();
            this.Ltelemovel = new System.Windows.Forms.Label();
            this.CBconcelho = new System.Windows.Forms.ComboBox();
            LCriarConta = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LCriarConta
            // 
            LCriarConta.AutoSize = true;
            LCriarConta.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LCriarConta.Location = new System.Drawing.Point(383, 9);
            LCriarConta.Name = "LCriarConta";
            LCriarConta.Size = new System.Drawing.Size(251, 49);
            LCriarConta.TabIndex = 0;
            LCriarConta.Text = "Criar Conta";
            // 
            // Lnome
            // 
            this.Lnome.AutoSize = true;
            this.Lnome.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnome.Location = new System.Drawing.Point(3, 0);
            this.Lnome.Name = "Lnome";
            this.Lnome.Size = new System.Drawing.Size(94, 29);
            this.Lnome.TabIndex = 1;
            this.Lnome.Text = "Nome:";
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lemail.Location = new System.Drawing.Point(3, 75);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(88, 29);
            this.Lemail.TabIndex = 7;
            this.Lemail.Text = "Email:";
            // 
            // Lutilizador
            // 
            this.Lutilizador.AutoSize = true;
            this.Lutilizador.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lutilizador.Location = new System.Drawing.Point(3, 150);
            this.Lutilizador.Name = "Lutilizador";
            this.Lutilizador.Size = new System.Drawing.Size(133, 58);
            this.Lutilizador.TabIndex = 8;
            this.Lutilizador.Text = "Nome de utilizador:";
            // 
            // Lconcelho
            // 
            this.Lconcelho.AutoSize = true;
            this.Lconcelho.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lconcelho.Location = new System.Drawing.Point(389, 0);
            this.Lconcelho.Name = "Lconcelho";
            this.Lconcelho.Size = new System.Drawing.Size(134, 29);
            this.Lconcelho.TabIndex = 9;
            this.Lconcelho.Text = "Concelho:";
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpassword.Location = new System.Drawing.Point(389, 75);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(138, 29);
            this.Lpassword.TabIndex = 10;
            this.Lpassword.Text = "Password:";
            // 
            // LvPassword
            // 
            this.LvPassword.AutoSize = true;
            this.LvPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvPassword.Location = new System.Drawing.Point(389, 150);
            this.LvPassword.Name = "LvPassword";
            this.LvPassword.Size = new System.Drawing.Size(138, 58);
            this.LvPassword.TabIndex = 11;
            this.LvPassword.Text = "Verificar Password:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Controls.Add(this.Lnome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LvPassword, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lemail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lpassword, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lutilizador, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lconcelho, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBnome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBemail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TButilizador, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBtelemovel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBpassword, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBvPassword, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Ltelemovel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CBconcelho, 3, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 298);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // TBnome
            // 
            this.TBnome.Location = new System.Drawing.Point(165, 3);
            this.TBnome.Multiline = true;
            this.TBnome.Name = "TBnome";
            this.TBnome.Size = new System.Drawing.Size(178, 50);
            this.TBnome.TabIndex = 12;
            // 
            // TBemail
            // 
            this.TBemail.Location = new System.Drawing.Point(165, 78);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(100, 29);
            this.TBemail.TabIndex = 13;
            // 
            // TButilizador
            // 
            this.TButilizador.Location = new System.Drawing.Point(165, 153);
            this.TButilizador.Name = "TButilizador";
            this.TButilizador.Size = new System.Drawing.Size(100, 29);
            this.TButilizador.TabIndex = 14;
            // 
            // TBtelemovel
            // 
            this.TBtelemovel.Location = new System.Drawing.Point(165, 235);
            this.TBtelemovel.Name = "TBtelemovel";
            this.TBtelemovel.Size = new System.Drawing.Size(100, 29);
            this.TBtelemovel.TabIndex = 15;
            // 
            // TBpassword
            // 
            this.TBpassword.Location = new System.Drawing.Point(536, 78);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(100, 29);
            this.TBpassword.TabIndex = 16;
            // 
            // TBvPassword
            // 
            this.TBvPassword.Location = new System.Drawing.Point(536, 153);
            this.TBvPassword.Name = "TBvPassword";
            this.TBvPassword.Size = new System.Drawing.Size(100, 29);
            this.TBvPassword.TabIndex = 17;
            // 
            // Ltelemovel
            // 
            this.Ltelemovel.AutoSize = true;
            this.Ltelemovel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltelemovel.Location = new System.Drawing.Point(3, 232);
            this.Ltelemovel.Name = "Ltelemovel";
            this.Ltelemovel.Size = new System.Drawing.Size(134, 29);
            this.Ltelemovel.TabIndex = 18;
            this.Ltelemovel.Text = "Telemovel";
            // 
            // CBconcelho
            // 
            this.CBconcelho.FormattingEnabled = true;
            this.CBconcelho.Location = new System.Drawing.Point(536, 3);
            this.CBconcelho.Name = "CBconcelho";
            this.CBconcelho.Size = new System.Drawing.Size(121, 31);
            this.CBconcelho.TabIndex = 19;
            // 
            // SignIn
            // 
            this.ClientSize = new System.Drawing.Size(932, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(LCriarConta);
            this.Name = "SignIn";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label Lnome;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.Label Lutilizador;
        private System.Windows.Forms.Label Lconcelho;
        private System.Windows.Forms.Label Lpassword;
        private System.Windows.Forms.Label LvPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TBnome;
        private System.Windows.Forms.TextBox TBemail;
        private System.Windows.Forms.TextBox TButilizador;
        private System.Windows.Forms.TextBox TBtelemovel;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.TextBox TBvPassword;
        private System.Windows.Forms.Label Ltelemovel;
        private System.Windows.Forms.ComboBox CBconcelho;
    }
}

