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
    public partial class FsignIn : Form 
    {
        //Instaciação e criação de ConnectionStrings, List e BindingList
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;
        BindingList<Cconcelhos> bListConcelhos = new BindingList<Cconcelhos>();


        public FsignIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chama a ligação com a base de dados
        /// </summary>
        private void SignIn_Load(object sender, EventArgs e)
        {
            LigacaoComboBox_Concelhos(); 
        }


        /// <summary>
        /// Adicionar valor à base de dados
        /// </summary>
        public async void bSubmeter_Click(object sender, EventArgs e)
        {

            //Adicionar a base de dados
            SqlConnection connection = new SqlConnection(connstring);
            int adicionarId = 0;
            try
            {

                connection.Open();

                //Pesquisar o id do concelho selecionado
                await Cconsultar.consulta_concelhos();
                foreach(var pesquisa in Cconsultar.listConcelhos)
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

                //Verificar se o telemóvel é nulo
                if(tbTelemovel.Text != "")
                {
                    utili.Parameters.Add("@telemovel", SqlDbType.Int).Value = Convert.ToInt64(tbTelemovel.Text);
                }
                else
                {
                    utili.Parameters.Add("@telemovel", SqlDbType.Int).Value = 0;
                }

                //Verificar se o email é nulo
                if (tbEmail.Text != "")
                {
                    utili.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text;
                }
                else
                {
                    utili.Parameters.Add("@email", SqlDbType.VarChar).Value = "";
                }

                if (tbVpassword.Text == tbPassword.Text)
                {
                    utili.Parameters.Add("@password", SqlDbType.VarChar).Value = tbPassword.Text;

                    utili.ExecuteNonQuery();

                    Cconsultar.loggedUser = tbUtilizador.Text;
                    // Adicionar id a uma variável
                    await Cconsultar.consulta_utilizadores();
                    foreach (var pesquisa in Cconsultar.listUtilizadores)
                    {
                        if (pesquisa.UtilizadorUsername == tbUtilizador.Text)
                        {
                            Cconsultar.idLoggedUser = pesquisa.UtilizadorId;
                        }
                    }

                    //mudar a página
                    Fpreferences preferences = new Fpreferences();
                    preferences.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Passwords bão coicidem! ");
                    tbPassword.Clear();
                    tbVpassword.Clear();


                }

                


                

            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Adicionar informação à comboBox (BindingList)
        /// </summary>
        public async void LigacaoComboBox_Concelhos()
        {
            SqlConnection connection = new SqlConnection(connstring);
            try
            {

                //Adicionar a comboBox
                await Cconsultar.consulta_concelhos();
                bListConcelhos = new BindingList<Cconcelhos>(Cconsultar.listConcelhos.OrderBy(x => x.ConcelhoNome).ToList());               
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


        /// <summary>
        /// mudar para LogIn
        /// </summary>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FlogIn logIn = new FlogIn();
            logIn.Show();
            this.Hide();
        }
    }
}
            