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
    public partial class UcProdutos : UserControl
    {

        public string Label {
            get { return lNomeProduto.Text; }
            set { lNomeProduto.Text = value; } 
       }
        public UcProdutos()
        {
            InitializeComponent();
        }

        private void UcProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
