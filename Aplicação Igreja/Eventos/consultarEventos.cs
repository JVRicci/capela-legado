using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação_Igreja.Eventos
{
    public partial class consultarEventos : Form
    {
        public consultarEventos()
        {
            InitializeComponent();
        }

        public string nomeUser { get; set; }

        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");

        public void carregar()
        {

           // string comando = "select id,nome, funcao from catequizando where idEvento = " + idEvento + "; ";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                //dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                equipeData.DataSource = tabela;

            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }


        }

        public void registrarEvento()
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                conexao.Open();



                MessageBox.Show(marcaDataBox.Text);
                comando.Connection = conexao;


                comando.CommandText = "insert into evento (descricao, dataEvento, responsavel) " +
                    "values (@descricao, @data, @responsavel); ";
                comando.Parameters.AddWithValue("@descricao", descricaoTxt.Text);
                comando.Parameters.AddWithValue("@data", marcaDataBox.Value.ToString());
                comando.Parameters.AddWithValue("@responsavel", nomeUser);

                comando.ExecuteNonQuery();


                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
            finally
            {
                conexao.Close();
            }
        }
        public void verificaEventos()
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                conexao.Open();


                MessageBox.Show(marcaDataBox.Text);
                comando.Connection = conexao;


                comando.CommandText = "select dataEvento from evento; ";

                SqlDataReader leitor = comando.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                       DateTime dataLeitor = Convert.ToDateTime(leitor.GetValue(0));
                        calendarioEventos.SelectionStart = dataLeitor;
                    }
                }
                leitor.Close();
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
            finally
            {
                conexao.Close();
            }
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            calendarioEventos.SelectionStart.ToString() ;
            verificaEventos();
        }

        private void consultarEventos_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registrarEvento();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
