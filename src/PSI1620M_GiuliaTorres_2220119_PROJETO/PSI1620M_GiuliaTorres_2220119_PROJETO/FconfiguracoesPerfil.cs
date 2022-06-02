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
    public partial class FconfiguracoesPerfil : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;
        List<string> listGrupos = new List<string>();
        public string campoDeUpdate { get; set; }

        public string valorUpdateString { get; set; }
                

        public FconfiguracoesPerfil()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adicionar nas labels e listbox as informações do utilizador
        /// </summary>
        private void FconfiguracoesPerfil_Load(object sender, EventArgs e)
        {
            

            SqlConnection connection = new SqlConnection(connstring);

            //Adicionar as Labels
            Cconsultar.consulta_utilizadores();
            foreach (var pesquisa in Cconsultar.listUtilizadores)
            {
                if (pesquisa.UtilizadorUsername == Cconsultar.loggedUser)
                {
                    llNome.Text = pesquisa.UtilizadorNome;
                    llEmail.Text = pesquisa.UtilizadorEmail;
                    llTelemovel.Text = pesquisa.UtilizadorTelemovel;
                    llUsername.Text = pesquisa.UtilizadorUsername;
                    break;
                }
            }

            //Adicionar grupos a ListBox
            try
            {
                Cconsultar.consulta_utilizadoresGrupos();
                foreach (var pesquisa in Cconsultar.listUtilizadoresGrupos)
                {
                    if (pesquisa.utilizadorGrupoIdUtilizador == Cconsultar.idLoggedUser)
                    {
                        Cconsultar.consulta_grupo();
                        foreach(var grupo in Cconsultar.listGrupos)
                        {
                            if(grupo.GrupoId == pesquisa.utilizadorGrupoIdGrupo)
                            {
                                listGrupos.Add(grupo.GrupoNome);
                                break;
                            }
                        }                        
                    }
                }
                // Adicionar na lista
                lbGrupos.DataSource = listGrupos;

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

        private void linkLabel()
        {
            

            
        }

        private void llNome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(connstring);
            Cconsultar.labelText = "Nome";
            //linkLabel();
            FalterarPerfil alterarPerfil = new FalterarPerfil();
            alterarPerfil.Show();

            try
            {
                connection.Open();
                SqlCommand update = connection.CreateCommand();
                update.CommandType = CommandType.Text;
                update.CommandText = @"update Utilizadores set nome = @nome 
                                        where id = @valorid";
                update.Parameters.Add("@nome", SqlDbType.VarChar).Value = Cconsultar.textBoxText;
                update.Parameters.Add("@valorid", SqlDbType.VarChar).Value = Cconsultar.idLoggedUser;
                update.ExecuteNonQuery();

            }
            catch(Exception)
            {
                //throw;
            }

        }

        private void llUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llTelemovel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
