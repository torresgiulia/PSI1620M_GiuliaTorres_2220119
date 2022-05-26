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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }




        private void LinkSignIn(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }


        /// <summary>
        /// verificar o utilizador e passe
        /// </summary>
        private void bEntrar_Click(object sender, EventArgs e)
        {
            string passe = "";

            Consultar.consulta_utilizadores();
            

            //Guardar os valores inseridos
            foreach(var pesquisa in Consultar.listUtilizadores)
            {
                if ((pesquisa.UtilizadorEmail == tbUtilizador.Text && pesquisa.UtilizadorPassword == tbPassword.Text) || (pesquisa.UtilizadorUsername == tbUtilizador.Text && pesquisa.UtilizadorPassword == tbPassword.Text))
                {
                    Consultar.loggedUser = pesquisa.UtilizadorUsername;
                    passe = pesquisa.UtilizadorPassword;
                }
            }


            //Comparar os valores guardados
            if (passe!="")
            {
                Home home = new Home();
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
