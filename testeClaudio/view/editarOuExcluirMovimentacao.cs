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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testeClaudio
{
    public partial class editarOuExcluirMovimentacao : Form
    {
        public editarOuExcluirMovimentacao()
        {
            InitializeComponent();
        }

        private void editarOuExcluirMovimentacao_Load(object sender, EventArgs e)
        {
            controlers.movimentacaoControler.ListarMovimentacao(dataGridView1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.Rows[e.RowIndex];
            idMovimentacao.Text = line.Cells[0].Value.ToString();
            movimentacao.Text = line.Cells[1].Value.ToString();
            dataInicio.Text = line.Cells[2].Value.ToString();
            dataFinal.Text = line.Cells[3].Value.ToString();
            idContainer.Text = line.Cells[4].Value.ToString();
            idCliente.Text = line.Cells[5].Value.ToString();
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string movimento = movimentacao.Text;
            string dataInit = dataInicio.Text;
            string dataFim = dataFinal.Text;
            string idMovimento = idMovimentacao.Text;
            controlers.movimentacaoControler.EditarMovimentacao(movimento, dataInit, dataFim, idMovimento);
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string idMovimento = idMovimentacao.Text;
            controlers.movimentacaoControler.ExcluirMovimentacao(idMovimento);
            this.Close();
        }

        private void dataInicio_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
