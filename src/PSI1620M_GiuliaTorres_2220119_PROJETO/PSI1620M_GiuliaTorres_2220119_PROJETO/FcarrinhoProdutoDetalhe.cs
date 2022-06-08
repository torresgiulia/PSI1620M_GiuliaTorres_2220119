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
    public partial class FcarrinhoProdutoDetalhe : Form
    {
        public FcarrinhoProdutoDetalhe()
        {
            InitializeComponent();
        }

        private void FcarrinhoProdutoDetalhe_Load(object sender, EventArgs e)
        {
            lNome.Text = Cconsultar.produtoNome;
            Cconsultar.consulta_vendedores();
            foreach (var pesquisa in Cconsultar.listProdutos)
            {
                if(pesquisa.ProdutoNome == lNome.Text)
                {
                    lDescricao.Text = pesquisa.ProdutoDescricao;
                    lValor.Text = pesquisa.ProdutoValor.ToString();
                    foreach (var vendedor in Cconsultar.listVendedores)
                    {
                        if (pesquisa.ProdutoIdVendedor == vendedor.VendedorId)
                        {
                            lVendedor.Text = vendedor.VendedorNome;
                            lMorada.Text = vendedor.VendedorMorada;
                            lCodigoPostal.Text = vendedor.VendedorIdCodigoPostal.ToString();
                        }
                    }
                }
               
            }
        }
    }
}
