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
    public partial class Preferences : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;
        List<Preferences> listPreferences = new List<Preferences>();


        public Preferences()
        {
            InitializeComponent();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {

        }

        private void select_preferences(object sender, EventArgs e)
        {
            for(int i = 0; i<20; i++)
            {
                
            }
        }

        private void Preferences_Load(object sender, EventArgs e)
        {

        }

        public void testar_preferencias()
        {
            //adicionar na base de dados
            //Adicionar a base de dados
            SqlConnection connection = new SqlConnection(connstring);
            try
            {
                connection.Open();

                //Pesquisar o id do concelho selecionado
                foreach (var pesquisa in listPreferences)
                {
                    if (pesquisa.ConcelhoNome == cbConcelhos.Text)
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


            if (bAnime.Enabled)
            {

            }
        }
    }
}
