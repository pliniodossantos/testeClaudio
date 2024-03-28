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
            var strSql = $"SELECT conteiner.codigoConteiner, conteiner.id_cliente, clientes.cliente FROM conteiner JOIN clientes on clientes.id_cliente = conteiner.id_cliente WHERE conteiner.id_conteiner = {id_conteiner}";
            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
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
            var strSql = "SELECT `id_conteiner` FROM `conteiner` ORDER BY `id_conteiner` ASC";
            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
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
            var strSql = $"INSERT INTO `movimentacao` (`tipoMovimentacao`, `dataInicio`, `dataFim`, `idConteiner`, `idCliente`) VALUES ('{registrarMovimento.tipoMovimentacao}', '{registrarMovimento.dataInicio}', '{registrarMovimento.dataFim}', '{registrarMovimento.idConteiner}', '{registrarMovimento.idCliente}')";
            try
            {
                controlers.auxControler.EscreverDb(strSql);
                MessageBox.Show("Movimentação Adicionada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<Movimentacao> ListaMovimentacao(){
            List<Movimentacao> movimento = new List<Movimentacao>();
            var strSql = "SELECT id, tipoMovimentacao, DATE_FORMAT(dataInicio, '%Y-%c-%d %H:%i:%s' ) AS 'dataInicio', DATE_FORMAT(dataFim, '%Y-%c-%d %H:%i:%s' ) AS 'dataFim', idConteiner, idCliente FROM `movimentacao` ";
            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
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
            var strSql = $"UPDATE `movimentacao` SET `tipoMovimentacao` = '{movimentacao.tipoMovimentacao}', `dataInicio` = '{movimentacao.dataInicio}', `dataFim` = '{movimentacao.dataFim}' WHERE `movimentacao`.`id` = {movimentacao.id}";
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
    public static void ExcluirMovimentacao(string idMovimento)
        {
            Movimentacao movimentacao = new Movimentacao();
            movimentacao.id = int.Parse(idMovimento);
            var strSql = $"DELETE FROM movimentacao WHERE `movimentacao`.`id` = {movimentacao.id}";
            try
            {
                controlers.auxControler.EscreverDb(strSql);
                MessageBox.Show("Movimentação excluída");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
