using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI1620M_GiuliaTorres_2220119_PROJETO
{
    internal class Produtos
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public int ProdutoIdVendedor { get; set; }
        public string ProdutoDescricao { get; set; }
        public float ProdutoValor { get; set; }
    }
}
