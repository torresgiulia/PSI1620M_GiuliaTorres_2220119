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
    public partial class Consultas : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;
        List<Concelhos> listConcelhos = new List<Concelhos>();



        public Consultas()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Função para fazer a ligação com a base de dados e a Lista concelhos
        /// </summary>
        public void consulta_concelhos()
        {
            SqlConnection connection = new SqlConnection(connstring);
            try
            {
                //Fazer a conexão
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
            catch (Exception)
            {
                throw;
            }
        }
    }
}
