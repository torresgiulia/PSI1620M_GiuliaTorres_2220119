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
    public partial class UcSair : UserControl
    {
        public UcSair()
        {
            InitializeComponent();
        }

        private void bSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
