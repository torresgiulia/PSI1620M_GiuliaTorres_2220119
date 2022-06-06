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
        public Fcarrinho()
        {
            InitializeComponent();
        }

        private void Fcarrinho_Load(object sender, EventArgs e)
        {
            //Cconsultar.consulta_produtos();
            //foreach(var pesquisa in Cconsultar.listProdutos)
            //{
            //    Button bProd = new Button();
            //    bProd.Text = pesquisa.ProdutoNome;
            //    bProd.Name = "b" + pesquisa.ProdutoNome;


            //}



            // labels das categorias
            //int localiza = 74;
            //Cconsultar.consulta_categorias();
            //foreach (var pesquisa in Cconsultar.listCategorias)
            //{
            //    LinkLabel llFiltos = new LinkLabel();
            //    llFiltos.Name = "ll" + pesquisa.CategoriaNome;
            //    llFiltos.Text = pesquisa.CategoriaNome;
            //    llFiltos.Visible = true;
            //    llFiltos.Location = new Point(0, localiza);

            //    this.Controls.Add(llFiltos);
            //    llFiltos.BringToFront();
            //    Controls.Add(llFiltos);

            //    localiza += 30;

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UcFiltrosProdutos sideBar = new UcFiltrosProdutos();
            sideBar.Dock = DockStyle.Fill;
            this.Controls.Add(sideBar);
        }
    }
}
