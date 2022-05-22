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
    public partial class SignIn : Form
    {
        //Instaciação e criação de ConnectionStrings, List e BindingList
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;
        List<Concelhos> listConcelhos = new List<Concelhos>();
        BindingList<Concelhos> bListConcelhos = new BindingList<Concelhos>();

        


        public SignIn()
        {
            InitializeComponent();
        }


        private void SignIn_Load(object sender, EventArgs e)
        {
            LigacaoComboBox_Concelhos(); 
        }

        private void bSubmeter_Click(object sender, EventArgs e)
        {


            //Adicionar a base de dados
            SqlConnection connection = new SqlConnection(connstring);
            int adicionarId = 0;
            try
            {

                connection.Open();

                //Pesquisar o id do concelho selecionado
                consulta_concelhos();
                foreach(var pesquisa in listConcelhos)
                {
                    if(pesquisa.ConcelhoNome == cbConcelhos.Text)
                    {
                        adicionarId = pesquisa.ConcelhoId;
                        break;
                    }
                }


                //Inserir a informação do utilizador a base de dados
                SqlCommand utili = connection.CreateCommand();
                utili.CommandType = CommandType.Text;
                utili.CommandText = @"insert into Utilizadores 
                                        (username, nome, id_concelho, telemovel, password, email)
                                        values (@username,@nome,@id_concelho,@telemovel,@password, @email)";
                utili.Parameters.Add("@username", SqlDbType.VarChar).Value = tbUtilizador.Text;
                utili.Parameters.Add("@nome", SqlDbType.VarChar).Value = tbNome.Text;
                utili.Parameters.Add("@id_concelho", SqlDbType.Int).Value = adicionarId;
                utili.Parameters.Add("@telemovel", SqlDbType.Int).Value = Convert.ToInt64(tbTelemovel.Text);
                utili.Parameters.Add("@password", SqlDbType.VarChar).Value = tbPassword.Text;
                utili.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text;

                utili.ExecuteNonQuery();

                //mudar a página
                Preferences preferences = new Preferences();
                preferences.Show();
                this.Hide();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void LigacaoComboBox_Concelhos()
        {
            SqlConnection connection = new SqlConnection(connstring);
            try
            {

                //Adicionar a comboBox
                consulta_concelhos();
                bListConcelhos = new BindingList<Concelhos>(listConcelhos.OrderBy(x => x.ConcelhoNome).ToList());               
                cbConcelhos.DataSource = bListConcelhos;               
                cbConcelhos.DisplayMember = "ConcelhoNome";
                cbConcelhos.ValueMember = "ConcelhoId";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


                                //FUNÇÕES DE LIGAÇÃO E CONSULTA:

        /// <summary>
        /// Função para fazer a ligação com a base de dados e a Lista concelhos
        /// </summary>
        public void consulta_concelhos()
        {
            try
            {
                //Fazer a conexão
                SqlConnection connection = new SqlConnection(connstring);
                connection.Open();
                SqlCommand conc = connection.CreateCommand();
                conc.CommandText = "select * from Concelhos";

                var ler = conc.ExecuteReader();

                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        Concelhos concelho = new Concelhos()
                        {
                            ConcelhoId = Convert.ToInt32(ler["id"].ToString()),
                            ConcelhoNome = ler["nome"].ToString()
                        };

                        //adicionar a lista
                        listConcelhos.Add(concelho);
                    }
                }
                
            }
            catch(Exception)
            {
                throw;
            }
        }

        
    }
}
            