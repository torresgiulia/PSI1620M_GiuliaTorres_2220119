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
    public partial class UcProdutosCategorias : UserControl
    {
        public UcProdutosCategorias()
        {
            InitializeComponent();
        }

        private void UcProdutosCategorias_Load(object sender, EventArgs e)
        {
            int x = 41;
            int y = 130;
            int contar = 0;
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
                contar++;
                y += 23;
                if (contar == 7)
                {
                    contar = 0;
                    x += 100;
                    y = 130;
                }
            }
        }
    }
}
