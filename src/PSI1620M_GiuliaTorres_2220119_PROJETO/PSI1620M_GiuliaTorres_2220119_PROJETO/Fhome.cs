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
    public partial class Fhome : Form
    {
        public Fhome()
        {
            InitializeComponent();
            lnome.Text = Cconsultar.loggedUser;
        }
    
        /// <summary>
        /// Guiar para o Novo Grupo
        /// </summary>
        private void bNovoGrupo_Click(object sender, EventArgs e)
        {
            FnovoGrupo novoGrupo = new FnovoGrupo();
            novoGrupo.Show();
        }
    }
}
