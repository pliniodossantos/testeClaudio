using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeClaudio.controlers
{
    internal class clientesControler
    {
        public static void ListaDeClientes(DataGridView dataGrid) {
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
                dataGrid.DataSource = dt;
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AddCliente(string nomeCliente, string cpfCliente, string ufCliente)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"INSERT INTO clientes (cliente, cpf, uf) values ('{nomeCliente}', '{cpfCliente}', '{ufCliente}')";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cliente Adicionado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void DeleteCliente(string id)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"DELETE FROM `clientes` WHERE `clientes`.`id_cliente` = {id}";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cliente excluido");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void EditarCliente(string id, string cliente, string cpf, string uf) {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"UPDATE `clientes` SET `cliente` = '{cliente}', `cpf` = '{cpf}', `uf` = '{uf}' WHERE `clientes`.`id_cliente` = {id}";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Edição Concluída");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
