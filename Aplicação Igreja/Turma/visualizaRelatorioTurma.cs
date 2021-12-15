using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação_Igreja.Turma
{
    public partial class visualizaRelatorioTurma : Form
    {
        public visualizaRelatorioTurma()
        {
            InitializeComponent();
        }

        private void visualizaRelatorioTurma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoCapelaDataSet.catequizando'. Você pode movê-la ou removê-la conforme necessário.
            this.catequizandoTableAdapter.Fill(this.bancoCapelaDataSet.catequizando);
        }
    }
}
