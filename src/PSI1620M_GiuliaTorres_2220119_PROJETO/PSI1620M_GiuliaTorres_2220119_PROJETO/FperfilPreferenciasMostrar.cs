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
    public partial class FperfilPreferenciasMostrar : Form
    {
        List<string> listutilizadorCategoria = new List<string>();


        public FperfilPreferenciasMostrar()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Adicionar valor a listBox (categorias de preferencia do utilizador)
        /// </summary>
        private async void FperfilPreferenciasMostrar_Load(object sender, EventArgs e)
        {

            await Cconsultar.consulta_categorias();
            await Cconsultar.consulta_utilizadoresCategorias();
            foreach(var categoria in Cconsultar.listCategorias)
            {
                foreach(var uticat in Cconsultar.listUtilizadoresCategorias)
                {
                    if(uticat.utilizadorCategoriaIdCategoria == categoria.CategoriaId && uticat.utilizadorCategoriaIdUtilizador == Cconsultar.idLoggedUser)
                    {
                        listutilizadorCategoria.Add(categoria.CategoriaNome);
                    }
                }
            }

            lbCategorias.DataSource = listutilizadorCategoria;



        }


        /// <summary>
        /// Voltar para o perfil
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fperfil perfil = new Fperfil();
            perfil.Show();
        }

        /// <summary>
        ///  Direcionar para alterar as preferencias
        /// </summary>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Fpreferences preferences = new Fpreferences();
            preferences.Show();
        }

        
    }
}
