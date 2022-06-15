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
    public partial class FpesquisarGrupoInfo : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        public int idGrupo { get; set; }
        public string statusGrupo { get; set; }

        public List<int> listUtilizadoresGrupo { get; set; }
        public List<string> listUtilizadoresNome { get; set; }
        static Random rnd = new Random();

        //labels que tem o valor do Fpesquisar
        public string LnomeGrupo
        {
            get { return lnomeGrupo.Text; }
            set { lnomeGrupo.Text = value; }
        }
        public string LutilizadorSorteado
        {
            get { return lUtilizadorSorteado.Text; }
            set { lUtilizadorSorteado.Text = value; }
        }
        public string LutilizadorSorteadoTexto
        {
            get { return lUtilizadorSorteadoTexto.Text; }
            set { lUtilizadorSorteadoTexto.Text = value; }
        }

        public bool status = true;

        public FpesquisarGrupoInfo()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Mostrar detalhes do grupo
        /// </summary>
        private async void FpesquisarGrupoInfo_Load(object sender, EventArgs e)
        {
            listUtilizadoresGrupo = new List<int>();
            listUtilizadoresNome = new List<string>();

            bParticipar.Show();
            await Cconsultar.consulta_grupo();

            lParticipantes.Visible = false;
            lbutilizadoresGrupos.Visible = false;
            

            //Adicionar valor ás labels
            foreach (var pesquisa in Cconsultar.listGrupos)
            {
                if (pesquisa.GrupoNome == lnomeGrupo.Text)
                {
                    ldescricao.Text = pesquisa.GrupoDescricao;
                    lstatus.Text = pesquisa.GrupoEstado;

                    //Para bParticipar_Click()
                    statusGrupo = pesquisa.GrupoEstado;
                    idGrupo = pesquisa.GrupoId;

                    //Buscar username utilizador lider
                    await Cconsultar.consulta_utilizadores();
                    foreach (var pesquisaUserLider in Cconsultar.listUtilizadores)
                    {
                        if (pesquisa.GrupoUtilizadorLider == pesquisaUserLider.UtilizadorId)
                        {
                            lLider.Text = pesquisaUserLider.UtilizadorUsername;
                        }
                    }

                }


                //Adicionar o botã0 de sortear caso o utilizador seja líder e mostar participantes
                if (pesquisa.GrupoId == idGrupo && pesquisa.GrupoUtilizadorLider == Cconsultar.idLoggedUser )
                {
                    if(pesquisa.GrupoEstado != "sorteado")
                    {
                        Button sortear = new Button();

                        sortear.Name = "llSortear";
                        sortear.Text = "Sortear";
                        sortear.Click += Sortear_Click;
                        sortear.Visible = true;
                        sortear.Location = new Point(302, 280);

                        this.Controls.Add(sortear);
                        sortear.BringToFront();
                    }
                    

                    //mostrar os participantes
                    lParticipantes.Visible = true;
                    lbutilizadoresGrupos.Visible = true;
                }
            }

            //Adicionar os utilizadores do grupo selecionado a uma lista
            foreach (var utigru in Cconsultar.listUtilizadoresGrupos)
            {
                if (utigru.utilizadorGrupoIdGrupo == idGrupo)
                {
                    listUtilizadoresGrupo.Add(utigru.utilizadorGrupoIdUtilizador);

                }
                if (utigru.utilizadorGrupoIdUtilizadorSorteado < 0)
                {
                    status = false;
                }

            }

            //Adicionar nome a lista de utilizadores por grupo
            foreach (var uti in Cconsultar.listUtilizadores)
            {
                foreach (var idUti in listUtilizadoresGrupo)
                {
                    if (uti.UtilizadorId == idUti)
                    {
                        listUtilizadoresNome.Add(uti.UtilizadorUsername);
                    }
                }
            }

            //Adicionar nomes à listBox
            lbutilizadoresGrupos.DataSource = listUtilizadoresNome;

            //botão de participar
            foreach (var utigru in Cconsultar.listUtilizadoresGrupos)
            {
                if(utigru.utilizadorGrupoIdUtilizador == Cconsultar.idLoggedUser && utigru.utilizadorGrupoIdGrupo == idGrupo)
                {
                    bParticipar.Hide();
                }
            }
        }


        /// <summary>
        /// Botão para sortear
        /// </summary>
        public void Sortear_Click(object sender, EventArgs e)
        {
           
            int idSorteado;

            if (status == true)
            {
                var shuffled = listUtilizadoresGrupo.OrderBy(_ => rnd.Next()).ToList();

                for (int i = 0; i < shuffled.Count(); i++)
                {
                    if (i == shuffled.Count() - 1)
                    {
                        idSorteado = shuffled[0];
                    }
                    else
                    {
                        idSorteado = shuffled[i + 1];
                    }

                    try
                    {

                        SqlConnection connection = new SqlConnection(connstring);
                        connection.Open();

                        //Update no utilizador sorteado
                        SqlCommand update = connection.CreateCommand();
                        update.CommandType = CommandType.Text;
                        update.CommandText = @"update utilizadoresGrupos set id_utilizadorSorteado = @sorteado 
                                        where id_utilizador = @user and id_grupo = @grupo";
                        update.Parameters.Add("@sorteado", SqlDbType.Int).Value = idSorteado;
                        update.Parameters.Add("@user", SqlDbType.Int).Value = shuffled[i];
                        update.Parameters.Add("@grupo", SqlDbType.Int).Value = idGrupo;
                        update.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }


                //Update no estado do grupo
                try
                {

                    SqlConnection connection = new SqlConnection(connstring);
                    connection.Open();

                    //Update no utilizador sorteado
                    SqlCommand update = connection.CreateCommand();
                    update.CommandType = CommandType.Text;
                    update.CommandText = @"update Grupos set estado = @estado 
                                        where id = @grupo ";
                    update.Parameters.Add("@estado", SqlDbType.VarChar).Value = "sorteado";
                    update.Parameters.Add("@grupo", SqlDbType.Int).Value = idGrupo;
                    update.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Grupo sorteado!! recarregue a página ver quem deverá presentear :)");
                this.Close();
            }

        }


        /// <summary>
        /// Adicionar participante ao grupo
        /// </summary>
        public async void bParticipar_Click(object sender, EventArgs e)
        {
            bool podeEntrar = true;
            SqlConnection connection = new SqlConnection(connstring);

            //Verificar se está aberto
            if (statusGrupo == "aberto")
            {
                await Cconsultar.consulta_utilizadoresGrupos();
                foreach (var pesquisa in Cconsultar.listUtilizadoresGrupos)
                {

                    if (pesquisa.utilizadorGrupoIdGrupo == idGrupo && pesquisa.utilizadorGrupoIdUtilizador == Cconsultar.idLoggedUser)
                    {

                        podeEntrar = false;
                        string texto = "Já se encontra neste grupo, por favor selecione outro para participar";
                        MessageBox.Show(texto);
                        break;
                    }
                }
                //Verificar se já está no grupo
                if (podeEntrar == true)
                {
                    connection.Open();
                    SqlCommand utigru = connection.CreateCommand();
                    utigru.CommandType = CommandType.Text;
                    utigru.CommandText = @"insert into utilizadoresGrupos
                                        (id_grupo, id_utilizador)
                                        values (@id_grupo, @id_utilizador)";
                    utigru.Parameters.Add("@id_grupo", SqlDbType.Int).Value = idGrupo;
                    utigru.Parameters.Add("@id_utilizador", SqlDbType.Int).Value = Cconsultar.idLoggedUser;
                    utigru.ExecuteReader();
                    MessageBox.Show("Adicionado ao grupo com sucesso!!");
                }

            }
            else
            {
                string texto = "Este grupo já foi sorteado, por favor selecione outro para participar";
                MessageBox.Show(texto);
            }
            this.Close();

        }
    }
}
