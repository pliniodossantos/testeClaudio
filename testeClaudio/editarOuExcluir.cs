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
    public partial class editarOuExcluir : Form
    {
        public editarOuExcluir()
        {
            InitializeComponent();
        }

        private void editarOuExcluir_Load(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT * FROM `clientes`";
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.Rows[e.RowIndex];
            txtId.Text = line.Cells[0].Value.ToString();
            txtCliente.Text = line.Cells[1].Value.ToString();
            txtCpf.Text = line.Cells[2].Value.ToString();
            txtUf.Text = line.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.Rows[e.RowIndex];
            txtId.Text = line.Cells[0].Value.ToString();
            txtCliente.Text = line.Cells[1].Value.ToString();
            txtCpf.Text = line.Cells[2].Value.ToString();
            txtUf.Text = line.Cells[3].Value.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"DELETE FROM `clientes` WHERE `clientes`.`id_cliente` = {txtId.Text}";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                this.Close();
                MessageBox.Show("Cliente excluido");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"UPDATE `clientes` SET `cliente` = '{txtCliente.Text}', `cpf` = '{txtCpf.Text}', `uf` = '{txtUf.Text}' WHERE `clientes`.`id_cliente` = {txtId.Text}";
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
    }
}

