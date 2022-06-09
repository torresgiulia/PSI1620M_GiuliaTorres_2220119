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
        public bool userControl { get; set; }

        public Fcarrinho()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Adiciona todos os produtos ao flowLayoutPanel
        /// </summary>
        public void Fcarrinho_Load(object sender, EventArgs e)
        {
            userControl = true;
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

        /// <summary>
        /// Adicionar os produtos das preferencias do utilizador
        /// </summary>
        public void llMinhasCategorias_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Cconsultar.consulta_utilizadoresCategorias();
            Cconsultar.consulta_produtosCategorias();

            foreach (var categoriasUtilizador in Cconsultar.listUtilizadoresCategorias)
            {
                if (categoriasUtilizador.utilizadorCategoriaIdUtilizador == Cconsultar.idLoggedUser)
                {
                    foreach(var produtocat in Cconsultar.listprodutosCategorias)
                    {
                        if(produtocat.produtoCategoriaIdCategoria == categoriasUtilizador.utilizadorCategoriaIdCategoria)
                        {
                            foreach (var produto in Cconsultar.listProdutos)
                            {
                                if (produtocat.produtoCategoriaIdProduto == produto.ProdutoId)
                                {
                                    UcProdutos prdItem = new UcProdutos();
                                    prdItem.Label = produto.ProdutoNome;
                                    flowLayoutPanel1.Controls.Add(prdItem);

                                }
                            }
                        }
                        
                    }
                    
                                           
                }
            }
        }



        /// <summary>
        /// Abrir as categorias da sidebar
        /// </summary>
        private void llCategorias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (userControl == true)
            {

                int x = 10;
                int y = 20;
                int contar = 0;
                Cconsultar.consulta_categorias();
                foreach (var pesquisa in Cconsultar.listCategorias)
                {
                    LinkLabel llFiltos = new LinkLabel();
                    llFiltos.Name = "ll" + pesquisa.CategoriaNome;
                    llFiltos.Text = pesquisa.CategoriaNome;
                    llFiltos.Click += LlFiltos_Click;
                    llFiltos.Visible = true;
                    llFiltos.Location = new Point(x, y);

                    this.Controls.Add(llFiltos);
                    llFiltos.BringToFront();
                    panel1.Controls.Add(llFiltos);
                    panel1.Visible = true;
                    contar++;
                    y += 23;
                    panel1.AutoScroll = true;

                }
                userControl = false;


            }
            else
            {


                panel1.Visible = false;

                userControl = true;
            }
        }

        private void LlFiltos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            continuar aqui //filtros de cada categoria
        }
    }
}
