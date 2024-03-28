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
            string strSql = "SELECT * FROM `clientes`";
            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
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
        public static void AddCliente(string nomeCliente, string cpfCliente, string ufCliente)
        {
            Cliente cliente = new Cliente();
            cliente.cliente = nomeCliente;
            cliente.cpf = cpfCliente;
            cliente.uf = ufCliente;
            var strSql = $"INSERT INTO clientes (cliente, cpf, uf) values ('{cliente.cliente}', '{cliente.cpf}', '{cliente.uf}')";
            try
            {
                controlers.auxControler.EscreverDb(strSql);
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
            var strSql = $"DELETE FROM `clientes` WHERE `clientes`.`id_cliente` = {cliente.id_cliente}";
            try
            {
                controlers.auxControler.EscreverDb(strSql);
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
            var strSql = $"UPDATE `clientes` SET `cliente` = '{cliente.cliente}', `cpf` = '{cliente.cpf}', `uf` = '{cliente.uf}' WHERE `clientes`.`id_cliente` = {cliente.id_cliente}";
            try
            {
                controlers.auxControler.EscreverDb(strSql);
                MessageBox.Show("Edição Concluída");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
