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

namespace Aplicação_Igreja.Turma
{
    public partial class consultarTurmas : Form
    {
        public consultarTurmas()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");


        public void pesquisar()
        {

            string comando = "select t.id, t.diaEncontro, t.formacao," +
                "  c.id, c.nome" +
                "   from turma as t " +
                "    inner join catequista as c on(t.idCatequista = c.id)" +
                " where t.formacao like '%"+turmaCombo.Text+"%'; ";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                turmaData.DataSource = tabela;

            }
            catch (Exception e)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }


        }
        public void carregarTurma()
        {

            string comando = "select t.id, t.diaEncontro, t.formacao," +
                "  c.id, c.nome" +
                "   from turma as t " +
                "    inner join catequista as c on(t.idCatequista = c.id); ";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                turmaData.DataSource = tabela;

            }
            catch (Exception e)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }


        }

        public void carregaCatequisandos()
        {
            string comando = "select c.id, c.nome, c.nascimento, c.ativo, c.faltaEncontro, c.faltaMissa, " +
                "  r.id, r.telefone, r.celular " +
                "   from catequizando as c " +
                "    inner join contato as r on(c.idContato = r.id)" +
                "   where idTurma = "+ turmaData.CurrentRow.Cells[0].Value.ToString()+";" ;

            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                catequizandoData.DataSource = tabela;

            }
            catch (Exception e)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }


        }

        public void deletarTurma()
        {
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;

                comando.CommandText = "Delete from turma where id = " + turmaData.CurrentRow.Cells[0].Value.ToString() + ";";

                comando.ExecuteNonQuery();

                MessageBox.Show("Registros excluidos com sucesso", "Excluir");
                conexao.Close();

            }
            catch (Exception erro)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();

                carregarTurma();
            }
        }
        public void mudarSala()
        {
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;

                comando.CommandText = "update catequizando set idTurma = 0 where id = " + catequizandoData.CurrentRow.Cells[0].Value.ToString() + ";";

                comando.ExecuteNonQuery();

                MessageBox.Show("Registros excluidos com sucesso", "Excluir");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(Convert.ToString(erro));
            }
            finally
            {
                if (conexao != null) conexao.Close();

                carregarTurma();
            }
        }
    
        private void consultarTurmas_Load(object sender, EventArgs e)
        {
            carregarTurma();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadastrarTurma obj = new cadastrarTurma();
            obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            catequizandoTurma obj = new catequizandoTurma();
            obj.idTurma= turmaData.CurrentRow.Cells[0].Value.ToString();
            obj.turma= turmaData.CurrentRow.Cells[1].Value.ToString();
            obj.diaEncontro = turmaData.CurrentRow.Cells[2].Value.ToString();
            obj.Show();
        }

        private void turmaData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carregarTurma();
            carregaCatequisandos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir turma?","Excluir",MessageBoxButtons.YesNo)==DialogResult.Yes)
            deletarTurma();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mudarSala();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            registroDeFaltas obj = new registroDeFaltas();
            obj.idTurma = turmaData.CurrentRow.Cells[0].Value.ToString();
            obj.turma = turmaData.CurrentRow.Cells[1].Value.ToString();
            obj.diaEncontro = turmaData.CurrentRow.Cells[2].Value.ToString();
            obj.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                visualizaRelatorioTurma obj = new visualizaRelatorioTurma();
                obj.Show();
            }
            catch(Exception erro) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void turmaData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            carregaCatequisandos();
            resgistrarMembButton.Enabled = true;
            registroFaltas.Enabled = true;

        }
    }
}
