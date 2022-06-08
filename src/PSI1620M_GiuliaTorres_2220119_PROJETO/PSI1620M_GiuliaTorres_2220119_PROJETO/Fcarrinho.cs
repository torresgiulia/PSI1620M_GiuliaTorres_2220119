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
    public partial class Fcarrinho : Form
    {
        public bool sideUserControl { get; set; }

        public Fcarrinho()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Adiciona todos os produtos ao flowLayoutPanel
        /// </summary>
        public void Fcarrinho_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sideUserControl = false;
            Cconsultar.consulta_produtos();
            foreach (var item in Cconsultar.listProdutos)
            {
                UcProdutos prdItem = new UcProdutos();
                prdItem.Label = item.ProdutoNome;
                flowLayoutPanel1.Controls.Add(prdItem);
            }
            cbGrupos.DataSource = Cconsultar.listPerfilGrupos;

        }


        /// <summary>
        /// abre a sidebar de categorias
        /// </summary>
        private void bSide_Click(object sender, EventArgs e)
        {
            UcProdutosFiltros sideBar = new UcProdutosFiltros();
            this.Controls.Add(sideBar);
        }

        /// <summary>
        /// Adicionar os produtos que estão perto do utilizador
        /// </summary>
        private void bPerto_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Cconsultar.consulta_vendedores();
            foreach (var pesquisa in Cconsultar.listUtilizadores)
            {
                if (pesquisa.UtilizadorUsername == Cconsultar.loggedUser)
                {
                    foreach (var item in Cconsultar.listProdutos)
                    {
                        foreach (var concelho_vendedor in Cconsultar.listVendedores)
                        {
                            if (pesquisa.UtilizadorIdConcelho == concelho_vendedor.VendedorIdConcelho)
                            {
                                if (concelho_vendedor.VendedorId == item.ProdutoIdVendedor)
                                {                                
                                    UcProdutos prdItem = new UcProdutos();
                                    prdItem.Label = item.ProdutoNome;
                                    flowLayoutPanel1.Controls.Add(prdItem);
                                }
                            }
                            
                        }

                    }
                }
            }

                
        }

        

    }
}
