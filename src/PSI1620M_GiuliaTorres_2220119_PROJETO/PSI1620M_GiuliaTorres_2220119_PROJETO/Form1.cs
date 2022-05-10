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
    public partial class Form1 : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        List<Categorias> categorias = new List<Categorias>();
        List<Concelhos> concelhos  = new List<Concelhos>();
        List<Utilizadores> utilizadores  = new List<Utilizadores>();
        List<Grupos> grupos  = new List<Grupos>();
        List<Vendedores> vendedores  = new List<Vendedores>();
        List<Produtos> produtos = new List<Produtos>();
        List<produtosCategorias> ProdutosCategorias  = new List<produtosCategorias>();
        List<utilizadoresCategorias> UtilizadoresCategorias  = new List<utilizadoresCategorias>();
        List<utilizadoresGrupos> UtilizadoresGrupos  = new List<utilizadoresGrupos>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connstring);
             /*EXEMPLO DE LIGAÇÃO COM O UTILIZADOR
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select * from utilizadores";
                connection.Open();

                var lr = cmd.ExecuteReader();
                if(lr.HasRows)
                {
                    while(lr.Read())
                    {
                        Utilizadores utilizadores = new Utilizadores()
                        {

                            UtilizadorNome = lr["nome"].ToString(),
                            UtilizadorUsername = lr["username"].ToString(),
                            UtilizadorEmail = lr["email"].ToString(),
                            UtilizadorPassword = lr["password"].ToString(),
                            UtilizadorIdConcelho = Convert.ToInt32(lr["id_concelho"].ToString()),
                            UtilizadorTelemovel = lr["telemovel"].ToString()
                        };
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }*/
        }
    }
}
