using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeClaudio
{
    public partial class relatorio : Form
    {
        public relatorio()
        {
            InitializeComponent();
        }

        private void relatorio_Load(object sender, EventArgs e)
        {
            controlers.relatorioControler.ContarImportação(totalImportacao);
            controlers.relatorioControler.ContarExportação(totalExportacao);
            controlers.relatorioControler.SelecionarClientesEId(cliente);

        }

        private void cliente_DropDownClosed(object sender, EventArgs e)
        {}

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string[] recebeId = cliente.Text.Split('/');
            string  receberArrayId = recebeId[1];
            string movimentacao = movimento.Text;
            controlers.relatorioControler.RetornarInfoGrid(dataGridView1, movimentacao, receberArrayId);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  }
    }
}
