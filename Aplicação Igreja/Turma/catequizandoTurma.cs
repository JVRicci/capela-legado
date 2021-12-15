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
    public partial class catequizandoTurma : Form
    {
        public catequizandoTurma()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoCapela;Data Source=DESKTOP-Q7U0TS0\\MSSQLSERVER01");


        public string diaEncontro { get; set; }
        public string turma { get; set; }
        public string idTurma { get; set; }


        public void registrar()
        {
                for (int i = 0; i < catequizandoData.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(catequizandoData.Rows[i].Cells[0].Value))
                    {
                        try
                        {
                            conexao.Open();
                            SqlCommand comando = new SqlCommand();

                            comando.Connection = conexao;

                            comando.CommandText = "update catequizando set idTurma = " + idTxt.Text  +
                            " where id = "+ catequizandoData.CurrentRow.Cells[1].Value.ToString() + ";";

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

                        }
                    }
                }
            
        }

        public void carregarCatequizando()
        {
            idTxt.Text = idTurma;
            turmaTxt.Text = turma;
            encontroTxt.Text = diaEncontro;

            try
            {
                string comando = "select c.id, c.nome, c.nascimento, " +
               "  r.id, r.responsavel, r.nascRespon, r.estadoCivil, r.tipoCasamento, r.padrinho, r.madrinha," +
               "	e.id, e.logradouro, e.numero, e.bairro, e.cep, e.uf, e.cidade," +
               "	i.id, i.telefone, i.celular, c.idResponsavel " +
               "   from catequizando as c " +
               "    inner join responsavel as r on(c.idResponsavel = r.id)" +
               "    inner join endereco as e on(c.idEndereco = e.id)" +
               "    inner join contato as i on(c.idContato = i.id)" +
               "   where c.idTurma <>  " + Convert.ToInt32(idTurma) + ";";
 
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
        private void catequizandoTurma_Load(object sender, EventArgs e)
        {
            carregarCatequizando();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void catequizandoData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
