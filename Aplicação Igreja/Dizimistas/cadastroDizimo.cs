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
    public partial class cadastroDizimo : Form
    {
        public cadastroDizimo()
        {
            InitializeComponent();
        }
        public string nome { get; set; }
        public string idDizimista { get; set; }
        
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

                comando.CommandText = "insert into dizimo (qtdRecebida, dataRecebimento) " +
                    "values (@qtd, @data); ";
                comando.Parameters.AddWithValue("@qtd", Convert.ToDecimal( valorTextBox.Text));
                comando.Parameters.AddWithValue("@data", dataTextBox.Text);

                comando2.CommandText = "update dizimo set " +
                    "idDizimista= @idDizimista" +
                    " where id = (select max(id) from dizimo); ";
                comando2.Parameters.AddWithValue("@idDizimista", idTextBox.Text);

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

        public void carregar()
        {

            idTextBox.Text = idDizimista;
            dizimistaTextBox.Text = nome;

        }

        private void cadastroDizimo_Load(object sender, EventArgs e)
        {
            carregar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref valorTextBox);
        }

        private void registrarButton_Click(object sender, EventArgs e)
        {
            if (valorTextBox.Text == "")
            {
                MessageBox.Show("Digite um valor.");
            }
            else 
            cadastrar();
        }

        private void valorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}
