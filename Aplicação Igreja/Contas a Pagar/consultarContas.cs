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
    public partial class consultarContas : Form
    {
        public consultarContas()
        {
            InitializeComponent();
        }
        public string nome { get; set; }
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
        
        public void atualizarRegistro()
        {
            SqlCommand comando = new SqlCommand();
            SqlCommand comando2 = new SqlCommand();
            SqlCommand comando3 = new SqlCommand();
            try
            {
                conexao.Open();


                comando.Connection = conexao;

                comando.CommandText = "update contas set descricao = @descricao, valor =@valor, categoria=@categoria," +
                    " fornecedor = @fornecedor, vencimento= @vencimento, pagamento=@pagamento, estado = @estado, " +
                    " recebimento = @recebimento, parcelas=@parcelas, forma=@forma" +
                    " where id = @id; ";

                comando.Parameters.AddWithValue("@descricao", descricaoTxt.Text);
                comando.Parameters.AddWithValue("@valor", Convert.ToDecimal(valorTextBox.Text));
                comando.Parameters.AddWithValue("@categoria", categoriaCombo.Text);
                comando.Parameters.AddWithValue("@fornecedor", fornecedorTxt.Text);
                comando.Parameters.AddWithValue("@vencimento", dataVencimento.Value.ToString());
                comando.Parameters.AddWithValue("@pagamento", dataPagamento.Value.ToString());
                comando.Parameters.AddWithValue("@estado", estadoCombo.Text);
                comando.Parameters.AddWithValue("@recebimento", parcelasRecebimento.Text);
                comando.Parameters.AddWithValue("@parcelas", totalParcelas.Text);
                comando.Parameters.AddWithValue("@forma", pagamentoCombo.Text);


                comando.Parameters.AddWithValue("@id", idTxt.Text);

                comando.ExecuteNonQuery();



                MessageBox.Show("Registro atualizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregar();

                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show (Convert.ToString(e));
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

                    comando.Connection = conexao;

                    comando.CommandText = "Delete from contas where id = " + idTxt.Text + ";";

                    comando.ExecuteNonQuery();

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
    
        public void carregaCampos()
        {
            try
            {
                idTxt.Text = contasData.CurrentRow.Cells[1].Value.ToString();
                descricaoTxt.Text = contasData.CurrentRow.Cells[2].Value.ToString();
                valorTextBox.Text = contasData.CurrentRow.Cells[3].Value.ToString();
                categoriaCombo.Text = contasData.CurrentRow.Cells[4].Value.ToString();
                fornecedorTxt.Text = contasData.CurrentRow.Cells[5].Value.ToString();
                dataVencimento.Text = contasData.CurrentRow.Cells[6].Value.ToString();
                dataPagamento.Text = contasData.CurrentRow.Cells[7].Value.ToString();
                estadoCombo.Text = contasData.CurrentRow.Cells[10].Value.ToString();
                parcelasRecebimento.Text = contasData.CurrentRow.Cells[14].Value.ToString();
                totalParcelas.Text = contasData.CurrentRow.Cells[12].Value.ToString();
                pagamentoCombo.Text = contasData.CurrentRow.Cells[13].Value.ToString(); 

            }
            catch (Exception erro)
            {

            }
        }
        public void carregar()
        {

            string comando = "select * from contas ;";


            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                contasData.DataSource = tabela;
                conexao.Close();
                
            }
            catch (Exception e)
            {
               // MessageBox.Show(Convert.ToString(e));
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }


        }
        public void setTotal()
        {
            float valorTotal;
            //foreach(var linha in contasData.Rows)
            //valorTotal+= linha.
        }
        public void pesquisarContas()
        {

            string comando = "select * from contas where estado like '%"+estado.Text+"%';";
            

            try
            {
                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                contasData.DataSource = tabela;

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
        //10 12 13
        private void consultarContas_Load(object sender, EventArgs e)
        {
            carregar();
            nomeLabel.Text = nome;
        }
        private decimal ValorTotal()
        {
            decimal total = 0;
            int i = 0;
            for (i = 0; i < contasData.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(contasData.Rows[i].Cells[4].Value);
            }
            return total;
        }
        private void resgistrarMembButton_Click(object sender, EventArgs e)
        {
            cadastrarConta obj = new cadastrarConta();
            obj.responsavel = nome;
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carregar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visualizaRelatorioContas obj = new visualizaRelatorioContas();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(estado.Text == "")
            {
                MessageBox.Show("Escolha uma estado de conta");
            }
            else
            {
                pesquisarContas();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {

                if (!char.IsDigit(e.KeyChar))

                {

                    e.Handled = true;

                }

            }
        }

        private void contasData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deletar();
        }

        private void totalParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTxt.Text == "")
                {
                    MessageBox.Show("Escolha algum Registro");
                }
                else if (Convert.ToInt32(parcelasRecebimento.Text) > Convert.ToInt32(totalParcelas.Text))
                {
                    MessageBox.Show("Quantidade de Parcelas invalidas");
                }
                else if (parcelasRecebimento.Text == "")
                {
                    MessageBox.Show("Quantidade de Parcelas invalidas");
                }
                else if (totalParcelas.Text == "")
                {

                    MessageBox.Show("Quantidade de Parcelas invalidas");
                }                    
                else if (Convert.ToDateTime(dataPagamento.Text) > Convert.ToDateTime(dataVencimento.Text))
                {
                    MessageBox.Show("Datas invalidadas");
                }
                else if (descricaoTxt.Text == "")
                {
                    MessageBox.Show("Descrição Invalida");
                }
                else if (categoriaCombo.Text == "")
                {
                    MessageBox.Show("Escolha uma cateoria");
                }
                else if (fornecedorTxt.Text == "")
                {
                    {
                        MessageBox.Show("Escolha um fornecedor");
                    }
                }
                else if (estadoCombo.Text == "")
                {
                    MessageBox.Show("Escolha um estado de compra");
                }
                else if (estadoCombo.Text != "")
                    atualizarRegistro();
            }
            catch(Exception erro)
            {
                
            }
        }

        private void valorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

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
        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref valorTextBox);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                visualizaRelatorioContas obj = new visualizaRelatorioContas();
                obj.Show();
            }
            catch(Exception erro) { }
        }

        private void pagamentoCombo_Leave(object sender, EventArgs e)
        {
        }

        private void categoriaCombo_Leave(object sender, EventArgs e)
        {

        }

        private void totalParcelas_Leave(object sender, EventArgs e)
        {
            if (categoriaCombo.Text == "Unico") {
                totalParcelas.Text = "1";
                categoriaCombo.Text = "Unico";
            }

            parcelasRecebimento.Text = "0";
        }

        private void categoriaCombo_TextChanged(object sender, EventArgs e)
        {
        }

        private void categoriaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (categoriaCombo.Text == "Unico")
            {
                parcelasRecebimento.Text = "1";
                totalParcelas.Text = "1";
                parcelasRecebimento.Enabled = false;
                totalParcelas.Enabled = false;
                label12.Text = "Valor `Parcelas";
            }
            if (categoriaCombo.Text == "Mensal" || categoriaCombo.Text == "Anual")
            {
                label12.Text = "Valor `Parcelas";

                parcelasRecebimento.Text = "1";
                totalParcelas.Text = "2";
                parcelasRecebimento.Enabled = true;
                totalParcelas.Enabled = true;
            }
        }
    }
}
