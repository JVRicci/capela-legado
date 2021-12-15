using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação_Igreja.Dizimistas
{
    public partial class Cadastro_Dizimista : Form
    {
        public Cadastro_Dizimista()
        {
            InitializeComponent();
        }
        
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");


        public void cadastro()
        {

            SqlCommand comando = new SqlCommand();
            SqlCommand comando2 = new SqlCommand();
            SqlCommand comando3 = new SqlCommand();
            SqlCommand comando4 = new SqlCommand();
            try
            {
                conexao.Open();


                comando.Connection = conexao;
                comando2.Connection = conexao;
                comando3.Connection = conexao;
                comando4.Connection = conexao;


                string format = "yyyy-MM-dd";

                comando.CommandText = "insert into dizimistas (nome, cpf, nascimento, casamento, estadoCivil, conjuge, nascConjuge) " +
                    "values (@nome , @cpf, @nascimento, @casamento, @estadoCivil, @conjuge, @nascConjuge); ";

                comando.Parameters.AddWithValue("@nome", nomeTxt.Text);
                comando.Parameters.AddWithValue("@cpf", cpfTxt.Text);
                comando.Parameters.AddWithValue("@nascimento", nascimentoTxt.Text);
                comando.Parameters.AddWithValue("@casamento", tipoCasaCombo.Text);
                comando.Parameters.AddWithValue("@estadoCivil",estadoCivilCombo.Text);
                comando.Parameters.AddWithValue("@conjuge", conjugeText.Text);
                comando.Parameters.AddWithValue("@nascConjuge", nascConjText.Text);
                comando.Parameters.AddWithValue("@ativo", "Ativo");


                comando2.CommandText = " insert into endereco (logradouro, numero, bairro, cep, uf, cidade)" +
                    "values (@logradouro, @numero, @bairro, @cep, @uf, @cidade);";

                comando2.Parameters.AddWithValue("@logradouro", enderecoTxt.Text) ;
                comando2.Parameters.AddWithValue("@numero",numeroTxt.Text);
                comando2.Parameters.AddWithValue("@bairro", bairroTxt.Text);
                comando2.Parameters.AddWithValue("@cep", cepTxt.Text);
                comando2.Parameters.AddWithValue("@uf", ufCombo.Text);
                comando2.Parameters.AddWithValue("@cidade", cidadeTxt.Text);

                comando3.CommandText = "insert into contato (telefone, celular)" +
                    "values (@telefone, @celular);";

                comando3.Parameters.AddWithValue("@telefone", telefoneTxt.Text);
                comando3.Parameters.AddWithValue("@celular", celularTxt.Text);

                comando4.CommandText = "update dizimistas set idendereco = (select max(id) from endereco), idcontato =" +
                    "(select max(id) from contato), Ativo = 'Ativo' where id = (select max(id) from dizimistas); ";

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
                if(conexao != null)
                {
                    conexao.Close();
                }
            }
        }


        private void Cadastro_Dizimista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nomeTxt.Text == "")
            {
                MessageBox.Show("Digite um nome.");
            }
            else if (cpfTxt.Text == "")
            {
                MessageBox.Show("Digite um CPF");
            }

            else if (estadoCivilCombo.Text == "")
            {
                MessageBox.Show("Escolha um estado Civil");
            }
            else if (tipoCasaCombo.Text == "")
            {
                MessageBox.Show("Escolha um Tipo de Casamento");
            }
            else if (conjugeText.Text == "")
            {
                MessageBox.Show("Digite um conjuge");
            }
            else if (enderecoTxt.Text == "")
            {
                MessageBox.Show("Digite um endereço");
            }
            else if (numeroTxt.Text == "")
            {
                MessageBox.Show("Digite um Numero de Casa");
            }

            else if (cidadeTxt.Text == "")
            {
                MessageBox.Show("Digite uma Cidade");
            }

            else if (bairroTxt.Text == "")
            {
                MessageBox.Show("Digite um bairro");
            }
            else if (ufCombo.Text == "")
            {
                MessageBox.Show("Escolha um estado");
            }
            else
            cadastro();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Cadastro_Dizimista_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
