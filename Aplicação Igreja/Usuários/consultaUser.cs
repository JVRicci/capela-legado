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
    public partial class consultaUser : Form
    {
        public consultaUser()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
        public void carregaCampos()
        {
            try
            {

                idTxt.Text = userData.CurrentRow.Cells[1].Value.ToString();
                nomeTxt.Text = userData.CurrentRow.Cells[2].Value.ToString();
                sexoCombo.Text = userData.CurrentRow.Cells[3].Value.ToString();
                funcaoCombo.Text = userData.CurrentRow.Cells[4].Value.ToString();

                ativoCombo.Text = userData.CurrentRow.Cells[5].Value.ToString();
                idLogin.Text = userData.CurrentRow.Cells[6].Value.ToString();

                atualizaButton.Enabled = true;
            }
            catch(Exception e)
            {

            }

        }

        public void carregar()
        {

            string comando = "select id, nome, sexo, funcao, ativo, idlogin from usuario; ";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                userData.DataSource = tabela;

            }
            catch (Exception e)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }


        }
        public void pesquisas()
        {

            string comando = "select id, nome, sexo, funcao, ativo, idlogin from usuario where nome like '%"+pesquisaTxt.Text+"%'; ";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                userData.DataSource = tabela;

            }
            catch (Exception e)
            {
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }


        }
        public void atualizarRegistro()
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                conexao.Open();

                comando.Connection = conexao;
                comando.CommandText = "update usuario set nome=@nome, sexo=@sexo, funcao=@funcao, ativo=@ativo where id = @id";

                comando.Parameters.AddWithValue("@nome", nomeTxt.Text);
                comando.Parameters.AddWithValue("@sexo", sexoCombo.Text);
                comando.Parameters.AddWithValue("@funcao", funcaoCombo.Text);
                comando.Parameters.AddWithValue("@ativo", ativoCombo.Text);
                comando.Parameters.AddWithValue("@id", idTxt.Text);

                comando.ExecuteNonQuery();


                MessageBox.Show("Registro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregar();

                conexao.Close();
            }
            catch (Exception e)
            {
            }
        }

        public void deletar()
        {
            if (MessageBox.Show("Deseja mesmo excluir registros?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                 
                SqlCommand comando = new SqlCommand();
                SqlCommand comando2 = new SqlCommand();
                try
                {
                    conexao.Open();

                    comando.Connection = conexao;
                    comando2.Connection = conexao;

                    comando.CommandText = "Delete from usuario where id = " + idTxt.Text + ";";
                    comando2.CommandText = "Delete from login where id = " + idLogin.Text + ";";

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Registros excluidos com sucesso", "Excluir");

                    carregar();

                    conexao.Close();
                }
                catch (Exception e)
                {
                }
            }
        }
        private void consultaUser_Load(object sender, EventArgs e)
        {
            carregar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastraUser obj = new cadastraUser();
            obj.Show();
        }

        private void userData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaCampos();
        }

        private void atualizaButton_Click(object sender, EventArgs e)
        {
            atualizarRegistro();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(funcaoCombo.Text == "Administrador")
            {
                MessageBox.Show("Não é possivel exluir administradores");
            }
            else if (MessageBox.Show("Deseja mesmo excluir esse registro?", "Erro", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                deletar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carregar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisas();
        }
    }
}
