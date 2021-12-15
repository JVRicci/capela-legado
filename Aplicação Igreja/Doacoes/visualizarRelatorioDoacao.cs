using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação_Igreja.Doacoes
{
    public partial class visualizarRelatorioDoacao : Form
    {
        public visualizarRelatorioDoacao()
        {
            InitializeComponent();
        }

        private void visualizarRelatorioDoacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoCapelaDataSet.doacao'. Você pode movê-la ou removê-la conforme necessário.
            this.doacaoTableAdapter.Fill(this.bancoCapelaDataSet.doacao);

            this.reportViewer1.RefreshReport();
        }
    }
}
