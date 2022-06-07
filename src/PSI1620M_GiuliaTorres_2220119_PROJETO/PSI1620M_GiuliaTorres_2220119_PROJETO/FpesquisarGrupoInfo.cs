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
    public partial class FpesquisarGrupoInfo : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        public int idGrupo { get; set; }
        public string statusGrupo { get; set; }

        List<int> listUtilizadoresGrupos = new List<int>();

        public string Label
        {
            get { return lnomeGrupo.Text; }
            set { lnomeGrupo.Text = value; }
        }


        public FpesquisarGrupoInfo()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Mostrar detalhes do grupo
        /// </summary>
        private void FpesquisarGrupoInfo_Load(object sender, EventArgs e)
        {

            Cconsultar.consulta_grupo();

            //Adicionar valor ás labels
            foreach(var pesquisa in Cconsultar.listGrupos)
            {
                if(pesquisa.GrupoNome == lnomeGrupo.Text)
                {
                    ldescricao.Text = pesquisa.GrupoDescricao;
                    lstatus.Text = pesquisa.GrupoEstado;

                    //Para bParticipar_Click()
                    statusGrupo = pesquisa.GrupoEstado;
                    idGrupo = pesquisa.GrupoId;

                    //Buscar username utilizador lider
                    Cconsultar.consulta_utilizadores();
                    foreach(var pesquisaUserLider in Cconsultar.listUtilizadores)
                    {
                        if(pesquisa.GrupoUtilizadorLider == pesquisaUserLider.UtilizadorId)
                        {
                            lLider.Text = pesquisaUserLider.UtilizadorUsername;
                        }
                    }
                    break;
                }
            }
        }


        /// <summary>
        /// Adicionar participante ao grupo
        /// </summary>
        private void bParticipar_Click(object sender, EventArgs e)
        {
            bool podeEntrar = true;
            SqlConnection connection = new SqlConnection(connstring);

            //Verificar se está aberto
            if(statusGrupo == "aberto")
            {
                Cconsultar.consulta_utilizadoresGrupos();
                foreach(var pesquisa in Cconsultar.listUtilizadoresGrupos)
                {
                    
                    if (pesquisa.utilizadorGrupoIdGrupo == idGrupo && pesquisa.utilizadorGrupoIdUtilizador == Cconsultar.idLoggedUser)
                    {
                        podeEntrar = false;
                        string texto = "Já se encontra neste grupo, por favor selecione outro para participar";
                        MessageBox.Show(texto);
                        break;
                    }
                }
                //Verificar se já está no grupo
                if (podeEntrar == true)
                {
                    connection.Open();
                    SqlCommand utigru = connection.CreateCommand();
                    utigru.CommandType = CommandType.Text;
                    utigru.CommandText = @"insert into utilizadoresGrupos
                                        (id_grupo, id_utilizador)
                                        values (@id_grupo, @id_utilizador)";
                    utigru.Parameters.Add("@id_grupo", SqlDbType.Int).Value = idGrupo;
                    utigru.Parameters.Add("@id_utilizador", SqlDbType.Int).Value = Cconsultar.idLoggedUser;
                    utigru.ExecuteReader();
                    MessageBox.Show("Adicionado ao grupo com sucesso!!");
                }
                
            }
            else
            {
                string texto = "Este grupo já foi sorteado, por favor selecione outro para participar";
                MessageBox.Show(texto);
            }           
            this.Close();

        }
    }
}
