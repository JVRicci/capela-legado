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
    public partial class Cadastro_Catequista : Form
    {
        public Cadastro_Catequista()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");

        public void pesquisar()
        {

            string comando = "select c.id, c.nome, c.nascimento, c.ativo," +
                "	e.id, e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade," +
                "	i.id, i.telefone, i.celular " +
                "   from catequista as c " +
                "    inner join endereco as e on(c.idEndereco = e.id)" +
                "    inner join contato as i on(c.idContato = i.id)" +
                "   where nome like '%"+pesquisaTxt.Text+"%'; ";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                catequizandoData.DataSource = tabela;
                conexao.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }


        }
        public void carregar()
        {

            string comando = "select c.id, c.nome, c.nascimento, c.ativo," +
                "	e.id, e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade," +
                "	i.id, i.telefone, i.celular " +
                "   from catequista as c " +
                "    inner join endereco as e on(c.idEndereco = e.id)" +
                "    inner join contato as i on(c.idContato = i.id); ";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                catequizandoData.DataSource = tabela;
                conexao.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }


        }
        public void carregaCampos()
        {
            try
            {
                idTxt.Text = catequizandoData.CurrentRow.Cells[1].Value.ToString();
                nomeTxt.Text = catequizandoData.CurrentRow.Cells[2].Value.ToString();
                marcaDataBox.Value = Convert.ToDateTime(catequizandoData.CurrentRow.Cells[3].Value);
                ativoCombo.Text = catequizandoData.CurrentRow.Cells[4].Value.ToString();

                idEndTextBox.Text = catequizandoData.CurrentRow.Cells[5].Value.ToString();
                enderecoTextBox.Text = catequizandoData.CurrentRow.Cells[6].Value.ToString();
                numeroTxt.Text = catequizandoData.CurrentRow.Cells[7].Value.ToString();
                bairroTxt.Text = catequizandoData.CurrentRow.Cells[8].Value.ToString();
                cepTxt.Text = catequizandoData.CurrentRow.Cells[9].Value.ToString();
                ufCombo.Text = catequizandoData.CurrentRow.Cells[10].Value.ToString();
                cidadeTxt.Text = catequizandoData.CurrentRow.Cells[11].Value.ToString();

                idContatoText.Text = catequizandoData.CurrentRow.Cells[12].Value.ToString();
                telefoneTxt.Text = catequizandoData.CurrentRow.Cells[13].Value.ToString();
                celularTxt.Text = catequizandoData.CurrentRow.Cells[14].Value.ToString();
            }
            catch (Exception erro)
            {

            }
        }
        public void atualizarRegistro()
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

                comando.CommandText = "update catequista set nome=@nome , nascimento=@nascimento, ativo=@ativo where id = @id";

                comando.Parameters.AddWithValue("@nome", nomeTxt.Text);
                comando.Parameters.AddWithValue("@nascimento", marcaDataBox.Value.ToString());
                comando.Parameters.AddWithValue("@ativo", ativoCombo.Text);
                comando.Parameters.AddWithValue("@id", idTxt.Text);


                comando2.CommandText = "update endereco set logradouro = @logradouro, numero = @numero, bairro = @bairro, cep = @cep, " +
                    "cidade = @cidade, uf = @uf where id= @idEndereco;";

                comando2.Parameters.AddWithValue("@logradouro", enderecoTextBox.Text);
                comando2.Parameters.AddWithValue("@numero", numeroTxt.Text);
                comando2.Parameters.AddWithValue("@bairro", bairroTxt.Text);
                comando2.Parameters.AddWithValue("@cep", cepTxt.Text);
                comando2.Parameters.AddWithValue("@uf", ufCombo.Text);
                comando2.Parameters.AddWithValue("@cidade", cidadeTxt.Text);
                comando2.Parameters.AddWithValue("@idEndereco", idEndTextBox.Text);

                comando3.CommandText = "update contato set telefone = @telefone, celular = @celular where id = @idContato;";

                comando3.Parameters.AddWithValue("@telefone", telefoneTxt.Text);
                comando3.Parameters.AddWithValue("@celular", celularTxt.Text);
                comando3.Parameters.AddWithValue("@idContato", idContatoText.Text);

                               
                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
                comando3.ExecuteNonQuery();



                MessageBox.Show("Registro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregar();

                conexao.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
        }
        public void deletar()
        {
            if (MessageBox.Show("Deseja mesmo excluir registros?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    conexao.Open();
                    SqlCommand comando = new SqlCommand();
                    SqlCommand comando2 = new SqlCommand();
                    SqlCommand comando3 = new SqlCommand();

                    comando.Connection = conexao;
                    comando2.Connection = conexao;
                    comando3.Connection = conexao;

                    comando.CommandText = "Delete from catequista where id = " + idTxt.Text + ";";
                    comando2.CommandText = "Delete from endereco where id = " + idEndTextBox.Text + ";";
                    comando3.CommandText = "Delete from contato where id = " + idContatoText.Text + ";";

                    comando.ExecuteNonQuery();
                    comando2.ExecuteNonQuery();
                    comando3.ExecuteNonQuery();

                    MessageBox.Show("Registros excluidos com sucesso", "Excluir");

                }
                catch (Exception erro)
                {
                    MessageBox.Show(Convert.ToString(erro));
                }
                finally
                {
                    if (conexao != null) conexao.Close();

                    carregar();
                }
            }
        }
        private void Cadastro_Catequista_Load(object sender, EventArgs e)
        {
            carregar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastroCatequista obj = new cadastroCatequista();
            obj.Show();
        }

        private void catequizandoData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carregaCampos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            atualizarRegistro();
        }

        private void button7_Click_1(object sender, EventArgs e)
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
            atualizarRegistro();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carregar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deletar();
        }
    }
}
