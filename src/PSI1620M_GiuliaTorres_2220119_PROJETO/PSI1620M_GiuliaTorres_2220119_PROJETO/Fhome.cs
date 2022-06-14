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
            
        }
    
        /// <summary>
        /// Guiar para o Novo Grupo
        /// </summary>
        private void bNovoGrupo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FnovoGrupo novoGrupo = new FnovoGrupo();
            novoGrupo.Show();
        }



        /// <summary>
        /// Adiciona os grupos do utilizador à listBox
        /// </summary>
        private async void Fhome_Load(object sender, EventArgs e)
        {
            lnome.Text = Cconsultar.loggedUser;
            //Descobrir Id
            await Cconsultar.consulta_utilizadores();
            foreach (var pesquisa in Cconsultar.listUtilizadores)
            {
                if (pesquisa.UtilizadorUsername == Cconsultar.loggedUser)
                {
                    Cconsultar.idLoggedUser = pesquisa.UtilizadorId;
                }
            }

            SqlConnection connection = new SqlConnection(connstring);

            //Adicionar grupos a ListBox
            Cconsultar.listPerfilGrupos = new List<string>();

            if (Cconsultar.listPerfilGrupos.Count == 0)
            {
                try
                {
                    await Cconsultar.consulta_utilizadoresGrupos();
                    foreach (var pesquisa in Cconsultar.listUtilizadoresGrupos)
                    {


                        if (pesquisa.utilizadorGrupoIdUtilizador == Cconsultar.idLoggedUser)
                        {
                            await Cconsultar.consulta_grupo();
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


        /// <summary>
        /// Chamar FpesquisarGrupoInfo
        /// </summary>
        private void lbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeSorteado = "";
            string texto = "";
            int idGrupo = 0;

            FpesquisarGrupoInfo grupoInfo = new FpesquisarGrupoInfo();

            //Encontrar id do grupo
            foreach(var grupo in Cconsultar.listGrupos)
            {
                if(grupo.GrupoNome == lbGrupos.GetItemText(lbGrupos.SelectedItem))
                {
                    idGrupo = grupo.GrupoId;
                }
            }

            //mostrar se existe algum utilizador sorteado
            foreach(var utigru in Cconsultar.listUtilizadoresGrupos)
            {
                if(utigru.utilizadorGrupoIdGrupo == idGrupo && utigru.utilizadorGrupoIdUtilizador == Cconsultar.idLoggedUser)
                {
                    foreach(var nome in Cconsultar.listUtilizadores)
                    {
                        if(nome.UtilizadorId == utigru.utilizadorGrupoIdUtilizadorSorteado)
                        {
                            nomeSorteado = nome.UtilizadorUsername;
                            texto = "Deverá presentear: ";
                        }
                    }
                }
            }

            grupoInfo.LnomeGrupo = lbGrupos.GetItemText(lbGrupos.SelectedItem);           
            grupoInfo.LutilizadorSorteado = nomeSorteado;
            grupoInfo.LutilizadorSorteadoTexto = texto;
            grupoInfo.Show();
        }
    }
}
