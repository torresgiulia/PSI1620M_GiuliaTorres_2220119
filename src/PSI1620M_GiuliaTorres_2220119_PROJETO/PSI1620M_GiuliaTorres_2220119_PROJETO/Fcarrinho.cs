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
    public partial class Fcarrinho : Form
    {
        public Fcarrinho()
        {
            InitializeComponent();
        }

        private void Fcarrinho_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            UcFiltrosProdutos sideBar = new UcFiltrosProdutos();
            sideBar.Dock = DockStyle.Fill;
            this.Controls.Add(sideBar);
        }
    }
}
