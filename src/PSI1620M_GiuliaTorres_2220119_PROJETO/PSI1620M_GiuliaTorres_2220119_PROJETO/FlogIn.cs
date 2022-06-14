using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    public partial class FlogIn : Form
    {
        public FlogIn()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Ir para SignIn
        /// </summary>
        private void LinkSignIn(object sender, EventArgs e)
        {
            FsignIn signIn = new FsignIn();
            signIn.Show();
            this.Hide();
        }


        /// <summary>
        /// verificar o utilizador e passe
        /// </summary>
        private async  void bEntrar_Click(object sender, EventArgs e)
        {
            string passe = "";

            await Cconsultar.consulta_utilizadores();
            

            //Guardar os valores inseridos
            foreach(var pesquisa in Cconsultar.listUtilizadores)
            {
                if ((pesquisa.UtilizadorEmail == tbUtilizador.Text && pesquisa.UtilizadorPassword == tbPassword.Text) || (pesquisa.UtilizadorUsername == tbUtilizador.Text && pesquisa.UtilizadorPassword == tbPassword.Text))
                {
                    Cconsultar.loggedUser = pesquisa.UtilizadorUsername;
                    passe = pesquisa.UtilizadorPassword;
                }
            }


            //Comparar os valores guardados
            if (passe!="")
            {
                Fhome home = new Fhome();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Credenciais inválidas");
                tbPassword.Clear();
                tbUtilizador.Clear();

            }
        }
    }

    
}
