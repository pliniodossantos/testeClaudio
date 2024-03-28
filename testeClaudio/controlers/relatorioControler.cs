using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeClaudio.model;

namespace testeClaudio.controlers
{
    internal class relatorioControler
    {
        public static int CountImportacao()
        {
            int contagem = 0;
            var strSql = "SELECT COUNT(*) FROM conteiner WHERE categoria = 'Importação'";
            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
                while (reader.Read())
                {
                    contagem = reader.GetInt32(0);
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return contagem;
        }
        public static int CountExportacao()
        {
            int contagem = 0;
            var strSql = "SELECT COUNT(*) FROM conteiner WHERE categoria = 'Exportacao'";
            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
                while (reader.Read())
                {
                    contagem = reader.GetInt32(0);
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return contagem;
        }
        public static List<Cliente> SelecClienteEId()
        {
            List<Cliente> lista = new List<Cliente>();
            var strSql = "SELECT `id_cliente`, `cliente` FROM `clientes`";
            try
            {
                var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
                while (reader.Read())
                {
                    lista.Add(new Cliente
                    {
                        id_cliente = reader.GetInt32(0),
                        cliente = reader.GetString(1)
                    });

                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lista;
        }

        public static List<Movimentacao>RetornarInfoGrid(string movimentacao, string receberArrayId)
        {
            List<Movimentacao> listaRetorno = new List<Movimentacao>();
            var strSql = $"SELECT id, tipoMovimentacao, DATE_FORMAT(dataInicio, '%Y-%c-%d %H:%i:%s' ) AS 'dataInicio', DATE_FORMAT(dataFim, '%Y-%c-%d %H:%i:%s' ) AS 'dataFim', idConteiner, idCliente FROM `movimentacao` WHERE `tipoMovimentacao` LIKE '{movimentacao}' AND `idCliente` = {receberArrayId}";
            try
            {   var db = controlers.auxControler.LerDb(strSql);
                var reader = db.Item1;
                var conexao = db.Item2;
                while (reader.Read())
                {
                    listaRetorno.Add(new Movimentacao
                    {
                        id = reader.GetInt32(0),
                        tipoMovimentacao = reader.GetString(1),
                        dataInicio = reader.GetString(2),
                        dataFim = reader.GetString(3),
                        idConteiner = reader.GetInt32(4),
                        idCliente = reader.GetInt32(5)
                    });;

                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listaRetorno;
        }
    }
}
