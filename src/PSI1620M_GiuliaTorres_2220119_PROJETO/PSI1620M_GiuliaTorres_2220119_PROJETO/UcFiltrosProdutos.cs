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
        public UcFiltrosProdutos()
        {
            InitializeComponent();
        }

        private void UcFiltrosProdutos_Load(object sender, EventArgs e)
        {

            

        }

        private void llCategorias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int x = 41;
            int y = 115;
            Cconsultar.consulta_categorias();
            foreach (var pesquisa in Cconsultar.listCategorias)
            {
                LinkLabel llFiltos = new LinkLabel();
                llFiltos.Name = "ll" + pesquisa.CategoriaNome;
                llFiltos.Text = pesquisa.CategoriaNome;
                llFiltos.Visible = true;
                llFiltos.Location = new Point(x, y);

                this.Controls.Add(llFiltos);
                llFiltos.BringToFront();
                Controls.Add(llFiltos);

                y += 30;
            }
        }
    }
}
