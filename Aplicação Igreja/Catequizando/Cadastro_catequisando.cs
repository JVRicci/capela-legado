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

namespace Aplicação_Igreja.Catequisando
{
    public partial class Cadastro_catequisando : Form
    {
        public Cadastro_catequisando()
        {
            InitializeComponent();
        }

        SqlConnection conexao = classeConectora.conexao;
        public void pesquisa()
        {
            SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
            SqlDataReader leitor;
            try
            {

                conexao.Open();

                SqlCommand comando = new SqlCommand("select nome from catequizando where nome = '" + nomeTxt.Text + "'; ", conexao);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                leitor = comando.ExecuteReader();

                if (leitor.HasRows)
                {
                    MessageBox.Show("Catequizando já registrado");


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
                comando5.Connection = conexao;


                string format = "yyyy-MM-dd";

                comando.CommandText = "insert into catequizando (nome, nascimento, idTurma) " +
                    "values (@nome, @nascimento, 2); ";

                comando.Parameters.AddWithValue("@nome", nomeTxt.Text);
                comando.Parameters.AddWithValue("@nascimento", dataNascimentoTxt.Text);
                
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

                comando4.CommandText = "insert into responsavel (responsavel, nascRespon, estadoCivil, tipoCasamento, padrinho,  madrinha)" +
                    "values (@responsavel, @nascRespon, @estadoCivil, @tipoCasamento, @padrinho,  @madrinha)";

                comando4.Parameters.AddWithValue("@responsavel", responsavelTxt.Text);
                comando4.Parameters.AddWithValue("@nascRespon", nascResponsaTxt.Text);
                comando4.Parameters.AddWithValue("@estadoCivil", estadoCivilCombo.Text);
                comando4.Parameters.AddWithValue("@tipoCasamento", tipoCasaCombo.Text);
                comando4.Parameters.AddWithValue("@padrinho", padrinhoTxt.Text);
                comando4.Parameters.AddWithValue("@madrinha", madrinhaTxt.Text);

                comando5.CommandText = "update catequizando set " +
                    "idendereco = (select max(id) from endereco), " +
                    "idcontato = (select max(id) from contato), " +
                    "idResponsavel = (select max(id) from responsavel)," +
                    "idTurma = (select max(id) from turma)" +
                    " where id = (select max(id) from catequizando); ";

                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
                comando3.ExecuteNonQuery();
                comando4.ExecuteNonQuery();
                comando5.ExecuteNonQuery();


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
        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Cadastro_catequisando_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nomeTxt.Text == "")
            {
                MessageBox.Show("Digite um nome.");
            }
            else if (responsavelTxt.Text == "")
            {
                MessageBox.Show("Digite um responsavel.");
            }
            else if (padrinhoTxt.Text == "")
            {
                MessageBox.Show("Digite um padrinho");
            }
            else if (madrinhaTxt.Text == "")
            {
                MessageBox.Show("Digite uma madrinha");
            }
            else if (tipoCasaCombo.Text == "")
            {
                MessageBox.Show("Escolha um tipo de Casamento");
            }
            else if (estadoCivilCombo.Text == "") 
            {
                MessageBox.Show("Escolha um estado Civil");
            }
            else if(enderecoTextBox.Text=="")
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
            else if(bairroTxt.Text == "")
            {
                MessageBox.Show("Digite um bairro;");
            }
            else if(dataNascimentoTxt.Value < nascResponsaTxt.Value)
            {
                MessageBox.Show("Nascimento invalido");
            }
            else
            pesquisa();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_catequisando_FormClosing_1(object sender, FormClosingEventArgs e)
        {

        }

        private void dataNascimentoTxt_Leave(object sender, EventArgs e)
        {

        }

        private void nascResponsaTxt_Leave(object sender, EventArgs e)
        {
        }

        private void estadoCivilCombo_Leave(object sender, EventArgs e)
        {
        }

        private void estadoCivilCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(estadoCivilCombo.Text != "Solteiro")
            {
                tipoCasaCombo.Text = "Ambos";
            }
            if (estadoCivilCombo.Text == "Solteiro")
            {
                tipoCasaCombo.Text = "Nenhum";
            }
        }

        private void tipoCasaCombo_Leave(object sender, EventArgs e)
        {
        }

        private void tipoCasaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoCasaCombo.Text == "Nenhum")
            {
                estadoCivilCombo.Text = "Solteiro";
            }
        }

        private void dataNascimentoTxt_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nascResponsaTxt_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
