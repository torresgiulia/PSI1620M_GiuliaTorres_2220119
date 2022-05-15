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
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        List<Concelhos> listConcelhos = new List<Concelhos>();

        BindingList<Concelhos> bListConcelhos = new BindingList<Concelhos>();

        public SignIn()
        {
            InitializeComponent();
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

                CBconcelho.DataSource = bListConcelhos;
                CBconcelho.DisplayMember = "ConcelhoNome";
                CBconcelho.ValueMember = "ConcelhoId";
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

        private void SignIn_Load(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(connstring);


            //// Ligação à base de dados para ligar com a comboBox Concelho (CBconcelho)
            //try
            //{
            //    connection.Open();
            //    SqlCommand conc = connection.CreateCommand();
            //    conc.CommandText = "select * from Concelhos";
            //    connection.Open();

            //    var ler = conc.ExecuteReader();

            //    if (ler.HasRows)
            //    {
            //        while (ler.Read())
            //        {
            //            Concelhos concelho = new Concelhos()
            //            {
            //                ConcelhoId = Convert.ToInt32(ler["id"].ToString()),
            //                ConcelhoNome = ler["nome"].ToString()
            //            };
            //            listConcelhos.Add(concelho);
            //        }
            //    }
            //    bListConcelhos = new BindingList<Concelhos>(listConcelhos.OrderBy(x => x.ConcelhoNome).ToList());

            //    CBconcelho.DataSource = bListConcelhos;
            //    CBconcelho.DisplayMember = "ConcelhoNome";
            //    CBconcelho.ValueMember = "ConcelhoId";
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //finally
            //{
            //    if (connection.State == ConnectionState.Open)
            //    {
            //        connection.Close();
            //    }
            //}            


            //foreach (var conce in listConcelhos)
            //{
                
            //}




            // SELECT * TABELA_CONCELHOS
            // FOR EACH ROW... READ

        }



    }
}
            