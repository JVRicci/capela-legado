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
    public partial class consulta_catequizando : Form
    {
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");

        public consulta_catequizando()
        {
            InitializeComponent();
        }
            public void pesquisar()
        {

            string comando = "select c.id, c.nome, c.nascimento, " +
                "  r.id, r.responsavel, r.nascRespon, r.estadoCivil, r.tipoCasamento, r.padrinho, r.madrinha," +
                "	e.id, e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade," +
                "	i.id, i.telefone, i.celular, c.idResponsavel " +
                "   from catequizando as c " +
                "    inner join responsavel as r on(c.idResponsavel = r.id)" +
                "    inner join endereco as e on(c.idEndereco = e.id)" +
                "    inner join contato as i on(c.idContato = i.id)" +
                "   where nome like '%" + pesquisaTxt.Text + "%'; ";


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

            string comando = "select c.id, c.nome, c.nascimento, " +
                "  r.id, r.responsavel, r.nascRespon, r.estadoCivil, r.tipoCasamento, r.padrinho, r.madrinha," +
                "	e.id, e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade," +
                "	i.id, i.telefone, i.celular, c.idResponsavel " +
                "   from catequizando as c " +
                "    inner join responsavel as r on(c.idResponsavel = r.id)" +
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
                            SqlCommand comando4 = new SqlCommand();

                            comando.Connection = conexao;
                            comando2.Connection = conexao;
                            comando3.Connection = conexao;
                            comando4.Connection = conexao;

                            comando.CommandText = "Delete from catequizando where id = " + idTxt.Text+ ";";
                            comando2.CommandText = "Delete from responsavel where id = " + idResponsa.Text + ";";
                            comando3.CommandText = "Delete from endereco where id = " + idEndTextBox.Text + ";";
                            comando4.CommandText = "Delete from contato where id = " + idContatoText.Text + ";";

                            comando.ExecuteNonQuery();
                            comando2.ExecuteNonQuery();
                            comando3.ExecuteNonQuery();
                            comando4.ExecuteNonQuery();

                            MessageBox.Show("Registros excluidos com sucesso", "Excluir");

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

        public void carregaCampos()
        {
            try
            {
                idTxt.Text = catequizandoData.CurrentRow.Cells[1].Value.ToString();
                nomeTxt.Text = catequizandoData.CurrentRow.Cells[2].Value.ToString();
                nascCateqTxt.Value = Convert.ToDateTime(catequizandoData.CurrentRow.Cells[3].Value);

                responsavelTxt.Text = catequizandoData.CurrentRow.Cells[5].Value.ToString();
                nascResponsaTxt.Text = catequizandoData.CurrentRow.Cells[6].Value.ToString();
                estadoCivilCombo.Text = catequizandoData.CurrentRow.Cells[7].Value.ToString();
                tipoCasaCombo.Text = catequizandoData.CurrentRow.Cells[8].Value.ToString();
                padrinhoTxt.Text = catequizandoData.CurrentRow.Cells[9].Value.ToString();
                madrinhaTxt.Text = catequizandoData.CurrentRow.Cells[10].Value.ToString();

                idEndTextBox.Text = catequizandoData.CurrentRow.Cells[11].Value.ToString();
                enderecoTextBox.Text = catequizandoData.CurrentRow.Cells[12].Value.ToString();
                numeroTxt.Text = catequizandoData.CurrentRow.Cells[13].Value.ToString();
                bairroTxt.Text = catequizandoData.CurrentRow.Cells[14].Value.ToString();
                cepTxt.Text = catequizandoData.CurrentRow.Cells[15].Value.ToString();
                ufCombo.Text = catequizandoData.CurrentRow.Cells[16].Value.ToString();
                cidadeTxt.Text = catequizandoData.CurrentRow.Cells[17].Value.ToString();

                idContatoText.Text = catequizandoData.CurrentRow.Cells[18].Value.ToString();
                telefoneTxt.Text = catequizandoData.CurrentRow.Cells[19].Value.ToString();
                celularTxt.Text = catequizandoData.CurrentRow.Cells[20].Value.ToString();

                idResponsa.Text = catequizandoData.CurrentRow.Cells[21].Value.ToString();
            }
            catch(Exception error) { }
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
                comando4.Connection = conexao;

                comando.CommandText = "update catequizando set nome=@nome , nascimento=@nascimento where id = @id";

                comando.Parameters.AddWithValue("@nome", nomeTxt.Text);
                comando.Parameters.AddWithValue("@nascimento", nascCateqTxt.Value.ToString());
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


                comando4.CommandText = "update responsavel set responsavel = @responsavel, nascRespon = @nascRespon, " +
                    "estadoCivil = @estadoCivil, tipoCasamento = @tipoCasamento, padrinho = @padrinho, madrinha = @madrinha where id=@id;";
                comando4.Parameters.AddWithValue("@responsavel", responsavelTxt.Text);
                comando4.Parameters.AddWithValue("@nascRespon", nascResponsaTxt.Value.ToString());
                comando4.Parameters.AddWithValue("@estadoCivil", estadoCivilCombo.Text);
                comando4.Parameters.AddWithValue("@tipoCasamento", tipoCasaCombo.Text);
                comando4.Parameters.AddWithValue("@padrinho", padrinhoTxt.Text);
                comando4.Parameters.AddWithValue("@madrinha", madrinhaTxt.Text);
                comando4.Parameters.AddWithValue("@id", idResponsa.Text);


                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
                comando3.ExecuteNonQuery();
                comando4.ExecuteNonQuery();



                MessageBox.Show("Registro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregar();

                conexao.Close();
            }
            catch (Exception e)
            {
            }
        }
        private void Consulta_catequizando_Load(object sender, EventArgs e)
        {
            carregar();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro_catequisando obj = new Cadastro_catequisando();
            obj.Show();
        }

        private void catequizandoData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carregaCampos();
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
                MessageBox.Show("Digite um bairro;");
            }
            else if (nascCateqTxt.Value < nascResponsaTxt.Value)
            {
                MessageBox.Show("Nascimento invalido");
            }
            else
                atualizarRegistro();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deletar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carregar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void estadoCivilCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (estadoCivilCombo.Text != "Solteiro")
            {
                tipoCasaCombo.Text = "Ambos";
            }
            if (estadoCivilCombo.Text == "Solteiro")
            {
                tipoCasaCombo.Text = "Nenhum";
            }
        }

        private void tipoCasaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tipoCasaCombo.Text == "Nenhum")
            {
                estadoCivilCombo.Text = "Solteiro";
            }
        }

        private void catequizandoData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
