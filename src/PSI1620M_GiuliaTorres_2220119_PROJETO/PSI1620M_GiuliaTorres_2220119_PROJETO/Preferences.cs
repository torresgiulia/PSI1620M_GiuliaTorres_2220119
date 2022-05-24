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
            SqlConnection connection = new SqlConnection(connstring);

            //string comp1 = ((Button)sender).Text;
            //string comp1 = sender;
            

            connection.Open();

            Consultar.consulta_categorias();
            foreach (var pesquisa in Consultar.listCategorias)
            {
                //string comp2 = pesquisa.CategoriaNome;
                if (pesquisa.CategoriaNome == ((Button)sender).Text)
                {
                    categoriaId = pesquisa.CategoriaId;
                    SqlCommand utiCat = connection.CreateCommand();
                    utiCat.CommandText = @"insert into utilizadoresCategorias
                                                        (username, id_categoria)
                                                        values (@username, @id_categoria)";
                    utiCat.Parameters.Add("@username", SqlDbType.VarChar).Value = "o";
                    utiCat.Parameters.Add("@id_categoria", SqlDbType.Int).Value = 2;
                    break;

                }

            }




            //foreach (Control bt in this.Controls)
            //{
            //    if(bt is Button)
            //    {
            //        Consultar.consulta_categorias();
            //        foreach (var pesquisa in Consultar.listCategorias)
            //        {
            //            if (pesquisa.CategoriaNome == bt.Name)
            //            {
            //                categoriaId = pesquisa.CategoriaId;
            //                SqlCommand utiCat = connection.CreateCommand();
            //                utiCat.CommandText = @"insert into utilizadoresCategorias
            //                                            (id_uc,username, id_categoria)
            //                                            values (@id_uc,@username, @id_categoria)";
            //                utiCat.Parameters.Add("@username", SqlDbType.VarChar).Value = Consultar.loggedUser;
            //                utiCat.Parameters.Add("@id_categoria", SqlDbType.Int).Value = categoriaId;
            //                utiCat.Parameters.Add("@id_categoria", SqlDbType.Int).Value = 1;

            //            }

            //        }
            //    }
            //}


                //mudar a tag do botão
                //foreach (Control bt in this.Controls.OfType<Button>())
                //{
                //if(bt is Button)
                //{
                //    bt.Tag = 1;
                //    //bt.BackColor = Color.Blue;
                //    Consultar.consulta_categorias();
                //    foreach (var pesquisa in Consultar.listCategorias)
                //    {
                //        if (pesquisa.CategoriaNome == bt.Name)
                //        {
                //            categoriaId = pesquisa.CategoriaId;
                //            SqlCommand utiCat = connection.CreateCommand();
                //            utiCat.CommandText = @"insert into utilizadoresCategorias
                //                                    (id_uc,username, id_categoria)
                //                                    values (@id_uc,@username, @id_categoria)";
                //            utiCat.Parameters.Add("@username", SqlDbType.VarChar).Value = Consultar.loggedUser;
                //            utiCat.Parameters.Add("@id_categoria", SqlDbType.Int).Value = categoriaId;
                //            utiCat.Parameters.Add("@id_categoria", SqlDbType.Int).Value = 1;
                            
                //        }

                //    }
                //}               
            
        }
        private void Preferences_Load(object sender, EventArgs e) // load do forms
        {
            
        }
        private void bSubmit_Click(object sender, EventArgs e) // submeter
        {
            
        }


    }
}
