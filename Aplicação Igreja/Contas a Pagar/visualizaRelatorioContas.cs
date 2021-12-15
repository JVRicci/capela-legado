using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação_Igreja.Contas_a_Pagar
{
    public partial class visualizaRelatorioContas : Form
    {
        public visualizaRelatorioContas()
        {
            InitializeComponent();
        }

        private void visualizaRelatorioContas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoCapelaDataSet.contas'. Você pode movê-la ou removê-la conforme necessário.
            this.contasTableAdapter.Fill(this.bancoCapelaDataSet.contas);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
