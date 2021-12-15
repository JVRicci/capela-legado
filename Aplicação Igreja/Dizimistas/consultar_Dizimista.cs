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

namespace Aplicação_Igreja.Dizimistas
{
    public partial class consultar_dizimista : Form
    {
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");

        public consultar_dizimista()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro_Dizimista obj = new Cadastro_Dizimista();
            obj.Show();
        }
        public void pesquisar()
        {

            string comando = "select d.id, d.nome, d.cpf,  d.nascimento, d.casamento, d.estadoCivil, d.conjuge, d.nascConjuge, d.ativo, " +
                "e.id, e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade," +
                "c.id, c.telefone, c.celular " +
                "from dizimistas as d " +
                "inner join contato as c  on(d.idContato = c.id) " +
                "inner join endereco as e on(d.idEndereco = e.id)" +
                "where d.nome like '%"+pesquisaTxt.Text+"%';";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dizimistaData.DataSource = tabela;
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
        public void carregar()
        {
            
            string comando = "select d.id, d.nome, d.cpf,  d.nascimento, d.casamento, d.estadoCivil, d.conjuge, d.nascConjuge, d.ativo, " +
                "e.id, e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade," +
                "c.id, c.telefone, c.celular " +
                "from dizimistas as d " +
                "inner join contato as c  on(d.idContato = c.id) " +
                "inner join endereco as e on(d.idEndereco = e.id);";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dizimistaData.DataSource = tabela;
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
                for (int i = 0; i < dizimistaData.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dizimistaData.Rows[i].Cells[0].Value))
                    {
                        MessageBox.Show(Convert.ToString(dizimistaData.Rows[i].Cells[1].Value));
                        try
                        {
                            conexao.Open();
                            SqlCommand comando = new SqlCommand();
                            SqlCommand comando2 = new SqlCommand();
                            SqlCommand comando3 = new SqlCommand();

                            comando.Connection = conexao;
                            comando2.Connection = conexao;
                            comando3.Connection = conexao;

                            comando.CommandText = "Delete from dizimistas where id = " + dizimistaData.Rows[i].Cells[0].Value + ";";
                            comando2.CommandText = "Delete from endereco where id = " + dizimistaData.Rows[i].Cells[9].Value + ";";
                            comando3.CommandText = "Delete from contato where id = " + dizimistaData.Rows[i].Cells[16].Value + ";";

                            comando.ExecuteNonQuery();
                            comando2.ExecuteNonQuery();
                            comando3.ExecuteNonQuery();

                            MessageBox.Show("Registros excluidos com sucesso", "Excluir");
                            conexao.Close();

                            carregar();
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
            }
        }

        public void carregaDizimo()
        {
            
            string comando = "SELECT id, idDizimista, qtdRecebida, dataRecebimento" +
                " from dizimo where idDizimista = "+dizimistaData.CurrentRow.Cells[0].Value.ToString();

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                dizimoData.DataSource = tabela;

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
                idTxt.Text = dizimistaData.CurrentRow.Cells[0].Value.ToString();
                nomeTxt.Text = dizimistaData.CurrentRow.Cells[1].Value.ToString();
                cpfTxt.Text = dizimistaData.CurrentRow.Cells[2].Value.ToString();
                dataNascimentoTxt.Value = Convert.ToDateTime(dizimistaData.CurrentRow.Cells[3].Value);
                tipoCasaCombo.Text = dizimistaData.CurrentRow.Cells[4].Value.ToString();
                estadoCivilCombo.Text = dizimistaData.CurrentRow.Cells[5].Value.ToString();
                conjugeText.Text = dizimistaData.CurrentRow.Cells[6].Value.ToString();
                nascimentoTxt.Text = dizimistaData.CurrentRow.Cells[7].Value.ToString();
                ativoCombo.Text = dizimistaData.CurrentRow.Cells[8].Value.ToString();
                idEndTextBox.Text = dizimistaData.CurrentRow.Cells[9].Value.ToString();
                enderecoTextBox.Text = dizimistaData.CurrentRow.Cells[10].Value.ToString();
                numeroTxt.Text = dizimistaData.CurrentRow.Cells[11].Value.ToString();
                bairroTxt.Text = dizimistaData.CurrentRow.Cells[12].Value.ToString();
                cepTxt.Text = dizimistaData.CurrentRow.Cells[13].Value.ToString();
                ufCombo.Text = dizimistaData.CurrentRow.Cells[14].Value.ToString();
                cidadeTxt.Text = dizimistaData.CurrentRow.Cells[15].Value.ToString();
                idContatoText.Text = dizimistaData.CurrentRow.Cells[16].Value.ToString();
                telefoneTxt.Text = dizimistaData.CurrentRow.Cells[17].Value.ToString();
                celularTxt.Text = dizimistaData.CurrentRow.Cells[18].Value.ToString();
            }
            catch(Exception e)
            {
                
            }

        }
        public void atualizarRegistro()
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

                comando.CommandText = "update dizimistas set nome=@nome , cpf=@cpf, nascimento=@nascimento, casamento = @casamento, " +
                    "estadoCivil = @estadoCivil, conjuge = @conjuge, nascconjuge = @nascConjuge, ativo = @ativo where id = @id; ";

                comando.Parameters.AddWithValue("@nome", nomeTxt.Text);
                comando.Parameters.AddWithValue("@cpf", cpfTxt.Text);
                comando.Parameters.AddWithValue("@nascimento", nascimentoTxt.Text);
                comando.Parameters.AddWithValue("@casamento", tipoCasaCombo.Text);
                comando.Parameters.AddWithValue("@estadoCivil", estadoCivilCombo.Text);
                comando.Parameters.AddWithValue("@conjuge", conjugeText.Text);
                comando.Parameters.AddWithValue("@nascConjuge", nascimentoTxt.Text);
                comando.Parameters.AddWithValue("@ativo",ativoCombo.Text);
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
        }
        private void consultar_dizimista_Load(object sender, EventArgs e)
        {
            carregar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisar();
        }


        private void dizimoData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cadastroDizimo obj = new cadastroDizimo();

            obj.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deletar();
            carregaCampos();
        }


        private void dizimoData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dizimistaData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carregaDizimo();
            carregaCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro_Dizimista obj = new Cadastro_Dizimista();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
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
            else if (enderecoTextBox.Text == "")
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
                atualizarRegistro();
            carregaCampos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            carregar();
        }

        private void registrarDizimo_Click(object sender, EventArgs e)
        {
            cadastroDizimo obj = new cadastroDizimo();
            obj.idDizimista = idTxt.Text = dizimistaData.CurrentRow.Cells[0].Value.ToString();
            obj.nome = nomeTxt.Text = dizimistaData.CurrentRow.Cells[1].Value.ToString();
            obj.Show();
        }

        private void recarregarButton_Click(object sender, EventArgs e)
        {
            carregar();
        }

        private void relatorioButton_Click(object sender, EventArgs e)
        {
           visualizaRelatorioDizimo obj = new visualizaRelatorioDizimo();
           obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            nomeTxt.Text = "";
            cpfTxt.Text = "";
            estadoCivilCombo.Text = "";
            tipoCasaCombo.Text = "";
            conjugeText.Text = "";
            enderecoTextBox.Text = "";
            numeroTxt.Text = "";
            cidadeTxt.Text = "";
            bairroTxt.Text = "";
            ufCombo.Text = "";
            idTxt.Text = "";
            idEndTextBox.Text = "";
            idContatoText.Text = "";
        }
    }
}
