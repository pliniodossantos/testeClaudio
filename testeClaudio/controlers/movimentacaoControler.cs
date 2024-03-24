using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    internal class movimentacaoControler
    {
        public static void RetornaInfosPorId(string id_Conteiner, TextBox codConteiner, TextBox  idCliente, TextBox cliente) 
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = $"SELECT conteiner.codigoConteiner, conteiner.id_cliente, clientes.cliente FROM conteiner JOIN clientes on clientes.id_cliente = conteiner.id_cliente WHERE conteiner.id_conteiner = {id_Conteiner}";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    codConteiner.Text = ($"{reader["codigoConteiner"]}");
                    idCliente.Text = ($"{reader["id_cliente"]}");
                    cliente.Text = ($"{reader["cliente"]}");
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RetornarIdConteiner(ComboBox idConteiner) 
            {

            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var comando = new MySqlCommand("SELECT `id_conteiner` FROM `conteiner` ORDER BY `id_conteiner` ASC", conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    idConteiner.Items.Add($"{reader["id_conteiner"]}");


                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    public static void RegistrarMovimentacao(string movimento, string dateInit, string dateFim, string idCont, string idClien)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"INSERT INTO `movimentacao` (`tipoMovimentacao`, `dataInicio`, `dataFim`, `idConteiner`, `idCliente`) VALUES ('{movimento}', '{dateInit}', '{dateFim}', '{idCont}', '{idClien}')";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Movimentação Adicionado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    public static void ListarMovimentacao(DataGridView dataGridView1)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT id, tipoMovimentacao, DATE_FORMAT(dataInicio, '%Y-%c-%d %H:%i:%s' ) AS 'dataInicio', DATE_FORMAT(dataFim, '%Y-%c-%d %H:%i:%s' ) AS 'dataFim', idConteiner, idCliente FROM `movimentacao` ";
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
    public static void EditarMovimentacao(string movimento, string dataInit, string dataFim, string idMovimento)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"UPDATE `movimentacao` SET `tipoMovimentacao` = '{movimento}', `dataInicio` = '{dataInit}', `dataFim` = '{dataFim}' WHERE `movimentacao`.`id` = {idMovimento}";
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
    public static void ExcluirMovimentacao(string idMovimento)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"DELETE FROM movimentacao WHERE `movimentacao`.`id` = {idMovimento}";
                var comando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Movimentação excluída");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
