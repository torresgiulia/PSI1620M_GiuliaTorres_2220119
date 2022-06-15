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
    public partial class FperfilAlterarConcelho : Form
    {
        BindingList<Cconcelhos> bListConcelhos { get; set; }

        public FperfilAlterarConcelho()
        {
            InitializeComponent();
        }

        private async void FperfilAlterarConcelho_Load(object sender, EventArgs e)
        {
            await Cconsultar.consulta_concelhos();

            bListConcelhos = new BindingList<Cconcelhos>(Cconsultar.listConcelhos.OrderBy(x => x.ConcelhoNome).ToList());
            cbConcelhos.DataSource = bListConcelhos;
            cbConcelhos.DisplayMember = "ConcelhoNome";
            cbConcelhos.ValueMember = "ConcelhoId";

            Cconsultar.listConcelhos.Clear();

        }
        
        //Adicionar valor ao id e nome dos concelhos para o FperfilConfigurações
        private async void bSubmeter_Click(object sender, EventArgs e)
        {
            //Pesquisar o id do concelho selecionado
            await Cconsultar.consulta_concelhos();
            foreach (var pesquisa in Cconsultar.listConcelhos)
            {
                if (pesquisa.ConcelhoNome == cbConcelhos.Text)
                {
                    Cconsultar.textBoxText = pesquisa.ConcelhoNome;
                    Cconsultar.textBoxTextId = pesquisa.ConcelhoId;
                    break;
                }
            }
            this.Close();
        }
    }
}
