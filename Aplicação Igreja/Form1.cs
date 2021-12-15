using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Aplicação_Igreja.Inicio;

namespace Aplicação_Igreja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string nome { get; set; }
        public string funcao { get; set; }

        public void reabrir(bool status)
        {
                if (status == true)
                {
                    this.Visible = true;
                }
                else if (status == false)
                {
                    this.Visible = false;
                }
            
        }

        public void Logar()
        {
            SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");
            SqlDataReader leitor;
            try
            {

                conexao.Open();

                SqlCommand comando = new SqlCommand("select * from usuario as c join login as l on c.idlogin = l.id where l.login=@login and l.senha=@senha and c.ativo = 'Ativo'", conexao);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                comando.Parameters.AddWithValue("@login", loginTextBox.Text);
                comando.Parameters.AddWithValue("@senha", senhaTextBox.Text);

                leitor = comando.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        MessageBox.Show("Seja Bem-Vindo " + leitor.GetString(1) + "!!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nome = leitor.GetString(1);
                        funcao = leitor.GetString(3);

                        reabrir(false);

                        menuInicial menu = new menuInicial();
                        menu.nome(nome, funcao);

                        menu.id_usuario = leitor.GetInt32(0);
                        menu.user = leitor.GetString(1);
                        menu.funcao = leitor.GetString(2);
                        menu.Show();

                    }

                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Login ou Senha Incorretos \n ou Usuário Inativo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
        }

        private void logarButton_Click(object sender, EventArgs e)
        {
            Logar();
        }
        public void Limpar()
        {
            if (MessageBox.Show("Deseja realmente limpar campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginTextBox.Clear();
                senhaTextBox.Clear();
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;

            }
            else
            {
                Application.Exit();
            }
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void senhaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logarButton.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
