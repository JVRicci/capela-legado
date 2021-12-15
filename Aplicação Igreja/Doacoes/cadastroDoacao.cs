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

namespace Aplicação_Igreja.Doacoes
{
    public partial class cadastroDoacao : Form
    {
        public cadastroDoacao()
        {
            InitializeComponent();
        }
        public string nome { get; set; }
        public string idDoador { get; set; }
        public string operacao { get; set; }

        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");

        public void cadastrarMaterial()
        {
            SqlCommand comando = new SqlCommand();
            SqlCommand comando2 = new SqlCommand();
            try
            {
                conexao.Open();


                comando.Connection = conexao;
                comando2.Connection = conexao;


                comando.CommandText = "insert into doacao (descricao, destino, dataReceb, tipoDoacao) " +
                    "values (@descricao, @destino, @dataReceb, @tipoDoacao); ";
                comando.Parameters.AddWithValue("@descricao", descricaoTxt.Text);
                comando.Parameters.AddWithValue("@destino", destinoTxt.Text);
                comando.Parameters.AddWithValue("@dataReceb", marcaDoacaoBox.Value.ToString());
                comando.Parameters.AddWithValue("@tipoDoacao", tipoCombo.Text);


                comando2.CommandText = "update doacao set " +
                    "idDoador= @idDoador" +
                    " where id = (select max(id) from doacao); ";

                comando2.Parameters.AddWithValue("@idDoador", idTxt.Text);

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
        public void cadastrarEspecie()
        {
            SqlCommand comando = new SqlCommand();
            SqlCommand comando2 = new SqlCommand();
            try
            {
                conexao.Open();


                comando.Connection = conexao;
                comando2.Connection = conexao;


                comando.CommandText = "insert into doacao (descricao, destino, dataReceb, tipoDoacao) " +
                    "values (@descricao, @destino, @dataReceb,@tipoDoacao); ";
                comando.Parameters.AddWithValue("@descricao", valorTxt.Text);
                comando.Parameters.AddWithValue("@destino", destinoTxt.Text);
                comando.Parameters.AddWithValue("@dataReceb", marcaDoacaoBox.Value.ToString());
                comando.Parameters.AddWithValue("@tipoDoacao", tipoCombo.Text);


                comando2.CommandText = "update doacao set " +
                    "idDoador= @idDoador" +
                    " where id = (select max(id) from doacao); ";

                comando2.Parameters.AddWithValue("@idDoador", idTxt.Text);

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
        public void opVoid()
        {
            if (operacao == "doacao")
            {

                doadorTxt.Enabled = false;
            }
            if(operacao == "doador")
            {

                int idNovo = Convert.ToInt32(idDoador) + 1;
                idTxt.Text = Convert.ToString(idNovo);
            }

        }
        private void cadastroDoacao_Load(object sender, EventArgs e)
        {
            idTxt.Text = idDoador;

            
            opVoid();
            doadorTxt.Text = nome;
        }

        private void registrarDizimo_Click(object sender, EventArgs e)
        {
            if(tipoCombo.Text == "")
            {
                MessageBox.Show("Escolha um tipo");
            }
            if (destinoTxt.Text == "")
            {
                MessageBox.Show("Escolha um destino");
            }
            else if (tipoCombo.Text == "Em Espécie")
                cadastrarEspecie();
            else if (tipoCombo.Text == "Material")
                cadastrarMaterial();
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
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void descricaoTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void valorTxt_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref valorTxt);
        }

        private void tipoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoCombo.Text == "Em Espécie")
            {
                descricaoTxt.Clear();
                descricaoTxt.Enabled = false;
                valorTxt.Enabled = true;
            }
            if (tipoCombo.Text == "Material")
            {
                valorTxt.Clear();
                descricaoTxt.Enabled = true;
                valorTxt.Enabled = false;
            }
        }

        private void tipoCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void valorTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}
