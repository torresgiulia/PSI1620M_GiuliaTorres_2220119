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
    public partial class SignIn : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["cnGifty"].ConnectionString;

        List<Concelhos> concelhos;

        BindingList<Concelhos> BListConcelhos;

        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connstring);

            // Ligação à base de dados para ligar com a comboBox Concelho (CBconcelho)
            context.People.Load();
            this.CBconcelho.DataSource = BListConcelhos = context.People.Local.ToBindingList();
            this.CBconcelho.DisplayMember = "nome";





            concelhos = new List<Concelhos>();
            BListConcelhos = new BindingList<Concelhos>()
            {
                from Concelhos
                select *
            };
            CBconcelho.DataSource = BListConcelhos;
            



            // SELECT * TABELA_CONCELHOS
            // FOR EACH ROW... READ

        }



    }
}
/*try
            {
                connection.Open();
                SqlCommand conc = connection.CreateCommand();
                conc.CommandText = "select * from Concelhos";
                connection.Open();

                var ler = conc.ExecuteReader();
                if(ler.HasRows)
                {
                    while(ler.Read())
                    {
                        Concelhos concelho = new Concelhos()
                        {
                            ConcelhoId = Convert.ToInt32(ler["id"].ToString()),
                            ConcelhoNome = ler["nome"].ToString()
                        };
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }*/