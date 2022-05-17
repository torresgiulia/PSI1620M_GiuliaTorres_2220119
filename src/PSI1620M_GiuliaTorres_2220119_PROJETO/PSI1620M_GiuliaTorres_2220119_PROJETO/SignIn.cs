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
            try
            {
                connection.Open();
                SqlCommand utili = connection.CreateCommand();
                utili.CommandText = @"insert into Utilizadores 
                                        (username, nome, id_concelho, telemovel, password, email)
                                    values (@username,
                                            @nome,
                                            @id_concelho,
                                            @telemovel,
                                            @password, 
                                            @email)";
                utili.Parameters.Add("@username", SqlDbType.VarChar).Value = tbUtilizador.Text.Trim();
                utili.Parameters.Add("@nome", SqlDbType.VarChar).Value = tbNome.Text.Trim();
                utili.Parameters.Add("@id_concelho", SqlDbType.Int).Value = 1;
                utili.Parameters.Add("@telemovel", SqlDbType.Int).Value = Convert.ToInt64(tbTelemovel.Text);
                utili.Parameters.Add("@password", SqlDbType.VarChar).Value = tbPassword.Text.Trim();
                utili.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text.Trim();

                utili.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Função para fazer a ligação com a base de dados e a Lista concelhos
        /// Adiciona a informação à ComboBox
        /// </summary>
        public void LigacaoComboBox_Concelhos()
        {
            SqlConnection connection = new SqlConnection(connstring);

            // Ligação à base de dados para ligar com a comboBox Concelho (CBconcelho)
            try
            {
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
                        listConcelhos.Add(concelho);
                    }
                }
                bListConcelhos = new BindingList<Concelhos>(listConcelhos.OrderBy(x => x.ConcelhoNome).ToList());

                //adicionar a lista
                cbConcelhos.DataSource = bListConcelhos;
                //Adicionar a comboBox
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

        
    }
}
            