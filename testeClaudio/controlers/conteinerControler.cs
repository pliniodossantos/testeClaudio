using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeClaudio.model;

namespace testeClaudio.controlers
{
    internal class conteinerControler
    {
        public static List<Cliente> ListarIdClientes()
        {
            List<Cliente> listarId = new List<Cliente>();
            var strSql = "SELECT `id_cliente` FROM `clientes`";

            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
                while (reader.Read())
                {
                    listarId.Add(new Cliente
                    {
                        id_cliente = reader.GetInt32(0)

                    });
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listarId;

        }
        public static Cliente RecebeClientePorId(string id_Cliente)
        {
            Cliente cliente = new Cliente();
            cliente.id_cliente = int.Parse(id_Cliente);
            var strSql = $"SELECT `cliente` FROM `clientes` WHERE `clientes`.`id_cliente` = {cliente.id_cliente}";
            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
                while (reader.Read())
                {
                    cliente.cliente = ($"{reader["cliente"]}");
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return cliente;
        }

        public static void RegistrarConteiner(string codigoContainer, string tipoContainer, string stat, string categori, string id_Cliente) {
            Conteiner conteiner = new Conteiner();
            conteiner.codigoConteiner = codigoContainer;
            conteiner.tipo = tipoContainer;
            conteiner.estado = stat;
            conteiner.categoria = categori;
            conteiner.id_cliente = int.Parse(id_Cliente);
            var strSql = $"INSERT INTO `conteiner` (`codigoConteiner`, `tipo`, `estado`, `categoria`, `id_cliente`) VALUES ( '{conteiner.codigoConteiner}', '{conteiner.tipo}', '{conteiner.estado}', '{conteiner.categoria}', '{conteiner.id_cliente}')";
            try
            {
                controlers.auxControler.EscreverDb(strSql);
                MessageBox.Show("Conteiner Adicionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<Conteiner> ListarConteiners()
        {
            List<Conteiner> listaConteiner = new List<Conteiner>();
            var strSql = "SELECT * FROM `conteiner`";
            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
                while (reader.Read())
                {
                    listaConteiner.Add(new Conteiner
                    {
                        id_conteiner = reader.GetInt32(0),
                        codigoConteiner = reader.GetString(1),
                        tipo = reader.GetString(2),
                        estado = reader.GetString(3),
                        categoria = reader.GetString(4),
                        id_cliente = reader.GetInt32(5)
                    });
                }

                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listaConteiner;
        }
        public static void EditarConteiner(string codConteiner, string type, string estado, string category, string id_Conteiner)
        {
            Conteiner conteiner = new Conteiner();
            conteiner.codigoConteiner = codConteiner;
            conteiner.tipo = type;
            conteiner.estado = estado;
            conteiner.categoria = category;
            conteiner.id_conteiner = int.Parse(id_Conteiner);
            var strSql = $"UPDATE `conteiner` SET `codigoConteiner` = '{conteiner.codigoConteiner}', `tipo` = '{conteiner.tipo}', `estado` = '{conteiner.estado}', `categoria` = '{conteiner.categoria}' WHERE `conteiner`.`id_conteiner` = '{conteiner.id_conteiner}'";


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
        public static void ExcluirConteiner(string id_Conteiner)
        {
            Conteiner conteiner = new Conteiner();
            conteiner.id_conteiner = int.Parse(id_Conteiner);
            var strSql = $"DELETE FROM conteiner WHERE `conteiner`.`id_conteiner` = {conteiner.id_conteiner}";
            try
            {
                controlers.auxControler.EscreverDb(strSql);
                MessageBox.Show("Conteiner excluido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
