using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicação_Igreja.Dizimistas;
using Aplicação_Igreja.Catequisando;
using Aplicação_Igreja.Catequista;
using Aplicação_Igreja.Turma;
using Aplicação_Igreja.Doacoes;
using Aplicação_Igreja.Eventos;
using Aplicação_Igreja.Contas_a_Pagar;
using Aplicação_Igreja.Usuários;

namespace Aplicação_Igreja.Inicio
{
    public partial class menuInicial : Form
    {
        public menuInicial()
        {
            InitializeComponent();
        }

        public string user { get; set; }
        public string funcao { get; set; }
        public Int32 id_usuario { get; set; }

        public void nome(string user, string funcao)
        {
            nomeStatusLabel.Text = "Usuário: " + user + "    Função: " + funcao;
            if (funcao == "Auxiliar")
            {
                dizimoToolStripMenuItem.Visible = false;
                catequeseToolStripMenuItem.Visible = false;
                contaToolStripMenuItem.Visible = true;
                doacoesToolStripMenuItem.Visible = false;
                eventosToolStripMenuItem.Visible = false;
                usuáriosDoSistemaToolStripMenuItem.Visible = false;
                
                userButton.Visible = false;
                turmasButton.Visible = false;
                dizimoButton.Visible = false;
                doacoesButton.Visible = false;
            }
            if (funcao == "Catequista")
            {

                dizimoToolStripMenuItem.Visible = false;
                eventosToolStripMenuItem.Visible = false;
                contaToolStripMenuItem.Visible = false;
                doacoesToolStripMenuItem.Visible = false;
            }
        }

        public void novaAba(Form conteudo)
        {

            TabPage pagina = new TabPage(conteudo.Text);

            conteudo.TopLevel = false;
            conteudo.Parent = pagina;
            conteudo.Visible = true;
            conteudo.FormBorderStyle = FormBorderStyle.None;
            conteudo.Dock = DockStyle.Fill;

                pagina.Controls.Add(conteudo);
                principalAbas.TabPages.Add(pagina);
                principalAbas.SelectTab(pagina);

        }

        private void menuInicial_Load(object sender, EventArgs e)
        {

        }
        public void fecharTabPage()
        {

            if (MessageBox.Show("Deseja mesmo fechar '"+principalAbas.SelectedTab.Text+"'?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                principalAbas.Controls.Remove(principalAbas.SelectedTab);
            }
        }
        private void menuInicial_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 menuLogin = new Form1();
                menuLogin.reabrir(true);

            }
            else
            {
                e.Cancel = true;
            }
        }


        private void dizimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultar_dizimista obj = new consultar_dizimista();
            novaAba(obj);

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void catequizandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulta_catequizando obj = new consulta_catequizando();
            novaAba(obj);

        }

        private void principalAbas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (principalAbas.SelectedTab == inicioTab)
            {
            }
            else
            {
                fecharTabPage();
            }
        }

        private void catequistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Catequista obj = new Cadastro_Catequista();
            novaAba(obj);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarTurmas obj = new consultarTurmas();
            novaAba(obj);
        }

        private void doacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarDoacoes obj = new consultarDoacoes();
            novaAba(obj);
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarEventos obj = new consultarEventos();
            obj.nomeUser = user;
            novaAba(obj);
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarContas obj = new consultarContas();
            obj.nome = user; 
            novaAba(obj);
        }

        private void usuáriosDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaUser obj = new consultaUser();
            novaAba(obj);
        }

        private void contasButton_Click(object sender, EventArgs e)
        {

            consultarContas obj = new consultarContas();
            obj.nome = user;
            novaAba(obj);
        }

        private void userButton_Click(object sender, EventArgs e)
        {

            consultaUser obj = new consultaUser();
            novaAba(obj);
        }

        private void turmasButton_Click(object sender, EventArgs e)
        {

            consultarTurmas obj = new consultarTurmas();
            novaAba(obj);
        }

        private void dizimoButton_Click(object sender, EventArgs e)
        {

            consultar_dizimista obj = new consultar_dizimista();
            novaAba(obj);
        }

        private void doacoesButton_Click(object sender, EventArgs e)
        {

            consultarDoacoes obj = new consultarDoacoes();
            novaAba(obj);
        }
    }
}
