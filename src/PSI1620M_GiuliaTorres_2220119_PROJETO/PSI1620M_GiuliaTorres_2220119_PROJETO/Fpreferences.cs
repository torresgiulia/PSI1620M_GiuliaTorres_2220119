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
    public partial class Fpreferences : Form 
    {

        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        public int categoriaId { get; set; }
        
        
        public Fpreferences()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// Função para adicionar cada botão a base de dados (utilizadorCategoria)
        /// </summary>
        /// <param name="sender"> utilizado para comparar o texto do botão</param>
        private async void select_preferences(object sender, EventArgs e) 
        {
            SqlConnection connection = new SqlConnection(connstring);

            connection.Open();

             await Cconsultar.consulta_categorias();
            foreach (var pesquisa in Cconsultar.listCategorias)
            {
                ((Button)sender).BackColor = Color.FromArgb(255, 184, 237);

                if (pesquisa.CategoriaNome == ((Button)sender).Text)
                {
                    categoriaId = pesquisa.CategoriaId;
                    SqlCommand utiCat = connection.CreateCommand();
                    utiCat.CommandText = @"insert into utilizadoresCategorias
                                                        (id_utilizador, id_categoria)
                                                        values (@id_utilizador, @id_categoria)";
                    utiCat.Parameters.Add("@id_utilizador", SqlDbType.Int).Value = Cconsultar.idLoggedUser;
                    utiCat.Parameters.Add("@id_categoria", SqlDbType.Int).Value = categoriaId;
                    utiCat.ExecuteNonQuery();
                    break;

                }

            }             
            
        }
        

        /// <summary>
        /// Deleta qualquer preferencia que possa já lá estar
        /// </summary>
        private async void Preferences_Load(object sender, EventArgs e) 
        {
            SqlConnection connection = new SqlConnection(connstring);

            connection.Open();


            await Cconsultar.consulta_utilizadoresCategorias();
            foreach (var pesquisa in Cconsultar.listUtilizadoresCategorias)
            {
                if (pesquisa.utilizadorCategoriaIdUtilizador == Cconsultar.idLoggedUser)
                {
                    SqlCommand deletuticat = connection.CreateCommand();
                    deletuticat.CommandText = @"delete utilizadoresCategorias where id_utilizador = @user";
                    deletuticat.Parameters.Add("@user", SqlDbType.VarChar).Value = Cconsultar.idLoggedUser;
                    deletuticat.ExecuteNonQuery();
                    break;
                }
            }
        }


        /// <summary>
        /// Botão de submeter (vai para o menu)
        /// </summary>
        private void bSubmit_Click(object sender, EventArgs e) 
        {
            Fhome home = new Fhome();
            home.Show();
            this.Hide();
        }


    }
}
