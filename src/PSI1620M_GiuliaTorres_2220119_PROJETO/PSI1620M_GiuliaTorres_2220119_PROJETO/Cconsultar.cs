using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    public static class Cconsultar
    {
        public static string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        public static List<Cconcelhos> listConcelhos { get; set; }
        public static List<Ccategorias> listCategorias { get; set; }
        public static List<Cutilizadores> listUtilizadores { get; set; }
        public static List<Cgrupos> listGrupos { get; set; }



        public static string loggedUser { get; set; }



        /// <summary>
        /// Ligação com a base de dados e a Lista concelhos
        /// </summary>
        public static void consulta_concelhos()
        {
            listConcelhos = new List<Cconcelhos>();
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
                        Cconcelhos concelho = new Cconcelhos()
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
            listCategorias = new List<Ccategorias>();
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
                        Ccategorias categoria = new Ccategorias()
                        {
                            CategoriaId = Convert.ToInt32(ler["id"].ToString()),
                            CategoriaNome = ler["nome"].ToString()
                        };

                        //adicionar a lista
                        listCategorias.Add(categoria);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Ligação com a base de dados e a Lista utilizadores
        /// </summary>
        public static void consulta_utilizadores()
        {
            listUtilizadores = new List<Cutilizadores>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand uti = connection.CreateCommand();
                uti.CommandText = "select * from Utilizadores";

                var ler = uti.ExecuteReader();
                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        Cutilizadores utilizador = new Cutilizadores()
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
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Ligação com a base de dados e a Lista grupos
        /// </summary>
        public static void consulta_grupo()
        {
            listGrupos = new List<Cgrupos>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand gru = connection.CreateCommand();
                gru.CommandText = "select * from Grupos";

                var ler = gru.ExecuteReader();
                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        Cgrupos grupo = new Cgrupos()
                        {

                            GrupoId = Convert.ToInt32(ler["id"].ToString()),
                            GrupoNome = ler["nome"].ToString(),
                            GrupoEstado = ler["estado"].ToString(),
                            GrupoUtilizadorLider = ler["username_utilizador_lider"].ToString(),
                            GrupoDescricao = ler["descricao"].ToString(),
                        };
                        listGrupos.Add(grupo);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Funções para os botões do rodapé


        ///// <summary>
        ///// Mudar para a página Home
        ///// </summary>
        //public static void bHome_Click(object sender, EventArgs e)
        //{
        //    Fhome home = new Fhome();
        //    home.Show();
        //    this.Hide();
        //}

        ///// <summary>
        ///// Mudar para a página Produtos
        ///// </summary>
        //public static void bProdutos_Click(object sender, EventArgs e)
        //{
        //    Fcarrinho carrinho = new Fcarrinho();
        //    carrinho.Show();
        //    this.Hide();
        //}

        ///// <summary>
        ///// Mudar para a página Pesquisar
        ///// </summary>
        //public static void bPesquisar_Click(object sender, EventArgs e)
        //{
        //    Fpesquisar pesquisar = new Fpesquisar();
        //    pesquisar.Show();
        //    this.Hide();
        //}

        ///// <summary>
        ///// Mudar para a página Perfil
        ///// </summary>
        //public static void bPerfil_Click(object sender, EventArgs e)
        //{
        //    Fperfil perfil = new Fperfil();
        //    perfil.Show();
        //    this.Hide();
        //}

    }
}
