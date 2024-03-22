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
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT * FROM `movimentacao`";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            DateTime MinhaDataInit = DateTime.Parse(dataInicio.Text);
            dataInicio.Text = MinhaDataInit.ToString("yyyy-MM-dd hh:mm:ss");
            DateTime MinhaDataFim = DateTime.Parse(dataFinal.Text);
            dataFinal.Text = MinhaDataFim.ToString("yyyy-MM-dd hh:mm:ss");

            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"UPDATE `movimentacao` SET `tipoMovimentacao` = '{movimentacao.Text}', `dataInicio` = '{dataInicio.Text}', `dataFim` = '{dataFinal.Text}' WHERE `movimentacao`.`id` = {idMovimentacao.Text}";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                this.Close();
                MessageBox.Show("Edição Concluída");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"DELETE FROM movimentacao WHERE `movimentacao`.`id` = {idMovimentacao.Text}";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                this.Close();
                MessageBox.Show("Movimentação excluída");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataInicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
