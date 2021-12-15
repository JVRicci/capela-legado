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

namespace Aplicação_Igreja.Catequista
{
    public partial class cadastroCatequista : Form
    {
        public cadastroCatequista()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
        public void pesquisar()
        {
            SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
            SqlDataReader leitor;
            try
            {

                conexao.Open();

                SqlCommand comando = new SqlCommand("select nome from catequista where nome = '"+nomeTxt.Text+"'; ", conexao);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                leitor = comando.ExecuteReader();

                if (leitor.HasRows)
                {
                    MessageBox.Show("Catequista já registrado");
                       

                    conexao.Close();
                }
                else
                {
                    cadastrar();
                    conexao.Close();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }
        public void cadastrar()
        {
            SqlCommand comando = new SqlCommand();
            SqlCommand comando2 = new SqlCommand();
            SqlCommand comando3 = new SqlCommand();
            SqlCommand comando4 = new SqlCommand();
            SqlCommand comando5 = new SqlCommand();
            try
            {
                conexao.Open();


                comando.Connection = conexao;
                comando2.Connection = conexao;
                comando3.Connection = conexao;
                comando4.Connection = conexao;

                comando.CommandText = "insert into catequista (nome, nascimento, ativo) " +
                    "values (@nome, @nascimento, 'Ativo'); ";

                comando.Parameters.AddWithValue("@nome", nomeTxt.Text);
                comando.Parameters.AddWithValue("@nascimento", marcaDataBox.Value.ToString());

                comando2.CommandText = " insert into endereco (logradouro, numero, bairro, cep, uf, cidade)" +
                    "values (@logradouro, @numero, @bairro, @cep, @uf, @cidade);";

                comando2.Parameters.AddWithValue("@logradouro", enderecoTextBox.Text);
                comando2.Parameters.AddWithValue("@numero", numeroTxt.Text);
                comando2.Parameters.AddWithValue("@bairro", bairroTxt.Text);
                comando2.Parameters.AddWithValue("@cep", cepTxt.Text);
                comando2.Parameters.AddWithValue("@uf", ufCombo.Text);
                comando2.Parameters.AddWithValue("@cidade", cidadeTxt.Text);

                comando3.CommandText = "insert into contato (telefone, celular)" +
                    "values (@telefone, @celular);";

                comando3.Parameters.AddWithValue("@telefone", telefoneTxt.Text);
                comando3.Parameters.AddWithValue("@celular", celularTxt.Text);

                comando4.CommandText = "update catequista set " +
                    "idendereco = (select max(id) from endereco), " +
                    "idcontato = (select max(id) from contato) " +
                    " where id = (select max(id) from catequista); ";

                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
                comando3.ExecuteNonQuery();
                comando4.ExecuteNonQuery();


                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomeTxt.Text == "")
                {
                    MessageBox.Show("Digite um nome.");
                }
                else if (enderecoTextBox.Text == "")
                {
                    MessageBox.Show("Digite um logradouro");
                }
                else if (numeroTxt.Text == "")
                {
                    MessageBox.Show("Digite um numero de rua");
                }
                else if (cidadeTxt.Text == "")
                {
                    MessageBox.Show("Digite uma cidade");
                }
                else if (bairroTxt.Text == "")
                {
                    MessageBox.Show("Digite um bairro");
                }

                else if (ufCombo.Text == "")
                {
                    MessageBox.Show("Digite um Estado (UF)");
                }


                else
                    pesquisar();
            }
            catch(Exception erro){

            }
        }

        private void cadastroCatequista_Load(object sender, EventArgs e)
        {

        }

        private void marcaDataBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
