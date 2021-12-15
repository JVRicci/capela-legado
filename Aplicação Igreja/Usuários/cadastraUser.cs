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

namespace Aplicação_Igreja.Usuários
{
    public partial class cadastraUser : Form
    {
        public cadastraUser()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");

        public void pesquisa()
        {
            SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
            SqlDataReader leitor;
            try
            {

                conexao.Open();

                SqlCommand comando = new SqlCommand("select * from usuario as c join login as l on c.idlogin = l.id where l.login=@login ", conexao);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                comando.Parameters.AddWithValue("@login", loginTextBox.Text);
                comando.Parameters.AddWithValue("@senha", senhaTextBox.Text);

                leitor = comando.ExecuteReader();

                if (leitor.HasRows)
                {
                        MessageBox.Show("Login já registrado anteriormente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Close();
                }

                else
                {
                    cadastro();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }


        public void cadastro()
        {

            SqlCommand comando = new SqlCommand();
            SqlCommand comando2 = new SqlCommand();
            SqlCommand comando3 = new SqlCommand();

            try
            {
                conexao.Open();


                comando.Connection = conexao;
                comando2.Connection = conexao;
                comando3.Connection = conexao;


                comando.CommandText = "insert into usuario (nome, sexo, funcao,  ativo) " +
                    "values (@nome, @sexo, @funcao,  @ativo); ";

                comando.Parameters.AddWithValue("@nome", nomeTxt.Text);
                comando.Parameters.AddWithValue("@sexo", sexoCombo.Text);
                comando.Parameters.AddWithValue("@funcao", funcaoCombo.Text);
                comando.Parameters.AddWithValue("@ativo", ativoCombo.Text);

                comando2.CommandText = "insert into login (login, senha) " +
                    "values (@login, @senha); ";
                comando2.Parameters.AddWithValue("@login", loginTextBox.Text);
                comando2.Parameters.AddWithValue("@senha", senhaTextBox.Text);

                comando3.CommandText = "update usuario set idlogin = (select max(id) from login) where" +
                    " id = (select max(id) from usuario);";

                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
                comando3.ExecuteNonQuery();

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

        private void cadastraUser_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nomeTxt.Text == "")
            {
                MessageBox.Show("Digite um nome");
            }
            else if(loginTextBox.Text == "")
            {
                MessageBox.Show("Digite um login");
            }
            else if(senhaTextBox.Text == "")
            {
                MessageBox.Show("Digite uma senha");
            }
            else if (sexoCombo.Text == "")
            {
                MessageBox.Show("Escolha um sexo");
            }
            if(ativoCombo.Text == "")
            {
                MessageBox.Show("Digite uma situação");
            }
            else
            {
                pesquisa();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nomeTxt.Clear();
            loginTextBox.Clear();
            senhaTextBox.Clear();
            funcaoCombo.Text = "";
            sexoCombo.Text = "";
            ativoCombo.Text = "";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
