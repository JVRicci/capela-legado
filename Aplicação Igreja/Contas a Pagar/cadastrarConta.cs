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

namespace Aplicação_Igreja.Contas_a_Pagar
{
    public partial class cadastrarConta : Form
    {
        public string responsavel { get; set; }
        public cadastrarConta()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");

        public static void Moeda(ref TextBox txt)
        {
            string n = "";
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;


            }
            catch (Exception)
            {

            }
        }
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

                comando.CommandText = "insert into contas (descricao, valor, categoria, fornecedor, vencimento, pagamento, responsavel, cadastrante, estado, idAuxiliar) " +
                    "values (@descricao, @valor, @categoria, @fornecedor, @vencimento, @pagamento, @responsavel, @cadastrante, @estado, @idAuxiliar); ";
                comando.Parameters.AddWithValue("@descricao", descricaoTxt.Text);
                comando.Parameters.AddWithValue("@valor",Convert.ToDecimal( valorTextBox.Text));
                comando.Parameters.AddWithValue("@categoria", categoriaCombo.Text);
                comando.Parameters.AddWithValue("@fornecedor", fornecedorTxt.Text);
                comando.Parameters.AddWithValue("@vencimento", dataVencimento.Text);
                comando.Parameters.AddWithValue("@pagamento", dataPagamento.Text);
                comando.Parameters.AddWithValue("@responsavel", responsavelTxt.Text);
                comando.Parameters.AddWithValue("@cadastrante", cadastranteTxt.Text);
                comando.Parameters.AddWithValue("@estado", estadoCombo.Text);
                comando.Parameters.AddWithValue("@idAuxiliar", idTxt.Text);


                comando2.CommandText = "update turma set " +
                    "idCatequista= @idCatequista " +
                    " where id = (select max(id) from turma); ";

                comando2.Parameters.AddWithValue("@idCatequista", idTxt.Text);


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
            SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");

            string comando = "select id, nome, funcao, ativo from usuario; ";


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

        private void cadastrarConta_Load(object sender, EventArgs e)
        {
            carregar();
            cadastranteTxt.Text = responsavel;
        }

        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref valorTextBox);
        }

        private void userData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTxt.Text = userData.CurrentRow.Cells[1].Value.ToString();
                responsavelTxt.Text = userData.CurrentRow.Cells[2].Value.ToString();
            }
            catch(Exception erro) { }
        }

        private void dateTimePicker1_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void dataRecebimento_Leave(object sender, EventArgs e)
        {
            if (dataPagamento.Value > dataVencimento.Value)
            {
                MessageBox.Show("Data de recebimento inválida");
                dataPagamento.Value = DateTime.Today;
            }
        }

        private void dataVencimento_Leave(object sender, EventArgs e)
        {
            if (dataPagamento.Value > dataVencimento.Value)
            {
                MessageBox.Show("Data de Vencimento inválida");
                dataVencimento.Value = DateTime.Today;
            }
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            if (descricaoTxt.Text == "")
            {
                MessageBox.Show("Preencha o campo de descrição.");
            }
            else if (valorTextBox.Text == "")
            {
                MessageBox.Show("Preencha o campo do valor.");
            }
            else if (categoriaCombo.Text == "")
            {
                MessageBox.Show("Escolha uma catrgoria.");
            }
            else if (fornecedorTxt.Text == "")
            {

                MessageBox.Show("Preencha o campo de Fornecedor.");
            }
            else if (estadoCombo.Text == "")
            {
                MessageBox.Show("Selecione um estado de pagamento valido");
            }
            else if (responsavelTxt.Text == "")
            {

                MessageBox.Show("Selecione alguem responsável.");
            }
            else if (pagamentoCombo.Text == "")
            {
                MessageBox.Show("Selecione uma forma de Pagamento.");
            }
            else
            {
                cadastrar();
            }
        }

        private void valorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }

        }

        private void dataPagamento_ValueChanged(object sender, EventArgs e)
        {
            if (dataPagamento.Value > dataVencimento.Value)
            {
                MessageBox.Show("Escolha uma data válida");
            }
        }

        private void dataVencimento_ValueChanged(object sender, EventArgs e)
        {
            if (dataPagamento.Value > dataVencimento.Value)
            {
                MessageBox.Show("Escolha uma data válida");
            }
        }
    }
}
