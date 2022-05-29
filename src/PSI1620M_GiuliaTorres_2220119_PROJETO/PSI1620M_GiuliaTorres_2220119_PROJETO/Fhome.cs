using System;
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
    public partial class Fhome : Form
    {
        public Fhome()
        {
            InitializeComponent();
            lnome.Text = Cconsultar.loggedUser;
        }

        /// <summary>
        /// Mudar para a página Home
        /// </summary>
        private void bHome_Click(object sender, EventArgs e)
        {
            Fhome home = new Fhome();
            home.Show();
            this.Hide();
        }

        /// <summary>
        /// Mudar para a página Produtos
        /// </summary>
        private void bProdutos_Click(object sender, EventArgs e)
        {
            Fcarrinho carrinho = new Fcarrinho();
            carrinho.Show();
            this.Hide();
        }

        /// <summary>
        /// Mudar para a página Pesquisar
        /// </summary>
        private void bPesquisar_Click(object sender, EventArgs e)
        {
            Fpesquisar pesquisar = new Fpesquisar();
            pesquisar.Show();
            this.Hide();
        }

        /// <summary>
        /// Mudar para a página Perfil
        /// </summary>
        private void bPerfil_Click(object sender, EventArgs e)
        {
            Fperfil perfil = new Fperfil();
            perfil.Show();
            this.Hide();
        }

        private void bNovoGrupo_Click(object sender, EventArgs e)
        {
            FnovoGrupo novoGrupo = new FnovoGrupo();
            novoGrupo.Show();
        }
    }
}
