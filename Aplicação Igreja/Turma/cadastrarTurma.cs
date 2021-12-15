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
    public partial class cadastrarTurma : Form
    {
        public cadastrarTurma()
        {
            InitializeComponent();
        }
            
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
        public void cadastrar()
        {
            SqlCommand comando = new SqlCommand();
            SqlCommand comando2 = new SqlCommand();
            try
            {
                conexao.Open();


                comando.Connection = conexao;
                comando2.Connection = conexao;

                string format = "yyyy-MM-dd";

                comando.CommandText = "insert into turma (diaEncontro, formacao) " +
                    "values (@diaEncontro, @formacao); ";
                comando.Parameters.AddWithValue("@diaEncontro", diaEncontroCombo.Text);
                comando.Parameters.AddWithValue("@formacao", turmaCombo.Text);

                comando2.CommandText = "update turma set " +
                    "idCatequista= @idCatequista " +
                    " where id = (select max(id) from turma); ";

                comando2.Parameters.AddWithValue("@idCatequista",idTxt.Text);


                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();


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
        public void carregar()
        {

            string comando = "select c.id, c.nome, c.nascimento," +
                "	e.id, e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade," +
                "	i.id, i.telefone, i.celular " +
                "   from catequista as c " +
                "    inner join endereco as e on(c.idEndereco = e.id)" +
                "    inner join contato as i on(c.idContato = i.id)" +
                " where  c.ativo <> 'Inativo' ; ";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                catequistaData.DataSource = tabela;

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
        public void carregaCampos()
        {
            idTxt.Text = catequistaData.CurrentRow.Cells[0].Value.ToString();
            catequistaTxt.Text = catequistaData.CurrentRow.Cells[1].Value.ToString();
        }

        private void cadastrarTurma_Load(object sender, EventArgs e)
        {
            carregar();
        }

        private void catequistaData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carregaCampos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turmaCombo.Text == "")
            {
                MessageBox.Show("Escolha algum tipo de turma.");
            }
            else if (diaEncontroCombo.Text == "")
            {
                MessageBox.Show("Escolha algum dia de encontro.");
            }
            else if (catequistaTxt.Text == "")
            {
                MessageBox.Show("Escolha algum catequista.");
            }
            else
            {
                cadastrar();
            }
        }
    }
}
