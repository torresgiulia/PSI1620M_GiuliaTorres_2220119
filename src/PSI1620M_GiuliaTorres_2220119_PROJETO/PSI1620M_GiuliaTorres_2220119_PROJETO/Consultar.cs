using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    public static class Consultar
    {
        public static string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        public static List<Concelhos> listConcelhos { get; set; }
        public static List<Categorias> listCategorias { get; set; }
        public static List<Utilizadores> listUtilizadores { get; set; }


        public static string loggedUser { get; set; }
        

        /// <summary>
        /// Ligação com a base de dados e a Lista concelhos
        /// </summary>
        public static void consulta_concelhos()
        {
            listConcelhos = new List<Concelhos>();
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



        /// <summary>
        /// Ligação com a base de dados e a Lista categorias
        /// </summary>
        public static void consulta_categorias()
        {
            listCategorias = new List<Categorias>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand cat = connection.CreateCommand();
                cat.CommandText = "select * from Categorias";

                var ler = cat.ExecuteReader();

                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        Categorias categoria = new Categorias()
                        {
                            CategoriaId = Convert.ToInt32(ler["id"].ToString()),
                            CategoriaNome = ler["nome"].ToString()
                        };

                        //adicionar a lista
                        listCategorias.Add(categoria);
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Ligação com a base de dados e a Lista utilizadores
        /// </summary>
        public static void consulta_utilizadores()
        {
            listUtilizadores = new List<Utilizadores>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand uti = connection.CreateCommand();
                uti.CommandText = "select * from Utilizadores";

                var ler = uti.ExecuteReader();
                if(ler.HasRows)
                {
                    while(ler.Read())
                    {
                        Utilizadores utilizador = new Utilizadores()
                        {

                            UtilizadorUsername = ler["username"].ToString(),
                            UtilizadorNome = ler["nome"].ToString(),
                            UtilizadorTelemovel = ler["telemovel"].ToString(),
                            UtilizadorPassword = ler["password"].ToString(),
                            UtilizadorEmail = ler["email"].ToString(),
                            UtilizadorIdConcelho = Convert.ToInt32(ler["id_concelho"].ToString())

                        };
                        listUtilizadores.Add(utilizador);

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
