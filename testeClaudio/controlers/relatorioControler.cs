using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeClaudio.controlers
{
    internal class relatorioControler
    {
        private static object recebeId;

        public static void ContarImportação(TextBox totalImportacao)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT COUNT(*) FROM conteiner WHERE categoria = 'Importação'";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    totalImportacao.Text = $"{reader["COUNT(*)"]}";

                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ContarExportação(TextBox totalExportacao)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT COUNT(*) FROM conteiner WHERE categoria = 'Exportação'";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    totalExportacao.Text = $"{reader["COUNT(*)"]}";

                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SelecionarClientesEId(ComboBox cliente)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT `id_cliente`, `cliente` FROM `clientes`";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cliente.Items.Add(($"{reader["cliente"]}" + "/" + $"{reader["id_cliente"]}"));

                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RetornarInfoGrid(DataGridView dataGridView1, string movimentacao, string receberArrayId)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = $"SELECT * FROM `movimentacao` WHERE `tipoMovimentacao` LIKE '{movimentacao}' AND `idCliente` = {receberArrayId}";
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

    }
}
