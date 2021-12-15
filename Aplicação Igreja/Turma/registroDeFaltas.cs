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
    public partial class registroDeFaltas : Form
    {
        public registroDeFaltas()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");

        public string diaEncontro { get; set; }
        public string turma { get; set; }
        public string idTurma { get; set; }

        public void carregarCatequizando()
        {
            idTxt.Text = idTurma;
            turmaTxt.Text = turma;
            encontroTxt.Text = diaEncontro;

            try
            {
                string comando = "select id, nome, ativo, faltaEncontro, faltaMissa from catequizando " +
               "   where idTurma = " + Convert.ToInt32(idTurma) + ";";

                conexao.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(comando, conexao);
                DataTable tabela = new DataTable();
                dataAdapter.Fill(tabela);
                catequizandoData.DataSource = tabela;

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
            try
            {
                idCatTxt.Text = catequizandoData.CurrentRow.Cells[1].Value.ToString();
                nomeTxt.Text = catequizandoData.CurrentRow.Cells[2].Value.ToString();
                faltaEncCombo.Text = catequizandoData.CurrentRow.Cells[4].Value.ToString();
                faltaCelebTxt.Text = catequizandoData.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception error) { }
        }
        public void registrarFaltasNormal()
        {
                    try
                    {
                        conexao.Open();
                        SqlCommand comando = new SqlCommand();

                        comando.Connection = conexao;

                comando.CommandText = "update catequizando set ativo='Ativo', faltaEncontro = " + faltaEncCombo.Text +", faltaMissa = " + faltaCelebTxt.Text  +
                    " where id = " + catequizandoData.CurrentRow.Cells[1].Value.ToString() + ";";

                        comando.ExecuteNonQuery();
                conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(Convert.ToString(erro));
                    }
                    finally
                    {
                        if (conexao != null) conexao.Close();

                        carregarCatequizando();

                        MessageBox.Show("Registros efetuados com sucesso", "Registro");
                    }
                

        }
        public void registrarFaltasAvaliação()
        {
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;

                comando.CommandText = "update catequizando set ativo = 'Avaliação', faltaEncontro = " + faltaEncCombo.Text + ", faltaMissa = " + faltaCelebTxt.Text +
                    " where id = " + catequizandoData.CurrentRow.Cells[1].Value.ToString() + ";";

                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(Convert.ToString(erro));
            }
            finally
            {
                if (conexao != null) conexao.Close();

                carregarCatequizando();

                MessageBox.Show("Registros efetuados com sucesso", "Registro");
            }
        }
        public void registrarFaltasRetido()
        {
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;

                comando.CommandText = "update catequizando set ativo = 'Retido', faltaEncontro = " + faltaEncCombo.Text + ", faltaMissa = " + faltaCelebTxt.Text +
                    " where id = " + catequizandoData.CurrentRow.Cells[1].Value.ToString() + ";";

                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(Convert.ToString(erro));
            }
            finally
            {
                if (conexao != null) conexao.Close();

                carregarCatequizando();

                MessageBox.Show("Registros efetuados com sucesso", "Registro");
            }
        }
        private void registroDeFaltas_Load(object sender, EventArgs e)
        {
            carregarCatequizando();
        }

        private void catequizandoData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaCampos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(faltaEncCombo.Text) < 3 && Convert.ToInt32(faltaCelebTxt.Text) < 3)
                {
                    registrarFaltasNormal();
                }
                else if (Convert.ToInt32(faltaEncCombo.Text) >= 3 || Convert.ToInt32(faltaCelebTxt.Text) >= 3)
                {
                    registrarFaltasAvaliação();
                }
                if (Convert.ToInt32(faltaEncCombo.Text) == 5 || Convert.ToInt32(faltaCelebTxt.Text) == 5)
                {
                    registrarFaltasRetido();
                }
                if(faltaCelebTxt.Text == "")
                {
                    MessageBox.Show("Escolha uma quantidade de faltas");
                }
                if(faltaEncCombo.Text== "")
                {

                    MessageBox.Show("Escolha uma quantidade de faltas");
                }
            }
            catch (Exception erro)
            {
                
            }
        }

        private void catequizandoData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            carregaCampos();
        }
    }
}
