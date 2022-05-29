﻿using Microsoft.Data.SqlClient;
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
    public partial class FnovoGrupo : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        public int adicionarId { get; set; }

        public FnovoGrupo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adicionar um Grupo a abse de dados
        /// </summary>
        public void bCriarGrupo_Click(object sender, EventArgs e)
        {

            //adicionar ao grupo
            try
            {
                SqlConnection connection = new SqlConnection(connstring);

                connection.Open();

                SqlCommand criar = connection.CreateCommand();
                criar.CommandType = CommandType.Text;
                criar.CommandText = @"insert into Grupos 
                                        (nome, estado, username_utilizador_lider, descricao)
                                        values (@nome, @estado, @username, @descricao)";
                criar.Parameters.Add("@nome", SqlDbType.VarChar).Value = tbNomeGrupo.Text;
                criar.Parameters.Add("@estado", SqlDbType.VarChar).Value = "aberto";
                criar.Parameters.Add("@username", SqlDbType.VarChar).Value = Cconsultar.loggedUser;
                criar.Parameters.Add("@descricao", SqlDbType.VarChar).Value = tbDescricao.Text;
                criar.ExecuteReader();
            }
            catch(Exception)
            {
                throw;
            }


            // Procurar id do grupo
            Cconsultar.consulta_grupo();
            foreach (var pesquisa in Cconsultar.listGrupos)
            {
                if (pesquisa.GrupoNome == tbNomeGrupo.Text)
                {
                    adicionarId = pesquisa.GrupoId;
                    break;
                }
            }



            //adicionar o utilizador ao grupo
            try
            {
                SqlConnection connection = new SqlConnection(connstring);

                connection.Open();

                SqlCommand criar = connection.CreateCommand();
                criar.CommandType = CommandType.Text;
                criar.CommandText = @"insert into utilizadoresGrupos 
                                        (id_grupo, username_utilizador, username_utilizadorSorteado)
                                        values (@id_grupo, @username_utilizador, @username_utilizadorSorteado)";
                criar.Parameters.Add("@id_grupo", SqlDbType.Int).Value = adicionarId;
                criar.Parameters.Add("@username_utilizador", SqlDbType.VarChar).Value = Cconsultar.loggedUser;

                //COMO ADICIONAR UM VALOR NULO?
                criar.Parameters.Add("@username_utilizadorSorteado", SqlDbType.VarChar).Value = "NULL"; 
                criar.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }





            this.Close();

        }
    }
}