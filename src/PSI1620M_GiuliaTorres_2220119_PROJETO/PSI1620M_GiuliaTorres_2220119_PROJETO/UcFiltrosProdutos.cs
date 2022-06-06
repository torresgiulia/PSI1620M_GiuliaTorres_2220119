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
    public partial class UcFiltrosProdutos : UserControl
    {
        public bool userControl { get; set; }

        public UcFiltrosProdutos()
        {
            InitializeComponent();
        }

        private void UcFiltrosProdutos_Load(object sender, EventArgs e)
        {
            userControl = true;



        }

        private void llCategorias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(userControl == true)
            {
                userControl = false;
                UcProdutosCategorias labels = new UcProdutosCategorias();
                labels.Dock = DockStyle.Fill;
                this.Controls.Add(labels);

            }
            else
            {
                UcProdutosCategorias labels = new UcProdutosCategorias();
                labels.Dock = DockStyle.Fill;
                this.Controls.Clear();

                UcFiltrosProdutos sideBar = new UcFiltrosProdutos();
                sideBar.Dock = DockStyle.Fill;
                this.Controls.Add(sideBar);
                userControl = true;
            }

            
        }
    }
}
