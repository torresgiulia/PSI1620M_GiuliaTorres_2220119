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
        //public new System.Windows.Forms.Control.ControlCollection Controls { get; }

        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        public int categoriaId { get; set; }
        
        
        public Preferences()
        {
            InitializeComponent();
            
        }


        private void select_preferences(object sender, EventArgs e) //selecionar preferencias (botões)
        {
            //mudar a tag do botão
            foreach (Control bt in this.Controls)
            {
                bt.Tag = 1;
                bt.BackColor = Color.Beige;
            }
        }
        private void Preferences_Load(object sender, EventArgs e) // load do forms
        {
            SqlConnection connection = new SqlConnection(connstring);
            try
            {
                connection.Open();

                foreach (Control bt in this.Controls)
                {
                    if (bt is Button && bt.Text.StartsWith("b"))
                    {
                        Consultar.consulta_categorias();
                        foreach (var pesquisa in Consultar.listCategorias)
                        {
                            if (pesquisa.CategoriaNome == bt.Text)
                            {
                                categoriaId = pesquisa.CategoriaId;
                                break;
                            }
                        }
                        //if (/*utilizar a tag do botão*/(bt as Button).Ckicked == true)
                        //{
                        //    SqlCommand utiCat = connection.CreateCommand();
                        //    utiCat.CommandText = @"insert into utilizadoresCategorias
                        //                            (username, id_categoria)
                        //                            values (@username, @id_categoria)";
                        //    utiCat.Parameters.Add("@username", SqlDbType.VarChar).Value = Consultar.loggedUser;
                        //    utiCat.Parameters.Add("@id_categoria", SqlDbType.Int).Value = categoriaId;
                        //}

                    }
                }
            }
            catch(Exception)
            {
                throw;
            }


            
            Consultar.consulta_utilizadores();
            //adicionar o nome de utilizador e id_categoria de cada categoria





            //foreach (var pesquisa in Consultar.listUtilizadores)
            //{
            //    if(pesquisa.UtilizadorUsername == Consultar.loggedUser)
            //    {

            //    }
            //}
        }
        private void bSubmit_Click(object sender, EventArgs e) // submeter
        {
            for(int i=1; i<=20; i++)
            {
                //botao que inicia com b% 
                //caso esteja selcionado adicionar id utilizador e button.text
                //if()
            }
        }


    }
}
