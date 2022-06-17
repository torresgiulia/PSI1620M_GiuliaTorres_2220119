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
    public partial class Fperfil : Form
    {
        public Fperfil()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Redireciona para a Página de mostrar Preferencias
        /// </summary>
        private void bPreferencias_Click(object sender, EventArgs e)
        {
            FperfilPreferenciasMostrar preferencias = new FperfilPreferenciasMostrar();
            preferencias.Show();
            this.Hide();
        }


        /// <summary>
        /// Redireciona para a Página de Configuração de perfil
        /// </summary>
        private void bPerfil_Click(object sender, EventArgs e)
        {
            FperfilConfiguracoes perfil = new FperfilConfiguracoes();
            perfil.Show();
            this.Hide();
        }
    }
}
