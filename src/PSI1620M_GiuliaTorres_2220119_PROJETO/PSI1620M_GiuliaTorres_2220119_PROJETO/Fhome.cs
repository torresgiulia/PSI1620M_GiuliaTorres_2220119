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
    public partial class Fhome : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;


        public Fhome()
        {
            InitializeComponent();
            lnome.Text = Cconsultar.loggedUser;
            //Descobrir Id
            Cconsultar.consulta_utilizadores();
            foreach (var pesquisa in Cconsultar.listUtilizadores)
            {
                if (pesquisa.UtilizadorUsername == Cconsultar.loggedUser)
                {
                    Cconsultar.idLoggedUser = pesquisa.UtilizadorId;
                }
            }
        }
    
        /// <summary>
        /// Guiar para o Novo Grupo
        /// </summary>
        private void bNovoGrupo_Click(object sender, EventArgs e)
        {
            FnovoGrupo novoGrupo = new FnovoGrupo();
            novoGrupo.Show();
        }

        private void Fhome_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connstring);

            //Adicionar grupos a ListBox
            //foreach(var pesquisa in Cconsultar.listUtilizadoresGrupos)
            //{

            //}
            if (Cconsultar.listPerfilGrupos.Count == 0)
            {
                try
                {
                    Cconsultar.consulta_utilizadoresGrupos();
                    foreach (var pesquisa in Cconsultar.listUtilizadoresGrupos)
                    {


                        if (pesquisa.utilizadorGrupoIdUtilizador == Cconsultar.idLoggedUser)
                        {
                            Cconsultar.consulta_grupo();
                            foreach (var grupo in Cconsultar.listGrupos)
                            {
                                if (grupo.GrupoId == pesquisa.utilizadorGrupoIdGrupo)
                                {
                                    Cconsultar.listPerfilGrupos.Add(grupo.GrupoNome);
                                    break;
                                }
                            }
                        }
                    }
                    
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
            // Adicionar na lista
            lbGrupos.DataSource = Cconsultar.listPerfilGrupos;
            

                
        }
    }
}
