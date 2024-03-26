using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeClaudio.model;

namespace testeClaudio.controlers
{
    internal class clientesControler
    {

        public static List<Cliente> ListarClientes() {
            List<Cliente> listar = new List<Cliente>();

            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT * FROM `clientes`";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listar.Add(new Cliente
                    {
                        id_cliente = reader.GetInt32(0),
                        cliente = reader.GetString(1),
                        cpf = reader.GetString(2),
                        uf = reader.GetString(3)

                    });
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listar;

        }
        public static void AddClinete(string nomeCliente, string cpfCliente, string ufCliente)
        {
            Cliente cliente = new Cliente();
            cliente.cliente = nomeCliente;
            cliente.cpf = cpfCliente;
            cliente.uf = ufCliente;
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"INSERT INTO clientes (cliente, cpf, uf) values ('{cliente.cliente}', '{cliente.cpf}', '{cliente.uf}')";
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
            Cliente cliente = new Cliente();
            cliente.id_cliente = int.Parse(id);
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"DELETE FROM `clientes` WHERE `clientes`.`id_cliente` = {cliente.id_cliente}";
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
        public static void EditarCliente(string id, string client, string cpf, string uf) {
            Cliente cliente = new Cliente();
            cliente.id_cliente = int.Parse(id);
            cliente.cliente = client;
            cliente.cpf = cpf;
            cliente.uf = uf;
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"UPDATE `clientes` SET `cliente` = '{cliente.cliente}', `cpf` = '{cliente.cpf}', `uf` = '{cliente.uf}' WHERE `clientes`.`id_cliente` = {cliente.id_cliente}";
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
