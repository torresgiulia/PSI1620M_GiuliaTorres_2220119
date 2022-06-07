using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    public partial class Fpesquisar : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;
        BindingList<Cgrupos> bListGrupos = new BindingList<Cgrupos>();
        BindingList<CgruposPesquisar> bListGruposPesquisa = new BindingList<CgruposPesquisar>();

        public Fpesquisar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Binding List a listBox
        /// </summary>
        private void Fpesquisar_Load(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(connstring);
            
            //Adicionar a ListBox
            try
            {
                Cconsultar.consulta_grupo();
                bListGrupos = new BindingList<Cgrupos>(Cconsultar.listGrupos.OrderBy(x => x.GrupoId).ToList());
                lbGrupos.DataSource = bListGrupos;
                lbGrupos.DisplayMember = "GrupoNome";
                lbGrupos.ValueMember = "GrupoId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }


        /// <summary>
        /// Binding List a listBox depois da pesquisa
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Cconsultar.textoPesquisa = tbPesquisa.Text;

            // Binding List com a listbox
            try
            {
                Cconsultar.consulta_grupopesquisa();
                bListGruposPesquisa = new BindingList<CgruposPesquisar>(Cconsultar.listGruposPesquisa.OrderBy(x => x.GrupoPesquisaId).ToList());
                lbGrupos.DataSource = bListGruposPesquisa;
                lbGrupos.DisplayMember = "GrupoPesquisaNome";
                lbGrupos.ValueMember = "GrupoPesquisaId";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }


        /// <summary>
        /// Adiciona informação à label e direciona para os detalhes do grupo
        /// </summary>
        public void lbGrupos_DoubleClick(object sender, EventArgs e)
        {
            FpesquisarGrupoInfo grupoInfo = new FpesquisarGrupoInfo();
            
            string teste = lbGrupos.GetItemText(lbGrupos.SelectedItem);
            grupoInfo.Label = lbGrupos.GetItemText(lbGrupos.SelectedItem);
            grupoInfo.Show();

        }
    }
}
