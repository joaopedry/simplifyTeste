using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplify.Grafico
{
    public partial class TelaGerarRelatorio : Form
    {
        public DateTime DataInicio;
        public DateTime DataFinal;
        public TelaGerarRelatorio()
        {
            InitializeComponent();
        }

        public void DataInformadaInicio()
        {
            dtpDataInicioRelatorio.Value.Date.ToString("dd/MM/yyyy");
            DataInicio = DateTime.Parse(dtpDataInicioRelatorio.Text);
            dtpDataFimRelatorio.Value.Date.ToString("dd/MM/yyyy");
            DataFinal = DateTime.Parse(dtpDataFimRelatorio.Text);

            Program.Gerenciador.RelatorioDataInicio(DataInicio, DataFinal);
            Program.Gerenciador.RelatorioDataFinal(DataInicio);
            // MessageBox.Show(DataInicio.ToString(), "!");
        }

        public void DataInformadaFinal()
        {

        }

        private void TelaGerarRelatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnResultado_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
        }

        private void TelaGerarRelatorio_Load(object sender, EventArgs e)
        {
        }
    }
}
