using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação_Igreja.Dizimistas
{
    public partial class visualizaRelatorioDizimo : Form
    {
        public visualizaRelatorioDizimo()
        {
            InitializeComponent();
        }

        private void visualizaRelatorioDizimo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoCapelaDataSet.dizimo'. Você pode movê-la ou removê-la conforme necessário.
            this.dizimoTableAdapter.Fill(this.bancoCapelaDataSet.dizimo);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
