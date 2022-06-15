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
        public bool userControl { get; set; }
        public int categoriaPesquisa { get; set; }


        public Fcarrinho()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adiciona todos os produtos ao flowLayoutPanel
        /// </summary>
        public async void Fcarrinho_Load(object sender, EventArgs e)
        {

            label1.Text = "Produtos";
            userControl = true;
            flowLayoutPanel1.Controls.Clear();

            await Cconsultar.consulta_utilizadoresCategorias();
            await Cconsultar.consulta_produtosCategorias();
            await Cconsultar.consulta_produtos();


            //Adicionar produtos (flowLayoutPanel1)
            foreach (var item in Cconsultar.listProdutos)
            {
                UcProdutos prdItem = new UcProdutos();
                prdItem.Label = item.ProdutoNome;
                flowLayoutPanel1.Controls.Add(prdItem);
            }

            cbGrupos.DataSource = Cconsultar.listPerfilGrupos;

        }


        /// <summary>
        /// Adicionar os produtos que estão perto do utilizador
        /// </summary>
        private async void bPerto_Click(object sender, EventArgs e)
        {
            label1.Text = "Perto de mim";
            label1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Clear();
            await Cconsultar.consulta_vendedores();
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
                                    //utilizar async 

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
            label1.Text = "Minhas Categorias";
            label1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Clear();
            

            foreach (var categoriasUtilizador in Cconsultar.listUtilizadoresCategorias)
            {
                if (categoriasUtilizador.utilizadorCategoriaIdUtilizador == Cconsultar.idLoggedUser)
                {
                    foreach (var produtocat in Cconsultar.listprodutosCategorias)
                    {
                        if (produtocat.produtoCategoriaIdCategoria == categoriasUtilizador.utilizadorCategoriaIdCategoria)
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
        private async void llCategorias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (userControl == true)
            {

                int x = 10;
                int y = 20;
                int contar = 0;
                await Cconsultar.consulta_categorias();
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


        /// <summary>
        /// Pesquisar produtos por categoria
        /// </summary>
        private void LlFiltos_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            
            foreach(var cat in Cconsultar.listCategorias)
            {
                if(cat.CategoriaNome == ((LinkLabel)sender).Text)
                {
                    categoriaPesquisa = cat.CategoriaId;
                    label1.Text = cat.CategoriaNome;
                    label1.BackColor = Color.Transparent;
                }
            }


            foreach (var prodcat in Cconsultar.listprodutosCategorias )
            {
                foreach (var produ in Cconsultar.listProdutos)
                {
                    if (prodcat.produtoCategoriaIdProduto == produ.ProdutoId && prodcat.produtoCategoriaIdCategoria == categoriaPesquisa)//Controls[sender].Text)
                    {
                        UcProdutos prdItem = new UcProdutos();
                        prdItem.Label = produ.ProdutoNome;
                        flowLayoutPanel1.Controls.Add(prdItem);
                    }
                }
            }



        }


        /// <summary>
        /// Pesquisar categorias preferidas do utilizador sorteado
        /// </summary>
        private  void cbGrupos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label1.Text = "Produtos";
            label1.BackColor = Color.Transparent;
            int idGrupo = 0;
            int idSorteado = 0;

            flowLayoutPanel1.Controls.Clear();
            
            foreach(var grupo in Cconsultar.listGrupos)
            {
                if(grupo.GrupoNome == cbGrupos.Text)
                {
                    idGrupo = grupo.GrupoId;
                }
            }
            foreach(var utigru in Cconsultar.listUtilizadoresGrupos)
            {
                if(utigru.utilizadorGrupoIdGrupo == idGrupo && utigru.utilizadorGrupoIdUtilizador == Cconsultar.idLoggedUser)
                {
                    if(utigru.utilizadorGrupoIdUtilizadorSorteado > 0)
                    {
                        idSorteado = utigru.utilizadorGrupoIdUtilizadorSorteado;
                        break;
                    }
                    else
                    {
                        idSorteado = 0;
                    }
                }
            }
            foreach(var uticat in Cconsultar.listUtilizadoresCategorias)
            {
                if(uticat.utilizadorCategoriaIdUtilizador == idSorteado)
                {
                    foreach (var prodcat in Cconsultar.listprodutosCategorias)
                    {
                        if (prodcat.produtoCategoriaIdCategoria == uticat.utilizadorCategoriaIdCategoria)
                        {
                            foreach (var produto in Cconsultar.listProdutos)
                            {
                                if (prodcat.produtoCategoriaIdProduto == produto.ProdutoId)
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
            foreach (var nome in Cconsultar.listUtilizadores)
            {
                if (nome.UtilizadorId == idSorteado)
                {
                    label1.Text = $"Preferências de: {nome.UtilizadorUsername}";
                }
            }
            if (idSorteado == 0)
            {
                MessageBox.Show("O grupo selecionado ainda não foi sorteado :(");
            }
        }
    }
}
