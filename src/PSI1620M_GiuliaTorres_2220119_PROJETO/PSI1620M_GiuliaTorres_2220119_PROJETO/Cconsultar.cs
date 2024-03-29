﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    public static class Cconsultar
    {
        public static string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        //Grupo de Listas para as consultas a base de dados
        public static List<Cconcelhos> listConcelhos { get; set; }
        public static List<Ccategorias> listCategorias { get; set; }
        public static List<Cutilizadores> listUtilizadores { get; set; }
        public static List<Cgrupos> listGrupos { get; set; }
        public static List<CgruposPesquisar> listGruposPesquisa { get; set; } 
        public static List<CutilizadoresCategorias> listUtilizadoresCategorias { get; set; }
        public static List<CutilizadoresGrupos> listUtilizadoresGrupos{ get; set; }
        public static List<Cprodutos> listProdutos { get; set; }
        public static List<CprodutosCategorias> listprodutosCategorias { get; set; }
        public static List<Cvendedores> listVendedores { get; set; }


        //Lista para saber quais utilizadores se encotram em determinado grupo
        public static List<string> listPerfilGrupos = new List<string>();


        //Atributos para saber o utilizador logado
        public static string loggedUser { get; set; }
        public static int idLoggedUser { get; set; }
        private static int idUtilizadorSorteado { get; set; }


        //Para as configurações de perfil
        public static string labelText { get; set; }
        public static string textBoxText { get; set; }
        public static int textBoxTextId { get; set; }


        //Para as Pesquisas
        public static string textoPesquisa { get; set; }
        public static string nomeGrupo { get; set; }


        //Para Produtos
        public static string produtoNome { get; set; }


        /// <summary>
        /// Ligação com a base de dados e a Lista concelhos
        /// </summary>
        public static async Task consulta_concelhos()
        {
            listConcelhos = new List<Cconcelhos>();
            SqlConnection connection = new SqlConnection(connstring);
            try
            {
                //Fazer a conexão
                connection.Open();
                SqlCommand conc = connection.CreateCommand();
                conc.CommandText = "select * from Concelhos";

                var ler = await conc.ExecuteReaderAsync();

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
        public static async Task consulta_categorias()
        {
            listCategorias = new List<Ccategorias>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand cat = connection.CreateCommand();
                cat.CommandText = "select * from Categorias";

                var ler = await cat.ExecuteReaderAsync();

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
        public static async Task consulta_utilizadores()
        {
            listUtilizadores = new List<Cutilizadores>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand uti = connection.CreateCommand();
                uti.CommandText = "select * from Utilizadores";

                var ler = await uti.ExecuteReaderAsync();
                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        Cutilizadores utilizador = new Cutilizadores()
                        {
                            UtilizadorId = Convert.ToInt32(ler["id"].ToString()),
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
        /// Ligação com a base de dados e a Lista utilizadoresCategorias
        /// </summary>
        public static async Task consulta_utilizadoresCategorias()
        {
            listUtilizadoresCategorias = new List<CutilizadoresCategorias>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand uticat = connection.CreateCommand();
                uticat.CommandText = "select * from utilizadoresCategorias";

                var ler = await uticat.ExecuteReaderAsync();
                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        CutilizadoresCategorias utilizadorCategoria = new CutilizadoresCategorias()
                        {
                            utilizadorCategoriaId = Convert.ToInt32(ler["id_uc"].ToString()),
                            utilizadorCategoriaIdUtilizador = Convert.ToInt32(ler["id_utilizador"].ToString()),
                            utilizadorCategoriaIdCategoria = Convert.ToInt32(ler["id_categoria"].ToString()),
                        };
                        listUtilizadoresCategorias.Add(utilizadorCategoria);

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
        public static async Task consulta_grupo()
        {
            listGrupos = new List<Cgrupos>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand gru = connection.CreateCommand();
                gru.CommandText = "select * from Grupos";

                var ler = await gru.ExecuteReaderAsync();
                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        Cgrupos grupo = new Cgrupos()
                        {

                            GrupoId = Convert.ToInt32(ler["id"].ToString()),
                            GrupoNome = ler["nome"].ToString(),
                            GrupoEstado = ler["estado"].ToString(),
                            GrupoUtilizadorLider = Convert.ToInt32(ler["id_utilizador_lider"].ToString()),
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


        /// <summary>
        /// Query de consulta para o Forms de pesquisa
        /// </summary>
        public static async Task consulta_grupopesquisa()
        {
            listGruposPesquisa = new List<CgruposPesquisar>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand pesquisar = connection.CreateCommand();
                pesquisar.CommandText = @"SELECT * 
                                        FROM Grupos
                                        WHERE nome like  @pesquisa ";
                pesquisar.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = $"%{Cconsultar.textoPesquisa}%";
                var ler = await pesquisar.ExecuteReaderAsync();
                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        CgruposPesquisar gruposPesquisa = new CgruposPesquisar()
                        {
                            GrupoPesquisaId = Convert.ToInt32(ler["id"].ToString()),
                            GrupoPesquisaNome = ler["nome"].ToString(),
                            GrupoPesquisaEstado = ler["estado"].ToString(),
                            GrupoPesquisaUtilizadorLider = Convert.ToInt32(ler["id_utilizador_lider"].ToString()),
                            GrupoPesquisaDescricao = ler["descricao"].ToString(),
                        };
                        listGruposPesquisa.Add(gruposPesquisa);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Ligação com a base de dados e a Lista utilizadoresGrupos
        /// </summary>
        public static async Task consulta_utilizadoresGrupos()
        {

            listUtilizadoresGrupos = new List<CutilizadoresGrupos>();
            SqlConnection connection = new SqlConnection(connstring);
            try
            {
                connection.Open();
                SqlCommand utigru = connection.CreateCommand();
                utigru.CommandText = "select * from utilizadoresGrupos";

                var ler = await utigru.ExecuteReaderAsync();
                if (ler.HasRows)
                {
                    while (ler.Read())
                    {
                        // Checar se o utilizador sorteado é nulo
                        if(String.IsNullOrEmpty(ler["id_utilizadorSorteado"].ToString())) //String.IsNullOrEmpty(idr["ColumnNameFromDB"].ToString()
                        {
                            idUtilizadorSorteado = 0;
                        }
                        else
                        {
                            idUtilizadorSorteado = Convert.ToInt32(ler["id_utilizadorSorteado"].ToString());
                        }
                        //

                        CutilizadoresGrupos utilizadoresgrupos = new CutilizadoresGrupos()
                        {
                            utilizadorGrupoId = Convert.ToInt32(ler["id_ug"].ToString()),
                            utilizadorGrupoIdGrupo = Convert.ToInt32(ler["id_grupo"].ToString()),
                            utilizadorGrupoIdUtilizador = Convert.ToInt32(ler["id_utilizador"].ToString()),
                            utilizadorGrupoIdUtilizadorSorteado = idUtilizadorSorteado,
                        };
                        listUtilizadoresGrupos.Add(utilizadoresgrupos);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Ligação com a base de dados e a Lista Produtos
        /// </summary>
        public static async Task consulta_produtos()
        {
            listProdutos = new List<Cprodutos>();
            SqlConnection connection = new SqlConnection(connstring);
            try
            {
                connection.Open();
                SqlCommand prod = connection.CreateCommand();
                prod.CommandText = "select * from Produtos";

                var ler = await prod.ExecuteReaderAsync();
                if (ler.HasRows)
                {
                    while (ler.Read())
                    {

                        Cprodutos produtos = new Cprodutos()
                        {
                            ProdutoId = Convert.ToInt32(ler["id"].ToString()),
                            ProdutoIdVendedor = Convert.ToInt32(ler["id_vendedor"].ToString()),
                            ProdutoValor = Convert.ToDecimal(ler["valor"].ToString()),
                            ProdutoDescricao = ler["descricao"].ToString(),
                            ProdutoNome = ler["nome"].ToString(),
                        };
                        listProdutos.Add(produtos);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Ligação com a base de dados e a Lista Vendedores
        /// </summary>
        public static async Task consulta_vendedores()
        {
            listVendedores = new List<Cvendedores>();
            SqlConnection connection = new SqlConnection(connstring);
            try
            {
                connection.Open();
                SqlCommand vend = connection.CreateCommand();
                vend.CommandText = "select * from Vendedores";

                var ler = await vend.ExecuteReaderAsync();
                if (ler.HasRows)
                {
                    while (ler.Read()) 
                    {

                        Cvendedores vendedores = new Cvendedores()
                        {
                            VendedorId = Convert.ToInt32(ler["id"].ToString()),
                            VendedorNome = ler["nome"].ToString(),
                            VendedorIdCodigoPostal = ler["codigopostal"].ToString(),
                            VendedorIdConcelho = Convert.ToInt32(ler["id_concelho"].ToString()),
                            VendedorMorada = ler["morada"].ToString(),
                        };
                        listVendedores.Add(vendedores);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Ligação com a base de dados e a Lista produtoCategoria
        /// </summary>
        public static async Task consulta_produtosCategorias()
        {
            listprodutosCategorias = new List<CprodutosCategorias>();
            SqlConnection connection = new SqlConnection(connstring);

            try
            {
                connection.Open();
                SqlCommand prodcat = connection.CreateCommand();
                prodcat.CommandType = CommandType.Text;
                prodcat.CommandText = "select * from produtosCategorias";

                var ler = await prodcat.ExecuteReaderAsync();
                if(ler.HasRows)
                {
                    while(ler.Read())
                    {
                        CprodutosCategorias produtoscategorias = new CprodutosCategorias()
                        {
                            produtoCategoriaId = Convert.ToInt32(ler["id_pc"].ToString()),
                            produtoCategoriaIdCategoria = Convert.ToInt32(ler["id_categoria"].ToString()),
                            produtoCategoriaIdProduto = Convert.ToInt32(ler["id_produto"].ToString()),
                        };
                        listprodutosCategorias.Add(produtoscategorias);
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
