﻿using System;
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
    public partial class FperfilAlterarCampo : Form
    {
        public FperfilAlterarCampo()
        {
            InitializeComponent();
        }

        private void FalterarPerfil_Load(object sender, EventArgs e)
        {
            label1.Text = Cconsultar.labelText;
        }

        //adicionar valores aos parametros 
        private void bSubmeter_Click(object sender, EventArgs e)
        {
            Cconsultar.textBoxText = tbAlteracao.Text;
            this.Close();
        }
    }
}
