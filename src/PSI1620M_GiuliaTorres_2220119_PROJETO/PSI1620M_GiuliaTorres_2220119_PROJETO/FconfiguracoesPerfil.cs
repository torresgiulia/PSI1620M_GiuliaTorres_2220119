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


        /// <summary>
        /// Instanciar o forms para a entrada do update
        /// </summary>
        public void abrirPagina()
        {
            FalterarPerfil alterarPerfil = new FalterarPerfil();
            alterarPerfil.ShowDialog();
        }

        /// <summary>
        /// Mudar o nome (update)
        /// </summary>
        private void llNome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connstring);
                Cconsultar.labelText = "Nome";
                abrirPagina();
                
                connection.Open();
                SqlCommand update = connection.CreateCommand();
                update.CommandType = CommandType.Text;
                update.CommandText = @"update Utilizadores set nome = @nome 
                                        where id = @valorid";
                update.Parameters.Add("@nome", SqlDbType.VarChar).Value = Cconsultar.textBoxText;
                update.Parameters.Add("@valorid", SqlDbType.Int).Value = Cconsultar.idLoggedUser;
                update.ExecuteNonQuery();

                llNome.Text = Cconsultar.textBoxText;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        /// <summary>
        /// Mudar o username (update)
        /// </summary>
        private void llUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connstring);
                Cconsultar.labelText = "Username";
                abrirPagina();

                connection.Open();
                SqlCommand update = connection.CreateCommand();
                update.CommandType = CommandType.Text;
                update.CommandText = @"update Utilizadores set username = @user 
                                   where id = @valorid";
                update.Parameters.Add("@user", SqlDbType.VarChar).Value = Cconsultar.textBoxText;
                update.Parameters.Add("@valorid", SqlDbType.Int).Value = Cconsultar.idLoggedUser;
                update.ExecuteNonQuery();

                Cconsultar.loggedUser = Cconsultar.textBoxText;
                llUsername.Text = Cconsultar.textBoxText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
        }

        /// <summary>
        /// Mudar o email (update)
        /// </summary>
        private void llEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connstring);
                Cconsultar.labelText = "Email";
                abrirPagina();

                connection.Open();
                SqlCommand update = connection.CreateCommand();
                update.CommandType = CommandType.Text;
                update.CommandText = @"update Utilizadores set email = @email 
                                        where id = @valorid";
                update.Parameters.Add("@email", SqlDbType.VarChar).Value = Cconsultar.textBoxText;
                update.Parameters.Add("@valorid", SqlDbType.Int).Value = Cconsultar.idLoggedUser;
                update.ExecuteNonQuery();

                llEmail.Text = Cconsultar.textBoxText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Mudar o telemovel (update)
        /// </summary>
        private void llTelemovel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connstring);
                Cconsultar.labelText = "Telemóvel";
                abrirPagina();

                connection.Open();
                SqlCommand update = connection.CreateCommand();
                update.CommandType = CommandType.Text;
                update.CommandText = @"update Utilizadores set telemovel = @telemovel 
                                        where id = @valorid";
                update.Parameters.Add("@telemovel", SqlDbType.Int).Value = Cconsultar.textBoxText;
                update.Parameters.Add("@valorid", SqlDbType.Int).Value = Cconsultar.idLoggedUser;
                update.ExecuteNonQuery();

                llTelemovel.Text = Cconsultar.textBoxText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
