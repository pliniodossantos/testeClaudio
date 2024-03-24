using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeClaudio.controlers
{
    internal class conteinerControler
    {

        public static void RegistrarConteiner(string codigoContainer, string tipoContainer, string stat, string categori, string id_Cliente) {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"INSERT INTO `conteiner` (`codigoConteiner`, `tipo`, `estado`, `categoria`, `id_cliente`) VALUES ( '{codigoContainer}', '{tipoContainer}', '{stat}', '{categori}', '{id_Cliente}')";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                
                MessageBox.Show("Conteiner Adicionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RetornarIdCliente(ComboBox idCliente)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT `id_cliente` FROM `clientes`";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    idCliente.Items.Add(($"{reader["id_cliente"]}"));

                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void InserirClientePorId(string id_Cliente, TextBox nomeCliente) {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = $"SELECT `cliente` FROM `clientes` WHERE `clientes`.`id_cliente` = {id_Cliente}";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();


                while (reader.Read())
                {
                    nomeCliente.Text = ($"{reader["cliente"]}");
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ListarConteiner(DataGridView dataGridView1)
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
        public static void EditarConteiner(string codConteiner, string type, string estado, string category, string id_Conteiner)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"UPDATE `conteiner` SET `codigoConteiner` = '{codConteiner}', `tipo` = '{type}', `estado` = '{estado}', `categoria` = '{category}' WHERE `conteiner`.`id_conteiner` = '{id_Conteiner}'";
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
        public static void ExcluirConteiner(string id_Conteiner)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"DELETE FROM conteiner WHERE `conteiner`.`id_conteiner` = {id_Conteiner}";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Conteiner excluido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
