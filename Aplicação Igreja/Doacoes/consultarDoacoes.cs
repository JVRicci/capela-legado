using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplicação_Igreja.Doacoes
{
    public partial class consultarDoacoes : Form
    {
        public consultarDoacoes()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
        public void pesquisarDoador()
        {
            SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
            SqlDataReader leitor;
            try
            {

                conexao.Open();

                SqlCommand comando = new SqlCommand("select nome from doador where nome = '" +doadorTxt.Text + "'; ", conexao);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                leitor = comando.ExecuteReader();

                if (leitor.HasRows)
                {
                    MessageBox.Show("Doador já registrado");


                    conexao.Close();
                }
                else
                {
                    cadastrarDoador();
                    conexao.Close();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }
        public void carregar()
        {

            string comando = "select id, nome from doador ;";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                doadorData.DataSource = tabela;
                conexao.Close();

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
        public void pesquisar()
        {

            string comando = "select id, nome from doador where nome like '%"+pesquisaTxt.Text+"%';";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                doadorData.DataSource = tabela;
                conexao.Close();

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
        public void carregarTodasDoacoes()
        {

            string comando = "select id, descricao, destino, dataReceb from doacao ;";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                doacaoData.DataSource = tabela;
                conexao.Close();

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
        public void atualizarDoador()
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

                comando.CommandText = "update doador set nome=@nome where id = @id";

                comando.Parameters.AddWithValue("@nome", doadorTxt.Text);
                comando.Parameters.AddWithValue("@id", idTxt.Text);

                comando.ExecuteNonQuery();

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

        public void deletarDoador()
        {
            if (MessageBox.Show("Deseja mesmo excluir registros?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                        try
                        {
                            conexao.Open();
                            SqlCommand comando = new SqlCommand();
                            SqlCommand comando2 = new SqlCommand();

                            comando.Connection = conexao;
                            comando2.Connection = conexao;

                            comando.CommandText = "Delete from doador where id = " + doadorData.CurrentRow.Cells[0].Value.ToString() + ";";
                            comando2.CommandText = "Delete from doacao where idDoador = "+ doadorData.CurrentRow.Cells[0].Value.ToString()+";";

                            comando.ExecuteNonQuery();
                            comando2.ExecuteNonQuery();

                            MessageBox.Show("Registros excluidos com sucesso", "Excluir");
                            conexao.Close();
                            carregar();
                            carregarTodasDoacoes();
                        }
                        catch (Exception erro)
                        {
                        }
                        finally
                        {
                            if (conexao != null) conexao.Close();

                            carregar();
                        }
                    
                
            }
        }
        public void deletarDoacoes()
        {
            if (MessageBox.Show("Deseja mesmo excluir registros?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    try
                    {
                        conexao.Open();
                        SqlCommand comando = new SqlCommand();

                        comando.Connection = conexao;

                        comando.CommandText = "Delete from doacao where id = " + doacaoData.CurrentRow.Cells[0].Value.ToString() + ";";

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Registros excluidos com sucesso", "Excluir");
                        conexao.Close();

                        carregarTodasDoacoes();
                    conexao.Close();
                    }
                    catch (Exception erro)
                    {
                    }
                    finally
                    {
                        if (conexao != null) conexao.Close();

                    }
                

            }
        }

        public void carregaDoacao()
        {

            string comando = "select id, descricao, destino, dataReceb from doacao" +
                "  where idDoador = " + doadorData.CurrentRow.Cells[0].Value.ToString()+";";

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                doacaoData.DataSource = tabela;

            }
            catch (Exception e)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }

        }

        public void cadastrarDoador()
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                conexao.Open();

                comando.Connection = conexao;

                comando.CommandText = "insert into doador (nome) values (@nome); ";
                comando.Parameters.AddWithValue("@nome", doadorTxt.Text);


                comando.ExecuteNonQuery();


                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Close();
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

        private void consultarDoacoes_Load(object sender, EventArgs e)
        {
            carregar();
            carregarTodasDoacoes();
        }

        public void carregaCampos()
        {

            idTxt.Text = doadorData.CurrentRow.Cells[0].Value.ToString();
            doadorTxt.Text = doadorData.CurrentRow.Cells[1].Value.ToString();

        }
        private void doadorData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            registrarDizimo.Enabled = true;
            atualizaButton.Enabled = true;
            carregaCampos();
            carregaDoacao();
        }

        private void registrarDizimo_Click(object sender, EventArgs e)
        {
            cadastroDoacao obj = new cadastroDoacao();
            obj.idDoador = doadorData.CurrentRow.Cells[0].Value.ToString();
            obj.nome = doadorData.CurrentRow.Cells[1].Value.ToString();
            obj.operacao = "doacao";
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            pesquisarDoador();
            carregar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastrarDoador();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            carregar();
            carregarTodasDoacoes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deletarDoador();
        }

        private void atualizaButton_Click(object sender, EventArgs e)
        {
            if (doadorTxt.Text == "")
            {
                MessageBox.Show("Digite um nome");
            }
            else
            {
                atualizarDoador();
            }
            carregar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deletarDoacoes();
        }

        private void entregueButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            visualizarRelatorioDoacao obj = new visualizarRelatorioDoacao();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            visualizarRelatorioDoacao obj = new visualizarRelatorioDoacao();
            obj.Show();
        }
    }
}
