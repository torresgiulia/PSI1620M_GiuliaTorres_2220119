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

                int x = 10;
                int y = 20;
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
                    panel1.Controls.Add(llFiltos);
                    panel1.Visible = true;
                    contar++;
                    y += 23;
                    panel1.AutoScroll = true;
                    //if (contar == 7)
                    //{
                    //    contar = 0;
                    //    x = 10;
                    //    y = 30;
                    //}
                }
                userControl = false;
                

            }
            else
            {


                panel1.Visible = false;

                userControl = true;
            }

            
        }
    }
}
