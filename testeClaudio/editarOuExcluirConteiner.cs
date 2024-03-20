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
    public partial class editarOuExcluirConteiner : Form
    {
        public editarOuExcluirConteiner()
        {
            InitializeComponent();
        }

        private void editarOuExcluirConteiner_Load(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT * FROM `conteiner`";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.Rows[e.RowIndex];
            idConteiner.Text = line.Cells[0].Value.ToString();
            letrasConteiner.Text = line.Cells[1].Value.ToString();
            tipo.Text = line.Cells[2].Value.ToString();
            status.Text = line.Cells[3].Value.ToString();
            categoria.Text = line.Cells[4].Value.ToString();
            idcliente.Text = line.Cells[5].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"UPDATE `conteiner` SET `codigoConteiner` = '{letrasConteiner.Text}', `tipo` = '{tipo.Text}', `estado` = '{status.Text}', `categoria` = '{categoria.Text}' WHERE `conteiner`.`id_conteiner` = {idConteiner.Text}";
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

        private void btnExc_Click(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"DELETE FROM conteiner WHERE `conteiner`.`id_conteiner` = {idConteiner.Text}";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                this.Close();
                MessageBox.Show("Conteiner excluido");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
