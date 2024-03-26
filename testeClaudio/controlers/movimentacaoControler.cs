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
using testeClaudio.model;

namespace testeClaudio.controlers
{
    internal class movimentacaoControler
    {
        public static (Conteiner, Cliente) RetornarDadosPorId(string id_conteiner)
        {
            Conteiner conteiner = new Conteiner();
            Cliente cliente = new Cliente();

            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = $"SELECT conteiner.codigoConteiner, conteiner.id_cliente, clientes.cliente FROM conteiner JOIN clientes on clientes.id_cliente = conteiner.id_cliente WHERE conteiner.id_conteiner = {id_conteiner}";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    conteiner.codigoConteiner = reader.GetString(0);
                    conteiner.id_cliente = reader.GetInt32(1);
                    cliente.cliente = reader.GetString(2);
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return (conteiner, cliente);
        }
        public static List<Conteiner> RetornaIdConteiner()
        {
            List<Conteiner> listaIdConteiner = new List<Conteiner>();

            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var comando = new MySqlCommand("SELECT `id_conteiner` FROM `conteiner` ORDER BY `id_conteiner` ASC", conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    listaIdConteiner.Add(new Conteiner
                    {
                        id_conteiner = reader.GetInt32(0)

                    });
                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return listaIdConteiner;
        }
  
        public static void RegistrarMovimentacao(string movimento, string dateInit, string dateFim, string idCont, string idClien)
        {
            Movimentacao registrarMovimento = new Movimentacao();
            registrarMovimento.tipoMovimentacao = movimento;
            registrarMovimento.dataInicio = dateInit;
            registrarMovimento.dataFim = dateFim;
            registrarMovimento.idConteiner = int.Parse(idCont);
            registrarMovimento.idCliente = int.Parse(idClien);
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"INSERT INTO `movimentacao` (`tipoMovimentacao`, `dataInicio`, `dataFim`, `idConteiner`, `idCliente`) VALUES ('{registrarMovimento.tipoMovimentacao}', '{registrarMovimento.dataInicio}', '{registrarMovimento.dataFim}', '{registrarMovimento.idConteiner}', '{registrarMovimento.idCliente}')";
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

        public static List<Movimentacao> ListaMovimentacao(){
            List<Movimentacao> movimento = new List<Movimentacao>();

            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT id, tipoMovimentacao, DATE_FORMAT(dataInicio, '%Y-%c-%d %H:%i:%s' ) AS 'dataInicio', DATE_FORMAT(dataFim, '%Y-%c-%d %H:%i:%s' ) AS 'dataFim', idConteiner, idCliente FROM `movimentacao` ";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    movimento.Add(new Movimentacao
                    {
                        id = reader.GetInt32(0),
                        tipoMovimentacao = reader.GetString(1),
                        dataInicio = reader.GetString(2),
                        dataFim = reader.GetString(3),
                        idConteiner = reader.GetInt32(4),
                        idCliente = reader.GetInt32(5)
                    });
                }

                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return movimento;
        }

    public static void EditarMovimentacao(string movimento, string dataInit, string dataFim, string idMovimento) 
        {
            Movimentacao movimentacao = new Movimentacao();
            movimentacao.tipoMovimentacao = movimento;
            movimentacao.dataInicio = dataInit;
            movimentacao.dataFim = dataFim;
            movimentacao.id = int.Parse(idMovimento);
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"UPDATE `movimentacao` SET `tipoMovimentacao` = '{movimentacao.tipoMovimentacao}', `dataInicio` = '{movimentacao.dataInicio}', `dataFim` = '{movimentacao.dataFim}' WHERE `movimentacao`.`id` = {movimentacao.id}";
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
            Movimentacao movimentacao = new Movimentacao();
            movimentacao.id = int.Parse(idMovimento);
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = $"DELETE FROM movimentacao WHERE `movimentacao`.`id` = {movimentacao.id}";
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
