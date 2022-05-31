﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    public partial class BotoesRodape : UserControl
    {
        public BotoesRodape()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Direcionar para a Home
        /// </summary>
        private void bHome_Click(object sender, EventArgs e)
        {
            Fhome home = new Fhome();
            home.Show();
            this.Hide();
        }


        /// <summary>
        /// Direcionar para os Produtos
        /// </summary>
        private void bPrdutos_Click(object sender, EventArgs e)
        {
            Fcarrinho carrinho = new Fcarrinho();
            carrinho.Show();
            this.Hide();
        }


        /// <summary>
        /// Direcionar para a Pesquisa de grupos
        /// </summary>
        private void bPesquisar_Click(object sender, EventArgs e)
        {
            Fpesquisar pesquisar = new Fpesquisar();
            pesquisar.Show();
            this.Hide();
        }


        /// <summary>
        /// Direcionar para o Perfil
        /// </summary>
        private void bPerfil_Click(object sender, EventArgs e)
        {
            Fperfil perfil = new Fperfil();
            perfil.Show();
            this.Hide();
        }

    }
}
